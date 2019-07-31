using System.Collections.Generic;

namespace SmartRefridgerator
{
    public class VegetableTracker
    {
        Refrigerator refrigerator; ConfigurationManager configurationManager;
        public VegetableTracker(Refrigerator refrigerator, ConfigurationManager configurationManager)
        {
            this.refrigerator = refrigerator;
            this.configurationManager = configurationManager;
        }
        public List<KeyValuePair<Vegetable, int>> GetInsufficientVegetableQuantity()
        {
            var vegetableTray = refrigerator.GetVegetableTray();
        List<KeyValuePair<Vegetable, int>> inSufficient = new List<KeyValuePair<Vegetable, int>>();
            foreach (var item in vegetableTray.GetVegetableQuantity())
            {
                var minimum = configurationManager.GetMinimumQuantity(item.Key);
                if (minimum > item.Value)
                    inSufficient.Add(item);

            }
            return inSufficient;
        }
    }
}
