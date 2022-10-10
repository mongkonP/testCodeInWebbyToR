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
    //http://www.java2s.com/Tutorial/CSharp/0460__GUI-Windows-Forms/TrackBarSmallChangeLargeChangeMinimumMaximum.htm
    public partial  class frmTrackBarSmallChangeLargeChangeMinimumMaximum:Form
    {
        public frmTrackBarSmallChangeLargeChangeMinimumMaximum()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmTrackBarSmallChangeLargeChangeMinimumMaximum
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmTrackBarSmallChangeLargeChangeMinimumMaximum";
            this.Text = "frmTrackBarSmallChangeLargeChangeMinimumMaximum";
            this.Load += new System.EventHandler(this.frmTrackBarSmallChangeLargeChangeMinimumMaximum_Load);
            this.ResumeLayout(false);

        }

        private void frmTrackBarSmallChangeLargeChangeMinimumMaximum_Load(object sender, EventArgs e)
        {

        }
    }
}
