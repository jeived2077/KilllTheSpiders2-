using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KilllTheSpiders
{
    public partial class KillTheSpiders : Form
    {
        Random rnd = new Random();
        int point;
        int timerstart = 0;
        int click;
        int end;


        public KillTheSpiders()
        {
            InitializeComponent();
            timer1.Interval = 1000;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {

        }

        private void pictureBox_Click(object sender, EventArgs e)
        {

        }
        private void Timer1_Tick(object sender, EventArgs e)
        {

        }

        private void Spider_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            click++;
            point = point + 5;
            spider1.Visible = false;
            ScoreNumber.Text = Convert.ToString(point);
            ScoreNumber.Update();
        }

        private void KillTheSpiders_Load(object sender, EventArgs e)
        {
            timer2.Start();

            timer1.Start();
            spider1.Location = new Point(rnd.Next(20, 800), rnd.Next(20, 450));

            spider2.Location = new Point(rnd.Next(20, 800), rnd.Next(20, 450));

            spider3.Location = new Point(rnd.Next(20, 800), rnd.Next(20, 450));

            spider4.Location = new Point(rnd.Next(20, 800), rnd.Next(20, 450));

            spider1.Visible = true;
            spider2.Visible = true;

            spider3.Visible = true;
            spider4.Visible = true;
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {

            timerstart++;


            if ((timerstart <= 10) && (click == 4)) {
                click = 0;
                spider1.Location = new Point(rnd.Next(20, 780), rnd.Next(20, 420));

                spider2.Location = new Point(rnd.Next(20, 780), rnd.Next(20, 420));

                spider3.Location = new Point(rnd.Next(20, 780), rnd.Next(20, 420));

                spider4.Location = new Point(rnd.Next(20, 780), rnd.Next(20, 420));

                spider1.Visible = true;
                spider2.Visible = true;
                spider3.Visible = true;
                spider4.Visible = true;
                timerstart = 0;


            }
            if ((click <= 4) && (timerstart == 10))
            {
                timer1.Stop();
                timer2.Stop();
                switch (DialogResult = MessageBox.Show("Вы проиграли" + "\nХотите попробовать снова?", "Игра окончена" ,MessageBoxButtons.YesNo))

                {
                    case DialogResult.Yes:
                        click = 0;
                        timerstart = 0;
                        end = 0;
                        timer2.Start();

                        timer1.Start();
                        point = 0;
                        ScoreNumber.Update();
                        spider1.Location = new Point(rnd.Next(20, 780), rnd.Next(20, 420));

                        spider2.Location = new Point(rnd.Next(20, 780), rnd.Next(20, 420));

                        spider3.Location = new Point(rnd.Next(20, 780), rnd.Next(20, 420));

                        spider4.Location = new Point(rnd.Next(20, 780), rnd.Next(20, 420));

                        spider1.Visible = true;
                        spider2.Visible = true;
                        spider3.Visible = true;
                        spider4.Visible = true;



                        break;
                    case DialogResult.No:
                        Application.Exit();


                        break;
                }

            }





        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            click++;
            point = point + 5;
            spider2.Visible = false;
            ScoreNumber.Text = Convert.ToString(point);
            ScoreNumber.Update();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            click++;
            point = point + 5;
            spider3.Visible = false;
            ScoreNumber.Text = Convert.ToString(point);
            ScoreNumber.Update();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            click++;
            point = point + 5;
            spider4.Visible = false;
            ScoreNumber.Text = Convert.ToString(point);
            ScoreNumber.Update();
        }

        private void KillTheSpiders_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Timer_Click(object sender, EventArgs e)
        {

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            end++;
            Timer.Text = end.ToString();

            if (end == 60)
            {
                timer1.Stop();
                timer2.Stop();
                switch (DialogResult = MessageBox.Show("Вы дошли до конца \nВаш счёт состовляет: " + point + "\n Нажмите ОК, чтобы начать игру сначала", "Конец игры", MessageBoxButtons.OKCancel))
                {
                    case DialogResult.OK:
                        click = 0;
                        timerstart = 0;
                        end = 0;
                        timer2.Start();

                        timer1.Start();
                        point = 0;
                        ScoreNumber.Update();
                        spider1.Location = new Point(rnd.Next(20, 780), rnd.Next(20, 420));

                        spider2.Location = new Point(rnd.Next(20, 780), rnd.Next(20, 420));

                        spider3.Location = new Point(rnd.Next(20, 780), rnd.Next(20, 420));

                        spider4.Location = new Point(rnd.Next(20, 780), rnd.Next(20, 420));

                        spider1.Visible = true;
                        spider2.Visible = true;
                        spider3.Visible = true;
                        spider4.Visible = true;



                        break;
                    case DialogResult.Cancel:
                        Application.Exit();


                        break;
                    
                }
            }
        }
    } 
}

