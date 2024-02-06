namespace HogaryModa.Apis.Models
{
    /// Entidad para almacenar los procesos para validar si existen o no errores
    public class Response
    {
        /// <remarks/>
        public bool State { get; set; }
        /// <remarks/>
        public string Code { get; set; }
        /// <remarks/>
        public string Messsage { get; set; }
        /// <remarks/>
    }
}