using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace To_do
{
    public partial class Form1 : Form
    {
        int number_of_tasks = 0;
        const int max_number_of_tasks=10;
        string text = "/10 tasks";
        bool[] valid_position = new bool[11] ;
        public Form1()
        {
            InitializeComponent();
            Refresh_Counter();
            for (int i = 1; i <= max_number_of_tasks; i++)
                valid_position[i] = true;
        }
        public void Refresh_Counter()
        {
            Counter.Text = number_of_tasks.ToString() + text;
            if (number_of_tasks >= max_number_of_tasks)
                Adition.Visible = false;
            else
                Adition.Visible = true;
        }
        private void Add_Click(object sender, EventArgs e)
        {
            number_of_tasks++;
            Refresh_Counter();
            int position=0;

            int width1 = 400,width2 = 350,width3=50;
            int height1 = 50;

            for(int i=1;i<= max_number_of_tasks; i++)
                if( valid_position[i] )
                {
                    position = i;
                    valid_position[ position ] = false;
                    break;
                }

            var td_group = new GroupBox
            {
                Location = new Point(50, 30+position*(width3+10)),
                Size = new Size(width1,height1),
            };

            var td_text = new Label
            {
                Text = Input.Text,
                MaximumSize = new Size(width2,height1),
                AutoSize = true,
                BackColor = Color.DarkSeaGreen,
                Font = new Font( FontFamily.GenericSansSerif, 15 , FontStyle.Bold ),
            };

            td_group.Controls.Add(td_text);

            var td_button = new System.Windows.Forms.Button
            {
                Text = "X",
                Size = new Size(width3, width3),
                Location = new Point (width2, 0),  
                ForeColor = Color.DarkSeaGreen,
            };
            td_group.Controls.Add(td_button);

            Controls.Add(td_group);

            td_button.Click += new EventHandler(td_Delete );
            void td_Delete(object sender1, EventArgs e1) 
            {
                Controls.Remove(td_group);
                number_of_tasks--;
                Refresh_Counter();
                valid_position[ position ] = true;
            }
        }

        private void Input_TextChanged(object sender, EventArgs e)
        {

        }
    }



}
