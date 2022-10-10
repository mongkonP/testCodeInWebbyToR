using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0460__GUI_Windows_Forms.C0100__Form_Properties
{
    //http://www.java2s.com/Tutorial/CSharp/0460__GUI-Windows-Forms/CenterFormtothescreen.htm
    public partial  class frmCenterFormtothescreen:Form
    {
        public frmCenterFormtothescreen()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmCenterFormtothescreen
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmCenterFormtothescreen";
            this.Text = "frmCenterFormtothescreen";
            this.Load += new System.EventHandler(this.frmCenterFormtothescreen_Load);
            this.ResumeLayout(false);

        }

        private void frmCenterFormtothescreen_Load(object sender, EventArgs e)
        {

        }
    }
}
