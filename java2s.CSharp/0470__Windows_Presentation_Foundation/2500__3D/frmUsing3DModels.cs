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
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/Using3DModels.htm
    public partial  class frmUsing3DModels:Form
    {
        public frmUsing3DModels()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmUsing3DModels
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmUsing3DModels";
            this.Text = "frmUsing3DModels";
            this.Load += new System.EventHandler(this.frmUsing3DModels_Load);
            this.ResumeLayout(false);

        }

        private void frmUsing3DModels_Load(object sender, EventArgs e)
        {

        }
    }
}
