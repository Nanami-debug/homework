using ORDER;
using ORDER_SERVICE;
namespace SCF_Homework_5._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Order_Service order_Service = new Order_Service();
            Console.WriteLine("欢迎进入订单服务程序");
            Console.WriteLine("请选择您的业务：\n1-添加订单\n2-删除订单\n3-查找订单\n4-修改订单\n5-查询利润\n6-退出");
            int choice = 0;
            bool flag = true;

            while (flag)
            {
                // 捕获主菜单输入错误
                try
                {
                    choice = int.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("请正确输入服务代号");
                    continue; // 直接跳过本次循环剩余代码
                }

                switch (choice)
                {
                    case 1:
                        try
                        {
                            Console.WriteLine("请输入您的姓名");
                            string name = Console.ReadLine();
                            int id = order_Service.Add_Order(name);
                            Console.WriteLine($"订单创建成功，你的订单号为{id}");
                            Console.WriteLine("请继续输入您要订购的货物及其数量和单价（格式：商品名 数量 单价）");

                            string input = Console.ReadLine();
                            string[] parts = input.Split(' ');

                            // 校验输入格式
                            if (parts.Length < 4 || parts.Length % 3 != 1)
                                throw new FormatException("输入格式错误：应为商品名 数量 单价的三元组");

                            for (int i = 1; i < parts.Length; i += 3)
                            {
                                string name_of_good = parts[i];
                                int num = int.Parse(parts[i + 1]);
                                int cost = int.Parse(parts[i + 2]);
                                order_Service.add_order_datail(id, name_of_good, num, cost);
                            }
                            Console.WriteLine("订单创建成功");
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("请正确输入商品信息（格式：商品名 数量 单价）," +
                                "请再次输入服务代号后重新进入服务");
                        }
                        catch (OverflowException)
                        {
                            Console.WriteLine("数量或单价超出有效范围（0-2147483647）");
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine($"发生错误：{ex.Message}");
                        }
                        break;

                    case 2:
                        try
                        {
                            Console.WriteLine("请输入您要删除的订单id");
                            int del_id = int.Parse(Console.ReadLine());
                            order_Service.Remove_Order(del_id);
                            Console.WriteLine("订单删除成功");
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("请正确输入订单ID（整数格式）");
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine($"删除失败：{ex.Message}");
                        }
                        break;

                    case 3:
                        try
                        {
                            Console.WriteLine("请输入您的名字");
                            string search_id = Console.ReadLine();
                            List<Order> user_orders = order_Service.Get_Order(search_id);
                            foreach (Order s in user_orders)
                            {
                                Console.WriteLine(s.ToString());
                            }
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine($"查询失败：{ex.Message}");
                        }
                        break;

                    case 4:
                        try
                        {
                            Console.WriteLine("请输入您要修改的订单id号");
                            int change_id = int.Parse(Console.ReadLine());
                            Console.WriteLine("请输入您想修改的商品信息（格式：商品名 数量 单价）");
                            string input4 = Console.ReadLine();
                            string[] parts4 = input4.Split(' ');

                            // 校验输入格式
                            if (parts4.Length < 4 || parts4.Length % 3 != 1)
                                throw new FormatException("输入格式错误：应为商品名 数量 单价的三元组");

                            for (int i = 1; i < parts4.Length; i += 3)
                            {
                                string name_of_good = parts4[i];
                                int num = int.Parse(parts4[i + 1]);
                                int cost = int.Parse(parts4[i + 2]);
                                order_Service.change_Order_Datail(change_id, name_of_good, num, cost);
                            }
                            Console.WriteLine("订单修改成功");
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("请正确输入商品信息（格式：商品名 数量 单价）");
                        }
                        catch (OverflowException)
                        {
                            Console.WriteLine("数量或单价超出有效范围（0-2147483647）");
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine($"修改失败：{ex.Message}");
                        }
                        break;

                    case 5:
                        try
                        {
                            Console.WriteLine("请输入您要查询的订单id");
                            int pro_id = int.Parse(Console.ReadLine());
                            Console.WriteLine($"该订单利润为" +
                                $"{order_Service.get_Profit(pro_id)}");
                            
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("请正确输入订单ID（整数格式）");
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine($"没有找到订单：{ex.Message}");
                        }
                        break;
                    case 6:
                        Console.WriteLine("服务已结束");
                        flag = false;
                        break;

                    default:
                        Console.WriteLine("请正确输入服务代号");
                        break;
                }
            }
        }
    }
}
