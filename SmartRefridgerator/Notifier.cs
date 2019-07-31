namespace SmartRefridgerator
{
    public class NotifierThroughSms: INotification
    {
        VegetableTracker vegetableTracker;
        public NotifierThroughSms(VegetableTracker vegetableTracker)
        {
            this.vegetableTracker = vegetableTracker;
            
        }
        public string NotifyUser()
        {
            var OrderDetails = vegetableTracker.GetInsufficientVegetableQuantity();
            if (OrderDetails.Count != 0)
                return "Need to order the vegetables Through Sms";
            else
                return "Sufficient";
        }
    }
    public interface INotification
    {
        string NotifyUser();
    }
    public class NotifierThroughEmail : INotification
    {
        VegetableTracker vegetableTracker;
        public NotifierThroughEmail(VegetableTracker vegetableTracker)
        {
            this.vegetableTracker = vegetableTracker;
        }
        public string NotifyUser()
        {
            var OrderDetails = vegetableTracker.GetInsufficientVegetableQuantity();
            if (OrderDetails.Count != 0)
                return "Need to order the vegetables Through Email";
            else
                return "Sufficient";
        }

    }
    public class FactoryNotifier
    {
        public INotification FactoryNotifier(string TypeOfNotifier, VegetableTracker vegetableTracker)
        {
            switch(TypeOfNotifier)
            {
                case "SMS":
                    return new NotifierThroughSms(vegetableTracker);
                case "Email":
                    return new NotifierThroughEmail(vegetableTracker);
                default:
                    throw new System.NotImplementedException();
            }
        }
    }
}
