using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITMO.WindowsApps.CSharp.Lab03_04
{
    class Users
    {
        private string surname;
        private string name;
        private string patronymic;
        private string age;
        private string phoneIndex;
        private string phone;
        private string email;

        public Users (string surname, string name, string patronymic, string age, string phoneIndex, string phone, string email)
        {
            this.surname = surname;
            this.name = name;
            this.patronymic = patronymic;
            this.age = age;
            this.phoneIndex = phoneIndex;
            this.phone = phone;
            this.email = email;
        }

        public Users()
        {
        }

        public override string ToString()
        {
            return "\n Фамилия: " + surname + "\n Имя: " + name + "\n Отчество: " + patronymic + "\n Возраст: " + age + 
                "\n Контакты: \n Номер телефона: +7(" + phoneIndex + ")"+ phone + "\n E-mail: " + email;
        }
    }
}
