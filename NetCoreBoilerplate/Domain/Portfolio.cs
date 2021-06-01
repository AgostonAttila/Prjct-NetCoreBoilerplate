using System;

namespace Domain
{
    public class Portfolio
    {
        public string ISIN { get; set; }
        public decimal Piece { get; set; }
        public decimal Price { get; set; }
        public DateTime Date { get; set; }
        public string Memo { get; set; }
    }
}