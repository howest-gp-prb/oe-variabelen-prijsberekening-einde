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

namespace Prb.Variabelen02.WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, RoutedEventArgs e)
        {
            decimal net = decimal.Parse(txtNet.Text);            
            decimal transport = decimal.Parse(txtTransport.Text);
            decimal handling = decimal.Parse(txtHandling.Text);
            decimal other = decimal.Parse(txtOther.Text);
            float vat = float.Parse(txtVAT.Text);

            decimal totalnet = net + transport + handling + other;
            vat = vat / 100F;
            decimal netvat = net * (decimal)vat;
            decimal transportvat = (transport * (decimal)vat);
            decimal handlingvat = handling * (decimal)vat;
            decimal othervat = other * (decimal)vat;
            decimal totalgross = (totalnet * (decimal)vat) + totalnet;

            string report = "Net = " + net + " \t";
            report += "(VAT = " + netvat + ")\n";
            report += "Transport = " + transport + " \t";
            report += "(VAT = " + transportvat + ")\n";
            report += "Handling = " + handling + " \t";
            report += "(VAT = " + handlingvat + ")\n";
            report += "Other = " + other + " \t";
            report += "(VAT = " + othervat + ")\n";
            report += "=====================================\n";
            report += "Total NET = \t" + totalnet + "\n";
            report += "Total GROSS = \t" + totalgross;

            lblReport.Content = report;



        }
    }
}
