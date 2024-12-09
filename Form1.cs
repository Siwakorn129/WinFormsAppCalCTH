namespace WinFormsAppCalCTH
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("�Թ�յ�͹�Ѻ�����ҹ", "Welcome");
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("��ͧ��ûԴ��������������", "Close",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void btnCircleArea_Click(object sender, EventArgs e)
        {
            //input �Ѻ��Ҩҡ TextBox (�ŧ��Դ�������� double)
            double Radius = 0;

            if (double.TryParse(txtRadius.Text, out Radius) == false)
            {
                ShowError(txtRadius, "��سҡ�͡�������շ��١��ͧ");
                return;
            }

            //process �ٵäӹǳ pi*r*r
            double CircleArea = CalculateCircleArea(Radius);
            //Math.PI ����� PI
            //Math.Pow(x,y) x ¡���ѧ y

            //output ����ʴ���� lblResult
            ShowResult(lblResult, CircleArea);
            txtRadius.Focus();
            txtRadius.SelectAll();
        }

        private void btnTriangleArea_Click(object sender, EventArgs e)
        {
            //input �Ѻ��Ҩҡ TextBox (�ŧ��Դ�������� double)
            double BaseLenght = 0;
            double Height = 0;

            if (double.TryParse(txtHeight.Text, out Height) == false)
            {
                ShowError(txtRadius, "��سҡ�͡��Ұҹ���١��ͧ");
                return;
            }

            if (double.TryParse(txtBase.Text, out BaseLenght) == false)
            {
                ShowError(txtRadius, "��سҡ�͡����٧���١��ͧ");
                return;
            }

            double TriangleArea = CalculateTriangleArea(BaseLenght, Height);
            //output ����ʴ���� lblResult
            ShowResult(lblResult, TriangleArea);
            txtHeight.Focus();
            txtHeight.SelectAll();
        }

        private void btnHexagonArea_Click(object sender, EventArgs e)
        {
            double SideLenght = 0;
            if (double.TryParse(txtHexagonWidht.Text, out SideLenght) == false)
            {
                ShowError(txtRadius, "��سҡ�͡��Ҵ�ҹ���١��ͧ");
                return;
            }
            double HexagonArea = CalculateHexagonArea(SideLenght);
            ShowResult(lblResult, HexagonArea);
            txtHexagonWidht.Focus();
            txtHexagonWidht.SelectAll();
        }

        private double CalculateCircleArea(double Radius)
        {
            return Math.PI * Math.Pow(Radius, 2);
        }

        private double CalculateTriangleArea(double BaseLenght, double Height)
        {
            return 0.5 * BaseLenght * Height;
        }

        private double CalculateHexagonArea(double SideLenght)
        {
            return (3 * Math.Sqrt(3) / 2) * Math.Pow(SideLenght, 2);
        }

        private void ShowResult(Label label, double area)
        {
            label.Text = area.ToString("0.00");
        }

        private void ShowError(TextBox textBox, string message)
        {
            MessageBox.Show("��͡���������١��ͧ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            textBox.Focus(); //����� Cursor ��� TextBox
            textBox.SelectAll(); //��� Select ��ͤ���� TextBox
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void Clear()
        {
            txtRadius.Text = "";
            txtHeight.Text = "";
            txtBase.Text = "";
            txtHexagonWidht.Text = "";
            lblResult.Text = "";
        }
    }
}
