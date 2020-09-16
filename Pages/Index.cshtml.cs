using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace razortest.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        public string Id { get; set; }

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
            Id = "form1";
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        public void OnPostMyQuery(string testtext)
        {
        }

        public IActionResult OnPostMyPage()
        {
            return RedirectToPage("Paget");
        }

        public IActionResult OnPostMyPrivacy()
        {
            return RedirectToPage("Privacy");
        }

        public IActionResult OnPostToPage1()
        {
            return RedirectToPage("Page1");
        }
    }
}