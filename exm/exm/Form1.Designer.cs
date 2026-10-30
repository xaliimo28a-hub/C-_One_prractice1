namespace exm
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
            this.lblpackages = new System.Windows.Forms.Label();
            this.lblperpackage = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.txtpackages = new System.Windows.Forms.TextBox();
            this.txtperpackage = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.button = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lblpackages
            // 
            this.lblpackages.AutoSize = true;
            this.lblpackages.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpackages.Location = new System.Drawing.Point(15, 28);
            this.lblpackages.Name = "lblpackages";
            this.lblpackages.Size = new System.Drawing.Size(278, 32);
            this.lblpackages.TabIndex = 5;
            this.lblpackages.Text = "number of packages:";
            // 
            // lblperpackage
            // 
            this.lblperpackage.AutoSize = true;
            this.lblperpackage.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblperpackage.Location = new System.Drawing.Point(25, 114);
            this.lblperpackage.Name = "lblperpackage";
            this.lblperpackage.Size = new System.Drawing.Size(247, 32);
            this.lblperpackage.TabIndex = 6;
            this.lblperpackage.Text = "price per package:";
       //     this.lblperpackage.Click += new System.EventHandler(this.lbaperpackage_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(265, 197);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(191, 75);
            this.button5.TabIndex = 7;
            this.button5.Text = "Clear";
            this.button5.UseVisualStyleBackColor = true;
     //       this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.SystemColors.Highlight;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(9, 197);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(250, 79);
            this.button6.TabIndex = 8;
            this.button6.Text = "Calcuate";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // txtpackages
            // 
            this.txtpackages.Location = new System.Drawing.Point(302, 23);
            this.txtpackages.Multiline = true;
            this.txtpackages.Name = "txtpackages";
            this.txtpackages.Size = new System.Drawing.Size(277, 54);
            this.txtpackages.TabIndex = 9;
     //       this.txtpackages.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtperpackage
            // 
            this.txtperpackage.Location = new System.Drawing.Point(299, 110);
            this.txtperpackage.Multiline = true;
            this.txtperpackage.Name = "txtperpackage";
            this.txtperpackage.Size = new System.Drawing.Size(277, 54);
            this.txtperpackage.TabIndex = 10;
            // 
            // button
            // 
            this.button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button.Location = new System.Drawing.Point(486, 197);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(191, 75);
            this.button.TabIndex = 11;
            this.button.Text = "Exit";
            this.button.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(811, 30);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(421, 484);
            this.listBox1.TabIndex = 14;
    //        this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1304, 728);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button);
            this.Controls.Add(this.txtperpackage);
            this.Controls.Add(this.txtpackages);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.lblperpackage);
            this.Controls.Add(this.lblpackages);
            this.Name = "Form1";
            this.Text = "Form1";
       //     this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblpackages;
        private System.Windows.Forms.Label lblperpackage;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.TextBox txtpackages;
        private System.Windows.Forms.TextBox txtperpackage;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button button;
        private System.Windows.Forms.ListBox listBox1;
    }
}

