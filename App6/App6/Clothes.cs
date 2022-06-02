using System;
using SQLite;
using System.Collections.Generic;
using System.Text;

namespace App6.Models
{
    public class Clothes
    {
        [PrimaryKey, AutoIncrement]
        public string Name { get; set; }
        public Gender GStyle { get; set; }
        public string Size { get; set; }
        public DateTime Date { get; set; }
        public string Colour { get; set; }
        public string Address { get; set; }
        public string Image { get; set; }
    }
}
