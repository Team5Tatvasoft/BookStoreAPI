using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookStore.Models.ViewModels;
using BookStore.Models;

namespace BookStore.Repository
{
    public class BaseRepository
    {
        protected readonly BookStoreContext _context = new BookStoreContext();
    }
}