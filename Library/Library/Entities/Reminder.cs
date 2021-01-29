using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Library.Entities
{
    public class Reminder
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public DateTime RemindDate { get; set; }

        [Required]
        public double RemindFee { get; set; }

        [Required]
        public int BorrowId { get; set; }

        public virtual Borrow Borrow { get; set; }
    }
}
