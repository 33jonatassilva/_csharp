using Microsoft.Identity.Client;

namespace Test
{
    class Product
    {
        public string _id {get; set;}
        public string _name {get; set;}
        public string _category {get; set;}
        public float _value {get; set;}
        public int _quantity {get; set;}


        public Product()
        {
            _id = string.Empty;
            _name = string.Empty;
            _category = string.Empty;
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