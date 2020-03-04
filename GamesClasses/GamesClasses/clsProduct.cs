using System;

namespace GamesClasses
{
    public class ClsProduct
    {
        public string ProductID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public float UnitPrice { get; set; }
        public bool OutOfStock { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string Genre { get; set; }
        public string Platform { get; set; }
    }
}