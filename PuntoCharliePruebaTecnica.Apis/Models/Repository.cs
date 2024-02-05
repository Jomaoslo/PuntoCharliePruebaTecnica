using System;
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
        public DateTime Date { get; set; }

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
                    Date = Convert.ToDateTime("2020/12/31"),
                    Commits = 8
                },
                new Repository
                {
                    Url = "https://github.com/airbnb/javascript",
                    Description = "Repositorio de Java Script para Airbnb",
                    Date = Convert.ToDateTime("2021/12/31"),
                    Commits = 2
                },
                new Repository
                {
                    Url = "https://github.com/airbnb/javascript",
                    Description = "Repositorio de Java Script para Airbnb",
                    Date = Convert.ToDateTime("2022/12/31"),
                    Commits = 1960
                },
                new Repository
                {
                    Url = "https://github.com/huandu/facebook",
                    Description = "Repositorio para cargar de archivos, solicitud por lotes y API de marketing",
                    Date = Convert.ToDateTime("2021/12/31"),
                    Commits = 29
                },
                new Repository
                {
                    Url = "https://github.com/huandu/facebook",
                    Description = "Repositorio para cargar de archivos, solicitud por lotes y API de marketing",
                    Date = Convert.ToDateTime("2022/12/31"),
                    Commits = 200
                },
                new Repository
                {
                    Url = "https://github.com/plutov/paypal",
                    Description = "Repositorio para API de PayPal",
                    Date = Convert.ToDateTime("2020/12/31"),
                    Commits = 34
                },
                new Repository
                {
                    Url = "https://github.com/plutov/paypal",
                    Description = "Repositorio para API de PayPal",
                    Date = Convert.ToDateTime("2021/12/25"),
                    Commits = 300
                }
            };
            return list;
        }
    }
    
}