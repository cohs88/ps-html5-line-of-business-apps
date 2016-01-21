﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;

using CodedHomes.Data;
using CodedHomes.Models;
using CodedHomes.Web.Filters;
using CodedHomes.Web.ViewModels;
using System.Web.Mvc;
using System.Web;

namespace CodedHomes.Web.Controllers
{
    [Authorize]
    public class HomesController : Controller
    {
        private ApplicationUnit _unit = new ApplicationUnit();
        [AllowAnonymous]
        public ActionResult Index()
        {
            HomesListViewModel vm = new HomesListViewModel();
            var query = this._unit.Homes.GetAll().OrderByDescending(s => s.Price);
            vm.Homes = query.ToList();

            return View("Index", vm);
        }

        protected override void Dispose(bool disposing)
        {
            this._unit.Dispose();
            base.Dispose(disposing);
        }
    }
}