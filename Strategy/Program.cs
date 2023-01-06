
Oyun o1 = new Oyun(3, "Oyun Adı", "Oyun Türü", true);
Oyun o2 = (Oyun)o1.Clone();

if (o1.Equals(o2)) {
    Console.WriteLine("Eşit");
} else {
    Console.WriteLine("Eşit Değil");
}

Console.Read();