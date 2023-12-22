using System;

namespace Database2022
{
    public class Person
    {
        public int PersonId { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public DateTime Fecha { get; set; } // Nuevo campo
        public string Curso { get; set; }   // Nuevo campo
        public string Genero { get; set; }  // Nuevo campo
    }
}
