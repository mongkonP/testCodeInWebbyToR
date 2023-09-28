using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0080__Statement.C0060__For
{
    //http://www.java2s.com/Tutorial/CSharp/0080__Statement/Thebodyofaloopcanbeempty.htm
    public partial  class frmThebodyofaloopcanbeempty:Form
    {
        public frmThebodyofaloopcanbeempty()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmThebodyofaloopcanbeempty
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmThebodyofaloopcanbeempty";
            this.Text = "frmThebodyofaloopcanbeempty";
            this.Load += new System.EventHandler(this.frmThebodyofaloopcanbeempty_Load);
            this.ResumeLayout(false);

        }

        private void frmThebodyofaloopcanbeempty_Load(object sender, EventArgs e)
        {

        }
    }
}
