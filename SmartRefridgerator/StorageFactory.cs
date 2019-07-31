using System;
namespace SmartRefridgerator
{
    public class StorageFactory
    {
        public IStorage GetStorageFactory(string storage)
        {
            switch(storage)
            {
                case "InMemory":
                    return new InMemoryStorage();
                case "FileMemory":
                    return new FileBAsedMemoryStrorage();
                default:
                    throw new NotImplementedException();
            }
        }
    }
}
