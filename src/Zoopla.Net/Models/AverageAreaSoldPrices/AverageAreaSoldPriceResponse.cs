﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Zoopla.Net.Models.AverageSoldPrices;

namespace Zoopla.Net.Models.AverageAreaSoldPrices
{
    public class AverageAreaSoldPriceResponse : AverageSoldPriceResponse
    {
        public string Latitude { get; set; }
        public string Longitude { get; set; }
    }
}
