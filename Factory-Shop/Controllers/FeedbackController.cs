using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Factory_Shop.Data;
using Factory_Shop.Models;

namespace Factory_Shop.Controllers
{
    public class FeedbackController : Controller
    {
        private readonly AddDBContend _context;
        private IEnumerable<UserDataModel> Data { get; set; }

        public FeedbackController(AddDBContend context)
        {
            _context = context;
        }

        // GET: Feedback
        public async Task<IActionResult> Index()
        {
            Data = await _context.UserData.ToListAsync();
            return View(Data);   
        }

        // GET: Feedback/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.UserData == null)
            {
                return NotFound();
            }

            var userDataModel = await _context.UserData
                .FirstOrDefaultAsync(m => m.Id == id);
            if (userDataModel == null)
            {
                return NotFound();
            }

            return View(userDataModel);
        }

        // GET: Feedback/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Feedback/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,FirstName,LastName,Mobile,Email,Source")] UserDataModel userDataModel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(userDataModel);
                await _context.SaveChangesAsync();
                return Redirect("/Home/ListMat");
            }
            return View(userDataModel);
        }

        // GET: Feedback/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.UserData == null)
            {
                return NotFound();
            }

            var userDataModel = await _context.UserData.FindAsync(id);
            if (userDataModel == null)
            {
                return NotFound();
            }
            return View(userDataModel);
        }

        // POST: Feedback/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,FirstName,LastName,Mobile,Email,Source")] UserDataModel userDataModel)
        {
            if (id != userDataModel.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(userDataModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!UserDataModelExists(userDataModel.Id))
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
            return View(userDataModel);
        }

        // GET: Feedback/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.UserData == null)
            {
                return NotFound();
            }

            var userDataModel = await _context.UserData
                .FirstOrDefaultAsync(m => m.Id == id);
            if (userDataModel == null)
            {
                return NotFound();
            }

            return View(userDataModel);
        }

        // POST: Feedback/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.UserData == null)
            {
                return Problem("Entity set 'AddDBContend.UserData'  is null.");
            }
            var userDataModel = await _context.UserData.FindAsync(id);
            if (userDataModel != null)
            {
                _context.UserData.Remove(userDataModel);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool UserDataModelExists(int id)
        {
          return (_context.UserData?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
