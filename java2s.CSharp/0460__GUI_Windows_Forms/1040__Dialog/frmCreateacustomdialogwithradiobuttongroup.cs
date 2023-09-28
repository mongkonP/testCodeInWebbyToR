using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0460__GUI_Windows_Forms.C1040__Dialog
{
    //http://www.java2s.com/Tutorial/CSharp/0460__GUI-Windows-Forms/Createacustomdialogwithradiobuttongroup.htm
    public partial  class frmCreateacustomdialogwithradiobuttongroup:Form
    {
        public frmCreateacustomdialogwithradiobuttongroup()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmCreateacustomdialogwithradiobuttongroup
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmCreateacustomdialogwithradiobuttongroup";
            this.Text = "frmCreateacustomdialogwithradiobuttongroup";
            this.Load += new System.EventHandler(this.frmCreateacustomdialogwithradiobuttongroup_Load);
            this.ResumeLayout(false);

        }

        private void frmCreateacustomdialogwithradiobuttongroup_Load(object sender, EventArgs e)
        {

        }
    }
}
