using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
using System.IO;

namespace Project
{
    public partial class Form1 : Form
    {
        CustomList<string> Predictions = new CustomList<string>();
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            var src = DateTime.Now;
            var hm = new DateTime(src.Year, src.Month, src.Day, src.Hour, src.Minute, 0);
            TextDate.Text = "Днес е: " + hm.Day + "." + hm.Month + "." + hm.Year + "г.";

            GetPrediction(true);
        }

        public string GetPrediction(bool IsFirstTime) 
        {
            Random GenerateNumber = new Random();
            int Count = -1;

            if (IsFirstTime) //Ако FirstTime е true както е зададено на 30-ти ред (при стартиране на програмата) се създава списък от класа CustomList, към който се присвояват всички предсказания от тесктовия файл.
            {
                StreamReader Reader = new StreamReader("main.txt");
                using (Reader)
                {
                    int LineNumber = 1;
                    string CurrentLine = Reader.ReadLine();

                    while (CurrentLine != null)
                    {
                        Predictions.Add(CurrentLine);
                        LineNumber++;
                        CurrentLine = Reader.ReadLine();
                    }

                    return "";
                }
            }
            else //Генериране на предсказание
            {
                if (Predictions.Count - 1 >= 0)
                {
                    Count = Predictions.Count;
                }
                else
                {
                    Count = 0;
                }
                int RandomPrediction = GenerateNumber.Next(Count);
                string Prediction = Predictions.GetElementAtIndex(RandomPrediction);
                Predictions.RemoveAt(RandomPrediction);

                Count--;
                int SecondRandomPrediction = GenerateNumber.Next(Count);
                string SecondPrediction = Predictions.GetElementAtIndex(SecondRandomPrediction);
                Predictions.RemoveAt(SecondRandomPrediction);

                return Prediction + " " + SecondPrediction;
            }
        }

        public void CheckedButton()
        {
            MainTextBox.ScrollBars = ScrollBars.Vertical;
            if (ButtonOven.Checked)
            {
                ButtonOven.Enabled = false;
                ButtonOven.Checked = false;
                MainText.Text = "Дневен хороскоп за Овен";
                ZodiacSignPic.Image = global::Project.Properties.Resources.oven_znak;
                string Prediction = GetPrediction(false);
                MainTextBox.Text = Prediction;
            }
            else if (ButtonTelets.Checked)
            {
                ButtonTelets.Enabled = false;
                ButtonTelets.Checked = false;
                MainText.Text = "Дневен хороскоп за Телец";
                ZodiacSignPic.Image = global::Project.Properties.Resources.telets;
                string Prediction = GetPrediction(false);
                MainTextBox.Text = Prediction;
            }
            else if (ButtonBliznatsi.Checked)
            {
                ButtonBliznatsi.Enabled = false;
                ButtonBliznatsi.Checked = false;
                MainText.Text = "Дневен хороскоп за Близнаци";
                ZodiacSignPic.Image = global::Project.Properties.Resources.bliznatsi;
                string Prediction = GetPrediction(false);
                MainTextBox.Text = Prediction;
            }
            else if (ButtonRak.Checked)
            {
                ButtonRak.Enabled = false;
                ButtonRak.Checked = false;
                MainText.Text = "Дневен хороскоп за Рак";
                ZodiacSignPic.Image = global::Project.Properties.Resources.rak;
                string Prediction = GetPrediction(false);
                MainTextBox.Text = Prediction;
            }
            else if (ButtonLuv.Checked)
            {
                ButtonLuv.Enabled = false;
                ButtonLuv.Checked = false;
                MainText.Text = "Дневен хороскоп за Лъв";
                ZodiacSignPic.Image = global::Project.Properties.Resources.luv;
                string Prediction = GetPrediction(false);
                MainTextBox.Text = Prediction;
            }
            else if (ButtonDeva.Checked)
            {
                ButtonDeva.Enabled = false;
                ButtonDeva.Checked = false;
                MainText.Text = "Дневен хороскоп за Дева";
                ZodiacSignPic.Image = global::Project.Properties.Resources.deva;
                string Prediction = GetPrediction(false);
                MainTextBox.Text = Prediction;
            }
            else if (ButtonVezni.Checked)
            {
                ButtonVezni.Enabled = false;
                ButtonVezni.Checked = false;
                MainText.Text = "Дневен хороскоп за Везни";
                ZodiacSignPic.Image = global::Project.Properties.Resources.vezni;
                string Prediction = GetPrediction(false);
                MainTextBox.Text = Prediction;
            }
            else if (ButtonScorpion.Checked)
            {
                ButtonScorpion.Enabled = false;
                ButtonScorpion.Checked = false;
                MainText.Text = "Дневен хороскоп за Скорпион";
                ZodiacSignPic.Image = global::Project.Properties.Resources.skorpion;
                string Prediction = GetPrediction(false);
                MainTextBox.Text = Prediction;
            }
            else if (ButtonStrelets.Checked)
            {
                ButtonStrelets.Enabled = false;
                ButtonStrelets.Checked = false;
                MainText.Text = "Дневен хороскоп за Стрелец";
                ZodiacSignPic.Image = global::Project.Properties.Resources.strelets;
                string Prediction = GetPrediction(false);
                MainTextBox.Text = Prediction;
            }
            else if (ButtonKozirog.Checked)
            {
                ButtonKozirog.Enabled = false;
                ButtonKozirog.Checked = false;
                MainText.Text = "Дневен хороскоп за Козирог";
                ZodiacSignPic.Image = global::Project.Properties.Resources.kozirog;
                string Prediction = GetPrediction(false);
                MainTextBox.Text = Prediction;
            }
            else if (ButtonVodolei.Checked)
            {
                ButtonVodolei.Enabled = false;
                ButtonVodolei.Checked = false;
                MainText.Text = "Дневен хороскоп за Водолей";
                ZodiacSignPic.Image = global::Project.Properties.Resources.vodolei;
                string Prediction = GetPrediction(false);
                MainTextBox.Text = Prediction;
            }
            else if (ButtonRibi.Checked)
            {
                ButtonRibi.Enabled = false;
                ButtonRibi.Checked = false;
                MainText.Text = "Дневен хороскоп за Риби";
                ZodiacSignPic.Image = global::Project.Properties.Resources.ribi;
                string Prediction = GetPrediction(false);
                MainTextBox.Text = Prediction;
            }
            else
            {
                MessageBox.Show("Моля изберете една от зодиите!", "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ButtonShow_Click(object sender, EventArgs e)
        {
            CheckedButton();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 SecondForm = new Form2(this);
            SecondForm.Show();
        }

        public void AddPredictionToList(string PredictionToAdd) 
        { 
            Predictions.Add(PredictionToAdd);
        }
    }
}