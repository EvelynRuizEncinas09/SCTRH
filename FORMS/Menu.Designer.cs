
namespace SCT_RH
{
    partial class Menu
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
            this.components = new System.ComponentModel.Container();
            BunifuAnimatorNS.Animation animation1 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            BunifuAnimatorNS.Animation animation2 = new BunifuAnimatorNS.Animation();
            this.menuTopPnl = new System.Windows.Forms.Panel();
            this.Restaurar = new System.Windows.Forms.PictureBox();
            this.Minimizar = new System.Windows.Forms.PictureBox();
            this.Maximizar = new System.Windows.Forms.PictureBox();
            this.Salir = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.MenuDesplegableBtn = new System.Windows.Forms.PictureBox();
            this.contenedorMenuPnl = new System.Windows.Forms.Panel();
            this.Sidebar = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.busacrBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.eliminarBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.modiifcarBTN = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Registrarbtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.linea = new Bunifu.Framework.UI.BunifuSeparator();
            this.label1 = new System.Windows.Forms.Label();
            this.contenidoPnl = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.AnimacionSidebarAtras = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.AnimacionSidebar = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.menuTopPnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Restaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Minimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Maximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Salir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MenuDesplegableBtn)).BeginInit();
            this.contenedorMenuPnl.SuspendLayout();
            this.Sidebar.SuspendLayout();
            this.contenidoPnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuTopPnl
            // 
            this.menuTopPnl.BackColor = System.Drawing.Color.Gray;
            this.menuTopPnl.Controls.Add(this.Restaurar);
            this.menuTopPnl.Controls.Add(this.Minimizar);
            this.menuTopPnl.Controls.Add(this.Maximizar);
            this.menuTopPnl.Controls.Add(this.Salir);
            this.menuTopPnl.Controls.Add(this.label2);
            this.menuTopPnl.Controls.Add(this.MenuDesplegableBtn);
            this.AnimacionSidebar.SetDecoration(this.menuTopPnl, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarAtras.SetDecoration(this.menuTopPnl, BunifuAnimatorNS.DecorationType.None);
            this.menuTopPnl.Dock = System.Windows.Forms.DockStyle.Top;
            this.menuTopPnl.Location = new System.Drawing.Point(0, 0);
            this.menuTopPnl.Name = "menuTopPnl";
            this.menuTopPnl.Size = new System.Drawing.Size(924, 60);
            this.menuTopPnl.TabIndex = 2;
            this.menuTopPnl.MouseDown += new System.Windows.Forms.MouseEventHandler(this.menuTopPnl_MouseDown);
            this.menuTopPnl.MouseMove += new System.Windows.Forms.MouseEventHandler(this.menuTopPnl_MouseMove);
            this.menuTopPnl.MouseUp += new System.Windows.Forms.MouseEventHandler(this.menuTopPnl_MouseUp);
            // 
            // Restaurar
            // 
            this.Restaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AnimacionSidebarAtras.SetDecoration(this.Restaurar, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebar.SetDecoration(this.Restaurar, BunifuAnimatorNS.DecorationType.None);
            this.Restaurar.Image = ((System.Drawing.Image)(resources.GetObject("Restaurar.Image")));
            this.Restaurar.Location = new System.Drawing.Point(846, 21);
            this.Restaurar.Name = "Restaurar";
            this.Restaurar.Size = new System.Drawing.Size(30, 30);
            this.Restaurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Restaurar.TabIndex = 9;
            this.Restaurar.TabStop = false;
            this.Restaurar.Visible = false;
            this.Restaurar.Click += new System.EventHandler(this.Restaurar_Click);
            // 
            // Minimizar
            // 
            this.Minimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AnimacionSidebarAtras.SetDecoration(this.Minimizar, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebar.SetDecoration(this.Minimizar, BunifuAnimatorNS.DecorationType.None);
            this.Minimizar.Image = ((System.Drawing.Image)(resources.GetObject("Minimizar.Image")));
            this.Minimizar.Location = new System.Drawing.Point(810, 21);
            this.Minimizar.Name = "Minimizar";
            this.Minimizar.Size = new System.Drawing.Size(30, 30);
            this.Minimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Minimizar.TabIndex = 8;
            this.Minimizar.TabStop = false;
            this.Minimizar.Click += new System.EventHandler(this.Minimizar_Click);
            // 
            // Maximizar
            // 
            this.Maximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AnimacionSidebarAtras.SetDecoration(this.Maximizar, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebar.SetDecoration(this.Maximizar, BunifuAnimatorNS.DecorationType.None);
            this.Maximizar.Image = ((System.Drawing.Image)(resources.GetObject("Maximizar.Image")));
            this.Maximizar.Location = new System.Drawing.Point(846, 21);
            this.Maximizar.Name = "Maximizar";
            this.Maximizar.Size = new System.Drawing.Size(30, 30);
            this.Maximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Maximizar.TabIndex = 7;
            this.Maximizar.TabStop = false;
            // 
            // Salir
            // 
            this.Salir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AnimacionSidebarAtras.SetDecoration(this.Salir, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebar.SetDecoration(this.Salir, BunifuAnimatorNS.DecorationType.None);
            this.Salir.Image = ((System.Drawing.Image)(resources.GetObject("Salir.Image")));
            this.Salir.Location = new System.Drawing.Point(882, 21);
            this.Salir.Name = "Salir";
            this.Salir.Size = new System.Drawing.Size(30, 30);
            this.Salir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Salir.TabIndex = 6;
            this.Salir.TabStop = false;
            this.Salir.Click += new System.EventHandler(this.Salir_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.AnimacionSidebarAtras.SetDecoration(this.label2, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebar.SetDecoration(this.label2, BunifuAnimatorNS.DecorationType.None);
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(54, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(212, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "OPCIONES DEL SISTEMA";
            // 
            // MenuDesplegableBtn
            // 
            this.AnimacionSidebarAtras.SetDecoration(this.MenuDesplegableBtn, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebar.SetDecoration(this.MenuDesplegableBtn, BunifuAnimatorNS.DecorationType.None);
            this.MenuDesplegableBtn.Image = ((System.Drawing.Image)(resources.GetObject("MenuDesplegableBtn.Image")));
            this.MenuDesplegableBtn.Location = new System.Drawing.Point(27, 21);
            this.MenuDesplegableBtn.Name = "MenuDesplegableBtn";
            this.MenuDesplegableBtn.Size = new System.Drawing.Size(21, 20);
            this.MenuDesplegableBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.MenuDesplegableBtn.TabIndex = 1;
            this.MenuDesplegableBtn.TabStop = false;
            this.MenuDesplegableBtn.Click += new System.EventHandler(this.MenuDesplegableBtn_Click_1);
            // 
            // contenedorMenuPnl
            // 
            this.contenedorMenuPnl.BackColor = System.Drawing.Color.Gray;
            this.contenedorMenuPnl.Controls.Add(this.Sidebar);
            this.AnimacionSidebar.SetDecoration(this.contenedorMenuPnl, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarAtras.SetDecoration(this.contenedorMenuPnl, BunifuAnimatorNS.DecorationType.None);
            this.contenedorMenuPnl.Dock = System.Windows.Forms.DockStyle.Left;
            this.contenedorMenuPnl.Location = new System.Drawing.Point(0, 60);
            this.contenedorMenuPnl.Name = "contenedorMenuPnl";
            this.contenedorMenuPnl.Size = new System.Drawing.Size(300, 537);
            this.contenedorMenuPnl.TabIndex = 11;
            // 
            // Sidebar
            // 
            this.Sidebar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.Sidebar.BackColor = System.Drawing.Color.Silver;
            this.Sidebar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Sidebar.BackgroundImage")));
            this.Sidebar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Sidebar.Controls.Add(this.busacrBtn);
            this.Sidebar.Controls.Add(this.eliminarBtn);
            this.Sidebar.Controls.Add(this.modiifcarBTN);
            this.Sidebar.Controls.Add(this.Registrarbtn);
            this.Sidebar.Controls.Add(this.linea);
            this.Sidebar.Controls.Add(this.label1);
            this.AnimacionSidebar.SetDecoration(this.Sidebar, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarAtras.SetDecoration(this.Sidebar, BunifuAnimatorNS.DecorationType.None);
            this.Sidebar.GradientBottomLeft = System.Drawing.Color.White;
            this.Sidebar.GradientBottomRight = System.Drawing.Color.White;
            this.Sidebar.GradientTopLeft = System.Drawing.Color.White;
            this.Sidebar.GradientTopRight = System.Drawing.Color.Gray;
            this.Sidebar.Location = new System.Drawing.Point(15, 16);
            this.Sidebar.Name = "Sidebar";
            this.Sidebar.Quality = 10;
            this.Sidebar.Size = new System.Drawing.Size(270, 651);
            this.Sidebar.TabIndex = 1;
            // 
            // busacrBtn
            // 
            this.busacrBtn.Activecolor = System.Drawing.Color.Transparent;
            this.busacrBtn.BackColor = System.Drawing.Color.Transparent;
            this.busacrBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.busacrBtn.BorderRadius = 0;
            this.busacrBtn.ButtonText = "        BUSCAR EMPLEADOS";
            this.busacrBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnimacionSidebarAtras.SetDecoration(this.busacrBtn, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebar.SetDecoration(this.busacrBtn, BunifuAnimatorNS.DecorationType.None);
            this.busacrBtn.DisabledColor = System.Drawing.Color.Gray;
            this.busacrBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.busacrBtn.Iconimage = ((System.Drawing.Image)(resources.GetObject("busacrBtn.Iconimage")));
            this.busacrBtn.Iconimage_right = null;
            this.busacrBtn.Iconimage_right_Selected = null;
            this.busacrBtn.Iconimage_Selected = null;
            this.busacrBtn.IconMarginLeft = 0;
            this.busacrBtn.IconMarginRight = 0;
            this.busacrBtn.IconRightVisible = true;
            this.busacrBtn.IconRightZoom = 0D;
            this.busacrBtn.IconVisible = true;
            this.busacrBtn.IconZoom = 50D;
            this.busacrBtn.IsTab = false;
            this.busacrBtn.Location = new System.Drawing.Point(4, 311);
            this.busacrBtn.Name = "busacrBtn";
            this.busacrBtn.Normalcolor = System.Drawing.Color.Transparent;
            this.busacrBtn.OnHovercolor = System.Drawing.Color.Transparent;
            this.busacrBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.busacrBtn.selected = false;
            this.busacrBtn.Size = new System.Drawing.Size(252, 51);
            this.busacrBtn.TabIndex = 16;
            this.busacrBtn.Text = "        BUSCAR EMPLEADOS";
            this.busacrBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.busacrBtn.Textcolor = System.Drawing.Color.Black;
            this.busacrBtn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            // 
            // eliminarBtn
            // 
            this.eliminarBtn.Activecolor = System.Drawing.Color.Transparent;
            this.eliminarBtn.BackColor = System.Drawing.Color.Transparent;
            this.eliminarBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.eliminarBtn.BorderRadius = 0;
            this.eliminarBtn.ButtonText = "          ELIMINAR";
            this.eliminarBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnimacionSidebarAtras.SetDecoration(this.eliminarBtn, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebar.SetDecoration(this.eliminarBtn, BunifuAnimatorNS.DecorationType.None);
            this.eliminarBtn.DisabledColor = System.Drawing.Color.Gray;
            this.eliminarBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.eliminarBtn.Iconimage = ((System.Drawing.Image)(resources.GetObject("eliminarBtn.Iconimage")));
            this.eliminarBtn.Iconimage_right = null;
            this.eliminarBtn.Iconimage_right_Selected = null;
            this.eliminarBtn.Iconimage_Selected = null;
            this.eliminarBtn.IconMarginLeft = 0;
            this.eliminarBtn.IconMarginRight = 0;
            this.eliminarBtn.IconRightVisible = true;
            this.eliminarBtn.IconRightZoom = 0D;
            this.eliminarBtn.IconVisible = true;
            this.eliminarBtn.IconZoom = 50D;
            this.eliminarBtn.IsTab = false;
            this.eliminarBtn.Location = new System.Drawing.Point(0, 254);
            this.eliminarBtn.Name = "eliminarBtn";
            this.eliminarBtn.Normalcolor = System.Drawing.Color.Transparent;
            this.eliminarBtn.OnHovercolor = System.Drawing.Color.Transparent;
            this.eliminarBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.eliminarBtn.selected = false;
            this.eliminarBtn.Size = new System.Drawing.Size(252, 51);
            this.eliminarBtn.TabIndex = 15;
            this.eliminarBtn.Text = "          ELIMINAR";
            this.eliminarBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.eliminarBtn.Textcolor = System.Drawing.Color.Black;
            this.eliminarBtn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.eliminarBtn.Click += new System.EventHandler(this.eliminarBtn_Click);
            // 
            // modiifcarBTN
            // 
            this.modiifcarBTN.Activecolor = System.Drawing.Color.Transparent;
            this.modiifcarBTN.BackColor = System.Drawing.Color.Transparent;
            this.modiifcarBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.modiifcarBTN.BorderRadius = 0;
            this.modiifcarBTN.ButtonText = "          MODIFICAR";
            this.modiifcarBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnimacionSidebarAtras.SetDecoration(this.modiifcarBTN, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebar.SetDecoration(this.modiifcarBTN, BunifuAnimatorNS.DecorationType.None);
            this.modiifcarBTN.DisabledColor = System.Drawing.Color.Gray;
            this.modiifcarBTN.Iconcolor = System.Drawing.Color.Transparent;
            this.modiifcarBTN.Iconimage = ((System.Drawing.Image)(resources.GetObject("modiifcarBTN.Iconimage")));
            this.modiifcarBTN.Iconimage_right = null;
            this.modiifcarBTN.Iconimage_right_Selected = null;
            this.modiifcarBTN.Iconimage_Selected = null;
            this.modiifcarBTN.IconMarginLeft = 0;
            this.modiifcarBTN.IconMarginRight = 0;
            this.modiifcarBTN.IconRightVisible = true;
            this.modiifcarBTN.IconRightZoom = 0D;
            this.modiifcarBTN.IconVisible = true;
            this.modiifcarBTN.IconZoom = 50D;
            this.modiifcarBTN.IsTab = false;
            this.modiifcarBTN.Location = new System.Drawing.Point(0, 180);
            this.modiifcarBTN.Name = "modiifcarBTN";
            this.modiifcarBTN.Normalcolor = System.Drawing.Color.Transparent;
            this.modiifcarBTN.OnHovercolor = System.Drawing.Color.Transparent;
            this.modiifcarBTN.OnHoverTextColor = System.Drawing.Color.White;
            this.modiifcarBTN.selected = false;
            this.modiifcarBTN.Size = new System.Drawing.Size(252, 51);
            this.modiifcarBTN.TabIndex = 14;
            this.modiifcarBTN.Text = "          MODIFICAR";
            this.modiifcarBTN.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.modiifcarBTN.Textcolor = System.Drawing.Color.Black;
            this.modiifcarBTN.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.modiifcarBTN.Click += new System.EventHandler(this.modiifcarBTN_Click);
            // 
            // Registrarbtn
            // 
            this.Registrarbtn.Activecolor = System.Drawing.Color.Black;
            this.Registrarbtn.BackColor = System.Drawing.Color.Transparent;
            this.Registrarbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Registrarbtn.BorderRadius = 0;
            this.Registrarbtn.ButtonText = "          REGISTRAR";
            this.Registrarbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnimacionSidebarAtras.SetDecoration(this.Registrarbtn, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebar.SetDecoration(this.Registrarbtn, BunifuAnimatorNS.DecorationType.None);
            this.Registrarbtn.DisabledColor = System.Drawing.Color.Black;
            this.Registrarbtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Registrarbtn.Iconcolor = System.Drawing.Color.Transparent;
            this.Registrarbtn.Iconimage = ((System.Drawing.Image)(resources.GetObject("Registrarbtn.Iconimage")));
            this.Registrarbtn.Iconimage_right = null;
            this.Registrarbtn.Iconimage_right_Selected = null;
            this.Registrarbtn.Iconimage_Selected = null;
            this.Registrarbtn.IconMarginLeft = 0;
            this.Registrarbtn.IconMarginRight = 0;
            this.Registrarbtn.IconRightVisible = true;
            this.Registrarbtn.IconRightZoom = 0D;
            this.Registrarbtn.IconVisible = true;
            this.Registrarbtn.IconZoom = 50D;
            this.Registrarbtn.IsTab = false;
            this.Registrarbtn.Location = new System.Drawing.Point(0, 110);
            this.Registrarbtn.Name = "Registrarbtn";
            this.Registrarbtn.Normalcolor = System.Drawing.Color.Transparent;
            this.Registrarbtn.OnHovercolor = System.Drawing.Color.Transparent;
            this.Registrarbtn.OnHoverTextColor = System.Drawing.Color.Black;
            this.Registrarbtn.selected = false;
            this.Registrarbtn.Size = new System.Drawing.Size(252, 51);
            this.Registrarbtn.TabIndex = 13;
            this.Registrarbtn.Text = "          REGISTRAR";
            this.Registrarbtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Registrarbtn.Textcolor = System.Drawing.Color.Black;
            this.Registrarbtn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.Registrarbtn.Click += new System.EventHandler(this.Registrarbtn_Click);
            // 
            // linea
            // 
            this.linea.BackColor = System.Drawing.Color.Transparent;
            this.AnimacionSidebar.SetDecoration(this.linea, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarAtras.SetDecoration(this.linea, BunifuAnimatorNS.DecorationType.None);
            this.linea.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.linea.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.linea.LineThickness = 1;
            this.linea.Location = new System.Drawing.Point(11, 67);
            this.linea.Name = "linea";
            this.linea.Size = new System.Drawing.Size(245, 10);
            this.linea.TabIndex = 0;
            this.linea.Transparency = 255;
            this.linea.Vertical = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.AnimacionSidebarAtras.SetDecoration(this.label1, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebar.SetDecoration(this.label1, BunifuAnimatorNS.DecorationType.None);
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(62, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Recursos Humanos";
            // 
            // contenidoPnl
            // 
            this.contenidoPnl.BackColor = System.Drawing.SystemColors.Control;
            this.contenidoPnl.Controls.Add(this.panel1);
            this.AnimacionSidebar.SetDecoration(this.contenidoPnl, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarAtras.SetDecoration(this.contenidoPnl, BunifuAnimatorNS.DecorationType.None);
            this.contenidoPnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contenidoPnl.Location = new System.Drawing.Point(300, 60);
            this.contenidoPnl.Name = "contenidoPnl";
            this.contenidoPnl.Size = new System.Drawing.Size(624, 537);
            this.contenidoPnl.TabIndex = 12;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.AnimacionSidebar.SetDecoration(this.panel1, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarAtras.SetDecoration(this.panel1, BunifuAnimatorNS.DecorationType.None);
            this.panel1.Location = new System.Drawing.Point(0, -132);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(621, 802);
            this.panel1.TabIndex = 1;
            // 
            // AnimacionSidebarAtras
            // 
            this.AnimacionSidebarAtras.AnimationType = BunifuAnimatorNS.AnimationType.VertSlide;
            this.AnimacionSidebarAtras.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 0F;
            this.AnimacionSidebarAtras.DefaultAnimation = animation1;
            // 
            // AnimacionSidebar
            // 
            this.AnimacionSidebar.AnimationType = BunifuAnimatorNS.AnimationType.VertSlide;
            this.AnimacionSidebar.Cursor = null;
            animation2.AnimateOnlyDifferences = true;
            animation2.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.BlindCoeff")));
            animation2.LeafCoeff = 0F;
            animation2.MaxTime = 1F;
            animation2.MinTime = 0F;
            animation2.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicCoeff")));
            animation2.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicShift")));
            animation2.MosaicSize = 0;
            animation2.Padding = new System.Windows.Forms.Padding(0);
            animation2.RotateCoeff = 0F;
            animation2.RotateLimit = 0F;
            animation2.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.ScaleCoeff")));
            animation2.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.SlideCoeff")));
            animation2.TimeCoeff = 0F;
            animation2.TransparencyCoeff = 0F;
            this.AnimacionSidebar.DefaultAnimation = animation2;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(924, 597);
            this.Controls.Add(this.contenidoPnl);
            this.Controls.Add(this.contenedorMenuPnl);
            this.Controls.Add(this.menuTopPnl);
            this.AnimacionSidebar.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.AnimacionSidebarAtras.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Menu";
            this.Text = "Menu";
            this.menuTopPnl.ResumeLayout(false);
            this.menuTopPnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Restaurar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Minimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Maximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Salir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MenuDesplegableBtn)).EndInit();
            this.contenedorMenuPnl.ResumeLayout(false);
            this.Sidebar.ResumeLayout(false);
            this.Sidebar.PerformLayout();
            this.contenidoPnl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel menuTopPnl;
        private System.Windows.Forms.PictureBox Restaurar;
        private System.Windows.Forms.PictureBox Minimizar;
        private System.Windows.Forms.PictureBox Maximizar;
        private System.Windows.Forms.PictureBox Salir;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox MenuDesplegableBtn;
        private System.Windows.Forms.Panel contenedorMenuPnl;
        private Bunifu.Framework.UI.BunifuGradientPanel Sidebar;
        private Bunifu.Framework.UI.BunifuFlatButton busacrBtn;
        private Bunifu.Framework.UI.BunifuFlatButton eliminarBtn;
        private Bunifu.Framework.UI.BunifuFlatButton modiifcarBTN;
        private Bunifu.Framework.UI.BunifuFlatButton Registrarbtn;
        private Bunifu.Framework.UI.BunifuSeparator linea;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel contenidoPnl;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private BunifuAnimatorNS.BunifuTransition AnimacionSidebarAtras;
        private BunifuAnimatorNS.BunifuTransition AnimacionSidebar;
    }
}