using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShipCare.Models
{
    public class DbCon : DbContext
    {
        public DbSet<Client> Clients { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Ship_Paticular> Ship_Paticulars { get; set; }
        public DbSet<Shop_Test> Shop_Tests { get; set; }
        public DbSet<Sea_Trial> Sea_Trials { get; set; }
        public DbSet<Sailing_Data> Sailing_Datas { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new ClientConfiguration());
            modelBuilder.Configurations.Add(new UserConfiguration());
            modelBuilder.Configurations.Add(new Ship_PaticularConfiguration());
            modelBuilder.Configurations.Add(new Shop_TestConfiguration());
            modelBuilder.Configurations.Add(new Sea_TrialConfiguration());
            modelBuilder.Configurations.Add(new Sailing_DataConfiguration());
        }

        public class ClientConfiguration : EntityTypeConfiguration<Client>
        {
            public ClientConfiguration()
            {
                HasKey(d => d.Client_Id).Property(d => d.Client_Id).IsRequired();
                Property(d => d.Client_Name).HasMaxLength(50);
                Property(d => d.Client_Ceo).HasMaxLength(50);
                Property(d => d.Client_Phone).HasMaxLength(30);
                Property(d => d.Client_Fax).HasMaxLength(30);
                Property(d => d.Client_Address).HasMaxLength(255);
                Property(d => d.Client_PostNumber).HasMaxLength(20);
                Property(d => d.Client_Email).HasMaxLength(40);
                Property(d => d.Client_HomePage).HasMaxLength(255);
            }
        }

        public class UserConfiguration : EntityTypeConfiguration<User>
        {
            public UserConfiguration()
            {
                HasKey(d => d.User_Email).Property(d => d.User_Email).HasMaxLength(40);
                Property(d => d.User_Name).HasMaxLength(50);
                Property(d => d.User_Phone).HasMaxLength(30);
                Property(d => d.User_CellPhone).HasMaxLength(30);
                Property(d => d.User_Position).HasMaxLength(40);
                Property(d => d.User_Passworld).HasMaxLength(40);
                Property(d => d.User_Photo).HasColumnType("image");
            }
        }

        public class Ship_PaticularConfiguration : EntityTypeConfiguration<Ship_Paticular>
        {
            public Ship_PaticularConfiguration()
            {
                HasKey(d => d.Ship_Paticular_Callsign).Property(d => d.Ship_Paticular_Callsign).HasMaxLength(50);

                Property(d => d.Ship_Paticular_Name).HasMaxLength(40);
                Property(d => d.Ship_Paticular_Admin).HasMaxLength(50);

                Property(d => d.Ship_Paticular_Yard).HasMaxLength(40);
                Property(d => d.Ship_Paticular_Phone).HasMaxLength(30);
                Property(d => d.Ship_Paticular_Fax).HasMaxLength(30);
                Property(d => d.Ship_Paticular_Email).HasMaxLength(40);

                Property(d => d.Ship_Paticular_Class).HasMaxLength(40);
                Property(d => d.Ship_Paticular_ImoNo).HasMaxLength(20);
                Property(d => d.Ship_Paticular_Country).HasMaxLength(40);

                Property(d => d.Ship_Paticular_LOA).HasPrecision(5, 2);
                Property(d => d.Ship_Paticular_LBP).HasPrecision(5, 2);
                Property(d => d.Ship_Paticular_BREADTH).HasPrecision(5, 2);
                Property(d => d.Ship_Paticular_Depth_To_Upper_Deck).HasPrecision(5, 2);
                Property(d => d.Ship_Paticular_Dead_Weight).HasPrecision(8, 2);
                Property(d => d.Ship_Paticular_Displacement).HasPrecision(8, 2);
                Property(d => d.Ship_Paticular_Draft_Ballast).HasPrecision(5, 2);
                Property(d => d.Ship_Paticular_Draft_Laden).HasPrecision(5, 2);
                Property(d => d.Ship_Paticular_Draft_Scan).HasPrecision(5, 2);

                Property(d => d.Ship_Paticular_Me_Type).HasMaxLength(40);

                Property(d => d.Ship_Paticular_Me_Power_Mcr).HasPrecision(8, 2);
                Property(d => d.Ship_Paticular_Me_Rpm_Mcr).HasPrecision(8, 2);
                Property(d => d.Ship_Paticular_Propeller_Pitch).HasPrecision(7, 2);
            }
        }


        public class Shop_TestConfiguration : EntityTypeConfiguration<Shop_Test>
        {
            public Shop_TestConfiguration()
            {
                HasKey(d => d.Shop_Test_Id).Property(d => d.Shop_Test_Id).IsRequired();//pk identity
                Property(d => d.Shop_Test_Power_Kw).HasPrecision(8, 2).IsOptional(); //HasPrecision(8, 2) : decimal8,2  IsOptional() : null허용
                Property(d => d.Shop_Test_Rpm).HasPrecision(5, 2).IsOptional();
                Property(d => d.Shop_Test_Mep_Bar).HasPrecision(6, 2).IsOptional();
                Property(d => d.Shop_Test_Fuel_Index_Mm).HasPrecision(5, 2).IsOptional();
                Property(d => d.Shop_Test_Vit_Index).HasPrecision(5, 2).IsOptional();
                Property(d => d.Shop_Test_Ambient_Pressure_Mbar).HasPrecision(6, 2).IsOptional();
                Property(d => d.Shop_Test_Ambient_Temp_C).HasPrecision(5, 2).IsOptional();
                Property(d => d.Shop_Test_Scav_Air_Temp_Before_Blower).HasPrecision(5, 2).IsOptional();
                Property(d => d.Shop_Test_Receiver_Temp).HasPrecision(5, 2).IsOptional();
                Property(d => d.Shop_Test_A_C_Cooling_Water_Temp).HasPrecision(5, 2).IsOptional();
                Property(d => d.Shop_Test_Pmax_Bar).HasPrecision(6, 2).IsOptional();
                Property(d => d.Shop_Test_Pcomp_Bar).HasPrecision(6, 2).IsOptional();
                Property(d => d.Shop_Test_Psacv_Kg_Cm2).HasPrecision(6, 2).IsOptional();
                Property(d => d.Shop_Test_Pexh_Kg_Cm2).HasPrecision(6, 2).IsOptional();
                Property(d => d.Shop_Test_Exh_Temp_Cyl_Outlet_C).HasPrecision(5, 2).IsOptional();
                Property(d => d.Shop_Test_Exh_Temp_Before_Tc_C).HasPrecision(5, 2).IsOptional();
                Property(d => d.Shop_Test_Tc_Rpm).HasPrecision(7, 0).IsOptional();
                Property(d => d.Shop_Test_Sfoc_Measured_G_Kw_H).HasPrecision(6, 2).IsOptional();
                Property(d => d.Shop_Test_Sfoc_Iso_G_Kw_H).HasPrecision(6, 2).IsOptional();
            }
        }

        public class Sea_TrialConfiguration : EntityTypeConfiguration<Sea_Trial>
        {
            public Sea_TrialConfiguration()
            {
                HasKey(d => d.Sea_Trial_Id).Property(d => d.Sea_Trial_Id).IsRequired();
                //Property(d => d.Sea_Trial_Speed_Ballast2).HasPrecision(5, 2).IsOptional();
                //Property(d => d.Sea_Trial_Power_Bal).HasPrecision(8, 2).IsOptional();
                //Property(d => d.Sea_Trial_Speed_Laden1).HasPrecision(5, 2).IsOptional();
                //Property(d => d.Sea_Trial_Power_Scantling).HasPrecision(8, 2).IsOptional();

            }
        }
        public class Sailing_DataConfiguration : EntityTypeConfiguration<Sailing_Data>
        {
            public Sailing_DataConfiguration()
            {
                HasKey(d => d.Sailing_Data_Id).Property(d => d.Sailing_Data_Id).IsRequired();

                Property(d => d.Sailing_Data_Ground_Speed).HasPrecision(5, 2).IsOptional();              //배 속도
                Property(d => d.Sailing_Data_Longitudinal_Ground_Speed).HasPrecision(5, 2).IsOptional(); //배 속도
                Property(d => d.Sailing_Data_Tranverse_Ground_Speed).HasPrecision(5, 2).IsOptional();    //배 속도
                Property(d => d.Sailing_Data_Longitudinal_Water_Speed).HasPrecision(5, 2).IsOptional();  //배 속도
                Property(d => d.Sailing_Data_Tranverse_Water_Speed).HasPrecision(5, 2).IsOptional();     //배 속도
                Property(d => d.Sailing_Data_RelWindDir).HasPrecision(5, 2).IsOptional();                //날씨 방향
                Property(d => d.Sailing_Data_RelWindSpd).HasPrecision(5, 2).IsOptional();                //날씨 속도
                Property(d => d.Sailing_Data_PowerDel).HasPrecision(8, 2).IsOptional();                  //배 마력
                Property(d => d.Sailing_Data_SpeedVg).HasPrecision(5, 2).IsOptional();                   //배 속도
                Property(d => d.Sailing_Data_HeadingGps).HasPrecision(5, 2).IsOptional();                //배 방향
                Property(d => d.Sailing_Data_HeadingGyro).HasPrecision(5, 2).IsOptional();               //배 방향
                Property(d => d.Sailing_Data_WaterDepth).HasPrecision(7, 2).IsOptional();                //수심
                Property(d => d.Sailing_Data_RudderAngle).HasPrecision(5, 2).IsOptional();               //배방향
                Property(d => d.Sailing_Data_DraughtFore).HasPrecision(5, 2).IsOptional();               //배 길이
                Property(d => d.Sailing_Data_DraughtAft).HasPrecision(5, 2).IsOptional();                //배 길이
                Property(d => d.Sailing_Data_ShaftRev).HasPrecision(5, 2).IsOptional();                  //배 회전계
                Property(d => d.Sailing_Data_SeawaterTemp).HasPrecision(4, 2).IsOptional();              //수온
                Property(d => d.Sailing_Data_FlowMeterMeHfo).HasPrecision(5, 2).IsOptional();            //유량 초당
                Property(d => d.Sailing_Data_ValidData).HasPrecision(5, 2).IsOptional();     //bit타입
                Property(d => d.Sailing_Data_Distance).HasPrecision(5, 2).IsOptional();                  //배 거리
                Property(d => d.Sailing_Data_Depth_Map).HasPrecision(7, 2).IsOptional();                 //수심
                Property(d => d.Sailing_Data_Wind_Speed).HasPrecision(5, 2).IsOptional();                //날씨 속도
                Property(d => d.Sailing_Data_Wind_Direction).HasPrecision(5, 2).IsOptional();            //날씨 방향
                Property(d => d.Sailing_Data_DirectionOfWindWave).HasPrecision(5, 2).IsOptional();       //날씨 방향
                Property(d => d.Sailing_Data_SwellWaveDirection).HasPrecision(5, 2).IsOptional();        //날씨 방향
                Property(d => d.Sailing_Data_MeanPeriodWindWave).HasPrecision(5, 2).IsOptional();        //날씨 주기
                Property(d => d.Sailing_Data_MeanPeriodSwellWave).HasPrecision(5, 2).IsOptional();        //날씨 주기
                Property(d => d.Sailing_Data_MeanCombinedPeriodWindAndSwell).HasPrecision(5, 2).IsOptional();    //날씨 주기

                Property(d => d.Sailing_Data_SignificantHeightWindWave).HasPrecision(4, 2).IsOptional();        //파도 높이
                Property(d => d.Sailing_Data_SignificantHeightSwellWave).HasPrecision(4, 2).IsOptional();       //파도 높이
                Property(d => d.Sailing_Data_SignificantHeightWindAndSwellWave).HasPrecision(4, 2).IsOptional();//파도 높이
                Property(d => d.Sailing_Data_PrimaryWaveDirection).HasPrecision(5, 2).IsOptional();          //날씨 방향
                Property(d => d.Sailing_Data_PrimaryWaveMeanPeriod).HasPrecision(5, 2).IsOptional();         //날씨 주기
                Property(d => d.Sailing_Data_Ico_Cover).HasPrecision(5, 2).IsOptional();                     //N/A
                Property(d => d.Sailing_Data_Density).HasPrecision(4, 2).IsOptional();                       //밀도 
                Property(d => d.Sailing_Data_Sea_Surface_Salinity).HasPrecision(4, 2).IsOptional();          //염도
                Property(d => d.Sailing_Data_Sea_Surface_Temperature).HasPrecision(4, 2).IsOptional();       //수온
                Property(d => d.Sailing_Data_Current_Direction).HasPrecision(5, 2).IsOptional();             //날씨 방향
                Property(d => d.Sailing_Data_Current_Speed).HasPrecision(5, 2).IsOptional();                 //날씨 속도

                Property(d => d.M_E_F_O_InletPress).HasPrecision(6, 2).IsOptional();                 //압력
                Property(d => d.M_E_F_O_InletTemp).HasPrecision(5, 2).IsOptional();                  //온도
                Property(d => d.M_E_F_O_FlowInlet).HasPrecision(5, 2).IsOptional();                  //유량초당
                Property(d => d.M_E_F_O_FlowReturn).HasPrecision(5, 2).IsOptional();                 //유량초당
                Property(d => d.G_E_F_O_FlowInlet).HasPrecision(5, 2).IsOptional();                  //유량초당
                Property(d => d.G_E_F_O_FlowReturn).HasPrecision(5, 2).IsOptional();                 //유량초당
                Property(d => d.BOILER_F_O_FlowInlet).HasPrecision(5, 2).IsOptional();               //유량초당
                Property(d => d.BOILER_F_O_FlowReturn).HasPrecision(5, 2).IsOptional();              //유량초당
                Property(d => d.MAINS_W_PumpOutletTemp).HasPrecision(5, 2).IsOptional();             //온도
                Property(d => d.M_E_NO_1CYL_P_C_O_OutletTemp).HasPrecision(5, 2).IsOptional();       //온도
                Property(d => d.M_E_NO_2CYL_P_C_O_OutletTemp).HasPrecision(5, 2).IsOptional();       //온도
                Property(d => d.M_E_NO_3CYL_P_C_O_OutletTemp).HasPrecision(5, 2).IsOptional();       //온도
                Property(d => d.M_E_NO_4CYL_P_C_O_OutletTemp).HasPrecision(5, 2).IsOptional();       //온도
                Property(d => d.M_E_NO_5CYL_P_C_O_OutletTemp).HasPrecision(5, 2).IsOptional();       //온도
                Property(d => d.M_E_NO_6CYL_P_C_O_OutletTemp).HasPrecision(5, 2).IsOptional();       //온도
                Property(d => d.M_E_NO_7CYL_P_C_O_OutletTemp).HasPrecision(5, 2).IsOptional();       //온도
                Property(d => d.M_E_NO_8CYL_P_C_O_OutletTemp).HasPrecision(5, 2).IsOptional();       //온도
                Property(d => d.M_E_NO_9CYL_P_C_O_OutletTemp).HasPrecision(5, 2).IsOptional();       //온도
                Property(d => d.M_E_NO_10CYL_P_C_O_OutletTemp).HasPrecision(5, 2).IsOptional();      //온도
                Property(d => d.M_E_NO_11CYL_P_C_O_OutletTemp).HasPrecision(5, 2).IsOptional();      //온도
                Property(d => d.M_E_NO_12CYL_P_C_O_OutletTemp).HasPrecision(5, 2).IsOptional();      //온도
                Property(d => d.M_E_NO_13YL_P_C_O_OutletTemp).HasPrecision(5, 2).IsOptional();       //온도
                Property(d => d.M_E_NO_14CYL_P_C_O_OutletTemp).HasPrecision(5, 2).IsOptional();      //온도
                Property(d => d.M_E_NO_15CYL_P_C_O_OutletTemp).HasPrecision(5, 2).IsOptional();      //온도
                Property(d => d.M_E_NO_16CYL_P_C_O_OutletTemp).HasPrecision(5, 2).IsOptional();      //온도
                Property(d => d.M_E_ThrustpadTemp).HasPrecision(5, 2).IsOptional();                  //온도
                Property(d => d.M_E_T_CL_O_OutletTemp).HasPrecision(5, 2).IsOptional();              //온도
                Property(d => d.M_E_J_C_WinletPress).HasPrecision(5, 2).IsOptional();                //압력
                Property(d => d.M_E_No_1CYL_C_F_W_OutletTemp).HasPrecision(5, 2).IsOptional();       //온도
                Property(d => d.M_E_No_2CYL_C_F_W_OutletTemp).HasPrecision(5, 2).IsOptional();       //온도
                Property(d => d.M_E_No_3CYL_C_F_W_OutletTemp).HasPrecision(5, 2).IsOptional();       //온도
                Property(d => d.M_E_No_4CYL_C_F_W_OutletTemp).HasPrecision(5, 2).IsOptional();       //온도
                Property(d => d.M_E_No_5CYL_C_F_W_OutletTemp).HasPrecision(5, 2).IsOptional();       //온도
                Property(d => d.M_E_No_6CYL_C_F_W_OutletTemp).HasPrecision(5, 2).IsOptional();       //온도
                Property(d => d.M_E_No_7CYL_C_F_W_OutletTemp).HasPrecision(5, 2).IsOptional();       //온도
                Property(d => d.M_E_No_8CYL_C_F_W_OutletTemp).HasPrecision(5, 2).IsOptional();       //온도
                Property(d => d.M_E_No_9CYL_C_F_W_OutletTemp).HasPrecision(5, 2).IsOptional();       //온도
                Property(d => d.M_E_No_10CYL_C_F_W_OutletTemp).HasPrecision(5, 2).IsOptional();      //온도
                Property(d => d.M_E_No_11CYL_C_F_W_OutletTemp).HasPrecision(5, 2).IsOptional();      //온도
                Property(d => d.M_E_No_12CYL_C_F_W_OutletTemp).HasPrecision(5, 2).IsOptional();      //온도
                Property(d => d.M_E_No_13CYL_C_F_W_OutletTemp).HasPrecision(5, 2).IsOptional();      //온도
                Property(d => d.M_E_No_14CYL_C_F_W_OutletTemp).HasPrecision(5, 2).IsOptional();      //온도
                Property(d => d.M_E_No_15CYL_C_F_W_OutletTemp).HasPrecision(5, 2).IsOptional();      //온도
                Property(d => d.M_E_No_16CYL_C_F_W_OutletTemp).HasPrecision(5, 2).IsOptional();      //온도
                Property(d => d.M_E_RPM).HasPrecision(5, 2).IsOptional();                            //배 회전계
                Property(d => d.M_E_T_C_1Rpm).HasPrecision(7, 0).IsOptional();                       //터보차져 RPM
                Property(d => d.M_E_T_C_2Rpm).HasPrecision(7, 0).IsOptional();                       //터보차져 RPM
                Property(d => d.M_E_T_C_3Rpm).HasPrecision(7, 0).IsOptional();                       //터보차져 RPM
                Property(d => d.M_E_T_C_Exh_GasInletTemp).HasPrecision(5, 2).IsOptional();           //온도
                Property(d => d.M_E_T_C_Exh_GasOutletTemp).HasPrecision(5, 2).IsOptional();          //온도
                Property(d => d.M_E_SCAV_AirTemp).HasPrecision(5, 2).IsOptional();                   //온도
                Property(d => d.M_E_SCAV_AirPress).HasPrecision(5, 2).IsOptional();                  //압력
                Property(d => d.M_E_No_1CYL_EXH_GasOutletTemp).HasPrecision(5, 2).IsOptional();      //온도
                Property(d => d.M_E_No_2CYL_EXH_GasOutletTemp).HasPrecision(5, 2).IsOptional();      //온도
                Property(d => d.M_E_No_3CYL_EXH_GasOutletTemp).HasPrecision(5, 2).IsOptional();      //온도
                Property(d => d.M_E_No_4CYL_EXH_GasOutletTemp).HasPrecision(5, 2).IsOptional();      //온도
                Property(d => d.M_E_No_5CYL_EXH_GasOutletTemp).HasPrecision(5, 2).IsOptional();      //온도
                Property(d => d.M_E_No_6CYL_EXH_GasOutletTemp).HasPrecision(5, 2).IsOptional();      //온도
                Property(d => d.M_E_No_7CYL_EXH_GasOutletTemp).HasPrecision(5, 2).IsOptional();      //온도
                Property(d => d.M_E_No_8CYL_EXH_GasOutletTemp).HasPrecision(5, 2).IsOptional();      //온도
                Property(d => d.M_E_No_9CYL_EXH_GasOutletTemp).HasPrecision(5, 2).IsOptional();      //온도
                Property(d => d.M_E_No_10CYL_EXH_GasOutletTemp).HasPrecision(5, 2).IsOptional();     //온도
                Property(d => d.M_E_No_11CYL_EXH_GasOutletTemp).HasPrecision(5, 2).IsOptional();     //온도
                Property(d => d.M_E_No_12CYL_EXH_GasOutletTemp).HasPrecision(5, 2).IsOptional();     //온도
                Property(d => d.M_E_No_13CYL_EXH_GasOutletTemp).HasPrecision(5, 2).IsOptional();     //온도
                Property(d => d.M_E_No_14CYL_EXH_GasOutletTemp).HasPrecision(5, 2).IsOptional();     //온도
                Property(d => d.M_E_No_15CYL_EXH_GasOutletTemp).HasPrecision(5, 2).IsOptional();     //온도
                Property(d => d.M_E_No_16CYL_EXH_GasOutletTemp).HasPrecision(5, 2).IsOptional();     //온도
                Property(d => d.NO_1G_E_Rpm).HasPrecision(6, 2).IsOptional();                        //발전기 RPM
                Property(d => d.NO_2G_E_Rpm).HasPrecision(6, 2).IsOptional();                        //발전기 RPM
                Property(d => d.NO_3G_E_Rpm).HasPrecision(6, 2).IsOptional();                        //발전기 RPM
                Property(d => d.NO_1G_ET_C_Rpm).HasPrecision(7, 0).IsOptional();                     //터보차저rpm
                Property(d => d.NO_2G_ET_C_Rpm).HasPrecision(7, 0).IsOptional();                     //터보차저rpm
                Property(d => d.NO_3G_ET_C_Rpm).HasPrecision(7, 0).IsOptional();                     //터보차저rpm
                Property(d => d.NO_1G_E_Power).HasPrecision(6, 2).IsOptional();                      //발전기kw
                Property(d => d.NO_2G_E_Power).HasPrecision(6, 2).IsOptional();                      //발전기kw
                Property(d => d.NO_3G_E_Power).HasPrecision(6, 2).IsOptional();                      //발전기kw
            }
        }


    }

}
