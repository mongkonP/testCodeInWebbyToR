using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0470__Windows_Presentation_Foundation.C1880__Mouse
{
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/MousePositionandTranslateTransform.htm
    public partial  class frmMousePositionandTranslateTransform:Form
    {
        public frmMousePositionandTranslateTransform()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmMousePositionandTranslateTransform
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmMousePositionandTranslateTransform";
            this.Text = "frmMousePositionandTranslateTransform";
            this.Load += new System.EventHandler(this.frmMousePositionandTranslateTransform_Load);
            this.ResumeLayout(false);

        }

        private void frmMousePositionandTranslateTransform_Load(object sender, EventArgs e)
        {

        }
    }
}
