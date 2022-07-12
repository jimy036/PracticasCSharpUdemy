using System;


namespace ClasePersona
{
    internal class Persona
    {
        #region Propiedades
        public string Name { get; set; }
        public string Lastname { get; set; }

        private int _age;
        
        public int Age
        {
            get { return _age; }
            set { _age = value < 0 ? 0 : value; }

        }
        #endregion

        #region Constructores
        public Persona(string name)
        {
            Name = name;
        }

        public Persona(string name, string lastname) : this(name)
        {
            Lastname = lastname;
        }

        public  Persona(string name, string lastname, int age) : this(name, lastname)
        {
            _age = age;
        }

        public Persona()
        {

        }

        #endregion

        #region Metodos
        public void Saludar()
        {
            Console.WriteLine("Hola {0} {1} sus datos són: \n", Name, Lastname);
        }

        public override string ToString()
        {
            return String.Format("Nombre: {0} \nApellido: {1} \nEdad: {2}", Name, Lastname, Age);
        }

        #endregion

    }
}
