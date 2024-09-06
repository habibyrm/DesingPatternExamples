using CommandPattern.Command;

namespace CommandPattern
{
    public class Waiter
    {
        private IOrderCommand _orderCommand;

        public void SetOrder(IOrderCommand orderCommand)
        {
            _orderCommand = orderCommand;
        }

        public void ServeOrder()
        {
            _orderCommand.Execute();
        }
    }
}
