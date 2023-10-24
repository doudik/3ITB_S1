namespace Observer_winapp
{
    public partial class Form1 : Form
    {

        List<Device> ListZarizeni = new List<Device>();
        WeatherStation UnLstanice;

        public Form1()
        {
            InitializeComponent();
            timer1.Enabled = true;
            timer1.Interval = 1000;
            timer1.Tick += Timer1_Tick;
        }

        private void Timer1_Tick(object? sender, EventArgs e)
        {
            UpdateKonzole();

        }

        private void UpdatePosluchacu()
        {
            listBox2.Items.Clear();
            foreach (var item in UnLstanice.posluchaci)
            {
                listBox2.Items.Add(item);
            }
        }

        private void UpdateZarizeni()
        {
            listBox3.Items.Clear();
            foreach (var item in ListZarizeni)
            {
                listBox3.Items.Add(item.name);
            }
        }

        private void UpdateKonzole()
        {
            label1.ResetText();
            UnLstanice.Notifikuj();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            UnLstanice = new WeatherStation(GetValues()[0], GetValues()[1], this);
            
        }
        //remake
        void PridejPosluchace()
        {
            foreach (var item in ListZarizeni)
            {
                
            }
        }

        private float[] GetValues()
        {
            float[] array = new float[2];
            array[0] = (float)numericUpDown1.Value;
            array[1] = (float)numericUpDown1.Value;

            return array;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            //teplota
            UnLstanice.NoveMereniTeplota((float)numericUpDown1.Value);
        }
        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            //vlhkost
            UnLstanice.NoveMereniVlhkost((float)numericUpDown2.Value);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //pøidat device
            Random rnd = new Random();
            string[] names = { "hodinky", "widget", "mobil", "poèítaè" };
            Device temp = new Device(names[rnd.Next(0, names.Length)]);
            ListZarizeni.Add(temp);
            UpdateZarizeni();
            UnLstanice.PridejPosluchace(temp);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //TODO
            UpdatePosluchacu();
        }
    }
}