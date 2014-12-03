using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GWS.Repository.Interfaces
{
    public interface IBaseRepository
    {
        IList<T> GetAll<T>();
    }
}
