﻿namespace _01_Task
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
            this.btnBaixar = new System.Windows.Forms.Button();
            this.txtResultado = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSite = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnBaixar
            // 
            this.btnBaixar.Location = new System.Drawing.Point(11, 276);
            this.btnBaixar.Name = "btnBaixar";
            this.btnBaixar.Size = new System.Drawing.Size(258, 42);
            this.btnBaixar.TabIndex = 0;
            this.btnBaixar.Text = "Fazer Download";
            this.btnBaixar.UseVisualStyleBackColor = true;
            this.btnBaixar.Click += new System.EventHandler(this.btnBaixar_Click);
            // 
            // txtResultado
            // 
            this.txtResultado.Location = new System.Drawing.Point(12, 41);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(257, 229);
            this.txtResultado.TabIndex = 1;
            this.txtResultado.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Site:";
            // 
            // txtSite
            // 
            this.txtSite.Location = new System.Drawing.Point(55, 13);
            this.txtSite.Name = "txtSite";
            this.txtSite.Size = new System.Drawing.Size(214, 22);
            this.txtSite.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 328);
            this.Controls.Add(this.txtSite);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.btnBaixar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBaixar;
        private System.Windows.Forms.RichTextBox txtResultado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSite;
    }
}

