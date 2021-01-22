using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Betting_System.Entities
{
    public partial class Bet
    {
        [Key]
        public int Id { get; set; }

        [Required, MaxLength(500)]
        public string Description { get; set; }

    }
}
