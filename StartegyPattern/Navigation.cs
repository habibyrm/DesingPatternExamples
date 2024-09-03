namespace StartegyPattern
{
    public class Navigation
    {
        private IRouteStartegy _routeStartegy;

        // Strateji ayarlama
        public void SetRotaHesapla(IRouteStartegy routeStartegy)
        {
            _routeStartegy = routeStartegy;
        }

        // Stratejiye göre rota hesaplama
        public void RotaHesapla(string baslangic, string bitis)
        {
            string sonuc = _routeStartegy.RouteCalculate(baslangic, bitis);

            Console.WriteLine(sonuc);
        }
    }
}
