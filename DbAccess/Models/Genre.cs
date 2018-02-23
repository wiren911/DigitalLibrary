using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbAccess.Models
{
    public class Genre
    {
        public int GenreID { get; set; }
        public string GenreName { get; set; }
        public int BookID { get; set; }

        public virtual Book Books { get; set; }
    }
}
