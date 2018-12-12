using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SharpMap.Layers;

namespace Map
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            var ofd = new OpenFileDialog();
            ofd.ShowDialog();

            Layer layer = new GdiImageLayer(ofd.FileName);
            mapBox1.Map.Layers.Add(layer);
            mapBox1.Map.ZoomToExtents();
            mapBox1.Refresh();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void mapBox1_Click(object sender, EventArgs e)
        {

        }

        private void mapZoomToolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void mapDigitizeGeometriesToolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
