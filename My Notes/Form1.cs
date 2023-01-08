using My_Notes.Model;
using System.Net.NetworkInformation;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Microsoft.EntityFrameworkCore;

namespace My_Notes;

public partial class Form1 : Form
{
    private static  NotesContext notesContext = new NotesContext();
    private static List<Note> notes = notesContext.Notes.ToList();

    private static List<Category> categories = notesContext.Categories.ToList();
    BindingSource nbs = new BindingSource();
    BindingSource cbc = new BindingSource();

    public void refreshDGV()
    {
        dataGridView1.DataSource = null;

        nbs.DataSource = notes.Select(
            o => new {
                Date = o.Created,
                Title = o.Title,
                Category = o.CategoryID.CategoryName
            }).ToList();

        dataGridView1.DataSource = nbs;
        dataGridView1.Refresh();
    }

    public Form1()
    {
        InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {
        cbc.DataSource = categories.Select(o => o.CategoryName).ToList();

        nbs.DataSource = notes.Select(
            o => new {
                Date = o.Created,
                Title = o.Title,
                Category = o.CategoryID.CategoryName,
            }).ToList();

        dtp.Value = new DateTime(2001, 1, 19);
        dtp.CustomFormat = " ";
        dtp.Format = DateTimePickerFormat.Custom;

        dataGridView1.DataSource = nbs;
        CategoryBox.DataSource = cbc;
        CBox.DataSource = cbc;
        OldCategoryBox.DataSource = cbc;


    }

    private void AddButton_Click(object sender, EventArgs e)
    {
        string title = TitleBox.Text;
        DateTime date = DateTime.Now.Date;
        String categoryName = (string)CategoryBox.SelectedItem;
        String content = ContentBox.Text;
        Category category = notesContext.Categories.
            Select(o => o)
            .Where(o => o.CategoryName == categoryName).First();

        Note note = new Note { Title = title, Content = content, Created = date, CategoryID = category };

        notes.Add(note);
        notesContext.Notes.Add(note);
        notesContext.SaveChanges();
        dataGridView1.DataSource = null;

        nbs.DataSource = notes.Select(
            o => new {
                Date = o.Created,
                Title = o.Title,
                Category = o.CategoryID.CategoryName
            }).ToList();

        dataGridView1.DataSource = nbs;
        dataGridView1.Refresh();
        ResetAll();
    }

    private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {

    }

    private void dtp_ValueChanged(object sender, EventArgs e)
    {
        dtp.CustomFormat = "dd/MM/yyyy";
    }


    private void SearchButton_Click(object sender, EventArgs e)
    {
        string searchTitle = SearchBox.Text;


        DateTime tdt = new DateTime(2001, 1, 19);

        DateTime dt = dtp.Value.Date;

        if(tdt.Equals(dt) && searchTitle == " ") {
            MessageBox.Show("Cannot Search for an empty value");
        }
       
        else if(dt == tdt)
        {
            var searchResults = notes.Select(
            o => new {
                Date = o.Created,
                Title = o.Title,
                Category = o.CategoryID.CategoryName
            }).Where(o => o.Title == searchTitle).ToList();

            nbs.DataSource = searchResults;
        }
        
        else if (searchTitle == default(string))
        {
            var searchResults = notes.Select(
            o => new {
                Date = o.Created,
                Title = o.Title,
                Category = o.CategoryID.CategoryName
            }).Where(o => o.Date == dt ).ToList();

            nbs.DataSource = searchResults;
        }

        dataGridView1.DataSource = null;
        dataGridView1.DataSource = nbs;
        dataGridView1.Refresh();
    }

    private void ViewButton_Click(object sender, EventArgs e)
    {
        int selectedrowindex = dataGridView1.SelectedCells[0].RowIndex;
        DataGridViewRow selectedRow = dataGridView1.Rows[selectedrowindex];
        var SelectedValues = new { 
            title = selectedRow.Cells["Title"].Value, 
            date = selectedRow.Cells["Date"].Value };

        var content = notes.Select(o => o).Where(o => o.Title == (string)SelectedValues.title && o.Created == (DateTime)SelectedValues.date).First();
        var selectedContet = content.Content;

        MessageBox.Show($"{selectedContet}");
    }


    private void AddCategory_Click(object sender, EventArgs e)
    {
        string name = AddCategoryText.Text;
        cbc.Add(name);
        notesContext.Categories.Add(new Category { CategoryName = name});
        notesContext.SaveChanges();

        ResetAll();
    }

    private void DeleteCategory_Click(object sender, EventArgs e)
    {
     
        string categoryName = (string)CBox.SelectedItem;

        Category category = notesContext.Categories.
         Select(o => o)
        .Where(o => o.CategoryName == categoryName).First();

        var filteredNote = notesContext.Notes.Select(o => o).Where(o => o.CategoryID == category);

        foreach(var noteItem in filteredNote)
        {
            nbs.Remove(noteItem);
            notes.Remove(noteItem);
            notesContext.Entry(noteItem).State = EntityState.Deleted;
            notesContext.Notes.Remove(noteItem);
        }
        
        notesContext.Entry(category).State = EntityState.Deleted;
        notesContext.Categories.Remove(category);
        categories.Remove(category);
        cbc.Remove(category);
        notesContext.SaveChanges();
        cbc.DataSource = categories.Select(o => o.CategoryName).ToList();
        dataGridView1.DataSource = null;

        nbs.DataSource = notes.Select(
            o => new {
                Date = o.Created,
                Title = o.Title,
                Category = o.CategoryID.CategoryName
            }).ToList();

        dataGridView1.DataSource = nbs;
        dataGridView1.Refresh();

    }

    private void DeleteNote_Click(object sender, EventArgs e)
    {
        int selectedrowindex = dataGridView1.SelectedCells[0].RowIndex;
        DataGridViewRow selectedRow = dataGridView1.Rows[selectedrowindex];
        var SelectedValues = new
        {
            title = selectedRow.Cells["Title"].Value,
            date = selectedRow.Cells["Date"].Value
        };
        var item = notes.Select(o => o).Where(o => o.Title == (string)SelectedValues.title && o.Created == (DateTime)SelectedValues.date).First();

        notesContext.Entry(item).State = EntityState.Deleted;
        notes.Remove(item);
        notesContext.SaveChanges();

        dataGridView1.DataSource = null;
        nbs.DataSource = notes.Select(
            o => new {
                Date = o.Created,
                Title = o.Title,
                Category = o.CategoryID.CategoryName
            }).ToList();

        dataGridView1.DataSource = nbs;
        dataGridView1.Update();
        dataGridView1.Refresh();

    }

    private void ResetButton_Click_1(object sender, EventArgs e)
    {
        ResetAll();


    }

    public void ResetAll()
    {
        SearchBox.Text = default(string);
        TitleBox.Text = default(string);
        dtp.CustomFormat = default(string);
        CategoryBox.Text = default(string);
        AddCategoryText.Text = default(string);
        ContentBox.Text = default(string);
        NewCategoryTextBox.Text = default(string);

        dtp.Value = new DateTime(2001, 1, 19);
        dtp.CustomFormat = " ";
        dtp.Format = DateTimePickerFormat.Custom;
        dataGridView1.DataSource = null;

        nbs.DataSource = notes.Select(
            o => new {
                Date = o.Created,
                Title = o.Title,
                Category = o.CategoryID.CategoryName
            }).ToList();

        dataGridView1.DataSource = nbs;
        dataGridView1.Refresh();
    }

    private void label7_Click(object sender, EventArgs e)
    {

    }

    private void EditButton_Click(object sender, EventArgs e)
    {
        string oldCategory = (string)OldCategoryBox.SelectedItem;
        string newCategory = NewCategoryTextBox.Text;

        Category category = notesContext.Categories.
        Select(o => o)
       .Where(o => o.CategoryName == oldCategory).First();


        category.CategoryName = newCategory;
        cbc.Remove(oldCategory);
        cbc.Add(newCategory);

        
        notesContext.Entry(category).State = EntityState.Modified;
        notesContext.SaveChanges();

        dataGridView1.DataSource = null;

        nbs.DataSource = notes.Select(
            o => new {
                Date = o.Created,
                Title = o.Title,
                Category = o.CategoryID.CategoryName
            }).ToList();

        dataGridView1.DataSource = nbs;
        dataGridView1.Refresh();
        ResetAll();


    }
}