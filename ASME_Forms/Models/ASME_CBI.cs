using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ASME_Forms.Models
{
    public class ASME_CBI
    {
        //Top level input
        [Key]
        public int Id { get; set; }
        [DisplayName("JOB TRAVELER#")]
        public int JOB_TRAVELER_NUMBER { get; set; }
        [DisplayName("NATL.BD.#")]
        public string? NATL_BD_NUMBER { get; set; }
        [DisplayName("PART#")]
        public string? PART_NUMBER { get; set; }
        [DisplayName("BASIC TANK SN#")]
        public string? BASIC_TANK_NUMBER { get; set; }
        [DisplayName("HX SN#")]
        public string? HX_NUMBER { get; set; }
        [DisplayName("DESCRIPTION:")]
        public string? DESCRIPTION { get; set; }
        [DisplayName("DWG#")]
        public string? DWG_NUMBER { get; set; }
        [DisplayName("MVP#")]
        public string? MVP_NUMBER { get; set; }

        //Table inputs

        //Row1
        public int? PLATE_ROLLS_WELDER_1 { get; set; }
        public int? PLATE_ROLLS_WELDER_2 { get; set; }
        public string? PLATE_ROLLS_LOT_NUMBER_1 { get; set; }
        public string? PLATE_ROLLS_LOT_NUMBER_2 { get; set; }
        public string? PLATE_ROLLS_MFG_1 { get; set; }
        public string? PLATE_ROLLS_MFG_2 { get; set; }

        //Row2
        public int? LONGSEAM_WELD_WELDER { get; set; }
        public string? LONGSEAM_WELD_MFG { get; set; }

        //Row3
        public int? JOGGLE_WELDER { get; set; }
        public string? JOGGLE_MFG { get; set; }

        //Row4
        public int? TOP_HEAD_WELDER { get; set; }
        public string? TOP_HEAD_LOT_NUMBER { get; set; }
        public string? TOP_HEAD_MFG { get; set; }

        //Row5
        public int? TUBE_VERIFICATION_HX_INSTALLATION_WELDER { get; set; }
        public string? TUBE_VERIFICATION_HX_INSTALLATION_MFG { get; set; }

        //Row6
        public int? CHAMBER_HEAD_WELDER { get; set; }
        public string? CHAMBER_HEAD_MFG { get; set; }

        //Row7
        public int? BOTTOM_HEAD_WELDER { get; set; }
        public string? BOTTOM_HEAD_MFG { get; set; }

        //Row8
        public int? CHAMBER_SHELL_WELDER { get; set; }
        public string? CHAMBER_SHELL_MFG { get; set; }

        //Row9
        public int? ATTACHMENTS_WELDER { get; set; }
        public string? ATTACHMENTS_LOT_NUMBER { get; set; }
        public string? ATTACHMENTS_MFG { get; set; }

        //Row10
        public int? ERW_STUD_WELDER { get; set; }
        public string? ERW_STUD_MFG { get; set; }

        //Row11
        public int? MFG_HYDRO_TEST_WELDER { get; set; }
        public DateTime? MFG_HYDRO_TEST_DATE { get; set; }

        //Row12
        public int? MFG_NATL_BD_NUMBER_WELDER { get; set; }
        public DateTime? MFG_NATL_BD_NUMBER_DATE { get; set; }

        //Row13
        public int? QA_NATL_BD_NUMBER_WELDER { get; set; }
        public DateTime? QA_NATL_BD_NUMBER_DATE { get; set; }

        //Row14
        public int? QA_HYDRO_TEST_WELDER { get; set; }
        public DateTime? QA_HYDRO_TEST_DATE { get; set; }
        public int? QA_HYDRO_TEST_PSI { get; set; }
        public int? QA_HYDRO_TEST_GAUGE { get; set; }

        //Row15
        public int? AI_HYDRO_TEST_WELDER { get; set; }
        public DateTime? AI_HYDRO_TEST_DATE { get; set; }

        //Row16
        public int? CONDENSATE_PAN_WELDER { get; set; }
        public string? CONDENSATE_PAN_MFG { get; set; }

        //Row17
        public int? FLUE_ASSEMBLY_WELDER { get; set; }
        public string? FLUE_ASSEMBLY_MFG { get; set; }

        //Row18
        public int? BASE_CLEAT_WELDER { get; set; }
        public string? BASE_CLEAT_MFG { get; set; }

        //Row19
        public int? MFG_FINAL_INSP_WELDER { get; set; }
        public DateTime? MFG_FINAL_INSP_DATE { get; set; }

        //Capture Inputs
        public int? EMP_NUMBER { get; set; }

        public DateTime? CAPTURE_DATE { get; set; }

        //photo store
        public byte[]? PRODUCT_NUMBER { get; set; }
    }
}
