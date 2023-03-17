using Microsoft.AspNetCore.Mvc;
using TestMaintstar.Application.Interfaces;
using TestMaintstar.Application.Models.Entities;
using TestMaintstar.Application.Models.ViewModels;

namespace TestMaintstar.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly IDataModel<Picture> _dataModel;

        public HomeController(IDataModel<Picture> dataModel) => _dataModel = dataModel;

        public async Task<IActionResult> Index()
        {
            var pictures = await _dataModel.GetImages();
            return View(pictures);
        }

        public async Task<IActionResult> Detail(int id)
        {
            if (id == 0)
            {
                return NotFound();
            }

            var picture = await _dataModel.GetImageById(id);

            return PartialView(picture);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(PictureViewModel pictureViewModel)
        {
            var picture = new Picture
            {
                Name = pictureViewModel.Name,
                Description = pictureViewModel.Description
            };

            if (pictureViewModel.Image is not null)
            {
                byte[] imageData = null;

                using (var binaryReader = new BinaryReader(pictureViewModel.Image.OpenReadStream()))
                {
                    imageData = binaryReader.ReadBytes((int)pictureViewModel.Image.Length);
                }

                picture.Image = imageData;
            }

            if (ModelState.IsValid)
            {
                await _dataModel.AddImage(picture);
                return RedirectToAction("Index");
            }
            return View(picture);
        }

        public async Task<IActionResult> Edit(int id)
        {
            if (id == 0)
            {
                return NotFound();
            }

            var picture = await _dataModel.GetImageById(id);

            if (picture is null)
            {
                return NotFound();
            }

            return View(picture);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(Picture picture)
        {
            if (ModelState.IsValid)
            {
                await _dataModel.UpdateImage(picture);

                return RedirectToAction("Index");
            }
            return View(picture);
        }

        public async Task<IActionResult> Delete(int id)
        {
            if (id == 0)
            {
                return NotFound();
            }

            await _dataModel.DeleteImage(id);

            return RedirectToAction("Index");
        }
    }
}