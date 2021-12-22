using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Book
    {
        public string Name;

        public string Writer;

        public int Pages;

        public Book(string Name, string Writer, int Pages)
        {
            this.Name = Name;
            this.Writer = Writer;
            this.Pages = Pages;
        }
    }
}
