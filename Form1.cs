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
                MessageBox.Show("��͡���������١��ͧ", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtRadius.Focus(); //����� Cursor ��� TextBox
                txtRadius.SelectAll(); //��� Select ��ͤ���� TextBox
                return;
            }

            //process �ٵäӹǳ pi*r*r
            double CircleArea = Math.PI * Math.Pow(Radius, 2);
            //Math.PI ����� PI
            //Math.Pow(x,y) x ¡���ѧ y

            //output ����ʴ���� lblResult
            lblResult.Text = CircleArea.ToString("0.00");
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
                MessageBox.Show("��͡���������١��ͧ", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtHeight.Focus(); //����� Cursor ��� TextBox
                txtHeight.SelectAll(); //��� Select ��ͤ���� TextBox
                return;
            }

            if (double.TryParse(txtBase.Text, out BaseLenght) == false)
            {
                MessageBox.Show("��͡���������١��ͧ", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtBase.Focus(); //����� Cursor ��� TextBox
                txtBase.SelectAll(); //��� Select ��ͤ���� TextBox
                return;
            }
            
            double TriangleArea = 0.5 * BaseLenght * Height;
            //output ����ʴ���� lblResult
            lblResult.Text = TriangleArea.ToString("0.00");
            txtHeight.Focus();
            txtHeight.SelectAll();
        }

        private void btnHexagonArea_Click(object sender, EventArgs e)
        {
            double SideLenght = 0;
            if (double.TryParse(txtHexagonWidht.Text, out SideLenght) == false)
            {
                MessageBox.Show("��͡���������١��ͧ", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtHexagonWidht.Focus(); //����� Cursor ��� TextBox
                txtHexagonWidht.SelectAll(); //��� Select ��ͤ���� TextBox
                return;
            }
            double HexagonArea = (3*Math.Sqrt(3)/2)*Math.Pow(SideLenght, 2);
            lblResult.Text = HexagonArea.ToString("0.00");
        }
    }
}
