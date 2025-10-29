using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vecka_6___Advanced_Collections___LINQ
{
    internal class Books
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public double Price { get; set; }
        public List<string> Genres { get; set; }
        public bool Published { get; set; }
    }
}
