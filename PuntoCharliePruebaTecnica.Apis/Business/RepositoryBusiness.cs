using HogaryModa.Apis.Models;
using PruebaTecnicaPuntoCharlie.Models;
using System;
using System.Collections.Generic;

namespace PruebaTecnicaPuntoCharlie.Business
{
    /// <remarks/>
    public class RepositoryBusiness
    {

        /// <remarks/>
        public RepositoryBusiness()
        {
        }

        /// Método para consultar los repositorios y su total de commits
        public (Response, List<Repository>) GetRepository()
        {
            string result = string.Empty;
            Response response;
            List<Repository> repository;
            try
            {
                response = new Response { State = true, Code = "200", Messsage = "Consulta exitosa" };
                repository = Repository.Listar();
                if (repository.Count == 0)
                {
                    response.State = false;
                    response.Code = "400";
                    response.Messsage = "No existe registros de repositorios";                         
                }
            }
            catch (Exception ex)
            {
                result = ex.Message.ToString();
                response = new Response { State = false, Code = "404", Messsage = result };
                repository = new List<Repository>();
            }
            return (response, repository);
        }       
    } 
}