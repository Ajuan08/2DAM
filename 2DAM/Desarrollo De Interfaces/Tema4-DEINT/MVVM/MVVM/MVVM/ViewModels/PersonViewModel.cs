using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVVM.MVVM.Models;

namespace MVVM.MVVM.ViewModels
{
    public class PersonViewModel
    {
        public Person Person { get; set; }

        public PersonViewModel()
        {
            Person = new Person()
            {
                Name = "Antonio Juan",
                Age = 22,
                Married = false,
                BirthDate = new DateTime(2001, 09, 08),
                Weight = 100,
                Lunchtime = new TimeSpan(17, 10, 3)
            };
        }
    }
}
