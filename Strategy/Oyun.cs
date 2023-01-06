class Oyun : PrototypeOyun {
    public int OyunID { get; set; }
    public string OyunAdi { get; set; }
    public string OyunTuru { get; set; }
    public bool Durum { get; set; }
    public Oyun(int OyunID, string OyunAdi, string OyunTuru, bool Durum) {
        this.OyunID = OyunID;
        this.OyunAdi = OyunAdi;
        this.OyunTuru = OyunTuru;
        this.Durum = Durum;
    }

    public override PrototypeOyun? Clone() {
        return this.MemberwiseClone() as PrototypeOyun;
    }
}