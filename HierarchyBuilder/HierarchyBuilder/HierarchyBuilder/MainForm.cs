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
    public partial class MainForm : Form
    {
        class NodeStruct
        {
            public NodeStruct(Node _node, TreeNode _treeNode) { node = _node; treeNode = _treeNode; }
            public Node node;
            public TreeNode treeNode;
        }

        Node mainNode;
        TreeNode rootNode;

        Node currentNode;
        int currentNodeIndex;

        List<List<Node>> nodeList;
        List<NodeStruct> nodeStruct;

        int currentLevel = 0;

        public static List<Criterion> criteria = new List<Criterion>();

        string[][] koshargskyUemovCyclesAndObjects = new string[2][];
        string[] koshargskyUemovLevels = new string[] { "Циклы управления", "Объекты управления" };

        List<List<string>> levelsList; // Элементы всех уровней

        List<List<string>> elementsByLevels; //Элементы пренадлежащие конкретному уровню
        string[] levels;    //Уровни

        public static List<Criterion> criterionList = new List<Criterion>();

        public MainForm()
        {
            InitializeComponent();

            radioButtonKoshargskyUemov.Select();

            koshargskyUemovCyclesAndObjects[0] = new string[] {"Оперативное управление (ОУ)", "Организация(ОРГ)", "Преспективное планирование(ПЛ)",
                                                                  "Прогнозирование(ПР)", "Текущее планирование(ТП)", "Учет, Контроль, Анализ(УКА)"};

            koshargskyUemovCyclesAndObjects[1] = new string[] {"Вспомогательное производство (ВП)", "Материально - техническое снабжение(МТС)", "Научно - исследовательская работа(НИР)",
                                                                  "Основное производство(ОП)", "Сбыт продукции(СбП)", "Транспорт(Т)", "Трудовые ресурсы(К)", "Финансы(Ф)"};
            nodeList = new List<List<Node>>();
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            if (tabControl.SelectedIndex == 0)
            {
                if (!String.IsNullOrWhiteSpace(textBoxMainTarget.Text))
                {
                    mainNode = new Node(textBoxMainTarget.Text);
                    mainNode.element.weight = 1;

                    if (radioButtonKoshargskyUemov.Checked)
                    {
                        elementsByLevels = new List<List<string>>();
                        for (int i = 0; i < koshargskyUemovCyclesAndObjects.Length; i++)
                            elementsByLevels.Add(new List<string>(koshargskyUemovCyclesAndObjects[i]));

                        levels = koshargskyUemovLevels;

                        tabControl.SelectedIndex += 2;

                        levelsList = new List<List<string>>();
                        for (int i = 0; i < levels.Length; i++)
                            levelsList.Add(new List<string>());

                        for (int i = 0; i < levels.Length; i++)
                            nodeList.Add(new List<Node>());

                        int w = labelLevels.Width;
                        labelLevels.Text = "Элементы уровня \"" + levels[currentLevel] + "\"";
                        labelLevels.Location = new Point(labelLevels.Location.X - labelLevels.Width + w, labelLevels.Location.Y);
                        listBoxLevelsStandart.Items.AddRange(elementsByLevels[currentLevel].ToArray());
                    } else if (radioButtonVoluntaryModel.Checked)
                    {
                        listBoxLevelsStandart.Enabled = false;
                        buttonLevelsAdd.Enabled = false;
                        buttonLevelsAddAll.Enabled = false;
                        tabControl.SelectedIndex++;
                    }
                }
                else
                {
                    MessageBox.Show("Введите цель", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            } else if (tabControl.SelectedIndex == 1)
            {
                if (listBoxVoluntaryLevels.Items.Count < 1)
                {
                    MessageBox.Show("Вы должны добавить хотя бы один уровень", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    levels = new string[listBoxVoluntaryLevels.Items.Count];

                    for (int i = 0; i < levels.Length; i++)
                        nodeList.Add(new List<Node>());

                    levelsList = new List<List<string>>();
                    elementsByLevels = new List<List<string>>();
                    for (int i = 0; i < levels.Length; i++)
                    {
                        elementsByLevels.Add(new List<string>());
                        levelsList.Add(new List<string>());
                    }

                    for (int i = 0; i < listBoxVoluntaryLevels.Items.Count; i++)
                    {
                        levels[i] = listBoxVoluntaryLevels.Items[i].ToString();
                    }

                    listBoxVoluntaryLevels.Items.Clear();

                    int w = labelLevels.Width;
                    labelLevels.Text = "Элементы уровня \"" + levels[currentLevel] + "\"";
                    labelLevels.Location = new Point(labelLevels.Location.X - labelLevels.Width + w, labelLevels.Location.Y);

                    tabControl.SelectedIndex++;
                }

            } else if (tabControl.SelectedIndex == 2)
            {
                if (listBoxLevelsUser.Items.Count == 0)
                {
                    MessageBox.Show("На уровне должен присутствовать хотя бы один элемент", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                } else
                {
                    if (currentLevel < levels.Length - 1)
                    {
                        int end = listBoxLevelsUser.Items.Count;

                        for (int i = 0; i < end; i++)
                        {
                            levelsList[currentLevel].Add(listBoxLevelsUser.Items[0].ToString());
                            listBoxLevelsUser.Items.RemoveAt(0);
                        }

                        currentLevel++;

                        int w = labelLevels.Width;
                        labelLevels.Text = "Элементы уровня \"" + levels[currentLevel] + "\"";
                        labelLevels.Location = new Point(labelLevels.Location.X - labelLevels.Width + w, labelLevels.Location.Y);

                        if (!radioButtonVoluntaryModel.Checked)
                        {
                            listBoxLevelsStandart.Items.Clear();
                            listBoxLevelsStandart.Items.AddRange(elementsByLevels[currentLevel].ToArray());
                        }  
                    }
                    else
                    {
                        int end = listBoxLevelsUser.Items.Count;

                        for (int i = 0; i < end; i++)
                        {
                            levelsList[currentLevel].Add(listBoxLevelsUser.Items[0].ToString());
                            listBoxLevelsUser.Items.RemoveAt(0);
                        }

                        mainNode.AddChildren(levelsList[0].ToArray());

                        for (int i = 0; i < mainNode.ChildrenCount(); i++)
                            nodeList[0].Add(mainNode[i]);

                        currentNodeIndex = 0;
                        currentLevel = 1;
                        currentNode = nodeList[currentLevel - 1][currentNodeIndex];

                        tabControl.SelectedIndex++;
                        
                        labelConnectionsCurrentConnection.Text = "Связи для \"" + currentNode.Data + "\"";

                        listBoxConnectionsAvailable.Items.AddRange(levelsList[currentLevel].ToArray());
                    }
                }

            } else if (tabControl.SelectedIndex == 3)
            {
                nodesRefresh();

                tabControl.SelectedIndex++;

            } else if (tabControl.SelectedIndex == 4)
            {
                var hierarchy = Node.GetHierarchy(mainNode);

                var hierarchyString = Node.ListIntoStringArray(hierarchy);

                Draw();
                buttonSavePicture.Enabled = true;
                buttonSavePicture.Visible = true;
                buttonNext.Enabled = false;
                buttonBack.Enabled = true;
                buttonBack.Visible = true;

                tabControl.SelectedIndex++;
            }
        }

        private void buttonLevelsAdd_Click(object sender, EventArgs e)
        {
            if (listBoxLevelsStandart.SelectedIndex >= 0)
            {
                listBoxLevelsUser.Items.Insert(0, listBoxLevelsStandart.Items[listBoxLevelsStandart.SelectedIndex]);
                listBoxLevelsStandart.Items.RemoveAt(listBoxLevelsStandart.SelectedIndex);
            }
        }

        private void buttonLevelsAddAll_Click(object sender, EventArgs e)
        {
            int end = listBoxLevelsStandart.Items.Count;

            for (int i = 0; i < end; i++)
            {
                listBoxLevelsUser.Items.Insert(0, listBoxLevelsStandart.Items[0]);
                listBoxLevelsStandart.Items.RemoveAt(0);
            }
        }

        private void buttonLevelsRemove_Click(object sender, EventArgs e)
        {
            if (listBoxLevelsUser.SelectedIndex >= 0)
            {
                if (!radioButtonVoluntaryModel.Checked)
                {
                    listBoxLevelsStandart.Items.Insert(0, listBoxLevelsUser.Items[listBoxLevelsUser.SelectedIndex]);
                }
                listBoxLevelsUser.Items.RemoveAt(listBoxLevelsUser.SelectedIndex);
            }
        }

        private void buttonLevelsRemoveAll_Click(object sender, EventArgs e)
        {
            int end = listBoxLevelsUser.Items.Count;
            for (int i = 0; i < end; i++)
            {
                if (!radioButtonVoluntaryModel.Checked)
                {
                    listBoxLevelsStandart.Items.Insert(0, listBoxLevelsUser.Items[0]);
                }
                listBoxLevelsUser.Items.RemoveAt(0);
            }
        }

        private void buttonLevelsAddUserLvl_Click(object sender, EventArgs e)
        {
            if (!listBoxLevelsUser.Items.Contains(textBoxLevelsUserLvl.Text.Trim()) && 
                !listBoxLevelsStandart.Items.Contains(textBoxLevelsUserLvl.Text.Trim()) &&
                !String.IsNullOrWhiteSpace(textBoxLevelsUserLvl.Text.Trim()))
                listBoxLevelsUser.Items.Add(textBoxLevelsUserLvl.Text.Trim());
            textBoxLevelsUserLvl.Clear();
        }

        private void buttonConnectionsConfirm_Click(object sender, EventArgs e) 
        {
            int end = listBoxConnectionsAdded.Items.Count;
            for (int i = 0; i < end; i++)
            {
                nodeList[currentLevel].Add(currentNode.AddChild(listBoxConnectionsAdded.Items[0].ToString()));
                listBoxConnectionsAdded.Items.RemoveAt(0);
            }

            currentNodeIndex++;
            
            if (currentNodeIndex == nodeList[currentLevel - 1].Count)
            {
                currentNode = nodeList[currentLevel][0];

                currentNodeIndex = 0;
                currentLevel++;
            } else
            {
                currentNode = nodeList[currentLevel-1][currentNodeIndex];
            }

            listBoxConnectionsAvailable.Items.Clear();
            
            if (currentLevel == levels.Length)
            {
                buttonConnectionsConfirm.Enabled = false;
            } else
            {
                labelConnectionsCurrentConnection.Text = "Связи для \"" + currentNode.Data + "\"";
                listBoxConnectionsAvailable.Items.AddRange(levelsList[currentLevel].ToArray());
            }
        }

        private void buttonConnectionsAdd_Click(object sender, EventArgs e)
        {
            if (listBoxConnectionsAvailable.SelectedIndex >= 0)
            {
                listBoxConnectionsAdded.Items.Insert(0, listBoxConnectionsAvailable.Items[listBoxConnectionsAvailable.SelectedIndex]);
                listBoxConnectionsAvailable.Items.RemoveAt(listBoxConnectionsAvailable.SelectedIndex);
            }
        }

        private void buttonConnectionsAddAll_Click(object sender, EventArgs e)
        {
            int end = listBoxConnectionsAvailable.Items.Count;

            for (int i = 0; i < end; i++)
            {
                listBoxConnectionsAdded.Items.Insert(0, listBoxConnectionsAvailable.Items[0]);
                listBoxConnectionsAvailable.Items.RemoveAt(0);
            }
        }

        private void buttonConnectionsRemove_Click(object sender, EventArgs e)
        {
            if (listBoxConnectionsAdded.SelectedIndex >= 0)
            {
                listBoxConnectionsAvailable.Items.Insert(0, listBoxConnectionsAdded.Items[listBoxConnectionsAdded.SelectedIndex]);
                listBoxConnectionsAdded.Items.RemoveAt(listBoxConnectionsAdded.SelectedIndex);
            }
        }

        private void buttonConnectionsRemoveAll_Click(object sender, EventArgs e)
        {
            int end = listBoxConnectionsAdded.Items.Count;

            for (int i = 0; i < end; i++)
            {
                listBoxConnectionsAvailable.Items.Insert(0, listBoxConnectionsAdded.Items[0]);
                listBoxConnectionsAdded.Items.RemoveAt(0);
            }
        }

        private void buttonAddLevel_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(textBoxVoluntaryLevel.Text.Trim()))
            {
                if (!listBoxVoluntaryLevels.Items.Contains(textBoxVoluntaryLevel.Text.Trim()))
                    listBoxVoluntaryLevels.Items.Add(textBoxVoluntaryLevel.Text.Trim());
            }

            textBoxVoluntaryLevel.Clear();
        }

        private void buttonRemoveLevel_Click(object sender, EventArgs e)
        {
            if (listBoxVoluntaryLevels.SelectedIndex >= 0)
            {
                listBoxVoluntaryLevels.Items.RemoveAt(listBoxVoluntaryLevels.SelectedIndex);
            }
        }

        private void listBoxLevelsStandart_DoubleClick(object sender, EventArgs e)
        {
            if (listBoxLevelsStandart.SelectedIndex >= 0)
            {
                listBoxLevelsUser.Items.Insert(0, listBoxLevelsStandart.Items[listBoxLevelsStandart.SelectedIndex]);
                listBoxLevelsStandart.Items.RemoveAt(listBoxLevelsStandart.SelectedIndex);
            }
        }

        private void listBoxLevelsUser_DoubleClick(object sender, EventArgs e)
        {
            if (listBoxLevelsUser.SelectedIndex >= 0)
            {
                if (!radioButtonVoluntaryModel.Checked)
                {
                    listBoxLevelsStandart.Items.Insert(0, listBoxLevelsUser.Items[listBoxLevelsUser.SelectedIndex]);
                }
                listBoxLevelsUser.Items.RemoveAt(listBoxLevelsUser.SelectedIndex);
            }
        }

        private void listBoxConnectionsAvailable_DoubleClick(object sender, EventArgs e)
        {
            if (listBoxConnectionsAvailable.SelectedIndex >= 0)
            {
                listBoxConnectionsAdded.Items.Insert(0, listBoxConnectionsAvailable.Items[listBoxConnectionsAvailable.SelectedIndex]);
                listBoxConnectionsAvailable.Items.RemoveAt(listBoxConnectionsAvailable.SelectedIndex);
            }
        }

        private void listBoxConnectionsAdded_DoubleClick(object sender, EventArgs e)
        {
            if (listBoxConnectionsAdded.SelectedIndex >= 0)
            {
                listBoxConnectionsAvailable.Items.Insert(0, listBoxConnectionsAdded.Items[listBoxConnectionsAdded.SelectedIndex]);
                listBoxConnectionsAdded.Items.RemoveAt(listBoxConnectionsAdded.SelectedIndex);
            }
        }

        private void buttonSavePicture_Click(object sender, EventArgs e)
        {
            if (pictureBoxHierarchy.Image != null)
            {
                SaveFileDialog savedialog = new SaveFileDialog();
                savedialog.Title = "Сохранить картинку как...";
                savedialog.OverwritePrompt = true;
                savedialog.CheckPathExists = true;
                savedialog.Filter = "Image Files(*.JPG)|*.JPG";
                savedialog.ShowHelp = true;

                System.Drawing.Imaging.ImageCodecInfo jpgEncoder = GetEncoder(System.Drawing.Imaging.ImageFormat.Jpeg);

                System.Drawing.Imaging.Encoder myEncoder = System.Drawing.Imaging.Encoder.Quality;
                System.Drawing.Imaging.EncoderParameters myEncoderParameters = new System.Drawing.Imaging.EncoderParameters(1);
                System.Drawing.Imaging.EncoderParameter myEncoderParameter = new System.Drawing.Imaging.EncoderParameter(myEncoder, 100L);
                myEncoderParameters.Param[0] = myEncoderParameter;

                if (savedialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        pictureBoxHierarchy.Image.Save(savedialog.FileName, jpgEncoder, myEncoderParameters);
                    }
                    catch
                    {
                        MessageBox.Show("Невозможно сохранить изображение", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void nodesMatching(Node mainNode, TreeNode rootNode)
        {
            for (int i = 0; i < mainNode.ChildrenCount(); i++)
            {
                TreeNode tempNode = new TreeNode(mainNode[i].Data + " {" + mainNode[i].element.weight + "} ");
                rootNode.Nodes.Add(tempNode);

                nodeStruct.Add(new NodeStruct(mainNode[i], tempNode));

                nodesMatching(mainNode[i], tempNode);
            }
        }

        private int GetDeepestChildNodeLevel(TreeNode node)
        {
            var subLevel = node.Nodes.Cast<TreeNode>().Select(GetDeepestChildNodeLevel);
            return subLevel.Count() == 0 ? 1 : subLevel.Max() + 1;
        }

        private void nodesRefresh()
        {
            nodeStruct = new List<NodeStruct>();

            rootNode = new TreeNode(mainNode.Data + " {" + mainNode.element.weight + "} ");

            nodeStruct.Add(new NodeStruct(mainNode, rootNode));

            nodesMatching(mainNode, rootNode);

            treeViewHierarchy.Nodes.Clear();

            treeViewHierarchy.Nodes.Add(rootNode);

            treeViewHierarchy.Refresh();

            treeViewHierarchy.ExpandAll();
        }

        public static System.Drawing.Imaging.ImageCodecInfo GetEncoder(System.Drawing.Imaging.ImageFormat format)
        {
            return System.Drawing.Imaging.ImageCodecInfo.GetImageDecoders().Where(x => x.FormatID == format.Guid).FirstOrDefault();
        }

        private void drawCell(Graphics schematic, int cellWidth, int cellHeight, int x, int y, string str, int strIndent)
        {
            SolidBrush element = new SolidBrush(Color.Cornsilk); // Цвет фона окн элементов 
            Font textFont = new Font("Times New Roman", 10);

            schematic.FillRectangle(element, new Rectangle(x, y, cellWidth, cellHeight));
            schematic.DrawRectangle(new Pen(Color.Black), new Rectangle(x, y, cellWidth, cellHeight));
            schematic.DrawString(str, textFont, Brushes.Black, new Point(x + strIndent, y + strIndent));
        }

        private void Draw()
        {
            int width = 0, height = 0;
            int indent = 2;
            int wCount = 0, hCount = 0, wMaxLength = 0;

            foreach (List<Node> list in nodeList)
            {
                for (int i = 0; i < list.Count; i++)
                {
                    if (list[i].Data.Length > wMaxLength)
                        wMaxLength = list[i].Data.Length;
                }

                if (list.Count > wCount)
                    wCount = list.Count;
            }

            hCount = nodeList.Count;

            int cellWidth;
            int cellHeight;
            int spacer;

            cellWidth = wMaxLength * 10 + 2 * indent;
            cellHeight = cellWidth / 10 + 10 + 2 * indent;

            spacer = cellWidth / 4;

            width = cellWidth * wCount + spacer * (wCount - 1) + 2 * indent;
            height = cellHeight * (hCount + 1) + spacer * (hCount) + 2 * indent;


            Bitmap flag = new Bitmap(width, height);

            Pen blackLine = new Pen(Color.Black);

            Graphics schematic = Graphics.FromImage(flag);

            SolidBrush background = new SolidBrush(Color.White);

            schematic.FillRectangle(background, new Rectangle(0, 0, width, height));

            int x = width / 2, y = indent;

            drawCell(schematic, cellWidth, cellHeight, x, y, mainNode.Data + " {" + mainNode.element.weight + "}", indent);

            int parentX = x + (cellWidth / 2);
            int parentY = y + cellHeight;

            for (int i = 0; i < mainNode.ChildrenCount(); i++)
            {
                int delta = width / (mainNode.ChildrenCount() + 1);

                y = indent + cellHeight + spacer;
                x = (i + 1) * delta;
                x -= (cellWidth / 2);

                schematic.DrawLine(blackLine, parentX, parentY, parentX, parentY + spacer / 2);
                schematic.DrawLine(blackLine, parentX, parentY + spacer / 2, x + (cellWidth / 2), parentY + spacer / 2);
                schematic.DrawLine(blackLine, x + (cellWidth / 2), parentY + spacer / 2, x + (cellWidth / 2), y);
            }

            for (int i = 0; i < nodeList.Count; i++)
            {
                int delta = width / (nodeList[i].Count + 1);

                y = indent + (i + 1) * cellHeight + (i + 1)* spacer;

                for (int j = 0; j < nodeList[i].Count; j++)
                {
                    x = (j + 1) * delta;
                    x -= (cellWidth / 2);
                    drawCell(schematic, cellWidth, cellHeight, x, y, nodeList[i][j].Data + " {" + nodeList[i][j].element.weight + "}", indent);

                    if (i > 0)
                    {
                        int upperDelta = width / (nodeList[i - 1].Count + 1);
                        for (int k = 0; k < nodeList[i-1].Count; k++)
                        {
                            if (nodeList[i-1][k] == nodeList[i][j].Parent)
                            {
                                parentX = (k + 1) * upperDelta;
                                parentY = y - spacer;
                                schematic.DrawLine(blackLine, parentX, parentY, parentX, parentY + spacer / 2);
                                schematic.DrawLine(blackLine, parentX, parentY + spacer / 2, x + (cellWidth / 2), parentY + spacer / 2);
                                schematic.DrawLine(blackLine, x + (cellWidth / 2), parentY + spacer / 2, x + (cellWidth / 2), y);
                            }
                        }
                    }
                }
            }

            pictureBoxHierarchy.Image = flag;
            flowLayoutPanel.AutoScroll = true;
        }
        
        private void buttonSetPrice_Click(object sender, EventArgs e)
        {
            int depth = 0;
            depth = GetDeepestChildNodeLevel(rootNode) - 1;

            if (listBoxCriterion.Items.Count > 0)
            {
                if (treeViewHierarchy.SelectedNode.Index >= 0 && treeViewHierarchy.SelectedNode.Level != depth)
                {
                    criterionList.Clear();

                    for (int i = 0; i < listBoxCriterion.Items.Count; i++)
                    {
                        criterionList.Add(new Criterion(listBoxCriterion.Items[i].ToString()));
                    }

                    for (int i = 0; i < nodeStruct.Count; i++)
                        if (nodeStruct[i].treeNode == treeViewHierarchy.SelectedNode)
                        {
                            ItemPrice f = new ItemPrice(ref nodeStruct[i].node, ref criterionList);
                            f.Owner = this;
                            f.ShowDialog();
                            break;
                        }
                    
                    nodesRefresh();
                } else
                {
                    MessageBox.Show("Выберите узел для оценки, нижний уровень не может быть оценён", "Ошибка",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            } else
            {
                MessageBox.Show("Должен быть указан хотя бы один критерий", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonCriterionAdd_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(textBoxCriterion.Text.Trim()))
            {
                if (!listBoxCriterion.Items.Contains(textBoxCriterion.Text.Trim()))
                    listBoxCriterion.Items.Add(textBoxCriterion.Text.Trim());
            }

            textBoxCriterion.Clear();
        }

        private void buttonCriterionRemove_Click(object sender, EventArgs e)
        {
            if (listBoxCriterion.SelectedIndex >= 0)
            {
                listBoxCriterion.Items.RemoveAt(listBoxCriterion.SelectedIndex);
            }
        }

        private void buttonCriterionRemoveAll_Click(object sender, EventArgs e)
        {
            listBoxCriterion.Items.Clear();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            nodesRefresh();

            buttonSavePicture.Enabled = false;
            buttonSavePicture.Visible = false;
            buttonNext.Enabled = true;
            buttonBack.Enabled = false;
            buttonBack.Visible = false;

            tabControl.SelectedIndex--;
        }
    }
}
