﻿
using _2021_2c_Clase_3_MVC.Servicios.Zodiaco;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _2021_2c_Clase_3_MVC.Controllers
{
    public class ZodiacoController : Controller
    {
        // GET: ZodiacoController
        public ActionResult Index()
        {
            return View(SignosServicio.ObtenerTodosCronologicamente());
        }
    }
}
