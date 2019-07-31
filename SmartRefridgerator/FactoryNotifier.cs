namespace SmartRefridgerator
{
    public class FactoryNotifier
        {
            public INotification FactoryNotifierSelector(string TypeOfNotifier, VegetableTracker vegetableTracker)
            {
                switch (TypeOfNotifier)
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



