using System;

Console.OutputEncoding = System.Text.Encoding.UTF8;
Console.Write("Nhập n nguyên dương: ");
int n = int.Parse(Console.ReadLine()!);
Console.Write("Nhập x để tính x^n: ");
double x = double.Parse(Console.ReadLine()!);

Console.WriteLine($"Bài 1: {Tong(n)}");
Console.WriteLine($"Bài 2: {TongBinhPhuong(n)}");
Console.WriteLine($"Bài 3: {TongNghichDao(n):F6}");
Console.WriteLine($"Bài 4: {LuyThua(x, n):F6}");
Console.WriteLine($"Bài 5: {UocLeMax(n)}");
Console.Write("Nhập a: "); int a = int.Parse(Console.ReadLine()!);
Console.Write("Nhập b: "); int b = int.Parse(Console.ReadLine()!);
Console.WriteLine($"Bài 6: UCLN = {Ucln(a, b)}");
Console.WriteLine($"Bài 7: {SoChuSo(n)} chữ số");
Console.WriteLine($"Bài 8: {TongCan(1, n):F6}");

static long Tong(int n) => n == 1 ? 1 : Tong(n - 1) + n;
static long TongBinhPhuong(int n) => n == 1 ? 1 : TongBinhPhuong(n - 1) + (long)n * n;
static double TongNghichDao(int n) => n == 1 ? 1 : TongNghichDao(n - 1) + 1.0 / n;
static double LuyThua(double x, int n) => n == 0 ? 1 : x * LuyThua(x, n - 1);
static int UocLeMax(int n) => n % 2 == 1 ? n : UocLeMax(n / 2);
static int Ucln(int a, int b) => b == 0 ? a : Ucln(b, a % b);
static int SoChuSo(int n) => n < 10 ? 1 : SoChuSo(n / 10) + 1;
static double TongCan(int i, int n) => i == n ? Math.Sqrt(n) : Math.Sqrt(i + TongCan(i + 1, n));
