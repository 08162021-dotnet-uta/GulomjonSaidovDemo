using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TargetStore;
using TargetStoreBusinessLayer.Interfaces;
using TargetStoreDbContext.Models;

namespace TargetStoreBusinessLayer
{
    public class StoreRepository : IStoreRepository
    {

        private readonly StoreAppContext _context;
        // Step 2 of DI - call for an instance from the DI system in the constructor.
        public StoreRepository(StoreAppContext context)
        {
            _context = context;
        }

        public List<ViewModelStore> Stores()
        {
            List<Store> stores = _context.Stores.FromSqlRaw<Store>("select * from Stores").ToList();

            List<ViewModelStore> vms = new List<ViewModelStore>();
            foreach(Store s in stores)
            {
                vms.Add(ModelMapper.StoreToViewModelStore(s));
            }

            return vms;
        }
        //public  async Task<List<ViewModelStore>> StoresAsync(int id = -1)
        //{
        //    List<ViewModelStore> viewmodelstores = new List<ViewModelStore>();
        //    if (id == -1)
        //    {
        //        List<Store> stores = await _context.Stores.FromSqlRaw<Store>("select * from Stores").ToListAsync();
        //        // convert to ViewModelProduct
        //        foreach (Store s in stores)
        //        {
        //            viewmodelstores.Add(ModelMapper.StoreToViewModelStore(s));
        //        }
        //        return viewmodelstores;
        //    }
        //    else
        //    {
        //        List<Store> stores = await _context.Stores.FromSqlRaw<Store>("select TOP 1 from Stores where StoreId={0}", id).ToListAsync();
        //        // convert to ViewModelProduct
        //        foreach (Store s in stores)
        //        {
        //            viewmodelstores.Add(ModelMapper.StoreToViewModelStore(s));
        //        }
        //        return viewmodelstores;
        //    }
        //}
    }
}
