namespace PrototypePattern
{
    public abstract class Oyuncu
    {
        public string Rutbe {  get; set; }
        public string Techizat { get; set; }
        public string Guc { get; set; }
        public string Renk {  get; set; }
        public string SavasAlani {  get; set; }

        public abstract Oyuncu Klonla();
        public void SavasAlanDegistir(string yeniALan)
        {
            this.SavasAlani = yeniALan;
        }
        public void RutbeDegistir(string yeniRutbe)
        {
            this.Rutbe = yeniRutbe;
        }
        public void RenkDegistir(string yeniRenk)
        {
            this.Renk = yeniRenk;
        }
        public void TechizatDegistir(string yeniTechizat)
        {
            this.Techizat = yeniTechizat;
        }
        public void GucDegistir(string yeniGuc)
        {
            this.Guc = yeniGuc;
        }


        // Bilgileri gösterme
        public void BilgileriGoster()
        {
            Console.WriteLine($"Rütbe: {Rutbe}, Savaş Alanı: {SavasAlani}, Üniforma Rengi: {Renk}, Techizat: {Techizat}, Güç: {Guc}");
        }
    }
}
