using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listView1.View = View.Details;

            listView1.GridLines = true;

            listView1.FullRowSelect = true;



            // Add column

            listView1.Columns.Add("No", 30);

            listView1.Columns.Add("Name", 500);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] arr = new string[4];

            ListViewItem itm;



            // Add item

            arr[0] = "1";

            arr[1] = "Name 1";

            itm = new ListViewItem(arr);

            listView1.Items.Add(itm);



            arr[0] = "2";

            arr[1] = "Name 2";

            itm = new ListViewItem(arr);

            listView1.Items.Add(itm);
        }
    }
}
