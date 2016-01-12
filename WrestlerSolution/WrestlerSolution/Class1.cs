//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using RA;

//namespace WrestlerSolution
//{
//    public static class RAApproach
//    {
//        public static void Test1()
//        {
//            new RestAssured()
//                .Given()
//                    .Header("Content-Type", "application/json")
//                    .Header("Accept-Encoding", "gzip,deflate")
//                    .Header("Cookie", "PHPSESSID=qnagib35cjgc8sm1mr4epest54")
//                    .Query("id", "3629")
//                .When()
//                    .Get("http://streamtv.net.ua/base/php/wrestler/read.php")
//                    .Debug()
//                .Then()
//                    .Debug()
//                    .TestBody("test A", x => x.id != null);
//        }
//    }
//}
