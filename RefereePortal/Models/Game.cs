using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RefereePortal.Models
{
    public class Game
    {
        public int GameId { get; set; }

        public int RefereeId { get; set; }
        [Required]
        public DateTime Date { get; set; }
        [Required]
        public string Location { get; set; }

        [Required]
        public string Time { get; set; }

        // parent ref
        public Referee Referee { get; set; }
    }
}
