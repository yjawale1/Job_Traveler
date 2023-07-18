using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ASME_Forms.Models
{
    public class ASME_CBI_HX
    {
        [Key]
        public int Id { get; set; }
        //Top level input
        [DisplayName("JOB TRAVELER#")]
        public int JOB_TRAVELER_NUMBER_HX { get; set; }
        [DisplayName("PART#")]
        public string? PART_NUMBER_HX { get; set; }
        [DisplayName("HX SN#")]
        public string? HX_NUMBER_HX { get; set; }
        [DisplayName("DESCRIPTION:")]
        public string? DESCRIPTION_HX { get; set; }
        [DisplayName("DWG#")]
        public string? DWG_NUMBER_HX { get; set; }
        [DisplayName("MVP#")]
        public string? MVP_NUMBER_HX { get; set; }

        //Table inputs

        //Row1
        public int? CHAMBER_HEAD_FITUP_EMP_NUMBER { get; set; }
        public string? CHAMER_HEAD_PVI_LOT_NUMBER { get; set; }
        public string? CHAMBER_HEAD_MFG { get; set; }

        //Row2
        public int? BOTTOM_HEAD_FITUP_EMP_NUMBER { get; set; }
        public string? BOTTOM_HEAD_PVI_LOT_NUMBER { get; set; }
        public string? BOTTOM_HEAD_PVI_LOT_MFG { get; set; }

        //Row3
        public int? TUBE_INSTALL_FITUP_EMP_NUMBER { get; set; }
        public string? TUBE_INSTALL_MFG { get; set; }

        //Row4
        public int? TUBE_VERIFICATION_1_FITUP_EMP_NUMBER { get; set; }
        public string? TUBE_VERIFICATION_1_MFG { get; set; }

        //Row5
        public int? TUBE_TACK_WELD_FITUP_EMP_NUMBER { get; set; }
        public string? TUBE_TACK_WELD_MFG { get; set; }

        //Row6
        public int? TUBE_ROLL_FITUP_EMP_NUMBER { get; set; }
        public string? TUBE_ROLL_MFG { get; set; }

        //Row7
        public int? TUBE_VERIFICATION_2_FITUP_EMP_NUMBER { get; set; }
        public string? TUBE_VERIFICATION_2_MFG { get; set; }

        //Row8
        public int? ROBOT_TUBE_WELD_FITUP_EMP_NUMBER { get; set; }
        public string? ROBOT_TUBE_WELD_WELD_ID { get; set; }
        public string? ROBOT_TUBE_WELD_MFG { get; set; }

        //Row9
        public int? CHAMBER_SHELL_FITUP_EMP_NUMBER { get; set; }
        public int? CHAMBER_SHELL_WELD_ID { get; set; }
        public string? CHAMBER_SHELL_PVI_LOT_NUMBER { get; set; }
        public string? CHAMBER_SHELL_PVI_MFG { get; set; }

        //Row10
        public int? QA_FINAL_INSP_FITUP_EMP_NUMBER { get; set; }
        public DateTime? QA_FINAL_INSP_DATE { get; set; }

        //Row11
        public string? CBI_HX_NOTES_LINE_1 { get; set; }
        public string? CBI_HX_NOTES_LINE_2 { get; set; }
        public string? CBI_HX_NOTES_LINE_3 { get; set; }


    }
}
