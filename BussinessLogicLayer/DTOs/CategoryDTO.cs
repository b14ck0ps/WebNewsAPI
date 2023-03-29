using System.ComponentModel.DataAnnotations;

namespace BussinessLogicLayer.DTOs
{
    public class CategoryDTO
    {
        [Key] public int Id { get; set; }
        public string Name { get; set; }
    }
}