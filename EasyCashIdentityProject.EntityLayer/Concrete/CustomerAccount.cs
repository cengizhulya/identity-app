﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyCashIdentityProject.EntityLayer.Concrete
{
    public class CustomerAccount
    {
        [Key]
        public int CustomerAccountID { get; set; }
        public string CustomerAccountNumber{ get; set; }
        public string CustomerAccountCurrency { get; set; }
        public string CustomerAccountBalance { get; set; }
        public string BankBranch { get; set; }
        public int AppUserId { get; set; }
        public AppUser AppUser { get; set; }
    }
}
