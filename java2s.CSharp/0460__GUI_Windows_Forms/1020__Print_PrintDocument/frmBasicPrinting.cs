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
    //http://www.java2s.com/Tutorial/CSharp/0460__GUI-Windows-Forms/BasicPrinting.htm
    public partial  class frmBasicPrinting:Form
    {
        public frmBasicPrinting()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmBasicPrinting
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmBasicPrinting";
            this.Text = "frmBasicPrinting";
            this.Load += new System.EventHandler(this.frmBasicPrinting_Load);
            this.ResumeLayout(false);

        }

        private void frmBasicPrinting_Load(object sender, EventArgs e)
        {

        }
    }
}
