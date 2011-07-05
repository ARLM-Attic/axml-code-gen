namespace AXMLCodeGenerator_Test
{
    partial class TestForm
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
            this.tbAXML = new System.Windows.Forms.TextBox();
            this.tbCSharp = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tbViewName = new System.Windows.Forms.TextBox();
            this.tbActivityName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbNamespace = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "AXML";
            // 
            // tbAXML
            // 
            this.tbAXML.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbAXML.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAXML.Location = new System.Drawing.Point(12, 29);
            this.tbAXML.Multiline = true;
            this.tbAXML.Name = "tbAXML";
            this.tbAXML.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbAXML.Size = new System.Drawing.Size(690, 193);
            this.tbAXML.TabIndex = 1;
            // 
            // tbCSharp
            // 
            this.tbCSharp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbCSharp.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCSharp.Location = new System.Drawing.Point(12, 292);
            this.tbCSharp.Multiline = true;
            this.tbCSharp.Name = "tbCSharp";
            this.tbCSharp.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbCSharp.Size = new System.Drawing.Size(690, 292);
            this.tbCSharp.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 274);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "C#";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(627, 241);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Convert";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(95, 246);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "View:";
            // 
            // tbViewName
            // 
            this.tbViewName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbViewName.Location = new System.Drawing.Point(134, 243);
            this.tbViewName.Name = "tbViewName";
            this.tbViewName.Size = new System.Drawing.Size(115, 20);
            this.tbViewName.TabIndex = 6;
            // 
            // tbActivityName
            // 
            this.tbActivityName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbActivityName.Location = new System.Drawing.Point(312, 243);
            this.tbActivityName.Name = "tbActivityName";
            this.tbActivityName.Size = new System.Drawing.Size(115, 20);
            this.tbActivityName.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(262, 246);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Activity:";
            // 
            // tbNamespace
            // 
            this.tbNamespace.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbNamespace.Location = new System.Drawing.Point(506, 243);
            this.tbNamespace.Name = "tbNamespace";
            this.tbNamespace.Size = new System.Drawing.Size(115, 20);
            this.tbNamespace.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(433, 246);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Namespace:";
            // 
            // TestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 596);
            this.Controls.Add(this.tbNamespace);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbActivityName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbViewName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbCSharp);
            this.Controls.Add(this.tbAXML);
            this.Controls.Add(this.label1);
            this.Name = "TestForm";
            this.Text = "TestForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbAXML;
        private System.Windows.Forms.TextBox tbCSharp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbViewName;
        private System.Windows.Forms.TextBox tbActivityName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbNamespace;
        private System.Windows.Forms.Label label5;
    }
}