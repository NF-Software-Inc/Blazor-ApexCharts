﻿using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace ApexCharts
{
    public class ListPoint<TItem> : IDataPoint<TItem>
    {
        public string FillColor { get; set; }
    
        public object X { get; set; }
        [JsonIgnore(Condition = JsonIgnoreCondition.Never)]
        
        public IEnumerable<decimal?> Y { get; set; }

        public object Extra { get; set; }

        [JsonIgnore]
        public IEnumerable<TItem> Items { get; set; }
    }
}
