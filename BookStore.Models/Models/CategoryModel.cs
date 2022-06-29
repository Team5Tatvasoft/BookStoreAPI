using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookStore.Models.ViewModels;
using BookStore.Models;

namespace BookStore.Models.Models
{
    public class CategoryModel
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public CategoryModel() { }
        public CategoryModel(Category category)
        {
            Id = category.Id;
            Name = category.Name;
        }
    }
}