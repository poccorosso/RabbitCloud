﻿using Microsoft.Extensions.Primitives;
using System;
using System.Collections.Generic;
using System.IO;

namespace Rabbit.Cloud.Client.Features
{
    public interface IRequestFeature
    {
        string Method { get; set; }
        Uri RequestUri { get; set; }
        IDictionary<string, StringValues> Headers { get; set; }
        Stream Body { get; set; }
    }
}