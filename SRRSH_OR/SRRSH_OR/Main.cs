using System;
using System.Windows.Forms;
using System.Data.OleDb;
namespace SRRSH_OR
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string strTmp = Common.GetFilePath.GetStartupPath();
                
                string file = @""+strTmp+ "\\TestFile\\test.xls";
                OleDbConnection conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + file + ";Extended Properties=Excel 12.0");
                conn.Open();
                Console.WriteLine("连接成功");
                OleDbCommand comm = new OleDbCommand("Select * from [Sheet1$A:B] where [NO] is not null", conn);
                OleDbDataReader re = null;
                re = comm.ExecuteReader();
                if (re != null)
                {
                    string srt;
                    while (re.Read())
                    {
                        srt = re["修改日期"].ToString();
                        Console.WriteLine(srt);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }

        }
    }
}
