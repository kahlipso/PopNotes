
namespace PopNotesApplication
{
    partial class Note
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.title = new System.Windows.Forms.TextBox();
            this.body = new System.Windows.Forms.RichTextBox();
            this.deleteNoteButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.Location = new System.Drawing.Point(3, 3);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(166, 23);
            this.title.TabIndex = 9;
            this.title.Text = "Title";
            this.title.TextChanged += new System.EventHandler(this.title_TextChanged);
            // 
            // body
            // 
            this.body.Location = new System.Drawing.Point(3, 32);
            this.body.Name = "body";
            this.body.Size = new System.Drawing.Size(200, 73);
            this.body.TabIndex = 11;
            this.body.Text = "Body";
            // 
            // deleteNoteButton
            // 
            this.deleteNoteButton.Location = new System.Drawing.Point(175, 3);
            this.deleteNoteButton.Name = "deleteNoteButton";
            this.deleteNoteButton.Size = new System.Drawing.Size(28, 23);
            this.deleteNoteButton.TabIndex = 12;
            this.deleteNoteButton.Text = "X";
            this.deleteNoteButton.UseVisualStyleBackColor = true;
            this.deleteNoteButton.Click += new System.EventHandler(this.deleteNoteButton_Click);
            // 
            // Note
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.deleteNoteButton);
            this.Controls.Add(this.body);
            this.Controls.Add(this.title);
            this.Name = "Note";
            this.Size = new System.Drawing.Size(208, 109);
            this.Load += new System.EventHandler(this.Note_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox title;
        public System.Windows.Forms.RichTextBox body;
        private System.Windows.Forms.Button deleteNoteButton;
    }
}
