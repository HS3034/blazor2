using BlazorApp3.Model;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp3.Pages
{
    public class EmployeeOverviewBase : ComponentBase
    {
        public List<Empoloyee> Empoloyees { get; set; }

        protected override Task OnInitializedAsync()
        {
            Inittializeemployee();
            return base.OnInitializedAsync();
        }


        public void Inittializeemployee() 
        {
            Empoloyees = new List<Empoloyee>() { 
               new Empoloyee { Id = 1, Name = "Tahz" },
                new Empoloyee { Id = 2, Name = "Smith" },
                new Empoloyee { Id= 3,Name = "Naaan" }
            };
        }


    }
}
