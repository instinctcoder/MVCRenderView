using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Collections.ObjectModel;

namespace RenderView.ViewModels
{
    public class Contact
    {
        public string name { get; set; }
        public string title { get; set; }
        public int age { get; set; }


        public Contact() {
            employers = new Collection<Employer>(); 
        }

        public virtual ICollection<Employer> employers { get; set; }

    }
}