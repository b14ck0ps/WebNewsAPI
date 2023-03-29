using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace DatabaseAceesLayer.Models
{
    public class News
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Description { get; set; }
        public int Cid { get; set; }
        public DateTime Date { get; set; }
        [ForeignKey("Cid")]
        public virtual Category Category { get; set; }
    }
}
