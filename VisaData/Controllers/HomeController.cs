using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.IO;
using System.Text;

namespace MyWebApplication.Controllers
{
    public class HomeController : Controller
    {
        private MyData _myData = new MyData();
        

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SaveData(string name, string secondName, int marital_status,int year,int month,int day,
            string birthSity,string birthCountry,string citizenship,bool hasOtherCitizenship,bool hasOtherCountryPassport,
            string otherCountryPassportNumber,bool isPermanentResident,string residenceCountry)
        {
            ShareString(name);
            _myData.second_name = secondName;
            _myData.marital_status = marital_status;
            _myData.birth_date = new MyData.BirthDate(day, month, year);
            _myData.birth_sity = birthSity;
            _myData.birth_country = birthCountry;
            _myData.sitizenship = new MyData.Sitizenship(citizenship, hasOtherCitizenship, hasOtherCountryPassport,
                otherCountryPassportNumber, isPermanentResident, residenceCountry);
            _myData.sitizenship.second_sitizenship = hasOtherCitizenship;

            var jsonString = JsonConvert.SerializeObject(_myData);
            var fileName = "data.json";
            var fileBytes = Encoding.UTF8.GetBytes(jsonString);

            return File(fileBytes, "application/json", fileName);
        }
        
        private void ShareString(string fullName)
        {
            string[] names = fullName.Split(' '); // Разделение строки по пробелам
            MyData.FullName fullNames = new MyData.FullName(names[0], names[1], names[2]);
            _myData.full_name = fullNames;
        }

        public IActionResult Privacy()
        {
            throw new NotImplementedException();
        }
    }
}