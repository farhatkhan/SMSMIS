﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Valency.Models.Console;
using Valency.Models.Console.Admin;

namespace ValencyWeb.Controllers
{
    public partial class AdminController : Controller
    {
        //[HttpPost]
        //public JsonResult saveUserTypeBranch(comUserTypeBranches comusertypebranch)
        //{
        //    try
        //    {
        //        new hdlUserTypeBranches().save(comusertypebranch);
        //    }
        //    catch (Exception ex)
        //    {
        //        Response.StatusCode = 500;
        //        return Json(new { error = ex.Message });
        //    }
        //    return getBranches();
        //}
        //[HttpPost]
        //public JsonResult getUserTypeBranch(Guid BranchID)
        //{
        //    try
        //    {
        //        return Json(new hdlUserTypeBranches().SelectByID(BranchID), JsonRequestBehavior.AllowGet);
        //    }
        //    catch (Exception ex)
        //    {
        //        Response.StatusCode = 500;
        //        return Json(new { error = ex.Message });
        //    }
        //}

        //public JsonResult getUserTypeBranch()
        //{
        //    return Json(new Valency.Models.Console.Admin.hdlBranch().SelectAll(), JsonRequestBehavior.AllowGet);
        //}
        //[HttpPost]
        //public JsonResult deleteUserTypeBranch(comUserTypeBranches branch)
        //{
        //    try
        //    {
        //        new hdlUserTypeBranches().delete(branch);
        //    }
        //    catch (Exception ex)
        //    {
        //        Response.StatusCode = 500;
        //        return Json(new { error = ex.Message });
        //    }
        //    return getBranches();
        //}
    }
}