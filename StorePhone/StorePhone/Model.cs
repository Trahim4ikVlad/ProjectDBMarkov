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
    
    public partial class Model
    {
        public Model()
        {
            this.Specification = new HashSet<Specification>();
        }
    
        public int ID { get; set; }
        public string Model1 { get; set; }
        public int Producer { get; set; }
        public double Price { get; set; }
        public string OperationSystem { get; set; }
        public double Camera { get; set; }
        public int CountCore { get; set; }
        public int Memory { get; set; }
    
        public virtual Producer Producer1 { get; set; }
        public virtual ICollection<Specification> Specification { get; set; }
    }
}
