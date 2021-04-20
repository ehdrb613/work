using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace TrainInformation
{
    class GetUrl
    {
        public XElement request(string url)
        {
            var request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "GET";

            string results = string.Empty;
            HttpWebResponse response;
            using (response = request.GetResponse() as HttpWebResponse)
            {
                StreamReader reader = new StreamReader(response.GetResponseStream());
                results = reader.ReadToEnd();
            }
            XElement resultsXElement = XElement.Parse(results);
            return resultsXElement;
        }
        public void getStrtpntAlocFndTrainInfo(string date, string depPlaceId, string arrPlaceId)
        {
            string url = "http://openapi.tago.go.kr/openapi/service/TrainInfoService/getStrtpntAlocFndTrainInfo"; // URL
            //url += "?ServiceKey=gsClkYQY5L7abfYL7oyicjcCbDBXKny%2BiAx8pSuSBvevP%2B9XASascNCaoWJz%2F89mmb%2BHM53e2xibO743Dr%2BVVQ%3D%3D"; // Service Key
            url += "?ServiceKey=0IL6R0F8vitdpbkttdCEX3Uxse07CQ1RRK3plz%2BdAkBSYkIESNMfTtVmQk%2BPUDXLPQfvB3iGXJYvPOS2brP4gQ%3D%3D";
            url += "&numOfRows=100";
            url += "&pageNo=1";
            url += "&depPlaceId=" + depPlaceId;
            url += "&arrPlaceId=" + arrPlaceId;
            url += "&depPlandTime=" + date;
            url += "&trainGradeCode=02";
            /*
                 <item>
                    <adultcharge>0</adultcharge>
                    <arrplacename>하양</arrplacename>
                    <arrplandtime>20210420215100</arrplandtime>
                    <depplacename>동대구</depplacename>
                    <depplandtime>20210420213500</depplandtime>
                    <traingradename>무궁화호</traingradename>
                    <trainno>1795</trainno>
                </item>
            */
            Console.WriteLine(request(url));
            foreach (var item in request(url).Descendants("item"))
            {
                string tempAdultcharge = item.Element("adultcharge").Value;
                string tempArrplacename = item.Element("arrplacename").Value;
                string tempArrplandtime = item.Element("arrplandtime").Value;
                string tempDepplacename = item.Element("depplacename").Value;
                string tempDepplandtime = item.Element("depplandtime").Value;
                string tempTraingradename = item.Element("traingradename").Value;
                string tempTrainno = item.Element("trainno").Value;

            }
        }
        public static List<SearchTrain> st = new List<SearchTrain>();
        
        public Dictionary<string, string> getCtyCodeList()
        {
            string url = "http://openapi.tago.go.kr/openapi/service/TrainInfoService/getCtyCodeList"; // URL
            //url += "?ServiceKey=gsClkYQY5L7abfYL7oyicjcCbDBXKny%2BiAx8pSuSBvevP%2B9XASascNCaoWJz%2F89mmb%2BHM53e2xibO743Dr%2BVVQ%3D%3D"; // Service Key
            url += "?ServiceKey=0IL6R0F8vitdpbkttdCEX3Uxse07CQ1RRK3plz%2BdAkBSYkIESNMfTtVmQk%2BPUDXLPQfvB3iGXJYvPOS2brP4gQ%3D%3D";

            Dictionary<string, string> city = new Dictionary<string, string>();

            foreach (var item in request(url).Descendants("item"))
            {
                city.Add(item.Element("citycode").Value, item.Element("cityname").Value);
            }

            return city;

        }
        public Dictionary<string, string> getCtyAcctoTrainSttnList(string cityCode)
        {
            string url = "http://openapi.tago.go.kr/openapi/service/TrainInfoService/getCtyAcctoTrainSttnList"; // URL
            //url += "?ServiceKey=gsClkYQY5L7abfYL7oyicjcCbDBXKny%2BiAx8pSuSBvevP%2B9XASascNCaoWJz%2F89mmb%2BHM53e2xibO743Dr%2BVVQ%3D%3D"; // Service Key
            url += "?ServiceKey=0IL6R0F8vitdpbkttdCEX3Uxse07CQ1RRK3plz%2BdAkBSYkIESNMfTtVmQk%2BPUDXLPQfvB3iGXJYvPOS2brP4gQ%3D%3D";
            url += "&numOfRows=100";
            url += "&pageNo=1";
            url += "&cityCode=" + cityCode;

            Dictionary<string, string> node = new Dictionary<string, string>();

            foreach (var item in request(url).Descendants("item"))
            {
                node.Add(item.Element("nodeid").Value, item.Element("nodename").Value);
            }

            return node;

        }

    }
}
