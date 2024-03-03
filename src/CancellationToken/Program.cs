using System;
using System.Threading;
using System.Threading.Tasks;

class Example
{
    static async Task Main()
    {
        // Tạo đối tượng CancellationTokenSource
        CancellationTokenSource cts = new CancellationTokenSource();

        // Truyền CancellationToken từ CancellationTokenSource vào phương thức
        Task<string> task = CreateAsync("example", cts.Token);

        // Sau 8 giây, hủy bỏ tác vụ
        await Task.Delay(8000);
        cts.Cancel();

        try
        {
            // Đợi tác vụ hoàn thành
            string result = await task;
            Console.WriteLine(result);
        }
        catch (OperationCanceledException)
        {
            Console.WriteLine("Tac vu da bi huy bo.");
        }
    }

    static async Task<string> CreateAsync(string entity, CancellationToken cancellationToken = default)
    {
        // Kiểm tra trạng thái hủy bỏ
        cancellationToken.ThrowIfCancellationRequested();

        // Giả lập công việc không đồng bộ
        await Task.Delay(2000, cancellationToken);

        // Trả về kết quả
        return $"Created {entity}";
    }
}
