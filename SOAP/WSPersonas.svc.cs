using System;

namespace Soap
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Service1" en el código, en svc y en el archivo de configuración.
    // NOTE: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione Service1.svc o Service1.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class WSPersonas : IWSPersonas
    {
        public Persona GetPersona(string id)
        {
            if (id == "0")
            {
                return new Persona() { Nombre = "Felipe", Edad = 45 };
            }
            else if (id == "1")
            {
                return new Persona() { Nombre = "Juan Pablo", Edad = 33 };
            }
            else if (id=="3")
            {
                return new Persona() { Nombre = "Maria Isabel", Edad = 27 };
            }
            else
            {
                return new Persona() { Error = "Persona no Encontrada, verifique información" };
            }
        }
    }
}
