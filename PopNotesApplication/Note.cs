using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PopNotesApplication
{
    public partial class Note : UserControl
    {
        public Note()
        {
            InitializeComponent();
        }

        private void Note_Load(object sender, EventArgs e)
        {

        }

        private void title_TextChanged(object sender, EventArgs e)
        {

        }
        Form1 form;
        private void deleteNoteButton_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Remove(this);
            //form.nextNoteLocation.Y -= form.note.Height + 10;
        }
    }
}
