using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace testCodeInWebbyToR.Code_c_sharpcorner
{
    public partial class frmListViewSampleInCSharp : Form
    {
        public frmListViewSampleInCSharp()
        {
            InitializeComponent();

        }

        Button btn = new Button();
        //https://www.c-sharpcorner.com/UploadFile/mahesh/working-with-listview-in-C-Sharp/
        private void frmListViewSampleInCSharp_Load(object sender, EventArgs e)
        {
            /*  ListViewItem[] lvs = new ListViewItem[3];
              lvs[0] = new ListViewItem(new string[] { "row 1 column 1", "row 1 column 2", "" });
              lvs[1] = new ListViewItem(new string[] { "row 2 column 1", "row 2 column 2", "" });
              lvs[2] = new ListViewItem(new string[] { "row 3 column 1", "row 3 column 2", "" });*/
            System.IO.Directory.GetFiles(@"D:\Song YT", "*.mp3", System.IO.SearchOption.AllDirectories).ToList<string>()
                  .ForEach(f =>
                  {

                      this.listView1.Items.Add(
                          new ListViewItem(new string[] { f, "" }));
                  });


            btn.Visible = false;
            btn.Text = "Delete";
            btn.Click += this.button_Click;
            this.listView1.Controls.Add(btn);
            this.btn.Size = new Size(this.listView1.Items[0].SubItems[1].Bounds.Width,
            this.listView1.Items[0].SubItems[1].Bounds.Height);
        }
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListViewItem[] lvs = new ListViewItem[3];
            if (this.listView1.SelectedItems.Count > 0)
            {
                this.btn.Location = new Point(this.listView1.SelectedItems[0].SubItems[1].Bounds.Left, this.listView1.SelectedItems[0].SubItems[1].Bounds.Top);
                this.btn.Visible = true;
            }
        }
        private void button_Click(object sender, EventArgs e)
        {
            MessageBox.Show(this.listView1.SelectedItems[0].SubItems[0].Text);
        }
    }
}
