using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using BE;
using System.Net.Http;
using RestSharp;
using System.Web.Compilation;
using System.Linq.Expressions;


namespace DAL
{
    public class AddressCalculations
    {
        /// <summary>
        /// בדיקה האם הכתובת שהוזנה הינה כתובת אמיתית
        /// </summary>
        /// <param name="address"></param>
        /// <returns></returns>
        /// 

        public AddressCalculations()
        {

        }

        public bool IsRealAdrressApi(Address address)
        {
            JObject contentAsJSON = GetAdderssJsonApi(address);
            string street = contentAsJSON["results"][0]["locations"][0]["street"].ToString();
            return street.Contains(address.address_street);
        }

        private JObject GetAdderssJsonApi(Address address)
        {
            string location = address.varification() + " ישראל";
            string KEY = @"aAT8GkGFVaD8XYvoxrV3m5V8ipGZ7XsF";

            var client = new RestClient("http://www.mapquestapi.com/geocoding/v1/address");
            client.Timeout = -1;

            var request = new RestRequest(Method.POST);
            request.AddParameter("key", KEY);
            request.AddParameter("location", location);
            request.AddParameter("maxResults", 1);
            request.AddParameter("thumbMaps", false);

            IRestResponse response = client.Execute(request);
            Console.WriteLine(response.Content);

            object deserializeContent = JsonConvert.DeserializeObject<object>(response.Content);
            return JObject.Parse(deserializeContent.ToString());
        }

        /// <summary>
        /// מציאת קורדינאטות של כתובת נתונה
        /// </summary>
        public double[] getLatLongFromAddress(Address address)
        {
            JObject contentAsJSON = GetAdderssJsonApi(address);
            double latitude = double.Parse(contentAsJSON["results"][0]["locations"][0]["latLng"]["lat"].ToString());
            double longitude = double.Parse(contentAsJSON["results"][0]["locations"][0]["latLng"]["lng"].ToString());
            return new double[] { latitude, longitude };
        }
     
        /// <summary>
        /// חישוב מרחק בקילומטרים בין 2 כתובות נתונות
        /// </summary>
        /// <param name="a1"></param>
        /// <param name="a2"></param>
        /// <returns></returns>
        public double calculateDistance(double[] d1, double[] d2)
        {
            double lat1 = d1[0];
            double lat2 = d2[0];
            double lon1 = d1[1];
            double lon2 = d2[1];

            var R = 6372.8; // In kilometers
            var dLat = (toRadians(lat2 - lat1));
            var dLon = (toRadians(lon2 - lon1));
            lat1 = toRadians(lat1);
            lat2 = toRadians(lat2);

            var a = Math.Sin(dLat / 2) * Math.Sin(dLat / 2) + Math.Sin(dLon / 2) * Math.Sin(dLon / 2) * Math.Cos(lat1) * Math.Cos(lat2);
            var c = 2 * Math.Asin(Math.Sqrt(a));
            return R * 2 * Math.Asin(Math.Sqrt(a));

        }
        public double toRadians(double angle)
        {
            return Math.PI * angle / 180.0;
        }


        /*
     /// <summary>
     /// מציאת קורדינאטות של כתובת 
     /// </summary>
     /// <param name="address"></param>
     /// <returns></returns>
     public async Task<double[]> GetLatLongFromAddress(Address address)
     {
         try
         {
             var contentAsJSON = await GetAdderssJson(address);
             var json = JArray.Parse(contentAsJSON.ToString());
             double latitude = double.Parse(json[0]["lat"].ToString());
             double longitude = double.Parse(json[0]["lon"].ToString());
             return new double[] { latitude, longitude };
         }
         catch (Exception exp)
         {
             throw exp;
         }
     }
     private async Task<Place> GetAdderssJson(Address address)
     {
         string key = "3dafe75c090558";
         string url = @"https://eu1.locationiq.com/v1/search.php?key=" + key + "&q=" + address.varification() + "&format=json";

         object jasonObject = new object();
         try
         {
             using (HttpClient client = new HttpClient())
             {
                 var content = new StringContent(jasonObject.ToString(), Encoding.UTF8, "applicaton/json");
                 var response = await client.PostAsync(url, content);
                 if (response != null)
                 {
                     var jasonString = await response.Content.ReadAsStringAsync();
                     return JsonConvert.DeserializeObject<Place>(jasonString);
                 }
             }
         }
         catch (Exception)
         {
             throw new Exception("כתובת לא תקינה");
         }
         return null;
     }
     */

    }
}

