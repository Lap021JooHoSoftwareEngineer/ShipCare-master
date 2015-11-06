using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShipCare.Models
{
    [Table("Shop_Test")]    //해양테스트전 테스트 테이블
    public class Shop_Test
    {
        public string Ship_Paticular_Callsign { get; set; }

        public int Shop_Test_Id { get; set; }                               //
        public float Shop_Test_Load_Gap { get; set; }
        public decimal Shop_Test_Power_Kw { get; set; }                     //배마력
        public decimal Shop_Test_Rpm { get; set; }                          //배회전계
        public decimal Shop_Test_Mep_Bar { get; set; }                      //압력
        public decimal Shop_Test_Fuel_Index_Mm { get; set; }
        public decimal Shop_Test_Vit_Index { get; set; }
        public decimal Shop_Test_Ambient_Pressure_Mbar { get; set; }        //mbar
        public decimal Shop_Test_Ambient_Temp_C { get; set; }               //온도
        public decimal Shop_Test_Scav_Air_Temp_Before_Blower { get; set; }  //온도
        public decimal Shop_Test_Receiver_Temp { get; set; }                //온도
        public decimal Shop_Test_A_C_Cooling_Water_Temp { get; set; }       //온도
        public decimal Shop_Test_Pmax_Bar { get; set; }                     //압력
        public decimal Shop_Test_Pcomp_Bar { get; set; }                    //압력
        public decimal Shop_Test_Psacv_Kg_Cm2 { get; set; }                 //압력
        public decimal Shop_Test_Pexh_Kg_Cm2 { get; set; }                  //압력
        public decimal Shop_Test_Exh_Temp_Cyl_Outlet_C { get; set; }        //온도
        public decimal Shop_Test_Exh_Temp_Before_Tc_C { get; set; }         //온도
        public decimal Shop_Test_Tc_Rpm { get; set; }                       //터보차저rpm
        public decimal Shop_Test_Sfoc_Measured_G_Kw_H { get; set; }         //sfoc
        public decimal Shop_Test_Sfoc_Iso_G_Kw_H { get; set; }              //sfoc

        public virtual Ship_Paticular Ship_Paticular { get; set; }

    }
}
