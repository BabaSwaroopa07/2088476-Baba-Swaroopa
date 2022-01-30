namespace WinFormCalc
{
    partial class lblInputs
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblinput = new System.Windows.Forms.Label();
            this.textinput1 = new System.Windows.Forms.TextBox();
            this.textinput2 = new System.Windows.Forms.TextBox();
            this.lblOp = new System.Windows.Forms.Label();
            this.rbtnAdd = new System.Windows.Forms.RadioButton();
            this.rbtnSub = new System.Windows.Forms.RadioButton();
            this.rbtnMul = new System.Windows.Forms.RadioButton();
            this.rbtnDiv = new System.Windows.Forms.RadioButton();
            this.btnSub = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // lblinput
            // 
            this.lblinput.AutoSize = true;
            this.lblinput.Location = new System.Drawing.Point(24, 40);
            this.lblinput.Name = "lblinput";
            this.lblinput.Size = new System.Drawing.Size(97, 16);
            this.lblinput.TabIndex = 1;
            this.lblinput.Text = "Enter the Inputs";
            // 
            // textinput1
            // 
            this.textinput1.Location = new System.Drawing.Point(215, 40);
            this.textinput1.Name = "textinput1";
            this.textinput1.Size = new System.Drawing.Size(156, 22);
            this.textinput1.TabIndex = 2;
            // 
            // textinput2
            // 
            this.textinput2.Location = new System.Drawing.Point(424, 39);
            this.textinput2.Name = "textinput2";
            this.textinput2.Size = new System.Drawing.Size(167, 22);
            this.textinput2.TabIndex = 3;
            // 
            // lblOp
            // 
            this.lblOp.AutoSize = true;
            this.lblOp.Location = new System.Drawing.Point(27, 99);
            this.lblOp.Name = "lblOp";
            this.lblOp.Size = new System.Drawing.Size(105, 16);
            this.lblOp.TabIndex = 4;
            this.lblOp.Text = "Math Operations";
            // 
            // rbtnAdd
            // 
            this.rbtnAdd.AutoSize = true;
            this.rbtnAdd.Location = new System.Drawing.Point(233, 112);
            this.rbtnAdd.Name = "rbtnAdd";
            this.rbtnAdd.Size = new System.Drawing.Size(77, 20);
            this.rbtnAdd.TabIndex = 5;
            this.rbtnAdd.TabStop = true;
            this.rbtnAdd.Text = "Addition";
            this.rbtnAdd.UseVisualStyleBackColor = true;
            // 
            // rbtnSub
            // 
            this.rbtnSub.AutoSize = true;
            this.rbtnSub.Location = new System.Drawing.Point(233, 138);
            this.rbtnSub.Name = "rbtnSub";
            this.rbtnSub.Size = new System.Drawing.Size(95, 20);
            this.rbtnSub.TabIndex = 6;
            this.rbtnSub.TabStop = true;
            this.rbtnSub.Text = "Subtraction";
            this.rbtnSub.UseVisualStyleBackColor = true;
            // 
            // rbtnMul
            // 
            this.rbtnMul.AutoSize = true;
            this.rbtnMul.Location = new System.Drawing.Point(233, 164);
            this.rbtnMul.Name = "rbtnMul";
            this.rbtnMul.Size = new System.Drawing.Size(105, 20);
            this.rbtnMul.TabIndex = 7;
            this.rbtnMul.TabStop = true;
            this.rbtnMul.Text = "Multiplication";
            this.rbtnMul.UseVisualStyleBackColor = true;
            // 
            // rbtnDiv
            // 
            this.rbtnDiv.AutoSize = true;
            this.rbtnDiv.Location = new System.Drawing.Point(233, 190);
            this.rbtnDiv.Name = "rbtnDiv";
            this.rbtnDiv.Size = new System.Drawing.Size(73, 20);
            this.rbtnDiv.TabIndex = 8;
            this.rbtnDiv.TabStop = true;
            this.rbtnDiv.Text = "Divison";
            this.rbtnDiv.UseVisualStyleBackColor = true;
            // 
            // btnSub
            // 
            this.btnSub.Location = new System.Drawing.Point(206, 232);
            this.btnSub.Name = "btnSub";
            this.btnSub.Size = new System.Drawing.Size(132, 23);
            this.btnSub.TabIndex = 9;
            this.btnSub.Text = "Submit";
            this.btnSub.UseVisualStyleBackColor = true;
            this.btnSub.Click += new System.EventHandler(this.btnSub_Click);
            // 
            // lblInputs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSub);
            this.Controls.Add(this.rbtnDiv);
            this.Controls.Add(this.rbtnMul);
            this.Controls.Add(this.rbtnSub);
            this.Controls.Add(this.rbtnAdd);
            this.Controls.Add(this.lblOp);
            this.Controls.Add(this.textinput2);
            this.Controls.Add(this.textinput1);
            this.Controls.Add(this.lblinput);
            this.Controls.Add(this.label1);
            this.Name = "lblInputs";
            this.Text = "Enter the Inputs";
            this.Load += new System.EventHandler(this.lblInputs_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblinput;
        private System.Windows.Forms.TextBox textinput1;
        private System.Windows.Forms.TextBox textinput2;
        private System.Windows.Forms.Label lblOp;
        private System.Windows.Forms.RadioButton rbtnAdd;
        private System.Windows.Forms.RadioButton rbtnSub;
        private System.Windows.Forms.RadioButton rbtnMul;
        private System.Windows.Forms.RadioButton rbtnDiv;
        private System.Windows.Forms.Button btnSub;
    }
}

