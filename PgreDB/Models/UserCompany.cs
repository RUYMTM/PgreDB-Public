using System;
using System.Collections.Generic;

#nullable disable

namespace PgreDB.Models
{
    public partial class UserCompany
    {
        public int UserCompanyId { get; set; }
        public int CompanyId { get; set; }
        public int UserId { get; set; }
        public bool ActiveEwiserBillingNotification { get; set; }

        public virtual Company Company { get; set; }
        public virtual EwiserUser User { get; set; }
    }
}
