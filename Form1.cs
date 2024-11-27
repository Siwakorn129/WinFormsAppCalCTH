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
            MessageBox.Show("ยินดีต้อนรับผู้ใช้งาน", "Welcome");
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("ต้องการปิดโปรแกรมใช่หรือไม่", "Close",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void btnCircleArea_Click(object sender, EventArgs e)
        {
            //input รับค่าจาก TextBox (แปลงชนิดข้อมูลเป็น double)
            double Radius = 0;
            
            if (double.TryParse(txtRadius.Text, out Radius) == false)
            {
                MessageBox.Show("กรอกข้อมูลไม่ถูกต้อง", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtRadius.Focus(); //ให้มี Cursor ที่ TextBox
                txtRadius.SelectAll(); //ให้ Select ข้อความใน TextBox
                return;
            }

            //process สูตรคำนวณ pi*r*r
            double CircleArea = Math.PI * Math.Pow(Radius, 2);
            //Math.PI ให้ค่า PI
            //Math.Pow(x,y) x ยกกำลัง y

            //output นำไปแสดงที่ lblResult
            lblResult.Text = CircleArea.ToString("0.00");
            txtRadius.Focus();
            txtRadius.SelectAll();
        }

        private void btnTriangleArea_Click(object sender, EventArgs e)
        {
            //input รับค่าจาก TextBox (แปลงชนิดข้อมูลเป็น double)
            double BaseLenght = 0;
            double Height = 0;

            if (double.TryParse(txtHeight.Text, out Height) == false)
            {
                MessageBox.Show("กรอกข้อมูลไม่ถูกต้อง", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtHeight.Focus(); //ให้มี Cursor ที่ TextBox
                txtHeight.SelectAll(); //ให้ Select ข้อความใน TextBox
                return;
            }

            if (double.TryParse(txtBase.Text, out BaseLenght) == false)
            {
                MessageBox.Show("กรอกข้อมูลไม่ถูกต้อง", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtBase.Focus(); //ให้มี Cursor ที่ TextBox
                txtBase.SelectAll(); //ให้ Select ข้อความใน TextBox
                return;
            }
            
            double TriangleArea = 0.5 * BaseLenght * Height;
            //output นำไปแสดงที่ lblResult
            lblResult.Text = TriangleArea.ToString("0.00");
            txtHeight.Focus();
            txtHeight.SelectAll();
        }

        private void btnHexagonArea_Click(object sender, EventArgs e)
        {
            double SideLenght = 0;
            if (double.TryParse(txtHexagonWidht.Text, out SideLenght) == false)
            {
                MessageBox.Show("กรอกข้อมูลไม่ถูกต้อง", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtHexagonWidht.Focus(); //ให้มี Cursor ที่ TextBox
                txtHexagonWidht.SelectAll(); //ให้ Select ข้อความใน TextBox
                return;
            }
            double HexagonArea = (3*Math.Sqrt(3)/2)*Math.Pow(SideLenght, 2);
            lblResult.Text = HexagonArea.ToString("0.00");
        }
    }
}
