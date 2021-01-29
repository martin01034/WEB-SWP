using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Library.Entities
{
    public class Borrow
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public DateTime BorrowDate { get; set; }

        public DateTime ReturnDate { get; set; }

        public string Commentar { get; set; }

        [Required]
        public int BookId { get; set; }
        [Required]
        public int CustomerId { get; set; }

        public virtual IEnumerable<Reminder> Reminders { get; set; }

        public virtual Book Book { get; set; }
        public virtual Customer Customer { get; set; }
    }
}
