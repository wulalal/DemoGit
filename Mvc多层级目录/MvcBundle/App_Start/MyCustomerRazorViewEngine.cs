﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcBundle
{
    public class MyCustomerRazorViewEngine : RazorViewEngine
    {
        public MyCustomerRazorViewEngine()
            : base()
        {
            //Area视图路径其中{2},{1},{0}分别代表Area名，Controller名，Action名
            AreaViewLocationFormats = new[] { "~/Views/{2}/{1}/{0}.cshtml", "~/Views/Shared/{0}.cshtml" };
            //Area模版路径
            AreaMasterLocationFormats = new[] { "~/Views/Shared/{0}.cshtml" };
            //Area的分部视图路径
            AreaPartialViewLocationFormats = new[] { "~/Views/{2}/{1}/{0}.cshtml", "~/Views/Shared/{0}.cshtml" };
            //主视图路径
            ViewLocationFormats = new[] { "~/Views/{1}/{0}.cshtml", "~/Views/Shared/{0}.cshtml" };
            //主模版路径
            MasterLocationFormats = new[] { "~/Views/Shared/{0}.cshtml" };
            //主分部视图路径
            PartialViewLocationFormats = new[] { "~/Views/{1}/{0}.cshtml", "~/Views/Shared/{0}.cshtml" };
        }

        protected override IView CreatePartialView(ControllerContext controllerContext, string partialPath)
        {
            return base.CreatePartialView(controllerContext, partialPath);
        }

        protected override IView CreateView(ControllerContext controllerContext, string viewPath, string masterPath)
        {
            return base.CreateView(controllerContext, viewPath, masterPath);
        }

        protected override bool FileExists(ControllerContext controllerContext, string virtualPath)
        {
            return base.FileExists(controllerContext, virtualPath);
        }
    }
}