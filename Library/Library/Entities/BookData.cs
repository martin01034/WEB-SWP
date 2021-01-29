using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Library.Entities
{
    public partial class BookData
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int ISBN { get; set; }
        [Required]
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime MaxBorrowingDuration { get; set; }
        [Required]
        public float ReminderFees { get; set; }

        [Required]
        public string Author { get; set; }


        public virtual Publisher Publisher { get; set; }

    }
}
