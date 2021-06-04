﻿using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Car:IEntity
    {
        //Id, BrandId, ColorId, ModelYear, DailyPrice, Description
        public int Id { get; set; }
        public int BrandId { get; set; }
        public int ColorId { get; set; }
        public string  CarName { get; set; }
        public double DailyPrice { get; set; }
        public string ModelYear { get; set; }
      
        public string Description { get; set; }






    }
}
