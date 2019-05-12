using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace WebsiteScrapper
{
    class Program
    {
        #region URL
        
            //
            //      These are all the URL's i could find online (raw)
            //
        
            /* 
            https://itexamanswers.net/ccna-1-v5-1-v6-0-chapter-1-exam-answers-100-full.html
            https://itexamanswers.net/ccna-1-v5-1-v6-0-chapter-2-exam-answers-100-full.html
            https://itexamanswers.net/ccna-1-v5-1-v6-0-chapter-3-exam-answers-100-full.html
            https://itexamanswers.net/ccna-1-v5-1-v6-0-chapter-4-exam-answers-100-full.html
            https://itexamanswers.net/ccna-1-v5-1-v6-0-chapter-5-exam-answers-100-full.html
            https://itexamanswers.net/ccna-1-v5-1-v6-0-chapter-7-exam-answers-100-full.html
            https://itexamanswers.net/ccna-1-v5-1-v6-0-chapter-8-exam-answers-100-full.html
            https://itexamanswers.net/ccna-1-v5-1-v6-0-chapter-9-exam-answers-100-full.html
            https://itexamanswers.net/ccna-1-v5-1-v6-0-chapter-10-exam-answers-100-full.html
            https://itexamanswers.net/ccna-1-v5-1-v6-0-chapter-11-exam-answers-100-full.html
            https://itexamanswers.net/ccna-1-final-exam-answers-v5-1-v6-0-introduction-to-networks.html
            https://itexamanswers.net/ccna-2-v5-0-3-v6-0-chapter-1-exam-answers-100-full.html
            https://itexamanswers.net/ccna-2-v5-0-3-v6-0-chapter-2-exam-answers-100-full.html
            https://itexamanswers.net/ccna-2-v5-0-3-v6-0-chapter-3-exam-answers-100-full.html
            https://itexamanswers.net/ccna-2-v5-0-3-v6-0-chapter-4-exam-answers-100-full.html
            https://itexamanswers.net/ccna-2-v5-0-3-v6-0-chapter-4-exam-answers-100-full.html
            https://itexamanswers.net/ccna-2-v5-0-3-v6-0-chapter-5-exam-answers-100-full.html
            https://itexamanswers.net/ccna-2-v5-0-3-v6-0-chapter-6-exam-answers-100-full.html
            https://itexamanswers.net/ccna-2-v5-0-3-v6-0-chapter-7-exam-answers-100-full.html
            https://itexamanswers.net/ccna-2-v5-0-3-v6-0-chapter-8-exam-answers-100-full.html
            https://itexamanswers.net/ccna-2-v5-0-3-v6-0-chapter-9-exam-answers-100-full.html
            https://itexamanswers.net/ccna-2-v6-0-final-exam-answers-routing-switching-essentials.html
            https://itexamanswers.net/ccna-3-v5-0-3-v6-0-chapter-1-exam-answers-100-full.html
            https://itexamanswers.net/ccna-3-v5-0-3-v6-0-chapter-2-exam-answers-100-full.html
            https://itexamanswers.net/ccna-3-v5-0-3-v6-0-chapter-3-exam-answers-100-full.html
            https://itexamanswers.net/ccna-3-v5-0-3-v6-0-chapter-4-exam-answers-100-full.html
            https://itexamanswers.net/ccna-3-v5-0-3-v6-0-chapter-5-exam-answers-100-full.html
            https://itexamanswers.net/ccna-3-v5-0-3-v6-0-chapter-6-exam-answers-100-full.html
            https://itexamanswers.net/ccna-3-v5-0-3-v6-0-chapter-7-exam-answers-100-full.html
            https://itexamanswers.net/ccna-3-v5-0-3-v6-0-chapter-8-exam-answers-100-full.html
            https://itexamanswers.net/ccna-3-v5-0-3-v6-0-chapter-9-exam-answers-100-full.html
            https://itexamanswers.net/ccna-3-final-exam-answers-v5-0-3-v6-0-scaling-networks.html
            https://itexamanswers.net/ccna-4-chapter-1-exam-answers-v5-0-3-v6-0-full-100.html
            https://itexamanswers.net/ccna-4-chapter-2-exam-answers-v5-0-3-v6-0-full-100.html
            https://itexamanswers.net/ccna-4-chapter-3-exam-answers-v5-0-3-v6-0-full-100.html
            https://itexamanswers.net/ccna-4-chapter-4-exam-answers-v5-0-3-v6-0-full-100.html
            https://itexamanswers.net/ccna-4-chapter-5-exam-answers-v5-0-3-v6-0-full-100.html
            https://itexamanswers.net/ccna-4-chapter-6-exam-answers-v5-0-3-v6-0-full-100.html
            https://itexamanswers.net/ccna-4-chapter-7-exam-answers-v5-0-3-v6-0-full-100.html
            https://itexamanswers.net/ccna-4-chapter-8-exam-answers-v5-0-3-v6-0-full-100.html
            https://itexamanswers.net/ccna-4-final-exam-answers-v5-0-3-v6-0-connecting-networks.html
            */
        #endregion URL

        private static string[] ccnaURL = {"https://itexamanswers.net/ccna-1-v5-1-v6-0-chapter-1-exam-answers-100-full.html","https://itexamanswers.net/ccna-1-v5-1-v6-0-chapter-2-exam-answers-100-full.html","https://itexamanswers.net/ccna-1-v5-1-v6-0-chapter-3-exam-answers-100-full.html","https://itexamanswers.net/ccna-1-v5-1-v6-0-chapter-4-exam-answers-100-full.html","https://itexamanswers.net/ccna-1-v5-1-v6-0-chapter-5-exam-answers-100-full.html","https://itexamanswers.net/ccna-1-v5-1-v6-0-chapter-7-exam-answers-100-full.html","https://itexamanswers.net/ccna-1-v5-1-v6-0-chapter-8-exam-answers-100-full.html","https://itexamanswers.net/ccna-1-v5-1-v6-0-chapter-9-exam-answers-100-full.html","https://itexamanswers.net/ccna-1-v5-1-v6-0-chapter-10-exam-answers-100-full.html","https://itexamanswers.net/ccna-1-v5-1-v6-0-chapter-11-exam-answers-100-full.html","https://itexamanswers.net/ccna-1-final-exam-answers-v5-1-v6-0-introduction-to-networks.html","https://itexamanswers.net/ccna-2-v5-0-3-v6-0-chapter-1-exam-answers-100-full.html","https://itexamanswers.net/ccna-2-v5-0-3-v6-0-chapter-2-exam-answers-100-full.html","https://itexamanswers.net/ccna-2-v5-0-3-v6-0-chapter-3-exam-answers-100-full.html","https://itexamanswers.net/ccna-2-v5-0-3-v6-0-chapter-4-exam-answers-100-full.html","https://itexamanswers.net/ccna-2-v5-0-3-v6-0-chapter-4-exam-answers-100-full.html","https://itexamanswers.net/ccna-2-v5-0-3-v6-0-chapter-5-exam-answers-100-full.html","https://itexamanswers.net/ccna-2-v5-0-3-v6-0-chapter-6-exam-answers-100-full.html","https://itexamanswers.net/ccna-2-v5-0-3-v6-0-chapter-7-exam-answers-100-full.html","https://itexamanswers.net/ccna-2-v5-0-3-v6-0-chapter-8-exam-answers-100-full.html","https://itexamanswers.net/ccna-2-v5-0-3-v6-0-chapter-9-exam-answers-100-full.html","https://itexamanswers.net/ccna-2-v6-0-final-exam-answers-routing-switching-essentials.html","https://itexamanswers.net/ccna-3-v5-0-3-v6-0-chapter-1-exam-answers-100-full.html","https://itexamanswers.net/ccna-3-v5-0-3-v6-0-chapter-2-exam-answers-100-full.html","https://itexamanswers.net/ccna-3-v5-0-3-v6-0-chapter-3-exam-answers-100-full.html","https://itexamanswers.net/ccna-3-v5-0-3-v6-0-chapter-4-exam-answers-100-full.html","https://itexamanswers.net/ccna-3-v5-0-3-v6-0-chapter-5-exam-answers-100-full.html","https://itexamanswers.net/ccna-3-v5-0-3-v6-0-chapter-6-exam-answers-100-full.html","https://itexamanswers.net/ccna-3-v5-0-3-v6-0-chapter-7-exam-answers-100-full.html","https://itexamanswers.net/ccna-3-v5-0-3-v6-0-chapter-8-exam-answers-100-full.html","https://itexamanswers.net/ccna-3-v5-0-3-v6-0-chapter-9-exam-answers-100-full.html","https://itexamanswers.net/ccna-3-final-exam-answers-v5-0-3-v6-0-scaling-networks.html","https://itexamanswers.net/ccna-4-chapter-1-exam-answers-v5-0-3-v6-0-full-100.html","https://itexamanswers.net/ccna-4-chapter-2-exam-answers-v5-0-3-v6-0-full-100.html","https://itexamanswers.net/ccna-4-chapter-3-exam-answers-v5-0-3-v6-0-full-100.html","https://itexamanswers.net/ccna-4-chapter-4-exam-answers-v5-0-3-v6-0-full-100.html","https://itexamanswers.net/ccna-4-chapter-5-exam-answers-v5-0-3-v6-0-full-100.html","https://itexamanswers.net/ccna-4-chapter-6-exam-answers-v5-0-3-v6-0-full-100.html","https://itexamanswers.net/ccna-4-chapter-7-exam-answers-v5-0-3-v6-0-full-100.html","https://itexamanswers.net/ccna-4-chapter-8-exam-answers-v5-0-3-v6-0-full-100.html","https://itexamanswers.net/ccna-4-final-exam-answers-v5-0-3-v6-0-connecting-networks.html" };
        private static WebClient client;
        private static List<string> Questions = new List<string>();
        private static List<string> Answairs = new List<string>();
        static void Main(string[] args)
        {
            StreamWriter writer;
            client = new WebClient();
            string WebPageContent, BodyContent;
            int BodyStart = 0, BodyEnd = 0;
            string sBody = "<body";
            string eBody = "</body";
            bool isSbody = false;
            bool isEbody = false;
            //writer = new StreamWriter("G:\\ALL_Dump.txt");
            for (int i = 0; i < ccnaURL.Length; i++)
            {
                
                WebPageContent = client.DownloadString(ccnaURL[i]);
                writer = new StreamWriter("G:\\CCNA-Exam-Answers-2019---DUMP\\" + FindElementData(WebPageContent, "<title>", "</title>", false)[0] + ".txt");
                for (int j = 0; j < WebPageContent.Length - eBody.Length; j++)
                {
                    isSbody = true;
                    for (int x = 0; x < sBody.Length; x++)
                    {
                        if(WebPageContent[j+x] != sBody[x])
                        {
                            isSbody = false;
                            break;
                        }
                    }
                    isEbody = true;
                    for (int x = 0; x < eBody.Length-1; x++)
                    {
                        if (WebPageContent[j + x] != eBody[x])
                        {
                            isEbody = false;
                            break;
                        }
                    }
                    if (isSbody)
                        BodyStart = j;
                    if (isEbody)
                        BodyEnd = j;
                }
                BodyContent = WebPageContent.Substring(BodyStart, BodyEnd - BodyStart);
                List<string> Output = FindElementData(BodyContent, "<strong>", "</strong>",false);
                foreach(string unknown in Output)
                {
                    if (unknown[unknown.Length - 1] == '*')
                    {
                        Answairs.Add(unknown);
                        writer.WriteLine("A: " + unknown);
                    }
                    else
                    {
                        Questions.Add(unknown);
                        writer.WriteLine("Q: " + unknown);
                    }
                       
                }
                writer.Close();
            }
            
            Console.WriteLine("Done!");
            Console.ReadLine();

        }
        private static List<string> FindElementData(string data, string StartElement, string EndElement, bool IsRed)
        {
            List<string> SearchResult = new List<string>();
            int StartMatchIndex = -1;
            int EndMatchIndex = -1;
            int LastStartMatchIndex = -1;
            int LastEndMatchIndex = -1;
            for (int i = 0; i < data.Length; i++)
            {
                bool IsStartMatch = true;
                bool IsEndMatch = true;
                for (int j = 0; j < StartElement.Length; j++)
                {
                    if(data[i+j] != StartElement[j])
                    {
                        IsStartMatch = false;
                        break;
                    }
                }
                if (IsStartMatch)
                    StartMatchIndex = i + StartElement.Length;
                for (int j = 0; j < EndElement.Length; j++)
                {
                    if (data[i + j] != EndElement[j])
                    {
                        IsEndMatch = false;
                        break;
                    }
                }
                if (IsEndMatch)
                    EndMatchIndex = i;
                if(LastEndMatchIndex != EndMatchIndex && LastStartMatchIndex != StartMatchIndex)
                {
                    try
                    {
                        SearchResult.Add(data.Substring(StartMatchIndex, EndMatchIndex - StartMatchIndex).Replace("</p>", "").Replace("<li>", ""));
                        Console.WriteLine(data.Substring(StartMatchIndex, EndMatchIndex - StartMatchIndex));
                        LastEndMatchIndex = EndMatchIndex;
                        LastStartMatchIndex = StartMatchIndex;
                    }
                    catch { }
                    
                }
            }
            return SearchResult;
        }
    }
}
