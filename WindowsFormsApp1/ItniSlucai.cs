//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WindowsFormsApp1
{
    using System;
    using System.Collections.Generic;
    
    public partial class ItniSlucai
    {
        public int id { get; set; }
        public int idPersonal { get; set; }
        public string operacionaSala { get; set; }
        public string tip { get; set; }
        public System.DateTime vreme { get; set; }
    
        public virtual Personal Personal { get; set; }
    }
}
