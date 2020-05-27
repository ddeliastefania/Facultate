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
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace ASPNetCore.Media
{
    public class IndexModel : PageModel
    {
        private readonly ASPNetCore.Data.ASPNetCoreContext _context;
        private ProjectClient projectClient = new ProjectClient();
        public bool Favorite { get; set; }
        public string Keyword { get; set; }
        public int NoResults { get; set; }
        public string FilterCriteria { get; set; }

        public IndexModel(ASPNetCore.Data.ASPNetCoreContext context)
        {
            _context = context;
        }

        public IList<DataDTO> DataDTO { get;set; }

        public async Task OnPostAsync()
        {
            Favorite = Request.Form["Favourite"] == "on" ? true : false;
            Keyword = Request.Form["Keyword"];
            Keyword = Keyword.ToUpper();
            var datas = await projectClient.GetAllDataAsync();
            //Configure Mapper
            var config = new MapperConfiguration(mc => mc.CreateMap<ServiceReferenceMyPhotos.Data, DataDTO>());
            //Map the objects
            var mapper = new Mapper(config);
            DataDTO = mapper.Map<List<ServiceReferenceMyPhotos.Data>, List<DataDTO>>(datas);
            if (Favorite == true)
            {
                DataDTO = DataDTO.Where(d => d.FavoriteData == true).ToList();
                FilterCriteria = "Favorite: Yes";
            }
            if(Keyword != string.Empty && Keyword !=null)
            {
                DataDTO = DataDTO.Where(d => d.EventName.ToUpper().Contains(Keyword) ||
                d.Location.ToUpper().Contains(Keyword)||
                d.People.ToUpper().Contains(Keyword) ||
                d.DateType.ToUpper().Contains(Keyword))
                    .ToList();
            }
            NoResults = DataDTO.Count;
        }

        public async Task OnGetAsync()
        {
            
            var datas = await projectClient.GetAllDataAsync();
            //Configure Mapper
            var config = new MapperConfiguration(mc => mc.CreateMap<ServiceReferenceMyPhotos.Data, DataDTO>());
            //Map the objects
            var mapper = new Mapper(config);
            DataDTO = mapper.Map<List<ServiceReferenceMyPhotos.Data>, List<DataDTO>>(datas);
            FilterCriteria = "None";
            NoResults = DataDTO.Count;
        }
    }
}
