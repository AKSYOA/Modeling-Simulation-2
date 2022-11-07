using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewspaperSellerModels
{
    public class DayTypeDistribution
    {
        public DayTypeDistribution()
        {

        }
     
        public DayTypeDistribution(decimal Probability, Enums.DayType DayType)
        {
            this.Probability = Probability;
            this.DayType = DayType;
            
        }

        public Enums.DayType DayType { get; set; }
        public decimal Probability { get; set; }
        public decimal CummProbability { get; set; }
        public int MinRange { get; set; }
        public int MaxRange { get; set; }
    }
}
