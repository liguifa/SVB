//------------------------------------------------------------------------------
// <auto-generated>
//    此代码是根据模板生成的。
//
//    手动更改此文件可能会导致应用程序中发生异常行为。
//    如果重新生成代码，则将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace SportsVenueBookingCommon.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Space
    {
        public Space()
        {
            this.Snookers = new HashSet<Snooker>();
        }
    
        public int space_Id { get; set; }
        public long space_User { get; set; }
        public string space_Name { get; set; }
        public bool space_IsDel { get; set; }
    
        public virtual ICollection<Snooker> Snookers { get; set; }
        public virtual User User { get; set; }
    }
}
