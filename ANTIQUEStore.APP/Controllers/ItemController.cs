using System;
using Microsoft.AspNetCore.Mvc;
using ANTIQUEStore.Application.DTOs;
using ANTIQUEStore.Application.Interfaces;

namespace ANTIQUEStore.APP.Controllers
{
    public class ItemController : Controller
    {
        private readonly IItemApplicationService _itemApplicationService;

        public ItemController(IItemApplicationService itemApplicationService) => _itemApplicationService = itemApplicationService;

        public ActionResult Index()
        {
            try
            {
                return View(_itemApplicationService.GetAll());
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public ActionResult Details(int? id)
        {
            try
            {
                if (id == null) return NotFound();

                var itemDTO = _itemApplicationService.GetById(id.Value);

                if (itemDTO == null) return NotFound();

                return View(itemDTO);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind("Id,Name,Description,Price,Year")] ItemDTO itemDTO)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _itemApplicationService.Add(itemDTO);

                    return RedirectToAction(nameof(Index));
                }

                return View(itemDTO);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public ActionResult Edit(int? id)
        {
            try
            {
                if (id == null) return NotFound();

                var itemDTO = _itemApplicationService.GetById(id.Value);

                if (itemDTO == null) return NotFound();

                return View(itemDTO);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, [Bind("Id,Name,Description,Price,Year")] ItemDTO itemDTO)
        {
            try
            {
                if (id != itemDTO.Id) return NotFound();

                if (ModelState.IsValid)
                {
                    _itemApplicationService.Update(itemDTO);

                    return RedirectToAction(nameof(Index));
                }

                return View(itemDTO);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public ActionResult Delete(int? id)
        {
            try
            {
                if (id == null) return NotFound();

                var itemDTO = _itemApplicationService.GetById(id.Value);

                if (itemDTO == null) return NotFound();

                return View(itemDTO);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            try
            {
                _itemApplicationService.Remove(id);

                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private bool ItemDTOExists(int id)
        {
            return _itemApplicationService.GetById(id) == null;
        }
    }
}
