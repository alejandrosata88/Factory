using Factory.Servicio.Interface;

namespace Factory.Servicio.Implementacion.Fabrica
{
    public class WindowDialog : IFabrica
    {
        IBoton IBoton { get; set; }

        public WindowDialog(IBoton _iBoton)
        {
            IBoton = _iBoton;
        }

        public string CrearBoton()
        {
            return IBoton.Renderizar();
        }
    }
}
