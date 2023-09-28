using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0560__ADO.Net.C0260__SqlConnection_Stored_Procedure
{
    //http://www.java2s.com/Tutorial/CSharp/0560__ADO.Net/Catchexceptionwhencallingstoredprocedure.htm
    public partial  class frmCatchexceptionwhencallingstoredprocedure:Form
    {
        public frmCatchexceptionwhencallingstoredprocedure()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmCatchexceptionwhencallingstoredprocedure
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmCatchexceptionwhencallingstoredprocedure";
            this.Text = "frmCatchexceptionwhencallingstoredprocedure";
            this.Load += new System.EventHandler(this.frmCatchexceptionwhencallingstoredprocedure_Load);
            this.ResumeLayout(false);

        }

        private void frmCatchexceptionwhencallingstoredprocedure_Load(object sender, EventArgs e)
        {

        }
    }
}
