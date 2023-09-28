using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0470__Windows_Presentation_Foundation.C0840__Padding
{
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/Thesamepaddingonallfoursides.htm
    public partial  class frmThesamepaddingonallfoursides:Form
    {
        public frmThesamepaddingonallfoursides()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmThesamepaddingonallfoursides
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmThesamepaddingonallfoursides";
            this.Text = "frmThesamepaddingonallfoursides";
            this.Load += new System.EventHandler(this.frmThesamepaddingonallfoursides_Load);
            this.ResumeLayout(false);

        }

        private void frmThesamepaddingonallfoursides_Load(object sender, EventArgs e)
        {

        }
    }
}
