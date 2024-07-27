using System;
using System.Threading;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        // Tạo và bắt đầu luồng mới để thực hiện hàm ff
        Task ffTask = Task.Run(() => ff());
        
        // Đợi cho luồng ff hoàn thành
        ffTask.Wait();
        
        // Hiển thị thông báo khi luồng kết thúc
        Console.WriteLine("Đã thực hiện xong");
    }

    static void ff()
    {
        Random random = new Random();
        
        while (true)
        {
            int n = random.Next(); // Tạo số nguyên ngẫu nhiên

            if (n % 2025 == 0)
            {
                break; // Dừng lại nếu n chia hết cho 2025
            }

            Console.WriteLine(n); // Hiển thị số nguyên ngẫu nhiên
            Thread.Sleep(100); // Delay 100ms
        }
    }
}
