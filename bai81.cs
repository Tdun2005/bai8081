Thread.Sleep(100)
Namespace: System.Threading
Chức năng: Dừng thực thi luồng hiện tại trong khoảng thời gian đã chỉ định (trong trường hợp này là 100ms).
Đồng bộ: Đây là một phương pháp đồng bộ. Khi bạn gọi Thread.Sleep(100), luồng hiện tại sẽ bị khóa và dừng trong 100ms, không thể thực thi bất kỳ công việc nào khác.
Sử dụng: Phù hợp khi bạn muốn tạm dừng một luồng trong một thời gian ngắn và không cần thực hiện công việc nào khác trong thời gian chờ.
Task.Delay(100)
Namespace: System.Threading.Tasks
Chức năng: Tạo ra một tác vụ không đồng bộ hoàn thành sau một khoảng thời gian đã chỉ định (trong trường hợp này là 100ms).
Không đồng bộ: Đây là một phương pháp không đồng bộ. Khi bạn gọi Task.Delay(100), tác vụ sẽ trả về ngay lập tức và cho phép luồng hiện tại thực thi các công việc khác trong khi chờ tác vụ hoàn thành.
Sử dụng: Phù hợp khi bạn làm việc với lập trình không đồng bộ (async/await) và muốn tạo ra một khoảng thời gian chờ mà không chặn luồng hiện tại
