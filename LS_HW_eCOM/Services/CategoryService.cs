﻿using Microsoft.EntityFrameworkCore;
using LS_HW_eCOM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LS_HW_eCOM.Service
{
    public class CategoryService : ICategory
    {
        private readonly ApplicationDbContext _context;

        public CategoryService(ApplicationDbContext context)
        {
            _context = context;
        }

		public void DeleteCategory(int id)
		{
            var category = GetById(id);
            if(category == null)
            {
                throw new ArgumentException();
            }
            _context.Remove(category);
            _context.SaveChanges();
		}

		public void EditCategory(Category category)
        {
            _context.Update(category);
            _context.SaveChanges();
        }

        public IEnumerable<Category> GetAll()
        {
            return _context.Categories.Include(c => c.Foods);
        }

        public Category GetById(int id)
        {
            return GetAll().FirstOrDefault(category => category.Id == id);
        }

        public void NewCategory(Category category)
        {
            _context.Add(category);
            _context.SaveChanges();
        }
    }
}
