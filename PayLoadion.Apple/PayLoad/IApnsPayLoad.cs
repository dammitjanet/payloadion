﻿using System.Collections;
using System.Collections.Generic;
using PayLoadion.Apple.PayLoad.Alert;
using PayLoadion.PayLoad;

namespace PayLoadion.Apple.PayLoad
{
    public interface IApnsPayLoad : IPayLoad
    {
        IAlert Alert { get; }

        string AlertMessage { get; }

        int? Badge { get; }

        string Sound { get; }

        int? ContentAvailable { get; }

        string Category { get; }
    }
}