using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0541__XML_LINQ.C0080__Query
{
    //http://www.java2s.com/Tutorial/CSharp/0541__XML-LINQ/UsingLinqToqueryXml.htm
    public partial  class frmUsingLinqToqueryXml:Form
    {
        public frmUsingLinqToqueryXml()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmUsingLinqToqueryXml
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmUsingLinqToqueryXml";
            this.Text = "frmUsingLinqToqueryXml";
            this.Load += new System.EventHandler(this.frmUsingLinqToqueryXml_Load);
            this.ResumeLayout(false);

        }

        private void frmUsingLinqToqueryXml_Load(object sender, EventArgs e)
        {

        }
    }
}
