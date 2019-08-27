using System;
using System.Diagnostics;

namespace M120Projekt
{
    static class APIDemo
    {
        #region Kontakt
        // Create
        public static void KontaktCreate()
        {
            Debug.Print("--- DemoACreate ---");
            // KlasseA
            Data.Kontakt KontaktA1 = new Data.Kontakt();
            KontaktA1.Name = "Willener";
            KontaktA1.Vorname = "Noel";
            KontaktA1.Strasse = "Länggasse 11";
            KontaktA1.PLZ = 3000;
            KontaktA1.Mobil = 0792342786;
            KontaktA1.Privat = 0318392345;
            KontaktA1.Email = "noel.willener@swisscom.com";
            KontaktA1.Farbe = 1;
            KontaktA1.Favorit = true;
            KontaktA1.Geburtstag = DateTime.Today;
            Int64 klasseA1Id = KontaktA1.Erstellen();
            Debug.Print("Kontakt erstellt mit Id:" + klasseA1Id);
        }
        public static void DemoACreateKurz()
        {
            Data.Kontakt klasseA2 = new Data.Kontakt { Name = "Artikel 2", Favorit = true, Geburtstag = DateTime.Today };
            Int64 klasseA2Id = klasseA2.Erstellen();
            Debug.Print("Artikel erstellt mit Id:" + klasseA2Id);
        }

        // Read
        public static void DemoARead()
        {
            Debug.Print("--- DemoARead ---");
            // Demo liest alle
            foreach (Data.Kontakt klasseA in Data.Kontakt.LesenAlle())
            {
                Debug.Print("Artikel Id:" + klasseA.KontaktID + " Name:" + klasseA.Name);
            }
        }
        // Update
        public static void DemoAUpdate()
        {
            Debug.Print("--- DemoAUpdate ---");
            // KlasseA ändert Attribute
            Data.Kontakt klasseA1 = Data.Kontakt.LesenID(1);
            klasseA1.Name = "Artikel 1 nach Update";
            klasseA1.Aktualisieren();
        }
        // Delete
        public static void DemoADelete()
        {
            Debug.Print("--- DemoADelete ---");
            Data.Kontakt.LesenID(2).Loeschen();
            Debug.Print("Artikel mit Id 2 gelöscht");
        }
        #endregion
    }
}
