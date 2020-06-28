using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QuanLyBanHang.Class
{
    class Functions
    {
        public static SqlConnection Con;    

        public static void Connect()
        {
            Con = new SqlConnection();
            Con.ConnectionString = @"Data Source=.\SQLEXPRESS;AttachDbFilename=" + Application.StartupPath + @"\Quanlybanhang.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True";
            Con.Open();                  
            
            if (Con.State == ConnectionState.Open)
                MessageBox.Show("Kết nối thành công");
            else MessageBox.Show("Không thể kết nối với dữ liệu");

        }
        public static void Disconnect()
        {
            if (Con.State == ConnectionState.Open)
            {
                Con.Close();   	
                Con.Dispose(); 	
                Con = null;
            }
        }
    }