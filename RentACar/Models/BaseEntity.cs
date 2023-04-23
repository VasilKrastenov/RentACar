using System.ComponentModel.DataAnnotations;

namespace RentACar.Models
{
    public abstract class BaseEntity
    {
        [Key]
        public int Id { get; set; }
    }
}
