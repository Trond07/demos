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

namespace SimpleDelegates
{
    // Define a delegate type
    delegate double TrigOp(double radians);

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnSin_Click(object sender, RoutedEventArgs e)
        {
            TrigOp op = Math.Sin;
            PerformOp(op);
        }

        private void BtnCos_Click(object sender, RoutedEventArgs e)
        {
            TrigOp op = Math.Cos;
            PerformOp(op);
        }

        private void BtnTan_Click(object sender, RoutedEventArgs e)
        {
            TrigOp op = Math.Tan;
            PerformOp(op);
        }

        private void PerformOp(TrigOp op)
        {
            double degrees;

            if (this.TxtDegrees.Text.Length == 0)
            {
                MessageBox.Show("Please enter an angle.", "Error");
            }
            else if (!double.TryParse(TxtDegrees.Text, out degrees))
            {
                MessageBox.Show("Please enter a number.", "Error");
            }
            else
            {
                double radians = (degrees / 360) * 2 * Math.PI;
                double result = op(radians);
                result = Math.Round(result, 4);
                MessageBox.Show(result.ToString(), "Result");
            }
            TxtDegrees.Clear();
            TxtDegrees.Focus();
        }
    }
}
