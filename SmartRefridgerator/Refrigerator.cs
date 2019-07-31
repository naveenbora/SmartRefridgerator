namespace SmartRefridgerator
{
    public class Refrigerator
    {
        private VegetableTray _vegetableTray = new VegetableTray();
        private StorageFactory storageFactory = new StorageFactory();
        
        private ConfigurationManager _configurationManager;
        public Refrigerator()
        {
            _configurationManager = new ConfigurationManager(storageFactory.GetStorageFactory("InMemory"));

        }
        public void AddVegetable(Vegetable vegetable, int quantity)
        {
            _vegetableTray.Add(vegetable, quantity);
             
        }

    public void TakeOutVegetable(Vegetable vegetable, int quantity)
        {
            _vegetableTray.TakeOut(vegetable, quantity);

            var vegetableQuantity = _vegetableTray.GetVegetableQuantity();
        }
        public VegetableTray GetVegetableTray()
        {
            return _vegetableTray;
        }

    }
}
