using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hierarchy;

namespace HierarchyBuilder
{
    public partial class ItemPrice : Form
    {
        MainForm owner;
        Node node;

        private String cellDataBeforeChanging = "0";

        public ItemPrice(ref Node _node, ref List<Criterion> _criteria)
        {
            InitializeComponent();

            owner = this.Owner as MainForm;

            node = _node;

            string[] criteria = criteriaString();
            string[] nodes = nodesString();

            dataGridViewTable.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.Fill);
            dataGridViewTable.AutoResizeRows(DataGridViewAutoSizeRowsMode.AllCells);


            dataGridViewTable.Columns.Add("Критерий", "Критерий");
            dataGridViewTable.Columns.Add(criteria.Length.ToString(), "Вес элемента");

            dataGridViewTable.Rows.Add("Вес критерия ->");
            for (int i = 0; i < nodes.Length; i++)
                dataGridViewTable.Rows.Add(nodes[i]);
            dataGridViewTable.Rows.Add("Сумма весов (=1)");

            foreach (Criterion c in _criteria)
            {
                listBoxCriteria.Items.Add(c.data);
            }
            setZero();
        }

        string[] criteriaString()
        {
            string[] criteriaString = new string[MainForm.criteria.Count];
            for (int i = 0; i < MainForm.criteria.Count; i++)
            {
                criteriaString[i] = MainForm.criteria[i].data;
            }
            return criteriaString;
        }

        string[] nodesString()
        {
            string[] nodesString = new string[node.ChildrenCount()];
            for (int i = 0; i < node.ChildrenCount(); i++)
            {
                nodesString[i] = node[i].Data;
            }
            return nodesString;
        }

        private void buttonChoice_Click(object sender, EventArgs e)
        {

            if (listBoxCriteria.SelectedIndex >= 0)
            {
                if (!dataGridViewTable.Columns.Contains(listBoxCriteria.SelectedItem.ToString() + " "))
                {
                    DataGridViewTextBoxColumn Column = new DataGridViewTextBoxColumn();
                    Column.Name = listBoxCriteria.Items[listBoxCriteria.SelectedIndex].ToString() + " ";
                    Column.HeaderText = listBoxCriteria.Items[listBoxCriteria.SelectedIndex].ToString() + " ";
                    Column.ReadOnly = false;

                    dataGridViewTable.Columns.Insert(dataGridViewTable.ColumnCount - 1, Column);

                    setZero(dataGridViewTable.ColumnCount - 2);
                }


                listBoxCriteria.Items.RemoveAt(listBoxCriteria.SelectedIndex);
                if (listBoxCriteria.SelectedIndex + 1 != listBoxCriteria.Items.Count)
                    listBoxCriteria.SelectedIndex++;

            }
            int lastColumnIndex = dataGridViewTable.Columns.Count - 1;
            int lastRowIndex = nodesString().Length + 1;
            dataGridViewTable.Columns[0].ReadOnly = true;
            dataGridViewTable.Columns[lastColumnIndex].ReadOnly = true;
            dataGridViewTable.Rows[lastRowIndex].ReadOnly = true;

            dataGridViewTable.Refresh();
        }

        private void setZero(int columnIndex = -1)
        {
            for (int j = 0; j < dataGridViewTable.RowCount; j++)
            {
                if (columnIndex == -1)
                {
                    for (int i = 1; i < dataGridViewTable.ColumnCount; i++)
                        dataGridViewTable[i, j].Value = 0.ToString();
                }
                else
                {
                    for (int i = 1; i < dataGridViewTable.ColumnCount; i++)
                        dataGridViewTable[columnIndex, j].Value = 0.ToString();
                }
            }
        }

        private void calculate()
        {

            double[] tempArrCol = new double[dataGridViewTable.RowCount - 1];
            double[] tempArrRow = new double[dataGridViewTable.ColumnCount - 1];

            for (int i = 1; i < dataGridViewTable.ColumnCount - 1; i++)
            {
                for (int j = 0; j < dataGridViewTable.RowCount - 1; j++)
                {
                    tempArrCol[j] = Double.Parse(dataGridViewTable[i, j].Value.ToString());
                }

                double sum = 0;
                for (int j = 1; j < dataGridViewTable.RowCount - 1; j++)
                    sum += tempArrCol[j];

                if (sum > 1)
                {
                    for (int j = 1; j < dataGridViewTable.RowCount - 1; j++)
                    {
                        tempArrCol[j] /= sum;
                        dataGridViewTable[i, j].Value = Math.Round(Double.Parse(tempArrCol[j].ToString()), 2).ToString();
                    }

                    dataGridViewTable[i, dataGridViewTable.RowCount - 1].Value = 1.ToString();
                }
                else
                {
                    dataGridViewTable[i, dataGridViewTable.RowCount - 1].Value = Math.Round(Double.Parse(sum.ToString()), 2).ToString();
                }
            }


            double sumWeight = 0;

            for (int i = 1; i < dataGridViewTable.ColumnCount - 1; i++)
            {
                sumWeight += Double.Parse(dataGridViewTable[i, 0].Value.ToString());
            }

            if (sumWeight > 1)
            {
                for (int i = 1; i < dataGridViewTable.ColumnCount - 1; i++)
                {
                    dataGridViewTable[i, 0].Value = Math.Round(Double.Parse(dataGridViewTable[i, 0].Value.ToString()) / sumWeight, 2).ToString();
                }
                dataGridViewTable[dataGridViewTable.ColumnCount - 1, 0].Value = 1.ToString();
            }
            else
            {
                dataGridViewTable[dataGridViewTable.ColumnCount - 1, 0].Value = Math.Round(Double.Parse(sumWeight.ToString()), 2).ToString();
            }

            sumWeight = 0;

            for (int i = 1; i < dataGridViewTable.ColumnCount - 1; i++)
            {
                sumWeight += Double.Parse(dataGridViewTable[i, dataGridViewTable.RowCount - 1].Value.ToString());
            }

            sumWeight /= (dataGridViewTable.ColumnCount - 2);

            if (sumWeight > 1)
            {
                for (int i = 1; i < dataGridViewTable.ColumnCount - 1; i++)
                {
                    dataGridViewTable[i, dataGridViewTable.RowCount - 1].Value = Math.Round(Double.Parse(dataGridViewTable[i, dataGridViewTable.RowCount - 1].Value.ToString()) / sumWeight, 2).ToString();
                }

                dataGridViewTable[dataGridViewTable.ColumnCount - 1, dataGridViewTable.RowCount - 1].Value = 1.ToString();
            }
            else
            {
                dataGridViewTable[dataGridViewTable.ColumnCount - 1, dataGridViewTable.RowCount - 1].Value = Math.Round(Double.Parse(sumWeight.ToString()), 2).ToString();
            }


            for (int j = 1; j < dataGridViewTable.RowCount - 1; j++)
            {
                for (int i = 1; i < dataGridViewTable.ColumnCount - 1; i++)
                {
                    tempArrRow[i] = Double.Parse(dataGridViewTable[i, j].Value.ToString());
                }

                double result = 0;
                for (int i = 1; i < tempArrRow.Length; i++)
                {
                    result += tempArrRow[i] * (Double.Parse(dataGridViewTable[i, 0].Value.ToString()));
                }

                dataGridViewTable[dataGridViewTable.ColumnCount - 1, j].Value = Math.Round(Double.Parse(result.ToString()), 2).ToString();

            }
        }

        private void buttonSolve_Click(object sender, EventArgs e)
        {
            calculate();
        }

        private void dataGridViewTable_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.ColumnIndex; int j = e.RowIndex;

            if (dataGridViewTable[i, j].Value == DBNull.Value || dataGridViewTable[i, j].Value == null || String.IsNullOrWhiteSpace(dataGridViewTable[i, j].Value.ToString()))
            {
                dataGridViewTable[i, j].Value = cellDataBeforeChanging;
                return;
            }

            String sTemp = dataGridViewTable[i, j].Value.ToString();

            sTemp = sTemp.Replace('.', ',');

            Double dTemp;

            if (!Double.TryParse(sTemp, out dTemp))
            {
                dataGridViewTable[i, j].Value = cellDataBeforeChanging;
                return;
            }


            dataGridViewTable[i, j].Value = Math.Round(Double.Parse(sTemp), 2).ToString();
        }

        private void dataGridViewTable_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            int i = e.ColumnIndex; int j = e.RowIndex;
            cellDataBeforeChanging = dataGridViewTable[i, j].Value.ToString();
        }

        private void listBoxCriteria_DoubleClick(object sender, EventArgs e)
        {
            if (listBoxCriteria.SelectedIndex >= 0)
            {
                if (!dataGridViewTable.Columns.Contains(listBoxCriteria.SelectedItem.ToString() + " "))
                {
                    DataGridViewTextBoxColumn Column = new DataGridViewTextBoxColumn();
                    Column.Name = listBoxCriteria.Items[listBoxCriteria.SelectedIndex].ToString() + " ";
                    Column.HeaderText = listBoxCriteria.Items[listBoxCriteria.SelectedIndex].ToString() + " ";
                    Column.ReadOnly = false;

                    dataGridViewTable.Columns.Insert(dataGridViewTable.ColumnCount - 1, Column);

                    setZero(dataGridViewTable.ColumnCount - 2);
                }


                listBoxCriteria.Items.RemoveAt(listBoxCriteria.SelectedIndex);
                if (listBoxCriteria.SelectedIndex + 1 != listBoxCriteria.Items.Count)
                    listBoxCriteria.SelectedIndex++;

            }
            int lastColumnIndex = dataGridViewTable.Columns.Count - 1;
            int lastRowIndex = nodesString().Length + 1;
            dataGridViewTable.Columns[0].ReadOnly = true;
            dataGridViewTable.Columns[lastColumnIndex].ReadOnly = true;
            dataGridViewTable.Rows[lastRowIndex].ReadOnly = true;

            dataGridViewTable.Refresh();
        }

        private void buttonSaveCalculations_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < node.ChildrenCount(); i++)
            {
                node[i].element.weight = Double.Parse(dataGridViewTable[dataGridViewTable.ColumnCount - 1, i + 1].Value.ToString());
            }
        }
    }
}
