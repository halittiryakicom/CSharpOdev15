using CSharpOdev15;
// Geçerli Kapı Sayısı ile Araba Nesnesi Oluşturma
Car araba1 = new Car("BMW", "3 Serisi", "Siyah", 4);
araba1.ArabaBilgileriniGoster();

// Geçersiz Kapı Sayısı ile Araba Nesnesi Oluşturma
Car araba2 = new Car("Audi", "A3", "Beyaz", 3);
araba2.ArabaBilgileriniGoster();