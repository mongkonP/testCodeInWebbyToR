using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0460__GUI_Windows_Forms.C1100__Control_Relation
{
    //http://www.java2s.com/Tutorial/CSharp/0460__GUI-Windows-Forms/AmbientProperties.htm
    public partial  class frmAmbientProperties:Form
    {
        public frmAmbientProperties()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmAmbientProperties
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmAmbientProperties";
            this.Text = "frmAmbientProperties";
            this.Load += new System.EventHandler(this.frmAmbientProperties_Load);
            this.ResumeLayout(false);

        }

        private void frmAmbientProperties_Load(object sender, EventArgs e)
        {

        }
    }
}
