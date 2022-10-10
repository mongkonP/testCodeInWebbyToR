using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0560__ADO.Net.C0980__Text_File_Load_Save
{
    //http://www.java2s.com/Tutorial/CSharp/0560__ADO.Net/Savetextfromdatabasetotextfile.htm
    public partial  class frmSavetextfromdatabasetotextfile:Form
    {
        public frmSavetextfromdatabasetotextfile()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmSavetextfromdatabasetotextfile
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmSavetextfromdatabasetotextfile";
            this.Text = "frmSavetextfromdatabasetotextfile";
            this.Load += new System.EventHandler(this.frmSavetextfromdatabasetotextfile_Load);
            this.ResumeLayout(false);

        }

        private void frmSavetextfromdatabasetotextfile_Load(object sender, EventArgs e)
        {

        }
    }
}
