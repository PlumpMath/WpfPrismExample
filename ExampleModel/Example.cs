using System.ComponentModel.DataAnnotations;

namespace ExampleModel
{
    public class Example
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(255)]
        public string Name { get; set; }
        [MaxLength(1023)]
        public string Description { get; set; }

        public int UserId { get; set; }

        public virtual User User { get; set; }

        [Timestamp]
        public byte[] RowVersion { get; set; }
    }
}
