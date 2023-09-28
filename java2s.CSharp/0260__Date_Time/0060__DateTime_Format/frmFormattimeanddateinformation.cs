using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0260__Date_Time.C0060__DateTime_Format
{
    //http://www.java2s.com/Tutorial/CSharp/0260__Date-Time/Formattimeanddateinformation.htm
    public partial  class frmFormattimeanddateinformation:Form
    {
        public frmFormattimeanddateinformation()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmFormattimeanddateinformation
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmFormattimeanddateinformation";
            this.Text = "frmFormattimeanddateinformation";
            this.Load += new System.EventHandler(this.frmFormattimeanddateinformation_Load);
            this.ResumeLayout(false);

        }

        private void frmFormattimeanddateinformation_Load(object sender, EventArgs e)
        {

        }
    }
}
