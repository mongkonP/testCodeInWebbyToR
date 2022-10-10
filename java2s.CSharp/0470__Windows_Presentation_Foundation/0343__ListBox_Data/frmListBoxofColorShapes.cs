using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0470__Windows_Presentation_Foundation.C0343__ListBox_Data
{
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/ListBoxofColorShapes.htm
    public partial  class frmListBoxofColorShapes:Form
    {
        public frmListBoxofColorShapes()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmListBoxofColorShapes
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmListBoxofColorShapes";
            this.Text = "frmListBoxofColorShapes";
            this.Load += new System.EventHandler(this.frmListBoxofColorShapes_Load);
            this.ResumeLayout(false);

        }

        private void frmListBoxofColorShapes_Load(object sender, EventArgs e)
        {

        }
    }
}
