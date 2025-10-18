using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AV1_primjeri
{
    public class Book
    {
        private string author;
        private string title;
        private int numberOfPages;
        public string Author
        {
            get { return author; }
            set { this.author = value; }
        }
        public string Title
        {
            get { return title; }
            set { this.title = value; }
        }
        public int NumberOfPages
        {
            get => numberOfPages;
            set => numberOfPages = value;
        }
    }

}
