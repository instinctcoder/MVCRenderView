using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RenderView.ViewModels;

namespace RenderView.Controllers
{
    public class ContactController : Controller
    {
        //
        // GET: /Contact/

        public ActionResult Index()
        {
            var contactinfo = new Contact();
            var Employer1 = new Employer();
            var Employer2 = new Employer();

            contactinfo.name = "Foo";
            contactinfo.title="Mr";
            contactinfo.age = 34;

            Employer1.name = "ABC";
            Employer1.yearofservice = "2";


            Employer2.name = "instinctcoder.com";
            Employer2.yearofservice = "1";

            contactinfo.employers.Add(Employer1);
            contactinfo.employers.Add(Employer2);


            return View(contactinfo);
        }

        public ActionResult LoopDetail()
        {
            var contactinfo = new Contact();
            var Employer1 = new Employer();
            var Employer2 = new Employer();

            contactinfo.name = "Foo";
            contactinfo.title = "Mr";
            contactinfo.age = 34;

            Employer1.name = "ABC";
            Employer1.yearofservice = "2";


            Employer2.name = "instinctcoder.com";
            Employer2.yearofservice = "1";

            contactinfo.employers.Add(Employer1);
            contactinfo.employers.Add(Employer2);


            return View(contactinfo);
        }

        [HttpPost]
        public void Index(Contact contact)
        {

            
        }

    }
}
