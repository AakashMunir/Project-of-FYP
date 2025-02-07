//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FYP.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;

    public partial class tbl_Hostel_Detail
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_Hostel_Detail()
        {
            this.tbl_Hostel_Booking = new HashSet<tbl_Hostel_Booking>();
            this.tbl_Hostel_Images = new HashSet<tbl_Hostel_Images>();
            this.tbl_Rating = new HashSet<tbl_Rating>();
        }

        [DisplayName("Hostel ID")]
        
        public int H_Id { get; set; }
        [DisplayName("Name")]
        [Required(ErrorMessage = "Required")]
        public string H_Name { get; set; }
        [DisplayName("Address")]
        [Required(ErrorMessage = "Required")]
        public string H_Address { get; set; }
        [DisplayName("Mobile")]
        [Required(ErrorMessage = "Required")]
        public string H_Mobile { get; set; }
        [DisplayName("Description")]
        [Required(ErrorMessage = "Required")]
        public string H_Description { get; set; }
        [DisplayName("Nearest University")]
        [Required(ErrorMessage = "Required")]
        public string H_Near_University { get; set; }
        [DisplayName("Nearest Area")]
        [Required(ErrorMessage = "Required")]
        public string H_Area { get; set; }
        [DisplayName("Total Room")]
        [Required(ErrorMessage = "Required")]
        public Nullable<int> H_Total_Room { get; set; }
        [DisplayName("Avail Room")]
        [Required(ErrorMessage = "Required")]
        public Nullable<int> H_Avail_Room { get; set; }
        [DisplayName("Security")]
        [Required(ErrorMessage = "Required")]
        public Nullable<int> H_Security { get; set; }
        [DisplayName("Wifi Charges")]
        [Required(ErrorMessage = "Required")]
        public Nullable<int> H_Wifi_Charges { get; set; }
        public Nullable<int> HC_Id { get; set; }
        public Nullable<int> HF_Id { get; set; }
        public Nullable<int> HS_Id { get; set; }
        public Nullable<int> U_Id { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_Hostel_Booking> tbl_Hostel_Booking { get; set; }
        public virtual tbl_Hostel_Category tbl_Hostel_Category { get; set; }
        public virtual tbl_Hostel_Facility tbl_Hostel_Facility { get; set; }
        public virtual tbl_Hostel_Status tbl_Hostel_Status { get; set; }
        public virtual tbl_User_info tbl_User_info { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_Hostel_Images> tbl_Hostel_Images { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_Rating> tbl_Rating { get; set; }
    }
}
