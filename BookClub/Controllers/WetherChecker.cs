﻿using Microsoft.AspNetCore.Mvc;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;

namespace BookClub.Controllers
{
    public class WetherChecker : Controller
    {
        [Route("api/[controller]")]
        public class WeatherController : Controller
        {

            [HttpGet("[action]/{city}")]
            public async Task<IActionResult> City(string city)
            {
                using (var client = new HttpClient())
                {
                    try
                    {
                        client.BaseAddress = new Uri("http://api.openweathermap.org/data/2.5/weather?q=London,uk&appid=049a8f0c6262b4b96bbf0e52c61db09c");
                        var response = await client.GetAsync($"/data/2.5/weather?q={city}&appid=049a8f0c6262b4b96bbf0e52c61db09c&units=metric");
                        response.EnsureSuccessStatusCode();

                        var stringResult = await response.Content.ReadAsStringAsync();
                        var rawWeather = JsonConvert.DeserializeObject<OpenWeatherResponse>(stringResult);
                        return Ok(new
                        {
                            Temp = rawWeather.Main.Temp,
                            Summary = string.Join(",", rawWeather.Weather.Select(x => x.Main)),
                            City = rawWeather.Name
                        });
                    }
                    catch (HttpRequestException httpRequestException)
                    {
                        return BadRequest($"Error getting weather from OpenWeather: {httpRequestException.Message}");
                    }
                }
            }
        }
    }
}

