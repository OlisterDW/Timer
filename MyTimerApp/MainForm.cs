﻿using System;
using System.Drawing;
using System.Windows.Forms;

namespace MyTimerApp
{
    public partial class MainForm : Form
    {
        private Timer timer = new Timer();
        private DateTime dateTime = new DateTime(0, 0);
        public static string textFilePath = "usersResults.json";
        public MainForm()
        {
            InitializeComponent();
            timer.Interval = 1000;
            timer.Tick += Timer_Tick;
            ContextMenuStrip = contextMenuStrip1;

            this.BackColor = Color.FromArgb(69, 71, 92);
            timerLabel.ForeColor = Color.White;
            startPauseButton.ForeColor = Color.White;
            clearButton.ForeColor = Color.White;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            dateTime = dateTime.AddSeconds(1);
            timerLabel.Text = dateTime.ToString("T");
        }

        private void StartPauseButton_Click(object sender, EventArgs e)
        {
            if (timer.Enabled)
            {
                Stop();
            }
            else
            {
                Start();
            }
        }

        private void Stop()
        {
            timer.Stop();
        }

        private void Start()
        {
            timer.Start();
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            timer.Stop();
            dateTime = new DateTime(0, 0);
            timerLabel.Text = dateTime.ToString("T");
        }

        private void AddMinutesMenuItem_Click(object sender, EventArgs e)
        {
            InputForm inputForm = new InputForm();
            inputForm.ShowDialog();
            if (inputForm.date != null)
            {
                int hours = int.Parse(inputForm.date[0]);
                int minutes = int.Parse(inputForm.date[1]);
                int seconds = int.Parse(inputForm.date[2]);
                dateTime = dateTime.AddHours(hours);
                dateTime = dateTime.AddMinutes(minutes);
                dateTime= dateTime.AddSeconds(seconds);
                timerLabel.Text = dateTime.ToString("T");
            }
        }

        private void PreviousResultsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ResultsForm resultsForm = new ResultsForm();
            resultsForm.ShowDialog();
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void SaveTimeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveTime();
        }

        private void SaveTime()
        {
            DateTime currentTime = DateTime.Now;
            string currentTimeString = currentTime.ToString("F");
            string resultTimeString = dateTime.ToString("T");
            Result result = new Result(resultTimeString, currentTimeString);
            ResultsStorage.Append(result);
        }

    }
}
