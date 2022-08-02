// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Console.WriteLine("SD");
DateTime start = Convert.ToDateTime(Console.ReadLine());
Console.WriteLine("ED");
DateTime end = Convert.ToDateTime(Console.ReadLine());
TimeSpan Time = end - start;

#region số ngày làm việc
if (start.DayOfWeek == DayOfWeek.Saturday)
{
    start = start.AddDays(2);
}
else if (start.DayOfWeek == DayOfWeek.Sunday)
{
    start = start.AddDays(1);
}

if (end.DayOfWeek == DayOfWeek.Saturday)
{
    end = end.AddDays(-1);
}
else if (end.DayOfWeek == DayOfWeek.Sunday)
{
    end = end.AddDays(-2);
}

int diff = (int)end.Subtract(start).TotalDays;

int result = diff / 7 * 5 + diff % 7;

if (end.DayOfWeek < start.DayOfWeek)
{
    result -= 2;

}
#endregion

#region số ngày t7,cn
Console.Write("So ngay t7, cn :");
Console.WriteLine((Time.Days - result));
#endregion

#region các ngày lễ (tự thêm, bớt)
DateTime[] z = { Convert.ToDateTime("07/31/2022"), Convert.ToDateTime("08/25/2022"), Convert.ToDateTime("08/10/2022") };
#endregion

#region kiểm tra ngày lễ có trúng t7,cn k
int ngayle = z.Length;
foreach (var s in z)
{
    if (s.DayOfWeek == DayOfWeek.Saturday || s.DayOfWeek == DayOfWeek.Sunday)
    {
        ngayle--;
    }
}
#endregion

Console.Write("So ngay lam viec :");
Console.WriteLine(result - ngayle);