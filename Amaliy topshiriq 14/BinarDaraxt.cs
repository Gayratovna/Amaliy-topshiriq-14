using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amaliy_topshiriq_14
{
    public class BinarDaraxt
    {
        public Telefon Root { get; set; }
        public BinarDaraxt Chap { get; set; }
        public BinarDaraxt Ong { get; set; }

        public BinarDaraxt(Telefon telefon)
        {
            Root = telefon;
            Chap = null;
            Ong = null;
        }

        public void MalumotKiritish(Telefon yangiTelefon)
        {
        if (string.Compare(yangiTelefon.Raqam, Root.Raqam) < 0)
        {
            if (Chap == null)
                Chap = new BinarDaraxt(yangiTelefon);
            else
                Chap.MalumotKiritish(yangiTelefon);
        }
        else if (string.Compare(yangiTelefon.Raqam, Root.Raqam) > 0)
        {
            if (Ong == null)
                Ong = new BinarDaraxt(yangiTelefon);
            else
                Ong.MalumotKiritish(yangiTelefon);
        
            
        }
    }

    public void BarchaMalumotlarniChiqarish()
    {
    if (Chap != null)
        Chap.BarchaMalumotlarniChiqarish();

        Console.WriteLine($"Telefon Raqami: {Root.Raqam}, Egal Ismi: {Root.EgalIsmi}, So'zlashuv Vaqti: {Root.SozlashuvVaqt}");

    if (Ong != null)
            Ong.BarchaMalumotlarniChiqarish();
    }

    public void TelefonRaqaminiChiqarish(string raqam)
    {
    if (string.Compare(raqam, Root.Raqam) == 0)
    {
        Console.WriteLine($"Telefon Raqami: {Root.Raqam}, Egal Ismi: {Root.EgalIsmi}, So'zlashuv Vaqti: {Root.SozlashuvVaqt}");
    }
    else if (string.Compare(raqam, Root.Raqam) < 0 && Chap != null)
    {
        Chap.TelefonRaqaminiChiqarish(raqam);
    }
    else if (string.Compare(raqam, Root.Raqam) > 0 && Ong != null)
        {
        Ong.TelefonRaqaminiChiqarish(raqam);
        }
        else
    {
        Console.WriteLine($"Telefon Raqami {raqam} topilmadi.");
    }
}
    }
}
