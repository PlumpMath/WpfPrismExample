using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ExampleModel
{
    public class User
    {
        public User()
        {
            Examples = new ObservableCollection<Example>();
        }

        [Key]
        public int Id { get; set; }
        [MaxLength(255)]
        public string Name { get; set; }
        [MaxLength(255)]
        [Required]
        [Index(IsUnique = true)]
        public string MailAddress { get; set; }
        [MaxLength(1023)]
        public string Description { get; set; }
        [Timestamp]
        public byte[] RowVersion { get; set; }

        public virtual ObservableCollection<Example> Examples { get; private set; }
    }
}