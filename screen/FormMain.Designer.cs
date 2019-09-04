namespace screen
{
    partial class FormMain
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBoxMain = new System.Windows.Forms.PictureBox();
            this.buttonTracking = new System.Windows.Forms.Button();
            this.labelAlarm = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBoxSecond = new System.Windows.Forms.PictureBox();
            this.panelColor1 = new System.Windows.Forms.Panel();
            this.panelColor2 = new System.Windows.Forms.Panel();
            this.checkBoxSound = new System.Windows.Forms.CheckBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.labelTime = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSecond)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(24, 26);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(519, 74);
            this.button1.TabIndex = 0;
            this.button1.Text = "Take windows";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBoxMain
            // 
            this.pictureBoxMain.BackColor = System.Drawing.Color.White;
            this.pictureBoxMain.Location = new System.Drawing.Point(24, 258);
            this.pictureBoxMain.Name = "pictureBoxMain";
            this.pictureBoxMain.Size = new System.Drawing.Size(520, 284);
            this.pictureBoxMain.TabIndex = 2;
            this.pictureBoxMain.TabStop = false;
            this.pictureBoxMain.Click += new System.EventHandler(this.pictureBoxMain_Click);
            // 
            // buttonTracking
            // 
            this.buttonTracking.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonTracking.Location = new System.Drawing.Point(564, 26);
            this.buttonTracking.Name = "buttonTracking";
            this.buttonTracking.Size = new System.Drawing.Size(520, 74);
            this.buttonTracking.TabIndex = 5;
            this.buttonTracking.Text = "Tracking point";
            this.buttonTracking.UseVisualStyleBackColor = true;
            this.buttonTracking.Click += new System.EventHandler(this.buttonTracking_Click);
            // 
            // labelAlarm
            // 
            this.labelAlarm.BackColor = System.Drawing.Color.White;
            this.labelAlarm.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAlarm.ForeColor = System.Drawing.Color.Red;
            this.labelAlarm.Location = new System.Drawing.Point(565, 112);
            this.labelAlarm.Name = "labelAlarm";
            this.labelAlarm.Size = new System.Drawing.Size(520, 61);
            this.labelAlarm.TabIndex = 6;
            this.labelAlarm.Text = "     ";
            this.labelAlarm.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(159, 118);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.Location = new System.Drawing.Point(215, 123);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(159, 118);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(25, 120);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(165, 124);
            this.panel1.TabIndex = 9;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gray;
            this.panel2.Location = new System.Drawing.Point(212, 120);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(165, 124);
            this.panel2.TabIndex = 10;
            // 
            // pictureBoxSecond
            // 
            this.pictureBoxSecond.BackColor = System.Drawing.Color.White;
            this.pictureBoxSecond.Location = new System.Drawing.Point(564, 258);
            this.pictureBoxSecond.Name = "pictureBoxSecond";
            this.pictureBoxSecond.Size = new System.Drawing.Size(520, 284);
            this.pictureBoxSecond.TabIndex = 12;
            this.pictureBoxSecond.TabStop = false;
            // 
            // panelColor1
            // 
            this.panelColor1.BackColor = System.Drawing.Color.White;
            this.panelColor1.Location = new System.Drawing.Point(486, 190);
            this.panelColor1.Name = "panelColor1";
            this.panelColor1.Size = new System.Drawing.Size(57, 54);
            this.panelColor1.TabIndex = 13;
            // 
            // panelColor2
            // 
            this.panelColor2.BackColor = System.Drawing.Color.White;
            this.panelColor2.Location = new System.Drawing.Point(1027, 189);
            this.panelColor2.Name = "panelColor2";
            this.panelColor2.Size = new System.Drawing.Size(58, 55);
            this.panelColor2.TabIndex = 14;
            // 
            // checkBoxSound
            // 
            this.checkBoxSound.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxSound.AutoSize = true;
            this.checkBoxSound.Checked = true;
            this.checkBoxSound.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxSound.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBoxSound.Location = new System.Drawing.Point(774, 189);
            this.checkBoxSound.Name = "checkBoxSound";
            this.checkBoxSound.Size = new System.Drawing.Size(105, 24);
            this.checkBoxSound.TabIndex = 15;
            this.checkBoxSound.Text = "Play sound";
            this.checkBoxSound.UseVisualStyleBackColor = true;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 561);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1105, 22);
            this.statusStrip1.TabIndex = 16;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // labelTime
            // 
            this.labelTime.Location = new System.Drawing.Point(564, 177);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(166, 23);
            this.labelTime.TabIndex = 17;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1105, 583);
            this.Controls.Add(this.labelTime);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.checkBoxSound);
            this.Controls.Add(this.panelColor2);
            this.Controls.Add(this.panelColor1);
            this.Controls.Add(this.pictureBoxSecond);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.labelAlarm);
            this.Controls.Add(this.buttonTracking);
            this.Controls.Add(this.pictureBoxMain);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.Text = "CP Tracker";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSecond)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBoxMain;
        private System.Windows.Forms.Button buttonTracking;
        private System.Windows.Forms.Label labelAlarm;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBoxSecond;
        private System.Windows.Forms.Panel panelColor1;
        private System.Windows.Forms.Panel panelColor2;
        private System.Windows.Forms.CheckBox checkBoxSound;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.Label labelTime;
    }
}

