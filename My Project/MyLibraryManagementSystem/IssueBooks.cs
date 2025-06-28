using MyLibraryManagementSystem.LibraryDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyLibraryManagementSystem
{
    public partial class IssueBooks : UserControl
    {
        //binding source list to book
        private BindingList<Book> books = new BindingList<Book>();//array list of book class
        LibraryDataSet library = new LibraryDataSet();//library dataset
        //adaptors
        LibraryDataSetTableAdapters.BookTableAdapter book = new LibraryDataSetTableAdapters.BookTableAdapter();
        LibraryDataSetTableAdapters.UserTableAdapter email = new LibraryDataSetTableAdapters.UserTableAdapter();
        LibraryDataSetTableAdapters.Check_outTableAdapter check = new LibraryDataSetTableAdapters.Check_outTableAdapter();
        LibraryDataSetTableAdapters.AuthorTableAdapter author = new LibraryDataSetTableAdapters.AuthorTableAdapter();
        LibraryDataSetTableAdapters.StatusTableAdapter status = new LibraryDataSetTableAdapters.StatusTableAdapter();
       //binding source of checkout table
        BindingSource checkBS = new BindingSource();
        public IssueBooks()
        {
            InitializeComponent();
            fillComboEmail();//on form load the combo box of email will be filled
            fillComboBook();//on form load the combo box of email will be filled
            //an event that occurs when index is changed the following method happens
            cbBook.SelectedIndexChanged += CbBook_SelectedIndexChanged;
            cbEmail.SelectedIndexChanged += CbEmail_SelectedIndexChanged;
            // filling tables data 
            ShowData();
            //binding
            dataGridViewCheckOut.DataSource = library.Check_out;
            checkBS.DataSource = library.Check_out;
            //disable editing in grid view
            SetReadOnlyColumns();

        }
        //this will be used to Fill tables
        public void ShowData()
        {
            //filling tables
            check.Fill(library.Check_out);
            book.Fill(library.Book);
            email.Fill(library.User);
            author.Fill(library.Author);
            status.Fill(library.Status);
            library.AcceptChanges();
        }
        //Method disable user from editing the checkout details
        private void SetReadOnlyColumns()
        {
            // Set columns as read-only
            dataGridViewCheckOut.Columns["id"].ReadOnly = true;
            dataGridViewCheckOut.Columns["start_time"].ReadOnly = true;
            dataGridViewCheckOut.Columns["end_time"].ReadOnly = true;
            dataGridViewCheckOut.Columns["book_Id"].ReadOnly = true;
            dataGridViewCheckOut.Columns["user_id"].ReadOnly = true;
            dataGridViewCheckOut.Columns["is_returned"].ReadOnly = true;
            dataGridViewCheckOut.Columns["Quantity_Borrowed"].ReadOnly = true;
        }
       
        //function fills book combobox
        public void fillComboBook()
        {
            // Clear existing items
            cbBook.Items.Clear();
            books.Clear();
            //filling book table in case any changes ocurred to update it
            book.Fill(library.Book);
            // Fill books list
            DataTable bookData = book.GetData(); // GetData() retrieves all books
            foreach (DataRow row in bookData.Rows)
            {
                //creating the book that we will add to the Book List 
                //this way we saved its the data we want to use later
                //to be able to have book author and status rather than ids
                Book book = new Book
                {
                    Id = Convert.ToInt32(row["id"]),
                    Title = row["title"].ToString(),
                    AuthorId = Convert.ToInt32(row["author_id"]),
                    StatusId = Convert.ToInt32(row["status_id"]),
                    ImageData = row["cover"] as byte[]
                };
                //we added it to the booklist
                books.Add(book);
                //now we added the title to the combo box
                cbBook.Items.Add(book.Title);
                
            }
            
        }
        //when we select index in combo box book
        private void CbBook_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = cbBook.SelectedIndex;//the selected index
            //not -1 (nothing selected)
            if (selectedIndex >= 0)
            {
                // we are retrieving the book from the bookList based on index of combo 
                Book selectedBook = books[selectedIndex];

                // Get author name from author table based on author Id in selectedBook
                DataRow authorRow = author.GetData().Rows.Find(selectedBook.AuthorId);

                //if this is the first time we select the index of the book
                //if we found the author we take his name and add it to book
                if (authorRow != null)
                {
                    selectedBook.AuthorName = authorRow["author"].ToString();
                }

                // Get status name(same as when we got author name)
                DataRow statusRow = status.GetData().Rows.Find(selectedBook.StatusId);
                if (statusRow != null)
                {
                    selectedBook.StatusName = statusRow["status"].ToString();
                }

                // Display in text boxes
                txtAuthor.Text = selectedBook.AuthorName;
                txtStatus.Text = selectedBook.StatusName;

                // Update the PictureBox image
                if (selectedBook.ImageData != null && selectedBook.ImageData.Length > 0)
                {
                    using (var ms = new System.IO.MemoryStream(selectedBook.ImageData))
                    {
                        pictureBook.Image = Image.FromStream(ms);
                    }
                }
                else
                {
                    pictureBook.Image = null; // Clear the image if no data is present
                }
            }
        }

        //function fill emailbox
        public void fillComboEmail()
        {
            cbEmail.Items.Clear();//so that items are not double each time we call this method

            //filling the library Emails table using the category adapter
            email.Fill(library.User);
            foreach (DataRow r in library.User)
            {
                if (r["role_id"].ToString().Equals("2"))
                { //user
                    cbEmail.Items.Add(r["email"].ToString());//filling Book combobox
                }
            }
        }
        // Method to get user name by email
        private string GetUserByEmail(string email)
        {
            DataRow[] foundRows = library.User.Select($"email = '{email}'");
            if (foundRows.Length > 0)
            {
                return foundRows[0]["name"].ToString();
            }
            return null;
        }
        // Method to get user ID by email and name
        private int GetUserIdByEmailAndName(string email, string name)
        {
            DataRow[] foundRows = library.User.Select($"email = '{email}' AND name = '{name}'");
            if (foundRows.Length > 0)
            {
                return Convert.ToInt32(foundRows[0]["card_number"]);
            }
            return -1;
        }
        // Method to get book ID by title
        private int GetBookIdByTitle(string title)
        {
            DataRow[] foundRows = library.Book.Select($"title = '{title}'");
            if (foundRows.Length > 0)
            {
                return Convert.ToInt32(foundRows[0]["id"]);
            }
            return -1; // Not found
        }
        //changed idex in email combo
        private void CbEmail_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbEmail.SelectedItem != null)//if there is a selected item
            {
                string selectedEmail = cbEmail.SelectedItem.ToString();//the email
                string userName = GetUserByEmail(selectedEmail);//getting name using email

                if (!string.IsNullOrEmpty(userName))
                {
                    txtName.Text = userName;    
                }
            }
            else
            {
                txtName.Text = string.Empty; 
            }
        
        }
        
       
        // Update book quantity and status
        //if quantity turns to 0 the book will become unavailable
        //once returned the qtt will be added and it will turn back to be available
        private void UpdateBookQuantityAndStatus(int bookId, int quantityChange)
        {
            DataRow[] foundRows = library.Book.Select($"id = '{bookId}'");
            if (foundRows.Length > 0)
            {
                DataRow bookRow = foundRows[0];
                int newQuantity = Convert.ToInt32(bookRow["quantity"]) + quantityChange;
                bookRow["quantity"] = newQuantity;

                if (newQuantity <= 0)
                {
                    bookRow["status_id"] = 2; //2 is the ID for "Not Available"
                }
                else
                {
                    bookRow["status_id"] = 1; //  1 is the ID for "Available"
                }

                book.Update(bookRow); // Update the book record in the database
                book.Fill(library.Book);
            }
        }


        private void btnBorrow_Click(object sender, EventArgs e)
        {

            // Get selected email and book title
            if (cbEmail.SelectedIndex==-1 || cbBook.SelectedIndex==-1)
            {
                ErrorWarning error = new ErrorWarning("Please select a user and a book.");
                error.Show();
                return;
            }
            // Validate if the book status is available or not
            if (txtStatus.Text.ToLower().Equals("Not Available".ToLower()))
            {
                ErrorWarning error = new ErrorWarning("The Book is not Available Cannot be borrowed!");
                error.Show();
                return;
            }

            // Validate that start date is before return date
            if (dtpIssueDate.Value.Date == dtpReturnDAte.Value.Date )
            {
                ErrorWarning error=new ErrorWarning("Start date must be before return date.");  
                error.Show();
                return;
            }

            //selected email and book
            string selectedEmail = cbEmail.SelectedItem.ToString();
                string selectedBookTitle = cbBook.SelectedItem.ToString();

                // Get user ID and book ID
                int userId = GetUserIdByEmailAndName(selectedEmail,GetUserByEmail(selectedEmail));
                int bookId = GetBookIdByTitle(selectedBookTitle);

                if (userId == -1 || bookId == -1)
                {
                ErrorWarning error = new ErrorWarning("Invalid user or book.");
                error.Show();
                    return;
                }

                // Get the quantity to borrow
                int quantityToBorrow = (int)nudQtt.Value;

                // Check if there is enough quantity available
                DataRow[] bookRows = library.Book.Select($"id = {bookId}");
                if (bookRows.Length == 0 || Convert.ToInt32(bookRows[0]["quantity"]) < quantityToBorrow)
                {
                ErrorWarning error = new ErrorWarning("Not enough quantity available.");
                error.Show();
                    return;
                }

                // Insert new check-out record
                DataRow newCheckOutRow = library.Check_out.NewRow();
                newCheckOutRow["user_id"] = userId;
                newCheckOutRow["book_id"] = bookId;
                newCheckOutRow["start_time"] = dtpIssueDate.Value;
                newCheckOutRow["end_time"] = dtpReturnDAte.Value;
                newCheckOutRow["is_returned"] = 0;
                newCheckOutRow["Quantity_Borrowed"] = quantityToBorrow;
                library.Check_out.Rows.Add(newCheckOutRow);
                check.Update(library.Check_out); // Update the database

                // Update book quantity and status
                UpdateBookQuantityAndStatus(bookId, -quantityToBorrow);

                // Refresh the book combo box to reflect updated quantities and statuses
                fillComboBook();

                // Show success message
                InformationMsgForm information=new InformationMsgForm("Book borrowed successfully.");
                information.Show();
                Clear();
                
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // filling tables data 
            ShowData();
            books = new BindingList<Book>();
            fillComboEmail();
            fillComboBook();
            InformationMsgForm informationMsgForm = new InformationMsgForm("Data Updated Successfully!");
            informationMsgForm.Show();
            dataGridViewCheckOut.Refresh();
            Clear();
        }

       
        public void Clear()
        {
            // Reset the numeric up-down control
            nudQtt.Value = 1;

            // Clear book selection
            cbBook.SelectedIndex = -1;

            // Clear email selection
            cbEmail.SelectedIndex = -1;


            // Reset the date pickers to the current date
            dtpIssueDate.Value = DateTime.Now;
            dtpReturnDAte.Value = DateTime.Now;

            // Clear the PictureBox image
            pictureBook.Image = null;

            // Clear textboxes
            txtAuthor.Text = string.Empty;
            txtStatus.Text = string.Empty;
            txtName.Text = string.Empty;


        }



        private void cbBook_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}

