using System.Collections.Generic;

namespace PuntoCharliePruebaTecnica.Apis.Models
{
    /// Entidad para almacenar los datos de los repositorios y su total de commits
    public class Repository
    {
        /// <remarks/>
        public string Url { get; set; }
        /// <remarks/>
        public string Description { get; set; }
        public string Date { get; set; }
        /// <remarks/>
        public int Commits { get; set; }

        /// <remarks/>
        public static List<Repository> Listar()
        {
            var list = new List<Repository>()
            {
                new Repository
                {
                    Url = "https://github.com/airbnb/javascript",
                    Description = "Repositorio de Java Script para Airbnb",
                    Date = "2020/12/31",
                    Commits = 8
                },
                new Repository
                {
                    Url = "https://github.com/airbnb/javascript",
                    Description = "Repositorio de Java Script para Airbnb",
                    Date = "2021/12/31",
                    Commits = 2
                },
                new Repository
                {
                    Url = "https://github.com/airbnb/javascript",
                    Description = "Repositorio de Java Script para Airbnb",
                    Date = "2022/12/31",
                    Commits = 1960
                },
                new Repository
                {
                    Url = "https://github.com/huandu/facebook",
                    Description = "Repositorio para cargar de archivos, solicitud por lotes y API de marketing",
                    Date = "2021/12/31",
                    Commits = 29
                },
                new Repository
                {
                    Url = "https://github.com/huandu/facebook",
                    Description = "Repositorio para cargar de archivos, solicitud por lotes y API de marketing",
                    Date = "2022/12/31",
                    Commits = 200
                },
                new Repository
                {
                    Url = "https://github.com/plutov/paypal",
                    Description = "Repositorio para API de PayPal",
                    Date = "2020/12/31",
                    Commits = 34
                },
                new Repository
                {
                    Url = "https://github.com/plutov/paypal",
                    Description = "Repositorio para API de PayPal",
                    Date = "2021/12/25",
                    Commits = 300
                }
            };
            return list;
        }
    }
    
}