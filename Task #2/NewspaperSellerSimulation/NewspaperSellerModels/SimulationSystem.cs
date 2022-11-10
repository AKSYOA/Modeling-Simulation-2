using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace NewspaperSellerModels
{
    public class SimulationSystem
    {
        public SimulationSystem()
        {
            this.DayTypeDistributions = new List<DayTypeDistribution>();
            this.DemandDistributions = new List<DemandDistribution>();
            this. SimulationTable = new List<SimulationCase>();
            this.PerformanceMeasures = new PerformanceMeasures();
        }
        ///////////// INPUTS /////////////
        public int NumOfNewspapers { get; set; }
        public int NumOfRecords { get; set; }
        public decimal PurchasePrice { get; set; }
        public decimal SellingPrice { get; set; }
        public decimal ScrapPrice { get; set; }
        public decimal UnitProfit { get; set; }
        public List<DayTypeDistribution> DayTypeDistributions { get; set; }
        public List<DemandDistribution> DemandDistributions { get; set; }

        ///////////// OUTPUTS /////////////
        public List<SimulationCase> SimulationTable { get; set; }
        public PerformanceMeasures PerformanceMeasures { get; set; }


        //Calculate Commulative Probability for Day Type .....
        public void calculateCummProbability_DayType()
        {
            for (int i = 0; i < DayTypeDistributions.Count; i++)
            {               
                if (i == 0)
                {
                    DayTypeDistributions[i].CummProbability = DayTypeDistributions[i].Probability;
                    DayTypeDistributions[i].MinRange = 1;
                }
                else
                {
                    DayTypeDistributions[i].CummProbability = DayTypeDistributions[i - 1].CummProbability + DayTypeDistributions[i].Probability;
                    DayTypeDistributions[i].MinRange = DayTypeDistributions[i - 1].MaxRange + 1;
                }
                DayTypeDistributions[i].MaxRange = Decimal.ToInt32(DayTypeDistributions[i].CummProbability * 100);
                //Console.WriteLine(DayTypeDistributions[i].CummProbability + " " + DayTypeDistributions[i].MinRange + " " + DayTypeDistributions[i].MaxRange);
            }
        }


        //Calculate Commulative Probability for Demand .....
        public void calculateCummProbability_Demand()
        {
           // Console.WriteLine("DemandDistributions.Count: " + DemandDistributions.Count);
           // Console.WriteLine("DayTypeDistributions.Count: " + DayTypeDistributions.Count);
            for (int i = 0; i < DemandDistributions.Count; i++)
            {
                for (int j = 0; j < DayTypeDistributions.Count; j++)
                {
                    if (i == 0)
                    {
                        DemandDistributions[i].DayTypeDistributions[j].CummProbability = DemandDistributions[i].DayTypeDistributions[j].Probability;
                        DemandDistributions[i].DayTypeDistributions[j].MinRange = 1;
                    }
                    else
                    {
                        DemandDistributions[i].DayTypeDistributions[j].CummProbability = DemandDistributions[i - 1].DayTypeDistributions[j].CummProbability + DemandDistributions[i].DayTypeDistributions[j].Probability;
                        DemandDistributions[i].DayTypeDistributions[j].MinRange = DemandDistributions[i - 1].DayTypeDistributions[j].MaxRange + 1;
                    }
                    if ((Decimal.ToInt32(DemandDistributions[i].DayTypeDistributions[j].CummProbability * 100)) > 100)
                        break;
                    DemandDistributions[i].DayTypeDistributions[j].MaxRange = Decimal.ToInt32(DemandDistributions[i].DayTypeDistributions[j].CummProbability * 100);
                    
                   // Console.WriteLine(DemandDistributions[i].DayTypeDistributions[j].CummProbability + " " + DemandDistributions[i].DayTypeDistributions[j].MinRange + "-" + DemandDistributions[i].DayTypeDistributions[j].MaxRange);
                } 
                //Console.WriteLine(DemandDistributions[i].DayTypeDistributions[0].CummProbability + " " + DemandDistributions[i].DayTypeDistributions[1].CummProbability + " " + DemandDistributions[i].DayTypeDistributions[2].CummProbability + "      " + DemandDistributions[i].DayTypeDistributions[0].MinRange + "-" + DemandDistributions[i].DayTypeDistributions[0].MaxRange + "   " +DemandDistributions[i].DayTypeDistributions[1].MinRange + "-" + DemandDistributions[i].DayTypeDistributions[1].MaxRange + "      " + DemandDistributions[i].DayTypeDistributions[2].MinRange + "-" + DemandDistributions[i].DayTypeDistributions[2].MaxRange);
            }
        }


        //Display Probability ......
        public void Disp()
        {
            for (int i = 0; i < DemandDistributions.Count; i++)
            {
                Console.WriteLine(DemandDistributions[i].DayTypeDistributions[0].Probability+ " " + DemandDistributions[i].DayTypeDistributions[1].Probability + " " + DemandDistributions[i].DayTypeDistributions[2].Probability);
            }
        }

    }


}
