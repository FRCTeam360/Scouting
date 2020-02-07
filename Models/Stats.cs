using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Scouting_v2.Models
{
    public class Stats
    {
        public int ID { get; set; }
        public string CompetitionId { get; set; }
        public int Match { get; set; }
        public int Team { get; set; }
        public decimal Baseline { get; set; }
        [Display(Name = "A1")]
        public decimal AutoBalls_LVL_1 { get; set; }
        [Display(Name = "A2")]
        public decimal AutoBalls_LVL_2 { get; set; }
        [Display(Name = "A3")]
        public decimal AutoBalls_LVL_3 { get; set; }
        [Display(Name = "T1")]
        public decimal TeleopBalls_LVL_1 { get; set; }
        [Display(Name = "T2")]
        public decimal TeleopBalls_LVL_2 { get; set; }
        [Display(Name = "T3")]
        public decimal TeleopBalls_LVL_3 { get; set; }
        [Display(Name = "Spin#")]
        public decimal Spinner_Number { get; set; }
        [Display(Name = "SpinCol")]
        public decimal Spinner_Colour { get; set; }
        [Display(Name = "Climb")]
        public decimal Climbed { get; set; }
        [Display(Name = "ClimbH")]
        public decimal Climb_HI { get; set; }
        [Display(Name = "ClimbM")]
        public decimal Climb_MI { get; set; }
        [Display(Name = "ClimbL")]
        public decimal Climb_LO { get; set; }
        [Display(Name = "Bal")]
        public decimal Balanced { get; set; }

        //[DataType(DataType.Date)]
        //public DateTime ReleaseDate { get; set; }

    }
}
