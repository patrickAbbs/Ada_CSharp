using System;
namespace Ada_CSharp_Try.Classes
{
    public class Dimension_Space
    {
        public Dimension_Space(string space_name, double match_threshold, double sibling_inhibition_power, double disuse_deletion_ratio, double child_pressure_threshold, double child_deviation_multiplier)
        {
            ID = Guid.NewGuid();
            Space_Name = space_name;

            Match_Threshold = match_threshold;
            Sibling_Inhibition_Power = sibling_inhibition_power;
            Disuse_Deletion_Ratio = disuse_deletion_ratio;
            Child_Pressure_Threshold = child_pressure_threshold;
            Child_Deviation_Multiplier = child_deviation_multiplier;
        }

        public Guid ID { get; set; }
        public string Space_Name { get; set; }

        public double Match_Threshold { get; set; }
        public double Sibling_Inhibition_Power { get; set; }
        public double Disuse_Deletion_Ratio { get; set; }
        public double Child_Pressure_Threshold { get; set; }
        public double Child_Deviation_Multiplier { get; set; }

        public Dimension_Cluster Top_Cluster { get; set; }


        public bool Write_Recursion(Dimension_Instance instance, Dimension_Cluster cluster)
        {

            return false;
        }
    }
}
