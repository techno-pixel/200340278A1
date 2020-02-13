namespace ChangeCalculator
{
    partial class ChangeCalculator
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
            this.clearBtn = new System.Windows.Forms.Button();
            this.calcBtn = new System.Windows.Forms.Button();
            this.tooniesOutput = new System.Windows.Forms.TextBox();
            this.looniesOutput = new System.Windows.Forms.TextBox();
            this.quartersOutput = new System.Windows.Forms.TextBox();
            this.dimesOutput = new System.Windows.Forms.TextBox();
            this.nickelOutput = new System.Windows.Forms.TextBox();
            this.totalInput = new System.Windows.Forms.TextBox();
            this.paidInput = new System.Windows.Forms.TextBox();
            this.changeOutput = new System.Windows.Forms.TextBox();
            this.nickels = new System.Windows.Forms.Label();
            this.dimes = new System.Windows.Forms.Label();
            this.quarters = new System.Windows.Forms.Label();
            this.loonies = new System.Windows.Forms.Label();
            this.toonies = new System.Windows.Forms.Label();
            this.total = new System.Windows.Forms.Label();
            this.paid = new System.Windows.Forms.Label();
            this.change = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // clearBtn
            // 
            this.clearBtn.Location = new System.Drawing.Point(233, 108);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(57, 23);
            this.clearBtn.TabIndex = 0;
            this.clearBtn.Text = "Clear";
            this.clearBtn.UseVisualStyleBackColor = true;
            // 
            // calcBtn
            // 
            this.calcBtn.Location = new System.Drawing.Point(12, 108);
            this.calcBtn.Name = "calcBtn";
            this.calcBtn.Size = new System.Drawing.Size(75, 23);
            this.calcBtn.TabIndex = 1;
            this.calcBtn.Text = "Calculate";
            this.calcBtn.UseVisualStyleBackColor = true;
            this.calcBtn.Click += new System.EventHandler(this.calcBtn_Click);
            // 
            // tooniesOutput
            // 
            this.tooniesOutput.Location = new System.Drawing.Point(13, 71);
            this.tooniesOutput.Name = "tooniesOutput";
            this.tooniesOutput.ReadOnly = true;
            this.tooniesOutput.Size = new System.Drawing.Size(53, 20);
            this.tooniesOutput.TabIndex = 2;
            this.tooniesOutput.TextChanged += new System.EventHandler(this.tooniesOutput_TextChanged);
            // 
            // looniesOutput
            // 
            this.looniesOutput.Location = new System.Drawing.Point(68, 71);
            this.looniesOutput.Name = "looniesOutput";
            this.looniesOutput.ReadOnly = true;
            this.looniesOutput.Size = new System.Drawing.Size(53, 20);
            this.looniesOutput.TabIndex = 3;
            this.looniesOutput.TextChanged += new System.EventHandler(this.looniesOutput_TextChanged);
            // 
            // quartersOutput
            // 
            this.quartersOutput.Location = new System.Drawing.Point(123, 71);
            this.quartersOutput.Name = "quartersOutput";
            this.quartersOutput.ReadOnly = true;
            this.quartersOutput.Size = new System.Drawing.Size(53, 20);
            this.quartersOutput.TabIndex = 4;
            // 
            // dimesOutput
            // 
            this.dimesOutput.Location = new System.Drawing.Point(179, 71);
            this.dimesOutput.Name = "dimesOutput";
            this.dimesOutput.ReadOnly = true;
            this.dimesOutput.Size = new System.Drawing.Size(53, 20);
            this.dimesOutput.TabIndex = 5;
            // 
            // nickelOutput
            // 
            this.nickelOutput.Location = new System.Drawing.Point(235, 71);
            this.nickelOutput.Name = "nickelOutput";
            this.nickelOutput.ReadOnly = true;
            this.nickelOutput.Size = new System.Drawing.Size(53, 20);
            this.nickelOutput.TabIndex = 6;
            // 
            // totalInput
            // 
            this.totalInput.Location = new System.Drawing.Point(13, 23);
            this.totalInput.Name = "totalInput";
            this.totalInput.Size = new System.Drawing.Size(53, 20);
            this.totalInput.TabIndex = 7;
            this.totalInput.TextChanged += new System.EventHandler(this.totalInput_TextChanged);
            // 
            // paidInput
            // 
            this.paidInput.Location = new System.Drawing.Point(68, 23);
            this.paidInput.Name = "paidInput";
            this.paidInput.Size = new System.Drawing.Size(53, 20);
            this.paidInput.TabIndex = 8;
            this.paidInput.TextChanged += new System.EventHandler(this.paidInput_TextChanged);
            // 
            // changeOutput
            // 
            this.changeOutput.Location = new System.Drawing.Point(123, 23);
            this.changeOutput.Name = "changeOutput";
            this.changeOutput.ReadOnly = true;
            this.changeOutput.Size = new System.Drawing.Size(53, 20);
            this.changeOutput.TabIndex = 9;
            this.changeOutput.TextChanged += new System.EventHandler(this.changeOutput_TextChanged);
            // 
            // nickels
            // 
            this.nickels.AutoSize = true;
            this.nickels.Location = new System.Drawing.Point(232, 55);
            this.nickels.Name = "nickels";
            this.nickels.Size = new System.Drawing.Size(42, 13);
            this.nickels.TabIndex = 10;
            this.nickels.Text = "Nickels";
            // 
            // dimes
            // 
            this.dimes.AutoSize = true;
            this.dimes.Location = new System.Drawing.Point(176, 55);
            this.dimes.Name = "dimes";
            this.dimes.Size = new System.Drawing.Size(36, 13);
            this.dimes.TabIndex = 11;
            this.dimes.Text = "Dimes";
            // 
            // quarters
            // 
            this.quarters.AutoSize = true;
            this.quarters.Location = new System.Drawing.Point(120, 55);
            this.quarters.Name = "quarters";
            this.quarters.Size = new System.Drawing.Size(47, 13);
            this.quarters.TabIndex = 12;
            this.quarters.Text = "Quarters";
            // 
            // loonies
            // 
            this.loonies.AutoSize = true;
            this.loonies.Location = new System.Drawing.Point(65, 55);
            this.loonies.Name = "loonies";
            this.loonies.Size = new System.Drawing.Size(44, 13);
            this.loonies.TabIndex = 13;
            this.loonies.Text = "Loonies";
            // 
            // toonies
            // 
            this.toonies.AutoSize = true;
            this.toonies.Location = new System.Drawing.Point(12, 55);
            this.toonies.Name = "toonies";
            this.toonies.Size = new System.Drawing.Size(45, 13);
            this.toonies.TabIndex = 14;
            this.toonies.Text = "Toonies";
            this.toonies.Click += new System.EventHandler(this.Toonies_Click);
            // 
            // total
            // 
            this.total.AutoSize = true;
            this.total.Location = new System.Drawing.Point(12, 7);
            this.total.Name = "total";
            this.total.Size = new System.Drawing.Size(31, 13);
            this.total.TabIndex = 15;
            this.total.Text = "Total";
            this.total.Click += new System.EventHandler(this.total_Click);
            // 
            // paid
            // 
            this.paid.AutoSize = true;
            this.paid.Location = new System.Drawing.Point(65, 7);
            this.paid.Name = "paid";
            this.paid.Size = new System.Drawing.Size(28, 13);
            this.paid.TabIndex = 16;
            this.paid.Text = "Paid";
            // 
            // change
            // 
            this.change.AutoSize = true;
            this.change.Location = new System.Drawing.Point(120, 7);
            this.change.Name = "change";
            this.change.Size = new System.Drawing.Size(44, 13);
            this.change.TabIndex = 17;
            this.change.Text = "Change";
            // 
            // ChangeCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(299, 143);
            this.Controls.Add(this.change);
            this.Controls.Add(this.paid);
            this.Controls.Add(this.total);
            this.Controls.Add(this.toonies);
            this.Controls.Add(this.loonies);
            this.Controls.Add(this.quarters);
            this.Controls.Add(this.dimes);
            this.Controls.Add(this.nickels);
            this.Controls.Add(this.changeOutput);
            this.Controls.Add(this.paidInput);
            this.Controls.Add(this.totalInput);
            this.Controls.Add(this.nickelOutput);
            this.Controls.Add(this.dimesOutput);
            this.Controls.Add(this.quartersOutput);
            this.Controls.Add(this.looniesOutput);
            this.Controls.Add(this.tooniesOutput);
            this.Controls.Add(this.calcBtn);
            this.Controls.Add(this.clearBtn);
            this.Name = "ChangeCalculator";
            this.Text = "Change Calculator";
            this.Load += new System.EventHandler(this.ChangeCalculator_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.Button calcBtn;
        private System.Windows.Forms.TextBox tooniesOutput;
        private System.Windows.Forms.TextBox looniesOutput;
        private System.Windows.Forms.TextBox quartersOutput;
        private System.Windows.Forms.TextBox dimesOutput;
        private System.Windows.Forms.TextBox nickelOutput;
        private System.Windows.Forms.TextBox totalInput;
        private System.Windows.Forms.TextBox paidInput;
        private System.Windows.Forms.TextBox changeOutput;
        private System.Windows.Forms.Label nickels;
        private System.Windows.Forms.Label dimes;
        private System.Windows.Forms.Label quarters;
        private System.Windows.Forms.Label loonies;
        private System.Windows.Forms.Label toonies;
        private System.Windows.Forms.Label total;
        private System.Windows.Forms.Label paid;
        private System.Windows.Forms.Label change;
    }
}

