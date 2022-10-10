using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0300__File_Directory_Stream.C0660__Using_Statement
{
    //http://www.java2s.com/Tutorial/CSharp/0300__File-Directory-Stream/Nestedusingstatement.htm
    public partial  class frmNestedusingstatement:Form
    {
        public frmNestedusingstatement()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmNestedusingstatement
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmNestedusingstatement";
            this.Text = "frmNestedusingstatement";
            this.Load += new System.EventHandler(this.frmNestedusingstatement_Load);
            this.ResumeLayout(false);

        }

        private void frmNestedusingstatement_Load(object sender, EventArgs e)
        {

        }
    }
}
