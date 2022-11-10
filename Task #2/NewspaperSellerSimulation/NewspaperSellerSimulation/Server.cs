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

        }


         SimulationSystem system = new SimulationSystem();

        public void MainFunction()
        {
            List<SimulationCase> cases = new List<SimulationCase>();

            Random rand = new Random();
            int DemandOver = 0;
            int DaysUnsold = 0;
            

            system.PerformanceMeasures.TotalSalesProfit = 0;
            system.PerformanceMeasures.TotalLostProfit = 0;
            system.PerformanceMeasures.TotalNetProfit = 0;
            system.PerformanceMeasures.TotalScrapProfit = 0;
            system.PerformanceMeasures.TotalCost = (system.NumOfNewspapers * system.PurchasePrice) * system.NumOfRecords;

            // calculateCummProbability_DayType();



            for (int i = 0; i < system.NumOfRecords; i++)
            {
                SimulationCase simulationCase = new SimulationCase();
                Console.WriteLine(simulationCase.DayNo = i + 1);
                Console.WriteLine(simulationCase.RandomNewsDayType = rand.Next(1, 100));
                Console.WriteLine(simulationCase.NewsDayType = DayType_Mapping(simulationCase.RandomNewsDayType));
                Console.WriteLine(simulationCase.RandomDemand = rand.Next(1, 100));
                Console.WriteLine(simulationCase.Demand = Demand_Mapping(simulationCase.RandomDemand, simulationCase.NewsDayType));
                Console.WriteLine(simulationCase.DailyCost = system.NumOfNewspapers * system.PurchasePrice);


                if (simulationCase.Demand >= system.NumOfNewspapers)
                {
                    Console.WriteLine(simulationCase.SalesProfit = system.NumOfNewspapers * system.SellingPrice);

                    Console.WriteLine(simulationCase.LostProfit = (simulationCase.Demand - system.NumOfNewspapers) * (system.SellingPrice - system.PurchasePrice));

                    Console.WriteLine(simulationCase.DailyNetProfit = simulationCase.SalesProfit - simulationCase.DailyCost - simulationCase.LostProfit);

                    if (simulationCase.LostProfit != 0)
                        DemandOver++;
                }

                else
                {
                    Console.WriteLine(simulationCase.SalesProfit = simulationCase.Demand * system.SellingPrice);

                    Console.WriteLine(simulationCase.ScrapProfit = (system.NumOfNewspapers - simulationCase.Demand) * system.ScrapPrice);

                    Console.WriteLine(simulationCase.DailyNetProfit = simulationCase.SalesProfit - simulationCase.DailyCost + simulationCase.ScrapProfit);

                    if (simulationCase.ScrapProfit != 0) DaysUnsold++;
                }


                Console.WriteLine(system.PerformanceMeasures.TotalSalesProfit += simulationCase.SalesProfit);
                Console.WriteLine(system.PerformanceMeasures.TotalNetProfit += simulationCase.DailyNetProfit);
                Console.WriteLine(system.PerformanceMeasures.TotalScrapProfit += simulationCase.ScrapProfit);
                Console.WriteLine(system.PerformanceMeasures.TotalLostProfit += simulationCase.LostProfit);

                cases.Add(simulationCase);
            }
            Console.WriteLine("Count: ");
            Console.WriteLine(system.PerformanceMeasures.DaysWithMoreDemand = DemandOver);
            Console.WriteLine(system.PerformanceMeasures.DaysWithUnsoldPapers = DaysUnsold);


           system.SimulationTable = cases;
        }

      


        public Enums.DayType DayType_Mapping(int rand)
        {

            List<DayTypeDistribution> DayTypeDistributions = system.DayTypeDistributions;

            foreach (DayTypeDistribution day in DayTypeDistributions)
            {
                if (rand >= day.MinRange && rand <= day.MaxRange)
                    return day.DayType;
            }

            return Enums.DayType.Good;

        }

        public int Demand_Mapping(int rand, Enums.DayType type)
        {
            foreach (DemandDistribution Demand in system.DemandDistributions)
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

        public void Display()
        {
            Console.WriteLine("No Day" + " " + "RandomDT" + " " + "DayT");
            for (int i = 0; i < system.NumOfRecords; i++)
            {
                Console.WriteLine(system.SimulationTable );
            }
        }

        public void Simulation()
        {
            system.calculateCummProbability_DayType();
            MainFunction();
        }

    }
}
