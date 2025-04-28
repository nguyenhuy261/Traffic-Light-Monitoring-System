using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Net;
using System.IO;
using System.Text.RegularExpressions;
using System.Net.Sockets;
using System.Data.SqlClient;//thư viện hỗ trợ kết nối SQL

namespace inal_Project_2
{
    public partial class Form1 : Form
    {
        private Thread thdUDPServer;
        private UdpClient udpClient;
        private bool isReading = false;

        //=============1================
        string returnData = string.Empty;
        string InputDataTime = String.Empty; // Khai báo string buff dùng cho hiển thị dữ liệu sau này.
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-TOC33KQ\NGUYEN;Initial Catalog=FINAL;Integrated Security=True");//Chuỗi kết nối CSDL
        SqlDataAdapter da, da1;
        DataTable dt, dt1;
        DataSet ds = new DataSet();
        SqlCommand cmd;
        long countData;
        static int i = 1;
        static int i1 = 1;
        int rowIndex = 0;
        string var1, var2;
        string road1 = string.Empty;
        string road2 = string.Empty;
        public delegate void logCallback(string logLine); //Khai bao delegate SetTextCallBack voi tham so string
        //=============================================

        public Form1()
        {
            InitializeComponent();
        }

        //====================2====================
        private void KetNoiCSDL()
        {
            //Tạo chuỗi kết nối
            string sql = "select * from UDP_data";//lấy dữ liệu từ table ValueTemp
            SqlCommand com = new SqlCommand(sql, con);//truy vấn cơ sở dữ liệu
            com.CommandType = CommandType.Text;
            da = new SqlDataAdapter(com);//Tải dữ liệu về
            dt = new DataTable();//Tạo không gian ảo lưu trữ dữ liệu
            da.Fill(dt);//Lưu dữ liệu vào không gian lưu trữ
            con.Close();//Đóng kết nối
            dataGridView1.DataSource = dt;//Gán dữ liệu vào DatagridView
            dataGridView1.FirstDisplayedScrollingRowIndex = dataGridView1.RowCount - 1;//autoscroll datagridview to end point
        }

        //==================================3=================================
        //==hàm tự động lưu dữ liệu vào csdl
        //==============
        private delegate void dlgAutoUpdateDatabases(long stt, string vaIPClient, string vaRoad1, string vaRoad2, string TimeCreated);
        private void AutoUpdateDatabases(long stt, string vaIPClient, string vaRoad1, string vaRoad2, string TimeCreated)
        {
            if (this.dataGridView1.InvokeRequired)
            {
                this.Invoke(new dlgAutoUpdateDatabases(AutoUpdateDatabases), stt, vaIPClient, vaRoad1, vaRoad2, TimeCreated);
            }
            else
            {
                con.Open();
                cmd = new SqlCommand("INSERT INTO UDP_data (ID, IPClient, Road1, Road2, TimeCreat) VALUES (@ID,@IPClient,@Road1,@Road2,@TimeCreat)", con);
                //nhóm lệnh truy xuất SQL
                cmd.Parameters.Add("@ID", stt);
                cmd.Parameters.Add("@IPClient", vaIPClient);
                cmd.Parameters.Add("@Road1", vaRoad1);
                cmd.Parameters.Add("@Road2", vaRoad2);
                cmd.Parameters.Add("@TimeCreat", TimeCreated);
                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch
                {
                    con.Close();
                    // MessageBox.Show("The value is identical", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }


                KetNoiCSDL();
            }

        }

        //====================2====================
        private void KetNoiCSDL1()
        {
            //Tạo chuỗi kết nối
            string sql1 = "select * from UDP_control";//lấy dữ liệu từ table ValueTemp
            SqlCommand com1 = new SqlCommand(sql1, con);//truy vấn cơ sở dữ liệu
            com1.CommandType = CommandType.Text;
            da1 = new SqlDataAdapter(com1);//Tải dữ liệu về
            dt1 = new DataTable();//Tạo không gian ảo lưu trữ dữ liệu
            da1.Fill(dt1);//Lưu dữ liệu vào không gian lưu trữ
            con.Close();//Đóng kết nối
            dataGridView2.DataSource = dt1;//Gán dữ liệu vào DatagridView
            dataGridView2.FirstDisplayedScrollingRowIndex = dataGridView2.RowCount - 1;//autoscroll datagridview to end point
        }

        //==hàm tự động lưu dữ liệu vào csdl
        private delegate void dlgAutoUpdateDatabases1(long stt, string vaIPClient, string vaCommand, string vaStatus, string TimeCreated);
        private void AutoUpdateDatabases1(long stt, string vaIPClient, string vaCommand, string vaStatus, string TimeCreated)
        {
            if (this.dataGridView2.InvokeRequired)
            {
                this.Invoke(new dlgAutoUpdateDatabases1(AutoUpdateDatabases1), stt, vaIPClient, vaCommand, vaStatus, TimeCreated);
            }
            else
            {
                con.Open();
                cmd = new SqlCommand("INSERT INTO UDP_control (ID,IPClient,Command,Status,TimeCreat) VALUES (@ID,@IPClient,@Command,@Status,@TimeCreat)", con);
                //nhóm lệnh truy xuất SQL
                cmd.Parameters.Add("@ID", stt);
                cmd.Parameters.Add("@IPClient", vaIPClient);
                cmd.Parameters.Add("@Command", vaCommand);
                cmd.Parameters.Add("@Status", vaStatus);
                cmd.Parameters.Add("@TimeCreat", TimeCreated);
                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch
                {
                    con.Close();
                    // MessageBox.Show("The value is identical", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                KetNoiCSDL1();
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'fINALDataSet1.UDP_control' table. You can move, or remove it, as needed.
            this.uDP_controlTableAdapter.Fill(this.fINALDataSet1.UDP_control);
            // TODO: This line of code loads data into the 'fINALDataSet.UDP_data' table. You can move, or remove it, as needed.
            this.uDP_dataTableAdapter.Fill(this.fINALDataSet.UDP_data);

            Thread thdUDPServer = new Thread(new ThreadStart(serverThread));
            thdUDPServer.Start();
            KetNoiCSDL();
            //==========kiểm tra dữ liệu trong csdl
            //
            if (dataGridView1.Rows.Count > 1)
            {
                //dữ liệu được chèn tiếp theo
                i = Int32.Parse(dataGridView1.Rows[dataGridView1.Rows.Count - 2].Cells[0].Value.ToString());
                i++;
            }
            else i = 1; //nếu chưa có dữ liệu thì thêm từ đầu

            KetNoiCSDL1();
            //==========kiểm tra dữ liệu trong csdl
            //
            if (dataGridView2.Rows.Count > 1)
            {
                //dữ liệu được chèn tiếp theo
                i1 = Int32.Parse(dataGridView2.Rows[dataGridView2.Rows.Count - 2].Cells[0].Value.ToString());
                i1++;
            }
            else i1 = 1; //nếu chưa có dữ liệu thì thêm từ đầu
        }

        private void b_open_Click(object sender, EventArgs e)
        {
            if (!isReading)
            {
                isReading = true;
                thdUDPServer = new Thread(new ThreadStart(serverThread));
                thdUDPServer.Start();
            }
        }

        //=================Đặt định dạng text hiển thị data nhận đươc=====
        private void SetText(string text)
        {

            //=============
            if (InvokeRequired) this.Invoke(new logCallback(SetText), new object[] { text });
            else tb_receive.AppendText(text + Environment.NewLine);
        }
        //==========================================================
        public void serverThread() //SERVER
        {
            udpClient = new UdpClient(8080);
            try
            {
                while (isReading)
                {
                    IPEndPoint RemoteIpEndPoint = new IPEndPoint(IPAddress.Any, 8080);
                    Byte[] receiveBytes = udpClient.Receive(ref RemoteIpEndPoint);
                    string returnData = Encoding.ASCII.GetString(receiveBytes);

                    if (returnData != string.Empty)
                    {
                        SetText(returnData); // Gọi delegate đã khai báo trước đó.
                        InputDataTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff");
                        if ((returnData.IndexOf('@') != -1) && (returnData.IndexOf('#') != -1) && (returnData.IndexOf('@') < (returnData.IndexOf('t') - 1)) && (returnData.IndexOf('t') < (returnData.IndexOf('#') - 1)))//Kiểm tra định dạng dữ liệu có @ và % không
                        {
                            countData++;//Đếm số dữ liệu đúng định dạng nhận được
                            SetText(" >>Count Data =" + countData);

                            //=======================================
                            if ((returnData.IndexOf('t') != -1) && (returnData.IndexOf('@') < (returnData.IndexOf('t') - 1)))
                            { //neu co ký tự 't' và vị trí ký tự 't' ko liền kề sau @ thi doc var1
                                var1 = returnData.Substring(returnData.IndexOf('@') + 1, returnData.IndexOf('t') - 1);
                                road1 = var1;
                                //=================================
                                if (tb_road1.InvokeRequired)
                                {
                                    tb_road1.Invoke((MethodInvoker)delegate { tb_road1.Text = road1; });
                                }
                                else tb_road1.Text = road1;
                            }

                            //=================================
                            if ((returnData.IndexOf('#') != -1) && (returnData.IndexOf('t') < (returnData.IndexOf('#') - 1)))
                            {
                                //Nếu thấy ký tự '#' và '#' không liên kề sau 't' thì var2
                                var2 = returnData.Substring(returnData.IndexOf('t') + 1, returnData.IndexOf('#') - returnData.IndexOf('t') - 1);
                                road2 = var2;
                                if (tb_road2.InvokeRequired)
                                {
                                    tb_road2.Invoke((MethodInvoker)delegate { tb_road2.Text = road2; });
                                }
                                else tb_road2.Text = road2;
                            }
                            //==============Tự động lưu vào CSDL
                            //IPEndPoint clientep = (IPEndPoint)clientsock.RemoteEndPoint;
                            string ipclient = textBox_ip.Text;
                            AutoUpdateDatabases(i, ipclient, road1, road2, InputDataTime);
                            i++;
                        }
                    }
                }
            }
            catch (SocketException ex)
            {
                // Xử lý ngoại lệ socket
                MessageBox.Show(ex.Message);
            }
            finally
            {
                udpClient.Close(); // Đảm bảo socket được đóng lại
            }

        }

        private void b_close_Click(object sender, EventArgs e)
        {
            isReading = false;
            udpClient.Close();
            thdUDPServer.Join();
        }

        private void bt_ut1_Click(object sender, EventArgs e)
        {
            try
            {

                using (UdpClient udpClient = new UdpClient())
                {
                    udpClient.Connect(textBox_ip.Text, Convert.ToInt16(textBox_port.Text));
                    Byte[] senddata = Encoding.ASCII.GetBytes("O");
                    udpClient.Send(senddata, senddata.Length);
                }
                string InputDataTime = String.Empty;
                InputDataTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff");
                string ipclient = textBox_ip.Text;
                AutoUpdateDatabases1(i1, ipclient, "O", "Ưu tiên Road1", InputDataTime);
                i1++;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error sending message: " + ex.Message);
            }
        }

        private void bt_ut2_Click(object sender, EventArgs e)
        {
            try
            {           
                using (UdpClient udpClient = new UdpClient())
                {
                    udpClient.Connect(textBox_ip.Text, Convert.ToInt16(textBox_port.Text));
                    Byte[] senddata = Encoding.ASCII.GetBytes("T");
                    udpClient.Send(senddata, senddata.Length);
                }
                string InputDataTime = String.Empty;
                InputDataTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff");
                string ipclient = textBox_ip.Text;
                AutoUpdateDatabases1(i1, ipclient, "T", "Ưu tiên Road2", InputDataTime);
                i1++;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error sending message: " + ex.Message);
            }
        }

    }
}
