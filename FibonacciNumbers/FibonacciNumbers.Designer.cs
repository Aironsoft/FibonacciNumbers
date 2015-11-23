namespace FibonacciNumbers
{
    partial class FibonacciNumbers
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbCount = new System.Windows.Forms.Label();
            this.tbCount = new System.Windows.Forms.TextBox();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.rtbOutput = new System.Windows.Forms.RichTextBox();
            this.btOK = new System.Windows.Forms.Button();
            this.backgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // lbCount
            // 
            this.lbCount.AutoSize = true;
            this.lbCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbCount.ForeColor = System.Drawing.SystemColors.Window;
            this.lbCount.Location = new System.Drawing.Point(12, 9);
            this.lbCount.Name = "lbCount";
            this.lbCount.Size = new System.Drawing.Size(269, 20);
            this.lbCount.TabIndex = 0;
            this.lbCount.Text = "Количество чисел Фибоначчи:";
            // 
            // tbCount
            // 
            this.tbCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbCount.Location = new System.Drawing.Point(287, 6);
            this.tbCount.Name = "tbCount";
            this.tbCount.Size = new System.Drawing.Size(100, 26);
            this.tbCount.TabIndex = 1;
            // 
            // progressBar
            // 
            this.progressBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar.Location = new System.Drawing.Point(12, 304);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(643, 23);
            this.progressBar.TabIndex = 2;
            // 
            // rtbOutput
            // 
            this.rtbOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbOutput.Location = new System.Drawing.Point(12, 46);
            this.rtbOutput.Name = "rtbOutput";
            this.rtbOutput.Size = new System.Drawing.Size(643, 252);
            this.rtbOutput.TabIndex = 3;
            this.rtbOutput.Text = "";
            // 
            // btOK
            // 
            this.btOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btOK.Location = new System.Drawing.Point(404, 3);
            this.btOK.Name = "btOK";
            this.btOK.Size = new System.Drawing.Size(46, 32);
            this.btOK.TabIndex = 4;
            this.btOK.Text = "OK";
            this.btOK.UseVisualStyleBackColor = true;
            this.btOK.Click += new System.EventHandler(this.btOK_Click);
            // 
            // backgroundWorker
            // 
            this.backgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker_DoWork);
            // 
            // FibonacciNumbers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(667, 339);
            this.Controls.Add(this.btOK);
            this.Controls.Add(this.rtbOutput);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.tbCount);
            this.Controls.Add(this.lbCount);
            this.Name = "FibonacciNumbers";
            this.Text = "FibonacciNumbers";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbCount;
        private System.Windows.Forms.TextBox tbCount;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.RichTextBox rtbOutput;
        private System.Windows.Forms.Button btOK;
        private System.ComponentModel.BackgroundWorker backgroundWorker;
    }
}

