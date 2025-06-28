using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace MyLibraryManagementSystem
{
    public partial class ReturnBooks : UserControl
    {
        LibraryDataSet library = new LibraryDataSet();//library dataset
        //adaptors
        LibraryDataSetTableAdapters.BookTableAdapter book = new LibraryDataSetTableAdapters.BookTableAdapter();
        LibraryDataSetTableAdapters.Check_outTableAdapter check = new LibraryDataSetTableAdapters.Check_outTableAdapter();
        LibraryDataSetTableAdapters.StatusTableAdapter status = new LibraryDataSetTableAdapters.StatusTableAdapter();
        //binding source of checkout table
        BindingSource checkBS = new BindingSource();
        public ReturnBooks()
        {
            InitializeComponent();
            ShowData();
            //binding
            dataGridViewCheckOut.DataSource = library.Check_out;
            checkBS.DataSource = library.Check_out;
            SetReadOnlyColumns();

        }
        //this will be used to Fill tables
        public void ShowData()
        {
            //filling tables
            check.Fill(library.Check_out);
            book.Fill(library.Book);
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

        private void btnReturn_Click(object sender, EventArgs e)
        {
            int id,borrowed_quantity, book_id;
            bool is_returned;

            if (dataGridViewCheckOut.SelectedRows.Count != 1)
            {
                ErrorWarning errorWarning = new ErrorWarning("Please Select 1 Row only To be Edited!");
                errorWarning.Show();
            }
            else
            {
                try
                {
                    foreach (DataGridViewRow row in dataGridViewCheckOut.SelectedRows)
                    {   
                        id= Convert.ToInt32(row.Cells["id"].Value);
                        borrowed_quantity = Convert.ToInt32(row.Cells["Quantity_Borrowed"].Value);
                        book_id = Convert.ToInt32(row.Cells["book_Id"].Value);
                        is_returned = Convert.ToBoolean(row.Cells["is_returned"].Value);

                        if (!is_returned)
                        {
                            // Mark the book as returned in the Check_out table (both GridView and database)
                            row.Cells["is_returned"].Value = true;
                            UpdateCheckOutTable(book_id,id);

                            // Update the quantity in the Book table
                            UpdateBookQuantity(book_id, borrowed_quantity);

                           

                            InformationMsgForm information = new InformationMsgForm("Returned Successfully!");
                            information.Show();
                        }
                        else
                        {
                            ErrorWarning errorWarning = new ErrorWarning("This book has already been returned!");
                            errorWarning.Show();
                        }
                    }
                }
                catch (Exception ex)
                {
                    ErrorWarning error = new ErrorWarning("Error during Updating: " + ex.Message);
                    error.Show();
                }
            }
        }

        private void UpdateCheckOutTable(int bookId,int id)
        {
            string connectionString = @"Server=DESKTOP-P2U6VKF\SQLEXPRESS;Database=Library;Trusted_Connection=True;";
            string updateQuery = "UPDATE Check_out SET is_returned = 1 WHERE book_Id = @book_id AND is_returned = 0 AND id=@id;";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(updateQuery, connection))
                    {
                        command.Parameters.AddWithValue("@book_id", bookId);
                        command.Parameters.AddWithValue("@id", id);
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                ErrorWarning error = new ErrorWarning("Error during Check_out Table Update: " + ex.Message);
                error.Show();
            }
        }

        private void UpdateBookQuantity(int bookId, int quantityBorrowed)
        {
            string connectionString = @"Server=DESKTOP-P2U6VKF\SQLEXPRESS;Database=Library;Trusted_Connection=True;";
            string updateQuery = "UPDATE Book SET quantity = quantity + @Quantity_Borrowed WHERE id = @book_id;";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(updateQuery, connection))
                    {
                        command.Parameters.AddWithValue("@Quantity_Borrowed", quantityBorrowed);
                        command.Parameters.AddWithValue("@book_id", bookId);
   
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                ErrorWarning error = new ErrorWarning("Error during Book Quantity Update: " + ex.Message);
                error.Show();
            }
        }

        private void RefreshGridView()
        {
            string connectionString = @"Server=DESKTOP-P2U6VKF\SQLEXPRESS;Database=Library;Trusted_Connection=True;";
            string query = "SELECT * FROM Check_out"; // Adjust the query as needed

            try
            {
                // Clear the GridView
                dataGridViewCheckOut.DataSource = null;
                dataGridViewCheckOut.Refresh();

                // Retrieve data from the database
                DataTable dataTable = new DataTable();
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    connection.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    adapter.Fill(dataTable);
                }

                // Bind the retrieved data to the GridView
                dataGridViewCheckOut.DataSource = dataTable;
                dataGridViewCheckOut.Refresh();

                InformationMsgForm information = new InformationMsgForm("GridView refreshed successfully!");
                information.Show();
            }
            catch (Exception ex)
            {
                ErrorWarning error = new ErrorWarning("Error during GridView refresh: " + ex.Message);
                error.Show();
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshGridView();
        }


    }
    
}

   
      

