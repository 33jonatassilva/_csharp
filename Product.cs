namespace Test
{
    class Product
    {
        private string _id;
        private string _name;
        private string _category;
        private float _value;
        private int _quantity;


        public Product()
        {
            _id = "";
            _name = "";
            _category = "";
            _value = -1;
            _quantity = -1;
        }

    public Product(string id, string name, string category, float value, int quantity)
        {
            _id = id;
            _name = name;
            _category = category;
            _value = value;
            _quantity = quantity;
        }

        override
        public string ToString()
        {
            return $"ID: {_id}\nNome: {_name}\nCategoria: {_category}\nValue: {_value}\nQuantidade: {_quantity}\n";
        }
    }
}