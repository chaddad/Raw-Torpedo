using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RawTorpedo.Models
{
    public class Game
    {
        public int ID { get; set; }

        /// <summary>
        /// That's the name of the game!
        /// </summary>
        [Required]
        [Display(Name = "Game Name")]
        public string GameName { get; set; }

        /// <summary>
        /// List of publishers for the game
        /// </summary>
        public virtual ICollection<Support.Publisher> Publisher { get; set; }

        /// <summary>
        /// Date the game was published
        /// </summary>
        [Display(Name = "Published Date")]
        [DisplayFormat(DataFormatString = "{0:yyyy}", ApplyFormatInEditMode = true)]
        public DateTime PublishedDate { get; set; }
        
        /// <summary>
        /// Maximum number of players
        /// </summary>
        [Display(Name = "Maximum Number of Players")]
        public int MaxNumberOfPlayers { get; set; }

        /// <summary>
        /// Minimum number of players
        /// </summary>
        [Display(Name = "Minimum Number of Players")]
        public int MinNumberOfPlayers { get; set; }

        /// <summary>
        /// Sweet Spot for number of players, 0 = any number
        /// </summary>
        [Display(Name = "Best Played With")]
        public int SweetNumberOfPlayers { get; set; }

        /// <summary>
        /// Mechanics used by gameplay, such as dice rolling, trick taking, card drafting
        /// </summary>
        public virtual ICollection<Support.Mechanic> Mechanics { get; set; }

        /// <summary>
        /// Categories for organzing games, such as travel, space exploration, sci-fi
        /// </summary>
        public virtual ICollection<Support.Theme> Themes { get; set; }

        /// <summary>
        /// Used to relate expansions and their parent game
        /// </summary>
        [Display(Name = "Parent Game")]
        public virtual Game ParentGame { get; set; }

        /// <summary>
        /// Average game length
        /// </summary>
        [Display(Name = "Average Playtime")]
        public Domain.Enums.Playtime Playtime { get; set; }

        /// <summary>
        /// Designers of the game
        /// </summary>
        public virtual ICollection<Support.Designer> Designer { get; set; }

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
