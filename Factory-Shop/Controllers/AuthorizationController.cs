using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Factory_Shop.Data;
using Factory_Shop.Models;

namespace Factory_Shop.Controllers
{
    public class AuthorizationController : Controller
    {
        private readonly AddDBContend _context;
        private IEnumerable<UserDataModel> Data { get; set; }

        public AuthorizationController(AddDBContend context)
        {
            _context = context;
        }

        // GET: Authorization
        public async Task<IActionResult> Index()
        {
            Data = await _context.UserData.ToListAsync();
            return View(Data);
                
                //_context.UserData != null ?
                //     View(await _context.UserData.ToListAsync()) :
                //      Problem("Entity set 'AddDBContend.UserData'  is null.");
        }

        // GET: Authorization/Details/5
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

        // GET: Authorization/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Authorization/Create
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
                return RedirectToAction(nameof(Index));
            }
            return View(userDataModel);
        }

        // GET: Authorization/Edit/5
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

        // POST: Authorization/Edit/5
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

        // GET: Authorization/Delete/5
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

        // POST: Authorization/Delete/5
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
