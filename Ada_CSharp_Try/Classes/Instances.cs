using System;
using System.Collections.Generic;

namespace Ada_CSharp_Try.Classes
{
    public class Dimension_Instance
    {
        public Dimension_Instance(string raw_value, Dictionary<string, double> dimension_set)
        {
            ID = Guid.NewGuid();
            Raw_Value = raw_value;
            Dimension_Set = dimension_set;
        }

        public Guid ID { get; set; }
        public string Raw_Value { get; set; }
        public Dictionary<string,double> Dimension_Set { get; set; }
    }
}
