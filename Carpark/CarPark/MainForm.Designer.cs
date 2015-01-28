namespace CarPark
{
    partial class MainForm
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
            this.lblEntrance1 = new System.Windows.Forms.Label();
            this.lblEntrance2 = new System.Windows.Forms.Label();
            this.lblEntrance3 = new System.Windows.Forms.Label();
            this.lblEntrance4 = new System.Windows.Forms.Label();
            this.lblEntrance5 = new System.Windows.Forms.Label();
            this.btn_Start = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblEntrance1
            // 
            this.lblEntrance1.AutoSize = true;
            this.lblEntrance1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblEntrance1.Location = new System.Drawing.Point(74, 55);
            this.lblEntrance1.Name = "lblEntrance1";
            this.lblEntrance1.Size = new System.Drawing.Size(53, 22);
            this.lblEntrance1.TabIndex = 0;
            this.lblEntrance1.Text = "label1";
            // 
            // lblEntrance2
            // 
            this.lblEntrance2.AutoSize = true;
            this.lblEntrance2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblEntrance2.Location = new System.Drawing.Point(74, 179);
            this.lblEntrance2.Name = "lblEntrance2";
            this.lblEntrance2.Size = new System.Drawing.Size(53, 22);
            this.lblEntrance2.TabIndex = 1;
            this.lblEntrance2.Text = "label2";
            // 
            // lblEntrance3
            // 
            this.lblEntrance3.AutoSize = true;
            this.lblEntrance3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblEntrance3.Location = new System.Drawing.Point(474, 55);
            this.lblEntrance3.Name = "lblEntrance3";
            this.lblEntrance3.Size = new System.Drawing.Size(53, 22);
            this.lblEntrance3.TabIndex = 2;
            this.lblEntrance3.Text = "label3";
            // 
            // lblEntrance4
            // 
            this.lblEntrance4.AutoSize = true;
            this.lblEntrance4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblEntrance4.Location = new System.Drawing.Point(474, 179);
            this.lblEntrance4.Name = "lblEntrance4";
            this.lblEntrance4.Size = new System.Drawing.Size(53, 22);
            this.lblEntrance4.TabIndex = 3;
            this.lblEntrance4.Text = "label4";
            // 
            // lblEntrance5
            // 
            this.lblEntrance5.AutoSize = true;
            this.lblEntrance5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblEntrance5.Location = new System.Drawing.Point(274, 113);
            this.lblEntrance5.Name = "lblEntrance5";
            this.lblEntrance5.Size = new System.Drawing.Size(53, 22);
            this.lblEntrance5.TabIndex = 4;
            this.lblEntrance5.Text = "label5";
            // 
            // btn_Start
            // 
            this.btn_Start.Location = new System.Drawing.Point(274, 295);
            this.btn_Start.Name = "btn_Start";
            this.btn_Start.Size = new System.Drawing.Size(103, 49);
            this.btn_Start.TabIndex = 5;
            this.btn_Start.Text = "Go";
            this.btn_Start.UseVisualStyleBackColor = true;
            this.btn_Start.Click += new System.EventHandler(this.btn_Start_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(959, 634);
            this.Controls.Add(this.btn_Start);
            this.Controls.Add(this.lblEntrance5);
            this.Controls.Add(this.lblEntrance4);
            this.Controls.Add(this.lblEntrance3);
            this.Controls.Add(this.lblEntrance2);
            this.Controls.Add(this.lblEntrance1);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEntrance1;
        private System.Windows.Forms.Label lblEntrance2;
        private System.Windows.Forms.Label lblEntrance3;
        private System.Windows.Forms.Label lblEntrance4;
        private System.Windows.Forms.Label lblEntrance5;
        private System.Windows.Forms.Button btn_Start;
    }
}

