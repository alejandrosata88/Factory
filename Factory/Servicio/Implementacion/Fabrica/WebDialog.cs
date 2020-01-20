using Factory.Servicio.Interface;

namespace Factory.Servicio.Implementacion.Fabrica
{
    public class WebDialog : IFabrica
    {
        IBoton IBoton { get; set; }

        public WebDialog(IBoton _IBoton)
        {
            IBoton = _IBoton;
        }

        public string CrearBoton()
        {
            return IBoton.Renderizar();
        }
    }
}
