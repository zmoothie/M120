using System.Windows;

namespace M120Projekt
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            // Aufruf diverse APIDemo Methoden
            APIDemo.KontaktCreate();
            //APIDemo.DemoACreateKurz();
            APIDemo.DemoARead();
            APIDemo.DemoAUpdate();
            APIDemo.DemoARead();

            TestTXT.AppendText(Data.Kontakt.LesenID(1).Name + " " + Data.Kontakt.LesenID(1).Vorname);
        }

        private void AddBTN_Click(object sender, RoutedEventArgs e)
        {
            details details = new details();
            details.Owner = this;
            details.ShowDialog();

            details.saveBTN.IsEnabled = false;
        }

        private void loadData(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            details details = new details();
            details.createBTN.IsEnabled = false;
            details.ReadData(3);
            details.Owner = this;
            details.ShowDialog();
        }
    }
}
