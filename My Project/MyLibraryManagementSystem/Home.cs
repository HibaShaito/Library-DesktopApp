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
using static MyLibraryManagementSystem.LibraryDataSet;

namespace MyLibraryManagementSystem
{
    public partial class Home : UserControl
    {
        private LibraryDataSet.BookDataTable bookDataTable;
        private LibraryDataSetTableAdapters.BookTableAdapter bookTableAdapter;
        private LibraryDataSetTableAdapters.Check_outTableAdapter checkOutTableAdapter;
        private LibraryDataSet.Check_outDataTable checkOutDataTable;
        private int issuedBooksCount = 0;
        private int returnedBooksCount = 0;
        public Home()
            {
                InitializeComponent();

                // Initialize table adapter and data table
                bookTableAdapter = new LibraryDataSetTableAdapters.BookTableAdapter();
                bookDataTable = new LibraryDataSet.BookDataTable();

                // Start with initial display of total quantity
                UpdateBookQuantity();

                // Initialize table adapter and data table for check_out table
                checkOutTableAdapter = new LibraryDataSetTableAdapters.Check_outTableAdapter();
                checkOutDataTable = new LibraryDataSet.Check_outDataTable();

                // Start with initial display of issued and returned books count
                UpdateIssuedAndReturnedBooks();

                // Set up a timer to periodically update the displayed quantity ( every 5 seconds)
                Timer timer = new Timer();
                timer.Interval = 5000; // 5000 milliseconds = 5 seconds
                timer.Tick += Timer_Tick;
                timer.Start();
            }

            private void Timer_Tick(object sender, EventArgs e)
            {
                // Update the displayed book quantity periodically
                UpdateBookQuantity();
                // Update the displayed issued and returned books counts periodically
                UpdateIssuedAndReturnedBooks();
        }

            private void UpdateBookQuantity()
            {
                // Clear the DataTable and fill it with updated data from database
                bookDataTable.Clear();
                bookTableAdapter.Fill(bookDataTable);

                // Calculate total quantity of books
                int totalQuantity = 0;
                foreach (LibraryDataSet.BookRow row in bookDataTable.Rows)
                {
                    totalQuantity += row.quantity; // quantity is the column name in your book table
                }

                // Display the total quantity in a label
                AvailableBooksNumber.Text = totalQuantity.ToString();
            }
        private void UpdateIssuedAndReturnedBooks()
        {
            // Clear the DataTable and fill it with updated data from check_out table
            checkOutDataTable.Clear();
            checkOutTableAdapter.Fill(checkOutDataTable);

            // Reset counts
            issuedBooksCount = 0;
            returnedBooksCount = 0;

            // Calculate counts based on is_returned attribute
            foreach (LibraryDataSet.Check_outRow row in checkOutDataTable.Rows)
            {
                if (row.is_returned == false) //is_returned is a boolean indicating return status
                {
                    issuedBooksCount += Convert.ToInt32(row["Quantity_Borrowed"]);
                }
                else
                {
                    returnedBooksCount += Convert.ToInt32(row["Quantity_Borrowed"]);
                }
            }

            // Display the counts in labels
            IssuedBooksNumber.Text = issuedBooksCount.ToString();
            ReturnedBooksNumber.Text =returnedBooksCount.ToString();
        }
    }
}

