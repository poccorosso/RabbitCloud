﻿using Microsoft.Extensions.Primitives;
using System;
using System.Collections.Generic;
using System.IO;

namespace Rabbit.Cloud.Client.Features
{
    public class ResponseFeature : IResponseFeature
    {
        public ResponseFeature()
        {
            StatusCode = 200;
            Headers = new Dictionary<string, StringValues>(StringComparer.OrdinalIgnoreCase);
            Body = Stream.Null;
        }

        #region Implementation of IResponseFeature

        public int StatusCode { get; set; }
        public IDictionary<string, StringValues> Headers { get; set; }
        public Stream Body { get; set; }
        public virtual bool HasStarted => false;

        #endregion Implementation of IResponseFeature
    }
}