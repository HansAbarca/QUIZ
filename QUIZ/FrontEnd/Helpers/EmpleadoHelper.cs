using FrontEnd.Models;
using FrontEND.Helpers;
using Newtonsoft.Json;

namespace FrontEnd.Helpers
{
    public class EmpleadoHelper
    {
        ServiceRepository repository;

        public EmpleadoHelper()
        {
            repository = new ServiceRepository();
        }
        public List<EmpleadoViewModel> GetAll()
        {
            List<EmpleadoViewModel> lista;
            HttpResponseMessage responseMessage = repository.GetResponse("api/Empleado");
            if (responseMessage != null)
            {
                var content = responseMessage.Content.ReadAsStringAsync().Result;
                lista = JsonConvert.DeserializeObject<List<EmpleadoViewModel>>(content);
            }


            return new List<EmpleadoViewModel>();
        }
    }
}
