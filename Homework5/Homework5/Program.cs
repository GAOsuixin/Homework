using System;

using System.Collections.Generic;

using System.Linq;

using System.Text;

using System.Threading.Tasks;


namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            OrderService service = new OrderService();
            List<OrderDetail> orderDetailsList1 = new List<OrderDetail>(new OrderDetail[]
            {
                service.placeOrderDetail(1,"张三",2,20),
                service.placeOrderDetail(2,"李四",3,60),
            });
            service.AddOrder(1, orderDetailsList1);
            service.queryOrderById(1);
        }
    }
    class Order
    {
        public int OrderId;
        public int Order_sum
        {
            get { return Order_sum; }
            set
            {
                foreach (OrderDetail temp in OrderDetailsList)
                {
                    Order_sum += temp.productNum * temp.productPrice;
                }
            }
        }
        public Order(int i, List<OrderDetail> list)
        {
            this.OrderId = i;
            foreach (OrderDetail temp in list)
            {
                OrderDetailsList.Add(temp);
            }
        }
        public override string ToString()
        {
            return OrderId + "总价：" + Order_sum;
        }
        List<OrderDetail> OrderDetailsList = new List<OrderDetail>();
    }
    class OrderDetail
    {
        public int orderId { get; set; }
        public string customer { get; set; }
        public int productNum { get; set; }
        public int productPrice { get; set; }
        public override string ToString()
        {
            return "orderId:" + orderId + "customer:" + customer + "productNum:" + productNum + "productPrice:" + productPrice;
        }
        public OrderDetail(int i, string c, int n, int p)
        {
            this.orderId = i;
            this.customer = c;
            this.productNum = n;
            this.productPrice = p;
        }
    }
    class OrderService
    {
        List<Order> OrderList = new List<Order>();
        public void queryOrderById(int id)
        {
            var query = from order in OrderList
                        where order.OrderId == id
                        orderby order.Order_sum
                        select order;
            foreach (var q in query)
            {
                Console.WriteLine(q);
            }
        }
        public void AddOrder(int orderI, List<OrderDetail> list)
        {
            Order temp = new Order(orderI, list);
            OrderList.Add(temp);
        }
        public OrderDetail placeOrderDetail(int i, string c, int n, int p)
        {
            return new OrderDetail(i, c, n, p);
        }
    }
}