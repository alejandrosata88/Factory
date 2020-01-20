using Factory.Servicio.Implementacion.Boton;
using Factory.Servicio.Implementacion.Fabrica;
using Factory.Servicio.Interface;
using System;

namespace Factory.Controlador
{
    public class Cliente
    {
        public void Main()
        {
            string cMensaje = string.Empty;

            IFabrica Ifabrica = new WebDialog(new HTMLButton());
            cMensaje = Ifabrica.CrearBoton();
            Console.WriteLine(cMensaje);

            Ifabrica = new WindowDialog(new WindowButton());
            cMensaje = Ifabrica.CrearBoton();
            Console.WriteLine(cMensaje);
            Console.ReadLine();
        }
    }
}
