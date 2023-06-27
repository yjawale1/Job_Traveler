using System.ComponentModel.DataAnnotations;

namespace ASME_Forms.Models
{
    public class ASME_CBI
    {
        [Key]
        public int JOB_TRAVELER_NUMBER { get; set; }
        public string? NATL_BD_NUMBER { get; set; }
        public string? PART_NUMBER { get; set; }
        public string? BASIC_TANK_NUMBER { get; set; }
        public string? HX_NUMBER { get; set; }
        public string? DESCRIPTION { get; set; }
        public string? DWG_NUMBER { get; set; }
        public string? MVP_NUMBER { get; set; }
    }
}
