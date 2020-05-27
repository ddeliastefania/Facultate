using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ASPNetCore.Data;
using ASPNetCore.Models;
using AutoMapper;
using ServiceReferenceMyPhotos;

namespace ASPNetCore.Media
{
    public class EditModel : PageModel
    {
        private readonly ASPNetCore.Data.ASPNetCoreContext _context;
        private ProjectClient projectClient = new ProjectClient();

        public EditModel(ASPNetCore.Data.ASPNetCoreContext context)
        {
            _context = context;
        }

        [BindProperty]
        public DataDTO DataDTO { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var data = await projectClient.GetDataByIdAsync((int)id);
            //Configure Mapper
            var config = new MapperConfiguration(mc => mc.CreateMap<ServiceReferenceMyPhotos.Data, DataDTO>());
            //Map the objects
            var mapper = new Mapper(config);
            DataDTO = mapper.Map<ServiceReferenceMyPhotos.Data, DataDTO>(data);

            if (DataDTO == null)
            {
                return NotFound();
            }
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(DataDTO).State = EntityState.Modified;

            try
            {
                var actData = await projectClient.GetDataByIdAsync(DataDTO.DataID);
                
                await projectClient.UpdateDataAsync(DataDTO.DataID,DataDTO.DateType, DataDTO.CreationDate, DataDTO.EventName, DataDTO.People, DataDTO.Location, DataDTO.Path);
                if (actData.Path != DataDTO.Path)
                {
                    await projectClient.MoveDataAsync(DataDTO.DataID, DataDTO.Path, true);
                }
            }
            catch (Exception)
            {
                var data = projectClient.GetDataByIdAsync(DataDTO.DataID);
                if (data==null)
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }


    }
}
