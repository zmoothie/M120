using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace M120Projekt.Data
{
    public class Kontakt
    {
        #region Datenbankschicht
        [Key]
        public Int64 KontaktID { get; set; }
        [Required]
        public String Name { get; set; }
        [Required]
        public String Vorname { get; set; }
        [Required]
        public String Strasse { get; set; }
        [Required]
        public String Ortschaft { get; set; }
        [Required]
        public Int64 PLZ { get; set; }
        [Required]
        public Int64 Mobil { get; set; }
        [Required]
        public Int64 Privat { get; set; }
        public String Email { get; set; }
        [Required]
        public Int64 Farbe { get; set; }
        [Required]
        public Boolean Favorit { get; set; }
        public DateTime Geburtstag { get; set; }


        #endregion
        #region Applikationsschicht
        public Kontakt() { }
        [NotMapped]
        public String BerechnetesAttribut
        {
            get
            {
                return "Im Getter kann Code eingefügt werden für berechnete Attribute";
            }
        }
        public static List<Kontakt> LesenAlle()
        {
            using (var db = new Context())
            {
                return (from record in db.Kontakt select record).ToList();
            }
        }
        public static Kontakt LesenID(Int64 klasseAId)
        {
            using (var db = new Context())
            {
                return (from record in db.Kontakt where record.KontaktID == klasseAId select record).FirstOrDefault();
            }
        }
        public static List<Kontakt> LesenAttributGleich(String suchbegriff)
        {
            using (var db = new Context())
            {
                return (from record in db.Kontakt where record.Name == suchbegriff select record).ToList();
            }
        }
        public static List<Kontakt> LesenAttributWie(String suchbegriff)
        {
            using (var db = new Context())
            {
                return (from record in db.Kontakt where record.Name.Contains(suchbegriff) select record).ToList();
            }
        }
        public Int64 Erstellen()
        {
            if (this.Name == null || this.Name == "") this.Name = "leer";
            if (this.Geburtstag == null) this.Geburtstag = DateTime.MinValue;
            using (var db = new Context())
            {
                db.Kontakt.Add(this);
                db.SaveChanges();
                return this.KontaktID;
            }
        }
        public Int64 Aktualisieren()
        {
            using (var db = new Context())
            {
                db.Entry(this).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                return this.KontaktID;
            }
        }
        public void Loeschen()
        {
            using (var db = new Context())
            {
                db.Entry(this).State = System.Data.Entity.EntityState.Deleted;
                db.SaveChanges();
            }
        }
        public override string ToString()
        {
            return KontaktID.ToString(); // Für bessere Coded UI Test Erkennung
        }
        #endregion
    }
}
