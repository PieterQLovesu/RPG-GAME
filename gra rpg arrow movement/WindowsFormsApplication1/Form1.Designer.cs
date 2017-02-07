namespace WindowsFormsApplication1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.picturePotionEQ = new System.Windows.Forms.PictureBox();
            this.pictureBox14 = new System.Windows.Forms.PictureBox();

            this.ButtonPick = new System.Windows.Forms.Button();
            this.buttonAttack = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.progressBarHp = new System.Windows.Forms.ProgressBar();
            this.label2 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.picturePotionEQ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox14)).BeginInit();
            this.SuspendLayout();
            // 
            // picturePotionEQ
            // 
            this.picturePotionEQ.BackColor = System.Drawing.Color.Transparent;
            this.picturePotionEQ.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picturePotionEQ.BackgroundImage")));
            this.picturePotionEQ.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picturePotionEQ.Location = new System.Drawing.Point(79, 319);
            this.picturePotionEQ.Name = "picturePotionEQ";
            this.picturePotionEQ.Size = new System.Drawing.Size(50, 50);
            this.picturePotionEQ.TabIndex = 12;
            this.picturePotionEQ.TabStop = false;
            this.picturePotionEQ.Visible = false;
            this.picturePotionEQ.Click += new System.EventHandler(this.picturePotionEQ_Click);
            // 
            // pictureBox14
            // 
            this.pictureBox14.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox14.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox14.Image = global::WindowsFormsApplication1.Properties.Resources.potion_blue;
            this.pictureBox14.Location = new System.Drawing.Point(135, 319);
            this.pictureBox14.Name = "pictureBox14";
            this.pictureBox14.Size = new System.Drawing.Size(50, 50);
            this.pictureBox14.TabIndex = 13;
            this.pictureBox14.TabStop = false;
            this.pictureBox14.Visible = false;
           
            // 
            // ButtonPick
            // 
            this.ButtonPick.Location = new System.Drawing.Point(468, 353);
            this.ButtonPick.Name = "ButtonPick";
            this.ButtonPick.Size = new System.Drawing.Size(75, 23);
            this.ButtonPick.TabIndex = 20;
            this.ButtonPick.Text = "Pick";
            this.ButtonPick.UseVisualStyleBackColor = true;
            this.ButtonPick.Visible = false;
            this.ButtonPick.Click += new System.EventHandler(this.ButtonPick_Click);
            // 
            // buttonAttack
            // 
            this.buttonAttack.Location = new System.Drawing.Point(468, 324);
            this.buttonAttack.Name = "buttonAttack";
            this.buttonAttack.Size = new System.Drawing.Size(75, 23);
            this.buttonAttack.TabIndex = 21;
            this.buttonAttack.Text = "Attack";
            this.buttonAttack.UseVisualStyleBackColor = true;
            this.buttonAttack.Click += new System.EventHandler(this.buttonAttack_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(631, 269);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "HPBat";
            // 
            // progressBarHp
            // 
            this.progressBarHp.Location = new System.Drawing.Point(634, 285);
            this.progressBarHp.Maximum = 10;
            this.progressBarHp.Name = "progressBarHp";
            this.progressBarHp.Size = new System.Drawing.Size(88, 13);
            this.progressBarHp.TabIndex = 23;
            this.progressBarHp.Value = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(380, 269);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "HpGracz";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(435, 269);
            this.progressBar1.Maximum = 30;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(88, 16);
            this.progressBar1.TabIndex = 25;
            this.progressBar1.Value = 30;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.nowamapa;
            this.ClientSize = new System.Drawing.Size(747, 399);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.progressBarHp);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonAttack);
            this.Controls.Add(this.ButtonPick);
            this.Controls.Add(this.pictureBox14);
            this.Controls.Add(this.picturePotionEQ);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picturePotionEQ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox14)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox picturePotionEQ;
        private System.Windows.Forms.PictureBox pictureBox14;
        private System.Windows.Forms.Button ButtonPick;
        private System.Windows.Forms.Button buttonAttack;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar progressBarHp;
        private System.Windows.Forms.Label label2;
        // private System.Windows.Forms.ProgressBar progressBar1;
    }
}

