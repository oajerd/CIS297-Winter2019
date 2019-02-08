using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Generics
{
    public partial class Form1 : Form
    {
        List<string> objects;
        Dictionary<string, double> grades;
        List<Vehicle> vehicles;
        public Form1()
        {
            InitializeComponent();
            objects = new List<string>();
            grades = new Dictionary<string, double>();
            vehicles = new List<Vehicle>();
        }

        //public void updateLabel()
        //{
        //    grades.Add("Eric", 99.9);
        //    label1.Text = "";
        //    foreach( var o in objects)
        //    {
        //        //Random rand = o as Random ;
        //        if ( rand != null )
        //        {
        //            label1.Text += rand.Next() + "\n";
        //        }
        //        else
        //        {
        //            label1.Text += o.ToString() + "\n";
        //        }


                
        //    }
        //}

        //private void button1_Click(object sender, EventArgs e)
        //{
        //    objects.Add("Eric");
        //    updateLabel();
        //}

        //private void button2_Click(object sender, EventArgs e)
        //{
        //    objects.Add(42);
        //    updateLabel();
        //}

        //private void button3_Click(object sender, EventArgs e)
        //{
        //    objects.Add(3.14);
        //    updateLabel();
        //}

        //private void button4_Click(object sender, EventArgs e)
        //{
        //    objects.Add(new Random());
        //    updateLabel();
        //}

        private void button1_Click_1(object sender, EventArgs e)
        {
            Random random = new Random();
            Vehicle first = vehicles[random.Next(vehicles.Count)];
            Vehicle second = vehicles[random.Next(vehicles.Count)];
            Race<Vehicle> race = new Race<Vehicle>(first, second);
            label2.Text = race.Result;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if ( !string.IsNullOrEmpty(makeTextBox.Text) &&
                !string.IsNullOrEmpty(modelTextBox.Text) &&
                !string.IsNullOrEmpty(qmtTextBox.Text) )
            {
                vehicles.Add(new Vehicle(makeTextBox.Text, modelTextBox.Text, Convert.ToDouble(qmtTextBox.Text)));
            }
        }
    }
}
