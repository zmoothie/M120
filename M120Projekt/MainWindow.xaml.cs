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
        }

        private void AddBTN_Click(object sender, RoutedEventArgs e)
        {
            details details = new details();
            details.Owner = this;
            details.ShowDialog();
        }
    }
}
