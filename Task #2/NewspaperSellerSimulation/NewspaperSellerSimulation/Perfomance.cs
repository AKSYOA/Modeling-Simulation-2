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
using NewspaperSellerTesting;

namespace NewspaperSellerSimulation
{
    public partial class Perfomance : Form
    {
        private SimulationSystem system;
        public Perfomance(SimulationSystem system)
        {
            InitializeComponent();
            this.system = system;
        }

        private void Perfomance_Load(object sender, EventArgs e)
        {
            PreparingDataView();
            #region // comments

            //    label2.Text = Program.simulationSystem.PerformanceMeasures.TotalSalesProfit.ToString();
            //    label5.Text = Program.simulationSystem.PerformanceMeasures.TotalCost.ToString();
            //    label7.Text = Program.simulationSystem.PerformanceMeasures.TotalLostProfit.ToString();
            //    label9.Text = Program.simulationSystem.PerformanceMeasures.TotalScrapProfit.ToString();
            //    label11.Text = Program.simulationSystem.PerformanceMeasures.TotalNetProfit.ToString();
            //    label13.Text = Program.simulationSystem.PerformanceMeasures.DaysWithMoreDemand.ToString();
            //    label15.Text = Program.simulationSystem.PerformanceMeasures.DaysWithUnsoldPapers.ToString();
            #endregion
        }

        private void PreparingDataView()
        {
            foreach (var simulationCase in system.SimulationTable)
            {
                int DayNo = simulationCase.DayNo;
                int RandomNewsDayType = simulationCase.RandomNewsDayType;
                Enums.DayType NewsDayType = simulationCase.NewsDayType;
                int RandomDemand = simulationCase.RandomDemand;
                int Demand = simulationCase.Demand;
                decimal SalesProfit = simulationCase.SalesProfit;
                decimal LostProfit = simulationCase.LostProfit;
                decimal ScrapProfit = simulationCase.ScrapProfit;
                decimal DailyCost = simulationCase.DailyCost;

                PerformanceDataGridView.Rows.Add(DayNo, RandomNewsDayType, NewsDayType,
                 RandomDemand, Demand, SalesProfit, LostProfit, ScrapProfit, DailyCost);

                TotalSalesTextBox1.Text = system.PerformanceMeasures.TotalSalesProfit.ToString();
                TotalLostTextBox2.Text = system.PerformanceMeasures.TotalLostProfit.ToString();
                TotalNetTextBox3.Text = system.PerformanceMeasures.TotalNetProfit.ToString();
                NumOfDaysUnsoldPaperTextBox4.Text = system.PerformanceMeasures.DaysWithUnsoldPapers.ToString();
                TotalSalvageOfScrapPapersTextBox6.Text = system.PerformanceMeasures.TotalScrapProfit.ToString();
                TotalCostOfNewPaperTextBox5.Text = system.PerformanceMeasures.TotalCost.ToString();
                NumOfDaysExcessDemandTextBox7.Text = system.PerformanceMeasures.DaysWithMoreDemand.ToString();
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Done");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void outputDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
