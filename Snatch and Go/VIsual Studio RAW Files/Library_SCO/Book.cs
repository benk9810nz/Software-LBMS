using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_SCO
{
    public class Book
    {
		public int Book_ID { get; set; }
		public decimal Book_Barcode { get; set; }
		public string Name { get; set; }
		public string Author { get; set; }
		public string RFID_Tag { get; set; }
		public int Age { get; set; }
		public string DueDate { get; set; }

		public Book ()
        {

        }

		public Book (int id)
        {
			this.Book_ID = -1;
        }
	}
}
