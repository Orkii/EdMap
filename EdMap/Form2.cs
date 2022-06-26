using GMap.NET.WindowsForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EdMap {
    partial class Form2 : Form {
        public Form2(Point item) {
            point = item;
            InitializeComponent();
            numericUpDown1.Value = (decimal)point.weight;
            numericUpDown1.DecimalPlaces = 2;
        }
        Point point;
        private void button1_Click(object sender, EventArgs e) {
            point.weight = Convert.ToSingle(numericUpDown1.Value);
            point.marker.ToolTipText = point.ToString()/* + "\n" + "Вес " + point.weight*/;
            Console.WriteLine(Convert.ToSingle(numericUpDown1.Value));
            Console.WriteLine(point.weight);
            this.Close();
        }
    }
}
