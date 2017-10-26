namespace HierarchyBuilder
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl = new System.Windows.Forms.TabControl();
            this.StartPage = new System.Windows.Forms.TabPage();
            this.radioButtonVoluntaryModel = new System.Windows.Forms.RadioButton();
            this.radioButtonKoshargskyUemov = new System.Windows.Forms.RadioButton();
            this.labelTarget = new System.Windows.Forms.Label();
            this.labelMainTarget = new System.Windows.Forms.Label();
            this.textBoxMainTarget = new System.Windows.Forms.TextBox();
            this.VoluntatyLevelsPage = new System.Windows.Forms.TabPage();
            this.buttonRemoveLevel = new System.Windows.Forms.Button();
            this.labelAddLevel = new System.Windows.Forms.Label();
            this.buttonAddLevel = new System.Windows.Forms.Button();
            this.textBoxVoluntaryLevel = new System.Windows.Forms.TextBox();
            this.labelVoluntaryLevels = new System.Windows.Forms.Label();
            this.listBoxVoluntaryLevels = new System.Windows.Forms.ListBox();
            this.LevelsPage = new System.Windows.Forms.TabPage();
            this.labelLevels = new System.Windows.Forms.Label();
            this.labelLevelsAdded = new System.Windows.Forms.Label();
            this.labelLevelsAvailable = new System.Windows.Forms.Label();
            this.labelLevelsUserElement = new System.Windows.Forms.Label();
            this.buttonLevelsRemoveAll = new System.Windows.Forms.Button();
            this.buttonLevelsRemove = new System.Windows.Forms.Button();
            this.buttonLevelsAddAll = new System.Windows.Forms.Button();
            this.buttonLevelsAdd = new System.Windows.Forms.Button();
            this.buttonLevelsAddUserLvl = new System.Windows.Forms.Button();
            this.textBoxLevelsUserLvl = new System.Windows.Forms.TextBox();
            this.listBoxLevelsUser = new System.Windows.Forms.ListBox();
            this.listBoxLevelsStandart = new System.Windows.Forms.ListBox();
            this.ConnectionsPage = new System.Windows.Forms.TabPage();
            this.labelConnectionsCurrentConnection = new System.Windows.Forms.Label();
            this.labelConnections = new System.Windows.Forms.Label();
            this.labelConnectionsAdded = new System.Windows.Forms.Label();
            this.labelConnectionsAvailable = new System.Windows.Forms.Label();
            this.buttonConnectionsRemoveAll = new System.Windows.Forms.Button();
            this.buttonConnectionsRemove = new System.Windows.Forms.Button();
            this.buttonConnectionsAddAll = new System.Windows.Forms.Button();
            this.buttonConnectionsAdd = new System.Windows.Forms.Button();
            this.buttonConnectionsConfirm = new System.Windows.Forms.Button();
            this.listBoxConnectionsAdded = new System.Windows.Forms.ListBox();
            this.listBoxConnectionsAvailable = new System.Windows.Forms.ListBox();
            this.TreePage = new System.Windows.Forms.TabPage();
            this.buttonSetPrice = new System.Windows.Forms.Button();
            this.labelHierarchy = new System.Windows.Forms.Label();
            this.labelTreePage = new System.Windows.Forms.Label();
            this.labelCriterion = new System.Windows.Forms.Label();
            this.labelUserCriterion = new System.Windows.Forms.Label();
            this.buttonCriterionRemoveAll = new System.Windows.Forms.Button();
            this.buttonCriterionRemove = new System.Windows.Forms.Button();
            this.buttonCriterionAdd = new System.Windows.Forms.Button();
            this.textBoxCriterion = new System.Windows.Forms.TextBox();
            this.listBoxCriterion = new System.Windows.Forms.ListBox();
            this.treeViewHierarchy = new System.Windows.Forms.TreeView();
            this.PicturePage = new System.Windows.Forms.TabPage();
            this.flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.pictureBoxHierarchy = new System.Windows.Forms.PictureBox();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonNext = new System.Windows.Forms.Button();
            this.buttonSavePicture = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.tabControl.SuspendLayout();
            this.StartPage.SuspendLayout();
            this.VoluntatyLevelsPage.SuspendLayout();
            this.LevelsPage.SuspendLayout();
            this.ConnectionsPage.SuspendLayout();
            this.TreePage.SuspendLayout();
            this.PicturePage.SuspendLayout();
            this.flowLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHierarchy)).BeginInit();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabControl.Controls.Add(this.StartPage);
            this.tabControl.Controls.Add(this.VoluntatyLevelsPage);
            this.tabControl.Controls.Add(this.LevelsPage);
            this.tabControl.Controls.Add(this.ConnectionsPage);
            this.tabControl.Controls.Add(this.TreePage);
            this.tabControl.Controls.Add(this.PicturePage);
            this.tabControl.ItemSize = new System.Drawing.Size(0, 1);
            this.tabControl.Location = new System.Drawing.Point(12, 27);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(760, 493);
            this.tabControl.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl.TabIndex = 0;
            // 
            // StartPage
            // 
            this.StartPage.Controls.Add(this.radioButtonVoluntaryModel);
            this.StartPage.Controls.Add(this.radioButtonKoshargskyUemov);
            this.StartPage.Controls.Add(this.labelTarget);
            this.StartPage.Controls.Add(this.labelMainTarget);
            this.StartPage.Controls.Add(this.textBoxMainTarget);
            this.StartPage.Location = new System.Drawing.Point(4, 5);
            this.StartPage.Name = "StartPage";
            this.StartPage.Padding = new System.Windows.Forms.Padding(3);
            this.StartPage.Size = new System.Drawing.Size(752, 484);
            this.StartPage.TabIndex = 0;
            this.StartPage.Text = "tabPage1";
            this.StartPage.UseVisualStyleBackColor = true;
            // 
            // radioButtonVoluntaryModel
            // 
            this.radioButtonVoluntaryModel.AutoSize = true;
            this.radioButtonVoluntaryModel.Location = new System.Drawing.Point(7, 109);
            this.radioButtonVoluntaryModel.Name = "radioButtonVoluntaryModel";
            this.radioButtonVoluntaryModel.Size = new System.Drawing.Size(219, 17);
            this.radioButtonVoluntaryModel.TabIndex = 6;
            this.radioButtonVoluntaryModel.TabStop = true;
            this.radioButtonVoluntaryModel.Text = "Произвольная иерархическая модель";
            this.radioButtonVoluntaryModel.UseVisualStyleBackColor = true;
            // 
            // radioButtonKoshargskyUemov
            // 
            this.radioButtonKoshargskyUemov.AutoSize = true;
            this.radioButtonKoshargskyUemov.Location = new System.Drawing.Point(7, 86);
            this.radioButtonKoshargskyUemov.Name = "radioButtonKoshargskyUemov";
            this.radioButtonKoshargskyUemov.Size = new System.Drawing.Size(170, 17);
            this.radioButtonKoshargskyUemov.TabIndex = 5;
            this.radioButtonKoshargskyUemov.TabStop = true;
            this.radioButtonKoshargskyUemov.Text = "Метод Кошаргского-Уемова";
            this.radioButtonKoshargskyUemov.UseVisualStyleBackColor = true;
            // 
            // labelTarget
            // 
            this.labelTarget.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTarget.AutoSize = true;
            this.labelTarget.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTarget.Location = new System.Drawing.Point(508, 0);
            this.labelTarget.Name = "labelTarget";
            this.labelTarget.Size = new System.Drawing.Size(244, 26);
            this.labelTarget.TabIndex = 4;
            this.labelTarget.Text = "Введите главную цель";
            // 
            // labelMainTarget
            // 
            this.labelMainTarget.AutoSize = true;
            this.labelMainTarget.Location = new System.Drawing.Point(3, 43);
            this.labelMainTarget.Name = "labelMainTarget";
            this.labelMainTarget.Size = new System.Drawing.Size(79, 13);
            this.labelMainTarget.TabIndex = 2;
            this.labelMainTarget.Text = "Главная цель:";
            // 
            // textBoxMainTarget
            // 
            this.textBoxMainTarget.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxMainTarget.Location = new System.Drawing.Point(6, 59);
            this.textBoxMainTarget.Name = "textBoxMainTarget";
            this.textBoxMainTarget.Size = new System.Drawing.Size(740, 20);
            this.textBoxMainTarget.TabIndex = 1;
            // 
            // VoluntatyLevelsPage
            // 
            this.VoluntatyLevelsPage.Controls.Add(this.buttonRemoveLevel);
            this.VoluntatyLevelsPage.Controls.Add(this.labelAddLevel);
            this.VoluntatyLevelsPage.Controls.Add(this.buttonAddLevel);
            this.VoluntatyLevelsPage.Controls.Add(this.textBoxVoluntaryLevel);
            this.VoluntatyLevelsPage.Controls.Add(this.labelVoluntaryLevels);
            this.VoluntatyLevelsPage.Controls.Add(this.listBoxVoluntaryLevels);
            this.VoluntatyLevelsPage.Location = new System.Drawing.Point(4, 5);
            this.VoluntatyLevelsPage.Name = "VoluntatyLevelsPage";
            this.VoluntatyLevelsPage.Padding = new System.Windows.Forms.Padding(3);
            this.VoluntatyLevelsPage.Size = new System.Drawing.Size(752, 484);
            this.VoluntatyLevelsPage.TabIndex = 5;
            this.VoluntatyLevelsPage.Text = "tabPage1";
            this.VoluntatyLevelsPage.UseVisualStyleBackColor = true;
            // 
            // buttonRemoveLevel
            // 
            this.buttonRemoveLevel.Location = new System.Drawing.Point(6, 456);
            this.buttonRemoveLevel.Name = "buttonRemoveLevel";
            this.buttonRemoveLevel.Size = new System.Drawing.Size(168, 23);
            this.buttonRemoveLevel.TabIndex = 16;
            this.buttonRemoveLevel.Text = "Удалить выбранный уровень";
            this.buttonRemoveLevel.UseVisualStyleBackColor = true;
            this.buttonRemoveLevel.Click += new System.EventHandler(this.buttonRemoveLevel_Click);
            // 
            // labelAddLevel
            // 
            this.labelAddLevel.AutoSize = true;
            this.labelAddLevel.Location = new System.Drawing.Point(299, 461);
            this.labelAddLevel.Name = "labelAddLevel";
            this.labelAddLevel.Size = new System.Drawing.Size(104, 13);
            this.labelAddLevel.TabIndex = 15;
            this.labelAddLevel.Text = "Добавить уровень:";
            // 
            // buttonAddLevel
            // 
            this.buttonAddLevel.Location = new System.Drawing.Point(671, 456);
            this.buttonAddLevel.Name = "buttonAddLevel";
            this.buttonAddLevel.Size = new System.Drawing.Size(75, 23);
            this.buttonAddLevel.TabIndex = 14;
            this.buttonAddLevel.Text = "Добавить";
            this.buttonAddLevel.UseVisualStyleBackColor = true;
            this.buttonAddLevel.Click += new System.EventHandler(this.buttonAddLevel_Click);
            // 
            // textBoxVoluntaryLevel
            // 
            this.textBoxVoluntaryLevel.Location = new System.Drawing.Point(409, 458);
            this.textBoxVoluntaryLevel.Name = "textBoxVoluntaryLevel";
            this.textBoxVoluntaryLevel.Size = new System.Drawing.Size(256, 20);
            this.textBoxVoluntaryLevel.TabIndex = 13;
            // 
            // labelVoluntaryLevels
            // 
            this.labelVoluntaryLevels.AutoSize = true;
            this.labelVoluntaryLevels.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelVoluntaryLevels.Location = new System.Drawing.Point(563, 0);
            this.labelVoluntaryLevels.Name = "labelVoluntaryLevels";
            this.labelVoluntaryLevels.Size = new System.Drawing.Size(189, 26);
            this.labelVoluntaryLevels.TabIndex = 12;
            this.labelVoluntaryLevels.Text = "Добавьте уровни";
            // 
            // listBoxVoluntaryLevels
            // 
            this.listBoxVoluntaryLevels.FormattingEnabled = true;
            this.listBoxVoluntaryLevels.Location = new System.Drawing.Point(6, 59);
            this.listBoxVoluntaryLevels.Name = "listBoxVoluntaryLevels";
            this.listBoxVoluntaryLevels.Size = new System.Drawing.Size(740, 381);
            this.listBoxVoluntaryLevels.TabIndex = 0;
            // 
            // LevelsPage
            // 
            this.LevelsPage.Controls.Add(this.labelLevels);
            this.LevelsPage.Controls.Add(this.labelLevelsAdded);
            this.LevelsPage.Controls.Add(this.labelLevelsAvailable);
            this.LevelsPage.Controls.Add(this.labelLevelsUserElement);
            this.LevelsPage.Controls.Add(this.buttonLevelsRemoveAll);
            this.LevelsPage.Controls.Add(this.buttonLevelsRemove);
            this.LevelsPage.Controls.Add(this.buttonLevelsAddAll);
            this.LevelsPage.Controls.Add(this.buttonLevelsAdd);
            this.LevelsPage.Controls.Add(this.buttonLevelsAddUserLvl);
            this.LevelsPage.Controls.Add(this.textBoxLevelsUserLvl);
            this.LevelsPage.Controls.Add(this.listBoxLevelsUser);
            this.LevelsPage.Controls.Add(this.listBoxLevelsStandart);
            this.LevelsPage.Location = new System.Drawing.Point(4, 5);
            this.LevelsPage.Name = "LevelsPage";
            this.LevelsPage.Padding = new System.Windows.Forms.Padding(3);
            this.LevelsPage.Size = new System.Drawing.Size(752, 484);
            this.LevelsPage.TabIndex = 1;
            this.LevelsPage.Text = "tabPage1";
            this.LevelsPage.UseVisualStyleBackColor = true;
            // 
            // labelLevels
            // 
            this.labelLevels.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelLevels.AutoSize = true;
            this.labelLevels.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelLevels.Location = new System.Drawing.Point(654, 0);
            this.labelLevels.Name = "labelLevels";
            this.labelLevels.Size = new System.Drawing.Size(98, 26);
            this.labelLevels.TabIndex = 11;
            this.labelLevels.Text = "Уровень";
            // 
            // labelLevelsAdded
            // 
            this.labelLevelsAdded.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelLevelsAdded.AutoSize = true;
            this.labelLevelsAdded.Location = new System.Drawing.Point(513, 43);
            this.labelLevelsAdded.Name = "labelLevelsAdded";
            this.labelLevelsAdded.Size = new System.Drawing.Size(138, 13);
            this.labelLevelsAdded.TabIndex = 10;
            this.labelLevelsAdded.Text = "Используемые элементы";
            // 
            // labelLevelsAvailable
            // 
            this.labelLevelsAvailable.AutoSize = true;
            this.labelLevelsAvailable.Location = new System.Drawing.Point(3, 43);
            this.labelLevelsAvailable.Name = "labelLevelsAvailable";
            this.labelLevelsAvailable.Size = new System.Drawing.Size(150, 13);
            this.labelLevelsAvailable.TabIndex = 9;
            this.labelLevelsAvailable.Text = "Неиспользуемые элементы";
            // 
            // labelLevelsUserElement
            // 
            this.labelLevelsUserElement.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelLevelsUserElement.AutoSize = true;
            this.labelLevelsUserElement.Location = new System.Drawing.Point(513, 439);
            this.labelLevelsUserElement.Name = "labelLevelsUserElement";
            this.labelLevelsUserElement.Size = new System.Drawing.Size(153, 13);
            this.labelLevelsUserElement.TabIndex = 8;
            this.labelLevelsUserElement.Text = "Пользовательский элемент:";
            // 
            // buttonLevelsRemoveAll
            // 
            this.buttonLevelsRemoveAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonLevelsRemoveAll.Location = new System.Drawing.Point(426, 228);
            this.buttonLevelsRemoveAll.Name = "buttonLevelsRemoveAll";
            this.buttonLevelsRemoveAll.Size = new System.Drawing.Size(84, 38);
            this.buttonLevelsRemoveAll.TabIndex = 7;
            this.buttonLevelsRemoveAll.Text = "<- Удалить все";
            this.buttonLevelsRemoveAll.UseVisualStyleBackColor = true;
            this.buttonLevelsRemoveAll.Click += new System.EventHandler(this.buttonLevelsRemoveAll_Click);
            // 
            // buttonLevelsRemove
            // 
            this.buttonLevelsRemove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonLevelsRemove.Location = new System.Drawing.Point(426, 199);
            this.buttonLevelsRemove.Name = "buttonLevelsRemove";
            this.buttonLevelsRemove.Size = new System.Drawing.Size(84, 23);
            this.buttonLevelsRemove.TabIndex = 6;
            this.buttonLevelsRemove.Text = "<- Удалить";
            this.buttonLevelsRemove.UseVisualStyleBackColor = true;
            this.buttonLevelsRemove.Click += new System.EventHandler(this.buttonLevelsRemove_Click);
            // 
            // buttonLevelsAddAll
            // 
            this.buttonLevelsAddAll.Location = new System.Drawing.Point(241, 228);
            this.buttonLevelsAddAll.Name = "buttonLevelsAddAll";
            this.buttonLevelsAddAll.Size = new System.Drawing.Size(84, 38);
            this.buttonLevelsAddAll.TabIndex = 5;
            this.buttonLevelsAddAll.Text = "Добавить все ->";
            this.buttonLevelsAddAll.UseVisualStyleBackColor = true;
            this.buttonLevelsAddAll.Click += new System.EventHandler(this.buttonLevelsAddAll_Click);
            // 
            // buttonLevelsAdd
            // 
            this.buttonLevelsAdd.Location = new System.Drawing.Point(241, 199);
            this.buttonLevelsAdd.Name = "buttonLevelsAdd";
            this.buttonLevelsAdd.Size = new System.Drawing.Size(84, 23);
            this.buttonLevelsAdd.TabIndex = 4;
            this.buttonLevelsAdd.Text = "Добавить ->";
            this.buttonLevelsAdd.UseVisualStyleBackColor = true;
            this.buttonLevelsAdd.Click += new System.EventHandler(this.buttonLevelsAdd_Click);
            // 
            // buttonLevelsAddUserLvl
            // 
            this.buttonLevelsAddUserLvl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonLevelsAddUserLvl.Location = new System.Drawing.Point(670, 453);
            this.buttonLevelsAddUserLvl.Name = "buttonLevelsAddUserLvl";
            this.buttonLevelsAddUserLvl.Size = new System.Drawing.Size(75, 23);
            this.buttonLevelsAddUserLvl.TabIndex = 3;
            this.buttonLevelsAddUserLvl.Text = "Добавить";
            this.buttonLevelsAddUserLvl.UseVisualStyleBackColor = true;
            this.buttonLevelsAddUserLvl.Click += new System.EventHandler(this.buttonLevelsAddUserLvl_Click);
            // 
            // textBoxLevelsUserLvl
            // 
            this.textBoxLevelsUserLvl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxLevelsUserLvl.Location = new System.Drawing.Point(516, 455);
            this.textBoxLevelsUserLvl.Name = "textBoxLevelsUserLvl";
            this.textBoxLevelsUserLvl.Size = new System.Drawing.Size(148, 20);
            this.textBoxLevelsUserLvl.TabIndex = 2;
            // 
            // listBoxLevelsUser
            // 
            this.listBoxLevelsUser.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxLevelsUser.FormattingEnabled = true;
            this.listBoxLevelsUser.Location = new System.Drawing.Point(516, 59);
            this.listBoxLevelsUser.Name = "listBoxLevelsUser";
            this.listBoxLevelsUser.Size = new System.Drawing.Size(229, 368);
            this.listBoxLevelsUser.TabIndex = 1;
            this.listBoxLevelsUser.DoubleClick += new System.EventHandler(this.listBoxLevelsUser_DoubleClick);
            // 
            // listBoxLevelsStandart
            // 
            this.listBoxLevelsStandart.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listBoxLevelsStandart.FormattingEnabled = true;
            this.listBoxLevelsStandart.Location = new System.Drawing.Point(6, 59);
            this.listBoxLevelsStandart.Name = "listBoxLevelsStandart";
            this.listBoxLevelsStandart.Size = new System.Drawing.Size(229, 407);
            this.listBoxLevelsStandart.TabIndex = 0;
            this.listBoxLevelsStandart.DoubleClick += new System.EventHandler(this.listBoxLevelsStandart_DoubleClick);
            // 
            // ConnectionsPage
            // 
            this.ConnectionsPage.Controls.Add(this.labelConnectionsCurrentConnection);
            this.ConnectionsPage.Controls.Add(this.labelConnections);
            this.ConnectionsPage.Controls.Add(this.labelConnectionsAdded);
            this.ConnectionsPage.Controls.Add(this.labelConnectionsAvailable);
            this.ConnectionsPage.Controls.Add(this.buttonConnectionsRemoveAll);
            this.ConnectionsPage.Controls.Add(this.buttonConnectionsRemove);
            this.ConnectionsPage.Controls.Add(this.buttonConnectionsAddAll);
            this.ConnectionsPage.Controls.Add(this.buttonConnectionsAdd);
            this.ConnectionsPage.Controls.Add(this.buttonConnectionsConfirm);
            this.ConnectionsPage.Controls.Add(this.listBoxConnectionsAdded);
            this.ConnectionsPage.Controls.Add(this.listBoxConnectionsAvailable);
            this.ConnectionsPage.Location = new System.Drawing.Point(4, 5);
            this.ConnectionsPage.Name = "ConnectionsPage";
            this.ConnectionsPage.Padding = new System.Windows.Forms.Padding(3);
            this.ConnectionsPage.Size = new System.Drawing.Size(752, 484);
            this.ConnectionsPage.TabIndex = 3;
            this.ConnectionsPage.Text = "tabPage1";
            this.ConnectionsPage.UseVisualStyleBackColor = true;
            // 
            // labelConnectionsCurrentConnection
            // 
            this.labelConnectionsCurrentConnection.AutoSize = true;
            this.labelConnectionsCurrentConnection.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelConnectionsCurrentConnection.Location = new System.Drawing.Point(-3, 7);
            this.labelConnectionsCurrentConnection.Name = "labelConnectionsCurrentConnection";
            this.labelConnectionsCurrentConnection.Size = new System.Drawing.Size(130, 17);
            this.labelConnectionsCurrentConnection.TabIndex = 12;
            this.labelConnectionsCurrentConnection.Text = "Current Connection";
            // 
            // labelConnections
            // 
            this.labelConnections.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelConnections.AutoSize = true;
            this.labelConnections.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelConnections.Location = new System.Drawing.Point(564, 0);
            this.labelConnections.Name = "labelConnections";
            this.labelConnections.Size = new System.Drawing.Size(188, 26);
            this.labelConnections.TabIndex = 11;
            this.labelConnections.Text = "Создание связей";
            // 
            // labelConnectionsAdded
            // 
            this.labelConnectionsAdded.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelConnectionsAdded.AutoSize = true;
            this.labelConnectionsAdded.Location = new System.Drawing.Point(513, 43);
            this.labelConnectionsAdded.Name = "labelConnectionsAdded";
            this.labelConnectionsAdded.Size = new System.Drawing.Size(120, 13);
            this.labelConnectionsAdded.TabIndex = 10;
            this.labelConnectionsAdded.Text = "Выбранные элементы";
            // 
            // labelConnectionsAvailable
            // 
            this.labelConnectionsAvailable.AutoSize = true;
            this.labelConnectionsAvailable.Location = new System.Drawing.Point(3, 43);
            this.labelConnectionsAvailable.Name = "labelConnectionsAvailable";
            this.labelConnectionsAvailable.Size = new System.Drawing.Size(118, 13);
            this.labelConnectionsAvailable.TabIndex = 9;
            this.labelConnectionsAvailable.Text = "Доступные элементы";
            // 
            // buttonConnectionsRemoveAll
            // 
            this.buttonConnectionsRemoveAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonConnectionsRemoveAll.Location = new System.Drawing.Point(426, 228);
            this.buttonConnectionsRemoveAll.Name = "buttonConnectionsRemoveAll";
            this.buttonConnectionsRemoveAll.Size = new System.Drawing.Size(84, 38);
            this.buttonConnectionsRemoveAll.TabIndex = 7;
            this.buttonConnectionsRemoveAll.Text = "<- Удалить все";
            this.buttonConnectionsRemoveAll.UseVisualStyleBackColor = true;
            this.buttonConnectionsRemoveAll.Click += new System.EventHandler(this.buttonConnectionsRemoveAll_Click);
            // 
            // buttonConnectionsRemove
            // 
            this.buttonConnectionsRemove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonConnectionsRemove.Location = new System.Drawing.Point(426, 199);
            this.buttonConnectionsRemove.Name = "buttonConnectionsRemove";
            this.buttonConnectionsRemove.Size = new System.Drawing.Size(84, 23);
            this.buttonConnectionsRemove.TabIndex = 6;
            this.buttonConnectionsRemove.Text = "<- Удалить";
            this.buttonConnectionsRemove.UseVisualStyleBackColor = true;
            this.buttonConnectionsRemove.Click += new System.EventHandler(this.buttonConnectionsRemove_Click);
            // 
            // buttonConnectionsAddAll
            // 
            this.buttonConnectionsAddAll.Location = new System.Drawing.Point(241, 228);
            this.buttonConnectionsAddAll.Name = "buttonConnectionsAddAll";
            this.buttonConnectionsAddAll.Size = new System.Drawing.Size(84, 38);
            this.buttonConnectionsAddAll.TabIndex = 5;
            this.buttonConnectionsAddAll.Text = "Добавить все ->";
            this.buttonConnectionsAddAll.UseVisualStyleBackColor = true;
            this.buttonConnectionsAddAll.Click += new System.EventHandler(this.buttonConnectionsAddAll_Click);
            // 
            // buttonConnectionsAdd
            // 
            this.buttonConnectionsAdd.Location = new System.Drawing.Point(241, 199);
            this.buttonConnectionsAdd.Name = "buttonConnectionsAdd";
            this.buttonConnectionsAdd.Size = new System.Drawing.Size(84, 23);
            this.buttonConnectionsAdd.TabIndex = 4;
            this.buttonConnectionsAdd.Text = "Добавить ->";
            this.buttonConnectionsAdd.UseVisualStyleBackColor = true;
            this.buttonConnectionsAdd.Click += new System.EventHandler(this.buttonConnectionsAdd_Click);
            // 
            // buttonConnectionsConfirm
            // 
            this.buttonConnectionsConfirm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonConnectionsConfirm.Location = new System.Drawing.Point(516, 443);
            this.buttonConnectionsConfirm.Name = "buttonConnectionsConfirm";
            this.buttonConnectionsConfirm.Size = new System.Drawing.Size(229, 23);
            this.buttonConnectionsConfirm.TabIndex = 3;
            this.buttonConnectionsConfirm.Text = "Подтвердить связь";
            this.buttonConnectionsConfirm.UseVisualStyleBackColor = true;
            this.buttonConnectionsConfirm.Click += new System.EventHandler(this.buttonConnectionsConfirm_Click);
            // 
            // listBoxConnectionsAdded
            // 
            this.listBoxConnectionsAdded.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxConnectionsAdded.FormattingEnabled = true;
            this.listBoxConnectionsAdded.Location = new System.Drawing.Point(516, 59);
            this.listBoxConnectionsAdded.Name = "listBoxConnectionsAdded";
            this.listBoxConnectionsAdded.Size = new System.Drawing.Size(229, 368);
            this.listBoxConnectionsAdded.TabIndex = 1;
            this.listBoxConnectionsAdded.DoubleClick += new System.EventHandler(this.listBoxConnectionsAdded_DoubleClick);
            // 
            // listBoxConnectionsAvailable
            // 
            this.listBoxConnectionsAvailable.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listBoxConnectionsAvailable.FormattingEnabled = true;
            this.listBoxConnectionsAvailable.Location = new System.Drawing.Point(6, 59);
            this.listBoxConnectionsAvailable.Name = "listBoxConnectionsAvailable";
            this.listBoxConnectionsAvailable.Size = new System.Drawing.Size(229, 407);
            this.listBoxConnectionsAvailable.TabIndex = 0;
            this.listBoxConnectionsAvailable.DoubleClick += new System.EventHandler(this.listBoxConnectionsAvailable_DoubleClick);
            // 
            // TreePage
            // 
            this.TreePage.Controls.Add(this.buttonSetPrice);
            this.TreePage.Controls.Add(this.labelHierarchy);
            this.TreePage.Controls.Add(this.labelTreePage);
            this.TreePage.Controls.Add(this.labelCriterion);
            this.TreePage.Controls.Add(this.labelUserCriterion);
            this.TreePage.Controls.Add(this.buttonCriterionRemoveAll);
            this.TreePage.Controls.Add(this.buttonCriterionRemove);
            this.TreePage.Controls.Add(this.buttonCriterionAdd);
            this.TreePage.Controls.Add(this.textBoxCriterion);
            this.TreePage.Controls.Add(this.listBoxCriterion);
            this.TreePage.Controls.Add(this.treeViewHierarchy);
            this.TreePage.Location = new System.Drawing.Point(4, 5);
            this.TreePage.Name = "TreePage";
            this.TreePage.Padding = new System.Windows.Forms.Padding(3);
            this.TreePage.Size = new System.Drawing.Size(752, 484);
            this.TreePage.TabIndex = 6;
            this.TreePage.Text = "tabPage1";
            this.TreePage.UseVisualStyleBackColor = true;
            // 
            // buttonSetPrice
            // 
            this.buttonSetPrice.Location = new System.Drawing.Point(6, 453);
            this.buttonSetPrice.Name = "buttonSetPrice";
            this.buttonSetPrice.Size = new System.Drawing.Size(289, 23);
            this.buttonSetPrice.TabIndex = 21;
            this.buttonSetPrice.Text = "Задать вес";
            this.buttonSetPrice.UseVisualStyleBackColor = true;
            this.buttonSetPrice.Click += new System.EventHandler(this.buttonSetPrice_Click);
            // 
            // labelHierarchy
            // 
            this.labelHierarchy.AutoSize = true;
            this.labelHierarchy.Location = new System.Drawing.Point(3, 43);
            this.labelHierarchy.Name = "labelHierarchy";
            this.labelHierarchy.Size = new System.Drawing.Size(56, 13);
            this.labelHierarchy.TabIndex = 20;
            this.labelHierarchy.Text = "Иерархия";
            // 
            // labelTreePage
            // 
            this.labelTreePage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTreePage.AutoSize = true;
            this.labelTreePage.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTreePage.Location = new System.Drawing.Point(574, 0);
            this.labelTreePage.Name = "labelTreePage";
            this.labelTreePage.Size = new System.Drawing.Size(178, 26);
            this.labelTreePage.TabIndex = 19;
            this.labelTreePage.Text = "Оценка уровней";
            // 
            // labelCriterion
            // 
            this.labelCriterion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelCriterion.AutoSize = true;
            this.labelCriterion.Location = new System.Drawing.Point(514, 43);
            this.labelCriterion.Name = "labelCriterion";
            this.labelCriterion.Size = new System.Drawing.Size(94, 13);
            this.labelCriterion.TabIndex = 18;
            this.labelCriterion.Text = "Критерии оценки";
            // 
            // labelUserCriterion
            // 
            this.labelUserCriterion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelUserCriterion.AutoSize = true;
            this.labelUserCriterion.Location = new System.Drawing.Point(514, 439);
            this.labelUserCriterion.Name = "labelUserCriterion";
            this.labelUserCriterion.Size = new System.Drawing.Size(153, 13);
            this.labelUserCriterion.TabIndex = 17;
            this.labelUserCriterion.Text = "Пользовательский элемент:";
            // 
            // buttonCriterionRemoveAll
            // 
            this.buttonCriterionRemoveAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCriterionRemoveAll.Location = new System.Drawing.Point(427, 228);
            this.buttonCriterionRemoveAll.Name = "buttonCriterionRemoveAll";
            this.buttonCriterionRemoveAll.Size = new System.Drawing.Size(84, 38);
            this.buttonCriterionRemoveAll.TabIndex = 16;
            this.buttonCriterionRemoveAll.Text = "Удалить все";
            this.buttonCriterionRemoveAll.UseVisualStyleBackColor = true;
            this.buttonCriterionRemoveAll.Click += new System.EventHandler(this.buttonCriterionRemoveAll_Click);
            // 
            // buttonCriterionRemove
            // 
            this.buttonCriterionRemove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCriterionRemove.Location = new System.Drawing.Point(427, 199);
            this.buttonCriterionRemove.Name = "buttonCriterionRemove";
            this.buttonCriterionRemove.Size = new System.Drawing.Size(84, 23);
            this.buttonCriterionRemove.TabIndex = 15;
            this.buttonCriterionRemove.Text = "Удалить";
            this.buttonCriterionRemove.UseVisualStyleBackColor = true;
            this.buttonCriterionRemove.Click += new System.EventHandler(this.buttonCriterionRemove_Click);
            // 
            // buttonCriterionAdd
            // 
            this.buttonCriterionAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCriterionAdd.Location = new System.Drawing.Point(671, 453);
            this.buttonCriterionAdd.Name = "buttonCriterionAdd";
            this.buttonCriterionAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonCriterionAdd.TabIndex = 14;
            this.buttonCriterionAdd.Text = "Добавить";
            this.buttonCriterionAdd.UseVisualStyleBackColor = true;
            this.buttonCriterionAdd.Click += new System.EventHandler(this.buttonCriterionAdd_Click);
            // 
            // textBoxCriterion
            // 
            this.textBoxCriterion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxCriterion.Location = new System.Drawing.Point(517, 455);
            this.textBoxCriterion.Name = "textBoxCriterion";
            this.textBoxCriterion.Size = new System.Drawing.Size(148, 20);
            this.textBoxCriterion.TabIndex = 13;
            // 
            // listBoxCriterion
            // 
            this.listBoxCriterion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxCriterion.FormattingEnabled = true;
            this.listBoxCriterion.Location = new System.Drawing.Point(517, 59);
            this.listBoxCriterion.Name = "listBoxCriterion";
            this.listBoxCriterion.Size = new System.Drawing.Size(229, 368);
            this.listBoxCriterion.TabIndex = 12;
            // 
            // treeViewHierarchy
            // 
            this.treeViewHierarchy.Location = new System.Drawing.Point(6, 59);
            this.treeViewHierarchy.Name = "treeViewHierarchy";
            this.treeViewHierarchy.Size = new System.Drawing.Size(289, 368);
            this.treeViewHierarchy.TabIndex = 0;
            // 
            // PicturePage
            // 
            this.PicturePage.Controls.Add(this.flowLayoutPanel);
            this.PicturePage.Location = new System.Drawing.Point(4, 5);
            this.PicturePage.Name = "PicturePage";
            this.PicturePage.Padding = new System.Windows.Forms.Padding(3);
            this.PicturePage.Size = new System.Drawing.Size(752, 484);
            this.PicturePage.TabIndex = 4;
            this.PicturePage.Text = "tabPage1";
            this.PicturePage.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel
            // 
            this.flowLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel.Controls.Add(this.pictureBoxHierarchy);
            this.flowLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel.Name = "flowLayoutPanel";
            this.flowLayoutPanel.Size = new System.Drawing.Size(752, 484);
            this.flowLayoutPanel.TabIndex = 0;
            // 
            // pictureBoxHierarchy
            // 
            this.pictureBoxHierarchy.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxHierarchy.Location = new System.Drawing.Point(3, 3);
            this.pictureBoxHierarchy.Name = "pictureBoxHierarchy";
            this.pictureBoxHierarchy.Size = new System.Drawing.Size(749, 0);
            this.pictureBoxHierarchy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxHierarchy.TabIndex = 1;
            this.pictureBoxHierarchy.TabStop = false;
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(784, 24);
            this.menuStrip.TabIndex = 1;
            this.menuStrip.Text = "menuStrip1";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.helpToolStripMenuItem.Text = "Помощь";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.aboutToolStripMenuItem.Text = "О программе";
            // 
            // buttonNext
            // 
            this.buttonNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonNext.Location = new System.Drawing.Point(696, 526);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(75, 23);
            this.buttonNext.TabIndex = 2;
            this.buttonNext.Text = "Далее";
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // buttonSavePicture
            // 
            this.buttonSavePicture.Enabled = false;
            this.buttonSavePicture.Location = new System.Drawing.Point(12, 526);
            this.buttonSavePicture.Name = "buttonSavePicture";
            this.buttonSavePicture.Size = new System.Drawing.Size(147, 23);
            this.buttonSavePicture.TabIndex = 3;
            this.buttonSavePicture.Text = "Сохранить изображение";
            this.buttonSavePicture.UseVisualStyleBackColor = true;
            this.buttonSavePicture.Visible = false;
            this.buttonSavePicture.Click += new System.EventHandler(this.buttonSavePicture_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.Enabled = false;
            this.buttonBack.Location = new System.Drawing.Point(615, 526);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(75, 23);
            this.buttonBack.TabIndex = 4;
            this.buttonBack.Text = "Назад";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Visible = false;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonSavePicture);
            this.Controls.Add(this.buttonNext);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "MainForm";
            this.Text = "Hierarchy Builder";
            this.tabControl.ResumeLayout(false);
            this.StartPage.ResumeLayout(false);
            this.StartPage.PerformLayout();
            this.VoluntatyLevelsPage.ResumeLayout(false);
            this.VoluntatyLevelsPage.PerformLayout();
            this.LevelsPage.ResumeLayout(false);
            this.LevelsPage.PerformLayout();
            this.ConnectionsPage.ResumeLayout(false);
            this.ConnectionsPage.PerformLayout();
            this.TreePage.ResumeLayout(false);
            this.TreePage.PerformLayout();
            this.PicturePage.ResumeLayout(false);
            this.flowLayoutPanel.ResumeLayout(false);
            this.flowLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHierarchy)).EndInit();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.TabPage StartPage;
        private System.Windows.Forms.Label labelMainTarget;
        private System.Windows.Forms.TextBox textBoxMainTarget;
        private System.Windows.Forms.Label labelTarget;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.TabPage LevelsPage;
        private System.Windows.Forms.Label labelLevelsUserElement;
        private System.Windows.Forms.Button buttonLevelsRemoveAll;
        private System.Windows.Forms.Button buttonLevelsRemove;
        private System.Windows.Forms.Button buttonLevelsAddAll;
        private System.Windows.Forms.Button buttonLevelsAdd;
        private System.Windows.Forms.Button buttonLevelsAddUserLvl;
        private System.Windows.Forms.TextBox textBoxLevelsUserLvl;
        private System.Windows.Forms.ListBox listBoxLevelsUser;
        private System.Windows.Forms.ListBox listBoxLevelsStandart;
        private System.Windows.Forms.Label labelLevelsAvailable;
        private System.Windows.Forms.Label labelLevelsAdded;
        private System.Windows.Forms.Label labelLevels;
        private System.Windows.Forms.TabPage ConnectionsPage;
        private System.Windows.Forms.Label labelConnections;
        private System.Windows.Forms.Label labelConnectionsAdded;
        private System.Windows.Forms.Label labelConnectionsAvailable;
        private System.Windows.Forms.Button buttonConnectionsRemoveAll;
        private System.Windows.Forms.Button buttonConnectionsRemove;
        private System.Windows.Forms.Button buttonConnectionsAddAll;
        private System.Windows.Forms.Button buttonConnectionsAdd;
        private System.Windows.Forms.Button buttonConnectionsConfirm;
        private System.Windows.Forms.ListBox listBoxConnectionsAdded;
        private System.Windows.Forms.ListBox listBoxConnectionsAvailable;
        private System.Windows.Forms.Label labelConnectionsCurrentConnection;
        private System.Windows.Forms.TabPage PicturePage;
        private System.Windows.Forms.RadioButton radioButtonVoluntaryModel;
        private System.Windows.Forms.RadioButton radioButtonKoshargskyUemov;
        private System.Windows.Forms.TabPage VoluntatyLevelsPage;
        private System.Windows.Forms.Label labelAddLevel;
        private System.Windows.Forms.Button buttonAddLevel;
        private System.Windows.Forms.TextBox textBoxVoluntaryLevel;
        private System.Windows.Forms.Label labelVoluntaryLevels;
        private System.Windows.Forms.ListBox listBoxVoluntaryLevels;
        private System.Windows.Forms.Button buttonRemoveLevel;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel;
        private System.Windows.Forms.PictureBox pictureBoxHierarchy;
        private System.Windows.Forms.Button buttonSavePicture;
        private System.Windows.Forms.TabPage TreePage;
        private System.Windows.Forms.Label labelTreePage;
        private System.Windows.Forms.Label labelCriterion;
        private System.Windows.Forms.Label labelUserCriterion;
        private System.Windows.Forms.Button buttonCriterionRemoveAll;
        private System.Windows.Forms.Button buttonCriterionRemove;
        private System.Windows.Forms.Button buttonCriterionAdd;
        private System.Windows.Forms.TextBox textBoxCriterion;
        private System.Windows.Forms.ListBox listBoxCriterion;
        private System.Windows.Forms.TreeView treeViewHierarchy;
        private System.Windows.Forms.Label labelHierarchy;
        private System.Windows.Forms.Button buttonSetPrice;
        private System.Windows.Forms.Button buttonBack;
    }
}

