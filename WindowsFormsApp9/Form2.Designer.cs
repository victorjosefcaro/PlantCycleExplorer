namespace WindowsFormsApp9
{
    partial class Form2
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
            this.menuBtn = new System.Windows.Forms.Button();
            this.quizMCBtn = new System.Windows.Forms.Button();
            this.quizTOFBtn = new System.Windows.Forms.Button();
            this.endQuizBtn = new System.Windows.Forms.Button();
            this.questionLbl = new System.Windows.Forms.Label();
            this.aRBtn = new System.Windows.Forms.RadioButton();
            this.bRBtn = new System.Windows.Forms.RadioButton();
            this.cRBtn = new System.Windows.Forms.RadioButton();
            this.dRBtn = new System.Windows.Forms.RadioButton();
            this.nextMCBtn = new System.Windows.Forms.Button();
            this.finishMCBtn = new System.Windows.Forms.Button();
            this.nextResultMCBtn = new System.Windows.Forms.Button();
            this.fRBtn = new System.Windows.Forms.RadioButton();
            this.tRBtn = new System.Windows.Forms.RadioButton();
            this.nextTOFBtn = new System.Windows.Forms.Button();
            this.nextResultTOFBtn = new System.Windows.Forms.Button();
            this.finishTOFBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // menuBtn
            // 
            this.menuBtn.BackColor = System.Drawing.Color.White;
            this.menuBtn.Font = new System.Drawing.Font("Candy Beans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(133)))), ((int)(((byte)(134)))));
            this.menuBtn.Location = new System.Drawing.Point(12, 401);
            this.menuBtn.Name = "menuBtn";
            this.menuBtn.Size = new System.Drawing.Size(69, 37);
            this.menuBtn.TabIndex = 3;
            this.menuBtn.Text = "Menu";
            this.menuBtn.UseVisualStyleBackColor = false;
            this.menuBtn.Click += new System.EventHandler(this.menuBtn_Click);
            // 
            // quizMCBtn
            // 
            this.quizMCBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(128)))), ((int)(((byte)(115)))));
            this.quizMCBtn.Font = new System.Drawing.Font("Candy Beans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quizMCBtn.ForeColor = System.Drawing.Color.White;
            this.quizMCBtn.Location = new System.Drawing.Point(87, 214);
            this.quizMCBtn.Name = "quizMCBtn";
            this.quizMCBtn.Size = new System.Drawing.Size(270, 64);
            this.quizMCBtn.TabIndex = 1;
            this.quizMCBtn.Text = "Multiple Choice";
            this.quizMCBtn.UseVisualStyleBackColor = false;
            this.quizMCBtn.Click += new System.EventHandler(this.quizMCBtn_Click);
            // 
            // quizTOFBtn
            // 
            this.quizTOFBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(128)))), ((int)(((byte)(115)))));
            this.quizTOFBtn.Font = new System.Drawing.Font("Candy Beans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quizTOFBtn.ForeColor = System.Drawing.Color.White;
            this.quizTOFBtn.Location = new System.Drawing.Point(444, 214);
            this.quizTOFBtn.Name = "quizTOFBtn";
            this.quizTOFBtn.Size = new System.Drawing.Size(270, 64);
            this.quizTOFBtn.TabIndex = 2;
            this.quizTOFBtn.Text = "True or False";
            this.quizTOFBtn.UseVisualStyleBackColor = false;
            this.quizTOFBtn.Click += new System.EventHandler(this.quizTOFBtn_Click);
            // 
            // endQuizBtn
            // 
            this.endQuizBtn.BackColor = System.Drawing.Color.White;
            this.endQuizBtn.Font = new System.Drawing.Font("Candy Beans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endQuizBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(133)))), ((int)(((byte)(134)))));
            this.endQuizBtn.Location = new System.Drawing.Point(12, 401);
            this.endQuizBtn.Name = "endQuizBtn";
            this.endQuizBtn.Size = new System.Drawing.Size(102, 37);
            this.endQuizBtn.TabIndex = 9;
            this.endQuizBtn.Text = "End Quiz";
            this.endQuizBtn.UseVisualStyleBackColor = false;
            this.endQuizBtn.Visible = false;
            this.endQuizBtn.Click += new System.EventHandler(this.endQuizBtn_Click);
            // 
            // questionLbl
            // 
            this.questionLbl.AutoSize = true;
            this.questionLbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(128)))), ((int)(((byte)(115)))));
            this.questionLbl.Font = new System.Drawing.Font("Candy Beans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.questionLbl.ForeColor = System.Drawing.Color.White;
            this.questionLbl.Location = new System.Drawing.Point(12, 9);
            this.questionLbl.MaximumSize = new System.Drawing.Size(781, 0);
            this.questionLbl.Name = "questionLbl";
            this.questionLbl.Padding = new System.Windows.Forms.Padding(10);
            this.questionLbl.Size = new System.Drawing.Size(20, 41);
            this.questionLbl.TabIndex = 31;
            this.questionLbl.Visible = false;
            // 
            // aRBtn
            // 
            this.aRBtn.AutoSize = true;
            this.aRBtn.Font = new System.Drawing.Font("Candy Beans", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aRBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(101)))), ((int)(((byte)(114)))));
            this.aRBtn.Location = new System.Drawing.Point(35, 126);
            this.aRBtn.Name = "aRBtn";
            this.aRBtn.Padding = new System.Windows.Forms.Padding(10);
            this.aRBtn.Size = new System.Drawing.Size(65, 55);
            this.aRBtn.TabIndex = 4;
            this.aRBtn.TabStop = true;
            this.aRBtn.Text = "A";
            this.aRBtn.UseVisualStyleBackColor = true;
            this.aRBtn.Visible = false;
            this.aRBtn.CheckedChanged += new System.EventHandler(this.aRBtn_CheckedChanged);
            // 
            // bRBtn
            // 
            this.bRBtn.AutoSize = true;
            this.bRBtn.Font = new System.Drawing.Font("Candy Beans", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bRBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(101)))), ((int)(((byte)(114)))));
            this.bRBtn.Location = new System.Drawing.Point(35, 187);
            this.bRBtn.Name = "bRBtn";
            this.bRBtn.Padding = new System.Windows.Forms.Padding(10);
            this.bRBtn.Size = new System.Drawing.Size(64, 55);
            this.bRBtn.TabIndex = 5;
            this.bRBtn.TabStop = true;
            this.bRBtn.Text = "B";
            this.bRBtn.UseVisualStyleBackColor = true;
            this.bRBtn.Visible = false;
            this.bRBtn.CheckedChanged += new System.EventHandler(this.bRBtn_CheckedChanged);
            // 
            // cRBtn
            // 
            this.cRBtn.AutoSize = true;
            this.cRBtn.Font = new System.Drawing.Font("Candy Beans", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cRBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(101)))), ((int)(((byte)(114)))));
            this.cRBtn.Location = new System.Drawing.Point(35, 248);
            this.cRBtn.Name = "cRBtn";
            this.cRBtn.Padding = new System.Windows.Forms.Padding(10);
            this.cRBtn.Size = new System.Drawing.Size(65, 55);
            this.cRBtn.TabIndex = 6;
            this.cRBtn.TabStop = true;
            this.cRBtn.Text = "C";
            this.cRBtn.UseVisualStyleBackColor = true;
            this.cRBtn.Visible = false;
            this.cRBtn.CheckedChanged += new System.EventHandler(this.cRBtn_CheckedChanged);
            // 
            // dRBtn
            // 
            this.dRBtn.AutoSize = true;
            this.dRBtn.Font = new System.Drawing.Font("Candy Beans", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dRBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(101)))), ((int)(((byte)(114)))));
            this.dRBtn.Location = new System.Drawing.Point(35, 309);
            this.dRBtn.Name = "dRBtn";
            this.dRBtn.Padding = new System.Windows.Forms.Padding(10);
            this.dRBtn.Size = new System.Drawing.Size(64, 55);
            this.dRBtn.TabIndex = 7;
            this.dRBtn.TabStop = true;
            this.dRBtn.Text = "D";
            this.dRBtn.UseVisualStyleBackColor = true;
            this.dRBtn.Visible = false;
            this.dRBtn.CheckedChanged += new System.EventHandler(this.dRBtn_CheckedChanged);
            // 
            // nextMCBtn
            // 
            this.nextMCBtn.BackColor = System.Drawing.Color.White;
            this.nextMCBtn.Font = new System.Drawing.Font("Candy Beans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nextMCBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(133)))), ((int)(((byte)(134)))));
            this.nextMCBtn.Location = new System.Drawing.Point(719, 401);
            this.nextMCBtn.Name = "nextMCBtn";
            this.nextMCBtn.Size = new System.Drawing.Size(69, 37);
            this.nextMCBtn.TabIndex = 8;
            this.nextMCBtn.Text = "Next";
            this.nextMCBtn.UseVisualStyleBackColor = false;
            this.nextMCBtn.Visible = false;
            this.nextMCBtn.Click += new System.EventHandler(this.nextMCBtn_Click);
            // 
            // finishMCBtn
            // 
            this.finishMCBtn.BackColor = System.Drawing.Color.White;
            this.finishMCBtn.Font = new System.Drawing.Font("Candy Beans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.finishMCBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(133)))), ((int)(((byte)(134)))));
            this.finishMCBtn.Location = new System.Drawing.Point(709, 401);
            this.finishMCBtn.Name = "finishMCBtn";
            this.finishMCBtn.Size = new System.Drawing.Size(79, 37);
            this.finishMCBtn.TabIndex = 10;
            this.finishMCBtn.Text = "Finish";
            this.finishMCBtn.UseVisualStyleBackColor = false;
            this.finishMCBtn.Visible = false;
            this.finishMCBtn.Click += new System.EventHandler(this.finishMCBtn_Click);
            // 
            // nextResultMCBtn
            // 
            this.nextResultMCBtn.BackColor = System.Drawing.Color.White;
            this.nextResultMCBtn.Font = new System.Drawing.Font("Candy Beans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nextResultMCBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(133)))), ((int)(((byte)(134)))));
            this.nextResultMCBtn.Location = new System.Drawing.Point(659, 401);
            this.nextResultMCBtn.Name = "nextResultMCBtn";
            this.nextResultMCBtn.Size = new System.Drawing.Size(129, 37);
            this.nextResultMCBtn.TabIndex = 11;
            this.nextResultMCBtn.Text = "Next Result";
            this.nextResultMCBtn.UseVisualStyleBackColor = false;
            this.nextResultMCBtn.Visible = false;
            this.nextResultMCBtn.Click += new System.EventHandler(this.nextResultMCBtn_Click);
            // 
            // fRBtn
            // 
            this.fRBtn.AutoSize = true;
            this.fRBtn.Font = new System.Drawing.Font("Candy Beans", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fRBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(101)))), ((int)(((byte)(114)))));
            this.fRBtn.Location = new System.Drawing.Point(35, 187);
            this.fRBtn.Name = "fRBtn";
            this.fRBtn.Padding = new System.Windows.Forms.Padding(10);
            this.fRBtn.Size = new System.Drawing.Size(108, 55);
            this.fRBtn.TabIndex = 13;
            this.fRBtn.TabStop = true;
            this.fRBtn.Text = "False";
            this.fRBtn.UseVisualStyleBackColor = true;
            this.fRBtn.Visible = false;
            this.fRBtn.CheckedChanged += new System.EventHandler(this.fRBtn_CheckedChanged);
            // 
            // tRBtn
            // 
            this.tRBtn.AutoSize = true;
            this.tRBtn.Font = new System.Drawing.Font("Candy Beans", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tRBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(101)))), ((int)(((byte)(114)))));
            this.tRBtn.Location = new System.Drawing.Point(35, 126);
            this.tRBtn.Name = "tRBtn";
            this.tRBtn.Padding = new System.Windows.Forms.Padding(10);
            this.tRBtn.Size = new System.Drawing.Size(102, 55);
            this.tRBtn.TabIndex = 12;
            this.tRBtn.TabStop = true;
            this.tRBtn.Text = "True";
            this.tRBtn.UseVisualStyleBackColor = true;
            this.tRBtn.Visible = false;
            this.tRBtn.CheckedChanged += new System.EventHandler(this.tRBtn_CheckedChanged);
            // 
            // nextTOFBtn
            // 
            this.nextTOFBtn.BackColor = System.Drawing.Color.White;
            this.nextTOFBtn.Font = new System.Drawing.Font("Candy Beans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nextTOFBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(133)))), ((int)(((byte)(134)))));
            this.nextTOFBtn.Location = new System.Drawing.Point(719, 401);
            this.nextTOFBtn.Name = "nextTOFBtn";
            this.nextTOFBtn.Size = new System.Drawing.Size(69, 37);
            this.nextTOFBtn.TabIndex = 32;
            this.nextTOFBtn.Text = "Next";
            this.nextTOFBtn.UseVisualStyleBackColor = false;
            this.nextTOFBtn.Visible = false;
            this.nextTOFBtn.Click += new System.EventHandler(this.nextTOFBtn_Click);
            // 
            // nextResultTOFBtn
            // 
            this.nextResultTOFBtn.BackColor = System.Drawing.Color.White;
            this.nextResultTOFBtn.Font = new System.Drawing.Font("Candy Beans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nextResultTOFBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(133)))), ((int)(((byte)(134)))));
            this.nextResultTOFBtn.Location = new System.Drawing.Point(659, 401);
            this.nextResultTOFBtn.Name = "nextResultTOFBtn";
            this.nextResultTOFBtn.Size = new System.Drawing.Size(129, 37);
            this.nextResultTOFBtn.TabIndex = 34;
            this.nextResultTOFBtn.Text = "Next Result";
            this.nextResultTOFBtn.UseVisualStyleBackColor = false;
            this.nextResultTOFBtn.Visible = false;
            this.nextResultTOFBtn.Click += new System.EventHandler(this.nextResultTOFBtn_Click);
            // 
            // finishTOFBtn
            // 
            this.finishTOFBtn.BackColor = System.Drawing.Color.White;
            this.finishTOFBtn.Font = new System.Drawing.Font("Candy Beans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.finishTOFBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(133)))), ((int)(((byte)(134)))));
            this.finishTOFBtn.Location = new System.Drawing.Point(709, 401);
            this.finishTOFBtn.Name = "finishTOFBtn";
            this.finishTOFBtn.Size = new System.Drawing.Size(79, 37);
            this.finishTOFBtn.TabIndex = 35;
            this.finishTOFBtn.Text = "Finish";
            this.finishTOFBtn.UseVisualStyleBackColor = false;
            this.finishTOFBtn.Visible = false;
            this.finishTOFBtn.Click += new System.EventHandler(this.finishTOFBtn_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp9.Properties.Resources.Background4;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.nextMCBtn);
            this.Controls.Add(this.dRBtn);
            this.Controls.Add(this.cRBtn);
            this.Controls.Add(this.bRBtn);
            this.Controls.Add(this.aRBtn);
            this.Controls.Add(this.questionLbl);
            this.Controls.Add(this.quizTOFBtn);
            this.Controls.Add(this.quizMCBtn);
            this.Controls.Add(this.menuBtn);
            this.Controls.Add(this.endQuizBtn);
            this.Controls.Add(this.finishMCBtn);
            this.Controls.Add(this.nextResultMCBtn);
            this.Controls.Add(this.finishTOFBtn);
            this.Controls.Add(this.nextTOFBtn);
            this.Controls.Add(this.nextResultTOFBtn);
            this.Controls.Add(this.tRBtn);
            this.Controls.Add(this.fRBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button menuBtn;
        private System.Windows.Forms.Button quizMCBtn;
        private System.Windows.Forms.Button quizTOFBtn;
        private System.Windows.Forms.Button endQuizBtn;
        private System.Windows.Forms.Label questionLbl;
        private System.Windows.Forms.RadioButton aRBtn;
        private System.Windows.Forms.RadioButton bRBtn;
        private System.Windows.Forms.RadioButton cRBtn;
        private System.Windows.Forms.RadioButton dRBtn;
        private System.Windows.Forms.Button nextMCBtn;
        private System.Windows.Forms.Button finishMCBtn;
        private System.Windows.Forms.Button nextResultMCBtn;
        private System.Windows.Forms.RadioButton fRBtn;
        private System.Windows.Forms.RadioButton tRBtn;
        private System.Windows.Forms.Button nextTOFBtn;
        private System.Windows.Forms.Button nextResultTOFBtn;
        private System.Windows.Forms.Button finishTOFBtn;
    }
}