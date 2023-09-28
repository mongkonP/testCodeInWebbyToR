using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0460__GUI_Windows_Forms.C0420__TrackBar
{
    //http://www.java2s.com/Tutorial/CSharp/0460__GUI-Windows-Forms/TractBarLargeSmallrange.htm
    public partial  class frmTractBarLargeSmallrange:Form
    {
        public frmTractBarLargeSmallrange()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmTractBarLargeSmallrange
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmTractBarLargeSmallrange";
            this.Text = "frmTractBarLargeSmallrange";
            this.Load += new System.EventHandler(this.frmTractBarLargeSmallrange_Load);
            this.ResumeLayout(false);

        }

        private void frmTractBarLargeSmallrange_Load(object sender, EventArgs e)
        {

        }
    }
}
