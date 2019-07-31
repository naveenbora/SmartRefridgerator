namespace SmartRefridgerator
{
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
    }



