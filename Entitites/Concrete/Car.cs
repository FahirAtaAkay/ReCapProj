﻿using System;
using Entities.Abstract;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Car : IEntity
    {
        public int Id { get; set; }
        public int BrandId { get; set; }
        public string Description { get; set; }
        public int ColorId { get; set; }
        public double CurrentPrice { get; set; }

    }
}
