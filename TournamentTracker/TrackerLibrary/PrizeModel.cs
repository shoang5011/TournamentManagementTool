using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    public class PrizeModel
    {
        /// <summary>
        /// The unique identifier the the prize 
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// The numeric identifier for the place (2 for second place, etc)
        /// </summary>
        public int PlaceNumber { get; set; }
        /// <summary>
        /// the friendly name the the place (second place, first runner up, etc)
        /// </summary>
        public string PlaceName { get; set; }
        /// <summary>
        /// the fixed amount this place earns or zero if it is not used 
        /// </summary>
        public decimal PrizeAmount { get; set; }
        /// <summary>
        /// The number that represents the percentage of the overall take
        /// or zero if it is not used. The percentage is fraction of 1.
        /// </summary>
        public double PrizePercentage { get; set; }
    }
}
