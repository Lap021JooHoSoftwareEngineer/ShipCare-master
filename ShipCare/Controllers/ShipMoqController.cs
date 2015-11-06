using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ShipCare.Models;

namespace ShipCare.Controllers
{
    public class ShipMoqController : ApiController
    {

        public Moq db = new Moq();


        //회사, 배타입으로 회사에 등록된 배정보 추출
        [Route("api/{Client}/{shiptype}")]
        [HttpGet]
        public IEnumerable<dynamic> GetShipList(string Client, int shipType)
        {
            IEnumerable<dynamic> ShipList = null;

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
        [Route("api/shoptestvalue/{shipcode}")]
        [HttpGet]
        public IEnumerable<dynamic> ShopTestValue(string shipcode)
        {
            var ShopTestValue = from LinqShopTest in db.Shop_Tests
                                where LinqShopTest.Ship_Paticular_Callsign == shipcode
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
        [Route("api/seatrialvalue/{shipcode}")]
        [HttpGet]
        public IEnumerable<dynamic> seatrialValue(string shipcode)
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
        [Route("api/{shipcode}/datasummary")]
        [HttpGet]
        public IEnumerable<dynamic> DatabaseSummary(string shipcode)
        {
            var datasummary1 = db.Sailing_Datas

                            .Where(x => x.Ship_Paticular_Callsign == shipcode)
                            .GroupBy(t => t.Ship_Paticular_Callsign)
                            .Select(g => new {
                                Begin = g.Min(x => x.Sailing_DataDate),
                                EndData = g.Max(x => x.Sailing_DataDate),
                                Total = g.Count()
                            });
            return datasummary1;
        }


        //shipcode로 해양테스트 결과출력(다이나믹 쿼리 DB연결해서 실행해야함)
        //[Route("api/{shipcode},{startdate},{enddate},{data}")]
        //[HttpGet]
        //public IEnumerable<dynamic> seatrialValue111(string shipcode, DateTime startdate, DateTime enddate, string data)
        //{
        //    var seatrialValue = db.Sailing_Data.Where("Sailing_DataDate >= @0 and Sailing_DataDate <= @1 and Ship_Paticular_Callsign == @2", startdate, enddate, shipcode) //조건문
        //        .OrderBy("Sailing_Data_id")           //정렬
        //        .Select("New(" + data + ")");         //필드명
        //    return seatrialValue;
        //}


        double[] doubleGab;
        double[] doubleRpm;
        [Route("api/shopTestCurvefitting/{shipcode}")]
        [HttpGet]
        public IEnumerable<dynamic> shopTestCurvefitting(string shipcode)
        {
            var LinqShop = from linqShop in db.Shop_Tests
                           where linqShop.Ship_Paticular_Callsign == shipcode
                           select new
                           {
                               Gap = linqShop.Shop_Test_Load_Gap,
                               Rpm = double.Parse(linqShop.Shop_Test_Rpm.ToString())
                           };



            var ArrayShop = LinqShop.ToArray();
            doubleGab = new double[ArrayShop.Length];
            doubleRpm = new double[ArrayShop.Length];

            for (int i = 0; i < ArrayShop.Length; i++)
            {
                doubleGab[i] = ArrayShop[i].Gap;
                doubleRpm[i] = ArrayShop[i].Rpm;
            }


            var ShopCurveFitting = shipCare.curveFitting.polynominalRegression(doubleGab, doubleRpm, 3);

            //shop
            List<ShopCurveFittingResult> shopTestCurvefitting = new List<ShopCurveFittingResult>();



            shopTestCurvefitting.Add(new ShopCurveFittingResult
            {
                a = ShopCurveFitting[0],
                b = ShopCurveFitting[1],
                c = ShopCurveFitting[2],
                d = ShopCurveFitting[3],
                e = ShopCurveFitting[4]
            });
            return shopTestCurvefitting;
        }


        double[] doublePower;
        double[] doubleSpeed;
        double[] SeaCurveFitting;
        [Route("api/seatrialCurveFitting/{shipcode}")]
        [HttpGet]
        public IEnumerable<dynamic> seaTestCurvefitting(string shipcode)
        {
            var LinqSea = from linqSeaTrial in db.Sea_Trials
                          where linqSeaTrial.Ship_Paticular_Callsign == shipcode
                          select new
                          {
                              Power = linqSeaTrial.Sea_Trial_Power_Bal,
                              Speed = linqSeaTrial.Sea_Trial_Speed_Ballast2
                          };


            var ArraySea = LinqSea.ToArray();

            doublePower = new double[ArraySea.Length];
            doubleSpeed = new double[ArraySea.Length];

            for (int i = 0; i < ArraySea.Length; i++)
            {
                doublePower[i] = ArraySea[i].Power;
                doubleSpeed[i] = ArraySea[i].Speed;
            }
            var SeaCurveFitting = shipCare.curveFitting.powerRegression(doubleSpeed, doublePower);  //shop

            double[] x = { 11.9, 14.3, 15.9, 16.7, 17.2 };
            double[] y = { 4847, 9695, 14542, 17450, 19389 };



            List<SeaCurveFittingResult> seaTestCurvefitting = new List<SeaCurveFittingResult>();


            seaTestCurvefitting.Add(new SeaCurveFittingResult
            {
                a = SeaCurveFitting[0],
                b = SeaCurveFitting[1],
                c = SeaCurveFitting[2]
            });

            return seaTestCurvefitting;
        }
    }
}
