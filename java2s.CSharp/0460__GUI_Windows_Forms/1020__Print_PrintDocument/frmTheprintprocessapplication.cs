using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0460__GUI_Windows_Forms.C1020__Print_PrintDocument
{
    //http://www.java2s.com/Tutorial/CSharp/0460__GUI-Windows-Forms/Theprintprocessapplication.htm
    public partial  class frmTheprintprocessapplication:Form
    {
        public frmTheprintprocessapplication()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmTheprintprocessapplication
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmTheprintprocessapplication";
            this.Text = "frmTheprintprocessapplication";
            this.Load += new System.EventHandler(this.frmTheprintprocessapplication_Load);
            this.ResumeLayout(false);

        }

        private void frmTheprintprocessapplication_Load(object sender, EventArgs e)
        {

        }
    }
}
