using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Service;
using Logic;
using Model;

namespace UI
{
    public partial class TableForm : Form
    {
        private Logic.TableService tableService;


        private List<Table> tableList;
        private List<Button> buttonList;

        public TableForm()
        {
            InitializeComponent();

            buttonList = new List<Button>();
            buttonList.Add(btnTable1);
            buttonList.Add(btnTable2);
            buttonList.Add(btnTable3);
            buttonList.Add(btnTable4);
            buttonList.Add(btnTable5);
            buttonList.Add(btnTable6);
            buttonList.Add(btnTable7);
            buttonList.Add(btnTable8);
            buttonList.Add(btnTable9);
            buttonList.Add(btnTable10);

            TableStatus();
        }

        private void TableStatus()
        {
            tableList = new List<Table>();
            tableService = new Logic.TableService();

            tableList = tableService.GetTableData();

            for (int i = 0; i < tableList.Count; i++)
            {
                if (tableList[i].TableStatus == 0)
                    buttonList[i].BackColor = Color.LightGray;
                else if (tableList[i].TableStatus == 1)
                    buttonList[i].BackColor = Color.CornflowerBlue;
                else
                    buttonList[i].BackColor = Color.Gold;
            }
        }


        private void button7_Click(object sender, EventArgs e)
        {

        }
    }
}
