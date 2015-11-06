using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShipCare.Models
{
    [Table("Sailing_Data")]    //운항데이터
    public class Sailing_Data
    {
        public string Ship_Paticular_Callsign { get; set; }

        public Int64 Sailing_Data_Id { get; set; }
        public DateTime Sailing_DataDate { get; set; }
        public double Sailing_Data_Lat { get; set; }                        //배위치 위도
        public double Sailing_Data_Lon { get; set; }                        //배위치 경도
        public decimal Sailing_Data_Ground_Speed { get; set; }              //배 속도
        public decimal Sailing_Data_Longitudinal_Ground_Speed { get; set; } //배 속도
        public decimal Sailing_Data_Tranverse_Ground_Speed { get; set; }    //배 속도
        public decimal Sailing_Data_Longitudinal_Water_Speed { get; set; }  //배 속도
        public decimal Sailing_Data_Tranverse_Water_Speed { get; set; }     //배 속도
        public decimal Sailing_Data_RelWindDir { get; set; }                //날씨 방향
        public decimal Sailing_Data_RelWindSpd { get; set; }                //날씨 속도
        public decimal Sailing_Data_PowerDel { get; set; }                  //배 마력
        public decimal Sailing_Data_SpeedVg { get; set; }                   //배 속도
        public decimal Sailing_Data_HeadingGps { get; set; }                //배 방향
        public decimal Sailing_Data_HeadingGyro { get; set; }               //배 방향
        public decimal Sailing_Data_WaterDepth { get; set; }                //수심
        public decimal Sailing_Data_RudderAngle { get; set; }               //배방향
        public decimal Sailing_Data_DraughtFore { get; set; }               //배 길이
        public decimal Sailing_Data_DraughtAft { get; set; }                //배 길이
        public decimal Sailing_Data_ShaftRev { get; set; }                  //배 회전계
        public decimal Sailing_Data_SeawaterTemp { get; set; }              //수온
        public decimal Sailing_Data_FlowMeterMeHfo { get; set; }            //유량 초당
        public decimal Sailing_Data_ValidData { get; set; }     //bit타입
        public decimal Sailing_Data_Distance { get; set; }                  //배 거리
        public decimal Sailing_Data_Depth_Map { get; set; }                 //수심
        public decimal Sailing_Data_Wind_Speed { get; set; }                //날씨 속도
        public decimal Sailing_Data_Wind_Direction { get; set; }            //날씨 방향
        public decimal Sailing_Data_DirectionOfWindWave { get; set; }       //날씨 방향
        public decimal Sailing_Data_SwellWaveDirection { get; set; }        //날씨 방향
        public decimal Sailing_Data_MeanPeriodWindWave { get; set; }        //날씨 주기
        public decimal Sailing_Data_MeanPeriodSwellWave { get; set; }        //날씨 주기
        public decimal Sailing_Data_MeanCombinedPeriodWindAndSwell { get; set; }    //날씨 주기

        public decimal Sailing_Data_SignificantHeightWindWave { get; set; }        //파도 높이
        public decimal Sailing_Data_SignificantHeightSwellWave { get; set; }       //파도 높이
        public decimal Sailing_Data_SignificantHeightWindAndSwellWave { get; set; }//파도 높이
        public decimal Sailing_Data_PrimaryWaveDirection { get; set; }          //날씨 방향
        public decimal Sailing_Data_PrimaryWaveMeanPeriod { get; set; }         //날씨 주기
        public decimal Sailing_Data_Ico_Cover { get; set; }                     //N/A
        public decimal Sailing_Data_Density { get; set; }                       //밀도 
        public decimal Sailing_Data_Sea_Surface_Salinity { get; set; }          //염도
        public decimal Sailing_Data_Sea_Surface_Temperature { get; set; }       //수온
        public decimal Sailing_Data_Current_Direction { get; set; }             //날씨 방향
        public decimal Sailing_Data_Current_Speed { get; set; }                 //날씨 속도

        public decimal M_E_F_O_InletPress { get; set; }                 //압력
        public decimal M_E_F_O_InletTemp { get; set; }                  //온도
        public decimal M_E_F_O_FlowInlet { get; set; }                  //유량초당
        public decimal M_E_F_O_FlowReturn { get; set; }                 //유량초당
        public decimal G_E_F_O_FlowInlet { get; set; }                  //유량초당
        public decimal G_E_F_O_FlowReturn { get; set; }                 //유량초당
        public decimal BOILER_F_O_FlowInlet { get; set; }               //유량초당
        public decimal BOILER_F_O_FlowReturn { get; set; }              //유량초당
        public decimal MAINS_W_PumpOutletTemp { get; set; }             //온도
        public decimal M_E_NO_1CYL_P_C_O_OutletTemp { get; set; }       //온도
        public decimal M_E_NO_2CYL_P_C_O_OutletTemp { get; set; }       //온도
        public decimal M_E_NO_3CYL_P_C_O_OutletTemp { get; set; }       //온도
        public decimal M_E_NO_4CYL_P_C_O_OutletTemp { get; set; }       //온도
        public decimal M_E_NO_5CYL_P_C_O_OutletTemp { get; set; }       //온도
        public decimal M_E_NO_6CYL_P_C_O_OutletTemp { get; set; }       //온도
        public decimal M_E_NO_7CYL_P_C_O_OutletTemp { get; set; }       //온도
        public decimal M_E_NO_8CYL_P_C_O_OutletTemp { get; set; }       //온도
        public decimal M_E_NO_9CYL_P_C_O_OutletTemp { get; set; }       //온도
        public decimal M_E_NO_10CYL_P_C_O_OutletTemp { get; set; }      //온도
        public decimal M_E_NO_11CYL_P_C_O_OutletTemp { get; set; }      //온도
        public decimal M_E_NO_12CYL_P_C_O_OutletTemp { get; set; }      //온도
        public decimal M_E_NO_13YL_P_C_O_OutletTemp { get; set; }       //온도
        public decimal M_E_NO_14CYL_P_C_O_OutletTemp { get; set; }      //온도
        public decimal M_E_NO_15CYL_P_C_O_OutletTemp { get; set; }      //온도
        public decimal M_E_NO_16CYL_P_C_O_OutletTemp { get; set; }      //온도
        public decimal M_E_ThrustpadTemp { get; set; }                  //온도
        public decimal M_E_T_CL_O_OutletTemp { get; set; }              //온도
        public decimal M_E_J_C_WinletPress { get; set; }                //압력
        public decimal M_E_No_1CYL_C_F_W_OutletTemp { get; set; }       //온도
        public decimal M_E_No_2CYL_C_F_W_OutletTemp { get; set; }       //온도
        public decimal M_E_No_3CYL_C_F_W_OutletTemp { get; set; }       //온도
        public decimal M_E_No_4CYL_C_F_W_OutletTemp { get; set; }       //온도
        public decimal M_E_No_5CYL_C_F_W_OutletTemp { get; set; }       //온도
        public decimal M_E_No_6CYL_C_F_W_OutletTemp { get; set; }       //온도
        public decimal M_E_No_7CYL_C_F_W_OutletTemp { get; set; }       //온도
        public decimal M_E_No_8CYL_C_F_W_OutletTemp { get; set; }       //온도
        public decimal M_E_No_9CYL_C_F_W_OutletTemp { get; set; }       //온도
        public decimal M_E_No_10CYL_C_F_W_OutletTemp { get; set; }      //온도
        public decimal M_E_No_11CYL_C_F_W_OutletTemp { get; set; }      //온도
        public decimal M_E_No_12CYL_C_F_W_OutletTemp { get; set; }      //온도
        public decimal M_E_No_13CYL_C_F_W_OutletTemp { get; set; }      //온도
        public decimal M_E_No_14CYL_C_F_W_OutletTemp { get; set; }      //온도
        public decimal M_E_No_15CYL_C_F_W_OutletTemp { get; set; }      //온도
        public decimal M_E_No_16CYL_C_F_W_OutletTemp { get; set; }      //온도
        public decimal M_E_RPM { get; set; }                            //배 회전계
        public decimal M_E_T_C_1Rpm { get; set; }                       //터보차져 RPM
        public decimal M_E_T_C_2Rpm { get; set; }                       //터보차져 RPM
        public decimal M_E_T_C_3Rpm { get; set; }                       //터보차져 RPM
        public decimal M_E_T_C_Exh_GasInletTemp { get; set; }           //온도
        public decimal M_E_T_C_Exh_GasOutletTemp { get; set; }          //온도
        public decimal M_E_SCAV_AirTemp { get; set; }                   //온도
        public decimal M_E_SCAV_AirPress { get; set; }                  //압력
        public decimal M_E_No_1CYL_EXH_GasOutletTemp { get; set; }      //온도
        public decimal M_E_No_2CYL_EXH_GasOutletTemp { get; set; }      //온도
        public decimal M_E_No_3CYL_EXH_GasOutletTemp { get; set; }      //온도
        public decimal M_E_No_4CYL_EXH_GasOutletTemp { get; set; }      //온도
        public decimal M_E_No_5CYL_EXH_GasOutletTemp { get; set; }      //온도
        public decimal M_E_No_6CYL_EXH_GasOutletTemp { get; set; }      //온도
        public decimal M_E_No_7CYL_EXH_GasOutletTemp { get; set; }      //온도
        public decimal M_E_No_8CYL_EXH_GasOutletTemp { get; set; }      //온도
        public decimal M_E_No_9CYL_EXH_GasOutletTemp { get; set; }      //온도
        public decimal M_E_No_10CYL_EXH_GasOutletTemp { get; set; }     //온도
        public decimal M_E_No_11CYL_EXH_GasOutletTemp { get; set; }     //온도
        public decimal M_E_No_12CYL_EXH_GasOutletTemp { get; set; }     //온도
        public decimal M_E_No_13CYL_EXH_GasOutletTemp { get; set; }     //온도
        public decimal M_E_No_14CYL_EXH_GasOutletTemp { get; set; }     //온도
        public decimal M_E_No_15CYL_EXH_GasOutletTemp { get; set; }     //온도
        public decimal M_E_No_16CYL_EXH_GasOutletTemp { get; set; }     //온도
        public decimal NO_1G_E_Rpm { get; set; }                        //발전기 RPM
        public decimal NO_2G_E_Rpm { get; set; }                        //발전기 RPM
        public decimal NO_3G_E_Rpm { get; set; }                        //발전기 RPM
        public decimal NO_1G_ET_C_Rpm { get; set; }                     //터보차저rpm
        public decimal NO_2G_ET_C_Rpm { get; set; }                     //터보차저rpm
        public decimal NO_3G_ET_C_Rpm { get; set; }                     //터보차저rpm
        public decimal NO_1G_E_Power { get; set; }                      //발전기kw
        public decimal NO_2G_E_Power { get; set; }                      //발전기kw
        public decimal NO_3G_E_Power { get; set; }                      //발전기kw


        public virtual Ship_Paticular Ship_Paticular { get; set; }
    }
}
