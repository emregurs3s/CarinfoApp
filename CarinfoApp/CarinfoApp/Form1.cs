namespace CarinfoApp
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Textbox nesnesinin i�indeki string veriye eri�ip MessageBox i�erisinde ��kt� al�yoruz
            MessageBox.Show("Markas� : " + textBox_Marka.Text + "\n" +
                "Modeli : " + textBox_Model.Text + "\n" +
                "Rengi : " + textBox_Renk.Text + "\n" +
                "Kap� Say�s� : " + textBox_KapiSayisi.Text + "\n" +
                "Pencere Say�s� : " + textBox_PencereSayisi.Text + "\n" +
                "100 km�de Yakt��� Yak�t (Litre):  " + textBox_Yakit.Text + "\n"
                );
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_Kapisayisi_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
