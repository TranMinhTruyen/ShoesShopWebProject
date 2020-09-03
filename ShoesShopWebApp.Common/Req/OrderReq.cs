using System;
using System.Collections.Generic;
using System.Text;

namespace ShoesShopWebApp.Common.Req
{
    public class OrderReq
    {
        public int OrderID { get; set; }
        public String Name { get; set; }
        public DateTime CreatedDate { get; set; }
        public String PhoneNumberOfOrder { get; set; }
        public String Address { get; set; }
        public String City { get; set; }
        public String Status { get; set; }
        public String Note { get; set; }
        public String EmpId { get; set; }
        public String CusId { get; set; }
    }
}
