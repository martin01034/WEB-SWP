using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Betting_System.Entities
{
    public class OpponentPerBet
    {
        [Key]
        public int? Key { get; set; }

        [Required]
        public int BetId { get; set; }
        [Required]
        public int OponentId { get; set; }
        [Required]
        public int Quote { get; set; }


        public virtual Opponent Opponent { get; set; }
        public virtual Bet Bet { get; set; }
    }
}
