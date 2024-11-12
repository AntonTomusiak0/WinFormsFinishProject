using System.Net.Http.Json;
using System.Text.Json.Serialization;
using static System.Reflection.Metadata.BlobBuilder;
using System.Xml;
using System.Text.Json;
using static WinFormsApp11.Form1;

namespace WinFormsApp11
{


    public partial class Form1 : Form
    {
        public class Book
        {
            public string Title { get; set; }
            public string Author { get; set; }
            public int Year { get; set; }
            public string Genre { get; set; }
            public int ViewCount { get; set; } = 0;
        }
        private List<Book> books = new List<Book>();
        public Form1()
        {
            InitializeComponent();
            LoadBooks();
            LoadBooksToList();
            LoadEditing();
        }
        private void SaveBooks()
        {
            string json = JsonSerializer.Serialize(books, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText("books.json", json);
        }
        private void LoadBooks()
        {
            if (File.Exists("books.json"))
            {
                try
                {
                    string json = File.ReadAllText("books.json");
                    books = JsonSerializer.Deserialize<List<Book>>(json) ?? new List<Book>();
                }
                catch (JsonException ex)
                {
                    MessageBox.Show("Load JSON file error! " + ex.Message, "Error to JSON file!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    books = new List<Book>();
                }
            }
            else
            {
                books = new List<Book>();
            }
        }
        private void AddBook()
        {
            if (string.IsNullOrWhiteSpace(NameBox.Text) ||
                string.IsNullOrWhiteSpace(AuthorBox.Text) ||
                string.IsNullOrWhiteSpace(YearBox.Text) ||
                string.IsNullOrWhiteSpace(GenreBox.Text))
            {
                MessageBox.Show("Error no all!", "Error no all line!" , MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!int.TryParse(YearBox.Text, out int year))
            {
                MessageBox.Show("Error year!", "Error year!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var newBook = new Book
            {
                Title = NameBox.Text,
                Author = AuthorBox.Text,
                Year = year,
                Genre = GenreBox.Text,
                ViewCount = 0
            };
            books.Add(newBook);
            SaveBooks();

            LoadBooksToList();
            LoadEditing();
            MessageBox.Show("Book add!", "Book add!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void LoadBooksToList()
        {
            listView1.Items.Clear();
            foreach (var book in books)
            {
                var listitem = new ListViewItem(book.Title);
                listitem.SubItems.Add(book.Author);
                listitem.SubItems.Add($"{book.Year}");
                listitem.SubItems.Add(book.Genre);
                listView1.Items.Add(listitem);
            }
        }
        private void AddButton_Click(object sender, EventArgs e)
        {
            AddBook();
            LoadBooksToList();
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void LoadSearchResultsToList(List<Book> searchResults)
        {
            listView2.Items.Clear();
            foreach (var book in searchResults)
            {
                var listitem = new ListViewItem(book.Title);
                listitem.SubItems.Add(book.Author);
                listitem.SubItems.Add($"{book.Year}");
                listitem.SubItems.Add(book.Genre);
                listView2.Items.Add(listitem);
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            string selectedCategory = comboBox2.SelectedItem.ToString();
            string searchText = textBox2.Text.ToLower();

            var filteredBooks = books.Where(book =>
            {
                switch (selectedCategory)
                {
                    case "Title":
                        return book.Title.ToLower().Contains(searchText);
                    case "Author":
                        return book.Author.ToLower().Contains(searchText);
                    case "Year":
                        return book.Year.ToString().Contains(searchText);
                    case "Genre":
                        return book.Genre.ToLower().Contains(searchText);
                    default:
                        return false;
                }
            }).ToList();

            foreach (var book in filteredBooks)
            {
                book.ViewCount++;
            }
            SaveBooks();
            LoadSearchResultsToList(filteredBooks);
        }
        private void LoadEditing()
        {
            listView3.Items.Clear();
            foreach (var book in books)
            {
                var listit = new ListViewItem(book.Title);
                listit.SubItems.Add(book.Author);
                listit.SubItems.Add($"{book.Year}");
                listit.SubItems.Add(book.Genre);
                listView3.Items.Add(listit);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (listView3.SelectedItems.Count == 0)
            {
                MessageBox.Show("Choose book!", "Book choose!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int selectedIndex = listView3.SelectedItems[0].Index;
            books.RemoveAt(selectedIndex);

            SaveBooks();
            LoadBooksToList();
            LoadEditing();
        }
        private void listView3_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (listView2.SelectedItems.Count == 0) return;
            var selectedItem = listView2.SelectedItems[0];
            int selectedIndex = selectedItem.Index;

            var selectedBook = books[selectedIndex];
            NameBox.Text = selectedBook.Title;
            AuthorBox.Text = selectedBook.Author;
            YearBox.Text = selectedBook.Year.ToString();
            GenreBox.Text = selectedBook.Genre;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (listView3.SelectedItems.Count == 0)
            {
                MessageBox.Show("Error no book!", "Error select book!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int selectedIndex = listView3.SelectedItems[0].Index;

            if (string.IsNullOrWhiteSpace(ChangeTitle.Text) ||
                string.IsNullOrWhiteSpace(ChangeAuthor.Text) ||
                string.IsNullOrWhiteSpace(ChangeYear.Text) ||
                string.IsNullOrWhiteSpace(ChangeGenre.Text))
            {
                MessageBox.Show("Error no all!", "Error no all line!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!int.TryParse(ChangeYear.Text, out int year))
            {
                MessageBox.Show("Year error!", "Error year!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            books[selectedIndex].Title = ChangeTitle.Text;
            books[selectedIndex].Author = ChangeAuthor.Text;
            books[selectedIndex].Year = year;
            books[selectedIndex].Genre = ChangeGenre.Text;

            SaveBooks();
            LoadBooksToList();
            LoadEditing();

            MessageBox.Show("Book edit!", "Edit book complete!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var popularBooks = books.OrderByDescending(book => book.ViewCount).ToList();

            listView2.Items.Clear();

            foreach (var book in popularBooks)
            {
                var listItem = new ListViewItem(book.Title);
                listItem.SubItems.Add(book.Author);
                listItem.SubItems.Add(book.Year.ToString());
                listItem.SubItems.Add(book.Genre);
                listItem.SubItems.Add(book.ViewCount.ToString());
                listView2.Items.Add(listItem);
            }
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "JSON file (*.json)|*.json";
                saveFileDialog.Title = "Save book";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string json = JsonSerializer.Serialize(books, new JsonSerializerOptions { WriteIndented = true });
                    File.WriteAllText(saveFileDialog.FileName, json);
                    MessageBox.Show("All book save!", "Book are save", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "JSON file (*.json)|*.json";
                openFileDialog.Title = "Load file";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        string json = File.ReadAllText(openFileDialog.FileName);
                        books = JsonSerializer.Deserialize<List<Book>>(json) ?? new List<Book>();
                        LoadBooksToList();
                        LoadEditing();
                        MessageBox.Show("Book load!", "Book are load", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (JsonException ex)
                    {
                        MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}