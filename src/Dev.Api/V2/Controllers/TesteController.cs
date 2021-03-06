﻿using Dev.Api.Controllers;
using Dev.Business.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;

namespace Dev.Api.V2.Controllers
{
    [ApiVersion("2.0")]
    [Route("api/v{version:apiVersion}/teste")]
    public class TesteController : MainController
    {

        public TesteController(INotificador notificador, IUser appUser) : base(notificador, appUser)
        {
        }

        [HttpGet]
        public string Valor()
        {
            throw new Exception("error");

            return "Sou a V2";
        }
    }
}