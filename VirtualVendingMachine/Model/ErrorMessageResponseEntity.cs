using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VirtualVendingMachine.Models
{
    public class ErrorMessageResponseEntity
    {
        private string message = "";

        public string Message
        { get { return message; } set { message = value; } }
    }
}