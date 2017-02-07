using System;
using System.Windows.Forms;
using WindowsFormsApplication1;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Threading;
using System.Threading.Tasks;
namespace WindowsFormsApplication1
    
{

    public partial class Form1 : Form
    {
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            //capture up arrow key
            if (keyData == Keys.Down)
            {
                if (PlayerPicture.Top >= 180 || (PlayerPicture.Top + 30 == pictureBat.Top && PlayerPicture.Left == pictureBat.Left && pictureBat.Visible))
                {

                }
                else
                {
                    PlayerPicture.Top += 30;
                    PlayerPicture.Image = Properties.Resources.movementdown1;
                    AttackBat();
                }
                if (IsPickableSword(true) || IsPickablePotion(true))
                    ButtonPick.Visible = true;
                else
                    ButtonPick.Visible = false;
                MoveBat();
                lostgame();
                wingame();
                return true;
            }
            if (keyData == Keys.Up)
            {
                if (PlayerPicture.Top <= 55 || (PlayerPicture.Top - 30 == pictureBat.Top && PlayerPicture.Left == pictureBat.Left && pictureBat.Visible))
                {
                }
                else
                {
                    PlayerPicture.Top -= 30;
                    PlayerPicture.Image = Properties.Resources.movementup;
                    AttackBat();
                }
                if (IsPickableSword(true) || IsPickablePotion(true))
                    ButtonPick.Visible = true;
                else
                    ButtonPick.Visible = false;
                MoveBat();
                lostgame();
                wingame();
                return true;
            }
            if (keyData == Keys.Left)
            {
                 if (PlayerPicture.Left <= 85 || (PlayerPicture.Left - 30 == pictureBat.Left && PlayerPicture.Top == pictureBat.Top && pictureBat.Visible))
            {
            }
            else
            {
                PlayerPicture.Left -= 30;
                PlayerPicture.Image = Properties.Resources.movementleft;
                AttackBat();
            }
                if (IsPickableSword(true) || IsPickablePotion(true))
                    ButtonPick.Visible = true;
                else
                    ButtonPick.Visible = false;
            lostgame();
            Random rndRuch = new Random();
            MoveBat();
            lostgame();
            wingame();
                return true;
            }
            if (keyData == Keys.Right)
            {
                if (PlayerPicture.Left >= 480 || (PlayerPicture.Left + 30 == pictureBat.Left && PlayerPicture.Top == pictureBat.Top && pictureBat.Visible))
                {

                }
                else
                {
                    PlayerPicture.Left += 30;
                    PlayerPicture.Image = Properties.Resources.movementright;
                    AttackBat();
                }
                if (IsPickableSword(true) || IsPickablePotion(true))
                    ButtonPick.Visible = true;
                else
                    ButtonPick.Visible = false;
                lostgame();
                Random rndRuch = new Random();
                MoveBat();
                lostgame();
                wingame();
                return true;
            }
                return base.ProcessCmdKey(ref msg, keyData);
        }

        public int[] tabX = new int[12] { 105, 135, 165, 195, 225, 255, 285, 315, 345, 375, 405, 435 };
        public int[] tabY = new int[4] { 85, 115, 145, 175 };
        public int aX;
        public int aY;
        public int HPBat = 10;
        public int HpPlayer = 30;
        PictureBox pictureSword = new PictureBox();
        PictureBox pictureBat = new PictureBox();
        PictureBox picturePotion = new PictureBox();
        ProgressBar progressbatHP = new ProgressBar();
        ProgressBar progressBar1 = new ProgressBar();
        PictureBox pictureSwordeq = new PictureBox();
        PictureBox PlayerPicture = new PictureBox();

        public void Player()
        {

            Size size = new Size(30, 30);
            Size size1 = new Size(149, 408);
            this.Controls.Add(PlayerPicture);
            PlayerPicture.Image = Properties.Resources.movementdown1;
            PlayerPicture.SizeMode = PictureBoxSizeMode.StretchImage;
            PlayerPicture.Size = size;
            PlayerPicture.Visible = true;
            PlayerPicture.BackColor = Color.Transparent;
            PlayerPicture.Left = 75;
            PlayerPicture.Top = 55;


        }
        public void potion()
        {
            int[] tabX = new int[12] { 105, 135, 165, 195, 225, 255, 285, 315, 345, 375, 405, 435 };
            int[] tabY = new int[4] { 85, 115, 145, 175 };
            Random random = new Random();
            Size size = new Size(30, 30);
            this.Controls.Add(picturePotion);
            picturePotion.Image = Properties.Resources.potion;
            picturePotion.SizeMode = PictureBoxSizeMode.StretchImage;
            picturePotion.Size = size;
            picturePotion.Visible = false;
            picturePotion.BackColor = Color.Transparent;
            picturePotion.Left = pictureBat.Left;
            picturePotion.Top = pictureBat.Top;
        }
        public void Sword()
        {
            Random random = new Random();
            Size size = new Size(30, 30);
            Size size1 = new Size(35, 35);
            this.Controls.Add(pictureSword);
            pictureSword.Image = Properties.Resources.sword;
            pictureSword.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureSword.Size = size;
            pictureSword.Visible = true;
            pictureSword.BackColor = Color.Transparent;
            aX = random.Next(12);
            aY = random.Next(4);
            pictureSword.Left = tabX[aX];
            pictureSword.Top = tabY[aY];
            pictureSwordeq.Image = Properties.Resources.swordeq;
            pictureSwordeq.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureSwordeq.Size = size1;
            pictureSwordeq.Visible = false;
            pictureSwordeq.BackColor = Color.Transparent;
            this.Controls.Add(pictureSwordeq);
            pictureSwordeq.Left = 608;
            pictureSwordeq.Top = 90;
        }
        public void Bat()
        {

            Random random = new Random();
            this.Controls.Add(pictureBat);
            Size size = new Size(30, 30);
            pictureBat.Image = Properties.Resources.movementbat1;
            pictureBat.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBat.Size = size;
            pictureBat.BackColor = Color.Transparent;
            aX = random.Next(12);
            aY = random.Next(4);

            Task T = Task.Run(() =>
            {
                do
                {
                    pictureBat.Image = Properties.Resources.movementbat1;
                    Thread.Sleep(300);
                    pictureBat.Image = Properties.Resources.movementbat2;
                    Thread.Sleep(300);
                } while (pictureBat.Visible == false);

            });
            T.ContinueWith((t) =>
            {
                Bat();


            }, TaskScheduler.FromCurrentSynchronizationContext());

        }
        public bool IsPickableSword(bool pickable)
        {
            if ((PlayerPicture.Left == pictureSword.Left) && (PlayerPicture.Top == pictureSword.Top) && pictureSword.Visible)
                return true;
            return false;


        }
        public bool IsPickablePotion(bool pickable)
        {
            if ((PlayerPicture.Left == picturePotion.Left) && (PlayerPicture.Top == picturePotion.Top) && picturePotion.Visible)
                return true;
            return false;

        }
        public void lostgame()
        {
            if (HpPlayer <= 0)
            {
                MessageBox.Show("You Lost");
                Application.Exit();
            }
        }
        public void wingame()
        {
            if (!pictureBat.Visible && PlayerPicture.Left >= 440 && PlayerPicture.Top >= 115)
            {
                MessageBox.Show("You Win");
                Application.Exit();
            }
        }
        public void AttackBat()
        {
            if (Math.Abs(PlayerPicture.Left - pictureBat.Left) <= 30 && Math.Abs(PlayerPicture.Top - pictureBat.Top) <= 30 && pictureBat.Visible)
            {
                HpPlayer -= 1;
                progressBar1.Value -= 1;
            }

        }
        public void MoveBat()
        {

            if (pictureBat.Top >= 65 && pictureBat.Top <= 180 && pictureBat.Left >= 85 && pictureBat.Left <= 480)
            {

                if ((PlayerPicture.Left + 30 == pictureBat.Left && PlayerPicture.Top == pictureBat.Top))
                {
                    pictureBat.Left += 30;
                    AttackBat();
                }
                if ((PlayerPicture.Left - 30 == pictureBat.Left && PlayerPicture.Top == pictureBat.Top))
                {
                    pictureBat.Left -= 30;
                    AttackBat();
                }
                if ((PlayerPicture.Top + 30 == pictureBat.Top && PlayerPicture.Left == pictureBat.Left))
                {
                    pictureBat.Top += 30;
                    AttackBat();
                }
                else
                {
                    Random rndruch = new Random();
                    rndruch.Next(0, 3);
                    if (rndruch.Next(0, 3) == 0)
                    {
                        pictureBat.Top -= 30;
                        AttackBat();
                    }
                    if (rndruch.Next(0, 3) == 1)
                    { pictureBat.Top += 30;
                        AttackBat();
                    }
                    if (rndruch.Next(0, 3) == 2)
                    { pictureBat.Left += 30;
                        AttackBat();
                    }
                    if (rndruch.Next(0, 3) == 3)
                    {   pictureBat.Left -= 30;
                        AttackBat();
                    }

                }
            }
         
            if (pictureBat.Top <= 60)
            { pictureBat.Top += 30; }
            if (pictureBat.Top >= 160)
            { pictureBat.Top -= 30; }
            if (pictureBat.Left >= 460)
            { pictureBat.Left -= 30; }
            if (pictureBat.Left <= 90)
            { pictureBat.Left += 30; }
        } 

        public Form1()
        {


            pictureBat.Left = tabX[aX];
            pictureBat.Top = tabY[aY];
            pictureBat.BringToFront();
            progressbatHP.BringToFront();
            Player();
           Bat();
            Sword();
            progressBar1.Value = 30;
            InitializeComponent();
         

        }
      
        private void ButtonPick_Click(object sender, EventArgs e)
        {
            if ((PlayerPicture.Left == pictureSword.Left) && (PlayerPicture.Top == pictureSword.Top) && pictureSword.Visible)
            {
                pictureSword.Visible = false;
                pictureSwordeq.Visible = true;
                ButtonPick.Visible = false;
                pictureSword.Left = tabX[aX];
                pictureSwordeq.BringToFront();
            }
            if ((PlayerPicture.Left == picturePotion.Left) && (PlayerPicture.Top == picturePotion.Top))
            {
                picturePotion.Visible = false;
                picturePotionEQ.Visible = true;
                ButtonPick.Visible = false;
            }
        }

        private void buttonAttack_Click(object sender, EventArgs e)
        {
            if(buttonAttack.Text == "Drink")
            {
                HpPlayer = 30;
                progressBar1.Value = 30;
                picturePotionEQ.Visible = false;
                picturePotion.Visible = false;
                buttonAttack.Text = "Attack";

            }
            if (pictureSwordeq.Visible)
            {

                if (Math.Abs(PlayerPicture.Left - pictureBat.Left)<=30 && Math.Abs(PlayerPicture.Top- pictureBat.Top) <= 30)
                {
                    
                    
                    HPBat -= 3;

                    if (HPBat <= 0&& pictureBat.Visible)

                    {
                        label1.Visible = false;
                  
                        progressBarHp.Visible = false;
                        pictureBat.Visible = false;
                        potion();
                        picturePotion.Visible = true;
                    }
                    if(progressBarHp.Value<=3)
                    {
                        progressBarHp.Visible = false;
                    }
                    else
                    progressBarHp.Value -= 3;
                }
                if (HPBat <= 0 && pictureBat.Visible)

                {
                    label1.Visible = false;
                    progressBarHp.Visible = false;
                    pictureBat.Visible = false;
                    potion();
                    picturePotion.Visible = true;
                }

            }
            else
            {
                if (Math.Abs(PlayerPicture.Left - pictureBat.Left) <= 30 && Math.Abs(PlayerPicture.Top - pictureBat.Top) <= 30)
                {

                    HPBat -= 1;
                    if (progressBarHp.Value == 0 )
                    {
                        progressBarHp.Visible = false;
                    }
                    else
                    progressBarHp.Value -= 1;
                }
                if (HPBat <= 0 && pictureBat.Visible)

                {
                    label1.Visible = false;
                    progressBarHp.Visible = false;
                    pictureBat.Visible = false;
                    potion();
                    picturePotion.Visible = true;
                }
            }
            AttackBat();
            lostgame();
        }
        private void picturePotionEQ_Click(object sender, EventArgs e)
        {
            buttonAttack.Text = "Drink";
          
        }
    
    }
}

