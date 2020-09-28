using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using ShopV1.Core.Repository;
using ShopV1.Core.UnitOfWork;
using ShopV1.Models;

namespace ShopV1.Areas.admin.Controllers
{
    public class SanPhamController : Controller
    {
        ShopDatabaseContext db = new ShopDatabaseContext();

        private readonly IEfRepository<SanPham> _sanPhamRepository;
        private readonly IUnitOfWork _unitOfWork;

        /// <summary>
        /// Khởi tạo
        /// </summary>
        /// <param name="sanPhamRepository"></param>
        /// <param name="unitOfWork"></param>
        public SanPhamController(IEfRepository<SanPham> sanPhamRepository, IUnitOfWork unitOfWork)
        {
            _sanPhamRepository = sanPhamRepository;
            _unitOfWork = unitOfWork;
        }
        // GET: SanPhamController
        [Area("admin")]
        public ActionResult Index()
        {
            
            var data = _sanPhamRepository.TableNoTracking.ToList();
            return View(data);
        }
        // GET: SanPhamController/Create
        [Area("admin")]
        public ActionResult Create()
        {
            List<DanhMuc> dm = db.DanhMuc.ToList();
            SelectList danhmuc = new SelectList(dm, "IdParent", "Ten");
            ViewBag.ID = danhmuc;
            return View();
        }

        // POST: SanPhamController/Create
        [Area("admin")]
        [HttpPost]
        public ActionResult Create(SanPham model) 
        {
            if (ModelState.IsValid)
            {
                _sanPhamRepository.Insert(model);
                _unitOfWork.SaveChange();
                return RedirectToAction("Index", "Sanpham");
            }
            return View(model);
        }

        // GET: SanPhamController/Edit/5
        [Area("admin")]
        public ActionResult Update()
        {
            return View();
        }

        [Area("admin")]
        [HttpPost]
        public ActionResult Update(SanPham model)
        {
            var selectedModel = _sanPhamRepository.TableNoTracking.Where(a => a.Id == model.Id).FirstOrDefault();

            if (selectedModel == null)
                return BadRequest("Danh mục không tồn tại !");

            selectedModel.MaSanphan = model.MaSanphan;
            selectedModel.TenSanpham = model.TenSanpham;

            _sanPhamRepository.Update(model);
            _unitOfWork.SaveChange();

            return RedirectToAction("Index");
        }
        // POST: SanPhamController/Edit/5
        [Area("admin")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(SanPham model)
        {
            var selectedModel = _sanPhamRepository.TableNoTracking.Where(a => a.Id == model.Id).FirstOrDefault();

            if (selectedModel == null)
                return BadRequest("Danh mục không tồn tại !");
            
            selectedModel.MaSanphan = model.MaSanphan;
            selectedModel.TenSanpham = model.TenSanpham;
            selectedModel.AnhSanpham = model.AnhSanpham;
            selectedModel.Mau = model.Mau;
            selectedModel.Size = model.Size;
            selectedModel.Mota = model.Mota;
            selectedModel.GiaSanpham = model.GiaSanpham;
            selectedModel.GiaKm = model.GiaKm;
            selectedModel.IdDanhmuc = model.IdDanhmuc;
            selectedModel.SoLuong = model.SoLuong;
            selectedModel.Status = model.Status;
            _sanPhamRepository.Update(model);
            _unitOfWork.SaveChange();

            return RedirectToAction("Index");
        }

        //GET: SanPhamController/Delete/5
        [Area("admin")]
        public ActionResult Delete(int? id)
        {
            var data = _sanPhamRepository.TableNoTracking.Where(m => m.Id == id).ToList();
            return View(data);
        }

        // POST: SanPhamController/Delete/5
        [Area("admin")]
        [HttpPost]
        public ActionResult Delete(int id)
        {
            var selectedModel = _sanPhamRepository.TableNoTracking.Where(a => a.Id == id).FirstOrDefault();

            if (selectedModel == null)
                return BadRequest("Sản phẩm không tồn tại !");

            _sanPhamRepository.Delete(selectedModel);
            _unitOfWork.SaveChange();

            return RedirectToAction("Index");
        }
    }
}
