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
using System.Windows.Shapes;

namespace M120Projekt
{
    /// <summary>
    /// Interaktionslogik für details.xaml
    /// </summary>
    public partial class details : Window
    {
        public details()
        {
            InitializeComponent();
        }

        private void AddBTN_Click(object sender, RoutedEventArgs e)
        {
            details details = new details();
            details.Owner = this;
            details.Owner.Hide();
            details.ShowDialog();
        }

        private void SaveBTN_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Bish dr sicher?", "Bish dr sicher?", MessageBoxButton.YesNoCancel);
            switch (result)
            {
                case MessageBoxResult.Yes:
                    MessageBox.Show("Supi, wird aues gspicheret!", "Supi!!!");
                    Close();
                    Owner.Show();
                    break;
                case MessageBoxResult.No:
                    MessageBox.Show("oke, de machs doch no shneu richtig", "Du paias");
                    break;
            }
        }

        private void CancelBTN_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Bish dr sicher?", "Bish dr sicher?", MessageBoxButton.YesNoCancel);
            switch (result)
            {
                case MessageBoxResult.Yes:
                    MessageBox.Show("Easy, de gömr doch zrüg", "wend meinsh");
                    Close();
                    Owner.Show();
                    break;
                case MessageBoxResult.No:
                    MessageBox.Show("oke, de blibe mr glich no shneu hie", "Du paias");
                    break;
            }
        }

        private void DeleteBTN_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Bish dr sicher?", "Bish dr sicher?", MessageBoxButton.YesNoCancel);
            switch (result)
            {
                case MessageBoxResult.Yes:
                    MessageBox.Show("Easy, de düemr ds doch löschä", "wird glösht");
                    Close();
                    Owner.Show();
                    break;
                case MessageBoxResult.No:
                    MessageBox.Show("oke, de hesh abr nomau glück gha", "Du paias");
                    break;
            }
        }
    }
}
