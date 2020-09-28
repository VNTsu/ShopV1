using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ShopV1.Core.Repository;
using ShopV1.Core.UnitOfWork;
using ShopV1.Models;

namespace ShopV1.Areas.admin.Controllers
{
    public class HomeController : Controller
    {
        private readonly IEfRepository<DanhMuc> _danhMucRepository;
        private readonly IUnitOfWork _unitOfWork;

        /// <summary>
        /// Khởi tạo
        /// </summary>
        /// <param name="danhMucRepository"></param>
        /// <param name="unitOfWork"></param>
        public HomeController(IEfRepository<DanhMuc> danhMucRepository, IUnitOfWork unitOfWork)
        {
            _danhMucRepository = danhMucRepository;
            _unitOfWork = unitOfWork;
        }
        [Area("admin")]
        public IActionResult Index()
        {
            var data = _danhMucRepository.TableNoTracking.ToList();
            return View(data);
        }
    }
}
