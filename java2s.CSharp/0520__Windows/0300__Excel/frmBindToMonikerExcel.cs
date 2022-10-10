using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0520__Windows.C0300__Excel
{
    //http://www.java2s.com/Tutorial/CSharp/0520__Windows/BindToMonikerExcel.htm
    public partial  class frmBindToMonikerExcel:Form
    {
        public frmBindToMonikerExcel()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmBindToMonikerExcel
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmBindToMonikerExcel";
            this.Text = "frmBindToMonikerExcel";
            this.Load += new System.EventHandler(this.frmBindToMonikerExcel_Load);
            this.ResumeLayout(false);

        }

        private void frmBindToMonikerExcel_Load(object sender, EventArgs e)
        {

        }
    }
}
