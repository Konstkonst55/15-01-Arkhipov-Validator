using _15_01_ArkhipovValidator.Utils;
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

namespace _15_01_ArkhipovValidator
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ShowPassed(Run r, bool passed)
        {
            if (passed) r.Text = "✔";
            else r.Text = "❌";
        }

        private void tbName_TextChanged(object sender, TextChangedEventArgs e)
        {
            if ((sender as TextBox).Text.ValidateMinMaxSymbols(3, 25))
                ShowPassed(rNamePassed, true);
            else
                ShowPassed(rNamePassed, false);
        }

        private void tbLastName_TextChanged(object sender, TextChangedEventArgs e)
        {
            if ((sender as TextBox).Text.ValidateMinMaxSymbols(2, 30))
                ShowPassed(rLastNamePassed, true);
            else
                ShowPassed(rLastNamePassed, false);
        }

        private void mtbEmail_TextChanged(object sender, TextChangedEventArgs e)
        {
            if ((sender as TextBox).Text.ValidateEmail())
                ShowPassed(rEmailPassed, true);
            else
                ShowPassed(rEmailPassed, false);
        }
    }
}
