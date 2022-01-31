using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.EntityFrameworkCore;
using BookStore.Models;
namespace BookStore.Controllers
{
    public class BooksController1 : Controller
    {
        private readonly BooksDbContext context;
        private readonly Repository<Books> booksRepository;
        public BooksController1(BooksDbContext context)
        {
            this.context = context;
            this.booksRepository = new GenericRepository<Books>(this.context);

        }
        public async Task<IActionResult> Index()
        {
            var books = await booksRepository.GetAsync();
            return View(books);
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(Books books)
        {
            if (!ModelState.IsValid)
                return View(books);

            booksRepository.Add(books);
            await booksRepository.SaveAsync();

            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Details(int id)
        {
            var books = await booksRepository.GetByIdAsync(id);

            if (books == null) return NotFound();
            return View(books);

        }

        public async Task<IActionResult> Edit(int id)
        {
            var books = await booksRepository.GetByIdAsync(id);

            if (books == null) return NotFound();
            return View(books);

        }

        [HttpPost]
        public async Task<IActionResult> Edit(Books books)
        {
            if (!ModelState.IsValid)
                return View(books);

            booksRepository.Update(books);
            await booksRepository.SaveAsync();

            return RedirectToAction("Index");


        }

        public async Task<IActionResult> Delete(int id)
        {
            var books = await context.Books.FindAsync(id);
            if (books == null)
                return NotFound();
            return View(books);
         }

        [HttpPost]
        [ActionName("Delete")]
        public async Task<IActionResult> Deletebook(int id)
        {
            var books = await booksRepository.GetByIdAsync(id);
            booksRepository.Delete(books);

             await booksRepository.SaveAsync();
            return RedirectToAction("Index");

        }

    }
}
