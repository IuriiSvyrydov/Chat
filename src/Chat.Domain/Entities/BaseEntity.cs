

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Chat.Domain.Entities
{
    public abstract class BaseEntity
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        [Timestamp]
        public byte[] TimeStamp { get; set; }

        public BaseEntity()
        {
            Id = Guid.NewGuid();
        }
    }
}
