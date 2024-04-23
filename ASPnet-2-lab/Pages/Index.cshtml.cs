using ASPnet_2_lab.Abstract;
using ASPnet_2_lab.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ASPnet_2_lab.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        public IPersonService PersonService;
        public IBookService BookService;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
            PersonService = new PersonService();
            BookService = new BookService();
        }

        public override void OnPageHandlerExecuted(PageHandlerExecutedContext context)
        {
            BookService.WriteAllBooksToFile("books.txt");
            PersonService.WriteAllPeopleToFile("people.txt");
        }

        public void OnGet()
        {
            

        }

    }
}
