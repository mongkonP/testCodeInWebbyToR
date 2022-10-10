using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0560__ADO.Net.C0420__SqlCommandBuilder
{
    //http://www.java2s.com/Tutorial/CSharp/0560__ADO.Net/DeleteDatausingCommandBuilder.htm
    public partial  class frmDeleteDatausingCommandBuilder:Form
    {
        public frmDeleteDatausingCommandBuilder()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmDeleteDatausingCommandBuilder
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmDeleteDatausingCommandBuilder";
            this.Text = "frmDeleteDatausingCommandBuilder";
            this.Load += new System.EventHandler(this.frmDeleteDatausingCommandBuilder_Load);
            this.ResumeLayout(false);

        }

        private void frmDeleteDatausingCommandBuilder_Load(object sender, EventArgs e)
        {

        }
    }
}
