using System;
using Microsoft.AspNetCore.Http;

namespace MyDogApp.API.Helpers
{
    public static class Extensions
    {
        public static void AddApplicationError(this HttpResponse response, string message)
        {
            response.Headers.Add("Application-Error", message);
            response.Headers.Add("Access-Control-Expose-Headers", "Application-Error");
            response.Headers.Add("Access-Control-Allow-Origin", "*");
        }

        public static int CalculateAge(this DateTime theDatetime) 
        {
            var age = DateTime.Today.Year - theDatetime.Year;
            if(theDatetime.AddYears(age) > DateTime.Today)
                age--;

            return age;
        }
    }
}