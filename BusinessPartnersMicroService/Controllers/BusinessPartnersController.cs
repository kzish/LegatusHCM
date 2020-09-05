using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using BusinessPartnersMicroService.Models;
using AutoMapper;
using Newtonsoft.Json;

namespace BusinessPartnersMicroService.Controllers
{
    [Route("LegatusHCM/api/")]
    public class BusinessPartnersController : Controller
    {

        private dbContext db = new dbContext();

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
            db.Dispose();
        }


        /// <summary>
        /// list all business partners from the specified company
        /// </summary>
        /// <returns></returns>
        [HttpGet("BusinessPartners")]
        public JsonResult BusinessPartners()
        {
            try
            {
                var business_partners = db.MBusinessPartners.ToList();
                return Json(new
                {
                    res = "ok",
                    data = business_partners
                });
            }
            catch (Exception ex)
            {
                return Json(new
                {
                    res = "err",
                    data = ex.Message
                });
            }
        }

        /// <summary>
        /// fetch a single business partner
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("BusinessPartners/{id}")]
        public JsonResult BusinessPartners([FromRoute]string id)
        {
            try
            {
                var business_partners = db.MBusinessPartners.Where(i => i.Id == id).FirstOrDefault();
                return Json(new
                {
                    res = "ok",
                    data = business_partners
                });
            }
            catch (Exception ex)
            {
                return Json(new
                {
                    res = "err",
                    data = ex.Message
                });
            }
        }


        /// <summary>
        /// create a new business partner
        /// </summary>
        /// <param name="business_partner"></param>
        /// <returns></returns>
        [HttpPost("BusinessPartners")]
        public JsonResult BusinessPartners([FromBody] Shared.MBusinessPartners business_partner)
        {
            try
            {
                var new_business_partner = Globals.AutoMapper<Shared.MBusinessPartners, MBusinessPartners>(business_partner);
                new_business_partner.Id = null;//id will be populated as new_id() in sqlserver
                db.MBusinessPartners.Add(new_business_partner);
                db.SaveChanges();
                return Json(new
                {
                    res = "ok",
                    data = "Business Partner Created"
                });
            }
            catch (Exception ex)
            {
                return Json(new
                {
                    res = "err",
                    data = ex.Message
                });
            }
        }


        /// <summary>
        /// updates the busines partner
        /// </summary>
        /// <param name="business_partner"></param>
        /// <returns></returns>
        [HttpPatch("BusinessPartners")]
        public JsonResult UpDateBusinessPartners([FromBody] Shared.MBusinessPartners business_partner)
        {
            try
            {
                var existing_business_partner = db.MBusinessPartners.Find(business_partner.Id);
                Globals.AutoMapper<Shared.MBusinessPartners, MBusinessPartners>(business_partner, existing_business_partner);
                db.SaveChanges();
                return Json(new
                {
                    res = "ok",
                    data = "Business Partner Updated"
                });
            }
            catch (Exception ex)
            {
                return Json(new
                {
                    res = "err",
                    data = ex.Message
                });
            }
        }


        /// <summary>
        /// updates the busines partner
        /// </summary>
        /// <param name="business_partner"></param>
        /// <returns></returns>
        [HttpDelete("BusinessPartners/{id}")]
        public JsonResult DeleteBusinessPartners([FromRoute]string id)
        {
            try
            {

                var business_partner = db.MBusinessPartners.Where(i => i.Id == id).FirstOrDefault();
                if (business_partner == null)
                {
                    return Json(new
                    {
                        res = "err",
                        data = "Business Partner Does not Exist"
                    });
                }
                else
                {
                    db.MBusinessPartners.Remove(business_partner);
                    db.SaveChanges();
                    return Json(new
                    {
                        res = "ok",
                        data = "Business Partner Deleted"
                    });
                }
            }
            catch (Exception ex)
            {
                return Json(new
                {
                    res = "err",
                    data = ex.Message
                });
            }
        }


    }
}
