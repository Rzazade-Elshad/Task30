using System.Diagnostics.CodeAnalysis;
using System.Net;
using System.Runtime.ConstrainedExecution;

namespace BB208_30Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1-10
            /* {
                 int num1 = 5, num2 = 7;

                 Console.WriteLine(Sum(num1, num2));
                 Console.WriteLine();

                 Console.WriteLine(Kv(num1));
                 Console.WriteLine();

                 string ad = "Elshad";
                 int yas = 20;
                 Scr(ad, yas);
                 Console.WriteLine();

                 Swap(num1, num2);
                 Console.WriteLine();

                 int num3 = 6;
                 EdOrtaCem(num1, num2, num3);
                 Console.WriteLine();

                 int num4;
                 while (true)
                 {
                     Console.WriteLine("dord reqemli pls");
                     num4 = int.Parse(Console.ReadLine());
                     if (num4 < 10000 && num4 > 999)
                     {
                         reqemCem(num4);
                         break;
                     }
                     Console.WriteLine("yeniden cehd edin");
                 }
                 Console.WriteLine();

                 {
                     int digit;
                     digit = int.Parse(Console.ReadLine());
                     TekCem(digit);
                     Console.WriteLine();
                 }

                 {
                     int num5, num6;
                     Console.WriteLine("iki eded daxil edin :");
                     num5 = int.Parse(Console.ReadLine());
                     num6 = int.Parse(Console.ReadLine());
                     muqsyise(num5, num6);
                     Console.WriteLine();
                     Console.WriteLine();
                 }

                 {
                     int num7;
                     Console.WriteLine("Bir eded daxil edin :");
                     num7 = int.Parse(Console.ReadLine());
                     muqsyise1(num7);
                     Console.WriteLine();
                     Console.WriteLine();
                 }

                 {
                     int num8;
                     Console.WriteLine("ededi daxil edin ");
                     num8 = int.Parse(Console.ReadLine());
                     checkout(num8);
                     Console.WriteLine();
                 }
             }*/
            //11-20
            /*{
                {
                    int num9;
                    Console.WriteLine("ededi daxil edin ");
                    num9 = int.Parse(Console.ReadLine());
                    checkout1(num9);
                    Console.WriteLine();
                }

                {
                    int num10;
                    Console.WriteLine("necenci aydi ?");
                    num10 = int.Parse(Console.ReadLine());
                    switccase(num10);
                    Console.WriteLine();
                }

                {
                    int num11;
                    Console.WriteLine("balinizi daxil edin ");
                    num11 = int.Parse(Console.ReadLine());
                    switccase1(num11);
                    Console.WriteLine();
                }

                {
                    int num12, num13; char emeliyyat;
                    Console.WriteLine("iki eded , bir emeliyyat daxil edin");
                    num12 = int.Parse(Console.ReadLine());
                    num13 = int.Parse(Console.ReadLine());
                    emeliyyat = char.Parse(Console.ReadLine());
                    switccase2(num12, num13, emeliyyat);
                    Console.WriteLine();
                }

                {
                    int num14 = int.Parse(Console.ReadLine());
                    Endirim(num14);
                    Console.WriteLine();
                }

                {
                    int parol = int.Parse(Console.ReadLine());
                    string ad1 = Console.ReadLine();
                    Girish(parol, ad1);
                    Console.WriteLine();
                }

                {
                    while (true)
                    {
                        Console.WriteLine("USD-AZE-1 // AZE-USD-2 // Exit-0");
                        int secim = int.Parse(Console.ReadLine());
                        if (secim == 0) break;
                        else
                        {
                            Console.WriteLine("meblegi daxil et ");
                            double pul = double.Parse(Console.ReadLine());
                            Mezenne(pul, secim);
                        }
                    }
                    Console.WriteLine();
                }

                {
                    Console.Write("Boyunuzu (metr ilə) daxil edin: ");
                    double boy = Convert.ToDouble(Console.ReadLine());

                    Console.Write("Çəkinizi (kg ilə) daxil edin: ");
                    double ceki = Convert.ToDouble(Console.ReadLine());

                    Boyceki(boy, ceki);
                    Console.WriteLine();
                }

                {
                    double balans = 1000.0;
                    while (true)
                    {
                        Console.WriteLine("ATM Proqramı");
                        Console.WriteLine("1. Balansı yoxla");
                        Console.WriteLine("2. Vəsait əlavə et");
                        Console.WriteLine("3. Pul çıxar");
                        Console.WriteLine("4. Çıxış");
                        Console.Write("Seçiminizi daxil edin: ");

                        int secim = Convert.ToInt32(Console.ReadLine());
                        if (secim == 4)
                            break;
                        else
                            ATM(secim, balans);
                        Console.WriteLine();
                    }
                }

                {
                    int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0, 1, 2, 3, 4, 5, 6, 8, 9, 10, 11, 12, };
                    Scrn(arr);
                    Console.WriteLine();
                }
            }*/
            //21-30
            /* {
                 {
                     int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0, 1, 2, 3, 4, 5, 6, 8, 9, 10, 11, 12, };
                     CemArr(arr);
                     Console.WriteLine();
                 }

                 {
                     int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0, 1, 2, 3, 4, 5, 6, 8, 9, 10, 11, 12, };
                     EdedortaArr(arr);
                     Console.WriteLine();
                 }

                 {
                     int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0, 1, 2, 3, 4, 5, 6, 8, 9, 10, 11, 12, };
                     BoyukKicik(arr);
                     Console.WriteLine();
                 }

                 {
                     int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0, 1, 2, 3, 4, 5, 6, 8, 9, 10, 11, 12, };
                     Cutarr(arr);
                     Console.WriteLine();
                 }

                 {
                     int[] arr = { 9,1, 2, 11,1, 12, };
                     EksSirArr(arr);
                     Console.WriteLine();
                 }

                 {
                     int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0, 1, 2, 3, 4, 5, 6, 8, 9, 10, 11, 12, };
                     int num15 = 5;
                     int result=Checkarr(arr, num15);
                     Console.WriteLine(result);
                     Console.WriteLine();
                 }

                 {
                     int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0, 1, 2, 3, 4, 5, 6, 8, 9, 10, 11, 12, };
                     Tekrarlanan(arr);
                     Console.WriteLine();
                 }

                 {
                     int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0, 1, 2, 3, 4, 5, 6, 8, 9, 10, 11, 12, };
                     ikinciBoyuk(arr);
                     Console.WriteLine();
                 }

                 {
                     int num16 = int.Parse(Console.ReadLine());
                     Nreqemkicem(num16);
                     Console.WriteLine();
                 }

                 {
                     int num17=int.Parse(Console.ReadLine());
                     Nreqemsay(num17);
                     Console.WriteLine();
                 }


             }*/
            //31-33
            /*{
                {
                    {
                        int num17 = int.Parse(Console.ReadLine());
                        Console.WriteLine(SadeMurekkeb(num17));
                    }
                }

                {
                    int num18=int.Parse(Console.ReadLine());
                    NreqemPoindrom(num18);
                    Console.WriteLine();
                }

                {
                    int num19=int.Parse(Console.ReadLine());
                    Fibo(num19);
                    Console.WriteLine();
                }
            }*/
        }

        static int Sum(int num1, int num2) => num1 + num2;

        static int Kv(int num1) => num1 * num1;

        static void Scr(string ad, int yas)
        {
            Console.WriteLine($"Salam, mənim adım {ad}-dur və mənim {yas} yaşım var.");
        }

        static void Swap(int num1, int num2)
        {
            (num1, num2) = (num2, num1);
            Console.WriteLine($"num1 dəyişəninin əvvəlki dəyəri {num2}, yer dəyişmədən sonra {num1} - dir.");
            Console.WriteLine($"num2 dəyişəninin əvvəlki dəyəri {num1}, yer dəyişmədən sonra {num2} - dir.");
        }

        static void EdOrtaCem(int num1, int num2, int num3)
        {
            Console.WriteLine(num1 + num2 + num3);
            Console.WriteLine((num1 + num2 + num3) / 3);
        }

        static void reqemCem(int num4)
        {
            int sum = 0;
            while (num4 > 0)
            {
                sum += num4 % 10;
                num4 /= 10;
            }
            Console.WriteLine(sum);
        }

        static void TekCem(int digit)
        {
            if (digit % 2 == 0 && digit > 0)
                Console.WriteLine("cwt");
            else if (digit % 2 == 1 && digit > 0)
                Console.WriteLine("tek ");
            else
                Console.WriteLine("tek cut musbet edede aiddir");
        }

        static void muqsyise(int num5, int num6)
        {
            if (num5 > num6) { Console.WriteLine($"birinci daxil edilen boyukdu{num5}"); }
            else if (num5 < num6) { Console.WriteLine($"ikinci eded boyukdu{num6}"); }
            else { Console.WriteLine($"ededler beraberdir{num5} {num6}"); }
        }

        static void muqsyise1(int num7)
        {
            if (num7 > 0) { Console.WriteLine($"musbet {num7}"); }
            else if (num7 < 0) { Console.WriteLine($"menfi {num7}"); }
            else { Console.WriteLine($"sifira beraberdir{num7}"); }
        }

        static void checkout(int num8)
        {
            if (num8 % 3 == 0 && num8 % 5 == 0)
                Console.WriteLine("eded hem 3-e hem 5-e bolunur ");
            else
                Console.WriteLine("eded hem 3-e hem 5-e bolunmur ");
        }

        static void checkout1(int num9)
        {
            if (num9 % 2 == 0 && num9 % 3 == 0)
                Console.WriteLine("eded hem 2-e hem 3-e bolunur ");
            else
                Console.WriteLine("eded hem 2-e hem 3-e bolunmur ");
        }

        static void switccase(int num10)
        {
            switch (num10)
            {
                case 1:
                    Console.WriteLine("yanvae");
                    break;
                case 2:
                    Console.WriteLine("fevral");
                    break;
                case 3:
                    Console.WriteLine("mart");
                    break;
                case 4:
                    Console.WriteLine("aprel");
                    break;
                case 5:
                    Console.WriteLine("may");
                    break;
                case 6:
                    Console.WriteLine("iyun");
                    break;
                case 7:
                    Console.WriteLine("iyul");
                    break;
                case 8:
                    Console.WriteLine("avgust");
                    break;
                case 9:
                    Console.WriteLine("sentiyabr");
                    break;
                case 10:
                    Console.WriteLine("oktyabr");
                    break;
                case 11:
                    Console.WriteLine("noyabr");
                    break;
                case 12:
                    Console.WriteLine("dekabr");
                    break;
                default:
                    Console.WriteLine("ele ay yoxdu");
                    break;
            }
        }

        static void switccase1(int num11)
        {
            string qiymet;
            qiymet = num11 switch
            {
                >= 90 and <= 100 => "A",
                >= 80 and < 90 => "B",
                >= 70 and < 80 => "C",
                >= 60 and < 70 => "D",
                >= 50 and < 60 => "E",
                >= 0 and < 50 => "F",
                _ => "Yanlış bal daxil edildi"
            };
            Console.WriteLine(qiymet);
        }

        static void switccase2(int num12, int num13, char emeliyyat)
        {
            double result;
            switch (emeliyyat)
            {
                case '+':
                    result = num12 + num13;
                    Console.WriteLine($"Nəticə: {result}");
                    break;
                case '-':
                    result = num12 - num13;
                    Console.WriteLine($"Nəticə: {result}");
                    break;
                case '*':
                    result = num12 * num13;
                    Console.WriteLine($"Nəticə: {result}");
                    break;
                case '/':
                    if (num13 != 0)
                    {
                        result = num12 / num13;
                        Console.WriteLine($"Nəticə: {result}");
                    }
                    else
                    {
                        Console.WriteLine("Sıfıra bölmə mümkün deyil!");
                    }
                    break;
                default:
                    Console.WriteLine("Yanlış əməliyyat daxil edildi!");
                    break;
            }
        }

        static void Endirim(int num14)
        {
            if (num14 >= 100)
            {
                int num = (num14 * 90) / 100;
                Console.WriteLine($"Endirimli qiymət: Alınan məhsulun dəyəri {num14} AZN. Ödəyəcəyiniz məbləğ {num} AZN (10% endirim tətbiq edildi)\r\n");
            }
            else if (num14 >= 50 && num14 <= 99)
            {
                int num = (num14 * 95) / 100;
                Console.WriteLine($"Endirimli qiymət: Alınan məhsulun dəyəri {num14} AZN. Ödəyəcəyiniz məbləğ {num} AZN (5% endirim tətbiq edildi)\r\n");
            }
            else if (num14 >= 1 && num14 <= 49)
            {
                Console.WriteLine($"Endirimli qiymət: Alınan məhsulun dəyəri {num14} AZN. Ödəyəcəyiniz məbləğ {num14} AZN ( endirim tətbiq edilmedi)\r\n");
            }
            else
                Console.WriteLine("ele bir qiymet yoxdur");
        }

        static void Girish(int num, string ad1)
        {
            if (num == 222 && ad1 == "admin")
            {
                Console.WriteLine("girishe icaze verildi");
            }
            else if (ad1 == "admin" && num != 222)
            {
                Console.WriteLine("parol sehvdir");
            }
            else
            { Console.WriteLine("bele bir istifadeci tapilmadi"); }
        }

        static void Mezenne(double pul, int secim)
        {
            if (secim == 1)
            {
                pul = pul * 1.7;
                Console.WriteLine(pul);
            }
            else if (secim == 2)
            {
                pul = pul / 1.7;
                Console.WriteLine(pul);
            }
            else
                Console.WriteLine("secimi duzgun edin");
        }

        static void Boyceki(double boy, double ceki)
        {
            double bmi = ceki / (boy * boy);
            string mesaj;

            if (bmi < 18.5)
            {
                mesaj = "Çəki azlığı";
            }
            else if (bmi >= 18.5 && bmi < 25)
            {
                mesaj = "Normal çəki";
            }
            else if (bmi >= 25 && bmi < 30)
            {
                mesaj = "Artıq çəki";
            }
            else if (bmi >= 30)
            {
                mesaj = "Piylənmə";
            }
            else
            {
                mesaj = "Yanlış dəyərlər daxil edilib";
            }

            Console.WriteLine($"BMI: {bmi:F2} - {mesaj}");
        }

        static void ATM(int secim, double balans)
        {
            switch (secim)
            {
                case 1:
                    Console.WriteLine($"Cari balansınız: {balans} AZN");
                    break;

                case 2:
                    Console.Write("Əlavə etmək istədiyiniz məbləği daxil edin: ");
                    double elaveMebleg = Convert.ToDouble(Console.ReadLine());
                    if (elaveMebleg > 0)
                    {
                        balans += elaveMebleg;
                        Console.WriteLine($"Yeni balansınız: {balans} AZN");
                    }
                    else
                    {
                        Console.WriteLine("Məbləğ mənfi və ya sıfır ola bilməz!");
                    }
                    break;

                case 3:
                    Console.Write("Çıxarmaq istədiyiniz məbləği daxil edin: ");
                    double cixarMebleg = Convert.ToDouble(Console.ReadLine());
                    if (cixarMebleg > 0 && cixarMebleg <= balans)
                    {
                        balans -= cixarMebleg;
                        Console.WriteLine($"Yeni balansınız: {balans} AZN");
                    }
                    else
                    {
                        Console.WriteLine("Yanlış məbləğ! Balansdan çox və ya mənfi məbləğ çıxmaq olmaz.");
                    }
                    break;
                default:
                    Console.WriteLine("Yanlış seçim! 1-4 arası rəqəm daxil edin.");
                    break;
            }
        }

        static void Scrn(int[] arr)
        {
            foreach (int i in arr)
            {
                Console.WriteLine(i);
            }
        }

        static void CemArr(int[] arr)
        {
            int sum = 0;
            foreach (int i in arr)
            {
                sum += i;
            }
            Console.WriteLine(sum);
        }

        static void EdedortaArr(int[] arr)
        {
            int sum = 0;
            foreach (int i in arr)
            {
                sum += i;
            }
            Console.WriteLine(sum / arr.Length);
        }

        static void BoyukKicik(int[] arr)
        {
            int min = arr[0], max = arr[0];
            int index = 0, index1 = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < min)
                {
                    min = arr[i];
                    index = i;
                }
                if (arr[i] > max)
                {
                    max = arr[i];
                    index1 = i;
                }
            }
            Console.WriteLine($" kicik {min} -index {index}, boyuk {max}- index{index1}");
        }

        static void Cutarr(int[] arr)
        {
            foreach (int i in arr)
            {
                if (i % 2 == 0 && i != 0)
                    Console.WriteLine(i);
            }
        }

        static void EksSirArr(int[] arr)
        {
            int key, key1;
            for (int i = 1; i < arr.Length; i++)
            {
                key1 = i; key = key1 - 1;
                while (key >= 0)
                {
                    if (arr[key] < arr[key1])
                        (arr[key], arr[key1]) = (arr[key1], arr[key]);
                    key--;
                    key1--;
                }
            }
            foreach (int i in arr)
            {
                Console.WriteLine(i);
            }
        }

        static int Checkarr(int[] arr, int num)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == num)
                {
                    Console.WriteLine("eded movcuddur");
                    return i;
                }
            }
            Console.WriteLine("eded movcut deyil");
            return -1;
        }

        static void Tekrarlanan(int[] arr)
        {
            int say;
            for (int i = 0; i < arr.Length; i++)
            {
                say = 0;
                for (int j = 0; j < arr.Length - 1; j++)
                {
                    if (arr[i] == arr[j])
                        say++;
                }
                if (say > 1)
                {
                    Console.WriteLine($"{arr[i]} ededi {say} qeder tekrralanib");
                }
            }
        }

        static void ikinciBoyuk(int[] arr)
        {
            int max = arr[0], max1 = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > max)
                    max = arr[i];
            }
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] > max1 && arr[i] < max)
                    max1 = arr[i];
            }
            Console.WriteLine($" birinci boyuk {max} , ikinci boyuk {max1}");
        }

        static void Nreqemkicem(int n)
        {
            int sum = 0;
            while (n > 0)
            {
                sum += n % 10; n /= 10;
            }
            Console.WriteLine(sum);
        }

        static void Nreqemsay(int n)
        {
            int suy = 0;
            while (n > 0)
            {
                suy++;
                n /= 10;
            }
            Console.WriteLine(suy);
        }

        static string SadeMurekkeb(int n)
        {
            if (n < 2)
                return "Nə sadə, nə də mürəkkəbdir";
            for (int i = 2; i * i <= n; i++)
                if (n % i == 0)
                    return "Mürəkkəbdir";
            return "Sadədir";
        }

        static void NreqemPoindrom(int n)
        {
            int sum = 0;
            int n1 = n;
            while (n > 0)
            {
                sum =(sum*10)+ (n % 10);
                n /= 10;
            }
            if (sum == n1)
                Console.WriteLine("polindrom");
            else
                Console.WriteLine("pol deyil");
        }

        static void Fibo(int n)
        {
            int a = 0;
            int b = 1;
            for (int i = 0; i < n; i++)
            {
                Console.Write(a + " ");
                (a, b) = (b, a + b);
            }
        }
    }
}