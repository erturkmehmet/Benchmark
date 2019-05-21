namespace BenchMark
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
            this.lbConnected = new System.Windows.Forms.ListBox();
            this.lblConnected = new System.Windows.Forms.Label();
            this.lblTime_Cnn = new System.Windows.Forms.Label();
            this.btnConnected = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbDisconnected = new System.Windows.Forms.ListBox();
            this.btnDisconnected = new System.Windows.Forms.Button();
            this.lblDisconnected = new System.Windows.Forms.Label();
            this.lblTime_Disc = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lbEntity = new System.Windows.Forms.ListBox();
            this.btnEntity = new System.Windows.Forms.Button();
            this.lblEntity = new System.Windows.Forms.Label();
            this.lblTime_Entity = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbConnected
            // 
            this.lbConnected.FormattingEnabled = true;
            this.lbConnected.Location = new System.Drawing.Point(16, 64);
            this.lbConnected.Name = "lbConnected";
            this.lbConnected.Size = new System.Drawing.Size(120, 264);
            this.lbConnected.TabIndex = 0;
            // 
            // lblConnected
            // 
            this.lblConnected.AutoSize = true;
            this.lblConnected.Location = new System.Drawing.Point(40, 30);
            this.lblConnected.Name = "lblConnected";
            this.lblConnected.Size = new System.Drawing.Size(74, 13);
            this.lblConnected.TabIndex = 1;
            this.lblConnected.Text = "CONNECTED";
            // 
            // lblTime_Cnn
            // 
            this.lblTime_Cnn.AutoSize = true;
            this.lblTime_Cnn.Location = new System.Drawing.Point(16, 347);
            this.lblTime_Cnn.Name = "lblTime_Cnn";
            this.lblTime_Cnn.Size = new System.Drawing.Size(35, 13);
            this.lblTime_Cnn.TabIndex = 2;
            this.lblTime_Cnn.Text = "label2";
            // 
            // btnConnected
            // 
            this.btnConnected.Location = new System.Drawing.Point(16, 382);
            this.btnConnected.Name = "btnConnected";
            this.btnConnected.Size = new System.Drawing.Size(120, 23);
            this.btnConnected.TabIndex = 3;
            this.btnConnected.Text = "Connected Başlat";
            this.btnConnected.UseVisualStyleBackColor = true;
            this.btnConnected.Click += new System.EventHandler(this.btnConnected_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbConnected);
            this.groupBox1.Controls.Add(this.btnConnected);
            this.groupBox1.Controls.Add(this.lblConnected);
            this.groupBox1.Controls.Add(this.lblTime_Cnn);
            this.groupBox1.Location = new System.Drawing.Point(25, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 426);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbDisconnected);
            this.groupBox2.Controls.Add(this.btnDisconnected);
            this.groupBox2.Controls.Add(this.lblDisconnected);
            this.groupBox2.Controls.Add(this.lblTime_Disc);
            this.groupBox2.Location = new System.Drawing.Point(282, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 426);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "2";
            // 
            // lbDisconnected
            // 
            this.lbDisconnected.FormattingEnabled = true;
            this.lbDisconnected.Location = new System.Drawing.Point(16, 64);
            this.lbDisconnected.Name = "lbDisconnected";
            this.lbDisconnected.Size = new System.Drawing.Size(120, 264);
            this.lbDisconnected.TabIndex = 0;
            // 
            // btnDisconnected
            // 
            this.btnDisconnected.Location = new System.Drawing.Point(16, 382);
            this.btnDisconnected.Name = "btnDisconnected";
            this.btnDisconnected.Size = new System.Drawing.Size(120, 23);
            this.btnDisconnected.TabIndex = 3;
            this.btnDisconnected.Text = "Disconnected Başlat";
            this.btnDisconnected.UseVisualStyleBackColor = true;
            this.btnDisconnected.Click += new System.EventHandler(this.btnDisconnected_Click);
            // 
            // lblDisconnected
            // 
            this.lblDisconnected.AutoSize = true;
            this.lblDisconnected.Location = new System.Drawing.Point(31, 30);
            this.lblDisconnected.Name = "lblDisconnected";
            this.lblDisconnected.Size = new System.Drawing.Size(92, 13);
            this.lblDisconnected.TabIndex = 1;
            this.lblDisconnected.Text = "DISCONNECTED";
            // 
            // lblTime_Disc
            // 
            this.lblTime_Disc.AutoSize = true;
            this.lblTime_Disc.Location = new System.Drawing.Point(16, 347);
            this.lblTime_Disc.Name = "lblTime_Disc";
            this.lblTime_Disc.Size = new System.Drawing.Size(35, 13);
            this.lblTime_Disc.TabIndex = 2;
            this.lblTime_Disc.Text = "label3";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lbEntity);
            this.groupBox3.Controls.Add(this.btnEntity);
            this.groupBox3.Controls.Add(this.lblEntity);
            this.groupBox3.Controls.Add(this.lblTime_Entity);
            this.groupBox3.Location = new System.Drawing.Point(541, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 426);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "3";
            // 
            // lbEntity
            // 
            this.lbEntity.FormattingEnabled = true;
            this.lbEntity.Location = new System.Drawing.Point(16, 64);
            this.lbEntity.Name = "lbEntity";
            this.lbEntity.Size = new System.Drawing.Size(120, 264);
            this.lbEntity.TabIndex = 0;
            // 
            // btnEntity
            // 
            this.btnEntity.Location = new System.Drawing.Point(16, 382);
            this.btnEntity.Name = "btnEntity";
            this.btnEntity.Size = new System.Drawing.Size(145, 23);
            this.btnEntity.TabIndex = 3;
            this.btnEntity.Text = "Entity Framework Başlat";
            this.btnEntity.UseVisualStyleBackColor = true;
            this.btnEntity.Click += new System.EventHandler(this.btnEntity_Click);
            // 
            // lblEntity
            // 
            this.lblEntity.AutoSize = true;
            this.lblEntity.Location = new System.Drawing.Point(16, 30);
            this.lblEntity.Name = "lblEntity";
            this.lblEntity.Size = new System.Drawing.Size(120, 13);
            this.lblEntity.TabIndex = 1;
            this.lblEntity.Text = "ENTITY FRAMEWORK";
            // 
            // lblTime_Entity
            // 
            this.lblTime_Entity.AutoSize = true;
            this.lblTime_Entity.Location = new System.Drawing.Point(16, 347);
            this.lblTime_Entity.Name = "lblTime_Entity";
            this.lblTime_Entity.Size = new System.Drawing.Size(35, 13);
            this.lblTime_Entity.TabIndex = 2;
            this.lblTime_Entity.Text = "label5";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbConnected;
        private System.Windows.Forms.Label lblConnected;
        private System.Windows.Forms.Label lblTime_Cnn;
        private System.Windows.Forms.Button btnConnected;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox lbDisconnected;
        private System.Windows.Forms.Button btnDisconnected;
        private System.Windows.Forms.Label lblDisconnected;
        private System.Windows.Forms.Label lblTime_Disc;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListBox lbEntity;
        private System.Windows.Forms.Button btnEntity;
        private System.Windows.Forms.Label lblEntity;
        private System.Windows.Forms.Label lblTime_Entity;
    }
}

