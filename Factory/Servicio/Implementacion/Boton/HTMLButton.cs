using Factory.Servicio.Interface;

namespace Factory.Servicio.Implementacion.Boton
{
    class HTMLButton : IBoton
    {
        public string Renderizar()
        {
            return "se creo el boton en HTNML";
        }
    }
}
