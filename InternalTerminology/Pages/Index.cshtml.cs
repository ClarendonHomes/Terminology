using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;

namespace InternalTerminology.Pages
{
    public class IndexModel : PageModel
    {
        #region Properties

        //private readonly IConfiguration _config;

        public List<Term> Terms { get; set; }

        #endregion Properties

        #region Constructors 

        public IndexModel() { }

        //public IndexModel(IConfiguration config)
        //{
        //    _config = config;

        //}
        
        #endregion Constructors 

        public void OnGet()
        {
           /* Term term1 = new Term(9999,"Test","Sample");


            var termid = term1.Id; */
        }
    }
}
