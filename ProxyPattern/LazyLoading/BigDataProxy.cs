namespace ProxyPattern.LazyLoading
{
    public class BigDataProxy
    {
        private BigData _bigData;

        public void Process()
        {
            if (_bigData == null)
            {
                _bigData = new BigData();
            }

            _bigData.Process();
        }
    }
}
