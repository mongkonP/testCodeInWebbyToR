using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0480__2D.C0260__Color
{
    //http://www.java2s.com/Tutorial/CSharp/0480__2D/CreateColorobjectfromstring.htm
    public partial  class frmCreateColorobjectfromstring:Form
    {
        public frmCreateColorobjectfromstring()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmCreateColorobjectfromstring
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmCreateColorobjectfromstring";
            this.Text = "frmCreateColorobjectfromstring";
            this.Load += new System.EventHandler(this.frmCreateColorobjectfromstring_Load);
            this.ResumeLayout(false);

        }

        private void frmCreateColorobjectfromstring_Load(object sender, EventArgs e)
        {
            Color currColor = Color.FromName("Red");
            this.BackColor = currColor;
            this.Text = currColor.Name;
        }
    }
}
