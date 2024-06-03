using VectorDraw.Professional.vdObjects;
using VectorDraw.Professional.vdFigures;

using VectorDraw.Geometry;


namespace WinFormsApp
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
            // VectorDraw uygulamasý oluþtur
            vdDocument doc = new vdDocument();

            // Dokümaný baþlat
            doc.New(); // Yeni bir doküman baþlatýr ve gerekli baþlangýç ayarlarýný yapar

            // Doðalgaz borusu için bir çizgi oluþtur
            vdLine boruCizgisi = new vdLine();

            // Baþlangýç ve bitiþ noktalarýný ayarla
            boruCizgisi.StartPoint = new gPoint(0, 0, 0);
            boruCizgisi.EndPoint = new gPoint(100, 0, 0);

            // Boru çapýný ayarla (örneðin kalýnlýk)
            boruCizgisi.LineWeight = VectorDraw.Professional.Constants.VdConstLineWeight.LW_158; // Boru çapý (kalýnlýk)

            // Boru rengini ayarla
            boruCizgisi.PenColor.SystemColor = Color.Red; // Boru rengi kýrmýzý

            // Çizgiyi dokümana ekle
            doc.Model.Entities.AddItem(boruCizgisi);

            // Çizimi kaydet
            doc.SaveAs("dogalgaz_borusu.vdml");

            // Çizimi göster (gerekirse)
            doc.Redraw(true);

            // Çizimin baþarýyla tamamlandýðýný bildir
            Console.WriteLine("Çizim baþarýyla oluþturuldu ve kaydedildi.");
        }
    }
}