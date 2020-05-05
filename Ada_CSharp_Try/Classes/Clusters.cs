using System;
using System.Collections.Generic;

namespace Ada_CSharp_Try.Classes
{
    public class Dimension_Cluster
    {
        public Dimension_Cluster(bool is_top_cluster, Dimension_Instance seed_instance, Dictionary<string, Tuple<double, double>> parent_dimension_set, double parent_deviation_multiplier)
        {
            ID = Guid.NewGuid();
            Is_Top_Cluster = is_top_cluster;

            Child_Pressure = 0.0;
            Cumulative_Match_Success_Count = 0;
            Cumulative_Match_Failure_Count = 0;
            Child_Clusters = new List<Dimension_Cluster>();

            Generated_Magnitude = 0.0;
            Cumulative_Interest = 0.0;
            Matched_Instance_Ids = new List<Guid>();

            Matched_Instance_Ids.Add(seed_instance.ID);
        }

        public Guid ID { get; set; }
        public bool Is_Top_Cluster { get; set; }

        //Tuple values are <Centroid, Deviation> respectively
        public Dictionary<string, Tuple<double, double>> Dimension_Set { get; set; }

        public double Child_Pressure { get; set; }
        public int Cumulative_Match_Success_Count { get; set; }
        public int Cumulative_Match_Failure_Count { get; set; }
        public List<Dimension_Cluster> Child_Clusters { get; set; }

        public double Generated_Magnitude { get; set; }
        public double Cumulative_Interest { get; set; }
        public List<Guid> Matched_Instance_Ids { get; set; }

        //temporary variables - not for persistence
        public double pre_sibling_inhibition_match_score { get; set; }
        public double post_sibling_inhibition_match_score { get; set; }
        public double sibling_inhibition_input { get; set; }

        public bool Pre_Sibling_Inhibition_Compare(double match_threshold)
        {
            return false;
        }

        public void Inhibit_Sibling_Inhibition_Compare(double sibling_inhibition_power)
        {
            
        }

        public void Merge_Instance(Dimension_Instance matched_instance)
        {

        }

        public void Instantiate_Child_Cluster(Dimension_Instance seed_instance, double child_deviation_multiplier)
        {

        }
    }
}
