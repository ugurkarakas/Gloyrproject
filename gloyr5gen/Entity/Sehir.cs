﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace gloyr5gen.Entity
{
    public class Sehir
    {
        public int SehirId { get; set; }

        public string SehirName { get; set; }

        public int AdvertisementId { get; set; }
        public Advertisement Advertisement { get; set; }
        public List<ulkecategory> Ulkecategories { get; set; }


    }
}
