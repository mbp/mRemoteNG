

namespace mRemoteNG.UI.Forms.OptionsPages
{
    public partial class AWSPage : OptionsPage
	{
		//UserControl overrides dispose to clean up the component list.
		[System.Diagnostics.DebuggerNonUserCode()]
        protected override void Dispose(bool disposing)
		{
			try
			{
				if (disposing && components != null)
				{
					components.Dispose();
				}
			}
			finally
			{
				base.Dispose(disposing);
			}
		}
			
		//Required by the Windows Form Designer
		private System.ComponentModel.Container components = null;
			
		//NOTE: The following procedure is required by the Windows Form Designer
		//It can be modified using the Windows Form Designer.
		//Do not modify it using the code editor.
		[System.Diagnostics.DebuggerStepThrough()]
        private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AWSPage));
            this.chkEuWest1 = new System.Windows.Forms.CheckBox();
            this.chkEuWest2 = new System.Windows.Forms.CheckBox();
            this.chkEuCentral1 = new System.Windows.Forms.CheckBox();
            this.chkUsWest1 = new System.Windows.Forms.CheckBox();
            this.chkUsWest2 = new System.Windows.Forms.CheckBox();
            this.chkUsEast1 = new System.Windows.Forms.CheckBox();
            this.chkUsEast2 = new System.Windows.Forms.CheckBox();
            this.chkApNorthEast2 = new System.Windows.Forms.CheckBox();
            this.chkApSouth1 = new System.Windows.Forms.CheckBox();
            this.chkCaCentral1 = new System.Windows.Forms.CheckBox();
            this.chkApSouthEast1 = new System.Windows.Forms.CheckBox();
            this.chkApSouthEast2 = new System.Windows.Forms.CheckBox();
            this.chkApNorthEast1 = new System.Windows.Forms.CheckBox();
            this.chkSaEast1 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // chkEuWest1
            // 
            this.chkEuWest1.AutoSize = true;
            this.chkEuWest1.Location = new System.Drawing.Point(3, 0);
            this.chkEuWest1.Name = "chkEuWest1";
            this.chkEuWest1.Size = new System.Drawing.Size(72, 17);
            this.chkEuWest1.TabIndex = 17;
            this.chkEuWest1.Text = "eu-west-1";
            this.chkEuWest1.UseVisualStyleBackColor = true;
            // 
            // chkEuWest2
            // 
            this.chkEuWest2.AutoSize = true;
            this.chkEuWest2.Location = new System.Drawing.Point(3, 23);
            this.chkEuWest2.Name = "chkEuWest2";
            this.chkEuWest2.Size = new System.Drawing.Size(72, 17);
            this.chkEuWest2.TabIndex = 19;
            this.chkEuWest2.Text = "eu-west-2";
            this.chkEuWest2.UseVisualStyleBackColor = true;
            // 
            // chkEuCentral1
            // 
            this.chkEuCentral1.AutoSize = true;
            this.chkEuCentral1.Location = new System.Drawing.Point(3, 46);
            this.chkEuCentral1.Name = "chkEuCentral1";
            this.chkEuCentral1.Size = new System.Drawing.Size(82, 17);
            this.chkEuCentral1.TabIndex = 20;
            this.chkEuCentral1.Text = "eu-central-1";
            this.chkEuCentral1.UseVisualStyleBackColor = true;
            // 
            // chkUsWest1
            // 
            this.chkUsWest1.AutoSize = true;
            this.chkUsWest1.Location = new System.Drawing.Point(3, 69);
            this.chkUsWest1.Name = "chkUsWest1";
            this.chkUsWest1.Size = new System.Drawing.Size(71, 17);
            this.chkUsWest1.TabIndex = 21;
            this.chkUsWest1.Text = "us-west-1";
            this.chkUsWest1.UseVisualStyleBackColor = true;
            // 
            // chkUsWest2
            // 
            this.chkUsWest2.AutoSize = true;
            this.chkUsWest2.Location = new System.Drawing.Point(3, 92);
            this.chkUsWest2.Name = "chkUsWest2";
            this.chkUsWest2.Size = new System.Drawing.Size(71, 17);
            this.chkUsWest2.TabIndex = 22;
            this.chkUsWest2.Text = "us-west-2";
            this.chkUsWest2.UseVisualStyleBackColor = true;
            // 
            // chkUsEast1
            // 
            this.chkUsEast1.AutoSize = true;
            this.chkUsEast1.Location = new System.Drawing.Point(3, 115);
            this.chkUsEast1.Name = "chkUsEast1";
            this.chkUsEast1.Size = new System.Drawing.Size(69, 17);
            this.chkUsEast1.TabIndex = 23;
            this.chkUsEast1.Text = "us-east-1";
            this.chkUsEast1.UseVisualStyleBackColor = true;
            // 
            // chkUsEast2
            // 
            this.chkUsEast2.AutoSize = true;
            this.chkUsEast2.Location = new System.Drawing.Point(3, 138);
            this.chkUsEast2.Name = "chkUsEast2";
            this.chkUsEast2.Size = new System.Drawing.Size(69, 17);
            this.chkUsEast2.TabIndex = 24;
            this.chkUsEast2.Text = "us-east-2";
            this.chkUsEast2.UseVisualStyleBackColor = true;
            // 
            // chkApNorthEast2
            // 
            this.chkApNorthEast2.AutoSize = true;
            this.chkApNorthEast2.Location = new System.Drawing.Point(3, 231);
            this.chkApNorthEast2.Name = "chkApNorthEast2";
            this.chkApNorthEast2.Size = new System.Drawing.Size(94, 17);
            this.chkApNorthEast2.TabIndex = 25;
            this.chkApNorthEast2.Text = "ap-northeast-2";
            this.chkApNorthEast2.UseVisualStyleBackColor = true;
            // 
            // chkApSouth1
            // 
            this.chkApSouth1.AutoSize = true;
            this.chkApSouth1.Location = new System.Drawing.Point(3, 184);
            this.chkApSouth1.Name = "chkApSouth1";
            this.chkApSouth1.Size = new System.Drawing.Size(76, 17);
            this.chkApSouth1.TabIndex = 26;
            this.chkApSouth1.Text = "ap-south-1";
            this.chkApSouth1.UseVisualStyleBackColor = true;
            // 
            // chkCaCentral1
            // 
            this.chkCaCentral1.AutoSize = true;
            this.chkCaCentral1.Location = new System.Drawing.Point(3, 161);
            this.chkCaCentral1.Name = "chkCaCentral1";
            this.chkCaCentral1.Size = new System.Drawing.Size(82, 17);
            this.chkCaCentral1.TabIndex = 27;
            this.chkCaCentral1.Text = "ca-central-1";
            this.chkCaCentral1.UseVisualStyleBackColor = true;
            // 
            // chkApSouthEast1
            // 
            this.chkApSouthEast1.AutoSize = true;
            this.chkApSouthEast1.Location = new System.Drawing.Point(3, 254);
            this.chkApSouthEast1.Name = "chkApSouthEast1";
            this.chkApSouthEast1.Size = new System.Drawing.Size(96, 17);
            this.chkApSouthEast1.TabIndex = 28;
            this.chkApSouthEast1.Text = "ap-southeast-1\t";
            this.chkApSouthEast1.UseVisualStyleBackColor = true;
            // 
            // chkApSouthEast2
            // 
            this.chkApSouthEast2.AutoSize = true;
            this.chkApSouthEast2.Location = new System.Drawing.Point(3, 277);
            this.chkApSouthEast2.Name = "chkApSouthEast2";
            this.chkApSouthEast2.Size = new System.Drawing.Size(96, 17);
            this.chkApSouthEast2.TabIndex = 29;
            this.chkApSouthEast2.Text = "ap-southeast-2";
            this.chkApSouthEast2.UseVisualStyleBackColor = true;
            // 
            // chkApNorthEast1
            // 
            this.chkApNorthEast1.AutoSize = true;
            this.chkApNorthEast1.Location = new System.Drawing.Point(3, 207);
            this.chkApNorthEast1.Name = "chkApNorthEast1";
            this.chkApNorthEast1.Size = new System.Drawing.Size(94, 17);
            this.chkApNorthEast1.TabIndex = 30;
            this.chkApNorthEast1.Text = "ap-northeast-1";
            this.chkApNorthEast1.UseVisualStyleBackColor = true;
            // 
            // chkSaEast1
            // 
            this.chkSaEast1.AutoSize = true;
            this.chkSaEast1.Location = new System.Drawing.Point(3, 300);
            this.chkSaEast1.Name = "chkSaEast1";
            this.chkSaEast1.Size = new System.Drawing.Size(69, 17);
            this.chkSaEast1.TabIndex = 31;
            this.chkSaEast1.Text = "sa-east-1";
            this.chkSaEast1.UseVisualStyleBackColor = true;
            // 
            // AWSPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.chkSaEast1);
            this.Controls.Add(this.chkApNorthEast1);
            this.Controls.Add(this.chkApSouthEast2);
            this.Controls.Add(this.chkApSouthEast1);
            this.Controls.Add(this.chkCaCentral1);
            this.Controls.Add(this.chkApSouth1);
            this.Controls.Add(this.chkApNorthEast2);
            this.Controls.Add(this.chkUsEast2);
            this.Controls.Add(this.chkUsEast1);
            this.Controls.Add(this.chkUsWest2);
            this.Controls.Add(this.chkUsWest1);
            this.Controls.Add(this.chkEuCentral1);
            this.Controls.Add(this.chkEuWest1);
            this.Controls.Add(this.chkEuWest2);
            this.Name = "AWSPage";
            this.PageIcon = ((System.Drawing.Icon)(resources.GetObject("$this.PageIcon")));
            this.Size = new System.Drawing.Size(610, 489);
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		internal System.Windows.Forms.CheckBox chkEuWest1;
		internal System.Windows.Forms.CheckBox chkEuWest2;
        internal System.Windows.Forms.CheckBox chkEuCentral1;
        internal System.Windows.Forms.CheckBox chkUsWest1;
        internal System.Windows.Forms.CheckBox chkUsWest2;
        internal System.Windows.Forms.CheckBox chkUsEast1;
        internal System.Windows.Forms.CheckBox chkUsEast2;
        internal System.Windows.Forms.CheckBox chkApNorthEast2;
        internal System.Windows.Forms.CheckBox chkApSouth1;
        internal System.Windows.Forms.CheckBox chkCaCentral1;
        internal System.Windows.Forms.CheckBox chkApSouthEast1;
        internal System.Windows.Forms.CheckBox chkApSouthEast2;
        internal System.Windows.Forms.CheckBox chkApNorthEast1;
        internal System.Windows.Forms.CheckBox chkSaEast1;
    }
}
