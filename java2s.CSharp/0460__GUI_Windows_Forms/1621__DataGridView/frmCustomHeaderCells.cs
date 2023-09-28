using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0460__GUI_Windows_Forms.C1621__DataGridView
{
    //http://www.java2s.com/Tutorial/CSharp/0460__GUI-Windows-Forms/CustomHeaderCells.htm
    public partial  class frmCustomHeaderCells:Form
    {
        public frmCustomHeaderCells()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmCustomHeaderCells
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmCustomHeaderCells";
            this.Text = "frmCustomHeaderCells";
            this.Load += new System.EventHandler(this.frmCustomHeaderCells_Load);
            this.ResumeLayout(false);

        }

        private void frmCustomHeaderCells_Load(object sender, EventArgs e)
        {

        }
    }
}
