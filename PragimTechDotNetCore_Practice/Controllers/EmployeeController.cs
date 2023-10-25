using Microsoft.AspNetCore.Mvc;
using PragimTechDotNetCore_Practice.Models;
using PragimTechDotNetCore_Practice.Repositories;
using PragimTechDotNetCore_Practice.ViewModels;

namespace PragimTechDotNetCore_Practice.Controllers
{
    
    [Route("[controller]/[action]")]
    public class EmployeeController : Controller
    {
        private IEmployeeRepository _employeeRepository;
        //private IWebHostEnvironment _hostingEnvironment;

        public EmployeeController(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
            //_hostingEnvironment = hostingEnvironment;
        }
        // This method return XML format data
        //[Produces("application/xml")]
        //public IActionResult Index()
        //{
        //    var employees = _employeeRepository.GetAllEmployee();

        //    return Ok(employees);
        //}        

        [Route("~/")]
        [Route("/employee")]
        [Route("~/employee/Index")]
        public IActionResult Index()
        {            
            var employees = _employeeRepository.GetAllEmployee();

            return View(employees);
        }

        public IActionResult Detail(int id)
        {            
            EmployeeDetailViewModel employeeViewModel = new()
            {
                Employee = _employeeRepository.GetEmplyees(id),
                PageTitle = "Employee Details"
            };

            return View(employeeViewModel);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(EmployeeCreateViewModel model)
        {
            //if (ModelState.IsValid)
            //{
            //    string uniquFileName = null;
            //    if (model.Photo != null)
            //    {
            //        string folderPath = Path.Combine(_hostingEnvironment.WebRootPath, "images");
            //        uniquFileName = Guid.NewGuid().ToString() + "_" + model.Photo.FileName;
            //        string filePath = Path.Combine(folderPath, uniquFileName);
            //        model.Photo.CopyTo(new FileStream(filePath, FileMode.Create));
            //    }
            //    Employee employee = new Employee()
            //    {
            //        Name = model.Name,
            //        Email = model.Email,
            //        Department = model.Department,
            //        PhotoPath = uniquFileName
            //    };

            //    var newEmployee = _employeeRepository.Add(employee);
            //    return RedirectToAction("Detail", new { id = newEmployee.Id });
            //}
            return View();
        }



        [HttpGet]
        public IActionResult Edit(int id)
        {
            var employee = _employeeRepository.GetEmplyees(id);
            if (employee != null)
            {
                EmployeeEditViewModel editViewModel = new EmployeeEditViewModel()
                {
                    Name = employee.Name,
                    Email = employee.Email,
                    Department = employee.Department,
                    ExistingPhotoPath = employee.PhotoPath,
                };

                return View(editViewModel);
            }
            return View("index");

        }

        [HttpPost]
        public IActionResult Edit(EmployeeEditViewModel model)
        {
            if (ModelState.IsValid)
            {
                Employee employee = _employeeRepository.GetEmplyees(model.Id);
                employee.Name = model.Name;
                employee.Email = model.Email;
                employee.Department = model.Department;
                if (model.Photo != null)
                {
                    if (model.ExistingPhotoPath != null)
                    {
                        //string filePath = Path.Combine(_hostingEnvironment.WebRootPath,
                        //    "images", model.ExistingPhotoPath);

                        //System.IO.File.Delete(filePath);
                    }
                    employee.PhotoPath = proccessUploadedFile(model);
                }


                var newEmployee = _employeeRepository.Update(employee);
                return RedirectToAction("index");
            }
            return View();
        }

        private string proccessUploadedFile(EmployeeCreateViewModel model)
        {
            string uniquFileName = null;
            if (model.Photo != null)
            {
                //string folderPath = Path.Combine(_hostingEnvironment.WebRootPath, "images");
                //uniquFileName = Guid.NewGuid().ToString() + "_" + model.Photo.FileName;
                //string filePath = Path.Combine(folderPath, uniquFileName);
                //using (FileStream fileStream = new FileStream(filePath, FileMode.Create))
                //{
                //    model.Photo.CopyTo(fileStream);
                //}
            }
            return uniquFileName;
        }

        //[HttpGet]
        //public IActionResult Get()
        //{
        //    var image = System.IO.File.OpenRead("C:\\test\\random_image.jpeg");
        //    var file = File(image, "image/jpeg");
        //    return file;
        //}
    }
}
