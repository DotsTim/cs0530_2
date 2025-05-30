namespace cs0530_2
{
    public partial class Form1 : Form
    {
       
        int vx=-50, vy=-50;
        public Form1()
        {
            InitializeComponent();
            MessageBox.Show($"{label1.Right}");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Left += vx;
            label1.Top += vy;

            if (label1.Left  < 0) 
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
               
        }
    }
}
