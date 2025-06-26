namespace FlightWaypoint
{
    partial class UAVFlightWaypoint
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
            this.TableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.panelLeft = new System.Windows.Forms.TableLayoutPanel();
            this.panelTopLeft = new System.Windows.Forms.Panel();
            this.startButt = new System.Windows.Forms.Button();
            this.exitButt = new System.Windows.Forms.Button();
            this.portTextBox = new System.Windows.Forms.TextBox();
            this.IPAddressTextBox = new System.Windows.Forms.TextBox();
            this.IPAddressLabel = new System.Windows.Forms.Label();
            this.portLabel = new System.Windows.Forms.Label();
            this.connectLabel = new System.Windows.Forms.Label();
            this.stopButt = new System.Windows.Forms.Button();
            this.panelMidLeft = new System.Windows.Forms.Panel();
            this.statusLabel = new System.Windows.Forms.Label();
            this.latitudeStatusLabel = new System.Windows.Forms.Label();
            this.longitudeStatusLabel = new System.Windows.Forms.Label();
            this.headingLabel = new System.Windows.Forms.Label();
            this.altitudeLabel = new System.Windows.Forms.Label();
            this.temperatureLabel = new System.Windows.Forms.Label();
            this.latitudeRTLabel = new System.Windows.Forms.Label();
            this.longitudeRTLabel = new System.Windows.Forms.Label();
            this.headingRTLabel = new System.Windows.Forms.Label();
            this.altitudeRTLabel = new System.Windows.Forms.Label();
            this.temperatureRTLabel = new System.Windows.Forms.Label();
            this.panelBotLeft = new System.Windows.Forms.Panel();
            this.waypointLabel = new System.Windows.Forms.Label();
            this.searchButt = new System.Windows.Forms.Button();
            this.sendButt = new System.Windows.Forms.Button();
            this.longitudeLabel = new System.Windows.Forms.Label();
            this.latitudeLabel = new System.Windows.Forms.Label();
            this.longitudeTextBox = new System.Windows.Forms.TextBox();
            this.latitudeTextBox = new System.Windows.Forms.TextBox();
            this.createListButt = new System.Windows.Forms.Button();
            this.resetButt = new System.Windows.Forms.Button();
            this.homeButt = new System.Windows.Forms.Button();
            this.panelRight = new System.Windows.Forms.TableLayoutPanel();
            this.gMapControl1 = new GMap.NET.WindowsForms.GMapControl();
            this.TableLayoutPanel.SuspendLayout();
            this.panelLeft.SuspendLayout();
            this.panelTopLeft.SuspendLayout();
            this.panelMidLeft.SuspendLayout();
            this.panelBotLeft.SuspendLayout();
            this.panelRight.SuspendLayout();
            this.SuspendLayout();
            // 
            // TableLayoutPanel
            // 
            this.TableLayoutPanel.ColumnCount = 2;
            this.TableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.TableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.TableLayoutPanel.Controls.Add(this.panelLeft, 0, 0);
            this.TableLayoutPanel.Controls.Add(this.panelRight, 1, 0);
            this.TableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.TableLayoutPanel.Name = "TableLayoutPanel";
            this.TableLayoutPanel.RowCount = 1;
            this.TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.TableLayoutPanel.Size = new System.Drawing.Size(800, 600);
            this.TableLayoutPanel.TabIndex = 0;
            // 
            // panelLeft
            // 
            this.panelLeft.BackColor = System.Drawing.Color.LightBlue;
            this.panelLeft.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelLeft.ColumnCount = 1;
            this.panelLeft.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.panelLeft.Controls.Add(this.panelTopLeft, 0, 0);
            this.panelLeft.Controls.Add(this.panelMidLeft, 1, 0);
            this.panelLeft.Controls.Add(this.panelBotLeft, 2, 0);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelLeft.Location = new System.Drawing.Point(3, 3);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.RowCount = 3;
            this.panelLeft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.3F));
            this.panelLeft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.3F));
            this.panelLeft.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.3F));
            this.panelLeft.Size = new System.Drawing.Size(154, 574);
            this.panelLeft.TabIndex = 1;
            // 
            // panelTopLeft
            // 
            this.panelTopLeft.BackColor = System.Drawing.Color.LightBlue;
            this.panelTopLeft.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelTopLeft.Controls.Add(this.startButt);
            this.panelTopLeft.Controls.Add(this.exitButt);
            this.panelTopLeft.Controls.Add(this.portTextBox);
            this.panelTopLeft.Controls.Add(this.IPAddressTextBox);
            this.panelTopLeft.Controls.Add(this.IPAddressLabel);
            this.panelTopLeft.Controls.Add(this.portLabel);
            this.panelTopLeft.Controls.Add(this.connectLabel);
            this.panelTopLeft.Controls.Add(this.stopButt);
            this.panelTopLeft.Controls.Add(this.resetButt);
            this.panelTopLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTopLeft.Location = new System.Drawing.Point(3, 3);
            this.panelTopLeft.Name = "panelTopLeft";
            this.panelTopLeft.Size = new System.Drawing.Size(146, 184);
            this.panelTopLeft.TabIndex = 3;
            // 
            // startButt
            // 
            this.startButt.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startButt.Location = new System.Drawing.Point(10, 150);
            this.startButt.Name = "startButt";
            this.startButt.Size = new System.Drawing.Size(150, 50);
            this.startButt.TabIndex = 14;
            this.startButt.Text = "Start";
            this.startButt.UseVisualStyleBackColor = true;
            this.startButt.Enabled = true;
            this.startButt.Click += new System.EventHandler(this.startButt_Click);
            // 
            // exitButt
            // 
            this.exitButt.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButt.Location = new System.Drawing.Point(10, 225);
            this.exitButt.Name = "exitButt";
            this.exitButt.Size = new System.Drawing.Size(150, 50);
            this.exitButt.TabIndex = 13;
            this.exitButt.Text = "Exit";
            this.exitButt.UseVisualStyleBackColor = true;
            this.exitButt.Click += new System.EventHandler(this.exitButt_Click);
            // 
            // portTextBox
            // 
            this.portTextBox.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.portTextBox.Location = new System.Drawing.Point(200, 100);
            this.portTextBox.Name = "portTextBox";
            this.portTextBox.Size = new System.Drawing.Size(150, 33);
            this.portTextBox.TabIndex = 10;
            // 
            // IPAddressTextBox
            // 
            this.IPAddressTextBox.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IPAddressTextBox.Location = new System.Drawing.Point(10, 100);
            this.IPAddressTextBox.Name = "IPAddressTextBox";
            this.IPAddressTextBox.Size = new System.Drawing.Size(150, 33);
            this.IPAddressTextBox.TabIndex = 9;
            // 
            // IPAddressLabel
            // 
            this.IPAddressLabel.AutoSize = true;
            this.IPAddressLabel.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IPAddressLabel.Location = new System.Drawing.Point(10, 50);
            this.IPAddressLabel.Name = "IPAddressLabel";
            this.IPAddressLabel.Size = new System.Drawing.Size(107, 25);
            this.IPAddressLabel.TabIndex = 5;
            this.IPAddressLabel.Text = "IP Address";
            // 
            // portLabel
            // 
            this.portLabel.AutoSize = true;
            this.portLabel.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.portLabel.Location = new System.Drawing.Point(200, 50);
            this.portLabel.Name = "portLabel";
            this.portLabel.Size = new System.Drawing.Size(48, 25);
            this.portLabel.TabIndex = 6;
            this.portLabel.Text = "Port";
            // 
            // connectLabel
            // 
            this.connectLabel.AutoSize = true;
            this.connectLabel.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.connectLabel.ForeColor = System.Drawing.Color.Black;
            this.connectLabel.Location = new System.Drawing.Point(140, 10);
            this.connectLabel.Name = "connectLabel";
            this.connectLabel.Size = new System.Drawing.Size(113, 32);
            this.connectLabel.TabIndex = 6;
            this.connectLabel.Text = "Connect";
            // 
            // stopButt
            // 
            this.stopButt.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stopButt.Location = new System.Drawing.Point(200, 150);
            this.stopButt.Name = "stopButt";
            this.stopButt.Size = new System.Drawing.Size(150, 50);
            this.stopButt.TabIndex = 14;
            this.stopButt.Text = "Stop";
            this.stopButt.UseVisualStyleBackColor = true;
            this.stopButt.Enabled = false;
            this.stopButt.Click += new System.EventHandler(this.stopButt_Click);
            // 
            // panelMidLeft
            // 
            this.panelMidLeft.BackColor = System.Drawing.Color.LightBlue;
            this.panelMidLeft.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelMidLeft.Controls.Add(this.statusLabel);
            this.panelMidLeft.Controls.Add(this.latitudeStatusLabel);
            this.panelMidLeft.Controls.Add(this.longitudeStatusLabel);
            this.panelMidLeft.Controls.Add(this.headingLabel);
            this.panelMidLeft.Controls.Add(this.altitudeLabel);
            this.panelMidLeft.Controls.Add(this.temperatureLabel);
            this.panelMidLeft.Controls.Add(this.latitudeRTLabel);
            this.panelMidLeft.Controls.Add(this.longitudeRTLabel);
            this.panelMidLeft.Controls.Add(this.headingRTLabel);
            this.panelMidLeft.Controls.Add(this.altitudeRTLabel);
            this.panelMidLeft.Controls.Add(this.temperatureRTLabel);
            this.panelMidLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMidLeft.Location = new System.Drawing.Point(3, 193);
            this.panelMidLeft.Name = "panelMidLeft";
            this.panelMidLeft.Size = new System.Drawing.Size(146, 184);
            this.panelMidLeft.TabIndex = 4;
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusLabel.ForeColor = System.Drawing.Color.Black;
            this.statusLabel.Location = new System.Drawing.Point(150, 10);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(89, 20);
            this.statusLabel.TabIndex = 3;
            this.statusLabel.Text = "Status";
            // 
            // latitudeStatusLabel
            // 
            this.latitudeStatusLabel.AutoSize = true;
            this.latitudeStatusLabel.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.latitudeStatusLabel.Location = new System.Drawing.Point(10, 50);
            this.latitudeStatusLabel.Name = "latitudeStatusLabel";
            this.latitudeStatusLabel.Size = new System.Drawing.Size(84, 25);
            this.latitudeStatusLabel.TabIndex = 5;
            this.latitudeStatusLabel.Text = "Latitude";
            // 
            // longitudeStatusLabel
            // 
            this.longitudeStatusLabel.AutoSize = true;
            this.longitudeStatusLabel.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.longitudeStatusLabel.Location = new System.Drawing.Point(10, 100);
            this.longitudeStatusLabel.Name = "longitudeStatusLabel";
            this.longitudeStatusLabel.Size = new System.Drawing.Size(99, 25);
            this.longitudeStatusLabel.TabIndex = 5;
            this.longitudeStatusLabel.Text = "Longitude";
            // 
            // headingLabel
            // 
            this.headingLabel.AutoSize = true;
            this.headingLabel.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headingLabel.Location = new System.Drawing.Point(10, 150);
            this.headingLabel.Name = "headingLabel";
            this.headingLabel.Size = new System.Drawing.Size(84, 25);
            this.headingLabel.TabIndex = 5;
            this.headingLabel.Text = "Heading";
            // 
            // altitudeLabel
            // 
            this.altitudeLabel.AutoSize = true;
            this.altitudeLabel.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.altitudeLabel.Location = new System.Drawing.Point(10, 200);
            this.altitudeLabel.Name = "altitudeLabel";
            this.altitudeLabel.Size = new System.Drawing.Size(84, 25);
            this.altitudeLabel.TabIndex = 5;
            this.altitudeLabel.Text = "Altitude";
            // 
            // temperatureLabel
            // 
            this.temperatureLabel.AutoSize = true;
            this.temperatureLabel.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.temperatureLabel.Location = new System.Drawing.Point(10, 250);
            this.temperatureLabel.Name = "temperatureLabel";
            this.temperatureLabel.Size = new System.Drawing.Size(122, 25);
            this.temperatureLabel.TabIndex = 5;
            this.temperatureLabel.Text = "Temperature";
            // 
            // latitudeRTLabel
            // 
            this.latitudeRTLabel.AutoSize = true;
            this.latitudeRTLabel.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.latitudeRTLabel.Location = new System.Drawing.Point(200, 50);
            this.latitudeRTLabel.Name = "latitudeRTLabel";
            this.latitudeRTLabel.Size = new System.Drawing.Size(84, 25);
            this.latitudeRTLabel.TabIndex = 5;
            this.latitudeRTLabel.Text = "Latitude";
            // 
            // longitudeRTLabel
            // 
            this.longitudeRTLabel.AutoSize = true;
            this.longitudeRTLabel.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.longitudeRTLabel.Location = new System.Drawing.Point(200, 100);
            this.longitudeRTLabel.Name = "longitudeRTLabel";
            this.longitudeRTLabel.Size = new System.Drawing.Size(99, 25);
            this.longitudeRTLabel.TabIndex = 5;
            this.longitudeRTLabel.Text = "Longitude";
            // 
            // headingRTLabel
            // 
            this.headingRTLabel.AutoSize = true;
            this.headingRTLabel.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headingRTLabel.Location = new System.Drawing.Point(200, 150);
            this.headingRTLabel.Name = "headingRTLabel";
            this.headingRTLabel.Size = new System.Drawing.Size(84, 25);
            this.headingRTLabel.TabIndex = 5;
            this.headingRTLabel.Text = "Heading";
            // 
            // altitudeRTLabel
            // 
            this.altitudeRTLabel.AutoSize = true;
            this.altitudeRTLabel.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.altitudeRTLabel.Location = new System.Drawing.Point(200, 200);
            this.altitudeRTLabel.Name = "altitudeRTLabel";
            this.altitudeRTLabel.Size = new System.Drawing.Size(84, 25);
            this.altitudeRTLabel.TabIndex = 5;
            this.altitudeRTLabel.Text = "Altitude";
            // 
            // temperatureRTLabel
            // 
            this.temperatureRTLabel.AutoSize = true;
            this.temperatureRTLabel.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.temperatureRTLabel.Location = new System.Drawing.Point(200, 250);
            this.temperatureRTLabel.Name = "temperatureRTLabel";
            this.temperatureRTLabel.Size = new System.Drawing.Size(122, 25);
            this.temperatureRTLabel.TabIndex = 5;
            this.temperatureRTLabel.Text = "Temperature";
            // 
            // panelBotLeft
            // 
            this.panelBotLeft.BackColor = System.Drawing.Color.LightBlue;
            this.panelBotLeft.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelBotLeft.Controls.Add(this.waypointLabel);
            this.panelBotLeft.Controls.Add(this.searchButt);
            this.panelBotLeft.Controls.Add(this.sendButt);
            this.panelBotLeft.Controls.Add(this.longitudeLabel);
            this.panelBotLeft.Controls.Add(this.latitudeLabel);
            this.panelBotLeft.Controls.Add(this.longitudeTextBox);
            this.panelBotLeft.Controls.Add(this.latitudeTextBox);
            this.panelBotLeft.Controls.Add(this.createListButt);
            this.panelBotLeft.Controls.Add(this.homeButt);
            this.panelBotLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBotLeft.Location = new System.Drawing.Point(3, 383);
            this.panelBotLeft.Name = "panelBotLeft";
            this.panelBotLeft.Size = new System.Drawing.Size(146, 186);
            this.panelBotLeft.TabIndex = 5;
            // 
            // waypointLabel
            // 
            this.waypointLabel.AutoSize = true;
            this.waypointLabel.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.waypointLabel.ForeColor = System.Drawing.Color.Black;
            this.waypointLabel.Location = new System.Drawing.Point(130, 10);
            this.waypointLabel.Name = "waypointLabel";
            this.waypointLabel.Size = new System.Drawing.Size(142, 20);
            this.waypointLabel.TabIndex = 4;
            this.waypointLabel.Text = "Waypoints";
            // 
            // searchButt
            // 
            this.searchButt.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchButt.Location = new System.Drawing.Point(10, 150);
            this.searchButt.Name = "searchButt";
            this.searchButt.Size = new System.Drawing.Size(150, 50);
            this.searchButt.TabIndex = 12;
            this.searchButt.Text = "Search";
            this.searchButt.UseVisualStyleBackColor = true;
            this.searchButt.Click += new System.EventHandler(this.searchButt_Click);
            // 
            // sendButt
            // 
            this.sendButt.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sendButt.Location = new System.Drawing.Point(200, 150);
            this.sendButt.Name = "sendButt";
            this.sendButt.Size = new System.Drawing.Size(150, 50);
            this.sendButt.TabIndex = 15;
            this.sendButt.Text = "Send";
            this.sendButt.UseVisualStyleBackColor = true;
            this.sendButt.Click += new System.EventHandler(this.sendButt_Click);
            // 
            // longitudeLabel
            // 
            this.longitudeLabel.AutoSize = true;
            this.longitudeLabel.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.longitudeLabel.Location = new System.Drawing.Point(10, 100);
            this.longitudeLabel.Name = "longitudeLabel";
            this.longitudeLabel.Size = new System.Drawing.Size(99, 25);
            this.longitudeLabel.TabIndex = 5;
            this.longitudeLabel.Text = "Longitude";
            // 
            // latitudeLabel
            // 
            this.latitudeLabel.AutoSize = true;
            this.latitudeLabel.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.latitudeLabel.Location = new System.Drawing.Point(10, 50);
            this.latitudeLabel.Name = "latitudeLabel";
            this.latitudeLabel.Size = new System.Drawing.Size(84, 25);
            this.latitudeLabel.TabIndex = 4;
            this.latitudeLabel.Text = "Latitude";
            // 
            // longitudeTextBox
            // 
            this.longitudeTextBox.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.longitudeTextBox.Location = new System.Drawing.Point(150, 100);
            this.longitudeTextBox.Name = "longitudeTextBox";
            this.longitudeTextBox.Size = new System.Drawing.Size(200, 33);
            this.longitudeTextBox.TabIndex = 2;
            // 
            // latitudeTextBox
            // 
            this.latitudeTextBox.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.latitudeTextBox.Location = new System.Drawing.Point(150, 50);
            this.latitudeTextBox.Name = "latitudeTextBox";
            this.latitudeTextBox.Size = new System.Drawing.Size(200, 33);
            this.latitudeTextBox.TabIndex = 1;
            // 
            // createListButt
            // 
            this.createListButt.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createListButt.Location = new System.Drawing.Point(10, 225);
            this.createListButt.Name = "createListButt";
            this.createListButt.Size = new System.Drawing.Size(150, 50);
            this.createListButt.TabIndex = 12;
            this.createListButt.Text = "Create List";
            this.createListButt.UseVisualStyleBackColor = true;
            this.createListButt.Click += new System.EventHandler(this.createListButt_Click);
            // 
            // resetButt
            // 
            this.resetButt.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetButt.Location = new System.Drawing.Point(200, 225);
            this.resetButt.Name = "resetButt";
            this.resetButt.Size = new System.Drawing.Size(150, 50);
            this.resetButt.TabIndex = 12;
            this.resetButt.Text = "Reset";
            this.resetButt.UseVisualStyleBackColor = true;
            this.resetButt.Click += new System.EventHandler(this.resetButt_Click);
            // 
            // homeButt
            // 
            this.homeButt.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homeButt.Location = new System.Drawing.Point(200, 225);
            this.homeButt.Name = "homeButt";
            this.homeButt.Size = new System.Drawing.Size(150, 50);
            this.homeButt.TabIndex = 12;
            this.homeButt.Text = "Home";
            this.homeButt.UseVisualStyleBackColor = true;
            this.homeButt.Click += new System.EventHandler(this.homeButt_Click);
            // 
            // panelRight
            // 
            this.panelRight.BackColor = System.Drawing.Color.LightBlue;
            this.panelRight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelRight.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 632F));
            this.panelRight.Controls.Add(this.gMapControl1);
            this.panelRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelRight.Location = new System.Drawing.Point(163, 3);
            this.panelRight.Name = "panelRight";
            this.panelRight.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 592F));
            this.panelRight.Size = new System.Drawing.Size(634, 574);
            this.panelRight.TabIndex = 2;
            // 
            // gMapControl1
            // 
            this.gMapControl1.Bearing = 0F;
            this.gMapControl1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.gMapControl1.CanDragMap = true;
            this.gMapControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gMapControl1.EmptyTileColor = System.Drawing.Color.Navy;
            this.gMapControl1.GrayScaleMode = false;
            this.gMapControl1.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.gMapControl1.LevelsKeepInMemory = 5;
            this.gMapControl1.Location = new System.Drawing.Point(3, 3);
            this.gMapControl1.MarkersEnabled = true;
            this.gMapControl1.MaxZoom = 2;
            this.gMapControl1.MinZoom = 2;
            this.gMapControl1.MouseWheelZoomEnabled = true;
            this.gMapControl1.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.gMapControl1.Name = "gMapControl1";
            this.gMapControl1.NegativeMode = false;
            this.gMapControl1.PolygonsEnabled = true;
            this.gMapControl1.RetryLoadTile = 0;
            this.gMapControl1.RoutesEnabled = true;
            this.gMapControl1.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.gMapControl1.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.gMapControl1.ShowTileGridLines = false;
            this.gMapControl1.Size = new System.Drawing.Size(626, 586);
            this.gMapControl1.TabIndex = 6;
            this.gMapControl1.Zoom = 0D;
            this.gMapControl1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.gMapControl1_MouseDown);
            this.gMapControl1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.gMapControl1_MouseUp);
            // 
            // UAVFlightWaypoint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.TableLayoutPanel);
            this.Name = "UAVFlightWaypoint";
            this.Text = "UAV Fly Waypoint";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.UAVFlightWaypoint_FormClosing);
            this.TableLayoutPanel.ResumeLayout(false);
            this.TableLayoutPanel.PerformLayout();
            this.panelLeft.ResumeLayout(false);
            this.panelTopLeft.ResumeLayout(false);
            this.panelTopLeft.PerformLayout();
            this.panelMidLeft.ResumeLayout(false);
            this.panelMidLeft.PerformLayout();
            this.panelBotLeft.ResumeLayout(false);
            this.panelBotLeft.PerformLayout();
            this.panelRight.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel TableLayoutPanel;
        private System.Windows.Forms.TableLayoutPanel panelLeft;
        private System.Windows.Forms.TableLayoutPanel panelRight;
        private System.Windows.Forms.Panel panelTopLeft;
        private System.Windows.Forms.Panel panelMidLeft;
        private System.Windows.Forms.Panel panelBotLeft;

        private GMap.NET.WindowsForms.GMapControl gMapControl1;

        private System.Windows.Forms.Label latitudeLabel;
        private System.Windows.Forms.Label longitudeLabel;
        private System.Windows.Forms.Label latitudeStatusLabel;
        private System.Windows.Forms.Label longitudeStatusLabel;
        private System.Windows.Forms.Label IPAddressLabel;
        private System.Windows.Forms.Label portLabel;
        private System.Windows.Forms.Label connectLabel;
        private System.Windows.Forms.Label waypointLabel;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.Label headingLabel;
        private System.Windows.Forms.Label altitudeLabel;
        private System.Windows.Forms.Label temperatureLabel;
        private System.Windows.Forms.Label latitudeRTLabel;
        private System.Windows.Forms.Label longitudeRTLabel;
        private System.Windows.Forms.Label headingRTLabel;
        private System.Windows.Forms.Label altitudeRTLabel;
        private System.Windows.Forms.Label temperatureRTLabel;

        private System.Windows.Forms.TextBox latitudeTextBox;
        private System.Windows.Forms.TextBox longitudeTextBox;
        private System.Windows.Forms.TextBox IPAddressTextBox;
        private System.Windows.Forms.TextBox portTextBox;

        private System.Windows.Forms.Button searchButt;
        private System.Windows.Forms.Button exitButt;
        private System.Windows.Forms.Button startButt;
        private System.Windows.Forms.Button stopButt;
        private System.Windows.Forms.Button sendButt;
        private System.Windows.Forms.Button createListButt;
        private System.Windows.Forms.Button resetButt;
        private System.Windows.Forms.Button homeButt;
    }
}

