using calendar.Abstarct;
using calendar.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calendar.ENTİTİES
{
    internal class Meeting : Event, INotification
    {
       

            public List<string> Guests { get; set; }

        public void GetNotification()
        {
            foreach (var guest in Guests)
            {
                Console.WriteLine($"ınviting:{ guest}");
            }
        }
    }

    }

