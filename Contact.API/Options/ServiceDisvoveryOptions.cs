﻿namespace Contact.API.Options
{
    public class ServiceDisvoveryOptions
    {
        public string UserServiceName { get; set; }
        public string ServiceName { get; set; }

        public ConsulOptions Consul { get; set; }
    }
}