using System.ComponentModel.DataAnnotations;

public class Mahasiswa
    {
        public int id { get; set; }

        public string? nama { get; set; }

        public string? nim { get; set; }

        public string? alamat { get; set; }

        public string? email { get; set; }

        public string? foto { get; set; }
        public int nim_progmob { get; set; }
    }