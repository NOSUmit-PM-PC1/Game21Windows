namespace Game21Windows
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
            this.buttonTake = new System.Windows.Forms.Button();
            this.buttonNotTake = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.labelCard = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelSum = new System.Windows.Forms.Label();
            this.labelCountStep = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonTake
            // 
            this.buttonTake.Location = new System.Drawing.Point(139, 208);
            this.buttonTake.Name = "buttonTake";
            this.buttonTake.Size = new System.Drawing.Size(165, 70);
            this.buttonTake.TabIndex = 0;
            this.buttonTake.Text = "БЕРУ";
            this.buttonTake.UseVisualStyleBackColor = true;
            this.buttonTake.Click += new System.EventHandler(this.buttonTake_Click);
            // 
            // buttonNotTake
            // 
            this.buttonNotTake.Location = new System.Drawing.Point(419, 208);
            this.buttonNotTake.Name = "buttonNotTake";
            this.buttonNotTake.Size = new System.Drawing.Size(165, 70);
            this.buttonNotTake.TabIndex = 1;
            this.buttonNotTake.Text = "НЕ БЕРУ";
            this.buttonNotTake.UseVisualStyleBackColor = true;
            this.buttonNotTake.Click += new System.EventHandler(this.buttonNotTake_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(330, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "карта";
            // 
            // labelCard
            // 
            this.labelCard.AutoSize = true;
            this.labelCard.BackColor = System.Drawing.Color.Aqua;
            this.labelCard.Font = new System.Drawing.Font("Microsoft YaHei", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCard.ForeColor = System.Drawing.Color.Red;
            this.labelCard.Location = new System.Drawing.Point(302, 71);
            this.labelCard.Name = "labelCard";
            this.labelCard.Size = new System.Drawing.Size(128, 96);
            this.labelCard.TabIndex = 3;
            this.labelCard.Text = "13";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(226, 325);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "итого очков";
            // 
            // labelSum
            // 
            this.labelSum.AutoSize = true;
            this.labelSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSum.Location = new System.Drawing.Point(232, 354);
            this.labelSum.Name = "labelSum";
            this.labelSum.Size = new System.Drawing.Size(54, 59);
            this.labelSum.TabIndex = 5;
            this.labelSum.Text = "0";
            // 
            // labelCountStep
            // 
            this.labelCountStep.AutoSize = true;
            this.labelCountStep.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCountStep.Location = new System.Drawing.Point(380, 355);
            this.labelCountStep.Name = "labelCountStep";
            this.labelCountStep.Size = new System.Drawing.Size(54, 59);
            this.labelCountStep.TabIndex = 7;
            this.labelCountStep.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(361, 325);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 30);
            this.label3.TabIndex = 8;
            this.label3.Text = "всего шагов";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelCountStep);
            this.Controls.Add(this.labelSum);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelCard);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonNotTake);
            this.Controls.Add(this.buttonTake);
            this.Name = "FormMain";
            this.Text = "Игра 21 очко";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonTake;
        private System.Windows.Forms.Button buttonNotTake;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelCard;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelSum;
        private System.Windows.Forms.Label labelCountStep;
        private System.Windows.Forms.Label label3;
    }
}

