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
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/Interactwith3DObjects.htm
    public partial  class frmInteractwith3DObjects:Form
    {
        public frmInteractwith3DObjects()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmInteractwith3DObjects
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmInteractwith3DObjects";
            this.Text = "frmInteractwith3DObjects";
            this.Load += new System.EventHandler(this.frmInteractwith3DObjects_Load);
            this.ResumeLayout(false);

        }

        private void frmInteractwith3DObjects_Load(object sender, EventArgs e)
        {

        }
    }
}
