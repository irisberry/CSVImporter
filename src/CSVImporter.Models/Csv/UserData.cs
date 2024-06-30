using CSVImporter.Validation.Attributes;

namespace CSVImporter.Models.Csv
{
    public class UserData
    {
        [Required]
        [MaxLength(8)]
        [Regex(@"^[a-zA-Z0-9]+$")]
        public string ID { get; set; }

        [Required]
        [MaxLength(20)]
        [Character(CharacterType.FullWidth)]
        public string Name { get; set; }

        [Required]
        [MaxLength(40)]
        [Regex(@"^[a-zA-Z\s]+$")]
        public string NameAlphabet { get; set; }

        [Required]
        public string Sex { get; set; }

        [Required]
        [Regex(@"^\d{4}/\d{2}/\d{2}$")]
        public string BirthDate { get; set; }

        [Required]
        public string Prefecture { get; set; }

        public int English { get; set; }

        public int Math { get; set; }

        public int Japanese { get; set; }

        public int History { get; set; }

        public int Civics { get; set; }

        public int Science { get; set; }

        public int Informatics { get; set; }
    }
}
