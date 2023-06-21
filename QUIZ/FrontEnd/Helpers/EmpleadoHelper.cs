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
        #region Getall
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
        #endregion
        #region GetByID
        public EmpleadoViewModel GetByID(int id)
        {
            EmpleadoViewModel empleado = new EmpleadoViewModel();

            HttpResponseMessage responseMessage = repository.GetResponse("api/Empleado/" + id);

            string content = responseMessage.Content.ReadAsStringAsync().Result;
            empleado = JsonConvert.DeserializeObject<EmpleadoViewModel>(content);

            return empleado;
        }
        #endregion
        #region Update
        public EmpleadoViewModel Edit(EmpleadoViewModel empleado)
        {
            HttpResponseMessage responseMessage = repository.PutResponse("api/Empleado/", empleado);
            var content = responseMessage.Content.ReadAsStringAsync().Result;
            EmpleadoViewModel empleadoAPI = JsonConvert.DeserializeObject<EmpleadoViewModel>(content);

            return empleadoAPI;
        }

        #endregion
        #region update
        public EmpleadoViewModel Add(EmpleadoViewModel empleado)
        {
            HttpResponseMessage responseMessage = repository.PostResponse("api/Empleado/", empleado);
            var content = responseMessage.Content.ReadAsStringAsync().Result;
            EmpleadoViewModel empleadoAPI = JsonConvert.DeserializeObject<EmpleadoViewModel>(content);

            return empleadoAPI;
        }
        #endregion
    }
}
