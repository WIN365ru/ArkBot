﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArkBot.WebApi.Model
{
    public class UserViewModel
    {
        public string Name { get; set; }
        public string SteamId { get; set; }
        public bool IsAdmin { get; set; }
    }
}