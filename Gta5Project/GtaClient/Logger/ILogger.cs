﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GtaClient.Logger
{
    public interface ILogger
    {
        void Trace(string message);

        void Info(string message);

        void Exception(string message, Exception exception);
    }
}
