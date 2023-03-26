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
       
        public IActionResult DownloadFile(MyData myData,string full_name)
        {
            ShareString(full_name,myData);
            if (_myData == null)
            {
                return BadRequest("Person data is empty");
            }

            // Serialize person data to JSON
            var json = JsonConvert.SerializeObject(myData);
            var fileName = "data.json";

            var fileBytes = Encoding.UTF8.GetBytes(json);

            // Download file
            return File(fileBytes, "application/json", fileName);
        }
        
        private void ShareString(string fullName,MyData myData)
        {
            string[] names = fullName.Split(' '); // Разделение строки по пробелам
            MyData.FullName fullNames = new MyData.FullName(names[0], names[1], names[2]);
            myData.full_name = fullNames;
        }

        public IActionResult Privacy()
        {
            throw new NotImplementedException();
        }
    }
}