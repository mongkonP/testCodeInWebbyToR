using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0280__Development.C0360__GC
{
    //http://www.java2s.com/Tutorial/CSharp/0280__Development/Garbagecollectiontype.htm
    public partial  class frmGarbagecollectiontype:Form
    {
        public frmGarbagecollectiontype()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmGarbagecollectiontype
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmGarbagecollectiontype";
            this.Text = "frmGarbagecollectiontype";
            this.Load += new System.EventHandler(this.frmGarbagecollectiontype_Load);
            this.ResumeLayout(false);

        }

        private void frmGarbagecollectiontype_Load(object sender, EventArgs e)
        {

        }
    }
}
