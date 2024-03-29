﻿using System;
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
            // KontaktA1
            Data.Kontakt KontaktA1 = new Data.Kontakt();
            KontaktA1.Name = "Willener";
            KontaktA1.Vorname = "Noel";
            KontaktA1.Strasse = "Länggasse 11";
            KontaktA1.Ortschaft = "Bern";
            KontaktA1.PLZ = 3000;
            KontaktA1.Mobil = 0792342786;
            KontaktA1.Privat = 0318392345;
            KontaktA1.Email = "noel.willener@swisscom.com";
            KontaktA1.Farbe = 1;
            KontaktA1.Favorit = true;
            KontaktA1.Geburtstag = DateTime.Today;
            Int64 KontaktA1Id = KontaktA1.Erstellen();
            Debug.Print("Kontakt erstellt mit Id:" + KontaktA1Id);

            // KontaktA2
            Data.Kontakt KontaktA2 = new Data.Kontakt();
            KontaktA2.Name = "Meyer";
            KontaktA2.Vorname = "Leonardo";
            KontaktA2.Strasse = "Muristrasse 11";
            KontaktA2.Ortschaft = "Muri";
            KontaktA2.PLZ = 3000;
            KontaktA2.Mobil = 0792356586;
            KontaktA2.Privat = 0314768945;
            KontaktA2.Email = "leonardo.meyer@swisscom.com";
            KontaktA2.Farbe = 2;
            KontaktA2.Favorit = true;
            KontaktA2.Geburtstag = DateTime.Today;
            Int64 KontaktA2Id = KontaktA2.Erstellen();
            Debug.Print("Kontakt erstellt mit Id:" + KontaktA2Id);

            // KontaktA2
            Data.Kontakt KontaktA3 = new Data.Kontakt();
            KontaktA3.Name = "Vinicius";
            KontaktA3.Vorname = "Pontes";
            KontaktA3.Strasse = "Birmenstorfstrasse 11";
            KontaktA3.Ortschaft = "Birmenstorf";
            KontaktA3.PLZ = 6000;
            KontaktA3.Mobil = 0792453586;
            KontaktA3.Privat = 0319372947;
            KontaktA3.Email = "vinicius.pontes@swisscom.com";
            KontaktA3.Farbe = 3;
            KontaktA3.Favorit = true;
            KontaktA3.Geburtstag = DateTime.Today;
            Int64 KontaktA3Id = KontaktA3.Erstellen();
            Debug.Print("Kontakt erstellt mit Id:" + KontaktA3Id);
        }
        //public static void DemoACreateKurz()
        //{
        //    Data.Kontakt klasseA2 = new Data.Kontakt { Name = "Artikel 2", Favorit = true, Geburtstag = DateTime.Today };
        //    Int64 klasseA2Id = klasseA2.Erstellen();
        //    Debug.Print("Artikel erstellt mit Id:" + klasseA2Id);
        //}

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
            klasseA1.Vorname = "Noël";
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
