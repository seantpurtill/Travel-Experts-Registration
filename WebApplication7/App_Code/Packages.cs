using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication7
{
    public class CustomerPackage
    {
        public int PackageId { get; set; }
        public string PkgName { get; set; }
        public DateTime? PkgStartDate { get; set; }
        public DateTime? PkgEndDate { get; set; }
        public string PkgDesc { get; set; }
        public decimal PkgBasePrice { get; set; }
        public int BookingId { get; set; }
        public DateTime? BookingDate { get; set; }
    }
}