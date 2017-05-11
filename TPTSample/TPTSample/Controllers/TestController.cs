using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TPTSample.Models;
using UtilLib.ClassUtil;

namespace TPTSample.Controllers
{
    public class TestController : Controller
    {
        public ActionResult RunOnModelCreating()
        {
            using (var model = new InheritanceMappingContext())
            {
                model.Database.Delete();
                model.Database.Create();
            }
            return View();
        }

        public ActionResult RunCreate()
        {
            var db = new InheritanceMappingContext();
            Random tmpRandom = new Random();
            db.BillingDetails.Add(new CreditCard
            {
                Owner = $"Owner-{RandomUtil.GetLetters(3)}",
                Number = tmpRandom.Next(100).ToString(),
                CardType = tmpRandom.Next(3),
                ExpiryMonth = tmpRandom.Next(12).ToString(),
                ExpiryYear = tmpRandom.Next(99).ToString(),

            });
            db.BillingDetails.Add(new BankAccount
            {
                Owner = $"Owner-{RandomUtil.GetLetters(3)}",
                Number = tmpRandom.Next(100).ToString(),
                BankName = $"BankName-{RandomUtil.GetLetters(3)}",
                Swift = $"Swift-{RandomUtil.GetLetters(3)}",

            });
            db.SaveChanges();
            return View();
        }
    }
}