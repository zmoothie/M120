using M120Projekt.Data;
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

        public void ReadData(int id)
        {
            Data.Kontakt KontaktA1 = Data.Kontakt.LesenID(id);
            NameTB.Text = KontaktA1.Name;
            SurnameTB.Text = KontaktA1.Vorname;
            StreetTB.Text = KontaktA1.Strasse;
            CityTB.Text = KontaktA1.Ortschaft;
            ZIPTB.Text = KontaktA1.PLZ.ToString();
            MobileNrTB.Text = KontaktA1.Mobil.ToString();
            BusinessNrTB.Text = KontaktA1.Privat.ToString();
            EmailTB.Text = KontaktA1.Email; 
            FavouritCB.IsChecked = KontaktA1.Favorit;
            BirthdayDP.DisplayDate = KontaktA1.Geburtstag;
        }

        private void SaveBTN_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Bish dr sicher?", "Bish dr sicher?", MessageBoxButton.YesNo);
            switch (result)
            {
                case MessageBoxResult.Yes:

                    Data.Kontakt KontaktA1 = Data.Kontakt.LesenID(1);
                    KontaktA1.Name = NameTB.Text;
                    KontaktA1.Vorname = SurnameTB.Text;
                    KontaktA1.Strasse = StreetTB.Text;
                    KontaktA1.Ortschaft = CityTB.Text;
                    KontaktA1.PLZ = Int64.Parse(ZIPTB.Text);
                    KontaktA1.Mobil = Int64.Parse(MobileNrTB.Text);
                    KontaktA1.Privat = Int64.Parse(BusinessNrTB.Text);
                    KontaktA1.Email = EmailTB.Text;
                    KontaktA1.Favorit = FavouritCB.IsChecked.Value;
                    KontaktA1.Geburtstag = BirthdayDP.DisplayDate;
                    KontaktA1.Aktualisieren();

                    MessageBox.Show("Supi, wird aues gspicheret!", "Supi!!!");
                    Close();
                    Owner.Show();
                    break;
                case MessageBoxResult.No:
                    MessageBox.Show("oke, de machs doch no shneu richtig", "Du paias");
                    break;
            }
        }

        private void DeleteBTN_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Bish dr sicher?", "Bish dr sicher?", MessageBoxButton.YesNo);
            switch (result)
            {
                case MessageBoxResult.Yes:

                    Data.Kontakt.LesenID(1).Loeschen();

                    MessageBox.Show("Easy, de düemr ds doch löschä", "wird glösht");
                    Close();
                    Owner.Show();
                    break;
                case MessageBoxResult.No:
                    MessageBox.Show("oke, de hesh abr nomau glück gha", "Du paias");
                    break;
            }
        }

        private void CreateBTN_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Bish dr sicher?", "Bish dr sicher?", MessageBoxButton.YesNo);
            switch (result)
            {
                case MessageBoxResult.Yes:

                    Data.Kontakt KontaktA1 = new Data.Kontakt
                    {
                        Name = NameTB.Text,
                        Vorname = SurnameTB.Text,
                        Strasse = StreetTB.Text,
                        Ortschaft = CityTB.Text,
                        PLZ = Int64.Parse(ZIPTB.Text),
                        Mobil = Int64.Parse(MobileNrTB.Text),
                        Privat = Int64.Parse(BusinessNrTB.Text),
                        Email = EmailTB.Text,
                        Favorit = FavouritCB.IsChecked.Value,
                        Geburtstag = BirthdayDP.DisplayDate
                    };
                    Int64 KontaktA1Id = KontaktA1.Erstellen();

                    MessageBox.Show("Supi, wird ersteut!", "Supi!!!");
                    Close();
                    Owner.Show();
                    break;

                case MessageBoxResult.No:

                    MessageBox.Show("oke, de machs doch no shneu richtig", "Du paias");
                    break;
            }
        }

        private void SurnameTB_LostFocus(object sender, RoutedEventArgs e)
        {
            System.Text.RegularExpressions.Regex regex = new System.Text.RegularExpressions.Regex(@"^([ \u00c0-\u01ffa-zA-Z'])+$");
            System.Text.RegularExpressions.Match match = regex.Match(SurnameTB.Text);

            if (match.Success)
            {

            } else
            {
                MessageBox.Show("Bitte geben Sie eine gültigen Vornamen ein!");
            }
        }
        private void SurnameTB_GotFocus(object sender, RoutedEventArgs e)
        {
            if (SurnameTB.Text == "Vorname")
            {
                SurnameTB.Clear();
            }
        }

        private void NameTB_LostFocus(object sender, RoutedEventArgs e)
        {
            System.Text.RegularExpressions.Regex regex = new System.Text.RegularExpressions.Regex(@"^([ \u00c0-\u01ffa-zA-Z'])+$");
            System.Text.RegularExpressions.Match match = regex.Match(NameTB.Text);

            if (match.Success)
            {

            }
            else
            {
                MessageBox.Show("Bitte geben Sie eine gültigen Namen ein!");
            }
        }
        private void NameTB_GotFocus(object sender, RoutedEventArgs e)
        {
            if (NameTB.Text == "Name") {
                NameTB.Clear();
            }
        }

        private void StreetTB_LostFocus(object sender, RoutedEventArgs e)
        {
            System.Text.RegularExpressions.Regex regex = new System.Text.RegularExpressions.Regex(@"^([A-ZÄÖÜ][a-zäöüß]+(([.] )|( )|([-])))+[1-9][0-9]{0,3}[a-z]?$");
            System.Text.RegularExpressions.Match match = regex.Match(StreetTB.Text);

            if (match.Success)
            {

            }
            else
            {
                MessageBox.Show("Bitte geben Sie eine gültigen Strassennamen ein!");
            }
        }
        private void StreetTB_GotFocus(object sender, RoutedEventArgs e)
        {
            if (StreetTB.Text == "Strasse") {
                StreetTB.Clear();
            }
        }

        private void CityTB_LostFocus(object sender, RoutedEventArgs e)
        {
            System.Text.RegularExpressions.Regex regex = new System.Text.RegularExpressions.Regex(@"^([ \u00c0-\u01ffa-zA-Z'])+$");
            System.Text.RegularExpressions.Match match = regex.Match(CityTB.Text);

            if (match.Success)
            {

            }
            else
            {
                validLBL.Content += "Bitte geben Sie einen gültigen Ort ein!";
            }
        }
        private void CityTB_GotFocus(object sender, RoutedEventArgs e)
        {
            if (CityTB.Text == "Ort") {
                CityTB.Clear();
            }
        }

        private void ZIPTB_LostFocus(object sender, RoutedEventArgs e)
        {
            System.Text.RegularExpressions.Regex regex = new System.Text.RegularExpressions.Regex(@"^\d{4}$");
            System.Text.RegularExpressions.Match match = regex.Match(ZIPTB.Text);

            if (match.Success)
            {

            }
            else
            {
                MessageBox.Show("Bitte geben Sie eine gültige PLZ ein!");
            }
        }
        private void ZIPTB_GotFocus(object sender, RoutedEventArgs e)
        {
            if (ZIPTB.Text == "PLZ") {
                ZIPTB.Clear();
            }
        }

        private void MobileNrTB_LostFocus(object sender, RoutedEventArgs e)
        {
            System.Text.RegularExpressions.Regex regex = new System.Text.RegularExpressions.Regex(@"^(((((\+)?(\s)?(\d{2,4}))(\s)?((\(0\))?)(\s)?|0)(\s|\-)?)(\s|\d{2})(\s|\-)?)?(\d{3})(\s|\-)?(\d{2})(\s|\-)?(\d{2})");
            System.Text.RegularExpressions.Match match = regex.Match(MobileNrTB.Text);

            if (match.Success)
            {

            }
            else
            {
                MessageBox.Show("Bitte geben Sie eine gültige Telefonnummer ein!");
            }
        }
        private void MobileNrTB_GotFocus(object sender, RoutedEventArgs e)
        {
            if (MobileNrTB.Text == "Telefon (Privat)") {
                MobileNrTB.Clear();
            }
        }


        private void BusinessNrTB_LostFocus(object sender, RoutedEventArgs e)
        {
            System.Text.RegularExpressions.Regex regex = new System.Text.RegularExpressions.Regex(@"^(((((\+)?(\s)?(\d{2,4}))(\s)?((\(0\))?)(\s)?|0)(\s|\-)?)(\s|\d{2})(\s|\-)?)?(\d{3})(\s|\-)?(\d{2})(\s|\-)?(\d{2})");
            System.Text.RegularExpressions.Match match = regex.Match(BusinessNrTB.Text);

            if (match.Success)
            {

            }
            else
            {
                MessageBox.Show("Bitte geben Sie eine gültige Telefonnummer ein!");
            }
        }
        private void BusinessNrTB_GotFocus(object sender, RoutedEventArgs e)
        {
            if (BusinessNrTB.Text == "Telefon (Geschäft)")
            {
                BusinessNrTB.Clear();
            }
        }


        private void EmailTB_LostFocus(object sender, RoutedEventArgs e)
        {
            System.Text.RegularExpressions.Regex regex = new System.Text.RegularExpressions.Regex(@"^(\D)+(\w)*((\.(\w)+)?)+@(\D)+(\w)*((\.(\D)+(\w)*)+)?(\.)[a-z]{2,}$");
            System.Text.RegularExpressions.Match match = regex.Match(EmailTB.Text);

            if (match.Success)
            {

            }
            else
            {
                MessageBox.Show("Bitte geben Sie eine gültige Email ein!");
            }
        }
        private void EmailTB_GotFocus(object sender, RoutedEventArgs e)
        {
            if (EmailTB.Text == "Email")
            {
                EmailTB.Clear();
            }
        }
    }
}
