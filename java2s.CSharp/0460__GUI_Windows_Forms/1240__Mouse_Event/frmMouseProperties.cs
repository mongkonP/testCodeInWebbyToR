using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0460__GUI_Windows_Forms.C1240__Mouse_Event
{
    //http://www.java2s.com/Tutorial/CSharp/0460__GUI-Windows-Forms/MouseProperties.htm
    public partial  class frmMouseProperties:Form
    {
        public frmMouseProperties()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmMouseProperties
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmMouseProperties";
            this.Text = "frmMouseProperties";
            this.Load += new System.EventHandler(this.frmMouseProperties_Load);
            this.ResumeLayout(false);

        }

        private void frmMouseProperties_Load(object sender, EventArgs e)
        {

        }
    }
}
