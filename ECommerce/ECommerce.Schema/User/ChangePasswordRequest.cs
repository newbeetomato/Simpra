﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Schema.User
{
    public class ChangePasswordRequest
    {
        public string OldPassword { get; set; }
        public string Password { get; set; }
    }
}
