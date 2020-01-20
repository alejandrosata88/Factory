using Factory.Servicio.Interface;

namespace Factory.Servicio.Implementacion.Boton
{
    class WindowButton : IBoton
    {
        public string Renderizar()
        {
            return "Se creo el boton en windows";
        }
    }
}
