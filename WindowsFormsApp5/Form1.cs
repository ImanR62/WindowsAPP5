using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        bool select(Human h)
        {
            db db1=new db();
            foreach (var item in db1.humen)
            {
                if(h.name==item.name && h.family == item.family)
                {
                    return true;
                    
                }
                
            }
            return false;
            
            {

            }
        }
        
        void clearTextbox()
        {
            foreach(var item in Controls)
            {
                if (item.GetType().ToString() == "System.Windows.Forms.TextBox")
                {
                    (item as TextBox).Clear();
                    textBox1.Focus();
                }
            }
        }

        void register(Human form) 
        {
            db db1=new db();
            if (form.age>=18)
            {
                db1.humen.Add(form);
                db1.SaveChanges();
                //MessageBox.Show("has been recorded");
                this.Text = "has been recorded ";
            }
            else
            {
                MessageBox.Show("Age should be bigger than 18");
            }
        }
        void updateGridView()
        {
            db db1 = new db();
            dataGridView1.DataSource = db1.humen.ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            db db1 = new db();
            Human form= new Human{ name = textBox1.Text, family = textBox2.Text, age = Convert.ToByte(textBox3.Text) };
            if (select(form))
            {
                MessageBox.Show("It is duplicate", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                register(form);
            }
            //register (new Human { name=textBox1.Text,family=textBox2.Text,age=Convert.ToByte(textBox3.Text)});
            clearTextbox();
            updateGridView();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            updateGridView();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            db db1 = new db();
            List<Human> searchlist = new List<Human>();
            if (textBox4.Text.Length>0)
            {
                foreach (var item in db1.humen)
                {
                    if (item.name.Contains(textBox4.Text) || item.family.Contains(textBox4.Text))
                    {
                        searchlist.Add(item);

                    }

                }


                dataGridView1.DataSource = null;
                dataGridView1.DataSource = searchlist.ToList();
            }
           
           


        }

        private void button3_Click(object sender, EventArgs e)
        {
            updateGridView();
        }
    }
}
