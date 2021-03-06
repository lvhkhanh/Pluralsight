﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarsIsland.WebAPI.Core.DTOs;
using CarsIsland.WebAPI.Core.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CarsIsland.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarsController : ControllerBase
    {
        private readonly ICarsDataService _carsDataService;
        public CarsController(ICarsDataService carsDataService)
        {
            _carsDataService = carsDataService;
        }

        [HttpGet]
        public async Task<IEnumerable<CarDto>> Get()
        {
            var availableCars = await _carsDataService.GetAvailableCars();
            return availableCars;
        }
    }
}