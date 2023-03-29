using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DatabaseAceesLayer.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual List<News> News { get; set;}
    }
}
