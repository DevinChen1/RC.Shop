using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using RC.Shop.Core.Domain.Product;
using RC.Shop.Data;

namespace RC.Shop.Controllers
{
    public class ProductInfoesController : Controller
    {
        private readonly ShopDBContext _context;

        public ProductInfoesController(ShopDBContext context)
        {
            _context = context;
        }

        // GET: ProductInfoes
        public async Task<IActionResult> Index()
        {
            return View(await _context.ProductInfos.ToListAsync());
        }

        // GET: ProductInfoes/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var productInfo = await _context.ProductInfos
                .FirstOrDefaultAsync(m => m.Pid == id);
            if (productInfo == null)
            {
                return NotFound();
            }

            return View(productInfo);
        }

        // GET: ProductInfoes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ProductInfoes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Pid,Psn,Name,Shopprice,Marketprice,Costprice,State,IsBest,IsHot,IsNew,Displayorder,Weight,WeightDescription,ShowImg,SaleCount,VisitCount,ReviewCount,Star,Addtime,Description,Number,Limit")] ProductInfo productInfo)
        {
            if (ModelState.IsValid)
            {
                _context.Add(productInfo);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(productInfo);
        }

        // GET: ProductInfoes/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var productInfo = await _context.ProductInfos.FindAsync(id);
            if (productInfo == null)
            {
                return NotFound();
            }
            return View(productInfo);
        }

        // POST: ProductInfoes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("Pid,Psn,Name,Shopprice,Marketprice,Costprice,State,IsBest,IsHot,IsNew,Displayorder,Weight,WeightDescription,ShowImg,SaleCount,VisitCount,ReviewCount,Star,Addtime,Description,Number,Limit")] ProductInfo productInfo)
        {
            if (id != productInfo.Pid)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(productInfo);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProductInfoExists(productInfo.Pid))
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
            return View(productInfo);
        }

        // GET: ProductInfoes/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var productInfo = await _context.ProductInfos
                .FirstOrDefaultAsync(m => m.Pid == id);
            if (productInfo == null)
            {
                return NotFound();
            }

            return View(productInfo);
        }

        // POST: ProductInfoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var productInfo = await _context.ProductInfos.FindAsync(id);
            _context.ProductInfos.Remove(productInfo);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ProductInfoExists(string id)
        {
            return _context.ProductInfos.Any(e => e.Pid == id);
        }
    }
}
