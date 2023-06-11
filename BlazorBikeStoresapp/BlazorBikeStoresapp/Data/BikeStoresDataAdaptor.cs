using Syncfusion.Blazor;
using Syncfusion.Blazor.Data;

namespace Dapper.CRUD.Data
{
    public class BikeStoresDataAdaptor : DataAdaptor
    {
        private BikeStoresDataAccessLayer _dataLayer;
        public BikeStoresDataAdaptor(BikeStoresDataAccessLayer BikeStoresDataAccessLayer)
        {
            _dataLayer = BikeStoresDataAccessLayer;
        }

        public override async Task<object> ReadAsync(DataManagerRequest dataManagerRequest, string key = null)
        {
            List<BikeStores> bugs = await _dataLayer.GetBikeStoresAsync();
            int count = await _dataLayer.GetBikeStoresCountAsync();
            return dataManagerRequest.RequiresCounts ? new DataResult() { Result = BikeStores, Count = count } : count;
        }

        public override async Task<object> InsertAsync(DataManager dataManager, object data, string key)
        {
            await _dataLayer.AddBikeStoresAsync(data as BikeStores);
            return data;
        }

        public override async Task<object> UpdateAsync(DataManager dataManager, object data, string keyField, string key)
        {
            await _dataLayer.UpdateBikeStoresAsync(data as BikeStores);
            return data;
        }

        public override async Task<object> RemoveAsync(DataManager dataManager, object primaryKeyValue, string keyField, string key)
        {
            await _dataLayer.RemoveBikeStoresAsync(Convert.ToInt32(primaryKeyValue));
            return primaryKeyValue;
        }
    }
}