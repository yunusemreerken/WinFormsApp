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
            // VectorDraw uygulamas� olu�tur
            vdDocument doc = new vdDocument();

            // Dok�man� ba�lat
            doc.New(); // Yeni bir dok�man ba�lat�r ve gerekli ba�lang�� ayarlar�n� yapar

            // Do�algaz borusu i�in bir �izgi olu�tur
            vdLine boruCizgisi = new vdLine();

            // Ba�lang�� ve biti� noktalar�n� ayarla
            boruCizgisi.StartPoint = new gPoint(0, 0, 0);
            boruCizgisi.EndPoint = new gPoint(100, 0, 0);

            // Boru �ap�n� ayarla (�rne�in kal�nl�k)
            boruCizgisi.LineWeight = VectorDraw.Professional.Constants.VdConstLineWeight.LW_158; // Boru �ap� (kal�nl�k)

            // Boru rengini ayarla
            boruCizgisi.PenColor.SystemColor = Color.Red; // Boru rengi k�rm�z�

            // �izgiyi dok�mana ekle
            doc.Model.Entities.AddItem(boruCizgisi);

            // �izimi kaydet
            doc.SaveAs("dogalgaz_borusu.vdml");

            // �izimi g�ster (gerekirse)
            doc.Redraw(true);

            // �izimin ba�ar�yla tamamland���n� bildir
            Console.WriteLine("�izim ba�ar�yla olu�turuldu ve kaydedildi.");
        }
    }
}