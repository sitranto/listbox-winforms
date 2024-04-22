
namespace listboxes
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            ListBoxLeft = new System.Windows.Forms.ListBox();
            ListBoxRight = new System.Windows.Forms.ListBox();
            ToRight = new System.Windows.Forms.Button();
            ToRightAll = new System.Windows.Forms.Button();
            ToLeftAll = new System.Windows.Forms.Button();
            ToLeft = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // ListBoxLeft
            // 
            ListBoxLeft.AllowDrop = true;
            ListBoxLeft.FormattingEnabled = true;
            ListBoxLeft.Location = new System.Drawing.Point(40, 19);
            ListBoxLeft.Name = "ListBoxLeft";
            ListBoxLeft.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            ListBoxLeft.Size = new System.Drawing.Size(178, 173);
            ListBoxLeft.TabIndex = 0;
            ListBoxLeft.DragDrop += ListBoxLeft_DragDrop;
            ListBoxLeft.DragEnter += ListBoxLeft_DragEnter;
            ListBoxLeft.MouseDown += ListBoxLeft_MouseDown;
            ListBoxLeft.MouseEnter += ListBoxLeft_MouseEnter;
            // 
            // ListBoxRight
            // 
            ListBoxRight.AllowDrop = true;
            ListBoxRight.FormattingEnabled = true;
            ListBoxRight.Location = new System.Drawing.Point(346, 19);
            ListBoxRight.Name = "ListBoxRight";
            ListBoxRight.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            ListBoxRight.Size = new System.Drawing.Size(178, 173);
            ListBoxRight.TabIndex = 1;
            ListBoxRight.DragDrop += ListBoxLeft_DragDrop;
            ListBoxRight.DragEnter += ListBoxLeft_DragEnter;
            ListBoxRight.MouseDown += ListBoxLeft_MouseDown;
            ListBoxRight.MouseEnter += ListBoxRight_MouseEnter;
            // 
            // ToRight
            // 
            ToRight.Enabled = false;
            ToRight.Location = new System.Drawing.Point(247, 36);
            ToRight.Name = "ToRight";
            ToRight.Size = new System.Drawing.Size(75, 20);
            ToRight.TabIndex = 2;
            ToRight.Text = ">";
            ToRight.UseVisualStyleBackColor = true;
            ToRight.Click += ToRight_Click;
            // 
            // ToRightAll
            // 
            ToRightAll.Location = new System.Drawing.Point(247, 75);
            ToRightAll.Name = "ToRightAll";
            ToRightAll.Size = new System.Drawing.Size(75, 20);
            ToRightAll.TabIndex = 3;
            ToRightAll.Text = ">>";
            ToRightAll.UseVisualStyleBackColor = true;
            ToRightAll.Click += ToRightAll_Click;
            // 
            // ToLeftAll
            // 
            ToLeftAll.Enabled = false;
            ToLeftAll.Location = new System.Drawing.Point(247, 115);
            ToLeftAll.Name = "ToLeftAll";
            ToLeftAll.Size = new System.Drawing.Size(75, 20);
            ToLeftAll.TabIndex = 4;
            ToLeftAll.Text = "<<";
            ToLeftAll.UseVisualStyleBackColor = true;
            ToLeftAll.Click += ToLeftAll_Click;
            // 
            // ToLeft
            // 
            ToLeft.Enabled = false;
            ToLeft.Location = new System.Drawing.Point(247, 154);
            ToLeft.Name = "ToLeft";
            ToLeft.Size = new System.Drawing.Size(75, 20);
            ToLeft.TabIndex = 5;
            ToLeft.Text = "<";
            ToLeft.UseVisualStyleBackColor = true;
            ToLeft.Click += ToLeft_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(550, 214);
            Controls.Add(ToLeft);
            Controls.Add(ToLeftAll);
            Controls.Add(ToRightAll);
            Controls.Add(ToRight);
            Controls.Add(ListBoxRight);
            Controls.Add(ListBoxLeft);
            Name = "Form1";
            Text = "howto_ove_between_listboxes";
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.ListBox ListBoxLeft;
        private System.Windows.Forms.ListBox ListBoxRight;
        private System.Windows.Forms.Button ToRight;
        private System.Windows.Forms.Button ToRightAll;
        private System.Windows.Forms.Button ToLeftAll;
        private System.Windows.Forms.Button ToLeft;
    }
}

