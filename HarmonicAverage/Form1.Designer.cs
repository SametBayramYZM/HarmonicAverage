
namespace HarmonicAverage
{
    partial class HarmonicAverage
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbA = new System.Windows.Forms.Label();
            this.lbB = new System.Windows.Forms.Label();
            this.tbA = new System.Windows.Forms.TextBox();
            this.tbB = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lbHA = new System.Windows.Forms.Label();
            this.lbAnswer = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbA
            // 
            this.lbA.AutoSize = true;
            this.lbA.Location = new System.Drawing.Point(12, 66);
            this.lbA.Name = "lbA";
            this.lbA.Size = new System.Drawing.Size(60, 13);
            this.lbA.TabIndex = 0;
            this.lbA.Text = "A Number :";
            // 
            // lbB
            // 
            this.lbB.AutoSize = true;
            this.lbB.Location = new System.Drawing.Point(12, 112);
            this.lbB.Name = "lbB";
            this.lbB.Size = new System.Drawing.Size(60, 13);
            this.lbB.TabIndex = 1;
            this.lbB.Text = "B Number :";
            // 
            // tbA
            // 
            this.tbA.Location = new System.Drawing.Point(121, 63);
            this.tbA.Name = "tbA";
            this.tbA.Size = new System.Drawing.Size(126, 20);
            this.tbA.TabIndex = 2;
            // 
            // tbB
            // 
            this.tbB.Location = new System.Drawing.Point(121, 109);
            this.tbB.Name = "tbB";
            this.tbB.Size = new System.Drawing.Size(126, 20);
            this.tbB.TabIndex = 3;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(134, 219);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 24);
            this.btnCalculate.TabIndex = 4;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // lbHA
            // 
            this.lbHA.AutoSize = true;
            this.lbHA.Location = new System.Drawing.Point(15, 169);
            this.lbHA.Name = "lbHA";
            this.lbHA.Size = new System.Drawing.Size(98, 13);
            this.lbHA.TabIndex = 5;
            this.lbHA.Text = "HarmonicAverage :";
            // 
            // lbAnswer
            // 
            this.lbAnswer.AutoSize = true;
            this.lbAnswer.Location = new System.Drawing.Point(118, 169);
            this.lbAnswer.Name = "lbAnswer";
            this.lbAnswer.Size = new System.Drawing.Size(0, 13);
            this.lbAnswer.TabIndex = 6;
            // 
            // HarmonicAverage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(259, 286);
            this.Controls.Add(this.lbAnswer);
            this.Controls.Add(this.lbHA);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.tbB);
            this.Controls.Add(this.tbA);
            this.Controls.Add(this.lbB);
            this.Controls.Add(this.lbA);
            this.Name = "HarmonicAverage";
            this.Text = "HarmonicAverage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbA;
        private System.Windows.Forms.Label lbB;
        private System.Windows.Forms.TextBox tbA;
        private System.Windows.Forms.TextBox tbB;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lbHA;
        private System.Windows.Forms.Label lbAnswer;
    }
}

