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
// Bibliotecile folosite


namespace To_do
{
    public partial class Form1 : Form
    {

        int number_of_tasks = 0;
        const int max_number_of_tasks=10;
        string text = "/10 tasks";
        bool[] valid_position = new bool[11] ; // pozitiile task-urilor

        public void Refresh_Counter() // Aceasta functie afiseaza numarul de  
        {                             // task-uri actuale si daca numarul de task-uri
                                      // actuale este egal cu numarul maxim de task-uri
                                      // se ascunde optiunea de a adauga
                                      // task-uri noi 
            Counter.Text = number_of_tasks.ToString() + text; // afisarea numarului curent de task.uri 

            if (number_of_tasks == max_number_of_tasks) // verifica daca se mai pot adauga task.uri
                Adition.Visible = false; // ascunde optiunea de a adauga
            else
                Adition.Visible = true; // face vizibila optiunea de a adauga
        }

        public Form1()
        {
            InitializeComponent(); 
            Refresh_Counter(); // contorul este afisat pentru prima oara 
            for (int i = 1; i <= max_number_of_tasks; i++) // la inceputul toate pozitiile sunt marcate ca fiind valide
                valid_position[i] = true;
        }
        private void Add_Click(object sender, EventArgs e)
        {
            // cand butonul Add este apasat :
            number_of_tasks++; // creste numarul de task-uri
            Refresh_Counter(); // se schimba afisajul si se verifica daca se mai pot adauga task-uri

            
            int width1 = 400,width2 = 350,width3=50;
            int height1 = 50;
                
            int position=0; // cautam o pozitie libera pentru task-ul nou
            for(int i=1;i<= max_number_of_tasks; i++)
                if( valid_position[i] )
                {
                    position = i;
                    valid_position[ position ] = false; // pozitia nu mai este libera
                    break;
                }

            // task-ul nou o sa fie pus intr-un GroupBox pentru a putea fi modificat cu usurinta
            var td_group = new GroupBox
            {
                Location = new Point(50, 30+position*(width3+10)),
                Size = new Size(width1,height1),
            };
            // in acest grup o sa avem :
            var td_text = new Label // un Label pentru afisarea textului dorit
            {
                Text = Input.Text,
                MaximumSize = new Size(width2, height1),
                AutoSize = true,
                BackColor = Color.DarkSeaGreen,
                Font = new Font(FontFamily.GenericSansSerif, 15, FontStyle.Bold),
            };
            td_group.Controls.Add(td_text); // adaugarea in grup
            var td_button = new System.Windows.Forms.Button // un Button pentru a putea sterge task-ul 
            {
                Text = "X",
                Size = new Size(width3, width3),
                Location = new Point (width2, 0),  
                ForeColor = Color.DarkSeaGreen,
            };
            td_group.Controls.Add(td_button);// adaugarea in grup
            
            Controls.Add(td_group); // adaugarea grupului 

            td_button.Click += new EventHandler(td_Delete );
            void td_Delete(object sender1, EventArgs e1) // stergerea task-ului
            {
                Controls.Remove(td_group);
                number_of_tasks--; // scade numarul de task-uri
                Refresh_Counter(); // se schimba afisajul
                valid_position[ position ] = true; // elibereaza pozitia task-ului sters
            }
        }

    }
}
