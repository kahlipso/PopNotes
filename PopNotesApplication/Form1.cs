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
    public partial class Form1 : Form
    {
        private List<Tuple<DateTime, string>> reminders = new List<Tuple<DateTime, string>>();


        private string jsonFilePath = "reminders.json";


        public Form1()
        {
            InitializeComponent();


            // Set up the Numeric Up Down control for minutes
            numMinutes.Minimum = 0;
            numMinutes.Maximum = 59;

            // Set up the Numeric Up Down control for seconds
            numSeconds.Minimum = 0;
            numSeconds.Maximum = 59;

            // Load the reminders from the JSON file
            LoadRemindersFromJsonFile();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveRemindersToJsonFile();
        }

        private void notiButton_Click(object sender, EventArgs e)
        {
            notiButton.Text = "RUNNING";
            timerStop = false;
            // Retrieve the number of minutes until the reminder from the NumericUpDown control
            int minutes = (int)numMinutes.Value;
            int seconds = (int)numSeconds.Value;

            // Get the time difference
            TimeSpan timeDifference = TimeSpan.FromMinutes((double)numMinutes.Value) + TimeSpan.FromSeconds((double)numSeconds.Value);

            // Set up a timer to check for the reminder time
            Timer reminderTimer = new Timer();

            // Check if the time difference is greater than zero
            if (timeDifference.TotalMilliseconds > 0)
            {
                // Calculate the reminder time
                DateTime reminderTime = DateTime.Now.Add(timeDifference);

                // Set the timer interval
                reminderTimer.Interval = (int)timeDifference.TotalMilliseconds;

                reminderTimer.Tick += ReminderTimer_Tick;

                // Start the timer
                if (!timerStop)
                {
                    reminderTimer.Start();
                }


            }
            else
            {

                MessageBox.Show(new Form { TopMost = true }, "Please enter a value greater than zero.", "Invalid Input");
            }
        }

        private void ReminderTimer_Tick(object sender, EventArgs e)
        {
            // Select a random note from the panelNotes.Controls collection
            Random random = new Random();
            int index = random.Next(notesListPanel.Controls.Count);
            Note selectedNote = (Note)notesListPanel.Controls[index];

            // Stop the timer
            Timer reminderTimer = (Timer)sender;
            reminderTimer.Stop();
            if (timerStop)
            {
                reminderTimer.Stop();
            }

            // Show the reminder message box
            if (!timerStop)
            {
                var messageBox = MessageBox.Show(selectedNote.title.Text + "\n\n" + selectedNote.body.Text, "Reminder", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
            }

            // Set up the timer for the next reminder
            TimeSpan timeDifference = TimeSpan.FromMinutes((double)numMinutes.Value) + TimeSpan.FromSeconds((double)numSeconds.Value);
            reminderTimer.Interval = (int)timeDifference.TotalMilliseconds;
            if (!timerStop)
            {
                reminderTimer.Start();
            }



        }
        public bool timerStop;
        private void stopButton_Click(object sender, EventArgs e)
        {
            timerStop = true;
            notiButton.Text = "Start";
        }
        public Point nextNoteLocation = new Point(0, 10);
        public Note note;
        public Note currentNote;
        private void addNoteButton_Click(object sender, EventArgs e)
        {
            note = new Note();
            currentNote = note;
            note.Location = nextNoteLocation;
            notesListPanel.Controls.Add(note);
            //nextNoteLocation.Y += note.Height + 10;

        }

        List<NoteData> notes = new List<NoteData>();
        private void SaveRemindersToJsonFile()
        {

            foreach (Note noteControl in notesListPanel.Controls.OfType<Note>())
            {
                NoteData note = new NoteData()
                {
                    Title = noteControl.title.Text,
                    Body = noteControl.body.Text,
                    Location = noteControl.Location

                };
                notes.Add(note);
            }

            // Serialize the list to JSON and write it to a file
            string json = JsonConvert.SerializeObject(notes);

            File.WriteAllText("reminders.json", json);
        }

        private void saveNotesButton_Click(object sender, EventArgs e)
        {
            //reminders.Add(new Tuple<DateTime, string>(DateTime.Now, note.title.Text + "\n\n" + note.body.Text));

            SaveRemindersToJsonFile();
        }

        private void LoadRemindersFromJsonFile()
        {
            // Check if the JSON file exists
            if (File.Exists(jsonFilePath))
            {
                // Read the JSON data from the file
                string json = File.ReadAllText(jsonFilePath);

                // Deserialize the JSON data to a list of NoteData objects
                List<NoteData> noteDataList = JsonConvert.DeserializeObject<List<NoteData>>(json);

                // Loop through the NoteData objects and create new Note user controls with their data
                foreach (NoteData noteData in noteDataList)
                {
                    //Note addedNote = new Note();
                    note = new Note();
                    note.title.Text = noteData.Title;
                    note.body.Text = noteData.Body;
                    note.Location = noteData.Location;
                    notesListPanel.Controls.Add(note);
                }


            }
        }

        void autoSaveNotes_Tick(object sender, EventArgs e)
        {
            Timer saveTimer = (Timer)sender;
        }

        private void notesListPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
