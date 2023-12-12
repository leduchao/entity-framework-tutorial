//using EnitytFrameworrkTutorial.Data;
//using EnitytFrameworrkTutorial.Models.DTOs;
//using EnitytFrameworrkTutorial.Models.Entities;
//using Microsoft.AspNetCore.Mvc;
//using Microsoft.EntityFrameworkCore;

//namespace EnitytFrameworrkTutorial.Controllers
//{
//    [Route("api/xe-may")]
//    [ApiController]
//    public class XeMayController : ControllerBase
//    {
//        private readonly WebDbContext _db;

//        public XeMayController(WebDbContext db)
//        {
//            _db = db;
//        }

//        [HttpGet]
//        [Route("xem-tat-ca-xe-may")]
//        public async Task<ActionResult<List<XeMay>>> XemTatCaXeMay()
//        {
//            return await _db.XeMays.Include(x => x.BienSo).ToListAsync();
//        }

//        [HttpGet]
//        [Route("xem-mot-xe-may/{id}")]
//        public async Task<ActionResult<XeMay?>> XemMotXeMay(int id)
//        {
//            var xeMay = await _db.XeMays
//                .Include(x => x.BienSo)
//                .FirstOrDefaultAsync(x => x.MaXe == id);

//            if (xeMay == null)
//                return NotFound();

//            return xeMay;
//        }

//        [HttpPost]
//        [Route("them-xe-may")]
//        public async Task<ActionResult> ThemXeMay(XeMayDTO xeMayDTO)
//        {
//            var bienSo = new BienSo
//            {
//                //MaHuyen = xeMayDTO.MaHuyen,
//                MaTinh = xeMayDTO.MaTinh,
//                SoDinhDanh = xeMayDTO.SoDinhDanh,
//            };

//            var xeMay = new XeMay()
//            {
//                TenXe = xeMayDTO.TenXe,
//                BienSo = bienSo
//            };

//            bienSo.XeMay = xeMay;

//            _db.XeMays.Add(xeMay);
//            await _db.SaveChangesAsync();
//            return Ok(xeMay);
//        }

//        [HttpGet]
//        [Route("xem-bien-so-cua-xe-may/{maXeMay}")]
//        public async Task<ActionResult<BienSo>> XemBienSoCuaXeMay(int maXeMay)
//        {
//            var bienSo = await _db.BienSos
//                .Include(b => b.XeMay)
//                .FirstOrDefaultAsync(b => b.MaXeMay == maXeMay);

//            if (bienSo == null)
//                return NotFound();

//            return bienSo;
//        }

//        [HttpGet]
//        [Route("xem-xe-may/{bienSo}")]
//        public async Task<ActionResult> XemBienSoCuaXeMay(string bienSo)
//        {
//            var result = await _db.BienSos
//                .Where(b => b.ChuoiDinhDanh.Contains(bienSo))
//                .Select(b => new
//                {
//                    b.XeMay.MaXe,
//                    b.XeMay.TenXe,
//                    BienSo = b.ChuoiDinhDanh
//                })
//                .ToListAsync();

//            if (result == null)
//                return NotFound();

//            return Ok(result);
//        }

//        [HttpDelete]
//        [Route("xoa-xe-may/{id}")]
//        public async Task<ActionResult> XoaXeMay(int id)
//        {
//            var xeMay = await _db.XeMays.FirstOrDefaultAsync(x => x.MaXe == id);

//            if (xeMay == null)
//                return NotFound();

//            _db.XeMays.Remove(xeMay);
//            await _db.SaveChangesAsync();

//            return Ok();
//        }
//    }
//}
