using System;
using System.Windows.Forms;
using NewspaperSellerModels;

namespace NewspaperSellerSimulation
{
    static class Program
    {

        public static SimulationSystem simulationSystem = new SimulationSystem();

        public static object SimulationSystem { get; internal set; }

        [STAThread]

        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new NumOfNewspapersText());

        }
    }
}
