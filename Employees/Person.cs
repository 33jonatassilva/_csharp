

namespace Test
{
    class Person
    {
        public string FirstName {get; set;} = string.Empty;
        public string LastName {get; set;} = string.Empty;
        public string Email {get; set;} = string.Empty;
        public string Password {get; set;} = string.Empty;
        public int Age {get; set;}
        public float Height {get; set;}
        public string Cpf {get; set;} = string.Empty;


        public Person()
        {
            Age = -1;
            Height = -1;
        }

        public Person(string first_name, string last_name, string email, string password, int age, float height, string cpf)
        {
            FirstName = first_name;
            LastName = last_name;
            Email = email;
            Password = password;
            Age = age;
            Height = height;
            Cpf = cpf;
        }

        override
        public string ToString()
        {
            return $"\nNome: {FirstName + " " + LastName}\nIdade: {Age}\nAltura: {Height}\nCPF: {Cpf}\nE-mail: {Email}\nSenha: {Password}\n";
        }
    }
}