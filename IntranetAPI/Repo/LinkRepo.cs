﻿using IntranetAPI.Entities;
using IntranetAPI.Repo.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IntranetAPI.Repo
{
    public class LinkRepo : ILinkRepo
    {
        private readonly DataContext _context;
        public LinkRepo(DataContext context)
        {
            _context = context;
        }

        public async Task<bool> SaveLinkAsync(Link link)
        {
            await _context.Links.AddAsync(link);
            return await SaveChangesAsync();
        }

        private async Task<bool> SaveChangesAsync()
        {
            return await _context.SaveChangesAsync() > 0;
        }
    }
}
