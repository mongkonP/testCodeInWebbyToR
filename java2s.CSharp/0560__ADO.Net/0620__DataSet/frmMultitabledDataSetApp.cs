using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0560__ADO.Net.C0620__DataSet
{
    //http://www.java2s.com/Tutorial/CSharp/0560__ADO.Net/MultitabledDataSetApp.htm
    public partial  class frmMultitabledDataSetApp:Form
    {
        public frmMultitabledDataSetApp()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmMultitabledDataSetApp
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmMultitabledDataSetApp";
            this.Text = "frmMultitabledDataSetApp";
            this.Load += new System.EventHandler(this.frmMultitabledDataSetApp_Load);
            this.ResumeLayout(false);

        }

        private void frmMultitabledDataSetApp_Load(object sender, EventArgs e)
        {

        }
    }
}
