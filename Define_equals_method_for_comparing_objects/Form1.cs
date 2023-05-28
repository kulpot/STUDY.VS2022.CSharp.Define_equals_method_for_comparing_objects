using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Define_equals_method_for_comparing_objects
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            Vertex vertex1 = new Vertex(2, 3, 4);
            Vertex vertex2 = new Vertex(2, 3, 4); // equal
            Vertex vertex3 = new Vertex(9, 9, 9); // not equal
            bool b = false; // not equal
            Stopwatch stopwatch = new Stopwatch(); // not equal

            this.Text = vertex1.Equals(vertex2).ToString();
            //this.Text = vertex1.Equals(stopwatch).ToString();
        }
    }
}
