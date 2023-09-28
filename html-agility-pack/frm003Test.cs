﻿using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using testCodeInWebbyToR.Ext;
using TORServices.Forms;
using System.Windows.Forms;
namespace testCodeInWebbyToR.html_agility_pack
{
    internal class frm003Test:frmBase
    {
        public frm003Test()
        {
            Load += (o, e) => { Task.Factory.StartNew(Test001); };
        }



        private void InitializeComponent()
        {
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // frm003Test
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.ClientSize = new System.Drawing.Size(941, 535);
            this.Name = "frm003Test";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }



        ///<summary>
        ///
        /// </summary>
        void Test001()
        {
            for (int i = 1; i < 29; i++)
            {
                string url = "http://www.chemicalbook.com/ProductCatalog_EN/12-"+i+".htm";
                this.Write(url);
                HtmlWeb web = new HtmlWeb();
                var htmlDoc = web.Load(url);
                HtmlNodeCollection rows = htmlDoc.DocumentNode.SelectNodes("//table[@class='CataProList']//tr");
                foreach (HtmlNode row in rows)
                {
                    // ดึงข้อมูลในแต่ละเซลล์ของแถว
                    HtmlNodeCollection cells = row.SelectNodes("td");
                    if (cells != null)
                    {
                        string structure = cells[0].SelectSingleNode("img").GetAttributeValue("src", "").Trim();
                        string chemicalName = cells[1].SelectSingleNode("a").InnerText.Trim();
                        string cas = cells[2].SelectSingleNode("a").InnerText.Trim();
                        string mf = cells[3].SelectSingleNode("span").InnerText.Trim();

                        // ทำอะไรกับข้อมูลที่ดึงได้ต่อไป
                        richTextBox1.WriteLine($"Structure: {structure} Chemical Name: {chemicalName} CAS: {cas} MF: {mf} ");

                    }
                }

            }
            MessageBox.Show("Complete");
        }


        ///<summary>
        ///
        /// </summary>
        void Test002()
        {

        }



        ///<summary>
        ///
        /// </summary>
        void Test003()
        {

        }



        ///<summary>
        ///
        /// </summary>
        void Test004()
        {

        }



        ///<summary>
        ///
        /// </summary>
        void Test005()
        {

        }



        ///<summary>
        ///
        /// </summary>
        void Test006()
        {

        }



        ///<summary>
        ///
        /// </summary>
        void Test007()
        {

        }



        ///<summary>
        ///
        /// </summary>
        void Test008()
        {

        }



        ///<summary>
        ///
        /// </summary>
        void Test009()
        {

        }



        ///<summary>
        ///
        /// </summary>
        void Test010()
        {

        }



        ///<summary>
        ///
        /// </summary>
        void Test011()
        {

        }



        ///<summary>
        ///
        /// </summary>
        void Test012()
        {

        }



        ///<summary>
        ///
        /// </summary>
        void Test013()
        {

        }



        ///<summary>
        ///
        /// </summary>
        void Test014()
        {

        }



        ///<summary>
        ///
        /// </summary>
        void Test015()
        {

        }



        ///<summary>
        ///
        /// </summary>
        void Test016()
        {

        }



        ///<summary>
        ///
        /// </summary>
        void Test017()
        {

        }



        ///<summary>
        ///
        /// </summary>
        void Test018()
        {

        }



        ///<summary>
        ///
        /// </summary>
        void Test019()
        {

        }



        ///<summary>
        ///
        /// </summary>
        void Test020()
        {

        }



        ///<summary>
        ///
        /// </summary>
        void Test021()
        {

        }



        ///<summary>
        ///
        /// </summary>
        void Test022()
        {

        }



        ///<summary>
        ///
        /// </summary>
        void Test023()
        {

        }



        ///<summary>
        ///
        /// </summary>
        void Test024()
        {

        }



        ///<summary>
        ///
        /// </summary>
        void Test025()
        {

        }



        ///<summary>
        ///
        /// </summary>
        void Test026()
        {

        }



        ///<summary>
        ///
        /// </summary>
        void Test027()
        {

        }



        ///<summary>
        ///
        /// </summary>
        void Test028()
        {

        }



        ///<summary>
        ///
        /// </summary>
        void Test029()
        {

        }



        ///<summary>
        ///
        /// </summary>
        void Test030()
        {

        }



        ///<summary>
        ///
        /// </summary>
        void Test031()
        {

        }



        ///<summary>
        ///
        /// </summary>
        void Test032()
        {

        }



        ///<summary>
        ///
        /// </summary>
        void Test033()
        {

        }



        ///<summary>
        ///
        /// </summary>
        void Test034()
        {

        }



        ///<summary>
        ///
        /// </summary>
        void Test035()
        {

        }



        ///<summary>
        ///
        /// </summary>
        void Test036()
        {

        }



        ///<summary>
        ///
        /// </summary>
        void Test037()
        {

        }



        ///<summary>
        ///
        /// </summary>
        void Test038()
        {

        }



        ///<summary>
        ///
        /// </summary>
        void Test039()
        {

        }



        ///<summary>
        ///
        /// </summary>
        void Test040()
        {

        }



        ///<summary>
        ///
        /// </summary>
        void Test041()
        {

        }



        ///<summary>
        ///
        /// </summary>
        void Test042()
        {

        }



        ///<summary>
        ///
        /// </summary>
        void Test043()
        {

        }



        ///<summary>
        ///
        /// </summary>
        void Test044()
        {

        }



        ///<summary>
        ///
        /// </summary>
        void Test045()
        {

        }



        ///<summary>
        ///
        /// </summary>
        void Test046()
        {

        }



        ///<summary>
        ///
        /// </summary>
        void Test047()
        {

        }



        ///<summary>
        ///
        /// </summary>
        void Test048()
        {

        }



        ///<summary>
        ///
        /// </summary>
        void Test049()
        {

        }



        ///<summary>
        ///
        /// </summary>
        void Test050()
        {

        }



        ///<summary>
        ///
        /// </summary>
        void Test051()
        {

        }



        ///<summary>
        ///
        /// </summary>
        void Test052()
        {

        }



        ///<summary>
        ///
        /// </summary>
        void Test053()
        {

        }



        ///<summary>
        ///
        /// </summary>
        void Test054()
        {

        }



        ///<summary>
        ///
        /// </summary>
        void Test055()
        {

        }



        ///<summary>
        ///
        /// </summary>
        void Test056()
        {

        }



        ///<summary>
        ///
        /// </summary>
        void Test057()
        {

        }



        ///<summary>
        ///
        /// </summary>
        void Test058()
        {

        }



        ///<summary>
        ///
        /// </summary>
        void Test059()
        {

        }



        ///<summary>
        ///
        /// </summary>
        void Test060()
        {

        }



        ///<summary>
        ///
        /// </summary>
        void Test061()
        {

        }



        ///<summary>
        ///
        /// </summary>
        void Test062()
        {

        }



        ///<summary>
        ///
        /// </summary>
        void Test063()
        {

        }



        ///<summary>
        ///
        /// </summary>
        void Test064()
        {

        }



        ///<summary>
        ///
        /// </summary>
        void Test065()
        {

        }



        ///<summary>
        ///
        /// </summary>
        void Test066()
        {

        }



        ///<summary>
        ///
        /// </summary>
        void Test067()
        {

        }



        ///<summary>
        ///
        /// </summary>
        void Test068()
        {

        }



        ///<summary>
        ///
        /// </summary>
        void Test069()
        {

        }



        ///<summary>
        ///
        /// </summary>
        void Test070()
        {

        }



        ///<summary>
        ///
        /// </summary>
        void Test071()
        {

        }



        ///<summary>
        ///
        /// </summary>
        void Test072()
        {

        }



        ///<summary>
        ///
        /// </summary>
        void Test073()
        {

        }



        ///<summary>
        ///
        /// </summary>
        void Test074()
        {

        }



        ///<summary>
        ///
        /// </summary>
        void Test075()
        {

        }



        ///<summary>
        ///
        /// </summary>
        void Test076()
        {

        }



        ///<summary>
        ///
        /// </summary>
        void Test077()
        {

        }



        ///<summary>
        ///
        /// </summary>
        void Test078()
        {

        }



        ///<summary>
        ///
        /// </summary>
        void Test079()
        {

        }



        ///<summary>
        ///
        /// </summary>
        void Test080()
        {

        }



        ///<summary>
        ///
        /// </summary>
        void Test081()
        {

        }



        ///<summary>
        ///
        /// </summary>
        void Test082()
        {

        }



        ///<summary>
        ///
        /// </summary>
        void Test083()
        {

        }



        ///<summary>
        ///
        /// </summary>
        void Test084()
        {

        }



        ///<summary>
        ///
        /// </summary>
        void Test085()
        {

        }



        ///<summary>
        ///
        /// </summary>
        void Test086()
        {

        }



        ///<summary>
        ///
        /// </summary>
        void Test087()
        {

        }



        ///<summary>
        ///
        /// </summary>
        void Test088()
        {

        }



        ///<summary>
        ///
        /// </summary>
        void Test089()
        {

        }



        ///<summary>
        ///
        /// </summary>
        void Test090()
        {

        }



        ///<summary>
        ///
        /// </summary>
        void Test091()
        {

        }



        ///<summary>
        ///
        /// </summary>
        void Test092()
        {

        }



        ///<summary>
        ///
        /// </summary>
        void Test093()
        {

        }



        ///<summary>
        ///
        /// </summary>
        void Test094()
        {

        }



        ///<summary>
        ///
        /// </summary>
        void Test095()
        {

        }



        ///<summary>
        ///
        /// </summary>
        void Test096()
        {

        }



        ///<summary>
        ///
        /// </summary>
        void Test097()
        {

        }



        ///<summary>
        ///
        /// </summary>
        void Test098()
        {

        }



        ///<summary>
        ///
        /// </summary>
        void Test099()
        {

        }



        ///<summary>
        ///
        /// </summary>
        void Test100()
        {

        }



        ///<summary>
        ///
        /// </summary>
        void Test101()
        {

        }



        ///<summary>
        ///
        /// </summary>
        void Test102()
        {

        }



        ///<summary>
        ///
        /// </summary>
        void Test103()
        {

        }



        ///<summary>
        ///
        /// </summary>
        void Test104()
        {

        }



        ///<summary>
        ///
        /// </summary>
        void Test105()
        {

        }



        ///<summary>
        ///
        /// </summary>
        void Test106()
        {

        }



        ///<summary>
        ///
        /// </summary>
        void Test107()
        {

        }



        ///<summary>
        ///
        /// </summary>
        void Test108()
        {

        }



        ///<summary>
        ///
        /// </summary>
        void Test109()
        {

        }



        ///<summary>
        ///
        /// </summary>
        void Test110()
        {

        }



        ///<summary>
        ///
        /// </summary>
        void Test111()
        {

        }



        ///<summary>
        ///
        /// </summary>
        void Test112()
        {

        }



        ///<summary>
        ///
        /// </summary>
        void Test113()
        {

        }



        ///<summary>
        ///
        /// </summary>
        void Test114()
        {

        }



        ///<summary>
        ///
        /// </summary>
        void Test115()
        {

        }



        ///<summary>
        ///
        /// </summary>
        void Test116()
        {

        }



        ///<summary>
        ///
        /// </summary>
        void Test117()
        {

        }



        ///<summary>
        ///
        /// </summary>
        void Test118()
        {

        }



        ///<summary>
        ///
        /// </summary>
        void Test119()
        {

        }



        ///<summary>
        ///
        /// </summary>
        void Test120()
        {

        }



        ///<summary>
        ///
        /// </summary>
        void Test121()
        {

        }



        ///<summary>
        ///
        /// </summary>
        void Test122()
        {

        }



        ///<summary>
        ///
        /// </summary>
        void Test123()
        {

        }



        ///<summary>
        ///
        /// </summary>
        void Test124()
        {

        }



        ///<summary>
        ///
        /// </summary>
        void Test125()
        {

        }



        ///<summary>
        ///
        /// </summary>
        void Test126()
        {

        }



        ///<summary>
        ///
        /// </summary>
        void Test127()
        {

        }



        ///<summary>
        ///
        /// </summary>
        void Test128()
        {

        }



        ///<summary>
        ///
        /// </summary>
        void Test129()
        {

        }



        ///<summary>
        ///
        /// </summary>
        void Test130()
        {

        }



        ///<summary>
        ///
        /// </summary>
        void Test131()
        {

        }



        ///<summary>
        ///
        /// </summary>
        void Test132()
        {

        }



        ///<summary>
        ///
        /// </summary>
        void Test133()
        {

        }



        ///<summary>
        ///
        /// </summary>
        void Test134()
        {

        }



        ///<summary>
        ///
        /// </summary>
        void Test135()
        {

        }



        ///<summary>
        ///
        /// </summary>
        void Test136()
        {

        }



        ///<summary>
        ///
        /// </summary>
        void Test137()
        {

        }



        ///<summary>
        ///
        /// </summary>
        void Test138()
        {

        }



        ///<summary>
        ///
        /// </summary>
        void Test139()
        {

        }



        ///<summary>
        ///
        /// </summary>
        void Test140()
        {

        }



        ///<summary>
        ///
        /// </summary>
        void Test141()
        {

        }



        ///<summary>
        ///
        /// </summary>
        void Test142()
        {

        }



        ///<summary>
        ///
        /// </summary>
        void Test143()
        {

        }



        ///<summary>
        ///
        /// </summary>
        void Test144()
        {

        }



        ///<summary>
        ///
        /// </summary>
        void Test145()
        {

        }



        ///<summary>
        ///
        /// </summary>
        void Test146()
        {

        }



        ///<summary>
        ///
        /// </summary>
        void Test147()
        {

        }



        ///<summary>
        ///
        /// </summary>
        void Test148()
        {

        }



        ///<summary>
        ///
        /// </summary>
        void Test149()
        {

        }



        ///<summary>
        ///
        /// </summary>
        void Test150()
        {

        }



        ///<summary>
        ///
        /// </summary>
        void Test151()
        {

        }



        ///<summary>
        ///
        /// </summary>
        void Test152()
        {

        }



        ///<summary>
        ///
        /// </summary>
        void Test153()
        {

        }



        ///<summary>
        ///
        /// </summary>
        void Test154()
        {

        }



        ///<summary>
        ///
        /// </summary>
        void Test155()
        {

        }



        ///<summary>
        ///
        /// </summary>
        void Test156()
        {

        }



        ///<summary>
        ///
        /// </summary>
        void Test157()
        {

        }



        ///<summary>
        ///
        /// </summary>
        void Test158()
        {

        }



        ///<summary>
        ///
        /// </summary>
        void Test159()
        {

        }



        ///<summary>
        ///
        /// </summary>
        void Test160()
        {

        }



        ///<summary>
        ///
        /// </summary>
        void Test161()
        {

        }



        ///<summary>
        ///
        /// </summary>
        void Test162()
        {

        }



        ///<summary>
        ///
        /// </summary>
        void Test163()
        {

        }



        ///<summary>
        ///
        /// </summary>
        void Test164()
        {

        }



        ///<summary>
        ///
        /// </summary>
        void Test165()
        {

        }



        ///<summary>
        ///
        /// </summary>
        void Test166()
        {

        }



        ///<summary>
        ///
        /// </summary>
        void Test167()
        {

        }



        ///<summary>
        ///
        /// </summary>
        void Test168()
        {

        }



        ///<summary>
        ///
        /// </summary>
        void Test169()
        {

        }



        ///<summary>
        ///
        /// </summary>
        void Test170()
        {

        }



        ///<summary>
        ///
        /// </summary>
        void Test171()
        {

        }



        ///<summary>
        ///
        /// </summary>
        void Test172()
        {

        }



        ///<summary>
        ///
        /// </summary>
        void Test173()
        {

        }



        ///<summary>
        ///
        /// </summary>
        void Test174()
        {

        }



        ///<summary>
        ///
        /// </summary>
        void Test175()
        {

        }



        ///<summary>
        ///
        /// </summary>
        void Test176()
        {

        }



        ///<summary>
        ///
        /// </summary>
        void Test177()
        {

        }



        ///<summary>
        ///
        /// </summary>
        void Test178()
        {

        }



        ///<summary>
        ///
        /// </summary>
        void Test179()
        {

        }



        ///<summary>
        ///
        /// </summary>
        void Test180()
        {

        }



        ///<summary>
        ///
        /// </summary>
        void Test181()
        {

        }



        ///<summary>
        ///
        /// </summary>
        void Test182()
        {

        }



        ///<summary>
        ///
        /// </summary>
        void Test183()
        {

        }



        ///<summary>
        ///
        /// </summary>
        void Test184()
        {

        }



        ///<summary>
        ///
        /// </summary>
        void Test185()
        {

        }



        ///<summary>
        ///
        /// </summary>
        void Test186()
        {

        }



        ///<summary>
        ///
        /// </summary>
        void Test187()
        {

        }



        ///<summary>
        ///
        /// </summary>
        void Test188()
        {

        }



        ///<summary>
        ///
        /// </summary>
        void Test189()
        {

        }



        ///<summary>
        ///
        /// </summary>
        void Test190()
        {

        }



        ///<summary>
        ///
        /// </summary>
        void Test191()
        {

        }



        ///<summary>
        ///
        /// </summary>
        void Test192()
        {

        }



        ///<summary>
        ///
        /// </summary>
        void Test193()
        {

        }



        ///<summary>
        ///
        /// </summary>
        void Test194()
        {

        }



        ///<summary>
        ///
        /// </summary>
        void Test195()
        {

        }



        ///<summary>
        ///
        /// </summary>
        void Test196()
        {

        }



        ///<summary>
        ///
        /// </summary>
        void Test197()
        {

        }



        ///<summary>
        ///
        /// </summary>
        void Test198()
        {

        }



        ///<summary>
        ///
        /// </summary>
        void Test199()
        {

        }



        ///<summary>
        ///
        /// </summary>
        void Test200()
        {

        }



        ///<summary>
        ///
        /// </summary>
        void Test201()
        {

        }



        ///<summary>
        ///
        /// </summary>
        void Test202()
        {

        }



        ///<summary>
        ///
        /// </summary>
        void Test203()
        {

        }



        ///<summary>
        ///
        /// </summary>
        void Test204()
        {

        }



        ///<summary>
        ///
        /// </summary>
        void Test205()
        {

        }



        ///<summary>
        ///
        /// </summary>
        void Test206()
        {

        }



        ///<summary>
        ///
        /// </summary>
        void Test207()
        {

        }



        ///<summary>
        ///
        /// </summary>
        void Test208()
        {

        }



        ///<summary>
        ///
        /// </summary>
        void Test209()
        {

        }



        ///<summary>
        ///
        /// </summary>
        void Test210()
        {

        }



        ///<summary>
        ///
        /// </summary>
        void Test211()
        {

        }



        ///<summary>
        ///
        /// </summary>
        void Test212()
        {

        }



        ///<summary>
        ///
        /// </summary>
        void Test213()
        {

        }



        ///<summary>
        ///
        /// </summary>
        void Test214()
        {

        }



        ///<summary>
        ///
        /// </summary>
        void Test215()
        {

        }



        ///<summary>
        ///
        /// </summary>
        void Test216()
        {

        }



        ///<summary>
        ///
        /// </summary>
        void Test217()
        {

        }



        ///<summary>
        ///
        /// </summary>
        void Test218()
        {

        }



        ///<summary>
        ///
        /// </summary>
        void Test219()
        {

        }



        ///<summary>
        ///
        /// </summary>
        void Test220()
        {

        }



        ///<summary>
        ///
        /// </summary>
        void Test221()
        {

        }



        ///<summary>
        ///
        /// </summary>
        void Test222()
        {

        }



        ///<summary>
        ///
        /// </summary>
        void Test223()
        {

        }



        ///<summary>
        ///
        /// </summary>
        void Test224()
        {

        }



        ///<summary>
        ///
        /// </summary>
        void Test225()
        {

        }



        ///<summary>
        ///
        /// </summary>
        void Test226()
        {

        }



        ///<summary>
        ///
        /// </summary>
        void Test227()
        {

        }



        ///<summary>
        ///
        /// </summary>
        void Test228()
        {

        }



        ///<summary>
        ///
        /// </summary>
        void Test229()
        {

        }



        ///<summary>
        ///
        /// </summary>
        void Test230()
        {

        }



        ///<summary>
        ///
        /// </summary>
        void Test231()
        {

        }



        ///<summary>
        ///
        /// </summary>
        void Test232()
        {

        }



        ///<summary>
        ///
        /// </summary>
        void Test233()
        {

        }



        ///<summary>
        ///
        /// </summary>
        void Test234()
        {

        }



        ///<summary>
        ///
        /// </summary>
        void Test235()
        {

        }



        ///<summary>
        ///
        /// </summary>
        void Test236()
        {

        }



        ///<summary>
        ///
        /// </summary>
        void Test237()
        {

        }



        ///<summary>
        ///
        /// </summary>
        void Test238()
        {

        }



        ///<summary>
        ///
        /// </summary>
        void Test239()
        {

        }



        ///<summary>
        ///
        /// </summary>
        void Test240()
        {

        }



        ///<summary>
        ///
        /// </summary>
        void Test241()
        {

        }



        ///<summary>
        ///
        /// </summary>
        void Test242()
        {

        }



        ///<summary>
        ///
        /// </summary>
        void Test243()
        {

        }



        ///<summary>
        ///
        /// </summary>
        void Test244()
        {

        }



        ///<summary>
        ///
        /// </summary>
        void Test245()
        {

        }



        ///<summary>
        ///
        /// </summary>
        void Test246()
        {

        }



        ///<summary>
        ///
        /// </summary>
        void Test247()
        {

        }



        ///<summary>
        ///
        /// </summary>
        void Test248()
        {

        }



        ///<summary>
        ///
        /// </summary>
        void Test249()
        {

        }



        ///<summary>
        ///
        /// </summary>
        void Test250()
        {

        }



        ///<summary>
        ///
        /// </summary>
        void Test251()
        {

        }



        ///<summary>
        ///
        /// </summary>
        void Test252()
        {

        }



        ///<summary>
        ///
        /// </summary>
        void Test253()
        {

        }



        ///<summary>
        ///
        /// </summary>
        void Test254()
        {

        }



        ///<summary>
        ///
        /// </summary>
        void Test255()
        {

        }



        ///<summary>
        ///
        /// </summary>
        void Test256()
        {

        }



        ///<summary>
        ///
        /// </summary>
        void Test257()
        {

        }



        ///<summary>
        ///
        /// </summary>
        void Test258()
        {

        }



        ///<summary>
        ///
        /// </summary>
        void Test259()
        {

        }



        ///<summary>
        ///
        /// </summary>
        void Test260()
        {

        }



        ///<summary>
        ///
        /// </summary>
        void Test261()
        {

        }



        ///<summary>
        ///
        /// </summary>
        void Test262()
        {

        }



        ///<summary>
        ///
        /// </summary>
        void Test263()
        {

        }



        ///<summary>
        ///
        /// </summary>
        void Test264()
        {

        }



        ///<summary>
        ///
        /// </summary>
        void Test265()
        {

        }



        ///<summary>
        ///
        /// </summary>
        void Test266()
        {

        }



        ///<summary>
        ///
        /// </summary>
        void Test267()
        {

        }



        ///<summary>
        ///
        /// </summary>
        void Test268()
        {

        }



        ///<summary>
        ///
        /// </summary>
        void Test269()
        {

        }



        ///<summary>
        ///
        /// </summary>
        void Test270()
        {

        }



        ///<summary>
        ///
        /// </summary>
        void Test271()
        {

        }



        ///<summary>
        ///
        /// </summary>
        void Test272()
        {

        }



        ///<summary>
        ///
        /// </summary>
        void Test273()
        {

        }



        ///<summary>
        ///
        /// </summary>
        void Test274()
        {

        }



        ///<summary>
        ///
        /// </summary>
        void Test275()
        {

        }



        ///<summary>
        ///
        /// </summary>
        void Test276()
        {

        }



        ///<summary>
        ///
        /// </summary>
        void Test277()
        {

        }



        ///<summary>
        ///
        /// </summary>
        void Test278()
        {

        }



        ///<summary>
        ///
        /// </summary>
        void Test279()
        {

        }



        ///<summary>
        ///
        /// </summary>
        void Test280()
        {

        }



        ///<summary>
        ///
        /// </summary>
        void Test281()
        {

        }



        ///<summary>
        ///
        /// </summary>
        void Test282()
        {

        }



        ///<summary>
        ///
        /// </summary>
        void Test283()
        {

        }



        ///<summary>
        ///
        /// </summary>
        void Test284()
        {

        }



        ///<summary>
        ///
        /// </summary>
        void Test285()
        {

        }



        ///<summary>
        ///
        /// </summary>
        void Test286()
        {

        }



        ///<summary>
        ///
        /// </summary>
        void Test287()
        {

        }



        ///<summary>
        ///
        /// </summary>
        void Test288()
        {

        }



        ///<summary>
        ///
        /// </summary>
        void Test289()
        {

        }



        ///<summary>
        ///
        /// </summary>
        void Test290()
        {

        }



        ///<summary>
        ///
        /// </summary>
        void Test291()
        {

        }



        ///<summary>
        ///
        /// </summary>
        void Test292()
        {

        }



        ///<summary>
        ///
        /// </summary>
        void Test293()
        {

        }



        ///<summary>
        ///
        /// </summary>
        void Test294()
        {

        }



        ///<summary>
        ///
        /// </summary>
        void Test295()
        {

        }



        ///<summary>
        ///
        /// </summary>
        void Test296()
        {

        }



        ///<summary>
        ///
        /// </summary>
        void Test297()
        {

        }



        ///<summary>
        ///
        /// </summary>
        void Test298()
        {

        }



        ///<summary>
        ///
        /// </summary>
        void Test299()
        {

        }



        ///<summary>
        ///
        /// </summary>
        void Test300()
        {

        }

    }
}
