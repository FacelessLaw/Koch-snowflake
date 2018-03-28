namespace WindowsFormsApplication1
{
    partial class Form1
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
            this.Snowflake = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Out = new System.Windows.Forms.Label();
            this.NextD = new System.Windows.Forms.Button();
            this.StrtDraw = new System.Windows.Forms.Button();
            this.CLR = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Snowflake)).BeginInit();
            this.SuspendLayout();
            // 
            // Snowflake
            // 
            this.Snowflake.Location = new System.Drawing.Point(12, 12);
            this.Snowflake.Name = "Snowflake";
            this.Snowflake.Size = new System.Drawing.Size(422, 350);
            this.Snowflake.TabIndex = 0;
            this.Snowflake.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label1.Location = new System.Drawing.Point(440, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Current depth:";
            // 
            // Out
            // 
            this.Out.AutoSize = true;
            this.Out.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.Out.Location = new System.Drawing.Point(492, 93);
            this.Out.Name = "Out";
            this.Out.Size = new System.Drawing.Size(18, 20);
            this.Out.TabIndex = 2;
            this.Out.Text = "0";
            // 
            // NextD
            // 
            this.NextD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.NextD.Location = new System.Drawing.Point(444, 116);
            this.NextD.Name = "NextD";
            this.NextD.Size = new System.Drawing.Size(112, 30);
            this.NextD.TabIndex = 3;
            this.NextD.Text = "Next";
            this.NextD.UseVisualStyleBackColor = true;
            this.NextD.Click += new System.EventHandler(this.NextD_Click);
            // 
            // StrtDraw
            // 
            this.StrtDraw.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.StrtDraw.Location = new System.Drawing.Point(444, 12);
            this.StrtDraw.Name = "StrtDraw";
            this.StrtDraw.Size = new System.Drawing.Size(112, 50);
            this.StrtDraw.TabIndex = 4;
            this.StrtDraw.Text = "Start drawing";
            this.StrtDraw.UseVisualStyleBackColor = true;
            this.StrtDraw.Click += new System.EventHandler(this.StrtDraw_Click);
            // 
            // CLR
            // 
            this.CLR.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.CLR.Location = new System.Drawing.Point(440, 310);
            this.CLR.Name = "CLR";
            this.CLR.Size = new System.Drawing.Size(112, 30);
            this.CLR.TabIndex = 5;
            this.CLR.Text = "Clear";
            this.CLR.UseVisualStyleBackColor = true;
            this.CLR.Click += new System.EventHandler(this.CLR_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 373);
            this.Controls.Add(this.CLR);
            this.Controls.Add(this.StrtDraw);
            this.Controls.Add(this.NextD);
            this.Controls.Add(this.Out);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Snowflake);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.Snowflake)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Snowflake;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Out;
        private System.Windows.Forms.Button NextD;
        private System.Windows.Forms.Button StrtDraw;
        private System.Windows.Forms.Button CLR;
    }
}

