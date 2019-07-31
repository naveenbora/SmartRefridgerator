using System;
using System.Collections.Generic;
using System.Text;

namespace SmartRefridgerator
{

    public class NotifierThroughSms : INotification
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
    }



