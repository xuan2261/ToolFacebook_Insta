﻿using ControlLdPlayer.Repositories;
using CreateAccountsProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateAccountsProject.Repositories
{
    public class DevicesRepository
    {
        public List<Device> CheckDevicesAccount(string hostName)
        {
            List<Device> dv = new List<Device>();
            return dv;
        }

        public Device Add(Device device)
        {
            int id = TestDb.Devices.Count;
            device.Id = id;
            TestDb.Devices.Add(device);
            return device;
        }

    }
}
