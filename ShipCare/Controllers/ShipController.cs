using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ShipCare.Models;
using System.Data.Entity;

namespace ShipCare.Controllers
{
    public class ShipController : ApiController
    {
        private DbCon db = new DbCon();

        //회사, 배타입으로 회사에 등록된 배정보 추출
        //[Route("api/{Client}/{shiptype}/get")]
        [HttpGet]
        public IQueryable GetShipList(string Client, int shipType)
        {
            IQueryable ShipList = null;

            //shipTYpe == 0 이면 배전부다 보여줌
            if (shipType == 0)
            {
                ShipList = from LinqClient in db.Clients    //회사테이블 
                           join LinqShipParticular in db.Ship_Paticulars on LinqClient.Client_Id equals LinqShipParticular.Client_Id  //선박명세 join 회사테이블
                           where LinqClient.Client_Name == Client && LinqShipParticular.Ship_Paticular_Type != shipType   //선박명세가 0이면 전부 출력
                           select new
                           {
                               Callsign = LinqShipParticular.Ship_Paticular_Callsign,
                               Name = LinqShipParticular.Ship_Paticular_Name,
                               Admin = LinqShipParticular.Ship_Paticular_Admin,
                               Type = LinqShipParticular.Ship_Paticular_Type,
                               Yard = LinqShipParticular.Ship_Paticular_Yard,
                               Phone = LinqShipParticular.Ship_Paticular_Phone,
                               Fax = LinqShipParticular.Ship_Paticular_Fax,
                               Email = LinqShipParticular.Ship_Paticular_Email,
                               GetDate = LinqShipParticular.Ship_Paticular_GetDate,
                               Class = LinqShipParticular.Ship_Paticular_Class,
                               ImoNo = LinqShipParticular.Ship_Paticular_ImoNo,
                               Country = LinqShipParticular.Ship_Paticular_Country,
                               LOA = LinqShipParticular.Ship_Paticular_LOA,
                               LBP = LinqShipParticular.Ship_Paticular_LBP,
                               BREADTH = LinqShipParticular.Ship_Paticular_BREADTH,
                               Depth_To_UpperDeck = LinqShipParticular.Ship_Paticular_Depth_To_Upper_Deck,
                               Dead_Weight = LinqShipParticular.Ship_Paticular_Dead_Weight,
                               Displacement = LinqShipParticular.Ship_Paticular_Displacement,
                               Draft_Ballast = LinqShipParticular.Ship_Paticular_Draft_Ballast,
                               Draft_Laden = LinqShipParticular.Ship_Paticular_Draft_Laden,
                               Draft_Scan = LinqShipParticular.Ship_Paticular_Draft_Scan,
                               Me_Type = LinqShipParticular.Ship_Paticular_Me_Type,
                               Me_Power_Mcr = LinqShipParticular.Ship_Paticular_Me_Power_Mcr,
                               Me_Rpm_Mcr = LinqShipParticular.Ship_Paticular_Me_Rpm_Mcr,
                               Propeller_Pitch = LinqShipParticular.Ship_Paticular_Propeller_Pitch

                           };
            }
            else
            {
                ShipList = from LinqClient in db.Clients
                           join LinqShipParticular in db.Ship_Paticulars on LinqClient.Client_Id equals LinqShipParticular.Client_Id
                           where LinqClient.Client_Name == Client && LinqShipParticular.Ship_Paticular_Type == shipType
                           select new
                           {
                               Callsign = LinqShipParticular.Ship_Paticular_Callsign,
                               Name = LinqShipParticular.Ship_Paticular_Name,
                               Admin = LinqShipParticular.Ship_Paticular_Admin,
                               Type = LinqShipParticular.Ship_Paticular_Type,
                               Yard = LinqShipParticular.Ship_Paticular_Yard,
                               Phone = LinqShipParticular.Ship_Paticular_Phone,
                               Fax = LinqShipParticular.Ship_Paticular_Fax,
                               Email = LinqShipParticular.Ship_Paticular_Email,
                               GetDate = LinqShipParticular.Ship_Paticular_GetDate,
                               Class = LinqShipParticular.Ship_Paticular_Class,
                               ImoNo = LinqShipParticular.Ship_Paticular_ImoNo,
                               Country = LinqShipParticular.Ship_Paticular_Country,
                               LOA = LinqShipParticular.Ship_Paticular_LOA,
                               LBP = LinqShipParticular.Ship_Paticular_LBP,
                               BREADTH = LinqShipParticular.Ship_Paticular_BREADTH,
                               Depth_To_UpperDeck = LinqShipParticular.Ship_Paticular_Depth_To_Upper_Deck,
                               Dead_Weight = LinqShipParticular.Ship_Paticular_Dead_Weight,
                               Displacement = LinqShipParticular.Ship_Paticular_Displacement,
                               Draft_Ballast = LinqShipParticular.Ship_Paticular_Draft_Ballast,
                               Draft_Laden = LinqShipParticular.Ship_Paticular_Draft_Laden,
                               Draft_Scan = LinqShipParticular.Ship_Paticular_Draft_Scan,
                               Me_Type = LinqShipParticular.Ship_Paticular_Me_Type,
                               Me_Power_Mcr = LinqShipParticular.Ship_Paticular_Me_Power_Mcr,
                               Me_Rpm_Mcr = LinqShipParticular.Ship_Paticular_Me_Rpm_Mcr,
                               Propeller_Pitch = LinqShipParticular.Ship_Paticular_Propeller_Pitch

                           };

            }
            return ShipList;
        }




        //shipcode로 해양테스트 하기전  결과출력
        //[Route("api/shoptestvalue/{shipcode}/get/")]
        [HttpGet]
        public IQueryable ShopTestValue(string shipcode)
        {
            var ShopTestValue = from LinqShipPaticular in db.Ship_Paticulars
                                join LinqShopTest in db.Shop_Tests on LinqShipPaticular.Ship_Paticular_Callsign equals LinqShopTest.Ship_Paticular_Callsign
                                where LinqShipPaticular.Ship_Paticular_Callsign == shipcode
                                select new
                                {
                                    Load_Gap = LinqShopTest.Shop_Test_Load_Gap,
                                    Power_Kw = LinqShopTest.Shop_Test_Power_Kw,
                                    Rpm = LinqShopTest.Shop_Test_Rpm,
                                    Mep_Bar = LinqShopTest.Shop_Test_Mep_Bar,
                                    Fuel_Index_Mm = LinqShopTest.Shop_Test_Fuel_Index_Mm,
                                    Vit_Index = LinqShopTest.Shop_Test_Vit_Index,
                                    Ambient_Pressure_Mbar = LinqShopTest.Shop_Test_Ambient_Pressure_Mbar,
                                    Ambient_Temp_C = LinqShopTest.Shop_Test_Ambient_Temp_C,
                                    Scav_Air_Temp_Before_Blower = LinqShopTest.Shop_Test_Scav_Air_Temp_Before_Blower,
                                    Receiver_Temp = LinqShopTest.Shop_Test_Receiver_Temp,
                                    A_C_Cooling_Water_Temp = LinqShopTest.Shop_Test_A_C_Cooling_Water_Temp,
                                    Pmax_Bar = LinqShopTest.Shop_Test_Pmax_Bar,
                                    Psacv_Kg_Cm2 = LinqShopTest.Shop_Test_Psacv_Kg_Cm2,
                                    Pexh_Kg_Cm2 = LinqShopTest.Shop_Test_Pexh_Kg_Cm2,
                                    Exh_Temp_Cyl_Outlet_C = LinqShopTest.Shop_Test_Exh_Temp_Cyl_Outlet_C,
                                    Exh_Temp_Before_Tc_C = LinqShopTest.Shop_Test_Exh_Temp_Before_Tc_C,
                                    Tc_Rpm = LinqShopTest.Shop_Test_Tc_Rpm,
                                    Sfoc_Measured_G_Kw_H = LinqShopTest.Shop_Test_Sfoc_Measured_G_Kw_H,
                                    Sfoc_Iso_G_Kw_H = LinqShopTest.Shop_Test_Sfoc_Iso_G_Kw_H
                                };
            return ShopTestValue;

        }


        //shipcode로 해양테스트 결과출력
        //[Route("api/seatrialvalue/{shipcode}/get")]
        [HttpGet]
        public IQueryable seatrialValue(string shipcode)
        {
            var seatrialValue = from LinqShipPaticular in db.Ship_Paticulars
                                join LinqSeaTrial in db.Sea_Trials on LinqShipPaticular.Ship_Paticular_Callsign equals LinqSeaTrial.Ship_Paticular_Callsign
                                where LinqShipPaticular.Ship_Paticular_Callsign == shipcode
                                select new
                                {

                                    Load_Gap = LinqSeaTrial.Sea_Trial_Load_Gap,
                                    Speed_Ballast2 = LinqSeaTrial.Sea_Trial_Speed_Ballast2,
                                    Power_Bal = LinqSeaTrial.Sea_Trial_Power_Bal,
                                    Speed_Laden1 = LinqSeaTrial.Sea_Trial_Speed_Laden1,
                                    Power_Scantling = LinqSeaTrial.Sea_Trial_Power_Scantling,
                                    Sea_Margine = LinqSeaTrial.Sea_Trial_Sea_Margine
                                };
            return seatrialValue;
        }



        //shipcode로 시작,끝나는날짜,통합 결과출력
        //[Route("api/{shipcode}/datasummary/get")]
        [HttpGet]
        public IQueryable DatabaseSummary(string shipcode)
        {
            var datasummary = db.Sailing_Datas

                            .Where(x => x.Ship_Paticular_Callsign == shipcode)
                            .GroupBy(t => t.Ship_Paticular_Callsign)
                            .Select(g => new {
                                Begin = g.Min(x => x.Sailing_DataDate),
                                EndData = g.Max(x => x.Sailing_DataDate),
                                Total = g.Count()
                            });
            return datasummary;
        }


        //shipcode로 해양테스트 결과출력
        //[Route("api/test1")]
        [HttpGet]
        public IQueryable seatrialValue111(string shipcode)
        {
            string a, b, c, d, e;
            var seatrialValue = from LinqShipPaticular in db.Ship_Paticulars
                                join LinqSeaTrial in db.Sea_Trials on LinqShipPaticular.Ship_Paticular_Callsign equals LinqSeaTrial.Ship_Paticular_Callsign
                                where LinqShipPaticular.Ship_Paticular_Callsign == shipcode
                                select new
                                {

                                    //a = a
                                };
            return seatrialValue;
        }



 


        [Route("api/insert")]
        [HttpGet]
        public void Insert()
        {

            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<DbCon>());

            using (var context = new DbCon())
            {
                var Clients = new List<Client> {
                    new Client {Client_Id=1 ,Client_Name="Lab021",Client_Ceo="Leesangbong1030", Client_Phone="010-111-1111",Client_Fax="051-111-1111",Client_Address="부산시 중구 조선빌딩 501호",Client_PostNumber="614-051",Client_Remark="remark1",Client_Email="Leesb@lab021.co.kr",Client_HomePage="http://lab021.co.kr" },
                    new Client {Client_Id=2 ,Client_Name="busan",Client_Ceo="Jungdoyoung1030", Client_Phone="010-222-2222",Client_Fax="051-222-2222",Client_Address="부산시 진구 양정동",Client_PostNumber="614-052",Client_Remark="remark2",Client_Email="wjd7364@lab021.co.kr",Client_HomePage="http://wjd7364.co.kr" },
                    new Client {Client_Id=3 ,Client_Name="unsan",Client_Ceo="haunsan1030", Client_Phone="010-333-3333",Client_Fax="051-333-3333",Client_Address="부산시 서구 팔당동",Client_PostNumber="614-053",Client_Remark="remark3",Client_Email="unsan@lab021.co.kr",Client_HomePage="http://Unsan.co.kr" },
                };
                //Clients.ForEach(s => context.Clients.Add(s));
                //context.SaveChanges();



            }
        }
    }
}
