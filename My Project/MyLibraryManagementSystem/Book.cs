using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibraryManagementSystem
{
    internal class Book
    {
            public int Id { get; set; }
            public string Title { get; set; }
            public int AuthorId { get; set; }
            public int StatusId { get; set; }
            public string AuthorName { get; set; }
            public string StatusName { get; set; }
            public byte[] ImageData { get; set; }

    }
}
