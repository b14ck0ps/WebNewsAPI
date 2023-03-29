using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BussinessLogicLayer.DTOs
{
    public class NewsDTO
    {
        [Key] public int Id { get; set; }
        [Required] public string Title { get; set; }
        [Required] public string Description { get; set; }
        public int Cid { get; set; }
        public DateTime Date { get; set; }
        [ForeignKey("Cid")] public CategoryDTO Category { get; set; }
    }
}