﻿using System;
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
           
        }


        //Button To Display Simulation Test .....
        private void button1_Click(object sender, EventArgs e)
        {
            if (system != null)
            {
                system.Simulation();
                Perfomance perfomance = new Perfomance(system);
                perfomance.Show();
                string result = TestingManager.Test(system, fileName);
                MessageBox.Show(result);
            }
            else
                MessageBox.Show("Please Choose Test Case");
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        //Display Data Input in GUI .....
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


        //Button_Function to get Test Cases.....
        private void OpenTestCase_Click(object sender, EventArgs e)
        {
            testCaseFileDialog = new OpenFileDialog();
            DialogResult fileResult = testCaseFileDialog.ShowDialog();

            if (fileResult == DialogResult.OK)
            {
                //Get File Test Case....
                fileName = testCaseFileDialog.SafeFileName;
                system = fileHandler.ReadTestCase(testCaseFileDialog.FileName);
                dataGridDayTypeDistribution.Rows.Clear();
                dataGridDemandDistributions.Rows.Clear();
                //Display Data in GUI.....
                displayData();
                //Calculate Comulative Probability .....
                system.calculateCummProbability_DayType();
                system.calculateCummProbability_Demand();
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
