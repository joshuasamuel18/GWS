using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity.Mvc4;
using Microsoft.Practices.Unity;
using GWS.Repository.Interfaces;
using GWS.Repository;
namespace GWS.Dependency
{
  public class RegisterDependency
    {
      public static IUnityContainer UnityContainer()
      {
          var container = new UnityContainer();

          container.RegisterType<IBaseRepository, BaseRepository>();

          return container;
      }
    }
}
