﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmVenta
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmVenta))
        Me.Seleccionar = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.BtnCerrar = New System.Windows.Forms.Button()
        Me.LblTotalArticulos = New System.Windows.Forms.Label()
        Me.TxtCodigo = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TxtTotal = New System.Windows.Forms.TextBox()
        Me.TxtTotalImpuesto = New System.Windows.Forms.TextBox()
        Me.TxtSubTotal = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DgvDetalle = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TxtImpuesto = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtNumComprobante = New System.Windows.Forms.TextBox()
        Me.CboTipoComprobante = New System.Windows.Forms.ComboBox()
        Me.BtnBuscarCliente = New System.Windows.Forms.Button()
        Me.TxtNombreCliente = New System.Windows.Forms.TextBox()
        Me.TxtIdCliente = New System.Windows.Forms.TextBox()
        Me.TxtSerieComprobante = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtId = New System.Windows.Forms.TextBox()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.DgvArticulos = New System.Windows.Forms.DataGridView()
        Me.ErrorIcono = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.BtnBuscarArticulos = New System.Windows.Forms.Button()
        Me.BtnAnular = New System.Windows.Forms.Button()
        Me.ChkSeleccionar = New System.Windows.Forms.CheckBox()
        Me.TxtValor = New System.Windows.Forms.TextBox()
        Me.Lbltotal = New System.Windows.Forms.Label()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.PanelMostrar = New System.Windows.Forms.Panel()
        Me.BtnCerrarM = New System.Windows.Forms.Button()
        Me.LblTotalM = New System.Windows.Forms.Label()
        Me.LblTotalImpuestoM = New System.Windows.Forms.Label()
        Me.LblSubTotalM = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.DgvMostrarDetalle = New System.Windows.Forms.DataGridView()
        Me.DgvListado = New System.Windows.Forms.DataGridView()
        Me.TabGeneral = New System.Windows.Forms.TabControl()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.PanelArticulos = New System.Windows.Forms.Panel()
        Me.BtnBuscarArticulosDetalle = New System.Windows.Forms.Button()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TxtBuscarArticulos = New System.Windows.Forms.TextBox()
        Me.BtnInsertar = New System.Windows.Forms.Button()
        CType(Me.DgvDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DgvArticulos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorIcono, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage1.SuspendLayout()
        Me.PanelMostrar.SuspendLayout()
        CType(Me.DgvMostrarDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DgvListado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabGeneral.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.PanelArticulos.SuspendLayout()
        Me.SuspendLayout()
        '
        'Seleccionar
        '
        Me.Seleccionar.HeaderText = "Seleccionar"
        Me.Seleccionar.MinimumWidth = 10
        Me.Seleccionar.Name = "Seleccionar"
        Me.Seleccionar.ReadOnly = True
        Me.Seleccionar.Width = 200
        '
        'BtnCerrar
        '
        Me.BtnCerrar.BackColor = System.Drawing.Color.Goldenrod
        Me.BtnCerrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCerrar.ForeColor = System.Drawing.Color.Black
        Me.BtnCerrar.Image = Global.Sistema.Presentacion.My.Resources.Resources._error
        Me.BtnCerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnCerrar.Location = New System.Drawing.Point(578, 15)
        Me.BtnCerrar.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnCerrar.Name = "BtnCerrar"
        Me.BtnCerrar.Size = New System.Drawing.Size(97, 26)
        Me.BtnCerrar.TabIndex = 4
        Me.BtnCerrar.Text = "Cerrar"
        Me.BtnCerrar.UseVisualStyleBackColor = False
        '
        'LblTotalArticulos
        '
        Me.LblTotalArticulos.AutoSize = True
        Me.LblTotalArticulos.Location = New System.Drawing.Point(569, 226)
        Me.LblTotalArticulos.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblTotalArticulos.Name = "LblTotalArticulos"
        Me.LblTotalArticulos.Size = New System.Drawing.Size(31, 13)
        Me.LblTotalArticulos.TabIndex = 3
        Me.LblTotalArticulos.Text = "Total"
        '
        'TxtCodigo
        '
        Me.TxtCodigo.Location = New System.Drawing.Point(101, 35)
        Me.TxtCodigo.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtCodigo.Name = "TxtCodigo"
        Me.TxtCodigo.Size = New System.Drawing.Size(348, 20)
        Me.TxtCodigo.TabIndex = 8
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(19, 35)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(79, 13)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Código artículo"
        '
        'TxtTotal
        '
        Me.TxtTotal.Location = New System.Drawing.Point(670, 321)
        Me.TxtTotal.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtTotal.Name = "TxtTotal"
        Me.TxtTotal.ReadOnly = True
        Me.TxtTotal.Size = New System.Drawing.Size(90, 20)
        Me.TxtTotal.TabIndex = 6
        '
        'TxtTotalImpuesto
        '
        Me.TxtTotalImpuesto.Location = New System.Drawing.Point(670, 298)
        Me.TxtTotalImpuesto.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtTotalImpuesto.Name = "TxtTotalImpuesto"
        Me.TxtTotalImpuesto.ReadOnly = True
        Me.TxtTotalImpuesto.Size = New System.Drawing.Size(90, 20)
        Me.TxtTotalImpuesto.TabIndex = 5
        '
        'TxtSubTotal
        '
        Me.TxtSubTotal.Location = New System.Drawing.Point(670, 272)
        Me.TxtSubTotal.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtSubTotal.Name = "TxtSubTotal"
        Me.TxtSubTotal.ReadOnly = True
        Me.TxtSubTotal.Size = New System.Drawing.Size(90, 20)
        Me.TxtSubTotal.TabIndex = 4
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(590, 323)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(31, 13)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "Total"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(590, 298)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(77, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Total Impuesto"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(590, 275)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Sub Total"
        '
        'DgvDetalle
        '
        Me.DgvDetalle.AllowUserToAddRows = False
        Me.DgvDetalle.AllowUserToOrderColumns = True
        Me.DgvDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvDetalle.Location = New System.Drawing.Point(19, 76)
        Me.DgvDetalle.Margin = New System.Windows.Forms.Padding(2)
        Me.DgvDetalle.Name = "DgvDetalle"
        Me.DgvDetalle.RowHeadersWidth = 82
        Me.DgvDetalle.RowTemplate.Height = 24
        Me.DgvDetalle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvDetalle.Size = New System.Drawing.Size(820, 183)
        Me.DgvDetalle.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TxtImpuesto)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.TxtNumComprobante)
        Me.GroupBox1.Controls.Add(Me.CboTipoComprobante)
        Me.GroupBox1.Controls.Add(Me.BtnBuscarCliente)
        Me.GroupBox1.Controls.Add(Me.TxtNombreCliente)
        Me.GroupBox1.Controls.Add(Me.TxtIdCliente)
        Me.GroupBox1.Controls.Add(Me.TxtSerieComprobante)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 36)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Size = New System.Drawing.Size(875, 116)
        Me.GroupBox1.TabIndex = 16
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Cabecera"
        '
        'TxtImpuesto
        '
        Me.TxtImpuesto.Location = New System.Drawing.Point(688, 69)
        Me.TxtImpuesto.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtImpuesto.Name = "TxtImpuesto"
        Me.TxtImpuesto.ReadOnly = True
        Me.TxtImpuesto.Size = New System.Drawing.Size(82, 20)
        Me.TxtImpuesto.TabIndex = 22
        Me.TxtImpuesto.Text = "0.18"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(633, 72)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 13)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "Impuesto"
        '
        'TxtNumComprobante
        '
        Me.TxtNumComprobante.Location = New System.Drawing.Point(329, 68)
        Me.TxtNumComprobante.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtNumComprobante.Name = "TxtNumComprobante"
        Me.TxtNumComprobante.Size = New System.Drawing.Size(168, 20)
        Me.TxtNumComprobante.TabIndex = 20
        '
        'CboTipoComprobante
        '
        Me.CboTipoComprobante.FormattingEnabled = True
        Me.CboTipoComprobante.Items.AddRange(New Object() {"Factura", "Boleta", "Ticket"})
        Me.CboTipoComprobante.Location = New System.Drawing.Point(112, 65)
        Me.CboTipoComprobante.Margin = New System.Windows.Forms.Padding(2)
        Me.CboTipoComprobante.Name = "CboTipoComprobante"
        Me.CboTipoComprobante.Size = New System.Drawing.Size(93, 21)
        Me.CboTipoComprobante.TabIndex = 19
        Me.CboTipoComprobante.Text = "Boleta"
        '
        'BtnBuscarCliente
        '
        Me.BtnBuscarCliente.Location = New System.Drawing.Point(509, 32)
        Me.BtnBuscarCliente.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnBuscarCliente.Name = "BtnBuscarCliente"
        Me.BtnBuscarCliente.Size = New System.Drawing.Size(65, 19)
        Me.BtnBuscarCliente.TabIndex = 18
        Me.BtnBuscarCliente.Text = "..."
        Me.BtnBuscarCliente.UseVisualStyleBackColor = True
        '
        'TxtNombreCliente
        '
        Me.TxtNombreCliente.Location = New System.Drawing.Point(220, 33)
        Me.TxtNombreCliente.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtNombreCliente.Name = "TxtNombreCliente"
        Me.TxtNombreCliente.ReadOnly = True
        Me.TxtNombreCliente.Size = New System.Drawing.Size(277, 20)
        Me.TxtNombreCliente.TabIndex = 17
        '
        'TxtIdCliente
        '
        Me.TxtIdCliente.Location = New System.Drawing.Point(112, 34)
        Me.TxtIdCliente.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtIdCliente.Name = "TxtIdCliente"
        Me.TxtIdCliente.ReadOnly = True
        Me.TxtIdCliente.Size = New System.Drawing.Size(93, 20)
        Me.TxtIdCliente.TabIndex = 16
        '
        'TxtSerieComprobante
        '
        Me.TxtSerieComprobante.Location = New System.Drawing.Point(220, 68)
        Me.TxtSerieComprobante.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtSerieComprobante.Name = "TxtSerieComprobante"
        Me.TxtSerieComprobante.Size = New System.Drawing.Size(91, 20)
        Me.TxtSerieComprobante.TabIndex = 15
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(16, 68)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(70, 13)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Comprobante"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(14, 34)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Cliente (*)"
        '
        'TxtId
        '
        Me.TxtId.Location = New System.Drawing.Point(331, 13)
        Me.TxtId.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtId.Name = "TxtId"
        Me.TxtId.Size = New System.Drawing.Size(76, 20)
        Me.TxtId.TabIndex = 6
        Me.TxtId.Visible = False
        '
        'BtnCancelar
        '
        Me.BtnCancelar.BackColor = System.Drawing.Color.Goldenrod
        Me.BtnCancelar.Image = Global.Sistema.Presentacion.My.Resources.Resources._error
        Me.BtnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnCancelar.Location = New System.Drawing.Point(196, 525)
        Me.BtnCancelar.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(128, 30)
        Me.BtnCancelar.TabIndex = 5
        Me.BtnCancelar.Text = "Cancelar"
        Me.BtnCancelar.UseVisualStyleBackColor = False
        '
        'DgvArticulos
        '
        Me.DgvArticulos.AllowUserToAddRows = False
        Me.DgvArticulos.AllowUserToDeleteRows = False
        Me.DgvArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvArticulos.Location = New System.Drawing.Point(10, 63)
        Me.DgvArticulos.Margin = New System.Windows.Forms.Padding(2)
        Me.DgvArticulos.Name = "DgvArticulos"
        Me.DgvArticulos.ReadOnly = True
        Me.DgvArticulos.RowHeadersWidth = 82
        Me.DgvArticulos.RowTemplate.Height = 24
        Me.DgvArticulos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvArticulos.Size = New System.Drawing.Size(665, 150)
        Me.DgvArticulos.TabIndex = 2
        '
        'ErrorIcono
        '
        Me.ErrorIcono.ContainerControl = Me
        '
        'BtnBuscarArticulos
        '
        Me.BtnBuscarArticulos.BackColor = System.Drawing.Color.Goldenrod
        Me.BtnBuscarArticulos.Image = Global.Sistema.Presentacion.My.Resources.Resources.lupa
        Me.BtnBuscarArticulos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnBuscarArticulos.Location = New System.Drawing.Point(463, 33)
        Me.BtnBuscarArticulos.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnBuscarArticulos.Name = "BtnBuscarArticulos"
        Me.BtnBuscarArticulos.Size = New System.Drawing.Size(111, 22)
        Me.BtnBuscarArticulos.TabIndex = 9
        Me.BtnBuscarArticulos.Text = "Buscar"
        Me.BtnBuscarArticulos.UseVisualStyleBackColor = False
        '
        'BtnAnular
        '
        Me.BtnAnular.BackColor = System.Drawing.Color.Goldenrod
        Me.BtnAnular.Location = New System.Drawing.Point(406, 408)
        Me.BtnAnular.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnAnular.Name = "BtnAnular"
        Me.BtnAnular.Size = New System.Drawing.Size(112, 30)
        Me.BtnAnular.TabIndex = 7
        Me.BtnAnular.Text = "Anular"
        Me.BtnAnular.UseVisualStyleBackColor = False
        '
        'ChkSeleccionar
        '
        Me.ChkSeleccionar.AutoSize = True
        Me.ChkSeleccionar.Location = New System.Drawing.Point(25, 408)
        Me.ChkSeleccionar.Margin = New System.Windows.Forms.Padding(2)
        Me.ChkSeleccionar.Name = "ChkSeleccionar"
        Me.ChkSeleccionar.Size = New System.Drawing.Size(82, 17)
        Me.ChkSeleccionar.TabIndex = 4
        Me.ChkSeleccionar.Text = "Seleccionar"
        Me.ChkSeleccionar.UseVisualStyleBackColor = True
        '
        'TxtValor
        '
        Me.TxtValor.Location = New System.Drawing.Point(69, 28)
        Me.TxtValor.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtValor.Name = "TxtValor"
        Me.TxtValor.Size = New System.Drawing.Size(478, 20)
        Me.TxtValor.TabIndex = 2
        '
        'Lbltotal
        '
        Me.Lbltotal.AutoSize = True
        Me.Lbltotal.Location = New System.Drawing.Point(838, 413)
        Me.Lbltotal.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Lbltotal.Name = "Lbltotal"
        Me.Lbltotal.Size = New System.Drawing.Size(31, 13)
        Me.Lbltotal.TabIndex = 1
        Me.Lbltotal.Text = "Total"
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.Khaki
        Me.TabPage1.Controls.Add(Me.Label11)
        Me.TabPage1.Controls.Add(Me.PanelMostrar)
        Me.TabPage1.Controls.Add(Me.BtnAnular)
        Me.TabPage1.Controls.Add(Me.ChkSeleccionar)
        Me.TabPage1.Controls.Add(Me.TxtValor)
        Me.TabPage1.Controls.Add(Me.Lbltotal)
        Me.TabPage1.Controls.Add(Me.DgvListado)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Margin = New System.Windows.Forms.Padding(2)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(2)
        Me.TabPage1.Size = New System.Drawing.Size(1028, 568)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Listado"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(22, 31)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(42, 13)
        Me.Label11.TabIndex = 9
        Me.Label11.Text = "Cliente:"
        '
        'PanelMostrar
        '
        Me.PanelMostrar.BackColor = System.Drawing.Color.LemonChiffon
        Me.PanelMostrar.Controls.Add(Me.BtnCerrarM)
        Me.PanelMostrar.Controls.Add(Me.LblTotalM)
        Me.PanelMostrar.Controls.Add(Me.LblTotalImpuestoM)
        Me.PanelMostrar.Controls.Add(Me.LblSubTotalM)
        Me.PanelMostrar.Controls.Add(Me.Label10)
        Me.PanelMostrar.Controls.Add(Me.Label9)
        Me.PanelMostrar.Controls.Add(Me.Label8)
        Me.PanelMostrar.Controls.Add(Me.DgvMostrarDetalle)
        Me.PanelMostrar.Location = New System.Drawing.Point(292, 220)
        Me.PanelMostrar.Margin = New System.Windows.Forms.Padding(2)
        Me.PanelMostrar.Name = "PanelMostrar"
        Me.PanelMostrar.Size = New System.Drawing.Size(723, 345)
        Me.PanelMostrar.TabIndex = 8
        Me.PanelMostrar.Visible = False
        '
        'BtnCerrarM
        '
        Me.BtnCerrarM.BackColor = System.Drawing.Color.Goldenrod
        Me.BtnCerrarM.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCerrarM.ForeColor = System.Drawing.Color.Black
        Me.BtnCerrarM.Image = Global.Sistema.Presentacion.My.Resources.Resources._error
        Me.BtnCerrarM.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnCerrarM.Location = New System.Drawing.Point(611, 11)
        Me.BtnCerrarM.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnCerrarM.Name = "BtnCerrarM"
        Me.BtnCerrarM.Size = New System.Drawing.Size(97, 32)
        Me.BtnCerrarM.TabIndex = 7
        Me.BtnCerrarM.Text = "Cerrar"
        Me.BtnCerrarM.UseVisualStyleBackColor = False
        '
        'LblTotalM
        '
        Me.LblTotalM.AutoSize = True
        Me.LblTotalM.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTotalM.Location = New System.Drawing.Point(622, 318)
        Me.LblTotalM.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblTotalM.Name = "LblTotalM"
        Me.LblTotalM.Size = New System.Drawing.Size(17, 17)
        Me.LblTotalM.TabIndex = 6
        Me.LblTotalM.Text = "0"
        '
        'LblTotalImpuestoM
        '
        Me.LblTotalImpuestoM.AutoSize = True
        Me.LblTotalImpuestoM.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTotalImpuestoM.Location = New System.Drawing.Point(622, 294)
        Me.LblTotalImpuestoM.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblTotalImpuestoM.Name = "LblTotalImpuestoM"
        Me.LblTotalImpuestoM.Size = New System.Drawing.Size(17, 17)
        Me.LblTotalImpuestoM.TabIndex = 5
        Me.LblTotalImpuestoM.Text = "0"
        '
        'LblSubTotalM
        '
        Me.LblSubTotalM.AutoSize = True
        Me.LblSubTotalM.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblSubTotalM.Location = New System.Drawing.Point(620, 270)
        Me.LblSubTotalM.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblSubTotalM.Name = "LblSubTotalM"
        Me.LblSubTotalM.Size = New System.Drawing.Size(17, 17)
        Me.LblSubTotalM.TabIndex = 4
        Me.LblSubTotalM.Text = "0"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(542, 318)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(37, 13)
        Me.Label10.TabIndex = 3
        Me.Label10.Text = "Total: "
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(542, 294)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(77, 13)
        Me.Label9.TabIndex = 2
        Me.Label9.Text = "Total Impuesto"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(542, 270)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(56, 13)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "Sub Total:"
        '
        'DgvMostrarDetalle
        '
        Me.DgvMostrarDetalle.AllowUserToAddRows = False
        Me.DgvMostrarDetalle.AllowUserToDeleteRows = False
        Me.DgvMostrarDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvMostrarDetalle.Location = New System.Drawing.Point(16, 48)
        Me.DgvMostrarDetalle.Margin = New System.Windows.Forms.Padding(2)
        Me.DgvMostrarDetalle.Name = "DgvMostrarDetalle"
        Me.DgvMostrarDetalle.ReadOnly = True
        Me.DgvMostrarDetalle.RowHeadersWidth = 82
        Me.DgvMostrarDetalle.RowTemplate.Height = 24
        Me.DgvMostrarDetalle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvMostrarDetalle.Size = New System.Drawing.Size(693, 208)
        Me.DgvMostrarDetalle.TabIndex = 0
        '
        'DgvListado
        '
        Me.DgvListado.AllowUserToAddRows = False
        Me.DgvListado.AllowUserToDeleteRows = False
        Me.DgvListado.AllowUserToOrderColumns = True
        Me.DgvListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvListado.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Seleccionar})
        Me.DgvListado.Location = New System.Drawing.Point(6, 58)
        Me.DgvListado.Margin = New System.Windows.Forms.Padding(2)
        Me.DgvListado.Name = "DgvListado"
        Me.DgvListado.ReadOnly = True
        Me.DgvListado.RowHeadersWidth = 82
        Me.DgvListado.RowTemplate.Height = 24
        Me.DgvListado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvListado.Size = New System.Drawing.Size(1009, 329)
        Me.DgvListado.TabIndex = 0
        '
        'TabGeneral
        '
        Me.TabGeneral.Controls.Add(Me.TabPage1)
        Me.TabGeneral.Controls.Add(Me.TabPage2)
        Me.TabGeneral.Location = New System.Drawing.Point(9, 10)
        Me.TabGeneral.Margin = New System.Windows.Forms.Padding(2)
        Me.TabGeneral.Name = "TabGeneral"
        Me.TabGeneral.SelectedIndex = 0
        Me.TabGeneral.Size = New System.Drawing.Size(1036, 594)
        Me.TabGeneral.TabIndex = 3
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.Khaki
        Me.TabPage2.Controls.Add(Me.GroupBox2)
        Me.TabPage2.Controls.Add(Me.GroupBox1)
        Me.TabPage2.Controls.Add(Me.TxtId)
        Me.TabPage2.Controls.Add(Me.BtnCancelar)
        Me.TabPage2.Controls.Add(Me.BtnInsertar)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Margin = New System.Windows.Forms.Padding(2)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(2)
        Me.TabPage2.Size = New System.Drawing.Size(1028, 568)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Mantenimiento"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.PanelArticulos)
        Me.GroupBox2.Controls.Add(Me.BtnBuscarArticulos)
        Me.GroupBox2.Controls.Add(Me.TxtCodigo)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.TxtTotal)
        Me.GroupBox2.Controls.Add(Me.TxtTotalImpuesto)
        Me.GroupBox2.Controls.Add(Me.TxtSubTotal)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.DgvDetalle)
        Me.GroupBox2.Location = New System.Drawing.Point(13, 168)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox2.Size = New System.Drawing.Size(875, 353)
        Me.GroupBox2.TabIndex = 17
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Detalles"
        '
        'PanelArticulos
        '
        Me.PanelArticulos.BackColor = System.Drawing.Color.LemonChiffon
        Me.PanelArticulos.Controls.Add(Me.BtnBuscarArticulosDetalle)
        Me.PanelArticulos.Controls.Add(Me.Label12)
        Me.PanelArticulos.Controls.Add(Me.BtnCerrar)
        Me.PanelArticulos.Controls.Add(Me.LblTotalArticulos)
        Me.PanelArticulos.Controls.Add(Me.DgvArticulos)
        Me.PanelArticulos.Controls.Add(Me.TxtBuscarArticulos)
        Me.PanelArticulos.Location = New System.Drawing.Point(220, 76)
        Me.PanelArticulos.Margin = New System.Windows.Forms.Padding(2)
        Me.PanelArticulos.Name = "PanelArticulos"
        Me.PanelArticulos.Size = New System.Drawing.Size(694, 262)
        Me.PanelArticulos.TabIndex = 10
        Me.PanelArticulos.Visible = False
        '
        'BtnBuscarArticulosDetalle
        '
        Me.BtnBuscarArticulosDetalle.BackColor = System.Drawing.Color.Goldenrod
        Me.BtnBuscarArticulosDetalle.Image = Global.Sistema.Presentacion.My.Resources.Resources.lupa
        Me.BtnBuscarArticulosDetalle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnBuscarArticulosDetalle.Location = New System.Drawing.Point(483, 15)
        Me.BtnBuscarArticulosDetalle.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnBuscarArticulosDetalle.Name = "BtnBuscarArticulosDetalle"
        Me.BtnBuscarArticulosDetalle.Size = New System.Drawing.Size(91, 27)
        Me.BtnBuscarArticulosDetalle.TabIndex = 10
        Me.BtnBuscarArticulosDetalle.Text = "Buscar"
        Me.BtnBuscarArticulosDetalle.UseVisualStyleBackColor = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(16, 21)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(47, 13)
        Me.Label12.TabIndex = 9
        Me.Label12.Text = "Nombre:"
        '
        'TxtBuscarArticulos
        '
        Me.TxtBuscarArticulos.Location = New System.Drawing.Point(68, 19)
        Me.TxtBuscarArticulos.Margin = New System.Windows.Forms.Padding(2)
        Me.TxtBuscarArticulos.Name = "TxtBuscarArticulos"
        Me.TxtBuscarArticulos.Size = New System.Drawing.Size(398, 20)
        Me.TxtBuscarArticulos.TabIndex = 0
        '
        'BtnInsertar
        '
        Me.BtnInsertar.BackColor = System.Drawing.Color.Goldenrod
        Me.BtnInsertar.Image = Global.Sistema.Presentacion.My.Resources.Resources.insertar
        Me.BtnInsertar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnInsertar.Location = New System.Drawing.Point(35, 525)
        Me.BtnInsertar.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnInsertar.Name = "BtnInsertar"
        Me.BtnInsertar.Size = New System.Drawing.Size(132, 30)
        Me.BtnInsertar.TabIndex = 4
        Me.BtnInsertar.Text = "Insertar"
        Me.BtnInsertar.UseVisualStyleBackColor = False
        '
        'FrmVenta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(852, 604)
        Me.Controls.Add(Me.TabGeneral)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "FrmVenta"
        Me.Text = "Ventas"
        CType(Me.DgvDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DgvArticulos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorIcono, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.PanelMostrar.ResumeLayout(False)
        Me.PanelMostrar.PerformLayout()
        CType(Me.DgvMostrarDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DgvListado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabGeneral.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.PanelArticulos.ResumeLayout(False)
        Me.PanelArticulos.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Seleccionar As DataGridViewCheckBoxColumn
    Friend WithEvents BtnCerrar As Button
    Friend WithEvents LblTotalArticulos As Label
    Friend WithEvents TxtCodigo As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TxtTotal As TextBox
    Friend WithEvents TxtTotalImpuesto As TextBox
    Friend WithEvents TxtSubTotal As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents DgvDetalle As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TxtImpuesto As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtNumComprobante As TextBox
    Friend WithEvents CboTipoComprobante As ComboBox
    Friend WithEvents BtnBuscarCliente As Button
    Friend WithEvents TxtNombreCliente As TextBox
    Friend WithEvents TxtIdCliente As TextBox
    Friend WithEvents TxtSerieComprobante As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtId As TextBox
    Friend WithEvents BtnCancelar As Button
    Friend WithEvents DgvArticulos As DataGridView
    Friend WithEvents ErrorIcono As ErrorProvider
    Friend WithEvents TabGeneral As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents PanelMostrar As Panel
    Friend WithEvents BtnCerrarM As Button
    Friend WithEvents LblTotalM As Label
    Friend WithEvents LblTotalImpuestoM As Label
    Friend WithEvents LblSubTotalM As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents DgvMostrarDetalle As DataGridView
    Friend WithEvents BtnAnular As Button
    Friend WithEvents ChkSeleccionar As CheckBox
    Friend WithEvents TxtValor As TextBox
    Friend WithEvents Lbltotal As Label
    Friend WithEvents DgvListado As DataGridView
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents PanelArticulos As Panel
    Friend WithEvents TxtBuscarArticulos As TextBox
    Friend WithEvents BtnBuscarArticulos As Button
    Friend WithEvents BtnInsertar As Button
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents BtnBuscarArticulosDetalle As Button
End Class
