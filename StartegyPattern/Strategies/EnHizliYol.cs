namespace StartegyPattern.Strategies
{
    public class EnHizliYol : IRouteStartegy
    {
        public string RouteCalculate(string baslangic, string bitis)
        {
            return $"{baslangic} noktasından {bitis} noktasına en hızlı rota hesaplandı.";
        }
    }
}
