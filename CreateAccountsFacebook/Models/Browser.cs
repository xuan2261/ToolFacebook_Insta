﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateAccountsProject.Models
{
    public class Browser
    {
        public int Id { get; set; }

        public Device Device { get; set; }
        public int? DeviceId { get; set; }
        public string FileName { get; set; }
        public string Name { get; set; }
        public bool Status { get; set; }
        public Account Account { get; set; }
        public int AccountId { get; set; }
        public Browser()
        {

        }

        public Browser(string name, string fileName, bool status = false)
        {
            Name = name;
            Status = status;
        }
    }
}
