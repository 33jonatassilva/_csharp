

namespace Test
{
    class Employee : Person
    {
        private string _id;
        private string _job;
        private float _salary;

        public Employee() //: base(_first_name, _last_name, _email, _password, _age, _height, _cpf)
        {
            _id = string.Empty;
            _job = string.Empty;
            _salary = -1;
            _age = -1;
            _height = -1;
        }

        public Employee(string id, string job, float salary, string first_name, string last_name, string email, string password, int age, float height, string cpf)
            //:base(_first_name, _last_name, _email, _password, _age, _height, _cpf)
        {
            _id = id;
            _job = job;
            _salary = salary;
            _first_name = first_name;
            _last_name = last_name;
            _email = email;
            _password = password;
            _age = age;
            _height = height;
            _cpf = cpf;
        }

        override
        public string ToString() //base(_first_name, _last_name, _email, _password, _age, _height, _cpf)
        {
            return $"\nNome: {_first_name + " " + _last_name}\nId: {_id}\nCargo: {_job}\nSalary: {_salary}\nIdade: {_age}\nAltura: {_height}\nCPF: {_cpf}\nE-mail: {_email}\nSenha: {_password}\n";
        }
    }
}