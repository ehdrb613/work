using donggyu_1023.Data;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace donggyu_1023
{
    class DataManager_D
    {
        static HttpClient client = new HttpClient();
        public static List<Train_D> trainGradeCode = new List<Train_D>();


        public const int SEOUL = 11;
        public const int SEJOUNG = 12;
        public const int BUSAN = 21;
        public const int DAEGU = 22;
        public const int INCHUN = 23;
        public const int GWANGJU = 24;
        public const int DAEJEON = 25;
        public const int ULSAN = 26;
        public const int GYEONGGI = 31;
        public const int GANGWON = 32;
        public const int CHUNGCHEONGBUK = 33;
        public const int CHUNGCHEONGNAM = 34;
        public const int JEOLLABUK = 35;
        public const int JEOLLANAM = 36;
        public const int GYEONGSANGBUK = 37;
        public const int GYEONGSANGNAM = 38;

        public const string KTX = "00";//ktx
        public const string SAEMAEUL = "01";//새마을
        public const string MUGUNGHWA = "02";//무궁화
        public const string COMMUTER = "03";//통근열차
        public const string NURIRO = "04";//누리로
        public const string AREXDIRECT = "06";//AREX직통
        public const string KTX_SANCHUN1 = "07";//ktx 산천
        public const string ITX_SAEMAEUL = "08";//itx 새마을
        public const string ITX_CHUNGCHUN1 = "09";//itx 청춘
        public const string KTX_SANCHUN2 = "10";//ktx 산천2
        public const string ITX_CHUNGCHUN2 = "15";//itx 청춘2
        public const string KTX_LEEEM = "16";//ktx 이음
        public const string SRT = "17";//SRT



        #region api 정보 호출

        //지역 코드 정보
        public static void getCtyCodeList()
        {
            
             string results = "";

            try
            {
                results = File.ReadAllText(@"./ctyCode.xml");
                Console.WriteLine("ctyCode.xml load 성공");
              
                XElement ctyCode = XElement.Parse(results);
                //도시 코드 저장
                foreach (var item in ctyCode.Descendants("citycode"))
                {
                    int tempCityCode = int.Parse(ctyCode.Element("citycode").Value);
                    string tempCtiyName = ctyCode.Element("cityname").Value;

                    Train_D td = new Train_D()
                    {
                        citycode = tempCityCode,
                        cityname = tempCtiyName
                    };
                    trainGradeCode.Add(td);
                    
                }
                foreach (var item in trainGradeCode)
                {
                    Console.WriteLine(item.citycode + item.cityname);

                }
              
                
            }
            catch (Exception ex)
            {
                string url = "http://openapi.tago.go.kr/openapi/service/TrainInfoService/getCtyCodeList"; // URL
                url += "?ServiceKey=" + "0IL6R0F8vitdpbkttdCEX3Uxse07CQ1RRK3plz%2BdAkBSYkIESNMfTtVmQk%2BPUDXLPQfvB3iGXJYvPOS2brP4gQ%3D%3D"; // Service Key


                var request = (HttpWebRequest)WebRequest.Create(url);
                request.Method = "GET";

                results = string.Empty;
                HttpWebResponse response;
                using (response = request.GetResponse() as HttpWebResponse)
                {
                    StreamReader reader = new StreamReader(response.GetResponseStream());
                    results = reader.ReadToEnd();
                }

                //Console.WriteLine(results);
                XElement ctyCode = XElement.Parse(results);

                Console.WriteLine(ctyCode);
                File.WriteAllText(@"./ctyCode.xml", ctyCode.ToString());


                System.Windows.Forms.MessageBox.Show(ex.Message);

                getCtyCodeList();//다시 호출
            }


        }

        //기차 종류 코드 정보
        public static void getVhcleKndList()
        {
            string results = "";
            try
            {
                results = File.ReadAllText(@"./VhcleKnd.xml");
                Console.WriteLine("VhcleKnd.xml load 성공");
                Console.WriteLine(results);
            }
            catch(Exception ex)
            {

           
            string url = "http://openapi.tago.go.kr/openapi/service/TrainInfoService/getVhcleKndList"; // URL
            url += "?ServiceKey=" + "0IL6R0F8vitdpbkttdCEX3Uxse07CQ1RRK3plz%2BdAkBSYkIESNMfTtVmQk%2BPUDXLPQfvB3iGXJYvPOS2brP4gQ%3D%3D"; // Service Key

            var request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "GET";

            results = string.Empty;
            HttpWebResponse response;
            using (response = request.GetResponse() as HttpWebResponse)
            {
                StreamReader reader = new StreamReader(response.GetResponseStream());
                results = reader.ReadToEnd();
            }


                XElement VhcleKnd = XElement.Parse(results);
                Console.WriteLine(VhcleKnd);
                File.WriteAllText(@"./VhcleKnd.xml", VhcleKnd.ToString());//Api 불러온 정보 저장

                System.Windows.Forms.MessageBox.Show(ex.Message);

                getVhcleKndList();//다시 호출
            }
        }

        public static void AcctoTrainSttnList(int city)
        {

        
        string url = "http://openapi.tago.go.kr/openapi/service/TrainInfoService/getCtyAcctoTrainSttnList"; // URL
            url += "?ServiceKey=" + "0IL6R0F8vitdpbkttdCEX3Uxse07CQ1RRK3plz%2BdAkBSYkIESNMfTtVmQk%2BPUDXLPQfvB3iGXJYvPOS2brP4gQ%3D%3D"; // Service Key
            url += "&numOfRows=10";
            url += "&pageNo=1";
            url += "&cityCode=" + city;

            var request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "GET";

            string results = string.Empty;
            HttpWebResponse response;
            using (response = request.GetResponse() as HttpWebResponse)
            {
                StreamReader reader = new StreamReader(response.GetResponseStream());
                results = reader.ReadToEnd();
            }

            Console.WriteLine(results);
            XElement TrainSttn = XElement.Parse(results);
            Console.WriteLine(TrainSttn);
           

        }


      
        static void getStrtTrainInfo()
        {
            string url = "http://openapi.tago.go.kr/openapi/service/TrainInfoService/getStrtpntAlocFndTrainInfo"; // URL
            url += "?ServiceKey=" + "서비스키"; // Service Key
            url += "&numOfRows=10";
            url += "&pageNo=1";
            url += "&depPlaceId=NAT010000";
            url += "&arrPlaceId=NAT011668";
            url += "&depPlandTime=20201201";
            url += "&trainGradeCode=00";

            var request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "GET";

            string results = string.Empty;
            HttpWebResponse response;
            using (response = request.GetResponse() as HttpWebResponse)
            {
                StreamReader reader = new StreamReader(response.GetResponseStream());
                results = reader.ReadToEnd();
            }

            Console.WriteLine(results);
        }

        #endregion api 정보호출
    }
}
