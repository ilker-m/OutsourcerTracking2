namespace OutsourcerTracking.Models.APIModels
{
    public class OutsourceWorkOrderIntegrationModel
    {
        public string Isemrino { get; set; } = null!;
        public string Refisemrino { get; set; } = null!;
        public string Aciklama { get; set; } = null!;
        public int Hmdepokodu { get; set; }
        public int Mamuldepokodu { get; set; }
        public string Opno { get; set; } = null!;
        public int MakinaNo { get; set; }
        public int Takipno { get; set; }
        public decimal Miktar { get; set; }
        public string StokKodu { get; set; } = null!;
        public decimal Uretilen { get; set; }
        public string Istkodu { get; set; } = null!;
        public string Opkodu { get; set; } = null!;
        public string? DemirKodu { get; set; }
        public string StokAdi { get; set; } = null!;
        public DateTime Kayittarihi { get; set; }
        public DateTime Isemritarihi { get; set; }
        public DateTime TeslimTarihi { get; set; }
        public int IntegrationStatusId { get; set; }
        public string Kapatildi { get; set; } = null!;
    }
}
