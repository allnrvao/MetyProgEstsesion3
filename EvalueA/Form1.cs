using EvalueA.models;

namespace EvalueA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Evaluate_Click(object sender, EventArgs e)
        {
            try
            {
                int age = Convert.ToInt16(TbAge.Text);
                Evaluate evaluete = new Evaluate();
                LblAnswer.Text = "Tienes" + age + "Años. " + evaluete.EvalAge + "";
                TbAge.Text = "";
                TbAge.Focus();
            }
            catch (Exception ex)
            {
                LblAnswer.Text = ex.Message;
            }

        }


    }
}
