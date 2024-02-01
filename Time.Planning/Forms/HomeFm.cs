using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Time.Planning.Objects;
using Time.Planning.Services;

namespace Time.Planning.Forms
{
    public partial class HomeFm : Form
    {
        private readonly ChickRepository _repo;
        private bool IsTimeOn = false;
        private Chick chick;
        public HomeFm(ChickRepository repo)
        {
            _repo = repo;
            InitializeComponent();
            FillBox();
        }

        private void FillBox()
        {
            ChicksDataGrid.DataSource = _repo.GetAllChick();
        }
        private void ClearBoxes()
        {
            TaskNameBox.Text = string.Empty;
        }
        // done
        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void StsrtBtn_Click(object sender, EventArgs e)
        {
            if (TaskNameBox.Text.Replace(" ", "") == "")
            {
                var message = "Title is empty";
                MessageBox.Show(message);
            }
            else if (IsTimeOn == true)
            {
                var message = "Now On Chick is running...";
                MessageBox.Show(message);
            }
            else
            {
                chick = new Chick()
                {
                    Title = TaskNameBox.Text.ToString().ToLower(),
                    StartTime = DateTime.Now,
                };

                IsTimeOn = true;
            }
        }
        private void EndTaskBtn_Click(object sender, EventArgs e)
        {
            if (IsTimeOn == false)
            {
                var message = "no chick has started...";
                MessageBox.Show(message);
            }

            chick.EndTime = DateTime.Now;
            chick.CalculateTime();

            // create new obj for next task
            IsTimeOn = false;

            ScoreBoard.Text = TaskNameBox.Text + " : " + chick.Length.Hours.ToString() + "." + chick.Length.Minutes.ToString()
                + "." + chick.Length.Seconds.ToString();

            // then save last task 
            _repo.SaveChick(chick);
            
            ClearBoxes();

            FillBox();
        }
    }
}
