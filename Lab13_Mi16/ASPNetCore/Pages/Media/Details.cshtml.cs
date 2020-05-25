using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ASPNetCore.Data;
using ASPNetCore.Models;
using ServiceReferenceMyPhotos;
using AutoMapper;

namespace ASPNetCore.Media
{
    public class DetailsModel : PageModel
    {
        private readonly ASPNetCore.Data.ASPNetCoreContext _context;
        private ProjectClient projectClient = new ProjectClient();

        public DetailsModel(ASPNetCore.Data.ASPNetCoreContext context)
        {
            _context = context;
        }

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
    }
}
