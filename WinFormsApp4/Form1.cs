namespace WinFormsApp4
{
    public partial class Form1 : Form
    {
        List<Cars> cars = new List<Cars>
        {
            new Cars{ Model = "X5", Vendor = "Bmw", Year = 2015, Engine = "Bmw Engine"},
            new Cars{ Model = "A7", Vendor = "Audi", Year = 2016, Engine = "Audi Engine"},
            new Cars { Model = "488 GTB", Vendor = "Ferrari", Year = 2020, Engine = "Ferrari"}
        };

        int pictureNumber = 1;

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_right_Click(object sender, EventArgs e)
        {
            pictureNumber -= 1;

            if (pictureNumber < 1)
                pictureNumber = cars.Count;
            
            ChangePictures(pictureNumber);
        }

        private void btn_left_Click(object sender, EventArgs e)
        {
            pictureNumber += 1;

            if (pictureNumber > cars.Count)
                pictureNumber = 1;            

            ChangePictures(pictureNumber);
        }


        private void ChangePictures(int picNum)
        {
            switch (picNum)
            {

                case 1:
                    pictureBox1.Image = Properties.Resources.bmw;
                    textBox1.Text = cars[0].ToString();
                    break;
                case 2:
                    pictureBox1.Image = Properties.Resources.Audi;
                    textBox1.Text = cars[1].ToString();
                    break;
                case 3:
                    pictureBox1.Image = Properties.Resources.Ferrari;
                    textBox1.Text = cars[2].ToString();
                    break;
               
            }
        }
    }
}