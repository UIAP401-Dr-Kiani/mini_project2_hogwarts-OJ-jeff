namespace Hogwarts_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Human[] Humans = new Human[400];
            for (int i = 0; i <= 400; ++i)
            {
                Humans[i] = new Human();
            }
            var Jsonfile = File.ReadAllText("C:\\Users\\Amir\\source\\repos\\mini_project2_hogwarts-OJ-jeff\\Files");
            Humans = JsonConvert.DeserializeObject<Human[]>(Jsonfile);
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}