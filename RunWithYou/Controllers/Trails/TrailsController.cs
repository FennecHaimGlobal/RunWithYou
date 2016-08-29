using RunWithYou.Models;
using RunWithYouBusiness;
using RunWithYouEntities;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Claims;
using System.Web;
using System.Web.Mvc;

namespace RunWithYou.Controllers
{
    public class TrailsController : Controller
    {
        private ITrailsManager m_trailsManager = TrailsManager.GetInstance;

        // GET: Trails/Trails
        public ActionResult Index()
        {
            return View();
        }

        // GET: Trails/Trails/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Trails/Trails/Create
        public ActionResult Create()
        {
            ViewBag.trailtype = new TrailTypes().TrailType
                              .Select(p=> new SelectListItem
                              {
                                  Text = p.DisplayName,
                                  Value = p.EnglishName,
                              }).ToList();
            return View();
        }

        [Authorize]
        // POST: Trails/Trails/Create
        [HttpPost]
        public ActionResult Create(TrailsViewModels collection)
        {
            try
            {
                var claimsIdentity = User.Identity as ClaimsIdentity;

                if (claimsIdentity != null)
                {
                    // the principal identity is a claims identity.
                    // now we need to find the NameIdentifier claim
                    var userIdClaim = claimsIdentity.Claims
                        .FirstOrDefault(x => x.Type == ClaimTypes.NameIdentifier);

                    if (userIdClaim != null)
                    {
                        var userIdValue = userIdClaim.Value;

                        collection.Trail.created_by = userIdValue;

                        m_trailsManager.CreateInAsync(collection.Trail).Wait();
                    }
                }

                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                return View();
            }
        }

        // GET: Trails/Trails/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Trails/Trails/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, TrailsViewModels collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Trails/Trails/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Trails/Trails/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, TrailsViewModels collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
