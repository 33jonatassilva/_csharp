

namespace Test
{
    class Person
    {
        private string _first_name;
        private string _last_name;
        private string _email;
        private string _password;
        private int _age;
        private float _height;
        private string _cpf;


        public Person()
        {
            _first_name = "";
            _last_name = "";
            _email = "";
            _password = "";
            _age = -1;
            _height = -1;
            _cpf = "";
        }

        public Person(string first_name, string last_name, string email, string password, int age, float height, string cpf){
            _first_name = first_name;
            _last_name = last_name;
            _email = email;
            _password = password;
            _age = age;
            _height = height;
            _cpf = cpf;
        }

        override
        public string ToString()
        {
            return $" \n Nome: {_first_name + " " + _last_name}\n Idade: {_age}\n Altura: {_height}\n CPF: {_cpf}\n E-mail: {_email}\n Senha: {_password}\n";
        }
    }
}