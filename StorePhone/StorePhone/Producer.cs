//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace StorePhone
{
    using System;
    using System.Collections.Generic;
    
    public partial class Producer
    {
        public Producer()
        {
            this.Model = new HashSet<Model>();
        }
    
        public int ID { get; set; }
        public string Name { get; set; }
        public string Country { get; set; }
    
        public virtual ICollection<Model> Model { get; set; }
    }
}