﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab10 {
    public partial class Form1 : Form {
        DataView dataView;
        DataTable table;
        MyData myData;

        public Form1() {
            InitializeComponent();
        }

        private void CreateTable_Click(object sender, EventArgs e) {
            table = new DataTable();
            table.Columns.Add(new DataColumn() {
                ColumnName = "teacher_id",
                DataType = Type.GetType("System.Int32"),
                AutoIncrement = true,
                AutoIncrementSeed = 0,
                AutoIncrementStep = 1
            });
            table.Columns.Add(new DataColumn() {
                ColumnName = "name",
                DataType = System.Type.GetType("System.String")
            });

            DataRow row1 = table.NewRow();
            row1[table.Columns[1].ColumnName] = "Петров Петр";
            table.Rows.Add(row1);

            DataRow row2 = table.NewRow();
            row2[table.Columns[1].ColumnName] = "Иванов Анатолий";
            table.Rows.Add(row2);

            dataView = table.DefaultView;
            dataGridView1.DataSource = table;

            CreateTable.Enabled = false;

            myData = new MyData();
            dataGridView2.DataSource = myData;
            dataGridView2.DataMember = "Order";

            dataGridView3.DataSource = myData;
            dataGridView3.DataMember = "OrderLines";

        }

        private void ValueRow_Click(object sender, EventArgs e) {
            MessageBox.Show("id = " + dataGridView1.CurrentRow.Cells[0].Value.ToString() +
                            "\nname = " + dataGridView1.CurrentRow.Cells[1].Value.ToString());
        }

        private void Form1_Load(object sender, EventArgs e) {
        }

        private void SortedButton_Click(object sender, EventArgs e) {
            dataView.Sort = sortedTextBox.Text;
        }

        private void button1_Click(object sender, EventArgs e) {
            dataView.RowFilter = FilterTextBox.Text;
        }

        private void button2_Click(object sender, EventArgs e) {
            myData.WriteXml("XMLSChema.xml", XmlWriteMode.WriteSchema);
            MessageBox.Show("Запись выполнена");
        }

        private void button3_Click(object sender, EventArgs e) {
            myData.ReadXml("XMLSChema.xml", XmlReadMode.IgnoreSchema);
            MessageBox.Show("Чтение выполнено");
            // ежели датасет уже содержит структуру (таблицы, связи, ограничения),
            // то импортировать данные нужно с игнорированием существующей в хмл-файле схемы (если она в нем(в файле) присутствует)
        }
    }
}
