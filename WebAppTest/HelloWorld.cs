using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using AspNetAdapter;

namespace WebAppTest
{
  public class HelloWorld : IAspNetAdapterApplication
  {
    public void Init(Dictionary<string, object> app,
                     Dictionary<string, object> request,
                     Action<Dictionary<string, object>> response)
    {
      response(new Dictionary<string, object>
      {
        {HttpAdapterConstants.ResponseBody, "<h1>Hello, World</h1>"}
      });
    }
  }
}