﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebProject.Controllers
{
    public class BlogController : Controller
    {
        public ActionResult SingleBlog() => View();

        public ActionResult AllBlogs() => View();
    }
}