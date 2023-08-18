using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;


namespace PopNotesApplication
{
    //[Serializable]
    public class NoteData
    {
        public string Title { get; set; }
        public string Body { get; set; }
        public Point Location { get; set; }

       
    }


}
