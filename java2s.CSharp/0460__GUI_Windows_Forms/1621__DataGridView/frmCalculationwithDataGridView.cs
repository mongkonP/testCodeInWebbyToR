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
    //http://www.java2s.com/Tutorial/CSharp/0460__GUI-Windows-Forms/CalculationwithDataGridView.htm
    public partial  class frmCalculationwithDataGridView:Form
    {
        public frmCalculationwithDataGridView()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmCalculationwithDataGridView
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmCalculationwithDataGridView";
            this.Text = "frmCalculationwithDataGridView";
            this.Load += new System.EventHandler(this.frmCalculationwithDataGridView_Load);
            this.ResumeLayout(false);

        }

        private void frmCalculationwithDataGridView_Load(object sender, EventArgs e)
        {

        }
    }
}
