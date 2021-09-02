using AdaptItAcademy.DataAccess.Repository.IRepository;
using AdaptItAcademy.DataAccess.Repository;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;
using TrainingModel = AdaptItAcademy.DataAccess.Models;
using AdaptItAcademy.DataAccess.Models;

namespace AdaptItAcademy.Areas.Training.Controllers
{
    [Area("Training")]
    [AutoValidateAntiforgeryToken]
    public class TrainingController : Controller
    {

        private readonly IUnitOfWork _unitOfWork;

        public TrainingController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public IActionResult Index()
        {
            return View(_unitOfWork.Training.GetAll());
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            return View(_unitOfWork.Training.Get(id));
        }

        [HttpPost]
        public IActionResult Edit(TrainingModel.Training training)
        {
            if (ModelState.IsValid)
            {
                _unitOfWork.Training.Update(training);
                _unitOfWork.Save();
                return RedirectToAction(nameof(Index));
            }
            return View(training);
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var objFromDb = _unitOfWork.Training.Get(id);
            return View(objFromDb);
        }

        [HttpPost]
        public IActionResult Delete(TrainingModel.Training training)
        {
            if (training != null)
            {
                _unitOfWork.Training.Remove(training);
                _unitOfWork.Save();
                return RedirectToAction(nameof(Index));
            }
            return View(training);
        }

        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.Dietary = new SelectList(Enum.GetValues(typeof(Dietary)).Cast<Dietary>().Select(v => new SelectListItem
            {
                Text = v.ToString(),
                Value = ((int)v).ToString()
            }).ToList(), "Value", "Text");
            return View();
        }

        public IActionResult Create(TrainingModel.Training training)
        {
            if (ModelState.IsValid)
            {
                _unitOfWork.Training.Add(training);
                _unitOfWork.Save();
                return RedirectToAction(nameof(Index));
            }
            return View(training);
        }
    }
}
