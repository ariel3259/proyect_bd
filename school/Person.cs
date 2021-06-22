using System;
namespace school
{
    public class Person
    {
        private int id;
        private string name;
        public string lastname;
        public string email;
        public string password;
        public string nickname;
        public string create_at;
        public string update_at;

        public Person(int id,string name, string lastname, string email, string password, string nickname, string create_at,string update_at)
        {
            this.id = id;
            this.name = name;
            this.lastname = lastname;
            this.email = email;
            this.password = password;
            this.nickname = nickname;
            this.create_at = create_at;
            this.update_at = update_at;
        }
        public override string ToString() => ("Nombre: "+this.name+"\nApellido: "+this.lastname+"\nCorreo: "+this.email+"\nContraseña: "+this.password);
    }
}
