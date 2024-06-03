using Microsoft.AspNetCore.Mvc;
using VectorDraw.Professional.vdPrimaries;
using VectorDraw.Professional.Constants;
using VectorDraw.Professional.vdObjects;
using VectorDraw.Professional.Components;
using System.IO;
using VectorDraw.Professional.vdFigures;

namespace WinFormsApp.Controllers
{
    public class DrawingControllers
    {
        [ApiController]
        [Route("[controller]")]
        public class DrawingController : ControllerBase
        {
            //[HttpGet]
            //[Route("CreateGasPipeLine")]
            //public IActionResult CreateGasPipeLine()
            //{
            //    // Doğalgaz borusu özellikleri
            //    double boruCapi = 100;  // mm cinsinden çap
            //    string boruMalzeme = "Çelik";

            //    // VectorDraw nesnesi oluşturma
            //    vdDocument cizim = new vdDocument();
            //    cizim.CommandAction.CmdCircle(new VectorDraw.Geometry.gPoint(0, 0), boruCapi / 2.0);

            //    // Başlangıç ve bitiş noktalarını tanımlama
            //    VectorDraw.Geometry.gPoint baslangicNoktasi = new VectorDraw.Geometry.gPoint(0, 0);
            //    VectorDraw.Geometry.gPoint bitisNoktasi = new VectorDraw.Geometry.gPoint(200, 0);

            //    // Boru çizgisi oluşturma
            //    vdLine boruCizgisi = new vdLine();
            //    boruCizgisi.SetUnRegisterDocument(cizim);
            //    boruCizgisi.setDocumentDefaults();
            //    boruCizgisi.StartPoint = baslangicNoktasi;
            //    boruCizgisi.EndPoint = bitisNoktasi;
            //    boruCizgisi.PenWidth = boruCapi / 10.0;  // Çapın bir oranı olarak kalınlık

            //    // Boru malzemesi bilgisini kaydetme (Custom Property)
            //    boruCizgisi.ToolTip = boruMalzeme;

            //    // Çizgiyi çizime ekleme
            //    cizim.Model.Entities.AddItem(boruCizgisi);

            //    // Çizimi kaydetme veya dosya olarak gönderme
            //    string dosyaYolu = Path.Combine(Path.GetTempPath(), "dogalgaz_borusu.vdml");
            //    cizim.SaveAs(dosyaYolu);

            //    // Dosyayı indirme için döndürme
            //    var bytes = System.IO.File.ReadAllBytes(dosyaYolu);
            //    return File(bytes, "application/octet-stream", "dogalgaz_borusu.vdml");
           // }
        }
    }
}
