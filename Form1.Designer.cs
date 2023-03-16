namespace THA_W3_Ali_Azhar_D
{
    partial class Form1_Main_Window_Form
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
            this.label_Nama = new System.Windows.Forms.Label();
            this.button_OPen_Next_Form = new System.Windows.Forms.Button();
            this.label_Artis_Favorit = new System.Windows.Forms.Label();
            this.textBox_nama = new System.Windows.Forms.TextBox();
            this.textBox_FavArtist = new System.Windows.Forms.TextBox();
            this.button_Submit1 = new System.Windows.Forms.Button();
            this.checkBox_agree = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label_Nama
            // 
            this.label_Nama.AutoSize = true;
            this.label_Nama.Location = new System.Drawing.Point(148, 37);
            this.label_Nama.Name = "label_Nama";
            this.label_Nama.Size = new System.Drawing.Size(44, 16);
            this.label_Nama.TabIndex = 0;
            this.label_Nama.Text = "Nama";
            // 
            // button_OPen_Next_Form
            // 
            this.button_OPen_Next_Form.Location = new System.Drawing.Point(304, 393);
            this.button_OPen_Next_Form.Name = "button_OPen_Next_Form";
            this.button_OPen_Next_Form.Size = new System.Drawing.Size(150, 23);
            this.button_OPen_Next_Form.TabIndex = 1;
            this.button_OPen_Next_Form.Text = "Open Next Form";
            this.button_OPen_Next_Form.UseVisualStyleBackColor = true;
            this.button_OPen_Next_Form.Click += new System.EventHandler(this.button_OPen_Next_Form_Click);
            // 
            // label_Artis_Favorit
            // 
            this.label_Artis_Favorit.AutoSize = true;
            this.label_Artis_Favorit.Location = new System.Drawing.Point(108, 73);
            this.label_Artis_Favorit.Name = "label_Artis_Favorit";
            this.label_Artis_Favorit.Size = new System.Drawing.Size(109, 16);
            this.label_Artis_Favorit.TabIndex = 3;
            this.label_Artis_Favorit.Text = "My Favorite Artist";
            // 
            // textBox_nama
            // 
            this.textBox_nama.Location = new System.Drawing.Point(232, 37);
            this.textBox_nama.Name = "textBox_nama";
            this.textBox_nama.Size = new System.Drawing.Size(100, 22);
            this.textBox_nama.TabIndex = 4;
            // 
            // textBox_FavArtist
            // 
            this.textBox_FavArtist.Location = new System.Drawing.Point(232, 73);
            this.textBox_FavArtist.Name = "textBox_FavArtist";
            this.textBox_FavArtist.Size = new System.Drawing.Size(100, 22);
            this.textBox_FavArtist.TabIndex = 5;
            // 
            // button_Submit1
            // 
            this.button_Submit1.Enabled = false;
            this.button_Submit1.Location = new System.Drawing.Point(216, 144);
            this.button_Submit1.Name = "button_Submit1";
            this.button_Submit1.Size = new System.Drawing.Size(75, 23);
            this.button_Submit1.TabIndex = 6;
            this.button_Submit1.Text = "Submit";
            this.button_Submit1.UseVisualStyleBackColor = true;
            this.button_Submit1.Click += new System.EventHandler(this.button_Submit1_Click);
            // 
            // checkBox_agree
            // 
            this.checkBox_agree.AutoSize = true;
            this.checkBox_agree.Location = new System.Drawing.Point(232, 101);
            this.checkBox_agree.Name = "checkBox_agree";
            this.checkBox_agree.Size = new System.Drawing.Size(235, 20);
            this.checkBox_agree.TabIndex = 7;
            this.checkBox_agree.Text = "All of the content i put above is true!";
            this.checkBox_agree.UseVisualStyleBackColor = true;
            this.checkBox_agree.CheckedChanged += new System.EventHandler(this.checkBox_agree_CheckedChanged);
            // 
            // Form1_Main_Window_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.checkBox_agree);
            this.Controls.Add(this.button_Submit1);
            this.Controls.Add(this.textBox_FavArtist);
            this.Controls.Add(this.textBox_nama);
            this.Controls.Add(this.label_Artis_Favorit);
            this.Controls.Add(this.button_OPen_Next_Form);
            this.Controls.Add(this.label_Nama);
            this.Name = "Form1_Main_Window_Form";
            this.Text = "Main Window Form";
            this.Load += new System.EventHandler(this.Form1_Main_Window_Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Nama;
        private System.Windows.Forms.Button button_OPen_Next_Form;
        private System.Windows.Forms.Label label_Artis_Favorit;
        private System.Windows.Forms.TextBox textBox_nama;
        private System.Windows.Forms.TextBox textBox_FavArtist;
        private System.Windows.Forms.Button button_Submit1;
        private System.Windows.Forms.CheckBox checkBox_agree;
    }
}

