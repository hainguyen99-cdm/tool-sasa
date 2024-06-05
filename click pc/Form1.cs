using click_pc.Controller;
using click_pc.Helpper;
using click_pc.Service;
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

            //Task.Run(async () =>
            //{
            //    while (true)
            //    {
            //        await HarvestServices.GetTokenHH();
            //        string token = await HarvestServices.LoginGame();
            //        await Task.Delay(1000);
            //        await HarvestServices.Defen(token);
            //        await Task.Delay(60000);
            //    }

            //});
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
                    webDriver = UtilitiesBrower.OpenBrowser(false, 1);

                    //ControllerAction.login(webDriver, lsCookie[dataGrids[i].index].TrimEnd(';'));
                    //TaskController.TaskLoginGame();
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



        private void btnStop_Click_1(object sender, EventArgs e)
        {
            TaskController.FlagStop = true;
        }

        private async void btnYescoins_Click(object sender, EventArgs e)
        {
            await Task.Run(async () =>
            {
                List<string> lsToken = new List<string>();
                lsToken.AddRange(UtilitiesFiles.ReadFiles(Environment.CurrentDirectory + "\\yescointoken.txt"));
                List<Task> ls = new List<Task>();
                foreach (string token in lsToken)
                {
                    Task task1 = Task.Run(async () =>
                 {
                     await Yescoin.Yescoins(richTextBox2, token);


                 });
                    ls.Add(task1);
                }

                await Task.WhenAll(ls);
            });

        }
        private static readonly Object obj = new Object();
        private async void btnQuack_Click(object sender, EventArgs e)
        {
            await Task.Run(async () =>
            {
                try
                {
                    List<Task> ls = new List<Task>();

                    List<string> lsToken = new List<string>();
                    lsToken.AddRange(UtilitiesFiles.ReadFiles(Environment.CurrentDirectory + "\\quacktoken.txt"));
                    foreach (string token in lsToken)
                    {

                        Task task1 = Task.Run(async () =>
                    {


                        QuackQuack.MainClaim(token, richTextBox1);
                    });
                        ls.Add(task1);

                    }
                    await Task.WhenAll(ls);
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex.Message);
                }
            });

        }

        private async void btnCapa_Click(object sender, EventArgs e)
        {
            await Task.Run(async () =>
            {
                try
                {
                    List<Task> ls = new List<Task>();

                    List<string> lsToken = new List<string>();
                    lsToken.AddRange(UtilitiesFiles.ReadFiles(Environment.CurrentDirectory + "\\cappatoken.txt"));
                    foreach (string token in lsToken)
                    {

                        Task task1 = Task.Run(async () =>
                        {


                            await Cappa.Cappacoin(richTextBox3, token);
                        });
                        ls.Add(task1);

                    }
                    await Task.WhenAll(ls);
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex.Message);
                }
            });
        }

        private async void btnChickCoop_Click(object sender, EventArgs e)
        {
            await Task.Run(async () =>
            {
                try
                {
                    List<Task> ls = new List<Task>();

                    List<string> lsToken = new List<string>();
                    lsToken.AddRange(UtilitiesFiles.ReadFiles(Environment.CurrentDirectory + "\\chickcooptoken.txt"));

                    foreach (string token in lsToken)
                    {

                        Task task1 = Task.Run(async () =>
                        {


                            await Chickcoop.Chickcoops(richTextBox4, token);
                        });
                        ls.Add(task1);

                    }
                    await Task.WhenAll(ls);
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex.Message);
                }
            });
        }

        private async void btnmemefi_Click(object sender, EventArgs e)
        {
            await Task.Run(async () =>
            {
                try
                {
                    List<Task> ls = new List<Task>();

                    List<string> lsToken = new List<string>();
                    lsToken.AddRange(UtilitiesFiles.ReadFiles(Environment.CurrentDirectory + "\\tokencell.txt"));


                    foreach (string token in lsToken)
                    {

                        Task task1 = Task.Run(async () =>
                        {


                            await Cell.CelllToken(richTextBox5, token);
                        });
                        ls.Add(task1);

                    }
                    await Task.WhenAll(ls);
                }

                catch (Exception ex)
                {
                    Debug.WriteLine(ex.Message);
                }
            });
        }

        private async void btnPrick_Click(object sender, EventArgs e)
        {
            //await prick.ClaimPrick();
            //await POP.GetPowPOP();
            string token = await HarvestServices.LoginGame();
            await HarvestServices.Defen(token, richTextBox6);
        }

        private async void btnpixelversexyz_Click(object sender, EventArgs e)
        {
            await Task.Run(async () =>
            {
               await pixelversexyz.Boxing(richTextBox7);
            });
        }
    }
}
