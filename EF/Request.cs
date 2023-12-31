//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Zero_Hunger.EF
{
    using System;
    using System.Collections.Generic;
    
    public partial class Request
    {
        public int req_id { get; set; }
        public string food_type { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public int quantity { get; set; }
        public int max_preservation_time { get; set; }
        public string location { get; set; }
        public string status { get; set; }
        public Nullable<int> rest_id { get; set; }
        public Nullable<int> assigned_employee_id { get; set; }
        public string details_food { get; set; }
        public Nullable<System.DateTime> date_of_order { get; set; }
    
        public virtual employee employee { get; set; }
        public virtual Restaurant Restaurant { get; set; }
    }
}
