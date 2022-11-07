using NewspaperSellerModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewspaperSellerSimulation
{
    class Server
    {

        public Server()
        {
            List<SimulationCase>  cases = new List<SimulationCase>();

            Random rand = new Random();
            int DemandOver = 0;
            int DaysUnsold = 0;

            Program.simulationSystem.PerformanceMeasures.TotalSalesProfit = 0;
            Program.simulationSystem.PerformanceMeasures.TotalLostProfit = 0;
            Program.simulationSystem.PerformanceMeasures.TotalNetProfit = 0;
            Program.simulationSystem.PerformanceMeasures.TotalScrapProfit = 0;
            Program.simulationSystem.PerformanceMeasures.TotalCost = (Program.simulationSystem.NumOfNewspapers * Program.simulationSystem.PurchasePrice) *
                Program.simulationSystem.NumOfRecords;
            for (int i = 0; i < Program.simulationSystem.NumOfRecords; i++)
            {
                SimulationCase simulationCase = new SimulationCase();
                simulationCase.DayNo = i + 1;
                simulationCase.RandomNewsDayType = rand.Next(1, 100);
                simulationCase.NewsDayType = DayType_Mapping(simulationCase.RandomNewsDayType);
                simulationCase.RandomDemand = rand.Next(1, 100);
                simulationCase.Demand = Demand_Mapping(simulationCase.RandomDemand, simulationCase.NewsDayType);
                simulationCase.DailyCost = Program.simulationSystem.NumOfNewspapers * Program.simulationSystem.PurchasePrice;


                if (simulationCase.Demand >= Program.simulationSystem.NumOfNewspapers)
                {
                    simulationCase.SalesProfit = Program.simulationSystem.NumOfNewspapers * Program.simulationSystem.SellingPrice;

                    simulationCase.LostProfit = (simulationCase.Demand - Program.simulationSystem.NumOfNewspapers)
                           * (Program.simulationSystem.SellingPrice - Program.simulationSystem.PurchasePrice);

                    simulationCase.DailyNetProfit = simulationCase.SalesProfit - simulationCase.DailyCost - simulationCase.LostProfit;

                    if (simulationCase.LostProfit != 0) 
                        DemandOver++;
                }

                else
                {
                    simulationCase.SalesProfit = simulationCase.Demand * Program.simulationSystem.SellingPrice;

                    simulationCase.ScrapProfit = (Program.simulationSystem.NumOfNewspapers - simulationCase.Demand)
                         * Program.simulationSystem.ScrapPrice;

                    simulationCase.DailyNetProfit = simulationCase.SalesProfit - simulationCase.DailyCost + simulationCase.ScrapProfit;
                   
                    if (simulationCase.ScrapProfit != 0) DaysUnsold++;
                }


                Program.simulationSystem.PerformanceMeasures.TotalSalesProfit += simulationCase.SalesProfit;
                Program.simulationSystem.PerformanceMeasures.TotalNetProfit += simulationCase.DailyNetProfit;
                Program.simulationSystem.PerformanceMeasures.TotalScrapProfit += simulationCase.ScrapProfit;
                Program.simulationSystem.PerformanceMeasures.TotalLostProfit += simulationCase.LostProfit;

                cases.Add(simulationCase);
            }

            Program.simulationSystem.PerformanceMeasures.DaysWithMoreDemand = DemandOver;
            Program.simulationSystem.PerformanceMeasures.DaysWithUnsoldPapers = DaysUnsold;


            Program.simulationSystem.SimulationTable = cases;


        }


        public Enums.DayType DayType_Mapping(int rand)
        {

            List<DayTypeDistribution> DayTypeDistributions = Program.simulationSystem.DayTypeDistributions;

            foreach (DayTypeDistribution day in DayTypeDistributions)
            {
                if (rand >= day.MinRange && rand <= day.MaxRange)
                    return day.DayType;
            }

            return Enums.DayType.Good;

        }

        public int Demand_Mapping(int rand, Enums.DayType type)
        {
            foreach (DemandDistribution Demand in Program.simulationSystem.DemandDistributions)
            {
                if (type == Enums.DayType.Good)
                {
                    if (rand >= Demand.DayTypeDistributions[0].MinRange &&
                        rand <= Demand.DayTypeDistributions[0].MaxRange)
                    {
                        return Demand.Demand;
                    }

                }
                else if (type == Enums.DayType.Fair)
                {
                    if (rand >= Demand.DayTypeDistributions[1].MinRange &&
                        rand <= Demand.DayTypeDistributions[1].MaxRange)
                    {
                        return Demand.Demand;
                    }

                }
                else if (type == Enums.DayType.Poor)
                {
                    if (rand >= Demand.DayTypeDistributions[2].MinRange &&
                        rand <= Demand.DayTypeDistributions[2].MaxRange)
                    {
                        return Demand.Demand;
                    }

                }
            }

            return 0;

        }

    }
}
