﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace WcfRestClient.Core
{
    public interface IAsyncRequestProcessor : IDisposable
    {
        Task<T> GetResultAsync<T>(string uriTemplate, string method, Dictionary<string, object> uriParameters, Dictionary<string, object> bodyParameters);
        Task ExecuteAsync(string uriTemplate, string method, Dictionary<string, object> uriParameters, Dictionary<string, object> bodyParameters);
    }
}
