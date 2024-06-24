

namespace Test
{
    class Person
    {
        public string _first_name {get; set;} = string.Empty;
        public string _last_name {get; set;} = string.Empty;
        public string _email {get; set;} = string.Empty;
        public string _password {get; set;} = string.Empty;
        public int _age {get; set;}
        public float _height {get; set;}
        public string _cpf {get; set;} = string.Empty;


        public Person()
        {
            _age = -1;
            _height = -1;
        }

        public Person(string first_name, string last_name, string email, string password, int age, float height, string cpf)
        {
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
            return $"\nNome: {_first_name + " " + _last_name}\nIdade: {_age}\nAltura: {_height}\nCPF: {_cpf}\nE-mail: {_email}\nSenha: {_password}\n";
        }
    }
}