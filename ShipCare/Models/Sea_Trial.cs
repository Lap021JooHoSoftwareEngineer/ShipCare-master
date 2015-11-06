using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShipCare.Models
{
    [Table("Sea_Trial")]     //해양테스트
    public class Sea_Trial
    {
        public string Ship_Paticular_Callsign { get; set; }

        public int Sea_Trial_Id { get; set; }
        public float Sea_Trial_Load_Gap { get; set; }
        public double Sea_Trial_Speed_Ballast2 { get; set; }   //선박속도
        public double Sea_Trial_Power_Bal { get; set; }        //배마력
        public double Sea_Trial_Speed_Laden1 { get; set; }     //선박속도
        public double Sea_Trial_Power_Scantling { get; set; }  //배마력
        public float Sea_Trial_Sea_Margine { get; set; }        //비율

        public virtual Ship_Paticular Ship_Paticular { get; set; }

    }
}
