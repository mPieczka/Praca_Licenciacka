//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MojDziennikv4.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Legal_Guardian : IPerson
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Legal_Guardian()
        {
            this.Pupil = new HashSet<Pupil>();
        }
    
        public int Legal_Guardian_Id { get; set; }
        public string First_Name { get; set; }
        public string Middle_Name { get; set; }
        public string Surname { get; set; }
        public string Telefon_Number { get; set; }
        public int Account_Id { get; set; }
        public string Adress { get; set; }
    
        public virtual Account Account { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Pupil> Pupil { get; set; }
    }
}
