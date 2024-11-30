namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] urunler = { "Kola", "Fanta", "Çikolata" };
            double[] fiyatlar = { 40, 40, 30 };
            double bakiye = 0;
            while (true)
            {
                for (int i = 0; i < urunler.Length; i++)
                {
                    Console.WriteLine($"{i}-{urunler[i]}:{fiyatlar[i]}");
                }

                Console.WriteLine("Seçilen Ürün No:");
                int urunno;
                if (int.TryParse(Console.ReadLine(), out urunno))
                {
                    
                    if (urunno >= 0 && urunno < urunler.Length)
                    {
                        while (true)
                        {
                            Console.WriteLine("Para Giriniz:");
                            bakiye += Convert.ToDouble(Console.ReadLine());

                            if (bakiye >= fiyatlar[urunno])
                            {
                                Console.WriteLine($"Afiyet Olsun. Para Üstü:{bakiye - fiyatlar[urunno]}");
                                bakiye = 0;
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Yetersiz Bakiye!");
                                Console.WriteLine("1-Para Ekle\n2-Çıkış");
                                string result = Console.ReadLine();
                                if (result != "1")
                                {
                                    Console.Clear();
                                    bakiye = 0;
                                    break;
                                }

                            }
                        }


                    }
                    else if (urunno == -1)
                    {
                        Console.WriteLine("1-Ürün Ekle\n2-Ürün Güncelle\n3-Ürün Sil\n4-Ürünleri Listele\n5-Gün Sonu Raporu");
                        string secim = Console.ReadLine();

                        if (secim == "1")
                        {
                            Console.WriteLine("Ürün Adı:");
                            string urunAd = Console.ReadLine();
                            Console.WriteLine("Ürün Fiyatı:");
                            double fiyat = Convert.ToDouble(Console.ReadLine());

                            int bosIndex = -1;
                            for (int i = 0; i < urunler.Length; i++)
                            {
                                if (fiyatlar[i] == 0) { bosIndex = i; break; }
                            }

                            if (bosIndex != -1)
                            {
                                urunler[bosIndex] = urunAd;
                                fiyatlar[bosIndex] = fiyat;
                            }
                            else
                            {
                                Array.Resize(ref urunler, urunler.Length + 1);
                                Array.Resize(ref fiyatlar, fiyatlar.Length + 1);

                                urunler[urunler.Length - 1] = urunAd;
                                fiyatlar[fiyatlar.Length - 1] = fiyat;
                            }
                            Console.Clear();
                        }
                        else if (secim == "2")
                        {
                            for (int i = 0; i < urunler.Length; i++)
                            {
                                Console.WriteLine($"{i}-{urunler[i]}:{fiyatlar[i]}");
                            }

                            Console.WriteLine("Seçilen Ürün No:");
                            int index = Convert.ToInt32(Console.ReadLine());

                            if (index >= 0 && index < urunler.Length)
                            {
                                Console.WriteLine("Yeni Ürün Adı:");
                                string urunAd = Console.ReadLine();
                                Console.WriteLine("Yeni Ürün Fiyatı:");
                                double fiyat = Convert.ToDouble(Console.ReadLine());

                                urunler[index] = urunAd;
                                fiyatlar[index] = fiyat;
                            }
                            else
                            {
                                Console.WriteLine("Hatalı Ürün Numarası!");
                            }
                            Console.Clear();
                        }
                        else if (secim == "3")
                        {
                            for (int i = 0; i < urunler.Length; i++)
                            {
                                Console.WriteLine($"{i}-{urunler[i]}:{fiyatlar[i]}");
                            }

                            Console.WriteLine("Seçilen Ürün No:");
                            int index = Convert.ToInt32(Console.ReadLine());

                            if (index >= 0 && index < urunler.Length)
                            {
                                Array.Clear(urunler, index, 1);
                                Array.Clear(fiyatlar, index, 1);
                                Console.Clear();
                                Console.WriteLine("Silme Başarılı");
                            }
                            else
                            {
                                Console.WriteLine("Hatalı Ürün Numarası!");
                            }

                        }

                        else if (secim == "4")
                        {
                            Console.WriteLine("\nÜRÜNLER VE FİYATLAR:");
                            foreach (var urun in urunler)
                            {
                                Console.WriteLine($"{urun}: {fiyatlar} TL");
                            }
                        }


                        else
                        {
                            Console.WriteLine("Hatalı Tuşlama!!");
                        }
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Hatalı Ürün Numarası!!");
                    }

                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Ürün Numarasını Rakam Giriniz!!");




                }
            }
        }
    }
}

