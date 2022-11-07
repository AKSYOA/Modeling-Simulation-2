using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using NewspaperSellerModels;


namespace NewspaperSellerSimulation
{
    class FileHandler
    {
        private SimulationSystem system;

        public SimulationSystem ReadTestCase(string testCasePath)
        {
            system = new SimulationSystem();
            Stream stream = File.Open(testCasePath, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
            var sr = new StreamReader(stream);
            string ln;
            while ((ln = sr.ReadLine()) != null)
            {
                if (ln.Equals("NumOfNewspapers"))
                {
                    system.NumOfNewspapers = Int32.Parse(sr.ReadLine());
                }
                else if (ln.Equals("NumOfRecords"))
                {
                    system.NumOfRecords = Int32.Parse(sr.ReadLine());
                }
                else if (ln.Equals("PurchasePrice"))
                {
                    system.PurchasePrice = Decimal.Parse(sr.ReadLine());
                }
                else if (ln.Equals("ScrapPrice"))
                {
                    system.ScrapPrice = Decimal.Parse(sr.ReadLine());
                }
                else if (ln.Equals("SellingPrice"))
                {
                    system.SellingPrice = Decimal.Parse(sr.ReadLine());
                }
                else if (ln.Equals("DayTypeDistributions"))
                {
                    while (!String.IsNullOrEmpty(ln = sr.ReadLine()))
                    {
                        ln = ln.Replace(" ", string.Empty);
                        string[] values = ln.Split(',');
                        decimal good = Decimal.Parse(values[0]);
                        decimal fair = Decimal.Parse(values[1]);
                        decimal poor = Decimal.Parse(values[2]);
                        system.DayTypeDistributions.Add(new DayTypeDistribution(good, Enums.DayType.Good));
                        system.DayTypeDistributions.Add(new DayTypeDistribution(fair, Enums.DayType.Fair));
                        system.DayTypeDistributions.Add(new DayTypeDistribution(poor, Enums.DayType.Poor));
                    }
                }
                else if (ln.Equals("DemandDistributions"))
                {
                    

                    while (!String.IsNullOrEmpty(ln = sr.ReadLine()))
                    {
                        DemandDistribution demandDistribution = new DemandDistribution();
                        ln = ln.Replace(" ", string.Empty);
                        string[] values = ln.Split(',');

                        demandDistribution.Demand = Int32.Parse(values[0]);
            
                        demandDistribution.DayTypeDistributions.Add(new DayTypeDistribution(Decimal.Parse(values[1]), Enums.DayType.Good));
                        demandDistribution.DayTypeDistributions.Add(new DayTypeDistribution(Decimal.Parse(values[2]), Enums.DayType.Fair));
                        demandDistribution.DayTypeDistributions.Add(new DayTypeDistribution(Decimal.Parse(values[3]), Enums.DayType.Poor));

                        system.DemandDistributions.Add(demandDistribution);
                    }
                }

            }
            return system;
        }



    }
}
