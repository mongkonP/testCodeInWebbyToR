using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0450__LINQ.C0160__where
{
    //http://www.java2s.com/Tutorial/CSharp/0450__LINQ/Filterstringbyitslength.htm
    public partial  class frmFilterstringbyitslength:Form
    {
        public frmFilterstringbyitslength()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmFilterstringbyitslength
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmFilterstringbyitslength";
            this.Text = "frmFilterstringbyitslength";
            this.Load += new System.EventHandler(this.frmFilterstringbyitslength_Load);
            this.ResumeLayout(false);

        }

        private void frmFilterstringbyitslength_Load(object sender, EventArgs e)
        {

        }
    }
}
