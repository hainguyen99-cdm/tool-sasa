using click_pc.Controller;
using click_pc.Helpper;
using crawl_price.Helpper;
using Emgu.CV.Flann;
using fox_hunter.Controllers;
using KAutoHelper;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Remote;
using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Controls;
using System.Windows.Forms;

namespace click_pc
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();

        }
        IWebDriver webDriver;

        private void btnStart_Click(object sender, EventArgs e)
        {
            Task.Run(() =>
            {
                List<DataGrid> dataGrids = new List<DataGrid>();
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (!row.IsNewRow)
                    {
                        if (row.Cells[0].Value != null)
                        {
                            if (bool.Parse(row.Cells[0].Value.ToString()) == true)
                            {

                                DataGrid dataGrid = new DataGrid();
                                // Lấy dữ liệu từ cột cụ thể, ví dụ cột đầu tiên (index = 0)
                                dataGrid.index = Int32.Parse(row.Cells[1].Value.ToString());
                                dataGrids.Add(dataGrid);

                            }

                        }

                    }
                }
                List<string> lsCookie = new List<string>();
                lsCookie.AddRange(UtilitiesFiles.ReadFiles(Environment.CurrentDirectory + "\\cookie.txt"));
                for (int i = 0; i < dataGrids.Count; i++)
                {
                    webDriver = UtilitiesBrower.OpenBrowser(false, dataGrids[i].index);
                    ControllerAction.login(webDriver, lsCookie[dataGrids[i].index].TrimEnd(';'));
                    //UtilitiesBrower.CloseBrower(webDriver);
                }
            });
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Đường dẫn đến thư mục mà bạn muốn lấy danh sách các thư mục con.
            List<string> lsCookie = new List<string>();
            lsCookie.AddRange(UtilitiesFiles.ReadFiles(Environment.CurrentDirectory + "\\cookie.txt"));
            for (int i = 0; i < lsCookie.Count(); i++)
            {
                DataGrid dataGrid = new DataGrid();

                dataGridView1.Invoke(new Action(() =>
                {
                    dataGridView1.Rows.Add();
                }));
                dataGrid.index = i;

                DataGridController.Loaddata(dataGrid, dataGridView1);
            }

        }

        private void BtnAutoSpin_Click(object sender, EventArgs e)
        {
            Task.Run(() =>
            {
                List<DataGrid> dataGrids = new List<DataGrid>();
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (!row.IsNewRow)
                    {
                        if (row.Cells[0].Value != null)
                        {
                            if (bool.Parse(row.Cells[0].Value.ToString()) == true)
                            {

                                DataGrid dataGrid = new DataGrid();
                                // Lấy dữ liệu từ cột cụ thể, ví dụ cột đầu tiên (index = 0)
                                dataGrid.index = Int32.Parse(row.Cells[1].Value.ToString());
                                dataGrids.Add(dataGrid);

                            }

                        }

                    }
                }
                List<string> lsCookie = new List<string>();
                lsCookie.AddRange(UtilitiesFiles.ReadFiles(Environment.CurrentDirectory + "\\cookie.txt"));
                for (int i = 0; i < dataGrids.Count; i++)
                {
                    webDriver = UtilitiesBrower.OpenBrowser(false, dataGrids[i].index);
                    ControllerAction.login(webDriver, lsCookie[dataGrids[i].index].TrimEnd(';'));
                    TaskController.TaskLoginGame();
                    Thread.Sleep(1000);
                    TaskController.TaskGachak();
                }
            });
        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();
            string path = Environment.CurrentDirectory + @"\Profile";

            // Kiểm tra xem thư mục có tồn tại không.
            // Đường dẫn đến thư mục mà bạn muốn lấy danh sách các thư mục con.
            List<string> lsCookie = new List<string>();
            lsCookie.AddRange(UtilitiesFiles.ReadFiles(Environment.CurrentDirectory + "\\cookie.txt"));
            for (int i = 0; i < lsCookie.Count(); i++)
            {
                DataGrid dataGrid = new DataGrid();

                dataGridView1.Invoke(new Action(() =>
                {
                    dataGridView1.Rows.Add();
                }));
                dataGrid.index = i;

                DataGridController.Loaddata(dataGrid, dataGridView1);
            }
        }

        private void btnWaterTree_Click(object sender, EventArgs e)
        {
            Task.Run(() =>
            {
                List<DataGrid> dataGrids = new List<DataGrid>();
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (!row.IsNewRow)
                    {
                        if (row.Cells[0].Value != null)
                        {
                            if (bool.Parse(row.Cells[0].Value.ToString()) == true)
                            {

                                DataGrid dataGrid = new DataGrid();
                                // Lấy dữ liệu từ cột cụ thể, ví dụ cột đầu tiên (index = 0)
                                dataGrid.index = Int32.Parse(row.Cells[1].Value.ToString());
                                dataGrids.Add(dataGrid);

                            }

                        }

                    }
                }
                List<string> lsCookie = new List<string>();
                lsCookie.AddRange(UtilitiesFiles.ReadFiles(Environment.CurrentDirectory + "\\cookie.txt"));
                for (int i = 0; i < dataGrids.Count; i++)
                {
                    webDriver = UtilitiesBrower.OpenBrowser(false, dataGrids[i].index);
                    ControllerAction.login(webDriver, lsCookie[dataGrids[i].index].TrimEnd(';'));
                    TaskController.TaskLoginGame();
                    Thread.Sleep(5000);
                    TaskController.TaskWaterTheTree();
                    Thread.Sleep(1000);
                    UtilitiesBrower.CloseBrower(webDriver);
                }
            });
        }

        private void btnDefen_Click(object sender, EventArgs e)
        {
            TaskController.FlagStop = false;
            Task.Run(() =>
            {
                List<DataGrid> dataGrids = new List<DataGrid>();
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (!row.IsNewRow)
                    {
                        if (row.Cells[0].Value != null)
                        {
                            if (bool.Parse(row.Cells[0].Value.ToString()) == true)
                            {

                                DataGrid dataGrid = new DataGrid();
                                // Lấy dữ liệu từ cột cụ thể, ví dụ cột đầu tiên (index = 0)
                                dataGrid.index = Int32.Parse(row.Cells[1].Value.ToString());
                                dataGrids.Add(dataGrid);

                            }

                        }

                    }
                }
                List<string> lsCookie = new List<string>();
                lsCookie.AddRange(UtilitiesFiles.ReadFiles(Environment.CurrentDirectory + "\\cookie.txt"));



                // Khởi tạo trình duyệt cho mỗi chỉ mục trong mảng

               
                    for (int i = 0; i < dataGrids.Count; i++)
                    {
                    webDriver = UtilitiesBrower.OpenBrowser(false, dataGrids[i].index);
                    while (true)
                    {

                        ControllerAction.login(webDriver, lsCookie[dataGrids[i].index].TrimEnd(';'));
                        Thread.Sleep(5000);

                        TaskController.TaskLoginGame();
                        Thread.Sleep(5000);
                        TaskController.TaskAddDefender();
                        Thread.Sleep(1000);
                        webDriver.Navigate().Refresh();
                        Thread.Sleep(5000);

                        ControllerAction.login(webDriver, lsCookie[dataGrids[i].index].TrimEnd(';'));
                        Thread.Sleep(1000);

                        TaskController.TaskLoginGame();
                        Thread.Sleep(1000);

                        TaskController.TaskGachak();
                    }



                }
            });
        }

        private void btnBuyTree5Gem_Click(object sender, EventArgs e)
        {
            Task.Run(() =>
            {
                List<DataGrid> dataGrids = new List<DataGrid>();
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (!row.IsNewRow)
                    {
                        if (row.Cells[0].Value != null)
                        {
                            if (bool.Parse(row.Cells[0].Value.ToString()) == true)
                            {

                                DataGrid dataGrid = new DataGrid();
                                // Lấy dữ liệu từ cột cụ thể, ví dụ cột đầu tiên (index = 0)
                                dataGrid.index = Int32.Parse(row.Cells[1].Value.ToString());
                                dataGrids.Add(dataGrid);

                            }

                        }

                    }
                }
                List<string> lsCookie = new List<string>();
                lsCookie.AddRange(UtilitiesFiles.ReadFiles(Environment.CurrentDirectory + "\\cookie.txt"));
                for (int i = 0; i < dataGrids.Count; i++)
                {
                    webDriver = UtilitiesBrower.OpenBrowser(false, dataGrids[i].index);
                    ControllerAction.login(webDriver, lsCookie[dataGrids[i].index].TrimEnd(';'));
                    TaskController.TaskLoginGame();
                    Thread.Sleep(5000);
                    TaskController.TaskBuyTree5Gem();
                    UtilitiesBrower.CloseBrower(webDriver);

                }
            });
        }

        private void btnPlanTree5_Click(object sender, EventArgs e)
        {
            Task.Run(() =>
            {
                List<DataGrid> dataGrids = new List<DataGrid>();
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (!row.IsNewRow)
                    {
                        if (row.Cells[0].Value != null)
                        {
                            if (bool.Parse(row.Cells[0].Value.ToString()) == true)
                            {

                                DataGrid dataGrid = new DataGrid();
                                // Lấy dữ liệu từ cột cụ thể, ví dụ cột đầu tiên (index = 0)
                                dataGrid.index = Int32.Parse(row.Cells[1].Value.ToString());
                                dataGrids.Add(dataGrid);

                            }

                        }

                    }
                }
                List<string> lsCookie = new List<string>();
                lsCookie.AddRange(UtilitiesFiles.ReadFiles(Environment.CurrentDirectory + "\\cookie.txt"));
                for (int i = 0; i < dataGrids.Count; i++)
                {
                    webDriver = UtilitiesBrower.OpenBrowser(false, dataGrids[i].index);
                    ControllerAction.login(webDriver, lsCookie[dataGrids[i].index].TrimEnd(';'));
                    TaskController.TaskLoginGame();
                    Thread.Sleep(5000);
                    TaskController.Tree5();
                    Thread.Sleep(1000);
                    UtilitiesBrower.CloseBrower(webDriver);

                }
            });
        }

        private void btnBuy100Water_Click(object sender, EventArgs e)
        {
            Task.Run(() =>
            {
                List<DataGrid> dataGrids = new List<DataGrid>();
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (!row.IsNewRow)
                    {
                        if (row.Cells[0].Value != null)
                        {
                            if (bool.Parse(row.Cells[0].Value.ToString()) == true)
                            {

                                DataGrid dataGrid = new DataGrid();
                                // Lấy dữ liệu từ cột cụ thể, ví dụ cột đầu tiên (index = 0)
                                dataGrid.index = Int32.Parse(row.Cells[1].Value.ToString());
                                dataGrids.Add(dataGrid);

                            }

                        }

                    }
                }
                List<string> lsCookie = new List<string>();
                lsCookie.AddRange(UtilitiesFiles.ReadFiles(Environment.CurrentDirectory + "\\cookie.txt"));
                for (int i = 0; i < dataGrids.Count; i++)
                {
                    webDriver = UtilitiesBrower.OpenBrowser(false, dataGrids[i].index);
                    ControllerAction.login(webDriver, lsCookie[dataGrids[i].index].TrimEnd(';'));
                    TaskController.TaskLoginGame();
                    Thread.Sleep(5000);
                    TaskController.Buy100Water();
                    Thread.Sleep(1000);

                    UtilitiesBrower.CloseBrower(webDriver);

                }
            });
        }

        private void btnBuy300Water_Click(object sender, EventArgs e)
        {
            Task.Run(() =>
            {
                List<DataGrid> dataGrids = new List<DataGrid>();
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (!row.IsNewRow)
                    {
                        if (row.Cells[0].Value != null)
                        {
                            if (bool.Parse(row.Cells[0].Value.ToString()) == true)
                            {

                                DataGrid dataGrid = new DataGrid();
                                // Lấy dữ liệu từ cột cụ thể, ví dụ cột đầu tiên (index = 0)
                                dataGrid.index = Int32.Parse(row.Cells[1].Value.ToString());
                                dataGrids.Add(dataGrid);

                            }

                        }

                    }
                }
                List<string> lsCookie = new List<string>();
                lsCookie.AddRange(UtilitiesFiles.ReadFiles(Environment.CurrentDirectory + "\\cookie.txt"));
                for (int i = 0; i < dataGrids.Count; i++)
                {
                    webDriver = UtilitiesBrower.OpenBrowser(false, dataGrids[i].index);
                    ControllerAction.login(webDriver, lsCookie[dataGrids[i].index].TrimEnd(';'));
                    TaskController.TaskLoginGame();
                    Thread.Sleep(5000);
                    TaskController.Buy300Water();
                    Thread.Sleep(1000);

                    UtilitiesBrower.CloseBrower(webDriver);

                }
            });
        }

        private void btnBuy500Water_Click(object sender, EventArgs e)
        {
            Task.Run(() =>
            {
                List<DataGrid> dataGrids = new List<DataGrid>();
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (!row.IsNewRow)
                    {
                        if (row.Cells[0].Value != null)
                        {
                            if (bool.Parse(row.Cells[0].Value.ToString()) == true)
                            {

                                DataGrid dataGrid = new DataGrid();
                                // Lấy dữ liệu từ cột cụ thể, ví dụ cột đầu tiên (index = 0)
                                dataGrid.index = Int32.Parse(row.Cells[1].Value.ToString());
                                dataGrids.Add(dataGrid);

                            }

                        }

                    }
                }
                List<string> lsCookie = new List<string>();
                lsCookie.AddRange(UtilitiesFiles.ReadFiles(Environment.CurrentDirectory + "\\cookie.txt"));
                for (int i = 0; i < dataGrids.Count; i++)
                {
                    webDriver = UtilitiesBrower.OpenBrowser(false, dataGrids[i].index);
                    ControllerAction.login(webDriver, lsCookie[dataGrids[i].index].TrimEnd(';'));
                    TaskController.TaskLoginGame();
                    Thread.Sleep(5000);
                    TaskController.Buy500Water();
                    Thread.Sleep(1000);

                    UtilitiesBrower.CloseBrower(webDriver);

                }
            });
        }

        private void btnBuy1000Water_Click(object sender, EventArgs e)
        {
            Task.Run(() =>
            {
                List<DataGrid> dataGrids = new List<DataGrid>();
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (!row.IsNewRow)
                    {
                        if (row.Cells[0].Value != null)
                        {
                            if (bool.Parse(row.Cells[0].Value.ToString()) == true)
                            {

                                DataGrid dataGrid = new DataGrid();
                                // Lấy dữ liệu từ cột cụ thể, ví dụ cột đầu tiên (index = 0)
                                dataGrid.index = Int32.Parse(row.Cells[1].Value.ToString());
                                dataGrids.Add(dataGrid);

                            }

                        }

                    }
                }
                List<string> lsCookie = new List<string>();
                lsCookie.AddRange(UtilitiesFiles.ReadFiles(Environment.CurrentDirectory + "\\cookie.txt"));
                for (int i = 0; i < dataGrids.Count; i++)
                {
                    webDriver = UtilitiesBrower.OpenBrowser(false, dataGrids[i].index);
                    ControllerAction.login(webDriver, lsCookie[dataGrids[i].index].TrimEnd(';'));
                    TaskController.TaskLoginGame();
                    Thread.Sleep(5000);
                    TaskController.Buy1000Water();
                    Thread.Sleep(1000);

                    UtilitiesBrower.CloseBrower(webDriver);

                }
            });
        }

        private void btn300WaterTheTree_Click(object sender, EventArgs e)
        {
            Task.Run(() =>
            {
                List<DataGrid> dataGrids = new List<DataGrid>();
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (!row.IsNewRow)
                    {
                        if (row.Cells[0].Value != null)
                        {
                            if (bool.Parse(row.Cells[0].Value.ToString()) == true)
                            {

                                DataGrid dataGrid = new DataGrid();
                                // Lấy dữ liệu từ cột cụ thể, ví dụ cột đầu tiên (index = 0)
                                dataGrid.index = Int32.Parse(row.Cells[1].Value.ToString());
                                dataGrids.Add(dataGrid);

                            }

                        }

                    }
                }
                List<string> lsCookie = new List<string>();
                lsCookie.AddRange(UtilitiesFiles.ReadFiles(Environment.CurrentDirectory + "\\cookie.txt"));
                for (int i = 0; i < dataGrids.Count; i++)
                {
                    webDriver = UtilitiesBrower.OpenBrowser(false, dataGrids[i].index);
                    ControllerAction.login(webDriver, lsCookie[dataGrids[i].index].TrimEnd(';'));
                    TaskController.TaskLoginGame();
                    Thread.Sleep(5000);
                    TaskController.Task300WaterTheTree();
                    Thread.Sleep(1000);
                    UtilitiesBrower.CloseBrower(webDriver);
                }
            });
        }

        private void btn500WaterTheTree_Click(object sender, EventArgs e)
        {
            Task.Run(() =>
            {
                List<DataGrid> dataGrids = new List<DataGrid>();
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (!row.IsNewRow)
                    {
                        if (row.Cells[0].Value != null)
                        {
                            if (bool.Parse(row.Cells[0].Value.ToString()) == true)
                            {

                                DataGrid dataGrid = new DataGrid();
                                // Lấy dữ liệu từ cột cụ thể, ví dụ cột đầu tiên (index = 0)
                                dataGrid.index = Int32.Parse(row.Cells[1].Value.ToString());
                                dataGrids.Add(dataGrid);

                            }

                        }

                    }
                }
                List<string> lsCookie = new List<string>();
                lsCookie.AddRange(UtilitiesFiles.ReadFiles(Environment.CurrentDirectory + "\\cookie.txt"));
                for (int i = 0; i < dataGrids.Count; i++)
                {
                    webDriver = UtilitiesBrower.OpenBrowser(false, dataGrids[i].index);
                    ControllerAction.login(webDriver, lsCookie[dataGrids[i].index].TrimEnd(';'));
                    TaskController.TaskLoginGame();
                    Thread.Sleep(5000);
                    TaskController.Task500WaterTheTree();
                    Thread.Sleep(1000);
                    UtilitiesBrower.CloseBrower(webDriver);
                }
            });
        }

        private void btn1000WaterTheTree_Click(object sender, EventArgs e)
        {
            Task.Run(() =>
            {
                List<DataGrid> dataGrids = new List<DataGrid>();
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (!row.IsNewRow)
                    {
                        if (row.Cells[0].Value != null)
                        {
                            if (bool.Parse(row.Cells[0].Value.ToString()) == true)
                            {

                                DataGrid dataGrid = new DataGrid();
                                // Lấy dữ liệu từ cột cụ thể, ví dụ cột đầu tiên (index = 0)
                                dataGrid.index = Int32.Parse(row.Cells[1].Value.ToString());
                                dataGrids.Add(dataGrid);

                            }

                        }

                    }
                }
                List<string> lsCookie = new List<string>();
                lsCookie.AddRange(UtilitiesFiles.ReadFiles(Environment.CurrentDirectory + "\\cookie.txt"));
                for (int i = 0; i < dataGrids.Count; i++)
                {
                    webDriver = UtilitiesBrower.OpenBrowser(false, dataGrids[i].index);
                    ControllerAction.login(webDriver, lsCookie[dataGrids[i].index].TrimEnd(';'));
                    TaskController.TaskLoginGame();
                    Thread.Sleep(5000);
                    TaskController.Task1000WaterTheTree();
                    Thread.Sleep(1000);
                    UtilitiesBrower.CloseBrower(webDriver);
                }
            });
        }

        private void contextMenuStrip1_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {
            dataGridView1.EndEdit();
        }

        private void aLLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (!row.IsNewRow)
                {
                    row.Cells[0].Value = true;
                }
            }
        }

        private void hightlightToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<DataGridViewRow> selectRows = new List<DataGridViewRow>();
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                selectRows.Add(row);
            }
            foreach (DataGridViewRow row in selectRows)
            {
                row.Cells[0].Value = true;
            }
        }

        private void uncheckedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (!row.IsNewRow)
                {
                    row.Cells[0].Value = false;
                }
            }
        }

        private void btnClaimGift_Click(object sender, EventArgs e)
        {
            Task.Run(() =>
            {
                List<DataGrid> dataGrids = new List<DataGrid>();
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (!row.IsNewRow)
                    {
                        if (row.Cells[0].Value != null)
                        {
                            if (bool.Parse(row.Cells[0].Value.ToString()) == true)
                            {

                                DataGrid dataGrid = new DataGrid();
                                // Lấy dữ liệu từ cột cụ thể, ví dụ cột đầu tiên (index = 0)
                                dataGrid.index = Int32.Parse(row.Cells[1].Value.ToString());
                                dataGrids.Add(dataGrid);

                            }

                        }

                    }
                }
                List<string> lsCookie = new List<string>();
                lsCookie.AddRange(UtilitiesFiles.ReadFiles(Environment.CurrentDirectory + "\\cookie.txt"));
                for (int i = 0; i < dataGrids.Count; i++)
                {
                    webDriver = UtilitiesBrower.OpenBrowser(false, dataGrids[i].index);
                    ControllerAction.login(webDriver, lsCookie[dataGrids[i].index].TrimEnd(';'));
                    TaskController.TaskLoginGame();
                    Thread.Sleep(5000);
                    TaskController.ClaimGift();
                    Thread.Sleep(1000);
                    UtilitiesBrower.CloseBrower(webDriver);
                }
            });

        }

        private void BtnLoop20Water_Click(object sender, EventArgs e)
        {
            TaskController.FlagStop = false;
            Task.Run(() =>
            {
                List<DataGrid> dataGrids = new List<DataGrid>();
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (!row.IsNewRow)
                    {
                        if (row.Cells[0].Value != null)
                        {
                            if (bool.Parse(row.Cells[0].Value.ToString()) == true)
                            {

                                DataGrid dataGrid = new DataGrid();
                                // Lấy dữ liệu từ cột cụ thể, ví dụ cột đầu tiên (index = 0)
                                dataGrid.index = Int32.Parse(row.Cells[1].Value.ToString());
                                dataGrids.Add(dataGrid);

                            }

                        }

                    }
                }
                if (dataGrids.Count > 1)
                {
                    MessageBox.Show("Only One");
                    return;
                }
                if (txtTimeWater.Text == "")
                {
                    MessageBox.Show("Only One");
                    return;
                }
                int time = Convert.ToInt32(txtTimeWater.Text);
                int loop = Convert.ToInt32(txtLoop.Text);
                List<string> lsCookie = new List<string>();
                lsCookie.AddRange(UtilitiesFiles.ReadFiles(Environment.CurrentDirectory + "\\cookie.txt"));
                for (int i = 0; i < dataGrids.Count; i++)
                {
                    webDriver = UtilitiesBrower.OpenBrowser(false, dataGrids[i].index);
                    ControllerAction.login(webDriver, lsCookie[dataGrids[i].index].TrimEnd(';'));
                    TaskController.TaskLoginGame();
                    Thread.Sleep(5000);
                    TaskController.Task20WaterTheTree(time, loop);
                    Thread.Sleep(1000);
                    UtilitiesBrower.CloseBrower(webDriver);
                }
            });
        }

        private void btnGiftToFriend_Click(object sender, EventArgs e)
        {
            Task.Run(() =>
            {
                List<DataGrid> dataGrids = new List<DataGrid>();
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (!row.IsNewRow)
                    {
                        if (row.Cells[0].Value != null)
                        {
                            if (bool.Parse(row.Cells[0].Value.ToString()) == true)
                            {

                                DataGrid dataGrid = new DataGrid();
                                // Lấy dữ liệu từ cột cụ thể, ví dụ cột đầu tiên (index = 0)
                                dataGrid.index = Int32.Parse(row.Cells[1].Value.ToString());
                                dataGrids.Add(dataGrid);

                            }

                        }

                    }
                }
                List<string> lsCookie = new List<string>();
                lsCookie.AddRange(UtilitiesFiles.ReadFiles(Environment.CurrentDirectory + "\\cookie.txt"));
                for (int i = 0; i < dataGrids.Count; i++)
                {
                    webDriver = UtilitiesBrower.OpenBrowser(false, dataGrids[i].index);
                  bool check =  ControllerAction.login(webDriver, lsCookie[dataGrids[i].index].TrimEnd(';'));
                    if (!check)
                    {
                        UtilitiesBrower.CloseBrower(webDriver);
                        continue;
                    }
                    TaskController.TaskLoginGame();
                    Thread.Sleep(5000);
                    TaskController.GiftoFriend();
                    Thread.Sleep(1000);
                     UtilitiesBrower.CloseBrower(webDriver);

                }
            });

        }

        private void btnC3_Click(object sender, EventArgs e)
        {
            TaskController.FlagStop = false;
            Task.Run(() =>
            {
                List<DataGrid> dataGrids = new List<DataGrid>();
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (!row.IsNewRow)
                    {
                        if (row.Cells[0].Value != null)
                        {
                            if (bool.Parse(row.Cells[0].Value.ToString()) == true)
                            {

                                DataGrid dataGrid = new DataGrid();
                                // Lấy dữ liệu từ cột cụ thể, ví dụ cột đầu tiên (index = 0)
                                dataGrid.index = Int32.Parse(row.Cells[1].Value.ToString());
                                dataGrids.Add(dataGrid);

                            }

                        }

                    }
                }
                if (dataGrids.Count > 1)
                {
                    MessageBox.Show("Only One");
                    return;
                }
                List<string> lsCookie = new List<string>();
                lsCookie.AddRange(UtilitiesFiles.ReadFiles(Environment.CurrentDirectory + "\\cookie.txt"));
                for (int i = 0; i < dataGrids.Count; i++)
                {
                    webDriver = UtilitiesBrower.OpenBrowser(false, dataGrids[i].index);
                    ControllerAction.login(webDriver, lsCookie[dataGrids[i].index].TrimEnd(';'));
                    TaskController.TaskLoginGame();
                    Thread.Sleep(1000);
                    TaskController.C3();
                    Thread.Sleep(1000);
                    UtilitiesBrower.CloseBrower(webDriver);
                }
            });
        }

        private void btnStop_Click_1(object sender, EventArgs e)
        {
            TaskController.FlagStop = true;
        }
    }
}
