using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApp.EF;
using WebApp.EntityModels;
using WebApp.ViewModels.Catalog;
using WebApp.ViewModels.Helper;

namespace WebApp.Controllers
{
    public class CatalogController : Controller
    {
        MyContext _context;

        public CatalogController(MyContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index(string searchValue, string typeOfAttachment, string orderBy, int pageIndex = 1)
        {
            ViewData["searchValue"] = searchValue;
            ViewData["typeOfAttachment"] = typeOfAttachment;
            ViewData["orderBy"] = orderBy;
            var attachments = _context.ActivityAttachment.Include(i => i.Activity).AsQueryable();
            if (!string.IsNullOrEmpty(typeOfAttachment) && typeOfAttachment != "-1")
            {
                attachments = attachments.Where(w => w.TypeOfAttachment == (TypeOfAttachment)int.Parse(typeOfAttachment)).AsQueryable();
            }
            if (!string.IsNullOrEmpty(searchValue))
            {
                attachments = attachments.Where(w => w.Name.Contains(searchValue) || w.Description.Contains(searchValue)).AsQueryable();
            }

            var items = attachments
                .Select(s => new CatalogPreview_VM
                {
                    Id = s.Id,
                    Title = s.Name,
                    Description = s.Description,
                    ImageName = s.ImageName,
                    Rate = (int)(_context.Rate.Where(w => w.ActivityId == s.ActivityId).Select(s => (int?)s.RateValue).Average() ?? 0.0),
                    Activity = s.Activity.Title,
                    Price = s.PriceToVisit,
                    Addons = (List<Tuple<TypeOfAddons, int>>)_context.AttachmentAddons.Where(w => w.AttachmentId == s.Id).Select(s => new Tuple<TypeOfAddons, int>(s.AddonType, s.Distance))
                });
            ViewData["count"] = items.Count();

            switch (orderBy)
            {
                case "0": // rate
                    items = items.OrderByDescending(o => o.Rate).AsQueryable();
                    break;
                case "1": // biggest price
                    items = items.OrderByDescending(o => o.Price).AsQueryable();
                    break;
                case "2": // smallest price
                    items = items.OrderBy(o => o.Price).AsQueryable();
                    break;
                default:
                    break;
            }

            var model = await PeginationList<CatalogPreview_VM>.CreateAsync(items, pageIndex, 6);
            ViewData["hasPrevious"] = model.HasPreviousPage;
            ViewData["hasNext"] = model.HasNextPage;
            return View(model);
        }

        public IActionResult CatalogItemDetails(int AttachmentId)
        {
            var model = _context.ActivityAttachment.Where(w => w.Id == AttachmentId).Select(s => new CatalogPreview_VM
            {
                Id = AttachmentId,
                ImageName = s.ImageName,
                Description = s.Description,
                Title = s.Name
            }).FirstOrDefault();

            return View(model);
        }

        public IActionResult CatalogFullItemDetails(int ActivityId)
        {
            var model = _context.Activity.Where(w => w.Id == ActivityId).Select(s => new FullCatalogPreview
            {
                ActivityId = ActivityId,
                ActivityTitle = s.Title,
                Image = s.ImageName,
                Rate = (int)(_context.Rate.Where(w => w.ActivityId == ActivityId).Select(c => (int?)c.RateValue).Average() ?? 0.0),
                Attachments = _context.ActivityAttachment.Where(w => w.ActivityId == ActivityId).Select(x => new FullCatalogPreview.CatalogAttachment
                {
                    Id = x.Id,
                    Title = x.Name,
                    Price = x.PriceToVisit,
                    Description = x.Description,
                    ImageName = x.ImageName,
                    Addons = _context.AttachmentAddons.Where(w => w.AttachmentId == x.Id).Select(c => new Tuple<TypeOfAddons, int>(c.AddonType, c.Distance)).ToList(),
                }).ToList()
            }).FirstOrDefault();

            return View(model);
        }
    }
}
