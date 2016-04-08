using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RawTorpedo.Models
{
    public class Game
    {
        public int ID { get; set; }

        [Required]
        [Display(Name = "Game Name")]
        public string GameName { get; set; }

        public virtual Support.Publisher Publisher { get; set; }

        [Display(Name = "Published Date")]
        public DateTime PublishedDate { get; set; }

        [Display(Name = "Maximum Number of Players")]
        public int MaxNumberOfPlayers { get; set; }
        [Display(Name = "Minimum Number of Players")]
        public int MinNumberOfPlayers { get; set; }
        [Display(Name = "Best Played With")]
        public int SweetNumberOfPlayers { get; set; }

        /// <summary>
        /// Mechanics used by gameplay, such as dice rolling, trick taking, card drafting
        /// </summary>
        public virtual IEnumerable<Support.Mechanic> Mechanics { get; set; }

        /// <summary>
        /// Categories for organzing games, such as travel, space exploration, sci-fi
        /// </summary>
        public virtual IEnumerable<Support.Theme> Themes { get; set; }

        /// <summary>
        /// Used to relate expansions and their parent game
        /// </summary>
        public virtual Game ParentGame { get; set; }

        /// <summary>
        /// Average game length
        /// </summary>
        public Domain.Enums.Playtime Playtime { get; set; }

        /// <summary>
        /// Designers of the game
        /// </summary>
        public virtual IEnumerable<Support.Designer> Designer { get; set; }

        /// <summary>
        /// ID for the game on that big-ass website
        /// </summary>
        public int BGGID { get; set; }

        /// <summary>
        /// URL to the game on that big-ass website
        /// </summary>
        public string BGGUrl { get; set; }
    }
}
