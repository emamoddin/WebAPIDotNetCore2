using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApplicationtest.Controllers
{
    [Produces("application/json")]
    [Route("api/API")]
    public class SimpleapiController : Controller
    {

    public string[] Get()
    {
        return new string[]
        {
        "Hello",
        "World"
        };
    }

}
}