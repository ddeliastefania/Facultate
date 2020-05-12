﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorPagesMovie.Data;
using RazorPagesMovies.Models;

namespace RazorPagesMovie.Pages.Comments
{
    public class DetailsModel : PageModel
    {
        private readonly RazorPagesMovie.Data.RazorPagesMovieContext _context;

        public DetailsModel(RazorPagesMovie.Data.RazorPagesMovieContext context)
        {
            _context = context;
        }

        public CommentDTO CommentDTO { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            CommentDTO = await _context.CommentDTO
                .Include(c => c.Post).FirstOrDefaultAsync(m => m.CommentId == id);

            if (CommentDTO == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
