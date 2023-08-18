
namespace PopNotesApplication
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
            notesListPanel = new System.Windows.Forms.FlowLayoutPanel();
            numMinutes = new System.Windows.Forms.NumericUpDown();
            numSeconds = new System.Windows.Forms.NumericUpDown();
            minText = new System.Windows.Forms.MaskedTextBox();
            secondsText = new System.Windows.Forms.MaskedTextBox();
            addNoteButton = new System.Windows.Forms.Button();
            textBox1 = new System.Windows.Forms.TextBox();
            notiButton = new System.Windows.Forms.Button();
            stopButton = new System.Windows.Forms.Button();
            saveNotesButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)numMinutes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numSeconds).BeginInit();
            SuspendLayout();
            // 
            // notesListPanel
            // 
            notesListPanel.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom;
            notesListPanel.AutoScroll = true;
            notesListPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            notesListPanel.Location = new System.Drawing.Point(12, 33);
            notesListPanel.Name = "notesListPanel";
            notesListPanel.Size = new System.Drawing.Size(256, 405);
            notesListPanel.TabIndex = 12;
            notesListPanel.WrapContents = false;
            notesListPanel.Paint += notesListPanel_Paint;
            // 
            // numMinutes
            // 
            numMinutes.Location = new System.Drawing.Point(389, 34);
            numMinutes.Name = "numMinutes";
            numMinutes.Size = new System.Drawing.Size(120, 23);
            numMinutes.TabIndex = 3;
            // 
            // numSeconds
            // 
            numSeconds.Location = new System.Drawing.Point(389, 61);
            numSeconds.Name = "numSeconds";
            numSeconds.Size = new System.Drawing.Size(120, 23);
            numSeconds.TabIndex = 4;
            // 
            // minText
            // 
            minText.Location = new System.Drawing.Point(515, 32);
            minText.Name = "minText";
            minText.ReadOnly = true;
            minText.Size = new System.Drawing.Size(52, 23);
            minText.TabIndex = 5;
            minText.Text = "Minutes";
            // 
            // secondsText
            // 
            secondsText.Location = new System.Drawing.Point(515, 63);
            secondsText.Name = "secondsText";
            secondsText.ReadOnly = true;
            secondsText.Size = new System.Drawing.Size(52, 23);
            secondsText.TabIndex = 6;
            secondsText.Text = "Seconds";
            // 
            // addNoteButton
            // 
            addNoteButton.Location = new System.Drawing.Point(274, 34);
            addNoteButton.Name = "addNoteButton";
            addNoteButton.Size = new System.Drawing.Size(109, 23);
            addNoteButton.TabIndex = 7;
            addNoteButton.Text = "Add Note";
            addNoteButton.UseVisualStyleBackColor = true;
            addNoteButton.Click += addNoteButton_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new System.Drawing.Point(12, 3);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new System.Drawing.Size(45, 23);
            textBox1.TabIndex = 9;
            textBox1.Text = "Notes:";
            textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // notiButton
            // 
            notiButton.Location = new System.Drawing.Point(389, 90);
            notiButton.Name = "notiButton";
            notiButton.Size = new System.Drawing.Size(109, 23);
            notiButton.TabIndex = 2;
            notiButton.Text = "Start";
            notiButton.UseVisualStyleBackColor = true;
            notiButton.Click += notiButton_Click;
            // 
            // stopButton
            // 
            stopButton.Location = new System.Drawing.Point(389, 119);
            stopButton.Name = "stopButton";
            stopButton.Size = new System.Drawing.Size(109, 23);
            stopButton.TabIndex = 10;
            stopButton.Text = "Stop";
            stopButton.UseVisualStyleBackColor = true;
            stopButton.Click += stopButton_Click;
            // 
            // saveNotesButton
            // 
            saveNotesButton.Location = new System.Drawing.Point(274, 61);
            saveNotesButton.Name = "saveNotesButton";
            saveNotesButton.Size = new System.Drawing.Size(109, 23);
            saveNotesButton.TabIndex = 11;
            saveNotesButton.Text = "Save Notes";
            saveNotesButton.UseVisualStyleBackColor = true;
            saveNotesButton.Click += saveNotesButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(579, 450);
            Controls.Add(notesListPanel);
            Controls.Add(saveNotesButton);
            Controls.Add(stopButton);
            Controls.Add(textBox1);
            Controls.Add(addNoteButton);
            Controls.Add(secondsText);
            Controls.Add(minText);
            Controls.Add(numSeconds);
            Controls.Add(numMinutes);
            Controls.Add(notiButton);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            Text = "PopNotes";
            TopMost = true;
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)numMinutes).EndInit();
            ((System.ComponentModel.ISupportInitialize)numSeconds).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.NumericUpDown numMinutes;
        private System.Windows.Forms.NumericUpDown numSeconds;
        private System.Windows.Forms.MaskedTextBox minText;
        private System.Windows.Forms.MaskedTextBox secondsText;
        private System.Windows.Forms.Button addNoteButton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button notiButton;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.Button saveNotesButton;
        private System.Windows.Forms.FlowLayoutPanel notesListPanel;
    }
}

