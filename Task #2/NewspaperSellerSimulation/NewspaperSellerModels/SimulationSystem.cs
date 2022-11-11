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



        public void MainFunction()
        {
            List<SimulationCase> cases = new List<SimulationCase>();

            Random rand = new Random();
            int DemandOver = 0;
            int DaysUnsold = 0;


            PerformanceMeasures.TotalSalesProfit = 0;
            PerformanceMeasures.TotalLostProfit = 0;
            PerformanceMeasures.TotalNetProfit = 0;
            PerformanceMeasures.TotalScrapProfit = 0;
            PerformanceMeasures.TotalCost = (NumOfNewspapers * PurchasePrice) * NumOfRecords;


            for (int i = 0; i < NumOfRecords; i++)
            {
                SimulationCase simulationCase = new SimulationCase();

                simulationCase.DayNo = i + 1;
                simulationCase.RandomNewsDayType = rand.Next(1, 100);
                simulationCase.NewsDayType = DayType_Mapping(simulationCase);
                simulationCase.RandomDemand = rand.Next(1, 100);
                simulationCase.Demand = Demand_Mapping(simulationCase);
                simulationCase.DailyCost = NumOfNewspapers * PurchasePrice;


                if (simulationCase.Demand >= NumOfNewspapers)
                {
                    simulationCase.SalesProfit = NumOfNewspapers * SellingPrice;

                    simulationCase.LostProfit = (simulationCase.Demand - NumOfNewspapers) * (SellingPrice - PurchasePrice);

                    simulationCase.DailyNetProfit = simulationCase.SalesProfit - simulationCase.DailyCost - simulationCase.LostProfit;

                    if (simulationCase.LostProfit != 0)
                        DemandOver++;
                }

                else
                {
                    simulationCase.SalesProfit = simulationCase.Demand * SellingPrice;

                    simulationCase.ScrapProfit = (NumOfNewspapers - simulationCase.Demand) * ScrapPrice;

                    simulationCase.DailyNetProfit = simulationCase.SalesProfit - simulationCase.DailyCost + simulationCase.ScrapProfit;

                    if (simulationCase.ScrapProfit != 0) 
                        DaysUnsold++;
                }


                PerformanceMeasures.TotalSalesProfit += simulationCase.SalesProfit;
                PerformanceMeasures.TotalNetProfit += simulationCase.DailyNetProfit;
                PerformanceMeasures.TotalScrapProfit += simulationCase.ScrapProfit;
                PerformanceMeasures.TotalLostProfit += simulationCase.LostProfit;
                PerformanceMeasures.DaysWithMoreDemand = DemandOver;
                PerformanceMeasures.DaysWithUnsoldPapers = DaysUnsold;
                cases.Add(simulationCase);
            }

            SimulationTable = cases;
        }




        public Enums.DayType DayType_Mapping(SimulationCase simulationCase)
        {
            for(int i=0; i< DayTypeDistributions.Count; i++)
            {
                if (simulationCase.RandomNewsDayType >= DayTypeDistributions[i].MinRange && simulationCase.RandomNewsDayType <= DayTypeDistributions[i].MaxRange)
                {
                    return DayTypeDistributions[i].DayType;
                } 
            }
            return 0;

        }



        public int Demand_Mapping(SimulationCase simulationCase)
        {
            foreach (DemandDistribution Demand in DemandDistributions)
            {
                if (simulationCase.NewsDayType == Enums.DayType.Good)
                {
                    if (simulationCase.RandomDemand >= Demand.DayTypeDistributions[0].MinRange &&
                        simulationCase.RandomDemand <= Demand.DayTypeDistributions[0].MaxRange)
                    {
                        return Demand.Demand;
                    }

                }
                else if (simulationCase.NewsDayType == Enums.DayType.Fair)
                {
                    if (simulationCase.RandomDemand >= Demand.DayTypeDistributions[1].MinRange &&
                        simulationCase.RandomDemand <= Demand.DayTypeDistributions[1].MaxRange)
                    {
                        return Demand.Demand;
                    }

                }
                else if (simulationCase.NewsDayType == Enums.DayType.Poor)
                {
                    if (simulationCase.RandomDemand >= Demand.DayTypeDistributions[2].MinRange &&
                        simulationCase.RandomDemand <= Demand.DayTypeDistributions[2].MaxRange)
                    {
                        return Demand.Demand;
                    }

                }
            }
            return 0;
        }
        

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
            }
        }


        //Calculate Commulative Probability for Demand .....
        public void calculateCummProbability_Demand()
        {
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
                } 
            }
        }

        //public void Reset()
        //{
        //    PerformanceMeasures.DaysWithMoreDemand = 0;
        //    PerformanceMeasures.DaysWithUnsoldPapers = 0;
        //}

        public void Simulation()
        {
            calculateCummProbability_DayType();
            calculateCummProbability_Demand();
            //Reset();
            MainFunction();
        }
    }
}
