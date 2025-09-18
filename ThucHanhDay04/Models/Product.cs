namespace ThucHanhDay04.Models
{
    public class Product
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public string Price { get; set; }
        public string Image { get; set; }

        public string Soluong { get; set; }
        public string Danhmuc { get; set; }

        public List<Product> GetListProduct()
        {
            List<Product> products = new List<Product>()
            {
                new Product
                {
                    ID = "01",
                    Name = "Quần sort nam",
                    Price = "129000 đ",
                    Image = "/Image/Quan.jpg",
                    Soluong = "20",
                },
                new Product
                {
                    ID = "02",
                    Name = "Áo sơ mi nam cotton",
                    Price = "119000đ",
                    Image = "/Image/Ao.jpg",
                    Soluong = "20",
                },
                new Product
                {
                    ID = "03",
                    Name = "Giày thể thao nam GTT23.4",
                    Price = "500000đ",
                    Image = "/Image/Giay.jpg",
                    Soluong = "20",
                }

            };


            return products;
        }
    }
}
