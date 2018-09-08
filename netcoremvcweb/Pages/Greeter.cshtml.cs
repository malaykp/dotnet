using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using netcoremvcweb.services;

namespace netcoremvcweb._Pages
{
    public class GreeterModel : PageModel
    {
        public int Id { get; set; }
        public string CurrentMessage { get; set; }
        private readonly IGreeting _greeter;

        public GreeterModel(IGreeting greeter)
        {
            _greeter = greeter;
        }
        public void OnGet(int id)
        {
           CurrentMessage = _greeter.GetGreetings();
        }

    }
}