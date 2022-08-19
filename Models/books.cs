using System;
namespace BookKeeping.Models
{
    public class books
    {
       
        
        public int BookID { get; set; }
        public string Title { get; set; }
        public decimal Price { get; set; }
        public string Genre { get; set; }
        public int Publishingyear { get; set; }
        public ICollection <Author> Authors { get; set; }

    }
 }
       
    
    


