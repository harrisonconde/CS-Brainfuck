namespace Brainfuck
{
    partial class mainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainWindow));
            this.codeTxt = new System.Windows.Forms.TextBox();
            this.btnRun = new System.Windows.Forms.Button();
            this.cellCountView = new System.Windows.Forms.Label();
            this.inputTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.outputTxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // codeTxt
            // 
            this.codeTxt.AcceptsReturn = true;
            this.codeTxt.AcceptsTab = true;
            this.codeTxt.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codeTxt.HideSelection = false;
            this.codeTxt.Location = new System.Drawing.Point(12, 34);
            this.codeTxt.Multiline = true;
            this.codeTxt.Name = "codeTxt";
            this.codeTxt.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.codeTxt.Size = new System.Drawing.Size(260, 330);
            this.codeTxt.TabIndex = 1;
            // 
            // btnRun
            // 
            this.btnRun.Location = new System.Drawing.Point(278, 327);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(260, 23);
            this.btnRun.TabIndex = 2;
            this.btnRun.Text = "Run";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // cellCountView
            // 
            this.cellCountView.AutoSize = true;
            this.cellCountView.Location = new System.Drawing.Point(489, 281);
            this.cellCountView.Name = "cellCountView";
            this.cellCountView.Size = new System.Drawing.Size(13, 13);
            this.cellCountView.TabIndex = 3;
            this.cellCountView.Text = "0";
            // 
            // inputTxt
            // 
            this.inputTxt.Location = new System.Drawing.Point(278, 301);
            this.inputTxt.Name = "inputTxt";
            this.inputTxt.Size = new System.Drawing.Size(260, 20);
            this.inputTxt.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Code:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(279, 281);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Input:";
            // 
            // outputTxt
            // 
            this.outputTxt.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.outputTxt.ForeColor = System.Drawing.Color.Lime;
            this.outputTxt.Location = new System.Drawing.Point(282, 34);
            this.outputTxt.Multiline = true;
            this.outputTxt.Name = "outputTxt";
            this.outputTxt.ReadOnly = true;
            this.outputTxt.Size = new System.Drawing.Size(256, 244);
            this.outputTxt.TabIndex = 1;
            this.outputTxt.Text = "output";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(279, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Output:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(424, 281);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Cell usage:";
            // 
            // mainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(546, 376);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cellCountView);
            this.Controls.Add(this.btnRun);
            this.Controls.Add(this.inputTxt);
            this.Controls.Add(this.outputTxt);
            this.Controls.Add(this.codeTxt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "mainWindow";
            this.Text = "Brainfuck";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox codeTxt;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.Label cellCountView;
        private System.Windows.Forms.TextBox inputTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox outputTxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

