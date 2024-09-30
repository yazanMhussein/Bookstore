using Bookstore.Data;
using Bookstore.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Bookstore.Controllers
{
    public class BookStoreController : Controller
    {

        private readonly booksDbContext _booksDbContext;

        public BookStoreController(booksDbContext booksDbContext)
        {
            _booksDbContext = booksDbContext;
        }
        // GET: Books (Index) - Display a list of books
        [HttpGet]
        public IActionResult Index()
        {
            var books = _booksDbContext.Books.ToList();
            return View(books);
        }
        // GET: BookStore/Create
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        //POST: Books/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create([Bind("Title,Author,Price,Genre")] Book book)
        {
            if (ModelState.IsValid)
            {
                _booksDbContext.Add(book);
                _booksDbContext.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View(book);
        }
        // GET: Books/Edit/5
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var book = _booksDbContext.Books.Find(id);
            if (book == null)
            {
                return NotFound();
            }
            return View(book);
        }

        // POST: Books/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, [Bind("Id,Title,Author,Price,Genre")] Book book)
        {
            if (id != book.Id)
            {
                return NotFound();
            }
            if (ModelState.IsValid)
            {
                try
                {
                    _booksDbContext.Update(book);
                    _booksDbContext.SaveChanges();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!_booksDbContext.Books.Any(e => e.Id == id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
                return View(book);
        }

        // GET: Books/Delete/5
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var book = _booksDbContext.Books.Find(id);
            if (book == null)
            {
                return NotFound();
            }

            return View(book);
        }

        // POST: Books/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            var book = _booksDbContext.Books.Find(id);
            if (book == null)
            {
                return NotFound();
            }
            _booksDbContext.Books.Remove(book);
            _booksDbContext.SaveChanges();
            return RedirectToAction(nameof(Index));
        }

        // GET: Books/Details/5
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var book = _booksDbContext.Books.Find(id);
            if (book == null)
            {
                return NotFound();
            }

            return View(book);
        }
    }
}

