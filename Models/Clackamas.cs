using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Scouting_v2.Models
{
    public class Clackamas
    {
       
        public int ID { get; set; }
        public int Team { get; set; }
        public decimal Baseline { get; set; }
        [Display(Name = "A1Avg")]
        public decimal AutoBalls_LVL_1_A { get; set; }
        [Display(Name = "A1Max")]
        public decimal AutoBalls_LVL_1_M { get; set; }
        [Display(Name = "A2Avg")]
        public decimal AutoBalls_LVL_2_A { get; set; }
        [Display(Name = "A2Max")]
        public decimal AutoBalls_LVL_2_M { get; set; }
        [Display(Name = "A3Avg")]
        public decimal AutoBalls_LVL_3_A { get; set; }
        [Display(Name = "A3Max")]
        public decimal AutoBalls_LVL_3_M { get; set; }
        [Display(Name = "T1Avg")]
        public decimal TeleopBalls_LVL_1_A { get; set; }
        [Display(Name = "T1Max")]
        public decimal TeleopBalls_LVL_1_M { get; set; }
        [Display(Name = "T2Avg")]
        public decimal TeleopBalls_LVL_2_A { get; set; }
        [Display(Name = "T2Max")]
        public decimal TeleopBalls_LVL_2_M { get; set; }
        [Display(Name = "T3Avg")]
        public decimal TeleopBalls_LVL_3_A { get; set; }
        [Display(Name = "T3Max")]
        public decimal TeleopBalls_LVL_3_M { get; set; }
        [Display(Name = "S#A")]
        public decimal Spinner_Number_A { get; set; }
        [Display(Name = "SCA")]
        public decimal Spinner_Colour_A { get; set; }
        [Display(Name = "CA")]
        public decimal Climbed_A { get; set; }
        [Display(Name = "CHS")]
        public decimal Climb_HI_S { get; set; }
        [Display(Name = "CMS")]
        public decimal Climb_MI_S { get; set; }
        [Display(Name = "CLS")]
        public decimal Climb_LO_S { get; set; }
        [Display(Name = "BA")]
        public decimal Balanced_A { get; set; }
        
    }

}
