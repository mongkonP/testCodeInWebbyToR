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
    //http://www.java2s.com/Tutorial/CSharp/0460__GUI-Windows-Forms/Theprintpreviewapplication.htm
    public partial  class frmTheprintpreviewapplication:Form
    {
        public frmTheprintpreviewapplication()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmTheprintpreviewapplication
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmTheprintpreviewapplication";
            this.Text = "frmTheprintpreviewapplication";
            this.Load += new System.EventHandler(this.frmTheprintpreviewapplication_Load);
            this.ResumeLayout(false);

        }

        private void frmTheprintpreviewapplication_Load(object sender, EventArgs e)
        {

        }
    }
}
