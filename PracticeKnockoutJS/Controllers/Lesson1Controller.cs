using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PracticeKnockoutJS.Controllers
{
    public class Lesson1Controller : Controller
    {
        //demo binding between view and viewModel
        //ko.apply(new AppViewModel()); 
        public ActionResult Lesson1_1()
        {
            return View();
        }

        //base on lesson1-1 , set viewModel.properties observable
        public ActionResult Lesson1_2()
        {
            return View();
        }

        //base on lesson1-2 , use two viewModel property to make another computed text
        //ko.computed()
        public ActionResult Lesson1_3()
        {
            return View();
        }
        
        //base on lesson1-3 , add more behavior
        //make FirstName , LastName ToUpper or ToLower
        public ActionResult Lesson1_4()
        {
            return View();
        }
    }
}