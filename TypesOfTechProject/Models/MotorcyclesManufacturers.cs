using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TypesOfTechProject.Models
{
    public class TechManufacturers
    {

        public TechType motoList
        {
            get
            {
                List< string > motoManufacturersList = new List<string>();
                motoManufacturersList.Add("Honda");
                motoManufacturersList.Add("Kawasaki");
                motoManufacturersList.Add("Suzuki");
                motoManufacturersList.Add("Harley-Davidson");

                TechType motorcyclesManufacturers = new TechType("Производители мотоциклов", motoManufacturersList);

                return motorcyclesManufacturers;
            }
        }
        
    }
}