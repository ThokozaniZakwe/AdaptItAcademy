using Microsoft.AspNetCore.Mvc;
using CourseModel = AdaptItAcademy.DataAccess.Models;
using AdaptItAcademy.DataAccess.Repository.IRepository;
using Microsoft.AspNetCore.Authorization;
using AdaptItAcademy.DataAccess.Models;

namespace AdaptItAcademy.Areas.Course.Controllers
{
    [Area("Course")]
    [AutoValidateAntiforgeryToken]
    [Authorize]
    public class CourseController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public CourseController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public IActionResult Index()
        {
            return View(_unitOfWork.Course.GetAll("TrainingDates"));
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            return View(_unitOfWork.Course.Get(id));
        }

        [HttpPost]
        public IActionResult Edit(CourseModel.Course course)
        {
            if (ModelState.IsValid)
            {
                _unitOfWork.Course.Update(course);
                _unitOfWork.Save();
                return RedirectToAction(nameof(Index));
            }
            return View(course);
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var objFromDb = _unitOfWork.Course.Get(id);
            return View(objFromDb);
        }

        [HttpPost]
        public IActionResult Delete(CourseModel.Course course)
        {
            if(course != null)
            {
                _unitOfWork.Course.Remove(course);
                _unitOfWork.Save();
                return RedirectToAction(nameof(Index));
            }
            return View(course);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        public IActionResult Create(CourseModel.Course course)
        {
            if (ModelState.IsValid)
            {
                _unitOfWork.Course.Add(course);
                _unitOfWork.Save();
                return RedirectToAction(nameof(Index));
            }
            return View(course);
        }
    }
}
