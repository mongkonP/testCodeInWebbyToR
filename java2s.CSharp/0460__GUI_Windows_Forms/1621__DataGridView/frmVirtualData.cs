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
    //http://www.java2s.com/Tutorial/CSharp/0460__GUI-Windows-Forms/VirtualData.htm
    public partial  class frmVirtualData:Form
    {
        public frmVirtualData()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmVirtualData
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmVirtualData";
            this.Text = "frmVirtualData";
            this.Load += new System.EventHandler(this.frmVirtualData_Load);
            this.ResumeLayout(false);

        }

        private void frmVirtualData_Load(object sender, EventArgs e)
        {

        }
    }
}
