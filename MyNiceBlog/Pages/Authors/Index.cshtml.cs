﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MyNiceBlog.DataLayer;
using MyNiceBlog.Models;

namespace MyNiceBlog.Pages.Authors
{
    public class IndexModel : PageModel
    {
        private readonly MyNiceBlog.DataLayer.PostdbContext _context;

        public IndexModel(MyNiceBlog.DataLayer.PostdbContext context)
        {
            _context = context;
        }

        public IList<Author> Author { get;set; }

        public async Task OnGetAsync()
        {
            Author = await _context.Author.ToListAsync();
        }
    }
}
