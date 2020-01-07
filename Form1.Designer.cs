namespace CarRent
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
            this.textLabel1 = new System.Windows.Forms.Label();
            this.textLabel2 = new System.Windows.Forms.Label();
            this.EnterOrEscapeLabel = new System.Windows.Forms.Label();
            this.textLabel3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textLabel1
            // 
            this.textLabel1.AutoSize = true;
            this.textLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold);
            this.textLabel1.Location = new System.Drawing.Point(47, 11);
            this.textLabel1.Name = "textLabel1";
            this.textLabel1.Size = new System.Drawing.Size(331, 16);
            this.textLabel1.TabIndex = 0;
            this.textLabel1.Text = "Welcome to RentC,your brand new solution to";
            // 
            // textLabel2
            // 
            this.textLabel2.AutoSize = true;
            this.textLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold);
            this.textLabel2.Location = new System.Drawing.Point(47, 31);
            this.textLabel2.Name = "textLabel2";
            this.textLabel2.Size = new System.Drawing.Size(298, 16);
            this.textLabel2.TabIndex = 1;
            this.textLabel2.Text = "manage and control your company's data";
            // 
            // EnterOrEscapeLabel
            // 
            this.EnterOrEscapeLabel.AutoSize = true;
            this.EnterOrEscapeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold);
            this.EnterOrEscapeLabel.Location = new System.Drawing.Point(47, 300);
            this.EnterOrEscapeLabel.Name = "EnterOrEscapeLabel";
            this.EnterOrEscapeLabel.Size = new System.Drawing.Size(302, 16);
            this.EnterOrEscapeLabel.TabIndex = 2;
            this.EnterOrEscapeLabel.Text = "Press ENTER to continue or ESC to quit.";
            // 
            // textLabel3
            // 
            this.textLabel3.AutoSize = true;
            this.textLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold);
            this.textLabel3.Location = new System.Drawing.Point(47, 50);
            this.textLabel3.Name = "textLabel3";
            this.textLabel3.Size = new System.Drawing.Size(181, 16);
            this.textLabel3.TabIndex = 3;
            this.textLabel3.Text = "without missing anything.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 336);
            this.Controls.Add(this.textLabel3);
            this.Controls.Add(this.EnterOrEscapeLabel);
            this.Controls.Add(this.textLabel2);
            this.Controls.Add(this.textLabel1);
            this.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

            }

            #endregion

            private System.Windows.Forms.Label textLabel1;
            private System.Windows.Forms.Label textLabel2;
            private System.Windows.Forms.Label textLabel3;
            private System.Windows.Forms.Label EnterOrEscapeLabel;
            
    }
    }