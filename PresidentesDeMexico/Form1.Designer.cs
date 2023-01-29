namespace PresidentesDeMexico
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbcBuscar = new System.Windows.Forms.TabControl();
            this.tbpCargar = new System.Windows.Forms.TabPage();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnExaminar = new System.Windows.Forms.Button();
            this.txtRuta = new System.Windows.Forms.TextBox();
            this.lblRuta = new System.Windows.Forms.Label();
            this.tbpLista = new System.Windows.Forms.TabPage();
            this.dgvGobernantes = new System.Windows.Forms.DataGridView();
            this.clNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clSignificado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clTitulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clInicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clFin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clPeriodoHistorico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbpAgregar = new System.Windows.Forms.TabPage();
            this.cboPeriodoHistorico = new System.Windows.Forms.ComboBox();
            this.cboTitulo = new System.Windows.Forms.ComboBox();
            this.nudFinGobierno = new System.Windows.Forms.NumericUpDown();
            this.nudInicioGobierno = new System.Windows.Forms.NumericUpDown();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtSignificado = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblPeriodoHistorico = new System.Windows.Forms.Label();
            this.lblFinGobierno = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblSignificado = new System.Windows.Forms.Label();
            this.lblAñoInicio = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.tbpBuscar = new System.Windows.Forms.TabPage();
            this.pnBuscar = new System.Windows.Forms.Panel();
            this.txtNombreBuscar = new System.Windows.Forms.TextBox();
            this.txtResultados = new System.Windows.Forms.TextBox();
            this.dgvGobernantesAño = new System.Windows.Forms.DataGridView();
            this.btnGobernantes = new System.Windows.Forms.Button();
            this.cboTiposBusqueda = new System.Windows.Forms.ComboBox();
            this.cboTiposGobernantes = new System.Windows.Forms.ComboBox();
            this.lblTipo = new System.Windows.Forms.Label();
            this.cboFin = new System.Windows.Forms.ComboBox();
            this.cboAño = new System.Windows.Forms.ComboBox();
            this.lblResultados = new System.Windows.Forms.Label();
            this.lblFin = new System.Windows.Forms.Label();
            this.lblTipoGobernante = new System.Windows.Forms.Label();
            this.lblLeyenda = new System.Windows.Forms.Label();
            this.lblNombreBuscar = new System.Windows.Forms.Label();
            this.lblAño = new System.Windows.Forms.Label();
            this.tbcBuscar.SuspendLayout();
            this.tbpCargar.SuspendLayout();
            this.tbpLista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGobernantes)).BeginInit();
            this.tbpAgregar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudFinGobierno)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudInicioGobierno)).BeginInit();
            this.tbpBuscar.SuspendLayout();
            this.pnBuscar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGobernantesAño)).BeginInit();
            this.SuspendLayout();
            // 
            // tbcBuscar
            // 
            this.tbcBuscar.Controls.Add(this.tbpCargar);
            this.tbcBuscar.Controls.Add(this.tbpLista);
            this.tbcBuscar.Controls.Add(this.tbpAgregar);
            this.tbcBuscar.Controls.Add(this.tbpBuscar);
            this.tbcBuscar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbcBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbcBuscar.Location = new System.Drawing.Point(0, 0);
            this.tbcBuscar.Name = "tbcBuscar";
            this.tbcBuscar.SelectedIndex = 0;
            this.tbcBuscar.Size = new System.Drawing.Size(635, 359);
            this.tbcBuscar.TabIndex = 0;
            // 
            // tbpCargar
            // 
            this.tbpCargar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.tbpCargar.Controls.Add(this.btnAceptar);
            this.tbpCargar.Controls.Add(this.btnExaminar);
            this.tbpCargar.Controls.Add(this.txtRuta);
            this.tbpCargar.Controls.Add(this.lblRuta);
            this.tbpCargar.Location = new System.Drawing.Point(4, 27);
            this.tbpCargar.Name = "tbpCargar";
            this.tbpCargar.Padding = new System.Windows.Forms.Padding(3);
            this.tbpCargar.Size = new System.Drawing.Size(627, 328);
            this.tbpCargar.TabIndex = 0;
            this.tbpCargar.Text = "Cargar";
            // 
            // btnAceptar
            // 
            this.btnAceptar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnAceptar.FlatAppearance.BorderSize = 2;
            this.btnAceptar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnAceptar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnAceptar.Location = new System.Drawing.Point(520, 41);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(78, 36);
            this.btnAceptar.TabIndex = 2;
            this.btnAceptar.Text = "&Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnExaminar
            // 
            this.btnExaminar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnExaminar.FlatAppearance.BorderSize = 2;
            this.btnExaminar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnExaminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnExaminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExaminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExaminar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnExaminar.Location = new System.Drawing.Point(412, 41);
            this.btnExaminar.Name = "btnExaminar";
            this.btnExaminar.Size = new System.Drawing.Size(102, 36);
            this.btnExaminar.TabIndex = 2;
            this.btnExaminar.Text = "&Examinar...";
            this.btnExaminar.UseVisualStyleBackColor = true;
            this.btnExaminar.Click += new System.EventHandler(this.btnExaminar_Click);
            // 
            // txtRuta
            // 
            this.txtRuta.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRuta.Location = new System.Drawing.Point(55, 6);
            this.txtRuta.Name = "txtRuta";
            this.txtRuta.Size = new System.Drawing.Size(544, 29);
            this.txtRuta.TabIndex = 1;
            // 
            // lblRuta
            // 
            this.lblRuta.AutoSize = true;
            this.lblRuta.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRuta.ForeColor = System.Drawing.Color.Black;
            this.lblRuta.Location = new System.Drawing.Point(6, 13);
            this.lblRuta.Name = "lblRuta";
            this.lblRuta.Size = new System.Drawing.Size(43, 18);
            this.lblRuta.TabIndex = 0;
            this.lblRuta.Text = "Ruta";
            // 
            // tbpLista
            // 
            this.tbpLista.Controls.Add(this.dgvGobernantes);
            this.tbpLista.Location = new System.Drawing.Point(4, 27);
            this.tbpLista.Name = "tbpLista";
            this.tbpLista.Padding = new System.Windows.Forms.Padding(3);
            this.tbpLista.Size = new System.Drawing.Size(627, 328);
            this.tbpLista.TabIndex = 1;
            this.tbpLista.Text = "Lista";
            this.tbpLista.UseVisualStyleBackColor = true;
            // 
            // dgvGobernantes
            // 
            this.dgvGobernantes.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dgvGobernantes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGobernantes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clNombre,
            this.clSignificado,
            this.clTitulo,
            this.clInicio,
            this.clFin,
            this.clPeriodoHistorico});
            this.dgvGobernantes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvGobernantes.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dgvGobernantes.Location = new System.Drawing.Point(3, 3);
            this.dgvGobernantes.Name = "dgvGobernantes";
            this.dgvGobernantes.ReadOnly = true;
            this.dgvGobernantes.Size = new System.Drawing.Size(621, 322);
            this.dgvGobernantes.TabIndex = 0;
            // 
            // clNombre
            // 
            this.clNombre.DataPropertyName = "nombre";
            this.clNombre.HeaderText = "Nombre";
            this.clNombre.Name = "clNombre";
            this.clNombre.ReadOnly = true;
            // 
            // clSignificado
            // 
            this.clSignificado.DataPropertyName = "significado";
            this.clSignificado.HeaderText = "Significado";
            this.clSignificado.Name = "clSignificado";
            this.clSignificado.ReadOnly = true;
            // 
            // clTitulo
            // 
            this.clTitulo.DataPropertyName = "titulo";
            this.clTitulo.HeaderText = "Titulo";
            this.clTitulo.Name = "clTitulo";
            this.clTitulo.ReadOnly = true;
            // 
            // clInicio
            // 
            this.clInicio.DataPropertyName = "inicio";
            this.clInicio.HeaderText = "Inicio";
            this.clInicio.Name = "clInicio";
            this.clInicio.ReadOnly = true;
            // 
            // clFin
            // 
            this.clFin.DataPropertyName = "fin";
            this.clFin.HeaderText = "Fin";
            this.clFin.Name = "clFin";
            this.clFin.ReadOnly = true;
            // 
            // clPeriodoHistorico
            // 
            this.clPeriodoHistorico.DataPropertyName = "periodoHistorico";
            this.clPeriodoHistorico.HeaderText = "Periodo Historico";
            this.clPeriodoHistorico.Name = "clPeriodoHistorico";
            this.clPeriodoHistorico.ReadOnly = true;
            // 
            // tbpAgregar
            // 
            this.tbpAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.tbpAgregar.Controls.Add(this.cboPeriodoHistorico);
            this.tbpAgregar.Controls.Add(this.cboTitulo);
            this.tbpAgregar.Controls.Add(this.nudFinGobierno);
            this.tbpAgregar.Controls.Add(this.nudInicioGobierno);
            this.tbpAgregar.Controls.Add(this.btnAgregar);
            this.tbpAgregar.Controls.Add(this.txtSignificado);
            this.tbpAgregar.Controls.Add(this.txtNombre);
            this.tbpAgregar.Controls.Add(this.lblPeriodoHistorico);
            this.tbpAgregar.Controls.Add(this.lblFinGobierno);
            this.tbpAgregar.Controls.Add(this.lblTitulo);
            this.tbpAgregar.Controls.Add(this.lblSignificado);
            this.tbpAgregar.Controls.Add(this.lblAñoInicio);
            this.tbpAgregar.Controls.Add(this.lblNombre);
            this.tbpAgregar.Location = new System.Drawing.Point(4, 27);
            this.tbpAgregar.Name = "tbpAgregar";
            this.tbpAgregar.Padding = new System.Windows.Forms.Padding(3);
            this.tbpAgregar.Size = new System.Drawing.Size(627, 328);
            this.tbpAgregar.TabIndex = 3;
            this.tbpAgregar.Text = "Agregar";
            this.tbpAgregar.Click += new System.EventHandler(this.tbpAgregar_Click);
            // 
            // cboPeriodoHistorico
            // 
            this.cboPeriodoHistorico.Enabled = false;
            this.cboPeriodoHistorico.FormattingEnabled = true;
            this.cboPeriodoHistorico.Location = new System.Drawing.Point(377, 74);
            this.cboPeriodoHistorico.Name = "cboPeriodoHistorico";
            this.cboPeriodoHistorico.Size = new System.Drawing.Size(242, 26);
            this.cboPeriodoHistorico.TabIndex = 7;
            this.cboPeriodoHistorico.SelectedIndexChanged += new System.EventHandler(this.cboPeriodoHistorico_SelectedIndexChanged);
            // 
            // cboTitulo
            // 
            this.cboTitulo.FormattingEnabled = true;
            this.cboTitulo.Items.AddRange(new object[] {
            "Emperador Azteca",
            "Rey de España",
            "Gobernante de la Nueva España",
            "Virrey de la Nueva España",
            "Emperador de Mexico",
            "Presidente de Mexico",
            "Presidente de Mexico (Liberal)",
            "Presidente de Mexico (Conservador)"});
            this.cboTitulo.Location = new System.Drawing.Point(64, 74);
            this.cboTitulo.Name = "cboTitulo";
            this.cboTitulo.Size = new System.Drawing.Size(202, 26);
            this.cboTitulo.TabIndex = 7;
            this.cboTitulo.SelectedIndexChanged += new System.EventHandler(this.cboTitulo_SelectedIndexChanged);
            // 
            // nudFinGobierno
            // 
            this.nudFinGobierno.Location = new System.Drawing.Point(546, 106);
            this.nudFinGobierno.Name = "nudFinGobierno";
            this.nudFinGobierno.Size = new System.Drawing.Size(68, 24);
            this.nudFinGobierno.TabIndex = 6;
            this.nudFinGobierno.ValueChanged += new System.EventHandler(this.nudFinGobierno_ValueChanged);
            // 
            // nudInicioGobierno
            // 
            this.nudInicioGobierno.Location = new System.Drawing.Point(151, 106);
            this.nudInicioGobierno.Name = "nudInicioGobierno";
            this.nudInicioGobierno.Size = new System.Drawing.Size(68, 24);
            this.nudInicioGobierno.TabIndex = 6;
            this.nudInicioGobierno.ValueChanged += new System.EventHandler(this.nudInicioGobierno_ValueChanged);
            // 
            // btnAgregar
            // 
            this.btnAgregar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnAgregar.FlatAppearance.BorderSize = 2;
            this.btnAgregar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnAgregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnAgregar.Location = new System.Drawing.Point(536, 199);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(78, 36);
            this.btnAgregar.TabIndex = 5;
            this.btnAgregar.Text = "&Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txtSignificado
            // 
            this.txtSignificado.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSignificado.Location = new System.Drawing.Point(92, 41);
            this.txtSignificado.Name = "txtSignificado";
            this.txtSignificado.Size = new System.Drawing.Size(527, 29);
            this.txtSignificado.TabIndex = 4;
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(76, 6);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(543, 29);
            this.txtNombre.TabIndex = 4;
            // 
            // lblPeriodoHistorico
            // 
            this.lblPeriodoHistorico.AutoSize = true;
            this.lblPeriodoHistorico.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPeriodoHistorico.ForeColor = System.Drawing.Color.Black;
            this.lblPeriodoHistorico.Location = new System.Drawing.Point(304, 82);
            this.lblPeriodoHistorico.Name = "lblPeriodoHistorico";
            this.lblPeriodoHistorico.Size = new System.Drawing.Size(67, 18);
            this.lblPeriodoHistorico.TabIndex = 3;
            this.lblPeriodoHistorico.Text = "Periodo";
            // 
            // lblFinGobierno
            // 
            this.lblFinGobierno.AutoSize = true;
            this.lblFinGobierno.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFinGobierno.ForeColor = System.Drawing.Color.Black;
            this.lblFinGobierno.Location = new System.Drawing.Point(411, 108);
            this.lblFinGobierno.Name = "lblFinGobierno";
            this.lblFinGobierno.Size = new System.Drawing.Size(129, 18);
            this.lblFinGobierno.TabIndex = 3;
            this.lblFinGobierno.Text = "Fin de Gobierno";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.Black;
            this.lblTitulo.Location = new System.Drawing.Point(8, 79);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(50, 18);
            this.lblTitulo.TabIndex = 3;
            this.lblTitulo.Text = "Titulo";
            // 
            // lblSignificado
            // 
            this.lblSignificado.AutoSize = true;
            this.lblSignificado.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSignificado.ForeColor = System.Drawing.Color.Black;
            this.lblSignificado.Location = new System.Drawing.Point(2, 48);
            this.lblSignificado.Name = "lblSignificado";
            this.lblSignificado.Size = new System.Drawing.Size(91, 18);
            this.lblSignificado.TabIndex = 3;
            this.lblSignificado.Text = "Significado";
            // 
            // lblAñoInicio
            // 
            this.lblAñoInicio.AutoSize = true;
            this.lblAñoInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAñoInicio.ForeColor = System.Drawing.Color.Black;
            this.lblAñoInicio.Location = new System.Drawing.Point(5, 108);
            this.lblAñoInicio.Name = "lblAñoInicio";
            this.lblAñoInicio.Size = new System.Drawing.Size(146, 18);
            this.lblAñoInicio.TabIndex = 3;
            this.lblAñoInicio.Text = "Inicio de Gobierno";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.Color.Black;
            this.lblNombre.Location = new System.Drawing.Point(2, 13);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(68, 18);
            this.lblNombre.TabIndex = 3;
            this.lblNombre.Text = "Nombre";
            // 
            // tbpBuscar
            // 
            this.tbpBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.tbpBuscar.Controls.Add(this.pnBuscar);
            this.tbpBuscar.Location = new System.Drawing.Point(4, 27);
            this.tbpBuscar.Name = "tbpBuscar";
            this.tbpBuscar.Size = new System.Drawing.Size(627, 328);
            this.tbpBuscar.TabIndex = 2;
            this.tbpBuscar.Text = "Buscar";
            this.tbpBuscar.UseVisualStyleBackColor = true;
            // 
            // pnBuscar
            // 
            this.pnBuscar.Controls.Add(this.txtNombreBuscar);
            this.pnBuscar.Controls.Add(this.txtResultados);
            this.pnBuscar.Controls.Add(this.dgvGobernantesAño);
            this.pnBuscar.Controls.Add(this.btnGobernantes);
            this.pnBuscar.Controls.Add(this.cboTiposBusqueda);
            this.pnBuscar.Controls.Add(this.cboTiposGobernantes);
            this.pnBuscar.Controls.Add(this.lblTipo);
            this.pnBuscar.Controls.Add(this.cboFin);
            this.pnBuscar.Controls.Add(this.cboAño);
            this.pnBuscar.Controls.Add(this.lblResultados);
            this.pnBuscar.Controls.Add(this.lblFin);
            this.pnBuscar.Controls.Add(this.lblTipoGobernante);
            this.pnBuscar.Controls.Add(this.lblLeyenda);
            this.pnBuscar.Controls.Add(this.lblNombreBuscar);
            this.pnBuscar.Controls.Add(this.lblAño);
            this.pnBuscar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnBuscar.Location = new System.Drawing.Point(0, 0);
            this.pnBuscar.Name = "pnBuscar";
            this.pnBuscar.Size = new System.Drawing.Size(627, 328);
            this.pnBuscar.TabIndex = 6;
            // 
            // txtNombreBuscar
            // 
            this.txtNombreBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreBuscar.Location = new System.Drawing.Point(237, 68);
            this.txtNombreBuscar.Name = "txtNombreBuscar";
            this.txtNombreBuscar.Size = new System.Drawing.Size(369, 29);
            this.txtNombreBuscar.TabIndex = 8;
            this.txtNombreBuscar.Visible = false;
            // 
            // txtResultados
            // 
            this.txtResultados.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResultados.Location = new System.Drawing.Point(286, 105);
            this.txtResultados.Name = "txtResultados";
            this.txtResultados.ReadOnly = true;
            this.txtResultados.Size = new System.Drawing.Size(55, 29);
            this.txtResultados.TabIndex = 7;
            this.txtResultados.Visible = false;
            // 
            // dgvGobernantesAño
            // 
            this.dgvGobernantesAño.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dgvGobernantesAño.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGobernantesAño.Location = new System.Drawing.Point(8, 139);
            this.dgvGobernantesAño.Name = "dgvGobernantesAño";
            this.dgvGobernantesAño.Size = new System.Drawing.Size(598, 185);
            this.dgvGobernantesAño.TabIndex = 6;
            this.dgvGobernantesAño.Visible = false;
            // 
            // btnGobernantes
            // 
            this.btnGobernantes.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnGobernantes.FlatAppearance.BorderSize = 2;
            this.btnGobernantes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnGobernantes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnGobernantes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGobernantes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGobernantes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnGobernantes.Location = new System.Drawing.Point(442, 99);
            this.btnGobernantes.Name = "btnGobernantes";
            this.btnGobernantes.Size = new System.Drawing.Size(177, 36);
            this.btnGobernantes.TabIndex = 5;
            this.btnGobernantes.Text = "&Obtener Gobernantes";
            this.btnGobernantes.UseVisualStyleBackColor = true;
            this.btnGobernantes.Visible = false;
            this.btnGobernantes.Click += new System.EventHandler(this.btnGobernantes_Click);
            // 
            // cboTiposBusqueda
            // 
            this.cboTiposBusqueda.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTiposBusqueda.FormattingEnabled = true;
            this.cboTiposBusqueda.Items.AddRange(new object[] {
            "Año Unitario",
            "Intervalo de Años",
            "Periodo Historico",
            "Tipo de Gobernante",
            "Nombre"});
            this.cboTiposBusqueda.Location = new System.Drawing.Point(286, 2);
            this.cboTiposBusqueda.Name = "cboTiposBusqueda";
            this.cboTiposBusqueda.Size = new System.Drawing.Size(320, 32);
            this.cboTiposBusqueda.TabIndex = 4;
            this.cboTiposBusqueda.SelectedIndexChanged += new System.EventHandler(this.cboTiposBusquedas_SelectedIndexChanged);
            // 
            // cboTiposGobernantes
            // 
            this.cboTiposGobernantes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTiposGobernantes.FormattingEnabled = true;
            this.cboTiposGobernantes.Items.AddRange(new object[] {
            "Año Unitario",
            "Intervalo de Años",
            "Periodo Historico",
            "Tipo de Gobernante",
            "Nombre"});
            this.cboTiposGobernantes.Location = new System.Drawing.Point(322, 35);
            this.cboTiposGobernantes.Name = "cboTiposGobernantes";
            this.cboTiposGobernantes.Size = new System.Drawing.Size(284, 32);
            this.cboTiposGobernantes.TabIndex = 4;
            this.cboTiposGobernantes.Visible = false;
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipo.ForeColor = System.Drawing.Color.Black;
            this.lblTipo.Location = new System.Drawing.Point(137, 10);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(143, 18);
            this.lblTipo.TabIndex = 3;
            this.lblTipo.Text = "Tipo de Busqueda";
            // 
            // cboFin
            // 
            this.cboFin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboFin.FormattingEnabled = true;
            this.cboFin.Location = new System.Drawing.Point(62, 79);
            this.cboFin.Name = "cboFin";
            this.cboFin.Size = new System.Drawing.Size(97, 32);
            this.cboFin.TabIndex = 4;
            this.cboFin.Visible = false;
            this.cboFin.TextChanged += new System.EventHandler(this.cboFin_TextChanged);
            // 
            // cboAño
            // 
            this.cboAño.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboAño.FormattingEnabled = true;
            this.cboAño.Location = new System.Drawing.Point(62, 41);
            this.cboAño.Name = "cboAño";
            this.cboAño.Size = new System.Drawing.Size(97, 32);
            this.cboAño.TabIndex = 4;
            this.cboAño.Visible = false;
            this.cboAño.SelectedIndexChanged += new System.EventHandler(this.cboAño_SelectedIndexChanged);
            this.cboAño.TextChanged += new System.EventHandler(this.cboAño_TextChanged);
            // 
            // lblResultados
            // 
            this.lblResultados.AutoSize = true;
            this.lblResultados.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultados.ForeColor = System.Drawing.Color.Black;
            this.lblResultados.Location = new System.Drawing.Point(347, 115);
            this.lblResultados.Name = "lblResultados";
            this.lblResultados.Size = new System.Drawing.Size(93, 18);
            this.lblResultados.TabIndex = 3;
            this.lblResultados.Text = "Resultados";
            this.lblResultados.Visible = false;
            // 
            // lblFin
            // 
            this.lblFin.AutoSize = true;
            this.lblFin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFin.ForeColor = System.Drawing.Color.Black;
            this.lblFin.Location = new System.Drawing.Point(9, 93);
            this.lblFin.Name = "lblFin";
            this.lblFin.Size = new System.Drawing.Size(31, 18);
            this.lblFin.TabIndex = 3;
            this.lblFin.Text = "Fin";
            this.lblFin.Visible = false;
            // 
            // lblTipoGobernante
            // 
            this.lblTipoGobernante.AutoSize = true;
            this.lblTipoGobernante.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoGobernante.ForeColor = System.Drawing.Color.Black;
            this.lblTipoGobernante.Location = new System.Drawing.Point(165, 45);
            this.lblTipoGobernante.Name = "lblTipoGobernante";
            this.lblTipoGobernante.Size = new System.Drawing.Size(157, 18);
            this.lblTipoGobernante.TabIndex = 3;
            this.lblTipoGobernante.Text = "Tipo de Gobernante";
            this.lblTipoGobernante.Visible = false;
            // 
            // lblLeyenda
            // 
            this.lblLeyenda.AutoSize = true;
            this.lblLeyenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLeyenda.ForeColor = System.Drawing.Color.Black;
            this.lblLeyenda.Location = new System.Drawing.Point(163, 115);
            this.lblLeyenda.Name = "lblLeyenda";
            this.lblLeyenda.Size = new System.Drawing.Size(124, 18);
            this.lblLeyenda.TabIndex = 3;
            this.lblLeyenda.Text = "Se encontraron";
            this.lblLeyenda.Visible = false;
            // 
            // lblNombreBuscar
            // 
            this.lblNombreBuscar.AutoSize = true;
            this.lblNombreBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreBuscar.ForeColor = System.Drawing.Color.Black;
            this.lblNombreBuscar.Location = new System.Drawing.Point(165, 73);
            this.lblNombreBuscar.Name = "lblNombreBuscar";
            this.lblNombreBuscar.Size = new System.Drawing.Size(68, 18);
            this.lblNombreBuscar.TabIndex = 3;
            this.lblNombreBuscar.Text = "Nombre";
            this.lblNombreBuscar.Visible = false;
            // 
            // lblAño
            // 
            this.lblAño.AutoSize = true;
            this.lblAño.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAño.ForeColor = System.Drawing.Color.Black;
            this.lblAño.Location = new System.Drawing.Point(9, 55);
            this.lblAño.Name = "lblAño";
            this.lblAño.Size = new System.Drawing.Size(37, 18);
            this.lblAño.TabIndex = 3;
            this.lblAño.Text = "Año";
            this.lblAño.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(635, 359);
            this.Controls.Add(this.tbcBuscar);
            this.Name = "Form1";
            this.Text = "Gobernantes de Mexico";
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tbcBuscar.ResumeLayout(false);
            this.tbpCargar.ResumeLayout(false);
            this.tbpCargar.PerformLayout();
            this.tbpLista.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGobernantes)).EndInit();
            this.tbpAgregar.ResumeLayout(false);
            this.tbpAgregar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudFinGobierno)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudInicioGobierno)).EndInit();
            this.tbpBuscar.ResumeLayout(false);
            this.pnBuscar.ResumeLayout(false);
            this.pnBuscar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGobernantesAño)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbcBuscar;
        private System.Windows.Forms.TabPage tbpCargar;
        private System.Windows.Forms.TabPage tbpLista;
        private System.Windows.Forms.Button btnExaminar;
        private System.Windows.Forms.TextBox txtRuta;
        private System.Windows.Forms.Label lblRuta;
        private System.Windows.Forms.DataGridView dgvGobernantes;
        private System.Windows.Forms.TabPage tbpBuscar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.DataGridViewTextBoxColumn clNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn clSignificado;
        private System.Windows.Forms.DataGridViewTextBoxColumn clTitulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clInicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn clFin;
        private System.Windows.Forms.DataGridViewTextBoxColumn clPeriodoHistorico;
        private System.Windows.Forms.Panel pnBuscar;
        private System.Windows.Forms.DataGridView dgvGobernantesAño;
        private System.Windows.Forms.Button btnGobernantes;
        private System.Windows.Forms.ComboBox cboAño;
        private System.Windows.Forms.Label lblAño;
        private System.Windows.Forms.TabPage tbpAgregar;
        private System.Windows.Forms.NumericUpDown nudFinGobierno;
        private System.Windows.Forms.NumericUpDown nudInicioGobierno;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblFinGobierno;
        private System.Windows.Forms.Label lblAñoInicio;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtSignificado;
        private System.Windows.Forms.Label lblSignificado;
        private System.Windows.Forms.ComboBox cboTitulo;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.ComboBox cboPeriodoHistorico;
        private System.Windows.Forms.Label lblPeriodoHistorico;
        private System.Windows.Forms.ComboBox cboTiposGobernantes;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.TextBox txtResultados;
        private System.Windows.Forms.Label lblResultados;
        private System.Windows.Forms.Label lblLeyenda;
        private System.Windows.Forms.ComboBox cboFin;
        private System.Windows.Forms.Label lblFin;
        private System.Windows.Forms.TextBox txtNombreBuscar;
        private System.Windows.Forms.Label lblNombreBuscar;
        private System.Windows.Forms.ComboBox cboTiposBusqueda;
        private System.Windows.Forms.Label lblTipoGobernante;
    }
}

