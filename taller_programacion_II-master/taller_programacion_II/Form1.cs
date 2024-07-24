namespace taller_programacion_II
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

      

        private void button1_Click_1(object sender, EventArgs e)
        {
            var PruebasFisicas = new PruebasFisicas();
            PruebasFisicas.Show();
            this.Hide();

        }
    }
}

