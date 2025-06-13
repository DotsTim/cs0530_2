namespace cs0530_2
{
    public partial class Form1 : Form
    {

        int vx = -20;
        int vy = -20;
        int vx2 = -30;
        int vy2 = -30;
        static Random random = new Random();
        public Form1()
        {
            InitializeComponent();
            //MessageBox.Show($"{label1.Right}");
            vx = random.Next(-10, 11);
            vy = random.Next(-10, 11);

            label1.Left = random.Next(ClientSize.Width);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // counter++;


            var mpos = MousePosition;
            var fpos = PointToClient(mpos);
            Text = $"{mpos.X},{mpos.Y}/{fpos.X},{fpos.Y}";
            label1.Left += vx;
            label1.Top += vy;

            if (label1.Left < 0)
            {

                vx = Math.Abs(vx);
            }
            if (label1.Top < 0)
            {
                vy = Math.Abs(vx);
            }
            if (label1.Right > ClientSize.Width)
            {
                vx = -Math.Abs(vy);
            }
            if (label1.Bottom > ClientSize.Height)
            {
                vy = -Math.Abs(vy);
            }
            if (
                (label1.Left < fpos.X)
                && (fpos.X < label1.Right)
                && (fpos.Y > label1.Top)
                && (fpos.Y < label1.Bottom))
            {
                timer1.Stop();
            }

            label2.Left += vx2;
            label2.Top += vy2;
            if (label2.Left < 0)
            {
                vx2 = Math.Abs(vx2);

            }
            else if (label2.Top<0)
            {
                
            }
        }  

                private void label2_Click(object sender, EventArgs e)
                {

                }
    }
}
