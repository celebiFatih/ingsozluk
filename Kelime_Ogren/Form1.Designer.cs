namespace Kelime_Ogren
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
            this.components = new System.ComponentModel.Container();
            this.lblIng = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIng = new System.Windows.Forms.TextBox();
            this.txtTurk = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.lblSure = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblKelime = new System.Windows.Forms.Label();
            this.lblCevap = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblIng
            // 
            this.lblIng.AutoSize = true;
            this.lblIng.Location = new System.Drawing.Point(95, 65);
            this.lblIng.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIng.Name = "lblIng";
            this.lblIng.Size = new System.Drawing.Size(59, 16);
            this.lblIng.TabIndex = 0;
            this.lblIng.Text = "İngilizce:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(95, 101);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Türkçe:";
            // 
            // txtIng
            // 
            this.txtIng.Location = new System.Drawing.Point(190, 65);
            this.txtIng.Margin = new System.Windows.Forms.Padding(4);
            this.txtIng.Name = "txtIng";
            this.txtIng.Size = new System.Drawing.Size(132, 22);
            this.txtIng.TabIndex = 2;
            // 
            // txtTurk
            // 
            this.txtTurk.Location = new System.Drawing.Point(190, 97);
            this.txtTurk.Margin = new System.Windows.Forms.Padding(4);
            this.txtTurk.Name = "txtTurk";
            this.txtTurk.Size = new System.Drawing.Size(132, 22);
            this.txtTurk.TabIndex = 1;
            this.txtTurk.TextChanged += new System.EventHandler(this.txtTurk_TextChanged);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(374, 65);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Süre:";
            // 
            // lblSure
            // 
            this.lblSure.AutoSize = true;
            this.lblSure.Location = new System.Drawing.Point(432, 65);
            this.lblSure.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSure.Name = "lblSure";
            this.lblSure.Size = new System.Drawing.Size(22, 16);
            this.lblSure.TabIndex = 5;
            this.lblSure.Text = "90";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(374, 100);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Kelime:";
            // 
            // lblKelime
            // 
            this.lblKelime.AutoSize = true;
            this.lblKelime.Location = new System.Drawing.Point(434, 103);
            this.lblKelime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblKelime.Name = "lblKelime";
            this.lblKelime.Size = new System.Drawing.Size(15, 16);
            this.lblKelime.TabIndex = 7;
            this.lblKelime.Text = "0";
            // 
            // lblCevap
            // 
            this.lblCevap.AutoSize = true;
            this.lblCevap.Location = new System.Drawing.Point(228, 45);
            this.lblCevap.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCevap.Name = "lblCevap";
            this.lblCevap.Size = new System.Drawing.Size(53, 16);
            this.lblCevap.TabIndex = 8;
            this.lblCevap.Text = "Türkçe:";
            this.lblCevap.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 196);
            this.Controls.Add(this.lblCevap);
            this.Controls.Add(this.lblKelime);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblSure);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTurk);
            this.Controls.Add(this.txtIng);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblIng);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIng;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIng;
        private System.Windows.Forms.TextBox txtTurk;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblSure;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblKelime;
        private System.Windows.Forms.Label lblCevap;
    }
}