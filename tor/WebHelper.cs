using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TORServices.Network
{
    public static class WebHelper
    {
      /*   public static TimeSpan ToTimeSpan(this string ts)
         {
             if (ts == null) return TimeSpan.Parse("00:00:00");
             string[] sts = ts.Split(':');
             //  MessageBox.Show(ts+ "  " +sts.Length);
             TimeSpan _ts = TimeSpan.Parse("00:00:00");
             if (sts.Length == 1)
             {
                 _ts = TimeSpan.Parse("00:00:" + ts);
             }
             else if (sts.Length == 2)
             {
                 _ts = TimeSpan.Parse("00:" + ts);
                 // MessageBox.Show(_ts.ToString());
             }
             else if (sts.Length == 3)
             {
                 _ts = TimeSpan.Parse(ts);
             }

             return _ts;
         }*/

        public static Task<string> getHTML(this string url)
        {
            return Task.Run(() =>
            {
                string _url = url;
                string html = "";
                if (url.StartsWith("http"))
                {
                    try
                    {
                        System.Net.HttpWebRequest request = (System.Net.HttpWebRequest)System.Net.HttpWebRequest.Create(url.Trim());
                        System.Net.HttpWebResponse response = (System.Net.HttpWebResponse)request.GetResponse();
                        System.IO.StreamReader sr = new System.IO.StreamReader(response.GetResponseStream());
                        html = sr.ReadToEnd();
                        sr.Close();
                        response.Close();
                    }
                    catch { }
                }
                else
                {
                    html = url;
                }
                return html;
            });


        }

        /* public static Task< List<string>> GetLinks(this string url, string pattern)
         {


                 List<string> lst = new List<string>();
                 lst.AddRange(Regex.Matches(url.getHTML(), pattern)
                     .OfType<Match>()
                     .Select(m => m.Groups[1].Value)
                     .ToList<string>());

                 return lst;

         }
         public static MatchCollection GetLinksMatchCollection(this string url, string pattern)
         {


                 MatchCollection matchCollection = Regex.Matches(url.getHTML(), pattern)??null;

                 return matchCollection ;

         }


         public static string GetValue(this string url, string pattern,bool setFile = false)
         {

                 string _value;
                 try
                 {

                     _value = new Regex(pattern, RegexOptions.None).Matches((string)url.getHTML())[0].Groups[1].Value;
                 }
                 catch { _value = ""; }

             return (setFile) ? TORServices.PathFile.FileTor.MakeValidFileName(_value):_value ;

         }

         public static Match GetValueMatch(this string url, string pattern)
         {

               return new Regex(pattern, RegexOptions.None).Matches((string)url.getHTML())[0]??null;


         }


         public static Task<List<string>> GetLinkByString(this string str, string pattern)
         {

             return Task.Run(() =>
             {
                 List<string> lst = new List<string>();

                 /* lst.AddRange(Regex.Matches(str, pattern)
                      .OfType<Match>()
                      .Select(m => m.Groups[1].Value)
                      .ToList<string>());*

                 foreach (Match myMatch in Regex.Matches(str, pattern))
                 {
                     lst.Add(myMatch.Groups[1].Value);
                 }


                 return lst;
             });
         }

         public static Task<string> GetValueByURL(this string url, string pattern)
         {

             return Task.Run(() =>
             {
                 string _value;
                 try
                 {

                     _value = new Regex(pattern, RegexOptions.None).Matches((string)url.getHTML())[0].Groups[1].Value;
                 }
                 catch { _value = ""; }

                 return _value;
             });
         }
 */


        public static Task<List<string>> GetLinkByURL(this string url, string pattern)
        {

            return Task.Run(() =>
            {
                List<string> lst = new List<string>();

                lst.AddRange(Regex.Matches(url.getHTML().Result, pattern)
                    .OfType<Match>()
                    .Select(m => m.Groups[1].Value)
                    .ToList<string>());

                return lst;
            });
        }

        public static Task<List<string>> GetLinkByString(this string str, string pattern)
        {

            return Task.Run(() =>
            {
                List<string> lst = new List<string>();

                /* lst.AddRange(Regex.Matches(str, pattern)
                     .OfType<Match>()
                     .Select(m => m.Groups[1].Value)
                     .ToList<string>());*/

                foreach (Match myMatch in Regex.Matches(str, pattern))
                {
                    lst.Add(myMatch.Groups[1].Value);
                }


                return lst;
            });
        }

        public static Task<string> GetValueByURL(this string url, string pattern)
        {

            return Task.Run(() =>
            {
                string _value;
                try
                {

                    _value = new Regex(pattern, RegexOptions.None).Matches((string)url.getHTML().Result)[0].Groups[1].Value;
                }
                catch { _value = ""; }

                return _value;
            });
        }

        public static Task<string> GetValueBystring(this string str, string pattern)
        {

            return Task.Run(() =>
            {
                string _value;
                try
                {

                    _value = new Regex(pattern, RegexOptions.None).Matches(str)[0].Groups[1].Value;
                }
                catch { _value = ""; }

                return _value;
            });
        }



        public static void LoadByIDM(string link, string file)
        {
            Task.Run(() =>
            {
                string IDMpath = Microsoft.Win32.Registry.GetValue(@"HKEY_CURRENT_USER\Software\DownloadManager", "ExePath", true).ToString();
                System.Diagnostics.Process.Start(IDMpath, "/a /n /d " + link + "  /f \"" + file + "\"");
                System.Threading.Thread.Sleep(500);
            });

        }

        /*  public static void LoadByWebClient(string link, string file)
           {

                   string fol = Path.GetDirectoryName(file);
                   string folTemp = Path.GetTempPath() + "LoadFileTemp";
                   string fileTemp = folTemp + "\\" + DateTime.Now.ToString("yyyyMMdd hhmmssffff") + "_"+ Path.GetFileName(file);
                   if (!Directory.Exists(folTemp))
                       Directory.CreateDirectory(folTemp);
                   using (WebClient webClient = new WebClient())
                       {
                       webClient.DownloadFileCompleted += (s,e)=>
                       {
                           if (File.Exists(fileTemp))
                           {

                               if (new FileInfo(fileTemp).Length > 0)
                               {

                                   if (!Directory.Exists(fol))
                                       Directory.CreateDirectory(fol);

                                   File.Move(fileTemp, file);
                               }

                           }
                       };
                       try
                       {
                           webClient.DownloadFileAsync(new Uri(link), fileTemp);
                           System.Threading.Thread.Sleep(100);
                       }
                       catch { }



                       }







           }*/

      
    

    }
}
