using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using testCodeInWebbyToR.Ext;
using TORServices.Forms;
using System.Xml;
namespace testCodeInWebbyToR.html_agility_pack
{
    internal class frm001:frmBase
    {
        public frm001()
        {
            Load += (o, e) =>
            {
               /* for (int i = 1; i <= 300; i++)
                {
                    richTextBox1.WriteLine("///<summary>\r\n        ///\r\n        /// </summary>\r\n        void Test" + i.ToString("000") + "()\r\n        {\r\n\r\n        }\n\n\n");

                }*/


                Task.Factory.StartNew(Test001_001);
            };
        }
        /*
         
          Action<HtmlNode> DisplayChildNodes = (nodeElement) => { };
            Action<HtmlNode> DisplayNode = (node) => { };
         */


        ///<summary>
        ///https://html-agility-pack.net/from-web
        ///https://dotnetfiddle.net/Vtwi7g
        /// </summary>
        void Test001()
        {
            
            var html = @"https://html-agility-pack.net/";
            HtmlWeb web = new HtmlWeb();
            var htmlDoc = web.Load(html);
            var node = htmlDoc.DocumentNode.SelectSingleNode("//head/title");
           richTextBox1.WriteLine("Node Name: " + node.Name + "\n" + node.OuterHtml);

        }

        void Test001_001()
        {

            var html = @"http://www.chemicalbook.com/ProductCatalog_EN/12.htm";
            HtmlWeb web = new HtmlWeb();
            var htmlDoc = web.Load(html);
            var node = htmlDoc.DocumentNode.SelectSingleNode("//head/title");
            if(node!=null)
            richTextBox1.WriteLine("Node Name: " + node.Name + "\n" + node.OuterHtml);

        }

        ///<summary>
        ///https://html-agility-pack.net/select-nodes
        ///https://dotnetfiddle.net/ozk9kE
        /// </summary>
        void Test002()
        {
            var html =
        @"<TD class=texte width=""50%"">
			<DIV align=right>Name :<B> </B></DIV>
		</TD>
		<TD width=""50%"">
    		<INPUT class=box value=John maxLength=16 size=16 name=user_name>
    		<INPUT class=box value=Tony maxLength=16 size=16 name=user_name>
    		<INPUT class=box value=Jams maxLength=16 size=16 name=user_name>
		</TD>
		<TR vAlign=center>";

            var htmlDoc = new HtmlDocument();
            htmlDoc.LoadHtml(html);

            var htmlNodes = htmlDoc.DocumentNode.SelectNodes("//td/input");

            foreach (var node in htmlNodes)
            {

                richTextBox1.WriteLine(node.Attributes["value"].Value + " " + node.Attributes["maxLength"].Value);
            }
        }



        ///<summary>
        ///https://html-agility-pack.net/select-single-node
        ///https://dotnetfiddle.net/KHzARJ
        /// </summary>
        void Test003()
        {
            var html =
        @"<TD class=texte width=""50%"">
			<DIV align=right>Name :<B> </B></DIV>
		</TD>
		<TD width=""50%"">
    		<INPUT class=box value=John maxLength=16 size=16 name=user_name>
    		<INPUT class=box value=Tony maxLength=16 size=16 name=user_name>
    		<INPUT class=box value=Jams maxLength=16 size=16 name=user_name>
		</TD>
		<TR vAlign=center>";

            var htmlDoc = new HtmlDocument();
            htmlDoc.LoadHtml(html);

            string name = htmlDoc.DocumentNode
                .SelectSingleNode("//td/input")
                .Attributes["value"].Value;

            richTextBox1.WriteLine(name);
        }



        ///<summary>
        ///https://html-agility-pack.net/inner-html
        ///https://dotnetfiddle.net/B0JkGV
        /// </summary>
        void Test004()
        {
            var html =
        @"<body>
            <h1>This is <b>bold</b> heading</h1>
            <p>This is <u>underlined</u> paragraph</p>
			
			<h1>This is <i>italic</i> heading</h1>
			<p>This is <u>underlined</u> paragraph</p>
        </body>";

            var htmlDoc = new HtmlDocument();
            htmlDoc.LoadHtml(html);

            var htmlNodes = htmlDoc.DocumentNode.SelectNodes("//body/h1");

            foreach (var node in htmlNodes)
            {

                richTextBox1.WriteLine(node.InnerHtml);

            }
        }



        ///<summary>
        ///https://html-agility-pack.net/inner-text
        ///https://dotnetfiddle.net/2wxxi9
        /// </summary>
        void Test005()
        {
            var html =
        @"<body>
            <h1>This is <b>bold</b> heading</h1>
            <p>This is <u>underlined</u> paragraph</p>
			
			<h1>This is <i>italic</i> heading</h1>
			<p>This is <u>underlined</u> paragraph</p>
        </body>";

            var htmlDoc = new HtmlDocument();
            htmlDoc.LoadHtml(html);

            var htmlNodes = htmlDoc.DocumentNode.SelectNodes("//body/h1");

            foreach (var node in htmlNodes)
            {
                richTextBox1.WriteLine(node.InnerText);

            }
        }



        ///<summary>
        ///https://html-agility-pack.net/outer-html
        ///https://dotnetfiddle.net/By222n
        /// </summary>
        void Test006()
        {
            var html =
        @"<body>
            <h1>This is <b>bold</b> heading</h1>
            <p>This is <u>underlined</u> paragraph</p>
			
			<h1>This is <i>italic</i> heading</h1>
			<p>This is <u>underlined</u> paragraph</p>
        </body>";

            var htmlDoc = new HtmlDocument();
            htmlDoc.LoadHtml(html);

            var htmlNodes = htmlDoc.DocumentNode.SelectNodes("//body/h1");

            foreach (var node in htmlNodes)
            {
                richTextBox1.WriteLine(node.OuterHtml);
            }
        }



        ///<summary>
        ///https://html-agility-pack.net/parent-node
        ///https://dotnetfiddle.net/BHfJdM
        /// </summary>
        void Test007()
        {
            var html =
        @"<body>
            <h1>This is <b>bold</b> heading</h1>
            <p>This is <u>underlined</u> paragraph</p>
        </body>";

            var htmlDoc = new HtmlDocument();
            htmlDoc.LoadHtml(html);

            var node = htmlDoc.DocumentNode.SelectSingleNode("//body/h1");

            HtmlNode parentNode = node.ParentNode;

            richTextBox1.WriteLine(parentNode.Name);
        }



        ///<summary>
        ///https://html-agility-pack.net/append-child
        ///https://dotnetfiddle.net/ANYiid
        /// </summary>
        void Test008()
        {
            var html =
        @"<body>
            <h1>This is <b>bold</b> heading</h1>
            <p>This is <u>underlined</u> paragraph</p>
        </body>";

            Action<HtmlNode> DisplayChildNodes = (nodeElement) =>
            {
                HtmlNodeCollection childNodes = nodeElement.ChildNodes;

                foreach (var node in childNodes)
                {
                    if (node.NodeType == HtmlNodeType.Element)
                    {
                        richTextBox1.WriteLine(node.Name);
                    }
                }
            };
            var htmlDoc = new HtmlDocument();
            htmlDoc.LoadHtml(html);

            var htmlBody = htmlDoc.DocumentNode.SelectSingleNode("//body");

            DisplayChildNodes(htmlBody);

            HtmlNode h2Node = HtmlNode.CreateNode("<h2> This is h2 heading</h2>");

            htmlBody.AppendChild(h2Node);

            richTextBox1.WriteLine("\n****After child node appended****\n");

            DisplayChildNodes(htmlBody);
        }



        ///<summary>
        ///https://html-agility-pack.net/append-children
        ///https://dotnetfiddle.net/zSLsQB
        /// </summary>
        void Test009()
        {
            var html =
        @"<body>
            <h1>This is <b>bold</b> heading</h1>
            <p>This is <u>underlined</u> paragraph</p>
        </body>";
            Action<HtmlNode> DisplayChildNodes = (nodeElement) =>
            {
                HtmlNodeCollection childNodes = nodeElement.ChildNodes;

                foreach (var node in childNodes)
                {
                    if (node.NodeType == HtmlNodeType.Element)
                    {
                        richTextBox1.WriteLine(node.InnerText);
                    }
                }
            };
            var htmlDoc = new HtmlDocument();
            htmlDoc.LoadHtml(html);

            var htmlBody = htmlDoc.DocumentNode.SelectSingleNode("//body");

            DisplayChildNodes(htmlBody);

            HtmlNode h2Node = HtmlNode.CreateNode("<h2> This is h2 heading</h2>");
            HtmlNode pNode1 = HtmlNode.CreateNode("<p> This is appended paragraph 1</p>");
            HtmlNode pNode2 = HtmlNode.CreateNode("<p> This is appended paragraph 2</p>");

            HtmlNodeCollection children = new HtmlNodeCollection(htmlBody);

            children.Add(h2Node);
            children.Add(pNode1);
            children.Add(pNode2);

            htmlBody.AppendChildren(children);

            richTextBox1.WriteLine("\n****After children appended****\n");

            DisplayChildNodes(htmlBody);
        }



        ///<summary>
        ///https://html-agility-pack.net/clone
        ///https://dotnetfiddle.net/E5Ohlu
        /// </summary>
        void Test010()
        {
            var html =
        @"<body>
            <h1>This is <b>bold</b> heading</h1>
            <p>This is <u>underlined</u> paragraph</p>
        </body>";
            Action<HtmlNode> DisplayChildNodes = (nodeElement) =>
            {
                HtmlNodeCollection childNodes = nodeElement.ChildNodes;

                foreach (var node in childNodes)
                {
                    if (node.NodeType == HtmlNodeType.Element)
                    {
                        richTextBox1.WriteLine(node.InnerText);
                    }
                }
            };
            var htmlDoc = new HtmlDocument();
            htmlDoc.LoadHtml(html);

            var htmlBody = htmlDoc.DocumentNode.SelectSingleNode("//body");

            DisplayChildNodes(htmlBody);

            HtmlNode newHtmlBody = htmlBody.Clone();

            richTextBox1.WriteLine("\nDuplicate Node Name: " + newHtmlBody.Name);

            richTextBox1.WriteLine("\n****Display children of the duplicate node****\n");

            DisplayChildNodes(newHtmlBody);
        }



        ///<summary>
        ///https://html-agility-pack.net/clone-node
        ///https://dotnetfiddle.net/ETUR7Y
        /// </summary>
        void Test011()
        {
            var html =
        @"<body>
            <h1>This is <b>bold</b> heading</h1>
            <p>This is <u>underlined</u> paragraph</p>
        </body>";
            Action<HtmlNode> DisplayChildNodes = (nodeElement) =>
            {
                HtmlNodeCollection childNodes = nodeElement.ChildNodes;

                if (childNodes.Count == 0)
                {
                    richTextBox1.WriteLine(nodeElement.Name + " has no children");
                }
                else
                {

                    foreach (var node in childNodes)
                    {
                        if (node.NodeType == HtmlNodeType.Element)
                        {
                            richTextBox1.WriteLine(node.InnerText);
                        }
                    }
                }
            };
            var htmlDoc = new HtmlDocument();
            htmlDoc.LoadHtml(html);

            var htmlBody = htmlDoc.DocumentNode.SelectSingleNode("//body");

            DisplayChildNodes(htmlBody);

            HtmlNode newHtmlBody = htmlBody.CloneNode(false);

            richTextBox1.WriteLine("\nClone Node Name: " + newHtmlBody.Name);

            richTextBox1.WriteLine("\n****Display children of the clone node****\n");

            DisplayChildNodes(newHtmlBody);
        }



        ///<summary>
        ///https://html-agility-pack.net/clone-node
        /// https://dotnetfiddle.net/2bK3FZ
        /// </summary>
        void Test012()
        {
            var html =
        @"<body>
            <h1>This is <b>bold</b> heading</h1>
            <p>This is <u>underlined</u> paragraph</p>
        </body>";

            Action<HtmlNode> DisplayChildNodes = (nodeElement) => {
                HtmlNodeCollection childNodes = nodeElement.ChildNodes;

                if (childNodes.Count == 0)
                {
                    richTextBox1.WriteLine(nodeElement.Name + " has no children");
                }
                else
                {

                    foreach (var node in childNodes)
                    {
                        if (node.NodeType == HtmlNodeType.Element)
                        {
                            richTextBox1.WriteLine(node.OuterHtml);
                        }
                    }
                }
            };
            Action<HtmlNode> DisplayNode = (node) =>
            {
                richTextBox1.WriteLine("Node Name: " + node.Name + "\n" + node.OuterHtml);

                richTextBox1.Write("\n" + node.Name + " children:\n");

                DisplayChildNodes(node);
            };
            var htmlDoc = new HtmlDocument();
            htmlDoc.LoadHtml(html);

            var htmlBody = htmlDoc.DocumentNode.SelectSingleNode("//body");

            HtmlNode h1Node = htmlBody.ChildNodes[1];

            DisplayNode(h1Node);

            HtmlNode h2Node = h1Node.CloneNode("h2");

            richTextBox1.WriteLine("\n****Clone node****\n");

            DisplayNode(h2Node);
        }



        ///<summary>
        ///https://html-agility-pack.net/clone-node
        ///https://dotnetfiddle.net/gblMur
        /// </summary>
        void Test013()
        {
            var html =
        @"<body>
            <h1>This is <b>bold</b> heading</h1>
            <p>This is <u>underlined</u> paragraph</p>
        </body>";
            Action<HtmlNode> DisplayChildNodes = (nodeElement) => {
                HtmlNodeCollection childNodes = nodeElement.ChildNodes;

                if (childNodes.Count == 0)
                {
                    richTextBox1.WriteLine(nodeElement.Name + " has no children");
                }
                else
                {

                    foreach (var node in childNodes)
                    {
                        if (node.NodeType == HtmlNodeType.Element)
                        {
                            richTextBox1.WriteLine(node.OuterHtml);
                        }
                    }
                }
            };
            Action<HtmlNode> DisplayNode = (node) =>
            {
                richTextBox1.WriteLine("Node Name: " + node.Name + "\n" + node.OuterHtml);

                richTextBox1.Write("\n" + node.Name + " children:\n");

                DisplayChildNodes(node);
            };
            var htmlDoc = new HtmlDocument();
            htmlDoc.LoadHtml(html);

            var htmlBody = htmlDoc.DocumentNode.SelectSingleNode("//body");

            HtmlNode h1Node = htmlBody.ChildNodes[1];

            DisplayNode(h1Node);

            HtmlNode h2Node = h1Node.CloneNode("h2", false);

            richTextBox1.WriteLine("\n****Clone node****\n");

            DisplayNode(h2Node);
        }



        ///<summary>
        ///https://html-agility-pack.net/clone-node#public-htmlnode-clonenodestring-newname
        ///https://dotnetfiddle.net/ETUR7Y
        /// </summary>
        void Test014()
        {
            var html =
        @"<body>
            <h1>This is <b>bold</b> heading</h1>
            <p>This is <u>underlined</u> paragraph</p>
        </body>";
            Action<HtmlNode> DisplayChildNodes = (nodeElement) =>
            {
                HtmlNodeCollection childNodes = nodeElement.ChildNodes;

                if (childNodes.Count == 0)
                {
                    richTextBox1.WriteLine(nodeElement.Name + " has no children");
                }
                else
                {

                    foreach (var node in childNodes)
                    {
                        if (node.NodeType == HtmlNodeType.Element)
                        {
                            richTextBox1.WriteLine(node.InnerText);
                        }
                    }
                }

            };
            var htmlDoc = new HtmlDocument();
            htmlDoc.LoadHtml(html);

            var htmlBody = htmlDoc.DocumentNode.SelectSingleNode("//body");

            DisplayChildNodes(htmlBody);

            HtmlNode newHtmlBody = htmlBody.CloneNode(false);

            richTextBox1.WriteLine("\nClone Node Name: " + newHtmlBody.Name);

            richTextBox1.WriteLine("\n****Display children of the clone node****\n");

            DisplayChildNodes(newHtmlBody);
        }



        ///<summary>
        ///https://html-agility-pack.net/clone-node#public-htmlnode-clonenodestring-newname
        ///https://dotnetfiddle.net/2bK3FZ
        /// </summary>
        void Test015()
        {
            var html =
        @"<body>
            <h1>This is <b>bold</b> heading</h1>
            <p>This is <u>underlined</u> paragraph</p>
        </body>";

            Action<HtmlNode> DisplayChildNodes = (nodeElement) => {
                HtmlNodeCollection childNodes = nodeElement.ChildNodes;

                if (childNodes.Count == 0)
                {
                    richTextBox1.WriteLine(nodeElement.Name + " has no children");
                }
                else
                {

                    foreach (var node in childNodes)
                    {
                        if (node.NodeType == HtmlNodeType.Element)
                        {
                            richTextBox1.WriteLine(node.OuterHtml);
                        }
                    }
                }
            };
            Action<HtmlNode> DisplayNode = (node) => {
                richTextBox1.WriteLine("Node Name: " + node.Name + "\n" + node.OuterHtml);

                richTextBox1.Write("\n" + node.Name + " children:\n");

                DisplayChildNodes(node);
            };
            var htmlDoc = new HtmlDocument();
            htmlDoc.LoadHtml(html);

            var htmlBody = htmlDoc.DocumentNode.SelectSingleNode("//body");

            HtmlNode h1Node = htmlBody.ChildNodes[1];

            DisplayNode(h1Node);

            HtmlNode h2Node = h1Node.CloneNode("h2");

            richTextBox1.WriteLine("\n****Clone node****\n");

            DisplayNode(h2Node);
        }



        ///<summary>
        ///https://html-agility-pack.net/clone-node#public-htmlnode-clonenodestring-newname
        ///https://dotnetfiddle.net/gblMur
        /// </summary>
        void Test016()
        {
            var html =
        @"<body>
            <h1>This is <b>bold</b> heading</h1>
            <p>This is <u>underlined</u> paragraph</p>
        </body>";
            Action<HtmlNode> DisplayChildNodes = (nodeElement) => {
                HtmlNodeCollection childNodes = nodeElement.ChildNodes;

                if (childNodes.Count == 0)
                {
                    richTextBox1.WriteLine(nodeElement.Name + " has no children");
                }
                else
                {

                    foreach (var node in childNodes)
                    {
                        if (node.NodeType == HtmlNodeType.Element)
                        {
                            richTextBox1.WriteLine(node.OuterHtml);
                        }
                    }
                }
            };
            Action<HtmlNode> DisplayNode = (node) => {
                richTextBox1.WriteLine("Node Name: " + node.Name + "\n" + node.OuterHtml);

                richTextBox1.Write("\n" + node.Name + " children:\n");

                DisplayChildNodes(node);
            };

            var htmlDoc = new HtmlDocument();
            htmlDoc.LoadHtml(html);

            var htmlBody = htmlDoc.DocumentNode.SelectSingleNode("//body");

            HtmlNode h1Node = htmlBody.ChildNodes[1];

            DisplayNode(h1Node);

            HtmlNode h2Node = h1Node.CloneNode("h2", false);

            richTextBox1.WriteLine("\n****Clone node****\n");

            DisplayNode(h2Node);
        }



        ///<summary>
        ///https://html-agility-pack.net/clone-node#public-htmlnode-clonenodestring-newname-bool-deep
        ///https://dotnetfiddle.net/gblMur
        /// </summary>
        void Test017()
        {
            var html =
        @"<body>
            <h1>This is <b>bold</b> heading</h1>
            <p>This is <u>underlined</u> paragraph</p>
        </body>";
            Action<HtmlNode> DisplayChildNodes = (nodeElement) => {
                HtmlNodeCollection childNodes = nodeElement.ChildNodes;

                if (childNodes.Count == 0)
                {
                    richTextBox1.WriteLine(nodeElement.Name + " has no children");
                }
                else
                {

                    foreach (var node in childNodes)
                    {
                        if (node.NodeType == HtmlNodeType.Element)
                        {
                            richTextBox1.WriteLine(node.OuterHtml);
                        }
                    }
                }
            };
            Action<HtmlNode> DisplayNode = (node) => {
                richTextBox1.WriteLine("Node Name: " + node.Name + "\n" + node.OuterHtml);

                richTextBox1.Write("\n" + node.Name + " children:\n");

                DisplayChildNodes(node);
            };
            var htmlDoc = new HtmlDocument();
            htmlDoc.LoadHtml(html);

            var htmlBody = htmlDoc.DocumentNode.SelectSingleNode("//body");

            HtmlNode h1Node = htmlBody.ChildNodes[1];

            DisplayNode(h1Node);

            HtmlNode h2Node = h1Node.CloneNode("h2", false);

            richTextBox1.WriteLine("\n****Clone node****\n");

            DisplayNode(h2Node);
        }



        ///<summary>
        ///https://html-agility-pack.net/copy-from
        ///https://dotnetfiddle.net/DxhdH3
        /// </summary>
        void Test018()
        {
            var html =
        @"<body>
            <h1>This is <b>bold</b> heading</h1>
            <p>This is <u>underlined</u> paragraph</p>
        </body>";
            Action<HtmlNode> DisplayChildNodes = (nodeElement) => {
                HtmlNodeCollection childNodes = nodeElement.ChildNodes;

                if (childNodes.Count == 0)
                {
                    richTextBox1.WriteLine(nodeElement.Name + " has no children");
                }
                else
                {

                    foreach (var node in childNodes)
                    {
                        if (node.NodeType == HtmlNodeType.Element)
                        {
                            richTextBox1.WriteLine(node.OuterHtml);
                        }
                    }
                }
            };
            Action<HtmlNode> DisplayNode = (node) => {
                richTextBox1.WriteLine("Node Name: " + node.Name);

                richTextBox1.Write("\n" + node.Name + " children:\n");

                DisplayChildNodes(node);
            };
            var htmlDoc = new HtmlDocument();
            htmlDoc.LoadHtml(html);

            var htmlBody = htmlDoc.DocumentNode.SelectSingleNode("//body");

            HtmlNode newBody = HtmlNode.CreateNode("<body></body>");

            newBody.CopyFrom(htmlBody);

            DisplayNode(htmlBody);

            richTextBox1.WriteLine("\n****Duplicate node****\n");

            DisplayNode(newBody);

        }



        ///<summary>
        ///https://html-agility-pack.net/copy-from
        ///https://dotnetfiddle.net/9PBQqs
        /// </summary>
        void Test019()
        {
            var html =
        @"<body>
            <h1>This is <b>bold</b> heading</h1>
            <p>This is <u>underlined</u> paragraph</p>
        </body>";
            Action<HtmlNode> DisplayChildNodes = (nodeElement) => {
                HtmlNodeCollection childNodes = nodeElement.ChildNodes;

                if (childNodes.Count == 0)
                {
                    richTextBox1.WriteLine(nodeElement.Name + " has no children");
                }
                else
                {

                    foreach (var node in childNodes)
                    {
                        if (node.NodeType == HtmlNodeType.Element)
                        {
                            richTextBox1.WriteLine(node.OuterHtml);
                        }
                    }
                }
            };
            Action<HtmlNode> DisplayNode = (node) => {
                richTextBox1.WriteLine("Node Name: " + node.Name);

                richTextBox1.Write("\n" + node.Name + " children:\n");

                DisplayChildNodes(node);
            };
            var htmlDoc = new HtmlDocument();
            htmlDoc.LoadHtml(html);

            var htmlBody = htmlDoc.DocumentNode.SelectSingleNode("//body");

            HtmlNode newBody = HtmlNode.CreateNode("<body></body>");

            newBody.CopyFrom(htmlBody, false);

            DisplayNode(htmlBody);

            richTextBox1.WriteLine("\n****Duplicate node****\n");

            DisplayNode(newBody);
        }



        ///<summary>
        ///https://html-agility-pack.net/copy-from#public-htmlnode-copyfromhtmlnode-node-bool-deep
        ///https://dotnetfiddle.net/DxhdH3
        /// </summary>
        void Test020()
        {
            var html =
        @"<body>
            <h1>This is <b>bold</b> heading</h1>
            <p>This is <u>underlined</u> paragraph</p>
        </body>";
            Action<HtmlNode> DisplayChildNodes = (nodeElement) => {
                HtmlNodeCollection childNodes = nodeElement.ChildNodes;

                if (childNodes.Count == 0)
                {
                    richTextBox1.WriteLine(nodeElement.Name + " has no children");
                }
                else
                {

                    foreach (var node in childNodes)
                    {
                        if (node.NodeType == HtmlNodeType.Element)
                        {
                            richTextBox1.WriteLine(node.OuterHtml);
                        }
                    }
                }
            };
            Action<HtmlNode> DisplayNode = (node) => {
                richTextBox1.WriteLine("Node Name: " + node.Name);

                richTextBox1.Write("\n" + node.Name + " children:\n");

                DisplayChildNodes(node);
            };
            var htmlDoc = new HtmlDocument();
            htmlDoc.LoadHtml(html);

            var htmlBody = htmlDoc.DocumentNode.SelectSingleNode("//body");

            HtmlNode newBody = HtmlNode.CreateNode("<body></body>");

            newBody.CopyFrom(htmlBody);

            DisplayNode(htmlBody);

            richTextBox1.WriteLine("\n****Duplicate node****\n");

            DisplayNode(newBody);
        }



        ///<summary>
        ///https://html-agility-pack.net/copy-from#public-htmlnode-copyfromhtmlnode-node-bool-deep
        ///https://dotnetfiddle.net/9PBQqs
        /// </summary>
        void Test021()
        {
            Action<HtmlNode> DisplayChildNodes = (nodeElement) => {
                HtmlNodeCollection childNodes = nodeElement.ChildNodes;

                if (childNodes.Count == 0)
                {
                    richTextBox1.WriteLine(nodeElement.Name + " has no children");
                }
                else
                {

                    foreach (var node in childNodes)
                    {
                        if (node.NodeType == HtmlNodeType.Element)
                        {
                            richTextBox1.WriteLine(node.OuterHtml);
                        }
                    }
                }
            };
            Action<HtmlNode> DisplayNode = (node) => {
                richTextBox1.WriteLine("Node Name: " + node.Name);

                richTextBox1.Write("\n" + node.Name + " children:\n");

                DisplayChildNodes(node);
            };
            var html =
        @"<body>
            <h1>This is <b>bold</b> heading</h1>
            <p>This is <u>underlined</u> paragraph</p>
        </body>";

            var htmlDoc = new HtmlDocument();
            htmlDoc.LoadHtml(html);

            var htmlBody = htmlDoc.DocumentNode.SelectSingleNode("//body");

            HtmlNode newBody = HtmlNode.CreateNode("<body></body>");

            newBody.CopyFrom(htmlBody, false);

            DisplayNode(htmlBody);

            richTextBox1.WriteLine("\n****Duplicate node****\n");

            DisplayNode(newBody);
        }



        ///<summary>
        ///https://html-agility-pack.net/create-node
        ///https://dotnetfiddle.net/0GtVim
        /// </summary>
        void Test022()
        {
            var html =
        @"<body>
            <h1>This is <b>bold</b> heading</h1>
            <p>This is <u>underlined</u> paragraph</p>
        </body>";
            Action<HtmlNode> DisplayChildNodes = (nodeElement) => {
                HtmlNodeCollection childNodes = nodeElement.ChildNodes;

                if (childNodes.Count == 0)
                {
                    richTextBox1.WriteLine(nodeElement.Name + " has no children");
                }
                else
                {

                    foreach (var node in childNodes)
                    {
                        if (node.NodeType == HtmlNodeType.Element)
                        {
                            richTextBox1.WriteLine(node.OuterHtml);
                        }
                    }
                }
            };
            Action<HtmlNode> DisplayNode = (node) => {
                richTextBox1.WriteLine("Node Name: " + node.Name);

                richTextBox1.Write("\n" + node.Name + " children:\n");

                DisplayChildNodes(node);
            };
            var htmlDoc = new HtmlDocument();
            htmlDoc.LoadHtml(html);

            var htmlBody = htmlDoc.DocumentNode.SelectSingleNode("//body");

            DisplayNode(htmlBody);

            HtmlNode newPara = HtmlNode.CreateNode("<p>This a new paragraph</p>");

            htmlBody.ChildNodes.Add(newPara);

            richTextBox1.WriteLine("\n****After adding new child node****\n");

            DisplayNode(htmlBody);
        }



        ///<summary>
        ///https://html-agility-pack.net/insert-after
        ///https://dotnetfiddle.net/cWpYzz
        /// </summary>
        void Test023()
        {
            var html =
        @"<body>
            <h1>This is <b>bold</b> heading</h1>
            <p>This is <u>underlined</u> paragraph</p>
        </body>";
            Action<HtmlNode> DisplayChildNodes = (nodeElement) => {
                HtmlNodeCollection childNodes = nodeElement.ChildNodes;

                if (childNodes.Count == 0)
                {
                    richTextBox1.WriteLine(nodeElement.Name + " has no children");
                }
                else
                {

                    foreach (var node in childNodes)
                    {
                        if (node.NodeType == HtmlNodeType.Element)
                        {
                            richTextBox1.WriteLine(node.OuterHtml);
                        }
                    }
                }
            };
            Action<HtmlNode> DisplayNode = (node) => {
                richTextBox1.WriteLine("Node Name: " + node.Name);

                richTextBox1.Write("\n" + node.Name + " children:\n");

                DisplayChildNodes(node);
            };
            var htmlDoc = new HtmlDocument();
            htmlDoc.LoadHtml(html);

            var htmlBody = htmlDoc.DocumentNode.SelectSingleNode("//body");

            HtmlNode refChild = htmlBody.ChildNodes[1];

            HtmlNode newChild = HtmlNode.CreateNode("<p> This is inserted after node paragraph</p>");

            DisplayNode(htmlBody);

            htmlBody.InsertAfter(newChild, refChild);

            richTextBox1.WriteLine("\n****Node inserted after first child****\n");

            DisplayNode(htmlBody);
        }



        ///<summary>
        ///https://html-agility-pack.net/insert-before
        ///https://dotnetfiddle.net/bgeDoP
        /// </summary>
        void Test024()
        {
            var html =
        @"<body>
            <h1>This is <b>bold</b> heading</h1>
            <p>This is <u>underlined</u> paragraph</p>
        </body>";
            Action<HtmlNode> DisplayChildNodes = (nodeElement) => {
                HtmlNodeCollection childNodes = nodeElement.ChildNodes;

                if (childNodes.Count == 0)
                {
                    richTextBox1.WriteLine(nodeElement.Name + " has no children");
                }
                else
                {

                    foreach (var node in childNodes)
                    {
                        if (node.NodeType == HtmlNodeType.Element)
                        {
                            richTextBox1.WriteLine(node.OuterHtml);
                        }
                    }
                }
            };
            Action<HtmlNode> DisplayNode = (node) => {
                richTextBox1.WriteLine("Node Name: " + node.Name);

                richTextBox1.Write("\n" + node.Name + " children:\n");

                DisplayChildNodes(node);
            };
            var htmlDoc = new HtmlDocument();
            htmlDoc.LoadHtml(html);

            var htmlBody = htmlDoc.DocumentNode.SelectSingleNode("//body");

            HtmlNode refChild = htmlBody.ChildNodes[1];

            HtmlNode newChild = HtmlNode.CreateNode("<h1> This is inserted before node heading</h>");

            DisplayNode(htmlBody);

            htmlBody.InsertBefore(newChild, refChild);

            richTextBox1.WriteLine("\n****Node inserted before first child****\n");

            DisplayNode(htmlBody);
        }



        ///<summary>
        ///https://html-agility-pack.net/prepend-child
        ///https://dotnetfiddle.net/pWFZzv
        /// </summary>
        void Test025()
        {
            var html =
        @"<body>
            <h1>This is <b>bold</b> heading</h1>
            <p>This is <u>underlined</u> paragraph</p>
        </body>";

            var htmlDoc = new HtmlDocument();
            htmlDoc.LoadHtml(html);
            Action<HtmlNode> DisplayChildNodes = (nodeElement) => {
                HtmlNodeCollection childNodes = nodeElement.ChildNodes;

                if (childNodes.Count == 0)
                {
                    richTextBox1.WriteLine(nodeElement.Name + " has no children");
                }
                else
                {

                    foreach (var node in childNodes)
                    {
                        if (node.NodeType == HtmlNodeType.Element)
                        {
                            richTextBox1.WriteLine(node.OuterHtml);
                        }
                    }
                }
            };
            Action<HtmlNode> DisplayNode = (node) => {
                richTextBox1.WriteLine("Node Name: " + node.Name);

                richTextBox1.Write("\n" + node.Name + " children:\n");

                DisplayChildNodes(node);
            };
            var htmlBody = htmlDoc.DocumentNode.SelectSingleNode("//body");


            HtmlNode newChild = HtmlNode.CreateNode("<h1> This is added at the beginning</h>");

            DisplayNode(htmlBody);

            htmlBody.PrependChild(newChild);

            richTextBox1.WriteLine("\n****After prepending child node****\n");

            DisplayNode(htmlBody);
        }



        ///<summary>
        ///https://html-agility-pack.net/prepend-children
        ///https://dotnetfiddle.net/dLgqd0
        /// </summary>
        void Test026()
        {
            var html =
        @"<body>
            <h1>This is <b>bold</b> heading</h1>
            <p>This is <u>underlined</u> paragraph</p>
        </body>";
            Action<HtmlNode> DisplayChildNodes = (nodeElement) => {
                HtmlNodeCollection childNodes = nodeElement.ChildNodes;

                if (childNodes.Count == 0)
                {
                    richTextBox1.WriteLine(nodeElement.Name + " has no children");
                }
                else
                {

                    foreach (var node in childNodes)
                    {
                        if (node.NodeType == HtmlNodeType.Element)
                        {
                            richTextBox1.WriteLine(node.OuterHtml);
                        }
                    }
                }
            };
            Action<HtmlNode> DisplayNode = (node) => {
                richTextBox1.WriteLine("Node Name: " + node.Name);

                richTextBox1.Write("\n" + node.Name + " children:\n");

                DisplayChildNodes(node);
            };
            var htmlDoc = new HtmlDocument();
            htmlDoc.LoadHtml(html);

            var htmlBody = htmlDoc.DocumentNode.SelectSingleNode("//body");

            DisplayNode(htmlBody);

            HtmlNode h1Node = HtmlNode.CreateNode("<h1> This is new heading</h1>");

            HtmlNode pNode = HtmlNode.CreateNode("<p> This is new paragraph 1</p>");

            HtmlNodeCollection newChildren = new HtmlNodeCollection(htmlBody);

            newChildren.Add(pNode);

            newChildren.Add(h1Node);

            htmlBody.PrependChildren(newChildren);

            richTextBox1.WriteLine("\n****After prepending children****\n");

            DisplayNode(htmlBody);
        }



        ///<summary>
        ///https://html-agility-pack.net/remove
        ///https://dotnetfiddle.net/EENTHk
        /// </summary>
        void Test027()
        {
            var html =
        @"<body>
            <h1>This is <b>bold</b> heading</h1>
            <p>This is <u>underlined</u> paragraph</p>
        </body>";
            Action<HtmlNode> DisplayChildNodes = (nodeElement) => {
                HtmlNodeCollection childNodes = nodeElement.ChildNodes;

                if (childNodes.Count == 0)
                {
                    richTextBox1.WriteLine(nodeElement.Name + " has no children");
                }
                else
                {

                    foreach (var _node in childNodes)
                    {
                        if (_node.NodeType == HtmlNodeType.Element)
                        {
                            richTextBox1.WriteLine(_node.OuterHtml);
                        }
                    }
                }
            };
            Action<HtmlNode> DisplayNode = (_node) => {
                richTextBox1.WriteLine("Node Name: " + _node.Name);

                richTextBox1.Write("\n" + _node.Name + " children:\n");

                DisplayChildNodes(_node);
            };
            var htmlDoc = new HtmlDocument();
            htmlDoc.LoadHtml(html);

            var htmlBody = htmlDoc.DocumentNode.SelectSingleNode("//body");

            DisplayNode(htmlBody);

            HtmlNode node = htmlBody.ChildNodes[1];

            node.Remove();

            richTextBox1.WriteLine("\n****After removing a node from parent node****\n");

            DisplayNode(htmlBody);

            richTextBox1.WriteLine("\n****Removed node****\n");

            DisplayNode(node);
        }



        ///<summary>
        ///https://html-agility-pack.net/remove-all
        ///https://dotnetfiddle.net/LFexCy
        /// </summary>
        void Test028()
        {
            var html =
        @"<body>
            <h1>This is <b>bold</b> heading</h1>
            <p>This is <u>underlined</u> paragraph</p>
        </body>";
            Action<HtmlNode> DisplayChildNodes = (nodeElement) => {
                HtmlNodeCollection childNodes = nodeElement.ChildNodes;

                if (childNodes.Count == 0)
                {
                    richTextBox1.WriteLine(nodeElement.Name + " has no children");
                }
                else
                {

                    foreach (var _node in childNodes)
                    {
                        if (_node.NodeType == HtmlNodeType.Element)
                        {
                            richTextBox1.WriteLine(_node.OuterHtml);
                        }
                    }
                }
            };
            Action<HtmlNode> DisplayNode = (_node) => {
                richTextBox1.WriteLine("Node Name: " + _node.Name);

                richTextBox1.Write("\n" + _node.Name + " children:\n");

                DisplayChildNodes(_node);
            };
            var htmlDoc = new HtmlDocument();
            htmlDoc.LoadHtml(html);

            var htmlBody = htmlDoc.DocumentNode.SelectSingleNode("//body");

            DisplayNode(htmlBody);

            HtmlNode node = htmlBody.ChildNodes[1];

            node.RemoveAll();

            richTextBox1.WriteLine("\n****After RemoveAll****\n");

            DisplayNode(htmlBody);

            richTextBox1.WriteLine("\n****Removed node****\n");

            DisplayNode(node);
        }



        ///<summary>
        ///https://html-agility-pack.net/remove-all-children
        ///https://dotnetfiddle.net/aFRmEy
        /// </summary>
        void Test029()
        {
            var html =
        @"<body>
            <h1>This is <b>bold</b> heading</h1>
            <p>This is <u>underlined</u> paragraph</p>
        </body>";
            Action<HtmlNode> DisplayChildNodes = (nodeElement) => {
                HtmlNodeCollection childNodes = nodeElement.ChildNodes;

                if (childNodes.Count == 0)
                {
                    richTextBox1.WriteLine(nodeElement.Name + " has no children");
                }
                else
                {

                    foreach (var node in childNodes)
                    {
                        if (node.NodeType == HtmlNodeType.Element)
                        {
                            richTextBox1.WriteLine(node.OuterHtml);
                        }
                    }
                }
            };
            Action<HtmlNode> DisplayNode = (node) => {
                richTextBox1.WriteLine("Node Name: " + node.Name);

                richTextBox1.Write("\n" + node.Name + " children:\n");

                DisplayChildNodes(node);
            };
            var htmlDoc = new HtmlDocument();
            htmlDoc.LoadHtml(html);

            var htmlBody = htmlDoc.DocumentNode.SelectSingleNode("//body");

            DisplayNode(htmlBody);

            htmlBody.RemoveAllChildren();

            richTextBox1.WriteLine("\n****After removing all children****\n");

            DisplayNode(htmlBody);
        }



        ///<summary>
        ///https://html-agility-pack.net/remove-child
        ///
        /// </summary>
        void Test030()
        {
            var html =
        @"<body>
            <h1>This is <b>bold</b> heading</h1>
            <p>This is <u>underlined</u> paragraph</p>
        </body>";
            Action<HtmlNode> DisplayChildNodes = (nodeElement) => {
                HtmlNodeCollection childNodes = nodeElement.ChildNodes;

                foreach (var _node in childNodes)
                {
                    if (_node.NodeType == HtmlNodeType.Element)
                    {
                        richTextBox1.WriteLine(_node.InnerText);
                    }
                }
            };
      
            var htmlDoc = new HtmlDocument();
            htmlDoc.LoadHtml(html);

            var htmlBody = htmlDoc.DocumentNode.SelectSingleNode("//body");

            DisplayChildNodes(htmlBody);

            HtmlNode node = htmlBody.ChildNodes[1];

            htmlBody.RemoveChild(node);

            richTextBox1.WriteLine("\n****After child node deleted****\n");

            DisplayChildNodes(htmlBody);
        }



        ///<summary>
        ///https://html-agility-pack.net/remove-child
        ///https://dotnetfiddle.net/bSWNON
        /// </summary>
        void Test031()
        {
            var html =
        @"<body>
            <h1>This is <b>bold</b> heading</h1>
            <p>This is <u>underlined</u> paragraph</p>
        </body>";
            Action<HtmlNode> DisplayChildNodes = (nodeElement) => {
                HtmlNodeCollection childNodes = nodeElement.ChildNodes;

                foreach (var _node in childNodes)
                {
                    if (_node.NodeType == HtmlNodeType.Element)
                    {
                        richTextBox1.WriteLine(_node.InnerText);
                    }
                }
            };
            var htmlDoc = new HtmlDocument();
            htmlDoc.LoadHtml(html);

            var htmlBody = htmlDoc.DocumentNode.SelectSingleNode("//body");

            DisplayChildNodes(htmlBody);

            HtmlNode node = htmlBody.ChildNodes[1];

            htmlBody.RemoveChild(node, true);

            richTextBox1.WriteLine("\n****After child node deleted****\n");

            DisplayChildNodes(htmlBody);
        }



        ///<summary>
        ///https://html-agility-pack.net/remove-child#public-htmlnode-removechildhtmlnode-oldchild-bool-keepgrandchildren
        ///https://dotnetfiddle.net/bSWNON
        /// </summary>
        void Test032()
        {
            var html =
        @"<body>
            <h1>This is <b>bold</b> heading</h1>
            <p>This is <u>underlined</u> paragraph</p>
        </body>";
            Action<HtmlNode> DisplayChildNodes = (nodeElement) => {
                HtmlNodeCollection childNodes = nodeElement.ChildNodes;

                foreach (var _node in childNodes)
                {
                    if (_node.NodeType == HtmlNodeType.Element)
                    {
                        richTextBox1.WriteLine(_node.InnerText);
                    }
                }
            };
            var htmlDoc = new HtmlDocument();
            htmlDoc.LoadHtml(html);

            var htmlBody = htmlDoc.DocumentNode.SelectSingleNode("//body");

            DisplayChildNodes(htmlBody);

            HtmlNode node = htmlBody.ChildNodes[1];

            htmlBody.RemoveChild(node, true);

            richTextBox1.WriteLine("\n****After child node deleted****\n");

            DisplayChildNodes(htmlBody);
        }



        ///<summary>
        ///https://html-agility-pack.net/replace-child
        ///https://dotnetfiddle.net/JUfoxv
        /// </summary>
        void Test033()
        {
            var html =
        @"<body>
            <h1>This is <b>bold</b> heading</h1>
            <p>This is <u>underlined</u> paragraph</p>
        </body>";
            Action<HtmlNode> DisplayChildNodes = (nodeElement) => {
                HtmlNodeCollection childNodes = nodeElement.ChildNodes;

                if (childNodes.Count == 0)
                {
                    richTextBox1.WriteLine(nodeElement.Name + " has no children");
                }
                else
                {
                    foreach (var node in childNodes)
                    {
                        if (node.NodeType == HtmlNodeType.Element)
                        {
                            richTextBox1.WriteLine(node.OuterHtml);
                        }
                    }
                }
            };
            Action<HtmlNode> DisplayNode = (node) => {
                richTextBox1.WriteLine("Node Name: " + node.Name);

                richTextBox1.Write("\n" + node.Name + " children:\n");

                DisplayChildNodes(node);
            };
            var htmlDoc = new HtmlDocument();
            htmlDoc.LoadHtml(html);

            var htmlBody = htmlDoc.DocumentNode.SelectSingleNode("//body");

            DisplayNode(htmlBody);

            HtmlNode oldChild = htmlBody.ChildNodes[1];

            HtmlNode newChild = HtmlNode.CreateNode("<h2> This is h2 new child heading</h2>");

            htmlBody.ReplaceChild(newChild, oldChild);

            richTextBox1.WriteLine("\n****After child node replaced****\n");

            DisplayNode(htmlBody);
        }



        ///<summary>
        ///https://html-agility-pack.net/child-nodes
        ///https://dotnetfiddle.net/9drY3o
        /// </summary>
        void Test034()
        {
            var html =
        @"<body>
            <h1>This is <b>bold</b> heading</h1>
            <p>This is <u>underlined</u> paragraph</p>
        </body>";

            var htmlDoc = new HtmlDocument();
            htmlDoc.LoadHtml(html);

            var htmlBody = htmlDoc.DocumentNode.SelectSingleNode("//body");

            HtmlNodeCollection childNodes = htmlBody.ChildNodes;

            foreach (var node in childNodes)
            {
                if (node.NodeType == HtmlNodeType.Element)
                {
                    richTextBox1.WriteLine(node.OuterHtml);
                }
            }
        }



        ///<summary>
        ///https://html-agility-pack.net/first-child
        ///https://dotnetfiddle.net/DJeEwt
        /// </summary>
        void Test035()
        {
            var html =
        @"<body><h1>This is <b>bold</b> heading</h1><p>This is <u>underlined</u> paragraph</p></body>";

            var htmlDoc = new HtmlDocument();
            htmlDoc.LoadHtml(html);

            var htmlBody = htmlDoc.DocumentNode.SelectSingleNode("//body");

            HtmlNode firstChild = htmlBody.FirstChild;

            richTextBox1.WriteLine(firstChild.OuterHtml);
        }



        ///<summary>
        ///https://html-agility-pack.net/last-child
        ///https://dotnetfiddle.net/W7K9JO
        /// </summary>
        void Test036()
        {
            var html =
        @"<body><h1>This is <b>bold</b> heading</h1><p>This is <u>underlined</u> paragraph</p></body>";

            var htmlDoc = new HtmlDocument();
            htmlDoc.LoadHtml(html);

            var htmlBody = htmlDoc.DocumentNode.SelectSingleNode("//body");

            HtmlNode lastChild = htmlBody.LastChild;

            richTextBox1.WriteLine(lastChild.OuterHtml);
        }



        ///<summary>
        ///https://html-agility-pack.net/next-sibling
        ///https://dotnetfiddle.net/k2k3IJ
        /// </summary>
        void Test037()
        {
            var html =
        @"<!DOCTYPE html>
<html>
<body>
	<h1>This is <b>bold</b> heading</h1>
	<p>This is <u>underlined</u> paragraph</p>
	<h2>This is <i>italic</i> heading</h2>
	<h2>This is new heading</h2>
</body>
</html> ";

            var htmlDoc = new HtmlDocument();
            htmlDoc.LoadHtml(html);

            var node = htmlDoc.DocumentNode.SelectSingleNode("//body/h1");

            HtmlNode sibling = node.NextSibling;

            while (sibling != null)
            {
                if (sibling.NodeType == HtmlNodeType.Element)
                    richTextBox1.WriteLine(sibling.OuterHtml);

                sibling = sibling.NextSibling;
            }

        }



        ///<summary>
        ///https://html-agility-pack.net/parent-node
        ///https://dotnetfiddle.net/BHfJdM
        /// </summary>
        void Test038()
        {
            var html =
        @"<body>
            <h1>This is <b>bold</b> heading</h1>
            <p>This is <u>underlined</u> paragraph</p>
        </body>";

            var htmlDoc = new HtmlDocument();
            htmlDoc.LoadHtml(html);

            var node = htmlDoc.DocumentNode.SelectSingleNode("//body/h1");

            HtmlNode parentNode = node.ParentNode;

            richTextBox1.WriteLine(parentNode.Name);
        }



        ///<summary>
        ///https://html-agility-pack.net/ancestors
        ///https://dotnetfiddle.net/Kth8sh
        /// </summary>
        void Test039()
        {
            var html =
        @"<!DOCTYPE html>
<html>
<body>
	<h1>This is <b>bold</b> heading</h1>
	<p>This is <u>underlined</u> paragraph</p>
	<h2>This is <i>italic</i> heading</h2>
</body>
</html> ";

            var htmlDoc = new HtmlDocument();
            htmlDoc.LoadHtml(html);

            var node = htmlDoc.DocumentNode.SelectSingleNode("//b");

            foreach (var nNode in node.Ancestors())
            {
                if (nNode.NodeType == HtmlNodeType.Element)
                {
                    richTextBox1.WriteLine(nNode.Name);
                }

            }
        }



        ///<summary>
        ///https://html-agility-pack.net/ancestors
        ///https://dotnetfiddle.net/ZBt7TO
        /// </summary>
        void Test040()
        {
            var html =
        @"<!DOCTYPE html>
        <html>
        <body>
	        <h1>This is <b>bold</b> heading</h1>
	        <p>This is <u>underlined</u> paragraph</p>
	        <h2>This is <i>italic</i> heading</h2>
        </body>
        </html> ";

            var htmlDoc = new HtmlDocument();
            htmlDoc.LoadHtml(html);

            var node = htmlDoc.DocumentNode.SelectSingleNode("//b");

            foreach (var nNode in node.Ancestors("body"))
            {
                if (nNode.NodeType == HtmlNodeType.Element)
                {
                    richTextBox1.WriteLine("Node name: " + nNode.Name);
                    richTextBox1.WriteLine(nNode.InnerText);
                }
            }
        }



        ///<summary>
        ///https://html-agility-pack.net/ancestors#public-ienumerable--htmlnode--ancestorsstring-name
        ///https://dotnetfiddle.net/Kth8sh
        /// </summary>
        void Test041()
        {
            var html =
        @"<!DOCTYPE html>
<html>
<body>
	<h1>This is <b>bold</b> heading</h1>
	<p>This is <u>underlined</u> paragraph</p>
	<h2>This is <i>italic</i> heading</h2>
</body>
</html> ";

            var htmlDoc = new HtmlDocument();
            htmlDoc.LoadHtml(html);

            var node = htmlDoc.DocumentNode.SelectSingleNode("//b");

            foreach (var nNode in node.Ancestors())
            {
                if (nNode.NodeType == HtmlNodeType.Element)
                {
                    richTextBox1.WriteLine(nNode.Name);
                }

            }
        }



        ///<summary>
        ///https://html-agility-pack.net/ancestors#public-ienumerable--htmlnode--ancestorsstring-name
        ///https://dotnetfiddle.net/ZBt7TO
        /// </summary>
        void Test042()
        {
            var html =
        @"<!DOCTYPE html>
<html>
<body>
	<h1>This is <b>bold</b> heading</h1>
	<p>This is <u>underlined</u> paragraph</p>
	<h2>This is <i>italic</i> heading</h2>
</body>
</html> ";

            var htmlDoc = new HtmlDocument();
            htmlDoc.LoadHtml(html);

            var node = htmlDoc.DocumentNode.SelectSingleNode("//b");

            foreach (var nNode in node.Ancestors("body"))
            {
                if (nNode.NodeType == HtmlNodeType.Element)
                {
                    richTextBox1.WriteLine("Node name: " + nNode.Name);
                    richTextBox1.WriteLine(nNode.InnerText);
                }
            }
        }



        ///<summary>
        ///https://html-agility-pack.net/ancestors-and-self
        ///
        /// </summary>
        void Test043()
        {
            var html =
        @"<!DOCTYPE html>
<html>
<body>
	<h1>This is <b>bold</b> heading</h1>
	<p>This is <u>underlined</u> paragraph</p>
	<h2>This is <i>italic</i> heading</h2>
</body>
</html> ";

            var htmlDoc = new HtmlDocument();
            htmlDoc.LoadHtml(html);

            var node = htmlDoc.DocumentNode.SelectSingleNode("//b");

            foreach (var nNode in node.Ancestors())
            {
                if (nNode.NodeType == HtmlNodeType.Element)
                {
                    richTextBox1.WriteLine(nNode.Name);
                }

            }
        }



        ///<summary>
        ///https://html-agility-pack.net/ancestors-and-self
        ///https://dotnetfiddle.net/urjo5m
        /// </summary>
        void Test044()
        {
            var html =
        @"<!DOCTYPE html>
<html>
<body>
	<h1>This is <b>bold</b> heading</h1>
	<p>This is <u>underlined</u> paragraph</p>
	<h2>This is <i>italic</i> heading</h2>
</body>
</html> ";

            var htmlDoc = new HtmlDocument();
            htmlDoc.LoadHtml(html);

            var node = htmlDoc.DocumentNode.SelectSingleNode("//u");

            foreach (var nNode in node.AncestorsAndSelf("p"))
            {
                if (nNode.NodeType == HtmlNodeType.Element)
                {
                    richTextBox1.WriteLine(nNode.Name);
                }

            }
        }



        ///<summary>
        ///https://html-agility-pack.net/ancestors-and-self#public-ienumerable--htmlnode--ancestorsandselfstring-name
        ///https://dotnetfiddle.net/Kth8sh
        /// </summary>
        void Test045()
        {
            var html =
        @"<!DOCTYPE html>
<html>
<body>
	<h1>This is <b>bold</b> heading</h1>
	<p>This is <u>underlined</u> paragraph</p>
	<h2>This is <i>italic</i> heading</h2>
</body>
</html> ";

            var htmlDoc = new HtmlDocument();
            htmlDoc.LoadHtml(html);

            var node = htmlDoc.DocumentNode.SelectSingleNode("//b");

            foreach (var nNode in node.Ancestors())
            {
                if (nNode.NodeType == HtmlNodeType.Element)
                {
                    richTextBox1.WriteLine(nNode.Name);
                }

            }
        }



        ///<summary>
        ///https://html-agility-pack.net/ancestors-and-self#public-ienumerable--htmlnode--ancestorsandselfstring-name
        ///https://dotnetfiddle.net/urjo5m
        /// </summary>
        void Test046()
        {
            var html =
        @"<!DOCTYPE html>
<html>
<body>
	<h1>This is <b>bold</b> heading</h1>
	<p>This is <u>underlined</u> paragraph</p>
	<h2>This is <i>italic</i> heading</h2>
</body>
</html> ";

            var htmlDoc = new HtmlDocument();
            htmlDoc.LoadHtml(html);

            var node = htmlDoc.DocumentNode.SelectSingleNode("//u");

            foreach (var nNode in node.AncestorsAndSelf("p"))
            {
                if (nNode.NodeType == HtmlNodeType.Element)
                {
                    richTextBox1.WriteLine(nNode.Name);
                }

            }
        }



        ///<summary>
        ///https://html-agility-pack.net/descendant-nodes
        ///https://dotnetfiddle.net/gLl45I
        /// </summary>
        void Test047()
        {
            var html =
        @"<!DOCTYPE html>
<html>
<body>
	<h1>This is <b>bold</b> heading</h1>
	<p>This is <u>underlined</u> paragraph</p>
	<h2>This is <i>italic</i> heading</h2>
</body>
</html> ";

            var htmlDoc = new HtmlDocument();
            htmlDoc.LoadHtml(html);

            var node = htmlDoc.DocumentNode.SelectSingleNode("//body");

            foreach (var nNode in node.DescendantNodes())
            {
                if (nNode.NodeType == HtmlNodeType.Element)
                {
                    richTextBox1.WriteLine(nNode.Name);
                }

            }
        }



        ///<summary>
        ///https://html-agility-pack.net/descendant-nodes-and-self
        ///https://dotnetfiddle.net/OMpg6Z
        /// </summary>
        void Test048()
        {
            var html =
        @"<!DOCTYPE html>
<html>
<body>
	<h1>This is <b>bold</b> heading</h1>
	<p>This is <u>underlined</u> paragraph</p>
	<h2>This is <i>italic</i> heading</h2>
</body>
</html> ";

            var htmlDoc = new HtmlDocument();
            htmlDoc.LoadHtml(html);

            var node = htmlDoc.DocumentNode.SelectSingleNode("//body");

            foreach (var nNode in node.DescendantNodesAndSelf())
            {
                if (nNode.NodeType == HtmlNodeType.Element)
                {
                    richTextBox1.WriteLine(nNode.Name);
                }
            }
        }



        ///<summary>
        ///https://html-agility-pack.net/descendants
        ///https://dotnetfiddle.net/gygZsT
        /// </summary>
        void Test049()
        {
            var html =
        @"<!DOCTYPE html>
<html>
<body>
	<h1>This is <b>bold</b> heading</h1>
	<p>This is <u>underlined</u> paragraph</p>
	<h2>This is <i>italic</i> heading</h2>
</body>
</html> ";

            var htmlDoc = new HtmlDocument();
            htmlDoc.LoadHtml(html);

            var node = htmlDoc.DocumentNode.SelectSingleNode("//body");

            foreach (var nNode in node.Descendants())
            {
                if (nNode.NodeType == HtmlNodeType.Element)
                {
                    richTextBox1.WriteLine(nNode.Name);
                }
            }
        }



        ///<summary>
        ///https://html-agility-pack.net/descendants
        ///https://dotnetfiddle.net/1HYt4Q
        /// </summary>
        void Test050()
        {
            var html =
        @"<!DOCTYPE html>
<html>
<body>
	<h1>This is <b>bold</b> heading</h1>
	<p>This is <u>underlined</u> paragraph</p>
	<h2>This is <i>italic</i> heading</h2>
	<h2>This is new heading</h2>
</body>
</html> ";

            var htmlDoc = new HtmlDocument();
            htmlDoc.LoadHtml(html);

            htmlDoc.Save("test.html");

            var path = @"test.html";

            var doc = new HtmlDocument();
            doc.Load(path);

            var node = doc.DocumentNode.SelectSingleNode("//body");

            foreach (var nNode in node.Descendants("h2"))
            {
                if (nNode.NodeType == HtmlNodeType.Element)
                {
                    richTextBox1.WriteLine(nNode.OuterHtml);
                }
            }
        }



        ///<summary>
        ///https://html-agility-pack.net/ancestors-and-self#public-ienumerable--htmlnode--ancestorsandselfstring-name
        ///https://dotnetfiddle.net/Kth8sh
        /// </summary>
        void Test051()
        {
            var html =
        @"<!DOCTYPE html>
<html>
<body>
	<h1>This is <b>bold</b> heading</h1>
	<p>This is <u>underlined</u> paragraph</p>
	<h2>This is <i>italic</i> heading</h2>
</body>
</html> ";

            var htmlDoc = new HtmlDocument();
            htmlDoc.LoadHtml(html);

            var node = htmlDoc.DocumentNode.SelectSingleNode("//b");

            foreach (var nNode in node.Ancestors())
            {
                if (nNode.NodeType == HtmlNodeType.Element)
                {
                    richTextBox1.WriteLine(nNode.Name);
                }

            }
        }



        ///<summary>
        ///https://html-agility-pack.net/ancestors-and-self#public-ienumerable--htmlnode--ancestorsandselfstring-name
        ///https://dotnetfiddle.net/urjo5m
        /// </summary>
        void Test052()
        {
            var html =
        @"<!DOCTYPE html>
<html>
<body>
	<h1>This is <b>bold</b> heading</h1>
	<p>This is <u>underlined</u> paragraph</p>
	<h2>This is <i>italic</i> heading</h2>
</body>
</html> ";

            var htmlDoc = new HtmlDocument();
            htmlDoc.LoadHtml(html);

            var node = htmlDoc.DocumentNode.SelectSingleNode("//u");

            foreach (var nNode in node.AncestorsAndSelf("p"))
            {
                if (nNode.NodeType == HtmlNodeType.Element)
                {
                    richTextBox1.WriteLine(nNode.Name);
                }

            }

        }



        ///<summary>
        ///https://html-agility-pack.net/descendant-nodes
        ///https://dotnetfiddle.net/gLl45I
        /// </summary>
        void Test053()
        {
            var html =
        @"<!DOCTYPE html>
<html>
<body>
	<h1>This is <b>bold</b> heading</h1>
	<p>This is <u>underlined</u> paragraph</p>
	<h2>This is <i>italic</i> heading</h2>
</body>
</html> ";

            var htmlDoc = new HtmlDocument();
            htmlDoc.LoadHtml(html);

            var node = htmlDoc.DocumentNode.SelectSingleNode("//body");

            foreach (var nNode in node.DescendantNodes())
            {
                if (nNode.NodeType == HtmlNodeType.Element)
                {
                    richTextBox1.WriteLine(nNode.Name);
                }

            }
        }



        ///<summary>
        ///https://html-agility-pack.net/descendant-nodes-and-self
        ///https://dotnetfiddle.net/OMpg6Z
        /// </summary>
        void Test054()
        {
            var html =
        @"<!DOCTYPE html>
<html>
<body>
	<h1>This is <b>bold</b> heading</h1>
	<p>This is <u>underlined</u> paragraph</p>
	<h2>This is <i>italic</i> heading</h2>
</body>
</html> ";

            var htmlDoc = new HtmlDocument();
            htmlDoc.LoadHtml(html);

            var node = htmlDoc.DocumentNode.SelectSingleNode("//body");

            foreach (var nNode in node.DescendantNodesAndSelf())
            {
                if (nNode.NodeType == HtmlNodeType.Element)
                {
                    richTextBox1.WriteLine(nNode.Name);
                }
            }
        }



        ///<summary>
        ///https://html-agility-pack.net/descendants
        ///https://dotnetfiddle.net/gygZsT
        /// </summary>
        void Test055()
        {
            var html =
        @"<!DOCTYPE html>
<html>
<body>
	<h1>This is <b>bold</b> heading</h1>
	<p>This is <u>underlined</u> paragraph</p>
	<h2>This is <i>italic</i> heading</h2>
</body>
</html> ";

            var htmlDoc = new HtmlDocument();
            htmlDoc.LoadHtml(html);

            var node = htmlDoc.DocumentNode.SelectSingleNode("//body");

            foreach (var nNode in node.Descendants())
            {
                if (nNode.NodeType == HtmlNodeType.Element)
                {
                    richTextBox1.WriteLine(nNode.Name);
                }
            }
        }



        ///<summary>
        ///https://html-agility-pack.net/descendants
        ///https://dotnetfiddle.net/1HYt4Q
        /// </summary>
        void Test056()
        {
            var html =
        @"<!DOCTYPE html>
<html>
<body>
	<h1>This is <b>bold</b> heading</h1>
	<p>This is <u>underlined</u> paragraph</p>
	<h2>This is <i>italic</i> heading</h2>
	<h2>This is new heading</h2>
</body>
</html> ";

            var htmlDoc = new HtmlDocument();
            htmlDoc.LoadHtml(html);

            htmlDoc.Save("test.html");

            var path = @"test.html";

            var doc = new HtmlDocument();
            doc.Load(path);

            var node = doc.DocumentNode.SelectSingleNode("//body");

            foreach (var nNode in node.Descendants("h2"))
            {
                if (nNode.NodeType == HtmlNodeType.Element)
                {
                    richTextBox1.WriteLine(nNode.OuterHtml);
                }
            }
        }



        ///<summary>
        ///https://html-agility-pack.net/descendants#public-ienumerable--htmlnode--descendantsstring-name
        ///https://dotnetfiddle.net/gygZsT
        /// </summary>
        void Test057()
        {
            var html =
        @"<!DOCTYPE html>
<html>
<body>
	<h1>This is <b>bold</b> heading</h1>
	<p>This is <u>underlined</u> paragraph</p>
	<h2>This is <i>italic</i> heading</h2>
</body>
</html> ";

            var htmlDoc = new HtmlDocument();
            htmlDoc.LoadHtml(html);

            var node = htmlDoc.DocumentNode.SelectSingleNode("//body");

            foreach (var nNode in node.Descendants())
            {
                if (nNode.NodeType == HtmlNodeType.Element)
                {
                    richTextBox1.WriteLine(nNode.Name);
                }
            }
        }



        ///<summary>
        ///https://html-agility-pack.net/descendants#public-ienumerable--htmlnode--descendantsstring-name
        ///https://dotnetfiddle.net/1HYt4Q
        /// </summary>
        void Test058()
        {
            var html =
        @"<!DOCTYPE html>
<html>
<body>
	<h1>This is <b>bold</b> heading</h1>
	<p>This is <u>underlined</u> paragraph</p>
	<h2>This is <i>italic</i> heading</h2>
	<h2>This is new heading</h2>
</body>
</html> ";

            var htmlDoc = new HtmlDocument();
            htmlDoc.LoadHtml(html);

            htmlDoc.Save("test.html");

            var path = @"test.html";

            var doc = new HtmlDocument();
            doc.Load(path);

            var node = doc.DocumentNode.SelectSingleNode("//body");

            foreach (var nNode in node.Descendants("h2"))
            {
                if (nNode.NodeType == HtmlNodeType.Element)
                {
                    richTextBox1.WriteLine(nNode.OuterHtml);
                }
            }
        }



        ///<summary>
        ///https://html-agility-pack.net/descendants-and-self
        ///https://dotnetfiddle.net/OMpg6Z
        /// </summary>
        void Test059()
        {
            var html =
        @"<!DOCTYPE html>
<html>
<body>
	<h1>This is <b>bold</b> heading</h1>
	<p>This is <u>underlined</u> paragraph</p>
	<h2>This is <i>italic</i> heading</h2>
</body>
</html> ";

            var htmlDoc = new HtmlDocument();
            htmlDoc.LoadHtml(html);

            var node = htmlDoc.DocumentNode.SelectSingleNode("//body");

            foreach (var nNode in node.DescendantNodesAndSelf())
            {
                if (nNode.NodeType == HtmlNodeType.Element)
                {
                    richTextBox1.WriteLine(nNode.Name);
                }
            }
        }



        ///<summary>
        ///https://html-agility-pack.net/descendants-and-self
        ///https://dotnetfiddle.net/0wwEO5
        /// </summary>
        void Test060()
        {
            var html =
        @"<!DOCTYPE html>
<html>
<body>
	<h1>This is <b>bold</b> heading</h1>
	<p>This is <u>underlined</u> paragraph</p>
	<h2>This is <i>italic</i> heading</h2>
	<h2>This is new heading</h2>
</body>
</html> ";

            var htmlDoc = new HtmlDocument();
            htmlDoc.LoadHtml(html);

            var node = htmlDoc.DocumentNode.SelectSingleNode("//body");

            foreach (var nNode in node.DescendantsAndSelf("h2"))
            {
                if (nNode.NodeType == HtmlNodeType.Element)
                {
                    richTextBox1.WriteLine(nNode.OuterHtml);
                }
            }
        }



        ///<summary>
        ///https://html-agility-pack.net/descendants-and-self#public-ienumerable--htmlnode--descendantsandselfstring-name
        ///https://dotnetfiddle.net/OMpg6Z
        /// </summary>
        void Test061()
        {
            var html =
        @"<!DOCTYPE html>
<html>
<body>
	<h1>This is <b>bold</b> heading</h1>
	<p>This is <u>underlined</u> paragraph</p>
	<h2>This is <i>italic</i> heading</h2>
</body>
</html> ";

            var htmlDoc = new HtmlDocument();
            htmlDoc.LoadHtml(html);

            var node = htmlDoc.DocumentNode.SelectSingleNode("//body");

            foreach (var nNode in node.DescendantNodesAndSelf())
            {
                if (nNode.NodeType == HtmlNodeType.Element)
                {
                    richTextBox1.WriteLine(nNode.Name);
                }
            }
        }



        ///<summary>
        ///https://html-agility-pack.net/descendants-and-self#public-ienumerable--htmlnode--descendantsandselfstring-name
        ///https://dotnetfiddle.net/0wwEO5
        /// </summary>
        void Test062()
        {
            var html =
        @"<!DOCTYPE html>
<html>
<body>
	<h1>This is <b>bold</b> heading</h1>
	<p>This is <u>underlined</u> paragraph</p>
	<h2>This is <i>italic</i> heading</h2>
	<h2>This is new heading</h2>
</body>
</html> ";

            var htmlDoc = new HtmlDocument();
            htmlDoc.LoadHtml(html);

            var node = htmlDoc.DocumentNode.SelectSingleNode("//body");

            foreach (var nNode in node.DescendantsAndSelf("h2"))
            {
                if (nNode.NodeType == HtmlNodeType.Element)
                {
                    richTextBox1.WriteLine(nNode.OuterHtml);
                }
            }
        }



        ///<summary>
        ///https://html-agility-pack.net/element
        ///https://dotnetfiddle.net/MhyWsN
        /// </summary>
        void Test063()
        {
            var html =
        @"<!DOCTYPE html>
<html>
<body>
	<h1>This is <b>bold</b> heading</h1>
	<p>This is <u>underlined</u> paragraph</p>
	<h2>This is <i>italic</i> heading</h2>
	<h2>This is new heading</h2>
</body>
</html> ";

            var htmlDoc = new HtmlDocument();
            htmlDoc.LoadHtml(html);

            var htmlBody = htmlDoc.DocumentNode.SelectSingleNode("//body");

            var node = htmlBody.Element("p");

            richTextBox1.WriteLine(node.OuterHtml);
        }



        ///<summary>
        ///https://html-agility-pack.net/elements
        ///https://dotnetfiddle.net/eN5vpD
        /// </summary>
        void Test064()
        {
            var html =
        @"<!DOCTYPE html>
<html>
<body>
	<h1>This is <b>bold</b> heading</h1>
	<p>This is <u>underlined</u> paragraph</p>
	<h2>This is <i>italic</i> heading</h2>
	<h2>This is new heading</h2>
</body>
</html> ";

            var htmlDoc = new HtmlDocument();
            htmlDoc.LoadHtml(html);

            var htmlBody = htmlDoc.DocumentNode.SelectSingleNode("//body");

            var nodes = htmlBody.Elements("h2");

            foreach (var node in nodes)
            {
                if (node.NodeType == HtmlNodeType.Element)
                {
                    richTextBox1.WriteLine(node.OuterHtml);
                }
            }
        }



        ///<summary>
        ///https://html-agility-pack.net/save
        ///https://dotnetfiddle.net/e3GYpK
        /// </summary>
        void Test065()
        {
            var html =
        @"<!DOCTYPE html>
<html>
<body>
	<h1>This is <b>bold</b> heading</h1>
	<p>This is <u>underlined</u> paragraph</p>
	<h2>This is <i>italic</i> heading</h2>
	<h2>This is new heading</h2>
</body>
</html> ";

            var htmlDoc = new HtmlDocument();
            htmlDoc.LoadHtml(html);

            FileStream sw = new FileStream("FileStream.html", FileMode.Create);

            htmlDoc.Save(sw);

            sw.Close();

            var htmlNewDoc = new HtmlDocument();

            htmlNewDoc.Load("FileStream.html");

            var node = htmlNewDoc.DocumentNode.SelectSingleNode("//body");

            richTextBox1.WriteLine(node.OuterHtml);
        }



        ///<summary>
        ///https://html-agility-pack.net/save
        ///https://dotnetfiddle.net/nyt6gY
        /// </summary>
        void Test066()
        {
            var html =
        @"<!DOCTYPE html>
<html>
<body>
	<h1>This is <b>bold</b> heading</h1>
	<p>This is <u>underlined</u> paragraph</p>
	<h2>This is <i>italic</i> heading</h2>
	<h2>This is new heading</h2>
</body>
</html> ";

            var htmlDoc = new HtmlDocument();
            htmlDoc.LoadHtml(html);

            StreamWriter sw = new StreamWriter("StreamWriter.html");

            htmlDoc.Save(sw);

            sw.Close();

            var htmlNewDoc = new HtmlDocument();

            htmlNewDoc.Load("StreamWriter.html");

            var node = htmlNewDoc.DocumentNode.SelectSingleNode("//body");

            richTextBox1.WriteLine(node.OuterHtml);
        }



        ///<summary>
        ///https://html-agility-pack.net/save
        ///https://dotnetfiddle.net/98wejH
        /// </summary>
        void Test067()
        {
            var html =
        @"<!DOCTYPE html>
<html>
<body>
	<h1>This is <b>bold</b> heading</h1>
	<p>This is <u>underlined</u> paragraph</p>
	<h2>This is <i>italic</i> heading</h2>
	<h2>This is new heading</h2>
</body>
</html> ";

            var htmlDoc = new HtmlDocument();
            htmlDoc.LoadHtml(html);

            TextWriter tw = File.CreateText("TextWriter.html");

            htmlDoc.Save(tw);

            tw.Close();

            var htmlNewDoc = new HtmlDocument();

            htmlNewDoc.Load("TextWriter.html");

            var node = htmlNewDoc.DocumentNode.SelectSingleNode("//body");

            richTextBox1.WriteLine(node.OuterHtml);
        }



        ///<summary>
        ///https://html-agility-pack.net/save
        ///https://dotnetfiddle.net/uke1Bg
        /// </summary>
        void Test068()
        {
            var html =
        @"<!DOCTYPE html>
<html>
<body>
	<h1>This is <b>bold</b> heading</h1>
	<p>This is <u>underlined</u> paragraph</p>
	<h2>This is <i>italic</i> heading</h2>
	<h2>This is new heading</h2>
</body>
</html> ";

            var htmlDoc = new HtmlDocument();
            htmlDoc.LoadHtml(html);

            htmlDoc.Save("test.html");

            var htmlNewDoc = new HtmlDocument();

            htmlNewDoc.Load("test.html");

            var node = htmlNewDoc.DocumentNode.SelectSingleNode("//body");

            richTextBox1.WriteLine(node.OuterHtml);
        }



        ///<summary>
        ///https://html-agility-pack.net/save
        ///https://dotnetfiddle.net/CCZ2Gu
        /// </summary>
        void Test069()
        {
            var html =
        @"<!DOCTYPE html>
<html>
<body>
	<h1>This is <b>bold</b> heading</h1>
	<p>This is <u>underlined</u> paragraph</p>
	<h2>This is <i>italic</i> heading</h2>
	<h2>This is new heading</h2>
</body>
</html> ";

            var htmlDoc = new HtmlDocument();
            htmlDoc.LoadHtml(html);

            htmlDoc.OptionOutputAsXml = true;

            StringWriter sw = new StringWriter();

            XmlTextWriter xw = new XmlTextWriter(sw);

            htmlDoc.Save(xw);

            string result = sw.ToString();

            richTextBox1.WriteLine(result);
        }



        ///<summary>
        ///https://html-agility-pack.net/save
        ///https://dotnetfiddle.net/fyDMJt
        /// </summary>
        void Test070()
        {
            var html =
        @"<!DOCTYPE html>
<html>
<body>
	<h1>This is <b>bold</b> heading</h1>
	<p>This is <u>underlined</u> paragraph</p>
	<h2>This is <i>italic</i> heading</h2>
	<h2>This is new heading</h2>
</body>
</html> ";

            var htmlDoc = new HtmlDocument();
            htmlDoc.LoadHtml(html);

            FileStream sw = new FileStream("FileStream.html", FileMode.Create);

            htmlDoc.Save(sw, Encoding.UTF8);

            sw.Close();

            var htmlNewDoc = new HtmlDocument();

            htmlNewDoc.Load("FileStream.html");

            var node = htmlNewDoc.DocumentNode.SelectSingleNode("//body");

            richTextBox1.WriteLine(node.OuterHtml);
        }



        ///<summary>
        ///https://html-agility-pack.net/save
        ///https://dotnetfiddle.net/IRTOcM
        /// </summary>
        void Test071()
        {
            var html =
        @"<!DOCTYPE html>
<html>
<body>
	<h1>This is <b>bold</b> heading</h1>
	<p>This is <u>underlined</u> paragraph</p>
	<h2>This is <i>italic</i> heading</h2>
	<h2>This is new heading</h2>
</body>
</html> ";

            var htmlDoc = new HtmlDocument();
            htmlDoc.LoadHtml(html);

            htmlDoc.Save("test.html", Encoding.UTF8);

            var htmlNewDoc = new HtmlDocument();

            htmlNewDoc.Load("test.html");

            var node = htmlNewDoc.DocumentNode.SelectSingleNode("//body");

            richTextBox1.WriteLine(node.OuterHtml);
        }



        ///<summary>
        ///https://html-agility-pack.net/save#public-void-savestreamwriter-writer
        ///https://dotnetfiddle.net/e3GYpK
        /// </summary>
        void Test072()
        {
            var html =
        @"<!DOCTYPE html>
<html>
<body>
	<h1>This is <b>bold</b> heading</h1>
	<p>This is <u>underlined</u> paragraph</p>
	<h2>This is <i>italic</i> heading</h2>
	<h2>This is new heading</h2>
</body>
</html> ";

            var htmlDoc = new HtmlDocument();
            htmlDoc.LoadHtml(html);

            FileStream sw = new FileStream("FileStream.html", FileMode.Create);

            htmlDoc.Save(sw);

            sw.Close();

            var htmlNewDoc = new HtmlDocument();

            htmlNewDoc.Load("FileStream.html");

            var node = htmlNewDoc.DocumentNode.SelectSingleNode("//body");

            richTextBox1.WriteLine(node.OuterHtml);
        
    }



    ///<summary>
    ///https://html-agility-pack.net/save#public-void-savestreamwriter-writer
    ///https://dotnetfiddle.net/nyt6gY
    /// </summary>
    void Test073()
        {
            var html =
        @"<!DOCTYPE html>
<html>
<body>
	<h1>This is <b>bold</b> heading</h1>
	<p>This is <u>underlined</u> paragraph</p>
	<h2>This is <i>italic</i> heading</h2>
	<h2>This is new heading</h2>
</body>
</html> ";

            var htmlDoc = new HtmlDocument();
            htmlDoc.LoadHtml(html);

            StreamWriter sw = new StreamWriter("StreamWriter.html");

            htmlDoc.Save(sw);

            sw.Close();

            var htmlNewDoc = new HtmlDocument();

            htmlNewDoc.Load("StreamWriter.html");

            var node = htmlNewDoc.DocumentNode.SelectSingleNode("//body");

            richTextBox1.WriteLine(node.OuterHtml);
        }



        ///<summary>
        ///https://html-agility-pack.net/save#public-void-savestreamwriter-writer
        ///https://dotnetfiddle.net/98wejH
        /// </summary>
        void Test074()
        {
            var html =
        @"<!DOCTYPE html>
<html>
<body>
	<h1>This is <b>bold</b> heading</h1>
	<p>This is <u>underlined</u> paragraph</p>
	<h2>This is <i>italic</i> heading</h2>
	<h2>This is new heading</h2>
</body>
</html> ";

            var htmlDoc = new HtmlDocument();
            htmlDoc.LoadHtml(html);

            TextWriter tw = File.CreateText("TextWriter.html");

            htmlDoc.Save(tw);

            tw.Close();

            var htmlNewDoc = new HtmlDocument();

            htmlNewDoc.Load("TextWriter.html");

            var node = htmlNewDoc.DocumentNode.SelectSingleNode("//body");

            richTextBox1.WriteLine(node.OuterHtml);
        }



        ///<summary>
        ///https://html-agility-pack.net/save#public-void-savestreamwriter-writer
        ///https://dotnetfiddle.net/uke1Bg
        /// </summary>
        void Test075()
        {
            var html =
                    @"<!DOCTYPE html>
<html>
<body>
	<h1>This is <b>bold</b> heading</h1>
	<p>This is <u>underlined</u> paragraph</p>
	<h2>This is <i>italic</i> heading</h2>
	<h2>This is new heading</h2>
</body>
</html> ";

            var htmlDoc = new HtmlDocument();
            htmlDoc.LoadHtml(html);

            htmlDoc.Save("test.html");

            var htmlNewDoc = new HtmlDocument();

            htmlNewDoc.Load("test.html");

            var node = htmlNewDoc.DocumentNode.SelectSingleNode("//body");

            richTextBox1.WriteLine(node.OuterHtml);
        }



        ///<summary>
        ///https://html-agility-pack.net/save#public-void-savestreamwriter-writer
        ///https://dotnetfiddle.net/CCZ2Gu
        /// </summary>
        void Test076()
        {
            var html =
        @"<!DOCTYPE html>
<html>
<body>
	<h1>This is <b>bold</b> heading</h1>
	<p>This is <u>underlined</u> paragraph</p>
	<h2>This is <i>italic</i> heading</h2>
	<h2>This is new heading</h2>
</body>
</html> ";

            var htmlDoc = new HtmlDocument();
            htmlDoc.LoadHtml(html);

            htmlDoc.OptionOutputAsXml = true;

            StringWriter sw = new StringWriter();

            XmlTextWriter xw = new XmlTextWriter(sw);

            htmlDoc.Save(xw);

            string result = sw.ToString();

            richTextBox1.WriteLine(result);
        }



        ///<summary>
        ///https://html-agility-pack.net/save#public-void-savestreamwriter-writer
        /// https://dotnetfiddle.net/fyDMJt
        /// </summary>
        void Test077()
        {
            var html =
        @"<!DOCTYPE html>
<html>
<body>
	<h1>This is <b>bold</b> heading</h1>
	<p>This is <u>underlined</u> paragraph</p>
	<h2>This is <i>italic</i> heading</h2>
	<h2>This is new heading</h2>
</body>
</html> ";

            var htmlDoc = new HtmlDocument();
            htmlDoc.LoadHtml(html);

            FileStream sw = new FileStream("FileStream.html", FileMode.Create);

            htmlDoc.Save(sw, Encoding.UTF8);

            sw.Close();

            var htmlNewDoc = new HtmlDocument();

            htmlNewDoc.Load("FileStream.html");

            var node = htmlNewDoc.DocumentNode.SelectSingleNode("//body");

            richTextBox1.WriteLine(node.OuterHtml);
        }



        ///<summary>
        ///https://html-agility-pack.net/save#public-void-savestreamwriter-writer
        ///https://dotnetfiddle.net/IRTOcM
        /// </summary>
        void Test078()
        {
            var html =
        @"<!DOCTYPE html>
<html>
<body>
	<h1>This is <b>bold</b> heading</h1>
	<p>This is <u>underlined</u> paragraph</p>
	<h2>This is <i>italic</i> heading</h2>
	<h2>This is new heading</h2>
</body>
</html> ";

            var htmlDoc = new HtmlDocument();
            htmlDoc.LoadHtml(html);

            htmlDoc.Save("test.html", Encoding.UTF8);

            var htmlNewDoc = new HtmlDocument();

            htmlNewDoc.Load("test.html");

            var node = htmlNewDoc.DocumentNode.SelectSingleNode("//body");

            richTextBox1.WriteLine(node.OuterHtml);
        }



        ///<summary>
        ///https://html-agility-pack.net/save#public-void-savetextwriter-writer
        ///https://dotnetfiddle.net/e3GYpK
        /// </summary>
        void Test079()
        {
            var html =
        @"<!DOCTYPE html>
<html>
<body>
	<h1>This is <b>bold</b> heading</h1>
	<p>This is <u>underlined</u> paragraph</p>
	<h2>This is <i>italic</i> heading</h2>
	<h2>This is new heading</h2>
</body>
</html> ";

            var htmlDoc = new HtmlDocument();
            htmlDoc.LoadHtml(html);

            FileStream sw = new FileStream("FileStream.html", FileMode.Create);

            htmlDoc.Save(sw);

            sw.Close();

            var htmlNewDoc = new HtmlDocument();

            htmlNewDoc.Load("FileStream.html");

            var node = htmlNewDoc.DocumentNode.SelectSingleNode("//body");

            richTextBox1.WriteLine(node.OuterHtml);
        }



        ///<summary>
        ///https://html-agility-pack.net/save#public-void-savetextwriter-writer
        ///https://dotnetfiddle.net/nyt6gY
        /// </summary>
        void Test080()
        {
            var html =
        @"<!DOCTYPE html>
<html>
<body>
	<h1>This is <b>bold</b> heading</h1>
	<p>This is <u>underlined</u> paragraph</p>
	<h2>This is <i>italic</i> heading</h2>
	<h2>This is new heading</h2>
</body>
</html> ";

            var htmlDoc = new HtmlDocument();
            htmlDoc.LoadHtml(html);

            StreamWriter sw = new StreamWriter("StreamWriter.html");

            htmlDoc.Save(sw);

            sw.Close();

            var htmlNewDoc = new HtmlDocument();

            htmlNewDoc.Load("StreamWriter.html");

            var node = htmlNewDoc.DocumentNode.SelectSingleNode("//body");

            richTextBox1.WriteLine(node.OuterHtml);
        }



        ///<summary>
        ///https://html-agility-pack.net/save#public-void-savetextwriter-writer
        ///https://dotnetfiddle.net/98wejH
        /// </summary>
        void Test081()
        {
            var html =
        @"<!DOCTYPE html>
<html>
<body>
	<h1>This is <b>bold</b> heading</h1>
	<p>This is <u>underlined</u> paragraph</p>
	<h2>This is <i>italic</i> heading</h2>
	<h2>This is new heading</h2>
</body>
</html> ";

            var htmlDoc = new HtmlDocument();
            htmlDoc.LoadHtml(html);

            TextWriter tw = File.CreateText("TextWriter.html");

            htmlDoc.Save(tw);

            tw.Close();

            var htmlNewDoc = new HtmlDocument();

            htmlNewDoc.Load("TextWriter.html");

            var node = htmlNewDoc.DocumentNode.SelectSingleNode("//body");

            richTextBox1.WriteLine(node.OuterHtml);
        }



        ///<summary>
        ///https://html-agility-pack.net/save#public-void-savetextwriter-writer
        ///https://dotnetfiddle.net/uke1Bg
        /// </summary>
        void Test082()
        {
            var html =
        @"<!DOCTYPE html>
<html>
<body>
	<h1>This is <b>bold</b> heading</h1>
	<p>This is <u>underlined</u> paragraph</p>
	<h2>This is <i>italic</i> heading</h2>
	<h2>This is new heading</h2>
</body>
</html> ";

            var htmlDoc = new HtmlDocument();
            htmlDoc.LoadHtml(html);

            htmlDoc.Save("test.html");

            var htmlNewDoc = new HtmlDocument();

            htmlNewDoc.Load("test.html");

            var node = htmlNewDoc.DocumentNode.SelectSingleNode("//body");

            richTextBox1.WriteLine(node.OuterHtml);
        }



        ///<summary>
        /// https://html-agility-pack.net/save#public-void-savetextwriter-writer
        /// https://dotnetfiddle.net/CCZ2Gu
        /// </summary>
        void Test083()
        {
            var html =
        @"<!DOCTYPE html>
<html>
<body>
	<h1>This is <b>bold</b> heading</h1>
	<p>This is <u>underlined</u> paragraph</p>
	<h2>This is <i>italic</i> heading</h2>
	<h2>This is new heading</h2>
</body>
</html> ";

            var htmlDoc = new HtmlDocument();
            htmlDoc.LoadHtml(html);

            htmlDoc.OptionOutputAsXml = true;

            StringWriter sw = new StringWriter();

            XmlTextWriter xw = new XmlTextWriter(sw);

            htmlDoc.Save(xw);

            string result = sw.ToString();

            richTextBox1.WriteLine(result);
        }



        ///<summary>
        ///https://html-agility-pack.net/save#public-void-savetextwriter-writer
        /// https://dotnetfiddle.net/fyDMJt
        /// </summary>
        void Test084()
        {
            var html =
        @"<!DOCTYPE html>
<html>
<body>
	<h1>This is <b>bold</b> heading</h1>
	<p>This is <u>underlined</u> paragraph</p>
	<h2>This is <i>italic</i> heading</h2>
	<h2>This is new heading</h2>
</body>
</html> ";

            var htmlDoc = new HtmlDocument();
            htmlDoc.LoadHtml(html);

            FileStream sw = new FileStream("FileStream.html", FileMode.Create);

            htmlDoc.Save(sw, Encoding.UTF8);

            sw.Close();

            var htmlNewDoc = new HtmlDocument();

            htmlNewDoc.Load("FileStream.html");

            var node = htmlNewDoc.DocumentNode.SelectSingleNode("//body");

            richTextBox1.WriteLine(node.OuterHtml);
        }



        ///<summary>
        ///https://html-agility-pack.net/save#public-void-savetextwriter-writer
        ///https://dotnetfiddle.net/IRTOcM
        /// </summary>
        void Test085()
        {
            var html =
        @"<!DOCTYPE html>
<html>
<body>
	<h1>This is <b>bold</b> heading</h1>
	<p>This is <u>underlined</u> paragraph</p>
	<h2>This is <i>italic</i> heading</h2>
	<h2>This is new heading</h2>
</body>
</html> ";

            var htmlDoc = new HtmlDocument();
            htmlDoc.LoadHtml(html);

            htmlDoc.Save("test.html", Encoding.UTF8);

            var htmlNewDoc = new HtmlDocument();

            htmlNewDoc.Load("test.html");

            var node = htmlNewDoc.DocumentNode.SelectSingleNode("//body");

            richTextBox1.WriteLine(node.OuterHtml);
        }



        ///<summary>
        ///https://html-agility-pack.net/save#public-void-savestring-filename
        ///https://dotnetfiddle.net/e3GYpK
        /// </summary>
        void Test086()
        {
            var html =
        @"<!DOCTYPE html>
<html>
<body>
	<h1>This is <b>bold</b> heading</h1>
	<p>This is <u>underlined</u> paragraph</p>
	<h2>This is <i>italic</i> heading</h2>
	<h2>This is new heading</h2>
</body>
</html> ";

            var htmlDoc = new HtmlDocument();
            htmlDoc.LoadHtml(html);

            FileStream sw = new FileStream("FileStream.html", FileMode.Create);

            htmlDoc.Save(sw);

            sw.Close();

            var htmlNewDoc = new HtmlDocument();

            htmlNewDoc.Load("FileStream.html");

            var node = htmlNewDoc.DocumentNode.SelectSingleNode("//body");

            richTextBox1.WriteLine(node.OuterHtml);
        }



        ///<summary>
        ///https://html-agility-pack.net/save#public-void-savestring-filename
        ///https://dotnetfiddle.net/nyt6gY
        /// </summary>
        void Test087()
        {
            var html =
        @"<!DOCTYPE html>
<html>
<body>
	<h1>This is <b>bold</b> heading</h1>
	<p>This is <u>underlined</u> paragraph</p>
	<h2>This is <i>italic</i> heading</h2>
	<h2>This is new heading</h2>
</body>
</html> ";

            var htmlDoc = new HtmlDocument();
            htmlDoc.LoadHtml(html);

            StreamWriter sw = new StreamWriter("StreamWriter.html");

            htmlDoc.Save(sw);

            sw.Close();

            var htmlNewDoc = new HtmlDocument();

            htmlNewDoc.Load("StreamWriter.html");

            var node = htmlNewDoc.DocumentNode.SelectSingleNode("//body");

            richTextBox1.WriteLine(node.OuterHtml);

        }



        ///<summary>
        ///https://html-agility-pack.net/save#public-void-savestring-filename
        ///https://dotnetfiddle.net/98wejH
        /// </summary>
        void Test088()
        {
            var html =
        @"<!DOCTYPE html>
<html>
<body>
	<h1>This is <b>bold</b> heading</h1>
	<p>This is <u>underlined</u> paragraph</p>
	<h2>This is <i>italic</i> heading</h2>
	<h2>This is new heading</h2>
</body>
</html> ";

            var htmlDoc = new HtmlDocument();
            htmlDoc.LoadHtml(html);

            TextWriter tw = File.CreateText("TextWriter.html");

            htmlDoc.Save(tw);

            tw.Close();

            var htmlNewDoc = new HtmlDocument();

            htmlNewDoc.Load("TextWriter.html");

            var node = htmlNewDoc.DocumentNode.SelectSingleNode("//body");

            richTextBox1.WriteLine(node.OuterHtml);
        }



        ///<summary>
        ///https://html-agility-pack.net/save#public-void-savestring-filename
        ///https://dotnetfiddle.net/uke1Bg
        /// </summary>
        void Test089()
        {
            var html =
        @"<!DOCTYPE html>
<html>
<body>
	<h1>This is <b>bold</b> heading</h1>
	<p>This is <u>underlined</u> paragraph</p>
	<h2>This is <i>italic</i> heading</h2>
	<h2>This is new heading</h2>
</body>
</html> ";

            var htmlDoc = new HtmlDocument();
            htmlDoc.LoadHtml(html);

            htmlDoc.Save("test.html");

            var htmlNewDoc = new HtmlDocument();

            htmlNewDoc.Load("test.html");

            var node = htmlNewDoc.DocumentNode.SelectSingleNode("//body");

            richTextBox1.WriteLine(node.OuterHtml);
        }



        ///<summary>
        ///https://html-agility-pack.net/save#public-void-savestring-filename
        ///https://dotnetfiddle.net/CCZ2Gu
        /// </summary>
        void Test090()
        {
            var html =
        @"<!DOCTYPE html>
<html>
<body>
	<h1>This is <b>bold</b> heading</h1>
	<p>This is <u>underlined</u> paragraph</p>
	<h2>This is <i>italic</i> heading</h2>
	<h2>This is new heading</h2>
</body>
</html> ";

            var htmlDoc = new HtmlDocument();
            htmlDoc.LoadHtml(html);

            htmlDoc.OptionOutputAsXml = true;

            StringWriter sw = new StringWriter();

            XmlTextWriter xw = new XmlTextWriter(sw);

            htmlDoc.Save(xw);

            string result = sw.ToString();

            richTextBox1.WriteLine(result);
        }



        ///<summary>
        ///https://html-agility-pack.net/save#public-void-savestring-filename
        ///https://dotnetfiddle.net/fyDMJt
        /// </summary>
        void Test091()
        {
            var html =
        @"<!DOCTYPE html>
<html>
<body>
	<h1>This is <b>bold</b> heading</h1>
	<p>This is <u>underlined</u> paragraph</p>
	<h2>This is <i>italic</i> heading</h2>
	<h2>This is new heading</h2>
</body>
</html> ";

            var htmlDoc = new HtmlDocument();
            htmlDoc.LoadHtml(html);

            FileStream sw = new FileStream("FileStream.html", FileMode.Create);

            htmlDoc.Save(sw, Encoding.UTF8);

            sw.Close();

            var htmlNewDoc = new HtmlDocument();

            htmlNewDoc.Load("FileStream.html");

            var node = htmlNewDoc.DocumentNode.SelectSingleNode("//body");

            richTextBox1.WriteLine(node.OuterHtml);

        }



        ///<summary>
        ///https://html-agility-pack.net/save#public-void-savestring-filename
        /// https://dotnetfiddle.net/IRTOcM
        /// </summary>
        void Test092()
        {
            var html =
        @"<!DOCTYPE html>
<html>
<body>
	<h1>This is <b>bold</b> heading</h1>
	<p>This is <u>underlined</u> paragraph</p>
	<h2>This is <i>italic</i> heading</h2>
	<h2>This is new heading</h2>
</body>
</html> ";

            var htmlDoc = new HtmlDocument();
            htmlDoc.LoadHtml(html);

            htmlDoc.Save("test.html", Encoding.UTF8);

            var htmlNewDoc = new HtmlDocument();

            htmlNewDoc.Load("test.html");

            var node = htmlNewDoc.DocumentNode.SelectSingleNode("//body");

            richTextBox1.WriteLine(node.OuterHtml);
        }



        ///<summary>
        ///https://html-agility-pack.net/write-content-to
        ///https://dotnetfiddle.net/mLxVJz
        /// </summary>
        void Test093()
        {
            var html =
        @"<!DOCTYPE html>
<html>
<body>
	<h1>This is <b>bold</b> heading</h1>
	<p>This is <u>underlined</u> paragraph</p>
	<h2>This is <i>italic</i> heading</h2>
	<h2>This is new heading</h2>
</body>
</html> ";

            var htmlDoc = new HtmlDocument();
            htmlDoc.LoadHtml(html);


            var node = htmlDoc.DocumentNode.SelectSingleNode("//body");

            string result = node.WriteContentTo();

            richTextBox1.WriteLine(result);

        }



        ///<summary>
        ///https://html-agility-pack.net/write-content-to
        ///https://dotnetfiddle.net/SscjAW
        /// </summary>
        void Test094()
        {
            var html =
        @"<!DOCTYPE html>
<html>
<body>
	<h1>This is <b>bold</b> heading</h1>
	<p>This is <u>underlined</u> paragraph</p>
	<h2>This is <i>italic</i> heading</h2>
	<h2>This is new heading</h2>
</body>
</html> ";

            var htmlDoc = new HtmlDocument();
            htmlDoc.LoadHtml(html);

            TextWriter writer = File.CreateText("TextWriter.html");

            var node = htmlDoc.DocumentNode.SelectSingleNode("//body");

            node.WriteContentTo(writer);

            writer.Close();

            var htmlNewDoc = new HtmlDocument();

            htmlNewDoc.Load("TextWriter.html");

            var result = htmlNewDoc.DocumentNode.OuterHtml;

            richTextBox1.WriteLine(result);
        }



        ///<summary>
        ///https://html-agility-pack.net/write-to
        ///https://dotnetfiddle.net/57tPH2
        /// </summary>
        void Test095()
        {
            var html =
        @"<!DOCTYPE html>
<html>
<body>
	<h1>This is <b>bold</b> heading</h1>
	<p>This is <u>underlined</u> paragraph</p>
	<h2>This is <i>italic</i> heading</h2>
	<h2>This is new heading</h2>
</body>
</html> ";

            var htmlDoc = new HtmlDocument();
            htmlDoc.LoadHtml(html);


            var node = htmlDoc.DocumentNode.SelectSingleNode("//body");

            string result = node.WriteTo();

            richTextBox1.WriteLine(result);
        }



        ///<summary>
        ///https://html-agility-pack.net/write-to
        ///https://dotnetfiddle.net/q7WBJ0
        /// </summary>
        void Test096()
        {
            var html =
        @"<!DOCTYPE html>
<html>
<body>
	<h1>This is <b>bold</b> heading</h1>
	<p>This is <u>underlined</u> paragraph</p>
	<h2>This is <i>italic</i> heading</h2>
	<h2>This is new heading</h2>
</body>
</html> ";

            var htmlDoc = new HtmlDocument();
            htmlDoc.LoadHtml(html);


            TextWriter writer = File.CreateText("TextWriter.html");

            var node = htmlDoc.DocumentNode.SelectSingleNode("//body");

            node.WriteTo(writer);

            writer.Close();

            var htmlNewDoc = new HtmlDocument();

            htmlNewDoc.Load("TextWriter.html");

            var result = htmlNewDoc.DocumentNode.OuterHtml;

            richTextBox1.WriteLine(result);
        }



        ///<summary>
        ///https://html-agility-pack.net/write-to
        ///https://dotnetfiddle.net/zgaXfg
        /// </summary>
        void Test097()
        {
            var html =
        @"<!DOCTYPE html>
<html>
<body>
	<h1>This is <b>bold</b> heading</h1>
	<p>This is <u>underlined</u> paragraph</p>
	<h2>This is <i>italic</i> heading</h2>
	<h2>This is new heading</h2>
</body>
</html> ";

            var htmlDoc = new HtmlDocument();
            htmlDoc.LoadHtml(html);

            var node = htmlDoc.DocumentNode.SelectSingleNode("//body");

            StringWriter sw = new StringWriter();

            XmlTextWriter xw = new XmlTextWriter(sw);

            node.WriteTo(xw);

            string result = sw.ToString();

            richTextBox1.WriteLine(result);
        }



        ///<summary>
        ///https://html-agility-pack.net/detect-encoding
        ///https://dotnetfiddle.net/IkDlKt
        /// </summary>
        void Test098()
        {
            var html =
        @"<!DOCTYPE html>
<html>
<body>
	<h1>This is <b>bold</b> heading</h1>
	<p>This is <u>underlined</u> paragraph</p>
	<h2>This is <i>italic</i> heading</h2>
	<h2>This is new heading</h2>
</body>
</html>";

            var htmlDoc = new HtmlDocument();
            htmlDoc.LoadHtml(html);

            FileStream fs = new FileStream("Test.html", FileMode.Create);

            StreamWriter sw = new StreamWriter(fs, System.Text.Encoding.UTF32);

            htmlDoc.Save(sw);

            sw.Close();

            var htmlNewDoc = new HtmlDocument();

            TextReader tr = File.OpenText("Test.html");

            var encoding = htmlNewDoc.DetectEncoding(tr);

            richTextBox1.WriteLine(encoding);
        }



        ///<summary>
        ///https://html-agility-pack.net/detect-encoding
        ///https://dotnetfiddle.net/ImZV3y
        /// </summary>
        void Test099()
        {
            var html =
        @"<!DOCTYPE html>
<html>
<body>
	<h1>This is <b>bold</b> heading</h1>
	<p>This is <u>underlined</u> paragraph</p>
	<h2>This is <i>italic</i> heading</h2>
	<h2>This is new heading</h2>
</body>
</html>";

            var htmlDoc = new HtmlDocument();
            htmlDoc.LoadHtml(html);

            FileStream fs = new FileStream("Test.html", FileMode.Create);

            StreamWriter sw = new StreamWriter(fs, System.Text.Encoding.UTF32);

            htmlDoc.Save(sw);

            sw.Close();

            var htmlNewDoc = new HtmlDocument();

            FileStream newfs = new FileStream("Test.html", FileMode.Open);

            var encoding = htmlNewDoc.DetectEncoding(newfs);

            richTextBox1.WriteLine(encoding);
        }



        ///<summary>
        ///https://html-agility-pack.net/detect-encoding
        ///https://dotnetfiddle.net/Wa4VTT
        /// </summary>
        void Test100()
        {
            var html =
        @"<!DOCTYPE html>
<html>
<body>
	<h1>This is <b>bold</b> heading</h1>
	<p>This is <u>underlined</u> paragraph</p>
	<h2>This is <i>italic</i> heading</h2>
	<h2>This is new heading</h2>
</body>
</html>";

            var htmlDoc = new HtmlDocument();
            htmlDoc.LoadHtml(html);

            FileStream fs = new FileStream("Test.html", FileMode.Create);

            StreamWriter sw = new StreamWriter(fs, System.Text.Encoding.UTF32);

            htmlDoc.Save(sw);

            sw.Close();

            var htmlNewDoc = new HtmlDocument();

            var encoding = htmlNewDoc.DetectEncoding("Test.html");

            richTextBox1.WriteLine(encoding);
        }
        ///<summary>
        ///https://html-agility-pack.net/detect-encoding#public-encoding-detectencodingtextreader-reader
        ///https://dotnetfiddle.net/ImZV3y
        /// </summary>
        void Test101()
        {
            var html =
        @"<!DOCTYPE html>
<html>
<body>
	<h1>This is <b>bold</b> heading</h1>
	<p>This is <u>underlined</u> paragraph</p>
	<h2>This is <i>italic</i> heading</h2>
	<h2>This is new heading</h2>
</body>
</html>";

            var htmlDoc = new HtmlDocument();
            htmlDoc.LoadHtml(html);

            FileStream fs = new FileStream("Test.html", FileMode.Create);

            StreamWriter sw = new StreamWriter(fs, System.Text.Encoding.UTF32);

            htmlDoc.Save(sw);

            sw.Close();

            var htmlNewDoc = new HtmlDocument();

            FileStream newfs = new FileStream("Test.html", FileMode.Open);

            var encoding = htmlNewDoc.DetectEncoding(newfs);

            richTextBox1.WriteLine(encoding);
        }
        ///<summary>
        ///https://html-agility-pack.net/detect-encoding#public-encoding-detectencodingtextreader-reader
        ///https://dotnetfiddle.net/IkDlKt
        /// </summary>
        void Test102()
        {
            var html =
        @"<!DOCTYPE html>
<html>
<body>
	<h1>This is <b>bold</b> heading</h1>
	<p>This is <u>underlined</u> paragraph</p>
	<h2>This is <i>italic</i> heading</h2>
	<h2>This is new heading</h2>
</body>
</html>";

            var htmlDoc = new HtmlDocument();
            htmlDoc.LoadHtml(html);

            FileStream fs = new FileStream("Test.html", FileMode.Create);

            StreamWriter sw = new StreamWriter(fs, System.Text.Encoding.UTF32);

            htmlDoc.Save(sw);

            sw.Close();

            var htmlNewDoc = new HtmlDocument();

            TextReader tr = File.OpenText("Test.html");

            var encoding = htmlNewDoc.DetectEncoding(tr);

            richTextBox1.WriteLine(encoding);
        }
        ///<summary>
        ///https://html-agility-pack.net/detect-encoding#public-encoding-detectencodingtextreader-reader
        ///https://dotnetfiddle.net/Wa4VTT
        /// </summary>
        void Test103()
        {
            var html =
        @"<!DOCTYPE html>
<html>
<body>
	<h1>This is <b>bold</b> heading</h1>
	<p>This is <u>underlined</u> paragraph</p>
	<h2>This is <i>italic</i> heading</h2>
	<h2>This is new heading</h2>
</body>
</html>";

            var htmlDoc = new HtmlDocument();
            htmlDoc.LoadHtml(html);

            FileStream fs = new FileStream("Test.html", FileMode.Create);

            StreamWriter sw = new StreamWriter(fs, System.Text.Encoding.UTF32);

            htmlDoc.Save(sw);

            sw.Close();

            var htmlNewDoc = new HtmlDocument();

            var encoding = htmlNewDoc.DetectEncoding("Test.html");

            richTextBox1.WriteLine(encoding);
        }
        ///<summary>
        ///https://html-agility-pack.net/detect-encoding-and-load
        ///https://dotnetfiddle.net/9pO7lN
        /// </summary>
        void Test104()
        {
            var html =
        @"<!DOCTYPE html>
<html>
<body>
	<h1>This is <b>bold</b> heading</h1>
	<p>This is <u>underlined</u> paragraph</p>
	<h2>This is <i>italic</i> heading</h2>
	<h2>This is new heading</h2>
</body>
</html>";

            var htmlDoc = new HtmlDocument();
            htmlDoc.LoadHtml(html);

            FileStream fs = new FileStream("Test.html", FileMode.Create);

            StreamWriter sw = new StreamWriter(fs, System.Text.Encoding.UTF32);

            htmlDoc.Save(sw);

            sw.Close();

            var htmlNewDoc = new HtmlDocument();

            htmlNewDoc.DetectEncodingAndLoad("Test.html");

            richTextBox1.WriteLine("Encoding: {0}", htmlNewDoc.Encoding);

            richTextBox1.WriteLine(htmlNewDoc.DocumentNode.OuterHtml);
        }
        ///<summary>
        ///https://html-agility-pack.net/detect-encoding-and-load
        ///https://dotnetfiddle.net/LqhqAq
        /// </summary>
        void Test105()
        {
            var html =
        @"<!DOCTYPE html>
<html>
<body>
	<h1>This is <b>bold</b> heading</h1>
	<p>This is <u>underlined</u> paragraph</p>
	<h2>This is <i>italic</i> heading</h2>
	<h2>This is new heading</h2>
</body>
</html>";

            var htmlDoc = new HtmlDocument();
            htmlDoc.LoadHtml(html);

            FileStream fs = new FileStream("Test.html", FileMode.Create);

            StreamWriter sw = new StreamWriter(fs, System.Text.Encoding.UTF32);

            htmlDoc.Save(sw);

            sw.Close();

            var htmlNewDoc = new HtmlDocument();

            htmlNewDoc.DetectEncodingAndLoad("Test.html", true);

            richTextBox1.WriteLine("Encoding: {0}", htmlNewDoc.Encoding);

            richTextBox1.WriteLine(htmlNewDoc.DocumentNode.OuterHtml);
        }
        ///<summary>
        ///https://html-agility-pack.net/detect-encoding-and-load#public-void-detectencodingandloadstring-path-bool-detectencoding
        ///https://dotnetfiddle.net/LqhqAq
        /// </summary>
        void Test106()
        {
            var html =
        @"<!DOCTYPE html>
<html>
<body>
	<h1>This is <b>bold</b> heading</h1>
	<p>This is <u>underlined</u> paragraph</p>
	<h2>This is <i>italic</i> heading</h2>
	<h2>This is new heading</h2>
</body>
</html>";

            var htmlDoc = new HtmlDocument();
            htmlDoc.LoadHtml(html);

            FileStream fs = new FileStream("Test.html", FileMode.Create);

            StreamWriter sw = new StreamWriter(fs, System.Text.Encoding.UTF32);

            htmlDoc.Save(sw);

            sw.Close();

            var htmlNewDoc = new HtmlDocument();

            htmlNewDoc.DetectEncodingAndLoad("Test.html", true);

            richTextBox1.WriteLine("Encoding: {0}", htmlNewDoc.Encoding);

            richTextBox1.WriteLine(htmlNewDoc.DocumentNode.OuterHtml);
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
