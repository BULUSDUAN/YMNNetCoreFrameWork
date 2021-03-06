﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace YMNNetCoreFrameWork.Core.Authoratication
{

    [Table("UserLogins")]
   public  class UserLogin:IdentityUserLogin<int>
    {

        [Key]
        public long Id { get; set; }

        public int TenantId { get; set; }

        public DateTime? CreateTime { get; set; }

        [MaxLength(255)]
        public string CreateUserId { get; set; }
    }
}
