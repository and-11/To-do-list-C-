namespace To_do
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Add = new System.Windows.Forms.Button();
            this.Input = new System.Windows.Forms.TextBox();
            this.Counter = new System.Windows.Forms.Label();
            this.Adition = new System.Windows.Forms.GroupBox();
            this.Title = new System.Windows.Forms.Label();
            this.Adition.SuspendLayout();
            this.SuspendLayout();
            // 
            // Add
            // 
            this.Add.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.Add.Location = new System.Drawing.Point(19, 91);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(350, 50);
            this.Add.TabIndex = 0;
            this.Add.Text = "ADD";
            this.Add.UseVisualStyleBackColor = false;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // Input
            // 
            this.Input.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.Input.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.Input.Location = new System.Drawing.Point(19, 35);
            this.Input.Multiline = true;
            this.Input.Name = "Input";
            this.Input.Size = new System.Drawing.Size(350, 50);
            this.Input.TabIndex = 2;
            this.Input.TextChanged += new System.EventHandler(this.Input_TextChanged);
            // 
            // Counter
            // 
            this.Counter.AutoSize = true;
            this.Counter.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.Counter.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.Counter.Location = new System.Drawing.Point(678, 57);
            this.Counter.Name = "Counter";
            this.Counter.Size = new System.Drawing.Size(87, 29);
            this.Counter.TabIndex = 3;
            this.Counter.Text = "label1";
            // 
            // Adition
            // 
            this.Adition.Controls.Add(this.Add);
            this.Adition.Controls.Add(this.Input);
            this.Adition.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.Adition.Location = new System.Drawing.Point(683, 123);
            this.Adition.Name = "Adition";
            this.Adition.Size = new System.Drawing.Size(400, 150);
            this.Adition.TabIndex = 4;
            this.Adition.TabStop = false;
            this.Adition.Text = "Adition";
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.Location = new System.Drawing.Point(50, 50);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(106, 36);
            this.Title.TabIndex = 5;
            this.Title.Text = "To do:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1125, 890);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.Adition);
            this.Controls.Add(this.Counter);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Adition.ResumeLayout(false);
            this.Adition.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.TextBox Input;
        private System.Windows.Forms.Label Counter;
        private System.Windows.Forms.GroupBox Adition;
        private System.Windows.Forms.Label Title;
    }
}

