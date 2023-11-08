namespace GPLApplication
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
            this.runBtn = new System.Windows.Forms.Button();
            this.syntaxBtn = new System.Windows.Forms.Button();
            this.singleLineCode = new System.Windows.Forms.TextBox();
            this.multipleLineCode = new System.Windows.Forms.RichTextBox();
            this.displayArea = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // runBtn
            // 
            this.runBtn.Location = new System.Drawing.Point(13, 401);
            this.runBtn.Name = "runBtn";
            this.runBtn.Size = new System.Drawing.Size(75, 23);
            this.runBtn.TabIndex = 0;
            this.runBtn.Text = "Run";
            this.runBtn.UseVisualStyleBackColor = true;
            this.runBtn.Click += new System.EventHandler(this.runBtnClick);
            // 
            // syntaxBtn
            // 
            this.syntaxBtn.Location = new System.Drawing.Point(95, 400);
            this.syntaxBtn.Name = "syntaxBtn";
            this.syntaxBtn.Size = new System.Drawing.Size(75, 23);
            this.syntaxBtn.TabIndex = 1;
            this.syntaxBtn.Text = "Syntax";
            this.syntaxBtn.UseVisualStyleBackColor = true;
            this.syntaxBtn.Click += new System.EventHandler(this.syntaxBtnClick);
            // 
            // singleLineCode
            // 
            this.singleLineCode.Location = new System.Drawing.Point(13, 375);
            this.singleLineCode.Name = "singleLineCode";
            this.singleLineCode.Size = new System.Drawing.Size(441, 20);
            this.singleLineCode.TabIndex = 2;
            // 
            // multipleLineCode
            // 
            this.multipleLineCode.Location = new System.Drawing.Point(13, 13);
            this.multipleLineCode.Name = "multipleLineCode";
            this.multipleLineCode.Size = new System.Drawing.Size(441, 356);
            this.multipleLineCode.TabIndex = 3;
            this.multipleLineCode.Text = "";
            this.multipleLineCode.TextChanged += new System.EventHandler(this.multipleLineCode_TextChanged);
            // 
            // displayArea
            // 
            this.displayArea.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.displayArea.Location = new System.Drawing.Point(461, 13);
            this.displayArea.Name = "displayArea";
            this.displayArea.Size = new System.Drawing.Size(327, 382);
            this.displayArea.TabIndex = 4;
            this.displayArea.Paint += new System.Windows.Forms.PaintEventHandler(this.displayArea_Paint);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(177, 401);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(258, 401);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "Open";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.displayArea);
            this.Controls.Add(this.multipleLineCode);
            this.Controls.Add(this.singleLineCode);
            this.Controls.Add(this.syntaxBtn);
            this.Controls.Add(this.runBtn);
            this.Name = "Form1";
            this.Text = "GPL Application";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button runBtn;
        private System.Windows.Forms.Button syntaxBtn;
        private System.Windows.Forms.TextBox singleLineCode;
        private System.Windows.Forms.RichTextBox multipleLineCode;
        private System.Windows.Forms.Panel displayArea;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

