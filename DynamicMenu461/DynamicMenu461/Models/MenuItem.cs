using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DynamicMenu461.Models
{
    public class MenuItem
    {
        public string ControllerName { get; set; }
        public string ActionName { get; set; }
        public string LinkText { get; set; }
    }
}