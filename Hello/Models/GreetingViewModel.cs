using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Greet;
namespace Hello.Models
{
    public class GreetingViewModel
    {
        private string greetingMessage;
        public string GreetingMessage
        {
            get
            {
                return this.greetingMessage;
            }
        }

        public GreetingViewModel()
        {
            var greeting = new Greeting();
            this.greetingMessage = greeting.GetGreetingMessage();
        }
    }
}
