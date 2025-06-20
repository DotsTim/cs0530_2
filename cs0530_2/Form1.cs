using System;

namespace cs0530_2
{
    public partial class Form1 : Form
    {

        int[] vx = new int[3];
        int[] vy = new int[3];
        Label[] labels = new Label[100];

        static Random random = new Random();
        public Form1()
        {
            InitializeComponent();

           

            for (int i = 0; i < 3; i++)
            {
                vx[i] = random.Next(-10, 11);
                vy[i] = random.Next(-10, 11);
                labels[i] = new Label();
                labels[i].AutoSize = true;
                labels[i].Text = "??";
                labels[i].Font = new Font("Yu Gothic UI", 24F);
                Controls.Add(labels[i]);
            }

            label1.Left = random.Next(ClientSize.Width);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // counter++;


            var mpos = MousePosition;
            var fpos = PointToClient(mpos);
            Text = $"{mpos.X},{mpos.Y}/{fpos.X},{fpos.Y}";
            label1.Left += vx[0];
            label1.Top += vy[0];

            for (int i=0;i<3;i++)
            {
                labels[i].Left += vx[i];
                labels[i].Top += vy[i];

            }

            if (label1.Left < 0)
            {

                vx[0] = Math.Abs(vx[0]);
            }
            if (label1.Top < 0)
            {
                vy[0] = Math.Abs(vx[0]);
            }
            if (label1.Right > ClientSize.Width)
            {
                vx[0] = -Math.Abs(vy[0]);
            }
            if (label1.Bottom > ClientSize.Height)
            {
                vy[0] = -Math.Abs(vy[0]);
            }
            if (
                (label1.Left < fpos.X)
                && (fpos.X < label1.Right)
                && (fpos.Y > label1.Top)
                && (fpos.Y < label1.Bottom))
            {
                timer1.Stop();
            }

            label2.Left += vx[1];
            label2.Top += vy[1];
            if (label2.Left < 0)
            {
                vx[1] = Math.Abs(vx[1]);

            }
            else if (label2.Top < 0)
            {

            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                MessageBox.Show($"{i}");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int i;
            for (i = 0; i < 10; i++)
            {
                if (i == 2)
                {
                    continue;
                }
                if (i == 5)
                {
                    break;
                }
                MessageBox.Show(i.ToString());
            }
        }
    }
}

