namespace Site_Guia.API.Models
{
    public class Site
    {
        public int SiteID { get; set; }
        public string Categoria { get; set; }
        public string Nome { get; set; }

        public string Descricao { get; set; }

        public string URL { get; set; }

        public string ImagemURL { get; set; }

    }
}