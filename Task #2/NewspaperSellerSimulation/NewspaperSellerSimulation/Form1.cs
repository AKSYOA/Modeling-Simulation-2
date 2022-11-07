using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NewspaperSellerModels;


namespace NewspaperSellerSimulation
{
    public partial class NumOfNewspapersText : Form
    {
        private OpenFileDialog testCaseFileDialog;

        private string fileName;
        private FileHandler fileHandler;
        private SimulationSystem system;


        public NumOfNewspapersText()
        {
            InitializeComponent();
            fileHandler = new FileHandler();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            //DataTable dataTableDayType = new DataTable();
            //DataTable dataTableDemand = new DataTable();

            //dataTableDayType.Columns.Add("Day Type");
            //dataTableDayType.Columns.Add("Probability");
            //dataTableDemand.Columns.Add("Demand");
            //dataTableDemand.Columns.Add("Good");
            //dataTableDemand.Columns.Add("Fair");
            //dataTableDemand.Columns.Add("Poor");

            //dataGridDayTypeDistribution.DataSource = dataTableDayType;
            //dataGridDemandDistributions.DataSource = dataTableDemand;

            //List<SimulationCase> Stable = Program.simulationSystem.SimulationTable;
            //foreach (var value in Stable)
            //{

            //    dataTable.Rows.Add(value.DayNo, value.RandomNewsDayType,
            //        value.NewsDayType, value.RandomDemand, 
            //        value.Demand, value.SalesProfit,
            //        value.LostProfit, value.ScrapProfit,
            //        value.DailyNetProfit);
            //}

            //dataTable.Rows.Add("", "", ""
            //   , "", "", Program.simulationSystem.PerformanceMeasures.TotalSalesProfit,
            //   Program.simulationSystem.PerformanceMeasures.TotalLostProfit,
            //   Program.simulationSystem.PerformanceMeasures.TotalScrapProfit,
            //   Program.simulationSystem.PerformanceMeasures.TotalNetProfit);



        }

        private void button1_Click(object sender, EventArgs e)
        {
            Perfomance perfomance = new Perfomance(system);
            perfomance.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void displayData()
        {

            NumOfNewspaperstextBox.Text = system.NumOfNewspapers.ToString();
            NumOfRecordsText.Text = system.NumOfRecords.ToString();
            PurchasePriceText.Text = system.PurchasePrice.ToString();
            ScrapPriceText.Text = system.ScrapPrice.ToString();
            SellingPriceText.Text = system.SellingPrice.ToString();
            // Adding Data of Day Type..
            for (int i = 0; i < system.DayTypeDistributions.Count; i++)
            {
                String DayT;
                if (i == 0) { DayT = "Good";}
                else if (i == 1) { DayT = "Fair"; }
                else { DayT = "Poor"; }      
                decimal Probability = system.DayTypeDistributions[i].Probability;
                dataGridDayTypeDistribution.Rows.Add(DayT, Probability);
            }
            //Adding Data of Demand..
            for (int i = 0; i < system.DemandDistributions.Count; i++)
            {
                int Demand = system.DemandDistributions[i].Demand;
                decimal Good = system.DemandDistributions[i].DayTypeDistributions[0].Probability;
                decimal Fair = system.DemandDistributions[i].DayTypeDistributions[1].Probability;
                decimal Poor = system.DemandDistributions[i].DayTypeDistributions[2].Probability;
                dataGridDemandDistributions.Rows.Add(Demand, Good, Fair, Poor);
            }


        }

        private void OpenTestCase_Click(object sender, EventArgs e)
        {
            testCaseFileDialog = new OpenFileDialog();
            DialogResult fileResult = testCaseFileDialog.ShowDialog();

            if (fileResult == DialogResult.OK)
            {
                fileName = testCaseFileDialog.SafeFileName;
                system = fileHandler.ReadTestCase(testCaseFileDialog.FileName);
                dataGridDayTypeDistribution.Rows.Clear();
                dataGridDemandDistributions.Rows.Clear();
                
                displayData();

                #region // comments
               
                /*
                for (int i =0; i < system.DemandDistributions.Count; i++)
                {
                    for (int j = 0; j < system.DemandDistributions[i].DayTypeDistributions.Count; j++)
                    {
                        Console.Write(system.DemandDistributions[i].DayTypeDistributions[j].Probability + " ");
                    }
                    Console.WriteLine();
                }
                */
                #endregion
            }
        }

        private void NumOfNewspapers_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void PurchasePrice_Click(object sender, EventArgs e)
        {

        }

        private void ScrapPrice_Click(object sender, EventArgs e)
        {

        }

        private void SellingPrice_Click(object sender, EventArgs e)
        {

        }

        private void ScrapPriceText_TextChanged(object sender, EventArgs e)
        {

        }

        private void SellingPriceText_TextChanged(object sender, EventArgs e)
        {

        }

        private void PurchasePriceText_TextChanged(object sender, EventArgs e)
        {

        }

        private void NumOfRecordsText_TextChanged(object sender, EventArgs e)
        {

        }

        private void NumOfRecords_Click(object sender, EventArgs e)
        {

        }

        private void interarrivalDistributionDataTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridDemandDistributions_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
