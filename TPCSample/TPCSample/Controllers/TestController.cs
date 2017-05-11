using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TPCSample.Models;
using UtilLib.ClassUtil;

namespace TPCSample.Controllers
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
            var tmpId = db.BillingDetails.Select(o => o.BillingDetailId).DefaultIfEmpty().Max();
            Random tmpRandom = new Random();
            db.BillingDetails.Add(new CreditCard
            {
                BillingDetailId = ++tmpId,
                Owner = $"Owner-{RandomUtil.GetLetters(3)}",
                Number = tmpRandom.Next(100).ToString(),
                CardType = tmpRandom.Next(3),
                ExpiryMonth = tmpRandom.Next(12).ToString(),
                ExpiryYear = tmpRandom.Next(99).ToString(),

            });
            db.BillingDetails.Add(new BankAccount
            {
                BillingDetailId = ++tmpId,
                Owner = $"Owner-{RandomUtil.GetLetters(3)}",
                Number = tmpRandom.Next(100).ToString(),
                BankName = $"BankName-{RandomUtil.GetLetters(3)}",
                Swift = $"Swift-{RandomUtil.GetLetters(3)}",

            });
            db.SaveChanges();
            return View();
        }

        public ActionResult RunCreate2()
        {
            var db = new InheritanceMappingContext();
            //var tmpId = db.BillingDetails.Select(o => o.BillingDetailId).DefaultIfEmpty().Max();
            Random tmpRandom = new Random();
            db.Cameras.Add(new Camera
            {
                //Id = 1,
                Caption = $"Caption-{RandomUtil.GetLetters(3)}",
                Manufacturer = $"Manufacturer-{RandomUtil.GetLetters(3)}",
                TypeNumber = $"TypeNumber-{RandomUtil.GetLetters(3)}",
                Lens = $"Lens-{RandomUtil.GetLetters(3)}"
            });
            db.SingleReflexCameras.Add(new SingleReflexCamera()
            {
                //Id = 2,
                Caption = $"Caption-{RandomUtil.GetLetters(3)}",
                Manufacturer = $"Manufacturer-{RandomUtil.GetLetters(3)}",
                TypeNumber = $"TypeNumber-{RandomUtil.GetLetters(3)}",
                LensMount = $"LensMount-{RandomUtil.GetLetters(3)}"
            });
            db.Lenses.Add(new Lens()
            {
                //Id = 3,
                Caption = $"Caption-{RandomUtil.GetLetters(3)}",
                Manufacturer = $"Manufacturer-{RandomUtil.GetLetters(3)}",
                TypeNumber = $"TypeNumber-{RandomUtil.GetLetters(3)}",
                FocalLength = $"FocalLength-{RandomUtil.GetLetters(3)}",
                MaxAperture = $"MaxAperture-{RandomUtil.GetLetters(3)}"

            });
            db.SaveChanges();
            return View();
        }
    }
}