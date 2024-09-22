namespace AvoidTooManyParameters_CleanCode
{
    class Program
    {
        static void Main(string[] args)
        {
            CreateOrder(1, 20, "address", "khalid karam", DateTime.Today);

            CreateOrderV2(new OrderDetails(), new CustomerDetails());
        }

        static void CreateOrder(int productId, int quantity, string shippingAddress, string customerName, DateTime deliveryDate, string customerEmail = "")
        {

        }

        static void CreateOrderV2(OrderDetails orderDetails, CustomerDetails customerDetails)
        {

        }


    }

    class OrderDetails
    {
        public int productId { get; set; }
        public int quantity { get; set; }
        public DateTime deliveryDate { get; set; }
        public string shippingAddress { get; set; }
    }
    class CustomerDetails
    {
        public string EmailAddress { get; set; }
        public string FullName { get; set; }

    }



}
