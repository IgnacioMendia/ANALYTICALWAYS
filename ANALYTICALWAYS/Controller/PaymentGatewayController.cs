using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ANALYTICALWAYS.Controller
{
    public class PaymentGatewayController
    {
        public bool PaymentStudent()
        {
			try
			{
				//Se evalua segun el medio de pago admitido, se realiza la transaccion y se espera el resultado de la misma
				//en este caso de prueba voy a devolver un tru, simulando que la entidad que recibe el pago lo acepto correctamente
				return true;
			}
			catch (Exception)
			{
				return false;
			}
        }
    }
}
