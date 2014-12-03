using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity.Mvc4;
using Microsoft.Practices.Unity;
using System.Web.Mvc;
namespace GWS.Dependency
{
   public class Ioc
    {
       public static IUnityContainer Initialise()
       {
           var container = RegisterDependency.UnityContainer();

           DependencyResolver.SetResolver(new UnityDependencyResolver(container));

           return container;
       }
    }
}
