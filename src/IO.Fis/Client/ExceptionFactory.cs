using System;
using RestSharp;

namespace IO.Fis.Client
{
    public delegate Exception ExceptionFactory(string methodName, IRestResponse response);
}
