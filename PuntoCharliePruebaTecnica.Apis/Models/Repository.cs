using System.Collections.Generic;

namespace PruebaTecnicaPuntoCharlie.Models
{
    /// <remarks/>
    public class Repository
    {
        /// <remarks/>
        public string Url { get; set; }

        /// <remarks/>
        public string Description { get; set; }

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
                    Commits = 1968
                },
                new Repository
                {
                    Url = "https://github.com/huandu/facebook",
                    Description = "Repositorio para cargar de archivos, solicitud por lotes y API de marketing",
                    Commits = 229
                },
                new Repository
                {
                    Url = "https://github.com/plutov/paypal",
                    Description = "Repositorio para API de PayPal",
                    Commits = 334
                }
            };
            return list;
        }
    }
    
}