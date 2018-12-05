using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using RC.Shop.Core;
using RC.Shop.Data;

namespace RC.Shop.Controllers
{
    public class AddressController : Controller
    {
        private readonly ShopDBContext _context;

        public AddressController(ShopDBContext context)
        {
            _context = context;
        }

        // GET: Address
        public async Task<IActionResult> Index()
        {
            return View(await _context.ShipAddressInfos.ToListAsync());
        }

        // GET: Address/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var shipAddressInfo = await _context.ShipAddressInfos
                .FirstOrDefaultAsync(m => m.SAId == id);
            if (shipAddressInfo == null)
            {
                return NotFound();
            }

            return View(shipAddressInfo);
        }

        // GET: Address/Create
        public IActionResult Create()
        {
            return View();
        }

        
        [HttpPost]
        
        public async Task<IActionResult> Create( ShipAddressInfo shipAddressInfo)
        {
            if (ModelState.IsValid)
            {
                _context.Add(shipAddressInfo);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(shipAddressInfo);
        }

        // GET: Address/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var shipAddressInfo = await _context.ShipAddressInfos.FindAsync(id);
            if (shipAddressInfo == null)
            {
                return NotFound();
            }
            return View(shipAddressInfo);
        }

        // POST: Address/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, ShipAddressInfo shipAddressInfo)
        {
            if (id != shipAddressInfo.SAId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(shipAddressInfo);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ShipAddressInfoExists(shipAddressInfo.SAId))
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
            return View(shipAddressInfo);
        }

        // GET: Address/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var shipAddressInfo = await _context.ShipAddressInfos
                .FirstOrDefaultAsync(m => m.SAId == id);
            if (shipAddressInfo == null)
            {
                return NotFound();
            }

            return View(shipAddressInfo);
        }

        // POST: Address/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var shipAddressInfo = await _context.ShipAddressInfos.FindAsync(id);
            _context.ShipAddressInfos.Remove(shipAddressInfo);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ShipAddressInfoExists(string id)
        {
            return _context.ShipAddressInfos.Any(e => e.SAId == id);
        }
    }
}
