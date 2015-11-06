using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShipCare.Models
{
    [Table("Ship_Paticular")]   //선박명세 테이블
    public class Ship_Paticular
    {
        public int Client_Id { get; set; }

        public string Ship_Paticular_Callsign { get; set; }     //선박코드
        public string Ship_Paticular_Name { get; set; }         //선박이름
        public string Ship_Paticular_Admin { get; set; }        //선박소유주
        public Int16 Ship_Paticular_Type { get; set; }          //선박타입 1:container, 2:tanker, 3:bulk, 4:Chemical, 5:LNG, 6:General Cargo 7: Ferry

        public string Ship_Paticular_Yard { get; set; }         //건조야드
        public string Ship_Paticular_Phone { get; set; }        //선박전화번호
        public string Ship_Paticular_Fax { get; set; }          //선박팩스번호
        public string Ship_Paticular_Email { get; set; }        //선박이메일
        public DateTime Ship_Paticular_GetDate { get; set; }    //인수날짜
        public string Ship_Paticular_Class { get; set; }        //선박선급
        public string Ship_Paticular_ImoNo { get; set; }        //IMO_NO
        public string Ship_Paticular_Country { get; set; }      //나라이름

        public decimal Ship_Paticular_LOA { get; set; }         //배길이
        public decimal Ship_Paticular_LBP { get; set; }         //배길이
        public decimal Ship_Paticular_BREADTH { get; set; }     //배길이
        public decimal Ship_Paticular_Depth_To_Upper_Deck { get; set; }//배길이
        public decimal Ship_Paticular_Dead_Weight { get; set; } //배무게
        public decimal Ship_Paticular_Displacement { get; set; }    //배무게
        public decimal Ship_Paticular_Draft_Ballast { get; set; }   //배길이
        public decimal Ship_Paticular_Draft_Laden { get; set; } //배길이
        public decimal Ship_Paticular_Draft_Scan { get; set; }  //배길이
        public string Ship_Paticular_Me_Type { get; set; }
        public decimal Ship_Paticular_Me_Power_Mcr { get; set; }//배마력
        public decimal Ship_Paticular_Me_Rpm_Mcr { get; set; }  //배마력
        public decimal Ship_Paticular_Propeller_Pitch { get; set; } //배프로펠러피치


        public virtual Client Client { get; set; }

        public virtual ICollection<Shop_Test> Shop_Tests { get; set; }
        public virtual ICollection<Sea_Trial> Sea_Trials { get; set; }
        public virtual ICollection<Sailing_Data> Sailing_Datas { get; set; }
    }
}
