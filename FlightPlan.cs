//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DBFirst_EntityFrameWork
{
    using System;
    using System.Collections.Generic;
    
    public partial class FlightPlan
    {
        public int FlightPlan_ID { get; set; }
        public int FlightRoute_ID { get; set; }
        public int Flight_ID { get; set; }
        public int Airline_ID { get; set; }
        public Nullable<System.DateTime> ArrivalTime { get; set; }
        public Nullable<System.DateTime> DepartureTime { get; set; }
    
        public virtual Airline Airline { get; set; }
        public virtual Flight Flight { get; set; }
        public virtual FlightRoute FlightRoute { get; set; }
    }
}