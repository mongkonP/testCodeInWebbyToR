using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0040__Data_Type.C0060__Integer_Family
{
    //http://www.java2s.com/Tutorial/CSharp/0040__Data-Type/Integerranges.htm
    public partial  class frmIntegerranges:Form
    {
        public frmIntegerranges()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmIntegerranges
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmIntegerranges";
            this.Text = "frmIntegerranges";
            this.Load += new System.EventHandler(this.frmIntegerranges_Load);
            this.ResumeLayout(false);

        }

        private void frmIntegerranges_Load(object sender, EventArgs e)
        {

        }
    }
}
