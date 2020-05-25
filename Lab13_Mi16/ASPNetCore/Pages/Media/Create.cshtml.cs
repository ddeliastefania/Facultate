using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using ASPNetCore.Data;
using ASPNetCore.Models;
using AutoMapper;
using ServiceReferenceMyPhotos;

namespace ASPNetCore.Media
{
    public class CreateModel : PageModel
    {
        private readonly ASPNetCore.Data.ASPNetCoreContext _context;
        private ProjectClient projectClient = new ProjectClient();

        public CreateModel(ASPNetCore.Data.ASPNetCoreContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public DataDTO DataDTO { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            await projectClient.CreateDataAsync(DataDTO.DateType, DataDTO.CreationDate, DataDTO.EventName, DataDTO.People, DataDTO.Location, DataDTO.Path);

            return RedirectToPage("./Index");
        }
    }
}
