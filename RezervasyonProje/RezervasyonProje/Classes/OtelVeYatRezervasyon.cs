using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RezervasyonProje.Classes
{
    public class OtelVeYatRezervasyon : Rezervasyon
    {
        OtelRezervasyon otel = new OtelRezervasyon();

        YatLimaniRezervasyon yatLimani = new YatLimaniRezervasyon();
        public override void RasgeleDoldur()
        {
            rezervasyonDurumu[2, 0] = RezervasyonEnum.Dolu;
            rezervasyonDurumu[2, 1] = RezervasyonEnum.Temizlik;
            rezervasyonDurumu[2, 5] = RezervasyonEnum.Dolu;
            rezervasyonDurumu[2, 6] = RezervasyonEnum.Temizlik;
            rezervasyonDurumu[8, 7] = RezervasyonEnum.Dolu;
            rezervasyonDurumu[8, 8] = RezervasyonEnum.Temizlik;
            rezervasyonDurumu[9, 9] = RezervasyonEnum.Dolu;
            rezervasyonDurumu[9, 10] = RezervasyonEnum.Temizlik;
            rezervasyonDurumu[3, 15] = RezervasyonEnum.Dolu;
            rezervasyonDurumu[3, 16] = RezervasyonEnum.Temizlik;
            rezervasyonDurumu[4, 20] = RezervasyonEnum.Dolu;
            rezervasyonDurumu[4, 21] = RezervasyonEnum.Temizlik;
            rezervasyonDurumu[7, 27] = RezervasyonEnum.Dolu;
            rezervasyonDurumu[7, 28] = RezervasyonEnum.Temizlik;
            rezervasyonDurumu[7, 29] = RezervasyonEnum.Dolu;

            rezervasyonDurumu[4, 0] = RezervasyonEnum.Temizlik;
            rezervasyonDurumu[5, 1] = RezervasyonEnum.Dolu;
            rezervasyonDurumu[5, 2] = RezervasyonEnum.Temizlik;
        }

        public OtelVeYatRezervasyon()
        {
            otel.RasgeleDoldur();
            yatLimani.RasgeleDoldur();

        }
        public override int Fiyat(int gunSayisi, bool cift)
        {
            return gunSayisi > 5 ? 90 : 100; // Eğer gün sayisi 5 ten büyük ise 90 değillse 100 lira ödesin
        }

        public override string KiralananYerTipi()
        {
            return "Yer";
        } // Ana classımızda abstract tanımlandığında yani Pure virtual
          // işlemini mutlaka olması gereklidir. Bunun için bu methodu override ettik

        public override string UygulamaAdi()
        {
            return "Otel Ve YatLimani";
        }

        public override bool YanYanaIkiYerBirdenRezervasyonYapilabilirMi()
        {
            return false;
        }
        public override void AylikDolulukDurumu()
        {

            otel.AylikDolulukDurumu();
            yatLimani.AylikDolulukDurumu();
        }
        public override void RezervasyonYap(bool yanYanaIkiRezervasyon = false)
        {
            otel.RezervasyonYap();
            yatLimani.RezervasyonYap();
        }
        public override void RezervasyonYap(DateTime date1, DateTime date2, bool yanYanaIkiRezervasyon = false)
        {
            otel.RezervasyonYap(date1, date2, yanYanaIkiRezervasyon);
            yatLimani.RezervasyonYap(date1, date2, yanYanaIkiRezervasyon);

        }
        public override void RezervasyonYap(DateTime basTarihi, int gun, bool yanYanaIkiRezervasyon = false)
        {
            otel.RezervasyonYap(basTarihi, gun, yanYanaIkiRezervasyon);
            yatLimani.RezervasyonYap(basTarihi, gun, yanYanaIkiRezervasyon);

        }
        public override void GunSonuIslemi()
        {
            otel.GunSonuIslemi();
            yatLimani.GunSonuIslemi();
        }
        public override void BugunkuBosOdalar()
        {
            otel.BugunkuBosOdalar();
            yatLimani.BugunkuBosOdalar();
        }
        public override void GunBazindaDolulukOranlari()
        {
            otel.GunBazindaDolulukOranlari();
            yatLimani.GunBazindaDolulukOranlari();
        }

    }
}
