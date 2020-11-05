using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    [EnableCors("AllowOrigin")]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            try
            {

                HttpClient client = new HttpClient(); 

                var values = new Dictionary<string, string>
                {
                     { "key", "G32Ifn3s" },
                     {"salt", "5tjMLBmHtB"},
                { "hash", "PD1nWbsFNh8zfO7wClGvPSvi4/dck5w9LJtcwDfYnJ0="},
                    { "X-Version", "1"},
                    { "txnid", "1233aa33"},
                    { "amount", "9.05"},
                    { "productinfo", "p2"},
                    { "firstname", "Sinona1"},
                    { "email","sinona1@gmail.com"},
                    { "phone", "+91 9400838732"},
                    { "surl", "hjhjgjkl11h"},
                    { "furl","hkhlkh1kj"},
                   };

                var content = new FormUrlEncodedContent(values);

                var response =  client.PostAsync("https://test.payu.in/_payment", content);

             //   var responseString =  response.Content.ReadAsStringAsync();
               // Hashtable data = new Hashtable();

               // var client = new HttpClient();
               // HttpRequestMessage msg = new HttpRequestMessage(HttpMethod.Post,
               //                "https://test.payu.in/_payment");

               // var stringContent = new StringContent("", Encoding.UTF8, "application/json");
               // msg.Content = stringContent;
               //HttpResponseMessage resp = client.SendAsync(msg).Result;

                return View();

            }
            catch (Exception ex)
            {

                throw;
            }

            

            //data.Add("hash","");
            //data.Add("txnid", "Test");
            //data.Add("key", "G32Ifn3s");
            //data.Add("amount", "5");
            //data.Add("salt", "5tjMLBmHtB");
            //var response = client.SendAsync(httpRequestMessage).Result;
            //data.Add("Service_provider", "");
            // return preparePOSTForm("https://test.payu.in/_payment", data);

        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
