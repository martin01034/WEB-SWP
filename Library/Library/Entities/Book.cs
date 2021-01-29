using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Library.Entities
{
    public partial class Book
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int InventoryNumber { get; set; }

        public string StoragePlace { get; set; }

        public DateTime BuyDate { get; set; }

        public double PurchasePrice { get; set; }

        public string Commentar { get; set; }

        public virtual IEnumerable<Borrow> Borrows { get; set; }

        public virtual BookData BookData { get; set; }


    }
}
