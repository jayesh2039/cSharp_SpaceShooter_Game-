using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace SpaceShooter
{
    public partial class Form1 : Form
    {
        WindowsMediaPlayer gameMedia;
        WindowsMediaPlayer shootgMedia;
        WindowsMediaPlayer explosion;

        PictureBox[] enemiesMuition;
        int enemiesMuitionspeed;

        PictureBox[] stars;
        int PlayerSpeed;
        
        PictureBox[] Munitions;
        int Multispeed;

        PictureBox[] enemies;
        int enemiespeed;

        int backgroundspeed;
        Random rnd;

        int score;
        int level;
        int dificulty;
        bool pause;
        bool gameisover;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pause = false;
            gameisover = false;
            score = 0;
            level = 1;
            dificulty = 9;


            backgroundspeed = 8;
            PlayerSpeed = 4;
            enemiespeed = 4;
            Multispeed = 50;
            enemiesMuitionspeed = 10;
            Munitions = new PictureBox[3];

            //Load image
            Image munition = Image.FromFile(@"asserts\munition.png");

            Image enemi1 = Image.FromFile("asserts\\E1.png");
            Image enemi2 = Image.FromFile("asserts\\E2.png");
            Image enemi3 = Image.FromFile("asserts\\E3.png");
            Image boss1 = Image.FromFile("asserts\\Boss1.png");
            Image boss2 = Image.FromFile("asserts\\Boss2.png");

            enemies = new PictureBox[10];

            //Initialiase enemispictureBoxes
            for (int i = 0; i < enemies.Length; i++)
            {
                enemies[i] = new PictureBox();
                enemies[i].Size = new Size(40, 40);
                enemies[i].SizeMode = PictureBoxSizeMode.Zoom;
                enemies[i].BorderStyle = BorderStyle.None;
                enemies[i].Visible = false;
                this.Controls.Add(enemies[i]);
                enemies[i].Location = new Point((i + 1) * 50, -50);
            }
            enemies[0].Image = boss1;
            enemies[1].Image = enemi2;
            enemies[2].Image = enemi3;
            enemies[3].Image = enemi3;
            enemies[4].Image = enemi1;
            enemies[5].Image = enemi3;
            enemies[6].Image = enemi2;
            enemies[7].Image = enemi3;
            enemies[8].Image = enemi2;
            enemies[9].Image = boss2;

            //Load Image
            for (int i = 0; i < Munitions.Length; i++)
            {
                Munitions[i] = new PictureBox();
                Munitions[i].Size = new Size(8, 8);
                Munitions[i].Image = munition;
                Munitions[i].SizeMode = PictureBoxSizeMode.Zoom;
                Munitions[i].BorderStyle = BorderStyle.None;
                this.Controls.Add(Munitions[i]);

            }
            //Create
            gameMedia = new WindowsMediaPlayer();
            shootgMedia = new WindowsMediaPlayer();
            explosion = new WindowsMediaPlayer();

            //Load song
            gameMedia.URL = "songs\\GameSong.mp3";
            shootgMedia.URL = "songs\\shoot.mp3";
            explosion.URL = "songs\\boom.mp3";

            //setup Songs settings
            gameMedia.settings.setMode("loop", true);
            gameMedia.settings.volume = 5;
            shootgMedia.settings.volume = 1;
            explosion.settings.volume = 6;


            stars = new PictureBox[15];
            rnd = new Random();

            //Enemis mution

            enemiesMuition = new PictureBox[10];
            for (int i = 0; i < enemiesMuition.Length; i++)
            {
                enemiesMuition[i] = new PictureBox();
                enemiesMuition[i].Size = new Size(2,25);
                enemiesMuition[i].Visible = false;
                enemiesMuition[i].BackColor = Color.Yellow;
                int x = rnd.Next(0, 10);
                enemiesMuition[i].Location = new Point(enemies[x].Location.X, enemies[x].Location.Y - 20);

                this.Controls.Add(enemiesMuition[i]);
                
            }
            for (int i = 0; i < stars.Length; i++)
            {
                gameMedia.controls.play();
            }

            for (int i = 0; i < stars.Length; i++)
            {
                stars[i] = new PictureBox();
                stars[i].BorderStyle = BorderStyle.None;
                stars[i].Location = new Point(rnd.Next(20, 580), rnd.Next(-10, 400));
                if (i % 2 == 1)
                {
                    stars[i].Size = new Size(2, 2);
                    stars[i].BackColor = Color.Wheat;
                }
                else
                {
                    stars[i].Size = new Size(3, 3);
                    stars[i].BackColor = Color.DarkGray;
                }
                this.Controls.Add(stars[i]);
            }
        }

        private void Movebgtimer_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < stars.Length/2; i++)
            {
                stars[i].Top += backgroundspeed;
                if (stars[i].Top >= this.Height)
                {
                    stars[i].Top = -stars[i].Height;
                }
            }
            for (int i = stars.Length / 2; i < stars.Length; i++)
            {
                stars[i].Top += backgroundspeed-2;
                if (stars[i].Top >= this.Height)
                {
                    stars[i].Top = -stars[i].Height;
                }
            }
        }

        private void LeftMoveTimer_Tick(object sender, EventArgs e)
        {
            if (Player.Left > 10)
            {
                Player.Left -= PlayerSpeed;
            }
        }

        private void RightMoveTimer_Tick(object sender, EventArgs e)
        {
            if (Player.Right < 580)
            {
                Player.Left += PlayerSpeed;
            }
        }

        private void DownMoveTimer_Tick(object sender, EventArgs e)
        {
            if (Player.Top < 400)
            {
                Player.Top += PlayerSpeed;
            }
        }

        private void UpMoveTimer_Tick(object sender, EventArgs e)
        {
            if (Player.Top > 10)
            {
                Player.Top -= 10;
            }

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (!pause)
            {
                if (e.KeyCode == Keys.Right)
                {
                    RightMoveTimer.Start();
                }
                if (e.KeyCode == Keys.Left)
                {
                    LeftMoveTimer.Start();
                }
                if (e.KeyCode == Keys.Down)
                {
                    DownMoveTimer.Start();
                }
                if (e.KeyCode == Keys.Up)
                {
                    UpMoveTimer.Start();
                }
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            RightMoveTimer.Stop();
            LeftMoveTimer.Stop();
            UpMoveTimer.Stop();
            DownMoveTimer.Stop();

            if (e.KeyCode == Keys.Space)
            {
                if (!gameisover)
                {
                    if (pause)
                    {
                        startTimer();
                        label1.Visible = false;
                        gameMedia.controls.play();
                        pause = false;
                    }
                    else
                    {
                        label1.Location = new Point(this.Width / 2 - 120, 150);
                        label1.Text = "Pause";
                        label1.Visible = true;
                        gameMedia.controls.play();
                        stopTimer();
                        pause = true;
                    }
                }
            }
        }

        private void MoveMuitionTimer_Tick(object sender, EventArgs e)
        {
            shootgMedia.controls.play();
            for (int i = 0; i <Munitions.Length; i++)
            {
                if (Munitions[i].Top > 0)
                {
                    Munitions[i].Visible = true;
                    Munitions[i].Top -= Multispeed;
                    collision();
                }
                else
                {
                    Munitions[i].Visible = false;
                    Munitions[i].Location = new Point(Player.Location.X + 20, Player.Location.Y - i * 30);
                }
                
            }
        }

        private void MoveEnemiesTimer_Tick(object sender, EventArgs e)
        {
            MoveEnemies(enemies, enemiespeed);
        }
        private void MoveEnemies(PictureBox[] array, int speed)
        {

            for (int i = 0; i < array.Length; i++)
            {
                array[i].Visible = true;
                array[i].Top += speed;
                if (array[i].Top > this.Height)
                {
                    array[i].Location = new Point((i + 1) * 50, -50);
                }
            }
        }

        private void collision()
        {
            for (int i = 0; i <enemies.Length; i++)
            {
                if (Munitions[0].Bounds.IntersectsWith(enemies[i].Bounds)
                    ||Munitions[1].Bounds.IntersectsWith(enemies[i].Bounds)
                    ||Munitions[2].Bounds.IntersectsWith(enemies[i].Bounds))
                {
                    explosion.controls.play();

                    score+=1;
                    
                    scorelable.Text = (score < 10) ? "0" + score.ToString() : score.ToString();

                    if (score % 30 == 0)
                    {
                        level +=1;
                        levellable.Text = level.ToString();// = (level < 10) ? "0" + level.ToString() : level.ToString();
                        if (enemiespeed <= 10 && enemiesMuitionspeed <= 10 && dificulty >= 0)
                        {
                            dificulty--;
                            enemiespeed++;
                            enemiesMuitionspeed++;
                        }
                        if (level == 10)
                        {
                            Gameover("Nice  Dne");
                        }
                    }

                    enemies[i].Location = new Point((i + 1) * 50, -100);
                }
                if (Player.Bounds.IntersectsWith(enemies[i].Bounds))
                {
                    explosion.settings.volume = 30;
                    explosion.controls.play();
                    Player.Visible = false;
                    Gameover("Game over");
                }
            }
        }

        private void Gameover(string str)
        {
            label1.Text = str;
            label1.Location = new Point(170, 80);
            label1.Visible = true;
            replaybtn.Visible = true;
            exitebtn.Visible = true;

            gameMedia.controls.stop();
            stopTimer();
        }

        //Strop Timers
        private void stopTimer()
        {
            Movebgtimer.Stop();
            MoveEnemiesTimer.Stop();
            MoveMuitionTimer.Stop();
            EnemiesMotionTimer.Stop();
        }
        //Start Timers
        private void startTimer()
        {
            Movebgtimer.Start();
            MoveEnemiesTimer.Start();
            MoveMuitionTimer.Start();
            EnemiesMotionTimer.Start();
       }

        private void EnemiesMotionTimer_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < enemiesMuition.Length-dificulty; i++)
            {
                if (enemiesMuition[i].Top < this.Height)
                {
                    enemiesMuition[i].Visible = true;
                    enemiesMuition[i].Top += enemiesMuitionspeed;
                    collisionwithenemiesmuition();
                }
                else
                {
                    enemiesMuition[i].Visible = false;
                    int x = rnd.Next(0, 10);
                    enemiesMuition[i].Location = new Point(enemies[x].Location.X+20, enemies[x].Location.Y - 30);
                }
            }
        }

        private void collisionwithenemiesmuition()
        {
            for (int i = 0; i < enemiesMuition.Length; i++)
            {
                if (enemiesMuition[i].Bounds.IntersectsWith(Player.Bounds))
                {
                    enemiesMuition[i].Visible = false;
                    explosion.settings.volume = 30;
                    explosion.controls.play();
                    Player.Visible = false;
                    Gameover("Gameover");
                }
            }
        }

        private void replaybtn_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            InitializeComponent();
            Form1_Load(e,e);

        }

        private void exitebtn_Click(object sender, EventArgs e)
        {
            Environment.Exit(1);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

    }
}
