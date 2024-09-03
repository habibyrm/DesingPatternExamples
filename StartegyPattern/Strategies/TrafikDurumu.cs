namespace StartegyPattern.Strategies
{
    public class TrafikDurumu : IRouteStartegy
    {
        public string RouteCalculate(string baslangic, string bitis)
        {
            return $"{baslangic} noktasından {bitis} noktasına trafik durumu göz önüne alınarak rota hesaplandı.";
        }
    }
}
