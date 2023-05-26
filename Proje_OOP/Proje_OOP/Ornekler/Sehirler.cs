namespace Proje_OOP.Ornekler
{
    public class Sehirler : Bayrak
    {
        public int ID { get; set; }
        public string Ad { get; set; }
        public int Nufus { get; set; }
        private string Ulke { get; set; }
        public Bayrak Bayrak { get; set; }

        public void SetUlke(string Ulke)
        {
            this.Ulke = Ulke;
        }
        public string GetUlke()
        {
            return this.Ulke;
        }


    }
}
