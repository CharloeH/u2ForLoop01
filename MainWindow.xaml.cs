using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace u2ForLoop01
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int BlastOff = 10;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnInput_Click(object sender, RoutedEventArgs e)
        {
            for (int BlastOff = 0; BlastOff < 11; BlastOff++)   
            {
                if (BlastOff == 0)
                {
                    lblOutput.Content = "10";
                }
                if (BlastOff == 1);
                {
                    lblOutput.Content = "9";
                }
                if (BlastOff == 2)
                {
                    lblOutput.Content = "8";
                }
                if (BlastOff == 3)
                {
                    lblOutput.Content = "7";
                }
                if (BlastOff == 4)
                {
                    lblOutput.Content = "6";
                }
                if (BlastOff == 5)
                {
                    lblOutput.Content = "5";
                }
                if (BlastOff ==6)
                {
                    lblOutput.Content = "4";
                }
                if (BlastOff == 7)
                {
                    lblOutput.Content = "3";
                }
                if (BlastOff == 8)
                {
                    lblOutput.Content = "2";
                }
                if (BlastOff == 9)
                {
                    lblOutput.Content = "1";
                }
                if (BlastOff == 10)
                {
                    lblOutput.Content = "BLASTOFF";
                }

            }
        }
    }
}
