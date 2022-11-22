using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;


using System;
using System.Collections.Generic;
using System.Linq;


namespace FIHRexportsApp.Pages
{
    public class WizardModel : PageModel
    {

        public int file;

        public void OnGet()
        {
        }


        public void OnPost()
        {

            file++;
           
        }






    }
}
