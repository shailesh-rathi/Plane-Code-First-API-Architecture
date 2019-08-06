using Medline.Recall.Core;
using Medline.Recall.Core.Entities;
using Medline.Recall.Core.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Medline.Recall.Web.Controllers
{
    public class ToDoController : Controller
    {
        private readonly IRepository _repository;

        public ToDoController(IRepository repository)
        {
            _repository = repository;
        }

        public IActionResult Index()
        {
            var items = _repository.List<ToDoItem>();
            return View(items);
        }

        public IActionResult Populate()
        {
            int recordsAdded = DatabasePopulator.PopulateDatabase(_repository);
            return Ok(recordsAdded);
        }
    }
}
