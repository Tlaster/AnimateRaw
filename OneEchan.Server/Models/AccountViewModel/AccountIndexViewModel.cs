﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using cloudscribe.Core.Models;
using OneEchan.Server.Models;
using System.ComponentModel.DataAnnotations;

namespace OneEchan.Server.Models.AccountViewModel
{
    public class EditUserViewModel
    {
        [Required]
        public string Name { get; set; }
        public string Gender { get; set; }
        public string Description { get; set; }
        [Url]
        public string WebSiteUrl { get; set; }
    }
    public class AccountIndexViewModel : EditUserViewModel
    {
        [Url]
        public string AvaterUrl { get; set; }
    }
}