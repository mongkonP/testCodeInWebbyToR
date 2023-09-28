using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0470__Windows_Presentation_Foundation.C1300__Path
{
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/LinewithPathGeometry.htm
    public partial  class frmLinewithPathGeometry:Form
    {
        public frmLinewithPathGeometry()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmLinewithPathGeometry
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmLinewithPathGeometry";
            this.Text = "frmLinewithPathGeometry";
            this.Load += new System.EventHandler(this.frmLinewithPathGeometry_Load);
            this.ResumeLayout(false);

        }

        private void frmLinewithPathGeometry_Load(object sender, EventArgs e)
        {

        }
    }
}
