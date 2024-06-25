

using System.Data;
using System.Xml.Serialization;
using Microsoft.IdentityModel.Protocols;



namespace Test
{
    class Employee : Person
    {
        public string Id {get; set;} = string.Empty;
        public string Job {get; set;} = string.Empty;
        public float Salary {get; set;}

    


        public Employee() 
        {
            Id = EmployeeFunc.GenerateID();
            Salary = -1;
            Age = -1;
            Height = -1;
        }

        public Employee(string job, float salary, string first_name, string last_name, string email, string password, int age, float height, string cpf)
        {
            Id = EmployeeFunc.GenerateID();
            Job = job;
            Salary = salary;
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
        {return $"\nId: {Id}\n Nome: {FirstName + " " + LastName}\nCargo: {Job}\nSalary: {Salary}\nIdade: {Age}\nAltura: {Height}\nCPF: {Cpf}\nE-mail: {Email}\nSenha: {Password}\n";
        }
    }
}