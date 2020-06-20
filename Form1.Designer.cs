namespace ARP_Spoofer
{
    partial class Form_Main
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.btn_stop_arp_reply = new System.Windows.Forms.Button();
            this.tB_arp_destination_ip1 = new System.Windows.Forms.TextBox();
            this.tB_arp_destination_ip2 = new System.Windows.Forms.TextBox();
            this.tB_arp_destination_ip3 = new System.Windows.Forms.TextBox();
            this.tB_arp_destination_ip4 = new System.Windows.Forms.TextBox();
            this.tB_arp_sender_ip4 = new System.Windows.Forms.TextBox();
            this.tB_arp_sender_ip3 = new System.Windows.Forms.TextBox();
            this.tB_arp_sender_ip2 = new System.Windows.Forms.TextBox();
            this.tB_arp_sender_ip1 = new System.Windows.Forms.TextBox();
            this.cB_select_adapter = new System.Windows.Forms.ComboBox();
            this.btn_send_arp_reply = new System.Windows.Forms.Button();
            this.tB_arp_destination_mac1 = new System.Windows.Forms.TextBox();
            this.tB_ethernet_destination_mac1 = new System.Windows.Forms.TextBox();
            this.lbl_status = new System.Windows.Forms.Label();
            this.tB_send_interval = new System.Windows.Forms.TextBox();
            this.tB_arp_destination_mac2 = new System.Windows.Forms.TextBox();
            this.tB_arp_destination_mac3 = new System.Windows.Forms.TextBox();
            this.tB_arp_destination_mac4 = new System.Windows.Forms.TextBox();
            this.tB_arp_destination_mac5 = new System.Windows.Forms.TextBox();
            this.tB_arp_destination_mac6 = new System.Windows.Forms.TextBox();
            this.tB_arp_sender_mac1 = new System.Windows.Forms.TextBox();
            this.tB_arp_sender_mac2 = new System.Windows.Forms.TextBox();
            this.tB_arp_sender_mac3 = new System.Windows.Forms.TextBox();
            this.tB_arp_sender_mac4 = new System.Windows.Forms.TextBox();
            this.tB_arp_sender_mac5 = new System.Windows.Forms.TextBox();
            this.tB_arp_sender_mac6 = new System.Windows.Forms.TextBox();
            this.tB_ethernet_destination_mac2 = new System.Windows.Forms.TextBox();
            this.tB_ethernet_destination_mac3 = new System.Windows.Forms.TextBox();
            this.tB_ethernet_destination_mac4 = new System.Windows.Forms.TextBox();
            this.tB_ethernet_destination_mac5 = new System.Windows.Forms.TextBox();
            this.tB_ethernet_destination_mac6 = new System.Windows.Forms.TextBox();
            this.tB_ethernet_sender_mac1 = new System.Windows.Forms.TextBox();
            this.tB_ethernet_sender_mac2 = new System.Windows.Forms.TextBox();
            this.tB_ethernet_sender_mac3 = new System.Windows.Forms.TextBox();
            this.tB_ethernet_sender_mac4 = new System.Windows.Forms.TextBox();
            this.tB_ethernet_sender_mac5 = new System.Windows.Forms.TextBox();
            this.tB_ethernet_sender_mac6 = new System.Windows.Forms.TextBox();
            this.lbl_title = new System.Windows.Forms.Label();
            this.lbl_interval_in_ms = new System.Windows.Forms.Label();
            this.lbl_arp_target_ip = new System.Windows.Forms.Label();
            this.lbl_arp_target_mac = new System.Windows.Forms.Label();
            this.lbl_arp_sender_ip = new System.Windows.Forms.Label();
            this.lbl_arp_sender_mac = new System.Windows.Forms.Label();
            this.lbl_ethernet_destination = new System.Windows.Forms.Label();
            this.lbl_ethernet_sender = new System.Windows.Forms.Label();
            this.tB_ping_results = new System.Windows.Forms.TextBox();
            this.lbl_to = new System.Windows.Forms.Label();
            this.lbl_from = new System.Windows.Forms.Label();
            this.lbl_dot2 = new System.Windows.Forms.Label();
            this.tB_scanto_host = new System.Windows.Forms.TextBox();
            this.tB_scanto_Net = new System.Windows.Forms.TextBox();
            this.lbl_dot1 = new System.Windows.Forms.Label();
            this.tB_scanfrom_host = new System.Windows.Forms.TextBox();
            this.tB_scanfrom_Net = new System.Windows.Forms.TextBox();
            this.btn_IPscan = new System.Windows.Forms.Button();
            this.menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(321, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveSettingsToolStripMenuItem,
            this.helpToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // saveSettingsToolStripMenuItem
            // 
            this.saveSettingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.loadToolStripMenuItem});
            this.saveSettingsToolStripMenuItem.Name = "saveSettingsToolStripMenuItem";
            this.saveSettingsToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.saveSettingsToolStripMenuItem.Text = "Settings";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.loadToolStripMenuItem.Text = "Load";
            this.loadToolStripMenuItem.Click += new System.EventHandler(this.loadToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.helpToolStripMenuItem.Text = "Help";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // splitContainer
            // 
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer.Location = new System.Drawing.Point(0, 24);
            this.splitContainer.Name = "splitContainer";
            this.splitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.BackColor = System.Drawing.Color.MediumTurquoise;
            this.splitContainer.Panel1.Controls.Add(this.btn_stop_arp_reply);
            this.splitContainer.Panel1.Controls.Add(this.tB_arp_destination_ip1);
            this.splitContainer.Panel1.Controls.Add(this.tB_arp_destination_ip2);
            this.splitContainer.Panel1.Controls.Add(this.tB_arp_destination_ip3);
            this.splitContainer.Panel1.Controls.Add(this.tB_arp_destination_ip4);
            this.splitContainer.Panel1.Controls.Add(this.tB_arp_sender_ip4);
            this.splitContainer.Panel1.Controls.Add(this.tB_arp_sender_ip3);
            this.splitContainer.Panel1.Controls.Add(this.tB_arp_sender_ip2);
            this.splitContainer.Panel1.Controls.Add(this.tB_arp_sender_ip1);
            this.splitContainer.Panel1.Controls.Add(this.cB_select_adapter);
            this.splitContainer.Panel1.Controls.Add(this.btn_send_arp_reply);
            this.splitContainer.Panel1.Controls.Add(this.tB_arp_destination_mac1);
            this.splitContainer.Panel1.Controls.Add(this.tB_ethernet_destination_mac1);
            this.splitContainer.Panel1.Controls.Add(this.lbl_status);
            this.splitContainer.Panel1.Controls.Add(this.tB_send_interval);
            this.splitContainer.Panel1.Controls.Add(this.tB_arp_destination_mac2);
            this.splitContainer.Panel1.Controls.Add(this.tB_arp_destination_mac3);
            this.splitContainer.Panel1.Controls.Add(this.tB_arp_destination_mac4);
            this.splitContainer.Panel1.Controls.Add(this.tB_arp_destination_mac5);
            this.splitContainer.Panel1.Controls.Add(this.tB_arp_destination_mac6);
            this.splitContainer.Panel1.Controls.Add(this.tB_arp_sender_mac1);
            this.splitContainer.Panel1.Controls.Add(this.tB_arp_sender_mac2);
            this.splitContainer.Panel1.Controls.Add(this.tB_arp_sender_mac3);
            this.splitContainer.Panel1.Controls.Add(this.tB_arp_sender_mac4);
            this.splitContainer.Panel1.Controls.Add(this.tB_arp_sender_mac5);
            this.splitContainer.Panel1.Controls.Add(this.tB_arp_sender_mac6);
            this.splitContainer.Panel1.Controls.Add(this.tB_ethernet_destination_mac2);
            this.splitContainer.Panel1.Controls.Add(this.tB_ethernet_destination_mac3);
            this.splitContainer.Panel1.Controls.Add(this.tB_ethernet_destination_mac4);
            this.splitContainer.Panel1.Controls.Add(this.tB_ethernet_destination_mac5);
            this.splitContainer.Panel1.Controls.Add(this.tB_ethernet_destination_mac6);
            this.splitContainer.Panel1.Controls.Add(this.tB_ethernet_sender_mac1);
            this.splitContainer.Panel1.Controls.Add(this.tB_ethernet_sender_mac2);
            this.splitContainer.Panel1.Controls.Add(this.tB_ethernet_sender_mac3);
            this.splitContainer.Panel1.Controls.Add(this.tB_ethernet_sender_mac4);
            this.splitContainer.Panel1.Controls.Add(this.tB_ethernet_sender_mac5);
            this.splitContainer.Panel1.Controls.Add(this.tB_ethernet_sender_mac6);
            this.splitContainer.Panel1.Controls.Add(this.lbl_title);
            this.splitContainer.Panel1.Controls.Add(this.lbl_interval_in_ms);
            this.splitContainer.Panel1.Controls.Add(this.lbl_arp_target_ip);
            this.splitContainer.Panel1.Controls.Add(this.lbl_arp_target_mac);
            this.splitContainer.Panel1.Controls.Add(this.lbl_arp_sender_ip);
            this.splitContainer.Panel1.Controls.Add(this.lbl_arp_sender_mac);
            this.splitContainer.Panel1.Controls.Add(this.lbl_ethernet_destination);
            this.splitContainer.Panel1.Controls.Add(this.lbl_ethernet_sender);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.splitContainer.Panel2.Controls.Add(this.tB_ping_results);
            this.splitContainer.Panel2.Controls.Add(this.lbl_to);
            this.splitContainer.Panel2.Controls.Add(this.lbl_from);
            this.splitContainer.Panel2.Controls.Add(this.lbl_dot2);
            this.splitContainer.Panel2.Controls.Add(this.tB_scanto_host);
            this.splitContainer.Panel2.Controls.Add(this.tB_scanto_Net);
            this.splitContainer.Panel2.Controls.Add(this.lbl_dot1);
            this.splitContainer.Panel2.Controls.Add(this.tB_scanfrom_host);
            this.splitContainer.Panel2.Controls.Add(this.tB_scanfrom_Net);
            this.splitContainer.Panel2.Controls.Add(this.btn_IPscan);
            this.splitContainer.Size = new System.Drawing.Size(321, 666);
            this.splitContainer.SplitterDistance = 372;
            this.splitContainer.TabIndex = 1;
            // 
            // btn_stop_arp_reply
            // 
            this.btn_stop_arp_reply.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_stop_arp_reply.ForeColor = System.Drawing.Color.Red;
            this.btn_stop_arp_reply.Location = new System.Drawing.Point(3, 344);
            this.btn_stop_arp_reply.Name = "btn_stop_arp_reply";
            this.btn_stop_arp_reply.Size = new System.Drawing.Size(148, 26);
            this.btn_stop_arp_reply.TabIndex = 37;
            this.btn_stop_arp_reply.Text = "Stop Sending";
            this.btn_stop_arp_reply.UseVisualStyleBackColor = true;
            this.btn_stop_arp_reply.Click += new System.EventHandler(this.btn_stop_arp_reply_Click);
            // 
            // tB_arp_destination_ip1
            // 
            this.tB_arp_destination_ip1.Location = new System.Drawing.Point(129, 260);
            this.tB_arp_destination_ip1.Name = "tB_arp_destination_ip1";
            this.tB_arp_destination_ip1.Size = new System.Drawing.Size(26, 20);
            this.tB_arp_destination_ip1.TabIndex = 30;
            // 
            // tB_arp_destination_ip2
            // 
            this.tB_arp_destination_ip2.Location = new System.Drawing.Point(161, 260);
            this.tB_arp_destination_ip2.Name = "tB_arp_destination_ip2";
            this.tB_arp_destination_ip2.Size = new System.Drawing.Size(26, 20);
            this.tB_arp_destination_ip2.TabIndex = 31;
            // 
            // tB_arp_destination_ip3
            // 
            this.tB_arp_destination_ip3.Location = new System.Drawing.Point(193, 260);
            this.tB_arp_destination_ip3.Name = "tB_arp_destination_ip3";
            this.tB_arp_destination_ip3.Size = new System.Drawing.Size(26, 20);
            this.tB_arp_destination_ip3.TabIndex = 33;
            // 
            // tB_arp_destination_ip4
            // 
            this.tB_arp_destination_ip4.Location = new System.Drawing.Point(225, 260);
            this.tB_arp_destination_ip4.Name = "tB_arp_destination_ip4";
            this.tB_arp_destination_ip4.Size = new System.Drawing.Size(26, 20);
            this.tB_arp_destination_ip4.TabIndex = 34;
            // 
            // tB_arp_sender_ip4
            // 
            this.tB_arp_sender_ip4.Location = new System.Drawing.Point(225, 191);
            this.tB_arp_sender_ip4.Name = "tB_arp_sender_ip4";
            this.tB_arp_sender_ip4.Size = new System.Drawing.Size(26, 20);
            this.tB_arp_sender_ip4.TabIndex = 23;
            // 
            // tB_arp_sender_ip3
            // 
            this.tB_arp_sender_ip3.Location = new System.Drawing.Point(193, 191);
            this.tB_arp_sender_ip3.Name = "tB_arp_sender_ip3";
            this.tB_arp_sender_ip3.Size = new System.Drawing.Size(26, 20);
            this.tB_arp_sender_ip3.TabIndex = 22;
            // 
            // tB_arp_sender_ip2
            // 
            this.tB_arp_sender_ip2.Location = new System.Drawing.Point(161, 191);
            this.tB_arp_sender_ip2.Name = "tB_arp_sender_ip2";
            this.tB_arp_sender_ip2.Size = new System.Drawing.Size(26, 20);
            this.tB_arp_sender_ip2.TabIndex = 21;
            // 
            // tB_arp_sender_ip1
            // 
            this.tB_arp_sender_ip1.Location = new System.Drawing.Point(129, 191);
            this.tB_arp_sender_ip1.Name = "tB_arp_sender_ip1";
            this.tB_arp_sender_ip1.Size = new System.Drawing.Size(26, 20);
            this.tB_arp_sender_ip1.TabIndex = 20;
            // 
            // cB_select_adapter
            // 
            this.cB_select_adapter.DropDownWidth = 400;
            this.cB_select_adapter.FormattingEnabled = true;
            this.cB_select_adapter.Location = new System.Drawing.Point(6, 52);
            this.cB_select_adapter.MaxDropDownItems = 10;
            this.cB_select_adapter.Name = "cB_select_adapter";
            this.cB_select_adapter.Size = new System.Drawing.Size(309, 21);
            this.cB_select_adapter.TabIndex = 1;
            // 
            // btn_send_arp_reply
            // 
            this.btn_send_arp_reply.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_send_arp_reply.ForeColor = System.Drawing.Color.DarkGreen;
            this.btn_send_arp_reply.Location = new System.Drawing.Point(170, 344);
            this.btn_send_arp_reply.Name = "btn_send_arp_reply";
            this.btn_send_arp_reply.Size = new System.Drawing.Size(148, 26);
            this.btn_send_arp_reply.TabIndex = 36;
            this.btn_send_arp_reply.Text = "Start Sending";
            this.btn_send_arp_reply.UseVisualStyleBackColor = true;
            this.btn_send_arp_reply.Click += new System.EventHandler(this.btn_send_arp_reply_Click);
            // 
            // tB_arp_destination_mac1
            // 
            this.tB_arp_destination_mac1.Location = new System.Drawing.Point(129, 226);
            this.tB_arp_destination_mac1.Name = "tB_arp_destination_mac1";
            this.tB_arp_destination_mac1.Size = new System.Drawing.Size(26, 20);
            this.tB_arp_destination_mac1.TabIndex = 24;
            // 
            // tB_ethernet_destination_mac1
            // 
            this.tB_ethernet_destination_mac1.Location = new System.Drawing.Point(129, 123);
            this.tB_ethernet_destination_mac1.Name = "tB_ethernet_destination_mac1";
            this.tB_ethernet_destination_mac1.Size = new System.Drawing.Size(26, 20);
            this.tB_ethernet_destination_mac1.TabIndex = 8;
            // 
            // lbl_status
            // 
            this.lbl_status.AutoSize = true;
            this.lbl_status.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_status.ForeColor = System.Drawing.Color.Red;
            this.lbl_status.Location = new System.Drawing.Point(3, 324);
            this.lbl_status.Name = "lbl_status";
            this.lbl_status.Size = new System.Drawing.Size(17, 16);
            this.lbl_status.TabIndex = 35;
            this.lbl_status.Text = "...";
            // 
            // tB_send_interval
            // 
            this.tB_send_interval.Location = new System.Drawing.Point(129, 293);
            this.tB_send_interval.Name = "tB_send_interval";
            this.tB_send_interval.Size = new System.Drawing.Size(40, 20);
            this.tB_send_interval.TabIndex = 35;
            // 
            // tB_arp_destination_mac2
            // 
            this.tB_arp_destination_mac2.Location = new System.Drawing.Point(161, 226);
            this.tB_arp_destination_mac2.Name = "tB_arp_destination_mac2";
            this.tB_arp_destination_mac2.Size = new System.Drawing.Size(26, 20);
            this.tB_arp_destination_mac2.TabIndex = 25;
            // 
            // tB_arp_destination_mac3
            // 
            this.tB_arp_destination_mac3.Location = new System.Drawing.Point(193, 226);
            this.tB_arp_destination_mac3.Name = "tB_arp_destination_mac3";
            this.tB_arp_destination_mac3.Size = new System.Drawing.Size(26, 20);
            this.tB_arp_destination_mac3.TabIndex = 26;
            // 
            // tB_arp_destination_mac4
            // 
            this.tB_arp_destination_mac4.Location = new System.Drawing.Point(225, 226);
            this.tB_arp_destination_mac4.Name = "tB_arp_destination_mac4";
            this.tB_arp_destination_mac4.Size = new System.Drawing.Size(26, 20);
            this.tB_arp_destination_mac4.TabIndex = 27;
            // 
            // tB_arp_destination_mac5
            // 
            this.tB_arp_destination_mac5.Location = new System.Drawing.Point(257, 226);
            this.tB_arp_destination_mac5.Name = "tB_arp_destination_mac5";
            this.tB_arp_destination_mac5.Size = new System.Drawing.Size(26, 20);
            this.tB_arp_destination_mac5.TabIndex = 28;
            // 
            // tB_arp_destination_mac6
            // 
            this.tB_arp_destination_mac6.Location = new System.Drawing.Point(289, 226);
            this.tB_arp_destination_mac6.Name = "tB_arp_destination_mac6";
            this.tB_arp_destination_mac6.Size = new System.Drawing.Size(26, 20);
            this.tB_arp_destination_mac6.TabIndex = 29;
            // 
            // tB_arp_sender_mac1
            // 
            this.tB_arp_sender_mac1.Location = new System.Drawing.Point(129, 155);
            this.tB_arp_sender_mac1.Name = "tB_arp_sender_mac1";
            this.tB_arp_sender_mac1.Size = new System.Drawing.Size(26, 20);
            this.tB_arp_sender_mac1.TabIndex = 14;
            // 
            // tB_arp_sender_mac2
            // 
            this.tB_arp_sender_mac2.Location = new System.Drawing.Point(161, 155);
            this.tB_arp_sender_mac2.Name = "tB_arp_sender_mac2";
            this.tB_arp_sender_mac2.Size = new System.Drawing.Size(26, 20);
            this.tB_arp_sender_mac2.TabIndex = 15;
            // 
            // tB_arp_sender_mac3
            // 
            this.tB_arp_sender_mac3.Location = new System.Drawing.Point(193, 155);
            this.tB_arp_sender_mac3.Name = "tB_arp_sender_mac3";
            this.tB_arp_sender_mac3.Size = new System.Drawing.Size(26, 20);
            this.tB_arp_sender_mac3.TabIndex = 16;
            // 
            // tB_arp_sender_mac4
            // 
            this.tB_arp_sender_mac4.Location = new System.Drawing.Point(225, 155);
            this.tB_arp_sender_mac4.Name = "tB_arp_sender_mac4";
            this.tB_arp_sender_mac4.Size = new System.Drawing.Size(26, 20);
            this.tB_arp_sender_mac4.TabIndex = 17;
            // 
            // tB_arp_sender_mac5
            // 
            this.tB_arp_sender_mac5.Location = new System.Drawing.Point(257, 155);
            this.tB_arp_sender_mac5.Name = "tB_arp_sender_mac5";
            this.tB_arp_sender_mac5.Size = new System.Drawing.Size(26, 20);
            this.tB_arp_sender_mac5.TabIndex = 18;
            // 
            // tB_arp_sender_mac6
            // 
            this.tB_arp_sender_mac6.Location = new System.Drawing.Point(289, 155);
            this.tB_arp_sender_mac6.Name = "tB_arp_sender_mac6";
            this.tB_arp_sender_mac6.Size = new System.Drawing.Size(26, 20);
            this.tB_arp_sender_mac6.TabIndex = 19;
            // 
            // tB_ethernet_destination_mac2
            // 
            this.tB_ethernet_destination_mac2.Location = new System.Drawing.Point(161, 123);
            this.tB_ethernet_destination_mac2.Name = "tB_ethernet_destination_mac2";
            this.tB_ethernet_destination_mac2.Size = new System.Drawing.Size(26, 20);
            this.tB_ethernet_destination_mac2.TabIndex = 9;
            // 
            // tB_ethernet_destination_mac3
            // 
            this.tB_ethernet_destination_mac3.Location = new System.Drawing.Point(193, 123);
            this.tB_ethernet_destination_mac3.Name = "tB_ethernet_destination_mac3";
            this.tB_ethernet_destination_mac3.Size = new System.Drawing.Size(26, 20);
            this.tB_ethernet_destination_mac3.TabIndex = 10;
            // 
            // tB_ethernet_destination_mac4
            // 
            this.tB_ethernet_destination_mac4.Location = new System.Drawing.Point(225, 123);
            this.tB_ethernet_destination_mac4.Name = "tB_ethernet_destination_mac4";
            this.tB_ethernet_destination_mac4.Size = new System.Drawing.Size(26, 20);
            this.tB_ethernet_destination_mac4.TabIndex = 11;
            // 
            // tB_ethernet_destination_mac5
            // 
            this.tB_ethernet_destination_mac5.Location = new System.Drawing.Point(257, 123);
            this.tB_ethernet_destination_mac5.Name = "tB_ethernet_destination_mac5";
            this.tB_ethernet_destination_mac5.Size = new System.Drawing.Size(26, 20);
            this.tB_ethernet_destination_mac5.TabIndex = 12;
            // 
            // tB_ethernet_destination_mac6
            // 
            this.tB_ethernet_destination_mac6.Location = new System.Drawing.Point(289, 123);
            this.tB_ethernet_destination_mac6.Name = "tB_ethernet_destination_mac6";
            this.tB_ethernet_destination_mac6.Size = new System.Drawing.Size(26, 20);
            this.tB_ethernet_destination_mac6.TabIndex = 13;
            // 
            // tB_ethernet_sender_mac1
            // 
            this.tB_ethernet_sender_mac1.Location = new System.Drawing.Point(129, 93);
            this.tB_ethernet_sender_mac1.Name = "tB_ethernet_sender_mac1";
            this.tB_ethernet_sender_mac1.Size = new System.Drawing.Size(26, 20);
            this.tB_ethernet_sender_mac1.TabIndex = 2;
            // 
            // tB_ethernet_sender_mac2
            // 
            this.tB_ethernet_sender_mac2.Location = new System.Drawing.Point(161, 93);
            this.tB_ethernet_sender_mac2.Name = "tB_ethernet_sender_mac2";
            this.tB_ethernet_sender_mac2.Size = new System.Drawing.Size(26, 20);
            this.tB_ethernet_sender_mac2.TabIndex = 3;
            // 
            // tB_ethernet_sender_mac3
            // 
            this.tB_ethernet_sender_mac3.Location = new System.Drawing.Point(193, 93);
            this.tB_ethernet_sender_mac3.Name = "tB_ethernet_sender_mac3";
            this.tB_ethernet_sender_mac3.Size = new System.Drawing.Size(26, 20);
            this.tB_ethernet_sender_mac3.TabIndex = 4;
            // 
            // tB_ethernet_sender_mac4
            // 
            this.tB_ethernet_sender_mac4.Location = new System.Drawing.Point(225, 93);
            this.tB_ethernet_sender_mac4.Name = "tB_ethernet_sender_mac4";
            this.tB_ethernet_sender_mac4.Size = new System.Drawing.Size(26, 20);
            this.tB_ethernet_sender_mac4.TabIndex = 5;
            // 
            // tB_ethernet_sender_mac5
            // 
            this.tB_ethernet_sender_mac5.Location = new System.Drawing.Point(257, 93);
            this.tB_ethernet_sender_mac5.Name = "tB_ethernet_sender_mac5";
            this.tB_ethernet_sender_mac5.Size = new System.Drawing.Size(26, 20);
            this.tB_ethernet_sender_mac5.TabIndex = 6;
            // 
            // tB_ethernet_sender_mac6
            // 
            this.tB_ethernet_sender_mac6.Location = new System.Drawing.Point(289, 93);
            this.tB_ethernet_sender_mac6.Name = "tB_ethernet_sender_mac6";
            this.tB_ethernet_sender_mac6.Size = new System.Drawing.Size(26, 20);
            this.tB_ethernet_sender_mac6.TabIndex = 7;
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.Location = new System.Drawing.Point(5, 13);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(177, 24);
            this.lbl_title.TabIndex = 7;
            this.lbl_title.Text = "Create ARP Reply";
            // 
            // lbl_interval_in_ms
            // 
            this.lbl_interval_in_ms.AutoSize = true;
            this.lbl_interval_in_ms.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_interval_in_ms.Location = new System.Drawing.Point(6, 294);
            this.lbl_interval_in_ms.Name = "lbl_interval_in_ms";
            this.lbl_interval_in_ms.Size = new System.Drawing.Size(103, 15);
            this.lbl_interval_in_ms.TabIndex = 6;
            this.lbl_interval_in_ms.Text = "Send Inerval (ms)";
            // 
            // lbl_arp_target_ip
            // 
            this.lbl_arp_target_ip.AutoSize = true;
            this.lbl_arp_target_ip.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_arp_target_ip.Location = new System.Drawing.Point(6, 261);
            this.lbl_arp_target_ip.Name = "lbl_arp_target_ip";
            this.lbl_arp_target_ip.Size = new System.Drawing.Size(104, 15);
            this.lbl_arp_target_ip.TabIndex = 5;
            this.lbl_arp_target_ip.Text = "Arp Destination IP";
            // 
            // lbl_arp_target_mac
            // 
            this.lbl_arp_target_mac.AutoSize = true;
            this.lbl_arp_target_mac.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_arp_target_mac.Location = new System.Drawing.Point(6, 227);
            this.lbl_arp_target_mac.Name = "lbl_arp_target_mac";
            this.lbl_arp_target_mac.Size = new System.Drawing.Size(119, 15);
            this.lbl_arp_target_mac.TabIndex = 4;
            this.lbl_arp_target_mac.Text = "Arp Destination MAC";
            // 
            // lbl_arp_sender_ip
            // 
            this.lbl_arp_sender_ip.AutoSize = true;
            this.lbl_arp_sender_ip.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_arp_sender_ip.Location = new System.Drawing.Point(6, 192);
            this.lbl_arp_sender_ip.Name = "lbl_arp_sender_ip";
            this.lbl_arp_sender_ip.Size = new System.Drawing.Size(82, 15);
            this.lbl_arp_sender_ip.TabIndex = 3;
            this.lbl_arp_sender_ip.Text = "Arp Sender IP";
            // 
            // lbl_arp_sender_mac
            // 
            this.lbl_arp_sender_mac.AutoSize = true;
            this.lbl_arp_sender_mac.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_arp_sender_mac.Location = new System.Drawing.Point(6, 156);
            this.lbl_arp_sender_mac.Name = "lbl_arp_sender_mac";
            this.lbl_arp_sender_mac.Size = new System.Drawing.Size(97, 15);
            this.lbl_arp_sender_mac.TabIndex = 2;
            this.lbl_arp_sender_mac.Text = "Arp Sender MAC";
            // 
            // lbl_ethernet_destination
            // 
            this.lbl_ethernet_destination.AutoSize = true;
            this.lbl_ethernet_destination.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ethernet_destination.Location = new System.Drawing.Point(6, 124);
            this.lbl_ethernet_destination.Name = "lbl_ethernet_destination";
            this.lbl_ethernet_destination.Size = new System.Drawing.Size(90, 15);
            this.lbl_ethernet_destination.TabIndex = 1;
            this.lbl_ethernet_destination.Text = "Eth Destination";
            // 
            // lbl_ethernet_sender
            // 
            this.lbl_ethernet_sender.AutoSize = true;
            this.lbl_ethernet_sender.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ethernet_sender.Location = new System.Drawing.Point(6, 94);
            this.lbl_ethernet_sender.Name = "lbl_ethernet_sender";
            this.lbl_ethernet_sender.Size = new System.Drawing.Size(68, 15);
            this.lbl_ethernet_sender.TabIndex = 0;
            this.lbl_ethernet_sender.Text = "Eth Sender";
            // 
            // tB_ping_results
            // 
            this.tB_ping_results.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.tB_ping_results.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tB_ping_results.Location = new System.Drawing.Point(2, -3);
            this.tB_ping_results.Multiline = true;
            this.tB_ping_results.Name = "tB_ping_results";
            this.tB_ping_results.ReadOnly = true;
            this.tB_ping_results.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tB_ping_results.Size = new System.Drawing.Size(321, 232);
            this.tB_ping_results.TabIndex = 38;
            this.tB_ping_results.TabStop = false;
            // 
            // lbl_to
            // 
            this.lbl_to.AutoSize = true;
            this.lbl_to.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_to.Location = new System.Drawing.Point(184, 240);
            this.lbl_to.Name = "lbl_to";
            this.lbl_to.Size = new System.Drawing.Size(21, 15);
            this.lbl_to.TabIndex = 8;
            this.lbl_to.Text = "To";
            // 
            // lbl_from
            // 
            this.lbl_from.AutoSize = true;
            this.lbl_from.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_from.Location = new System.Drawing.Point(6, 239);
            this.lbl_from.Name = "lbl_from";
            this.lbl_from.Size = new System.Drawing.Size(60, 15);
            this.lbl_from.TabIndex = 7;
            this.lbl_from.Text = "Ping from";
            // 
            // lbl_dot2
            // 
            this.lbl_dot2.AutoSize = true;
            this.lbl_dot2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_dot2.Location = new System.Drawing.Point(275, 240);
            this.lbl_dot2.Name = "lbl_dot2";
            this.lbl_dot2.Size = new System.Drawing.Size(12, 16);
            this.lbl_dot2.TabIndex = 6;
            this.lbl_dot2.Text = ".";
            // 
            // tB_scanto_host
            // 
            this.tB_scanto_host.Location = new System.Drawing.Point(288, 237);
            this.tB_scanto_host.Name = "tB_scanto_host";
            this.tB_scanto_host.Size = new System.Drawing.Size(26, 20);
            this.tB_scanto_host.TabIndex = 42;
            // 
            // tB_scanto_Net
            // 
            this.tB_scanto_Net.Location = new System.Drawing.Point(212, 237);
            this.tB_scanto_Net.Name = "tB_scanto_Net";
            this.tB_scanto_Net.ReadOnly = true;
            this.tB_scanto_Net.Size = new System.Drawing.Size(63, 20);
            this.tB_scanto_Net.TabIndex = 41;
            this.tB_scanto_Net.TabStop = false;
            // 
            // lbl_dot1
            // 
            this.lbl_dot1.AutoSize = true;
            this.lbl_dot1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_dot1.Location = new System.Drawing.Point(131, 240);
            this.lbl_dot1.Name = "lbl_dot1";
            this.lbl_dot1.Size = new System.Drawing.Size(12, 16);
            this.lbl_dot1.TabIndex = 3;
            this.lbl_dot1.Text = ".";
            // 
            // tB_scanfrom_host
            // 
            this.tB_scanfrom_host.Location = new System.Drawing.Point(144, 237);
            this.tB_scanfrom_host.Name = "tB_scanfrom_host";
            this.tB_scanfrom_host.Size = new System.Drawing.Size(26, 20);
            this.tB_scanfrom_host.TabIndex = 40;
            // 
            // tB_scanfrom_Net
            // 
            this.tB_scanfrom_Net.Location = new System.Drawing.Point(68, 237);
            this.tB_scanfrom_Net.Name = "tB_scanfrom_Net";
            this.tB_scanfrom_Net.Size = new System.Drawing.Size(63, 20);
            this.tB_scanfrom_Net.TabIndex = 39;
            // 
            // btn_IPscan
            // 
            this.btn_IPscan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_IPscan.Location = new System.Drawing.Point(0, 264);
            this.btn_IPscan.Name = "btn_IPscan";
            this.btn_IPscan.Size = new System.Drawing.Size(321, 27);
            this.btn_IPscan.TabIndex = 43;
            this.btn_IPscan.Text = "Start IP Detection";
            this.btn_IPscan.UseVisualStyleBackColor = true;
            this.btn_IPscan.Click += new System.EventHandler(this.btn_IPscan_Click);
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(321, 690);
            this.Controls.Add(this.splitContainer);
            this.Controls.Add(this.menuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip;
            this.MaximizeBox = false;
            this.Name = "Form_Main";
            this.ShowIcon = false;
            this.Text = "ARP Spoofer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_Main_FormClosing);
            this.Load += new System.EventHandler(this.Form_Main_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel1.PerformLayout();
            this.splitContainer.Panel2.ResumeLayout(false);
            this.splitContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveSettingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.Button btn_IPscan;
        private System.Windows.Forms.Label lbl_dot1;
        private System.Windows.Forms.TextBox tB_scanfrom_host;
        private System.Windows.Forms.TextBox tB_scanfrom_Net;
        private System.Windows.Forms.Label lbl_dot2;
        private System.Windows.Forms.TextBox tB_scanto_host;
        private System.Windows.Forms.TextBox tB_scanto_Net;
        private System.Windows.Forms.Label lbl_from;
        private System.Windows.Forms.Label lbl_to;
        private System.Windows.Forms.TextBox tB_ping_results;
        private System.Windows.Forms.Label lbl_arp_sender_mac;
        private System.Windows.Forms.Label lbl_ethernet_destination;
        private System.Windows.Forms.Label lbl_ethernet_sender;
        private System.Windows.Forms.Label lbl_interval_in_ms;
        private System.Windows.Forms.Label lbl_arp_target_ip;
        private System.Windows.Forms.Label lbl_arp_target_mac;
        private System.Windows.Forms.Label lbl_arp_sender_ip;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.TextBox tB_ethernet_sender_mac1;
        private System.Windows.Forms.TextBox tB_ethernet_sender_mac2;
        private System.Windows.Forms.TextBox tB_ethernet_sender_mac3;
        private System.Windows.Forms.TextBox tB_ethernet_sender_mac4;
        private System.Windows.Forms.TextBox tB_ethernet_sender_mac5;
        private System.Windows.Forms.TextBox tB_ethernet_sender_mac6;
        private System.Windows.Forms.TextBox tB_ethernet_destination_mac2;
        private System.Windows.Forms.TextBox tB_ethernet_destination_mac3;
        private System.Windows.Forms.TextBox tB_ethernet_destination_mac4;
        private System.Windows.Forms.TextBox tB_ethernet_destination_mac5;
        private System.Windows.Forms.TextBox tB_ethernet_destination_mac6;
        private System.Windows.Forms.TextBox tB_arp_destination_mac2;
        private System.Windows.Forms.TextBox tB_arp_destination_mac3;
        private System.Windows.Forms.TextBox tB_arp_destination_mac4;
        private System.Windows.Forms.TextBox tB_arp_destination_mac5;
        private System.Windows.Forms.TextBox tB_arp_destination_mac6;
        private System.Windows.Forms.TextBox tB_arp_sender_mac1;
        private System.Windows.Forms.TextBox tB_arp_sender_mac2;
        private System.Windows.Forms.TextBox tB_arp_sender_mac3;
        private System.Windows.Forms.TextBox tB_arp_sender_mac4;
        private System.Windows.Forms.TextBox tB_arp_sender_mac5;
        private System.Windows.Forms.TextBox tB_arp_sender_mac6;
        private System.Windows.Forms.TextBox tB_send_interval;
        private System.Windows.Forms.Label lbl_status;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.TextBox tB_ethernet_destination_mac1;
        private System.Windows.Forms.TextBox tB_arp_destination_mac1;
        private System.Windows.Forms.Button btn_send_arp_reply;
        private System.Windows.Forms.ComboBox cB_select_adapter;
        private System.Windows.Forms.TextBox tB_arp_destination_ip1;
        private System.Windows.Forms.TextBox tB_arp_destination_ip2;
        private System.Windows.Forms.TextBox tB_arp_destination_ip3;
        private System.Windows.Forms.TextBox tB_arp_destination_ip4;
        private System.Windows.Forms.TextBox tB_arp_sender_ip4;
        private System.Windows.Forms.TextBox tB_arp_sender_ip3;
        private System.Windows.Forms.TextBox tB_arp_sender_ip2;
        private System.Windows.Forms.TextBox tB_arp_sender_ip1;
        private System.Windows.Forms.Button btn_stop_arp_reply;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
    }
}

