using Medline.Recall.Core;
using Medline.Recall.Core.Interfaces;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Medline.Recall.Web.Pages.ToDoRazorPage
{
    public class PopulateModel : PageModel
    {
        private readonly IRepository _repository;

        public PopulateModel(IRepository repository)
        {
            _repository = repository;
        }

        public int RecordsAdded { get; set; }

        public void OnGet()
        {
            RecordsAdded = DatabasePopulator.PopulateDatabase(_repository);
        }
    }
}
