using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using HtmlAgilityPack;
using System.IO;

namespace GetEbayList
{
    class Program
    {
        static void Main(string[] args)
        {
            string line;
            List<string> urlList = new List<string>();
            StreamReader fileReader = new StreamReader("webList.txt");
            StreamWriter fileWriter = new StreamWriter("IdList.txt");
            while ((line = fileReader.ReadLine()) != null)
            {
                urlList.Add(line);
            }

            //string Url = @"http://www.ebay.com/sch/Battery-Grips/29967/i.html?LH_BIN=1&LH_ItemCondition=1000&rt=nc&LH_FS=1&_trksid=p2045573.m1684";
            HtmlWeb web = new HtmlWeb();
            foreach(var each in urlList)
            {
                HtmlDocument doc = web.Load(each);
                var liList = doc.GetElementbyId("ListViewInner").ChildNodes.Where(a => a.Name == "li").ToList();
                //liList.ToList()[0].Attributes[2].Value
                foreach (var eachInside in liList)
                {
                    fileWriter.WriteLine(eachInside.Attributes[2].Value);
                }
            }
            fileWriter.Close();
            //htmlDoc.Load("http://www.ebay.com/sch/Battery-Grips/29967/i.html?LH_BIN=1&LH_ItemCondition=1000&rt=nc&LH_FS=1&_trksid=p2045573.m1684");

        }
    }
}
