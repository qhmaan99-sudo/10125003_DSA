// Bài 1
static long Tong(int n)
{
    if (n == 1)
        return 1;

    return Tong(n - 1) + n;
}

static void Bai1()
{
    int n = 5;
    Console.WriteLine("Bài 1: " + Tong(n));
}


// Bài 2
static long TongBinhPhuong(int n)
{
    if (n == 1)
        return 1;

    return TongBinhPhuong(n - 1) + (long)n * n;
}

static void Bai2()
{
    int n = 5;
    Console.WriteLine("Bài 2: " + TongBinhPhuong(n));
}


// Bài 3
static double TongNghichDao(int n)
{
    if (n == 1)
        return 1.0;

    return TongNghichDao(n - 1) + 1.0 / n;
}

static void Bai3()
{
    int n = 5;
    Console.WriteLine("Bài 3: " + TongNghichDao(n));
}


// Bài 4
static double LuyThua(double x, int n)
{
    if (n == 0)
        return 1;

    return x * LuyThua(x, n - 1);
}

static void Bai4()
{
    double x = 2;
    int n = 3;
    Console.WriteLine("Bài 4: " + LuyThua(x, n));
}


// Bài 5
static int UocLeMax(int n)
{
    if (n % 2 == 1)
        return n;

    return UocLeMax(n / 2);
}

static void Bai5()
{
    int n = 48;
    Console.WriteLine("Bài 5: " + UocLeMax(n));
}


// Bài 6
static int Ucln(int a, int b)
{
    if (b == 0)
        return a;

    return Ucln(b, a % b);
}

static void Bai6()
{
    int a = 24;
    int b = 36;
    Console.WriteLine("Bài 6: " + Ucln(a, b));
}


// Bài 7
static int SoChuSo(int n)
{
    if (n < 10)
        return 1;

    return SoChuSo(n / 10) + 1;
}

static void Bai7()
{
    int n = 12345;
    Console.WriteLine("Bài 7: " + SoChuSo(n));
}


// Bài 8
static double TongCan(int i, int n)
{
    if (i == n)
        return Math.Sqrt(n);

    return Math.Sqrt(i + TongCan(i + 1, n));
}

static void Bai8()
{
    int i = 1;
    int n = 5;
    Console.WriteLine("Bài 8: " + TongCan(i, n));
}
