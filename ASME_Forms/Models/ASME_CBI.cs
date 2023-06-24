using System.ComponentModel.DataAnnotations;

namespace ASME_Forms.Models
{
    public class ASME_CBI
    {
        [Key]
        public int JOB_TRAVELER_NUMBER { get; set; }
        public int NATL_BD_NUMBER { get; set; }
        public int PART_NUMBER { get; set; }
        public int BASIC_TANK_NUMBER { get; set; }
        public int HX_NUMBER { get; set; }
        public string DESCRIPTION { get; set; }
        public int DWG_NUMBER { get; set; }
        public int MVP_NUMBER { get; set; }
    }
}
