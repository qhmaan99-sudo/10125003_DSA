// Bài 1
static long Tong(int n)
{
    if (n == 1)
        return 1;

    return Tong(n - 1) + n;
}

// Bài 2
static long TongBinhPhuong(int n)
{
    if (n == 1)
        return 1;

    return TongBinhPhuong(n - 1) + (long)n * n;
}

// Bài 3
static double TongNghichDao(int n)
{
    if (n == 1)
        return 1.0;

    return TongNghichDao(n - 1) + 1.0 / n;
}

// Bài 4
static double LuyThua(double x, int n)
{
    if (n == 0)
        return 1;

    return x * LuyThua(x, n - 1);
}

// Bài 5
static int UocLeMax(int n)
{
    if (n % 2 == 1)
        return n;

    return UocLeMax(n / 2);
}

// Bài 6
static int Ucln(int a, int b)
{
    if (b == 0)
        return a;

    return Ucln(b, a % b);
}

// Bài 7
static int SoChuSo(int n)
{
    if (n < 10)
        return 1;

    return SoChuSo(n / 10) + 1;
}

// Bài 8
static double TongCan(int i, int n)
{
    if (i == n)
        return Math.Sqrt(n);

    return Math.Sqrt(i + TongCan(i + 1, n));
}
