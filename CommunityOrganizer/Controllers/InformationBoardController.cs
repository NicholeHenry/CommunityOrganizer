using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CommunityOrganizer.Data.Repositories;
using CommunityOrganizer.Models;
using CommunityOrganizer.ViewModels.InformationBoard;
using Microsoft.AspNetCore.Mvc;

namespace CommunityOrganizer.Controllers
{
    public class InformationBoardController : Controller
    {
        private Factory repositoryFactory;

        public InformationBoardController(Factory repositoryFactory)
        {
            this.repositoryFactory = repositoryFactory;
        }
        public IActionResult Index()
        {
            List<InformationBoardListViewModel> informationBoards = InformationBoardListViewModel.GetInformationBoard(repositoryFactory);
            return View(informationBoards);
        }

        [HttpGet]
        public IActionResult Create()
        {
            InformationBoardCreateViewModel model = new InformationBoardCreateViewModel(repositoryFactory);
            return View(model);
        }

        [HttpPost]
        public IActionResult Create(InformationBoardCreateViewModel model)
        {
            model.Persist(repositoryFactory);
            return RedirectToAction(controllerName: nameof(InformationBoard), actionName: nameof(Index));
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            return View(new InformationBoardEditViewModel(id));
        }

        [HttpPost]
        public IActionResult Edit(int id, InformationBoardEditViewModel informationBoard)
        {
            repositoryFactory.GetInformationBoardRepository().Delete(id);
            return RedirectToAction(actionName: nameof(Index));
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            repositoryFactory.GetInformationBoardRepository().Delete(id);
            return RedirectToAction(actionName: nameof(Index));
        }
    }
}