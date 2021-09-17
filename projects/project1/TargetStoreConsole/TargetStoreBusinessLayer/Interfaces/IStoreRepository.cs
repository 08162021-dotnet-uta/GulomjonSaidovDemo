using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TargetStoreBusinessLayer.Interfaces
{
    public interface IStoreRepository
    {
        List<ViewModelStore> Stores();
    }
}
