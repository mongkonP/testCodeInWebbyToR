using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0470__Windows_Presentation_Foundation.C2500__3D
{
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/Ambientlight.htm
    public partial  class frmAmbientlight:Form
    {
        public frmAmbientlight()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmAmbientlight
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmAmbientlight";
            this.Text = "frmAmbientlight";
            this.Load += new System.EventHandler(this.frmAmbientlight_Load);
            this.ResumeLayout(false);

        }

        private void frmAmbientlight_Load(object sender, EventArgs e)
        {

        }
    }
}
