using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace testCodeInWebbyToR.java2s.CSharp
{
    class CreateFile
    {
        public void Create()
        {

            string pattern1 = @"<TD width=\d+>[\d\.]+<A href=""(/Tutorial/CSharp/\d+.*?/.*?\.htm)"">";
            string pattern2 = @".*?/.*?/.*?/.*?/[\d_\.]+(.*?).htm";


            Regex regex1 = new Regex(pattern1, RegexOptions.Compiled);
            Regex regex2 = new Regex(pattern2, RegexOptions.Compiled);
            // string targetString = TORServices.Network.WebHelper.getHTML(@"http://www.java2s.com/Tutorial/CSharp/CatalogCSharp.htm").Result;

            string fol = @"D:\T_MEGA\GithubCode\java2s.CSharp\java2s.CSharp\CodeTOR";
            string fol1, fol2;

            Task.Factory.StartNew(() =>
            {
                foreach (Match match0 in new Regex(@"<TD width=390>[\d\.]+<A href=""(/Tutorial/CSharp/\d+__.*?/\d+__.*?\.htm)"">", RegexOptions.None).Matches(TORServices.Network.WebHelper.getHTML("http://www.java2s.com/Tutorial/CSharp/CatalogCSharp.htm").Result))
                {
                    string url0 = @"http://www.java2s.com" + match0.Groups[1].Value;


                    // richTextBox1.Invoke(new Action(() => richTextBox1.Text += "\n" + url0 + "       " + fol1 ));
                    //  MessageBox.Show(fol1 );
                    foreach (Match match1 in new Regex(@"</td><td  align=left><A href=""(/Tutorial/CSharp/\d+__.*?/.*?.htm)"">", RegexOptions.None).Matches(TORServices.Network.WebHelper.getHTML(url0).Result))
                    {
                        string url1 = @"http://www.java2s.com" + match1.Groups[1].Value;
                        fol1 = match0.Groups[1].Value.Replace("/Tutorial/CSharp", "").Replace("/", "\\").Replace(".htm", "").Replace("-", "_");
                        string file = "frm" + Path.GetFileNameWithoutExtension(match1.Groups[1].Value).Replace(" ", "");


                        string _f = fol + fol1 + "\\" + file + ".cs";
                   

                        Directory.CreateDirectory(Path.GetDirectoryName(_f));
                        if (!File.Exists(_f))
                        {
                            string s;
                            using (StreamReader reader = new StreamReader(@"D:\T_MEGA\GithubCode\java2s.CSharp\java2s.CSharp\frmClass.cs"))
                            {
                                s = reader.ReadToEnd();
                            }

                            s = s.Replace("java2snamespace", $"java2s.CSharp{fol1.Replace("\\", ".C")}")
                                .Replace("frmClass", file)
                                .Replace("url", "http://www.java2s.com" + match1.Groups[1].Value);

                            using (StreamWriter writer = File.CreateText(_f))
                            {
                                writer.Write(s);
                            }

                        }


                    }


                }
              
            });

        }
    }
}
