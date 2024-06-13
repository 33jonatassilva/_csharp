

namespace Test
{
    class Person
    {
        public static string _first_name = string.Empty;
        public static string _last_name = string.Empty;
        public static string _email = string.Empty;
        public static string _password = string.Empty;
        public static int _age;
        public static float _height;
        public static string _cpf = string.Empty;


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