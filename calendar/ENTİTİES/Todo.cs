﻿using calendar.Abstarct;
using calendar.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calendar.ENTİTİES
{
    internal class Todo:Event,INotification
    {

        public string Importance { get; set; }
      
        public void GetNotification()
        {
            Console.WriteLine($"time to make this todo:{Title}");
                }
    }
}
