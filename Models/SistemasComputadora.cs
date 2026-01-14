namespace simple.Models
{
    public class SistemasComputadora
    {
                public int Id { get; set; }

        public string Marca { get; set; } = string.Empty;

        public string Modelo { get; set; } = string.Empty;

        public int MemoriaRamGB { get; set; }

        public decimal Precio { get; set; }

        public bool TieneGraficaDedicada { get; set; }
    }
}