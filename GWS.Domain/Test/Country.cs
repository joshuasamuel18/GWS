using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GWS.Domain.Test
{
   public class Country
    {
       public virtual long CountryId { get; set; }
       public virtual string CountryName { get; set; }

       public virtual IList<CarMake> CarMake { get; set; }
    }

   public class CarMake
   {
       public virtual long MakeId { get; set; }
       public virtual string Make { get; set; }

       public virtual Country Country { get; set; }
       public virtual IList<Car> Cars { get; set; }
   }

   public class Car
   {
       public virtual long Id { get; set; }
       public virtual string Title { get; set; }
       public virtual string Description { get; set; }

       public virtual CarMake CarMake { get; set; }
   }
}
