namespace LSPSolution.Views
{
    partial class Principal
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
            this.btnTransfer = new System.Windows.Forms.Button();
            this.btnExtraction = new System.Windows.Forms.Button();
            this.btnDeposit = new System.Windows.Forms.Button();
            this.btnFixedT = new System.Windows.Forms.Button();
            this.gbBank = new System.Windows.Forms.GroupBox();
            this.lblCode = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblMount = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAddBank = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblRole = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnRole = new System.Windows.Forms.Button();
            this.btnCreateUser = new System.Windows.Forms.Button();
            this.gbBank.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnTransfer
            // 
            this.btnTransfer.Location = new System.Drawing.Point(294, 269);
            this.btnTransfer.Name = "btnTransfer";
            this.btnTransfer.Size = new System.Drawing.Size(120, 23);
            this.btnTransfer.TabIndex = 33;
            this.btnTransfer.Text = "Do a transfer";
            this.btnTransfer.UseVisualStyleBackColor = true;
            this.btnTransfer.Click += new System.EventHandler(this.btnTransfer_Click);
            // 
            // btnExtraction
            // 
            this.btnExtraction.Location = new System.Drawing.Point(294, 240);
            this.btnExtraction.Name = "btnExtraction";
            this.btnExtraction.Size = new System.Drawing.Size(120, 23);
            this.btnExtraction.TabIndex = 32;
            this.btnExtraction.Text = "Do an extraction";
            this.btnExtraction.UseVisualStyleBackColor = true;
            this.btnExtraction.Click += new System.EventHandler(this.btnExtraction_Click);
            // 
            // btnDeposit
            // 
            this.btnDeposit.Location = new System.Drawing.Point(294, 210);
            this.btnDeposit.Name = "btnDeposit";
            this.btnDeposit.Size = new System.Drawing.Size(120, 23);
            this.btnDeposit.TabIndex = 31;
            this.btnDeposit.Text = "Do a deposit";
            this.btnDeposit.UseVisualStyleBackColor = true;
            this.btnDeposit.Click += new System.EventHandler(this.btnDeposit_Click);
            // 
            // btnFixedT
            // 
            this.btnFixedT.Location = new System.Drawing.Point(294, 181);
            this.btnFixedT.Name = "btnFixedT";
            this.btnFixedT.Size = new System.Drawing.Size(120, 23);
            this.btnFixedT.TabIndex = 30;
            this.btnFixedT.Text = "Create a Fixed-Term";
            this.btnFixedT.UseVisualStyleBackColor = true;
            // 
            // gbBank
            // 
            this.gbBank.Controls.Add(this.lblCode);
            this.gbBank.Controls.Add(this.label4);
            this.gbBank.Controls.Add(this.lblMount);
            this.gbBank.Controls.Add(this.label2);
            this.gbBank.Location = new System.Drawing.Point(294, 63);
            this.gbBank.Name = "gbBank";
            this.gbBank.Size = new System.Drawing.Size(200, 100);
            this.gbBank.TabIndex = 29;
            this.gbBank.TabStop = false;
            this.gbBank.Text = "group";
            // 
            // lblCode
            // 
            this.lblCode.AutoSize = true;
            this.lblCode.Location = new System.Drawing.Point(75, 37);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(29, 13);
            this.lblCode.TabIndex = 12;
            this.lblCode.Text = "label";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Code: ";
            // 
            // lblMount
            // 
            this.lblMount.AutoSize = true;
            this.lblMount.Location = new System.Drawing.Point(75, 68);
            this.lblMount.Name = "lblMount";
            this.lblMount.Size = new System.Drawing.Size(29, 13);
            this.lblMount.TabIndex = 9;
            this.lblMount.Text = "label";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Amount:";
            // 
            // btnAddBank
            // 
            this.btnAddBank.Location = new System.Drawing.Point(346, 34);
            this.btnAddBank.Name = "btnAddBank";
            this.btnAddBank.Size = new System.Drawing.Size(120, 23);
            this.btnAddBank.TabIndex = 28;
            this.btnAddBank.Text = "add bank count";
            this.btnAddBank.UseVisualStyleBackColor = true;
            this.btnAddBank.Click += new System.EventHandler(this.btnAddBank_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblRole);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lblName);
            this.groupBox1.Controls.Add(this.lblLastName);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(12, 53);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(184, 104);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "USER";
            // 
            // lblRole
            // 
            this.lblRole.AutoSize = true;
            this.lblRole.Location = new System.Drawing.Point(76, 78);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(35, 13);
            this.lblRole.TabIndex = 9;
            this.lblRole.Text = "label4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Role:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Name:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(76, 29);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 5;
            this.lblName.Text = "label2";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(76, 54);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(35, 13);
            this.lblLastName.TabIndex = 7;
            this.lblLastName.Text = "label4";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Last Name: ";
            // 
            // btnRole
            // 
            this.btnRole.Location = new System.Drawing.Point(12, 181);
            this.btnRole.Name = "btnRole";
            this.btnRole.Size = new System.Drawing.Size(149, 38);
            this.btnRole.TabIndex = 26;
            this.btnRole.Text = "CREATE A ROLE";
            this.btnRole.UseVisualStyleBackColor = true;
            // 
            // btnCreateUser
            // 
            this.btnCreateUser.Location = new System.Drawing.Point(12, 225);
            this.btnCreateUser.Name = "btnCreateUser";
            this.btnCreateUser.Size = new System.Drawing.Size(149, 38);
            this.btnCreateUser.TabIndex = 25;
            this.btnCreateUser.Text = "CREATE AN USER";
            this.btnCreateUser.UseVisualStyleBackColor = true;
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 310);
            this.Controls.Add(this.btnTransfer);
            this.Controls.Add(this.btnExtraction);
            this.Controls.Add(this.btnDeposit);
            this.Controls.Add(this.btnFixedT);
            this.Controls.Add(this.gbBank);
            this.Controls.Add(this.btnAddBank);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnRole);
            this.Controls.Add(this.btnCreateUser);
            this.Name = "Principal";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Principal_Load);
            this.gbBank.ResumeLayout(false);
            this.gbBank.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTransfer;
        private System.Windows.Forms.Button btnExtraction;
        private System.Windows.Forms.Button btnDeposit;
        private System.Windows.Forms.Button btnFixedT;
        private System.Windows.Forms.GroupBox gbBank;
        private System.Windows.Forms.Label lblCode;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblMount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAddBank;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnRole;
        private System.Windows.Forms.Button btnCreateUser;
    }
}