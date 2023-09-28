using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0140__Class.C0520__Name_Hiding
{
    //http://www.java2s.com/Tutorial/CSharp/0140__Class/Anexampleofinheritancerelatednamehiding.htm
    public partial  class frmAnexampleofinheritancerelatednamehiding:Form
    {
        public frmAnexampleofinheritancerelatednamehiding()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmAnexampleofinheritancerelatednamehiding
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmAnexampleofinheritancerelatednamehiding";
            this.Text = "frmAnexampleofinheritancerelatednamehiding";
            this.Load += new System.EventHandler(this.frmAnexampleofinheritancerelatednamehiding_Load);
            this.ResumeLayout(false);

        }

        private void frmAnexampleofinheritancerelatednamehiding_Load(object sender, EventArgs e)
        {

        }
    }
}
