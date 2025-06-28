using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;//to use the File to transform image to var binary
using System.Diagnostics.CodeAnalysis;
using System.Windows.Forms.VisualStyles;
namespace MyLibraryManagementSystem
{
    public partial class AddBooks : UserControl
    {
        public AddBooks()
        {
            InitializeComponent();
            //fill combo box status
            cbStatus.Items.Add("Available");
            cbStatus.Items.Add("Not Available");
            //fill grid view
            ShowDataBooks();
            SetReadOnlyColumns();

        }

        //dataset
        LibraryDataSet library=new LibraryDataSet();
        //creating adapters
        LibraryDataSetTableAdapters.BookTableAdapter book =new LibraryDataSetTableAdapters.BookTableAdapter();
        LibraryDataSetTableAdapters.CategoryTableAdapter category =  new LibraryDataSetTableAdapters.CategoryTableAdapter();
        LibraryDataSetTableAdapters.AuthorTableAdapter author= new LibraryDataSetTableAdapters.AuthorTableAdapter();
        //binding source
        BindingSource bookBs=new BindingSource();
        //taking picture directory and adding it to picture box
        String imageDirectory = "";
        int authorId;
        int category_id;
        private void btnImport_Click(object sender, EventArgs e)
        {
           
            try{
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Filter = "Image Files|*.jpg;*.png";
                if(openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    imageDirectory=openFileDialog.FileName;
                    pictreBook.ImageLocation= imageDirectory;
                }

            }
            catch (Exception ex)
            {
                ErrorWarning error = new ErrorWarning("Some inexpected error occured!\r\n" +
                    "check image format!");
                error.Show();
            }
        }
       
        //function that adds books
        public void addBooks()
        {
           
            //filling the library Book table using the book adapter
            book.Fill(library.Book);
            bool BookExist = false;
            //check if book already exists by title
            foreach (DataRow r in library.Book)
            {
                if (r["title"].ToString().ToLower().Equals(txtBook.Text.ToLower()))
                {
                    ErrorWarning error = new ErrorWarning(r["title"].ToString()+" already exists!"+
                        "if you want to update proceed to update button");
                    error.Show();
                    BookExist= true;
                    break;
                }
            } //end of foreach

            if (!BookExist)
            {
                //whether it is available or not yet admin can change it in update
                int status = 1;
                if(cbStatus.SelectedIndex == 1) {
                    status = 2;
                }
                //image to varbinary
                byte[] imageBytes = File.ReadAllBytes(imageDirectory);
                //adding author
                addBookAuthor();
                //adding category
                addCategory();
                /*add book*/
                book.Insert(txtBook.Text, int.Parse(txtQtt.Text),imageBytes,category_id,status,authorId);
                InformationMsgForm registered = new InformationMsgForm("Book Added Succesfully!");
                registered.Show();
                library.AcceptChanges();
               
            }
            ShowDataBooks();
        }
        //add the author of the book if not exist it will add author also to author table too
        public void addBookAuthor()
        {
            // Author adapter 
            author.Fill(library.Author);

            bool authorExist = false;
            foreach (DataRow r in library.Author)
            {
                if (r["author"].ToString().ToLower().Equals(txtAuthor.Text.ToLower()))
                {
                    authorId = int.Parse(r["id"].ToString());
                    authorExist = true;
                    break;
                }
            }

            if (!authorExist)
            {
                // Insert the new author
                author.Insert(txtAuthor.Text);

                // Re-fetch the Author table to get the new ID
                author.Fill(library.Author);

                // Get the ID of the author we just added
                foreach (DataRow r in library.Author)
                {
                    if (r["author"].ToString().ToLower().Equals(txtAuthor.Text.ToLower()))
                    {
                        authorId = int.Parse(r["id"].ToString());
                        break;
                    }
                }
            }
          
        }
        //add thecategory of the book if not exist it will add category also to category table too
        public void addCategory()
        {
         
            //filling the library Category table using the category adapter
            category.Fill(library.Category);

            bool categExist = false;
            foreach (DataRow r in library.Category)
            {
                if (r["category"].ToString().ToLower().Equals(txtCategory.Text.ToLower()))
                {
                    category_id = int.Parse(r["id"].ToString());
                    categExist = true;
                    break;
                }
            }

            if (!categExist)
            {
                // Insert the new author
                category.Insert(txtCategory.Text);

                // Re-fetch the Author table to get the new ID
                category.Fill(library.Category);

                // Get the ID of the author we just added
                foreach (DataRow r in library.Category)
                {
                    if (r["category"].ToString().ToLower().Equals(txtCategory.Text.ToLower()))
                    {
                        category_id = int.Parse(r["id"].ToString());
                        break;
                    }
                }
            }

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
           
            if (pictreBook.Image==null
                || txtBook.Text==""
                || txtAuthor.Text==""
                || txtQtt.Text==""
                || txtCategory.Text==""
                || cbStatus.SelectedIndex== -1)
            {
                ErrorWarning error = new ErrorWarning("Please Fill all Blank feilds");
                error.Show();
            }
            else
            {
                //everything entered properly
                addBooks();  
            }
                
        }

        //to avoid users writing text in Quantity
        private void txtQtt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsDigit(e.KeyChar) && e.KeyChar!=(char)Keys.Back) {
            e.Handled = true;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
            InformationMsgForm msgForm = new InformationMsgForm("Cleared Succesfully!");
            msgForm.Show();

        }
        public void Clear()
        {
            pictreBook.Image = null;
            txtBook.Clear();
            txtAuthor.Clear();
            txtQtt.Clear();
            txtCategory.Clear();
            cbStatus.SelectedIndex = -1;
        }
        private void SetReadOnlyColumns()
        {
            // Set specific columns as read-only
            dataGridViewBook.Columns["id"].ReadOnly = true;
            dataGridViewBook.Columns["title"].ReadOnly = false;
            dataGridViewBook.Columns["quantity"].ReadOnly = true;
            dataGridViewBook.Columns["cover"].ReadOnly = true;
            dataGridViewBook.Columns["category_id"].ReadOnly = true;
            dataGridViewBook.Columns["status_id"].ReadOnly = true;
            dataGridViewBook.Columns["author_id"].ReadOnly = true;
        }

        public void ShowDataBooks()
        {
            book.Fill(library.Book);
            library.AcceptChanges();
            dataGridViewBook.DataSource =library.Book;
            bookBs.DataSource=library.Book;
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewBook.SelectedRows.Count == 0)
            {
                ErrorWarning errorWarning = new ErrorWarning("Please Select a Row To be deleted!");
                errorWarning.Show();
            }
            else
            {
                try
                {
                    foreach (DataGridViewRow row in dataGridViewBook.SelectedRows)
                    {
                        int id = Convert.ToInt32(row.Cells["id"].Value);
                        int quantity = Convert.ToInt32(row.Cells["quantity"].Value);
                        int cat_id = Convert.ToInt32(row.Cells["category_id"].Value);
                        int stat_id = Convert.ToInt32(row.Cells["status_id"].Value);
                        int auth_id = Convert.ToInt32(row.Cells["author_id"].Value);
                        book.Delete(id, quantity, cat_id, stat_id, auth_id);
                        book.Fill(library.Book);
                        InformationMsgForm info = new InformationMsgForm("Delete succesful!");
                        info.Show();
                    }
                }catch(Exception ex)
                {
                    ErrorWarning error = new ErrorWarning("Error during deletion: " + ex.Message);
                    error.Show();
                }
            }
        }

        public void UpdateBookDetails()
        {
            // Filling the library Book table using the book adapter
            book.Fill(library.Book);

            bool bookExist = false;
            DataRow bookRow = null;

            // Check if book already exists by title
            foreach (DataRow r in library.Book)
            {
                if (r["title"].ToString().ToLower().Equals(txtBook.Text.ToLower()))
                {
                    bookExist = true;
                    bookRow = r;
                    break;
                }
            }

            if (!bookExist)
            {
                ErrorWarning error = new ErrorWarning(txtBook.Text + " does not exist. Please add it first!");
                error.Show();
            }
            else
            {
                // Update book details
                if (bookRow != null)
                {
                    addCategory();
                    addBookAuthor();
                    int status = 1;
                    if (cbStatus.SelectedIndex == 1)
                    {
                        status = 2;
                    }
                    bookRow["quantity"] = int.Parse(txtQtt.Text);
                    bookRow["category_id"] = category_id;
                    bookRow["status_id"] = status;
                    bookRow["author_id"] = authorId;
                    // Convert image to varbinary if there's a new image
                    if (!string.IsNullOrEmpty(imageDirectory))
                    {
                        bookRow["cover"] = File.ReadAllBytes(imageDirectory);
                    }

                    // Save the changes to the database
                    book.Update(library.Book);
                    library.AcceptChanges();
                    InformationMsgForm info = new InformationMsgForm("Book Data Updated Successfully!");
                    info.Show();
                }
            }
            
        }

       
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (pictreBook.Image == null
               || txtBook.Text == ""
               || txtAuthor.Text == ""
               || txtQtt.Text == ""
               || txtCategory.Text == ""
               || cbStatus.SelectedIndex == -1)
            {
                ErrorWarning error = new ErrorWarning("Please Fill all Blank feilds");
                error.Show();
            }
            else
            {
                //everything entered properly
                UpdateBookDetails();
            }
            bookBs.Filter = "title like '%" + txtBook.Text + "%'";
            dataGridViewBook.Refresh();

        }
    }
}
