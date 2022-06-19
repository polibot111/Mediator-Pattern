// See https://aka.ms/new-console-template for more information

using Mediator.Mediator_Senaryo_1;
using Mediator.Mediator_Senaryo_2;
using Mediator.Mediator_Senaryo_3;

#region Senaryo 1


Console.WriteLine("Senaryo 1 Başladı \n \n");


Anakart anakart = new Anakart();

CDDriver cdDraver = new CDDriver(anakart);
CPU cpu = new CPU(anakart);
EkranKarti ekranKarti = new EkranKarti(anakart);
SesKarti sesKarti = new SesKarti(anakart);

anakart.CDDriver = cdDraver;
anakart.CPU = cpu;
anakart.EkranKarti = ekranKarti;
anakart.SesKarti = sesKarti;

cdDraver.CDOku();

Console.WriteLine("Senaryo 1 Tamamlandı. \n \n");

#endregion

#region Senaryo 2

Console.WriteLine("Senaryo 2 Başladı \n \n");


Nakliye nakliye = new Nakliye();
XFirma xFirma = new XFirma(nakliye);
YFirma yFirma = new YFirma(nakliye);
ZFirma zFirma = new ZFirma(nakliye);

nakliye.XFirma = xFirma;
nakliye.YFirma = yFirma;
nakliye.ZFirma = zFirma;

xFirma.NakliyeyeBasla();


Console.WriteLine("Senaryo 2 Tamamlandı \n \n");

#endregion

#region Senaryo 3

Console.WriteLine("Senaryo 3 Başladı \n \n");


Transfer transfer = new Transfer();

Alici alici = new Alici(transfer);
Emlakci Emlakci = new Emlakci(transfer);
Satici Satici = new Satici(transfer);

transfer.Alici = alici;
transfer.Satici = Satici;
transfer.Emlakci = Emlakci;

alici.KonutParasiOde(200000);
Console.WriteLine("*************");
alici.KonutParasiOde(100000);

Console.WriteLine("Senaryo 3 Tamamlandı \n \n");

#endregion