using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FluentNHibernate.Mapping;
using GWS.Domain.Test;

namespace GWS.Hibernate.Mappings
{
   public  class CountryMapping:ClassMap<Country>
    {
       public CountryMapping()
       {
           LazyLoad();
           Table("Country");
           Id(x => x.CountryId).Column("Country_Id").GeneratedBy.Identity();
           Map(x => x.CountryName).Column("CountryName");

           HasMany<CarMake>(x => x.CarMake).KeyColumn("Country_Id").Cascade.AllDeleteOrphan().Inverse();
       }
    }


   public class CarMakeMapping : ClassMap<CarMake>
   {
       public CarMakeMapping()
       {
           LazyLoad();
           Table("CarMake");
           Id(x => x.MakeId).Column("Make_Id").GeneratedBy.Identity();
           Map(x => x.Make).Column("Make");
                      
           References<Country>(x => x.Country).Column("Country_Id");
           HasMany<Car>(x => x.Cars).KeyColumn("Make_Id").Cascade.All().Not.LazyLoad();
       }
   }

   public class CarMapping : ClassMap<Car>
   {
       public CarMapping()
       {
           LazyLoad();
           Table("Car");
           Id(x => x.Id).Column("Id");
           Map(x => x.Title).Column("Title");
           Map(x => x.Description).Column("Description");

           References<CarMake>(x => x.CarMake).Column("Make_Id").Cascade.All().Not.LazyLoad();
           
       }
   }

}
