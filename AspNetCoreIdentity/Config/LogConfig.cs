using KissLog;
using KissLog.Apis.v1.Listeners;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreIdentity.Config
{
    public static class LogConfig
    {
        public static void RegisterKissLogListeners(IConfiguration configuration)
        {
            KissLogConfiguration.Listeners.Add(new KissLogApiListener(
                configuration["8798df6a-00d2-43ea-8310-b63b259eb611"],
                configuration["254ce7bb-24c4-41fe-a701-c5085b42824f"],
                configuration["https://api.kisslog.net"]
            ));     
        }
    }
}
