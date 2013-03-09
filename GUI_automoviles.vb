Public Class GUIautomoviles
    Inherits System.Windows.Forms.Form

#Region " Código generado por el Diseñador de Windows Forms "

    Public Sub New()
        MyBase.New()

        'El Diseñador de Windows Forms requiere esta llamada.
        InitializeComponent()

        'Agregar cualquier inicialización después de la llamada a InitializeComponent()

    End Sub

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms requiere el siguiente procedimiento
    'Puede modificarse utilizando el Diseñador de Windows Forms. 
    'No lo modifique con el editor de código.
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents btVerProp As System.Windows.Forms.Button
    Friend WithEvents btEliminarAutom As System.Windows.Forms.Button
    Friend WithEvents btEditarAutom As System.Windows.Forms.Button
    Friend WithEvents btAgregarAutom As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents cbFiltrosAutom As System.Windows.Forms.ComboBox
    Friend WithEvents tbBuscarProp As System.Windows.Forms.TextBox
    Friend WithEvents btBuscarAutom As System.Windows.Forms.Button
    Friend WithEvents lvAutomoviles As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(GUIautomoviles))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.cbFiltrosAutom = New System.Windows.Forms.ComboBox
        Me.btBuscarAutom = New System.Windows.Forms.Button
        Me.lvAutomoviles = New System.Windows.Forms.ListView
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader4 = New System.Windows.Forms.ColumnHeader
        Me.btVerProp = New System.Windows.Forms.Button
        Me.btEliminarAutom = New System.Windows.Forms.Button
        Me.btEditarAutom = New System.Windows.Forms.Button
        Me.btAgregarAutom = New System.Windows.Forms.Button
        Me.tbBuscarProp = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.ColumnHeader5 = New System.Windows.Forms.ColumnHeader
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(14, 8)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(96, 32)
        Me.PictureBox1.TabIndex = 24
        Me.PictureBox1.TabStop = False
        '
        'cbFiltrosAutom
        '
        Me.cbFiltrosAutom.Items.AddRange(New Object() {"Patente"})
        Me.cbFiltrosAutom.Location = New System.Drawing.Point(566, 56)
        Me.cbFiltrosAutom.Name = "cbFiltrosAutom"
        Me.cbFiltrosAutom.Size = New System.Drawing.Size(104, 21)
        Me.cbFiltrosAutom.TabIndex = 23
        '
        'btBuscarAutom
        '
        Me.btBuscarAutom.Location = New System.Drawing.Point(406, 52)
        Me.btBuscarAutom.Name = "btBuscarAutom"
        Me.btBuscarAutom.Size = New System.Drawing.Size(88, 24)
        Me.btBuscarAutom.TabIndex = 22
        Me.btBuscarAutom.Text = "Buscar"
        '
        'lvAutomoviles
        '
        Me.lvAutomoviles.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5})
        Me.lvAutomoviles.FullRowSelect = True
        Me.lvAutomoviles.GridLines = True
        Me.lvAutomoviles.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.lvAutomoviles.Location = New System.Drawing.Point(6, 88)
        Me.lvAutomoviles.MultiSelect = False
        Me.lvAutomoviles.Name = "lvAutomoviles"
        Me.lvAutomoviles.Size = New System.Drawing.Size(576, 384)
        Me.lvAutomoviles.TabIndex = 21
        Me.lvAutomoviles.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Patente"
        Me.ColumnHeader1.Width = 122
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Marca"
        Me.ColumnHeader2.Width = 151
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Modelo"
        Me.ColumnHeader3.Width = 103
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Año"
        Me.ColumnHeader4.Width = 68
        '
        'btVerProp
        '
        Me.btVerProp.Location = New System.Drawing.Point(590, 240)
        Me.btVerProp.Name = "btVerProp"
        Me.btVerProp.Size = New System.Drawing.Size(88, 32)
        Me.btVerProp.TabIndex = 20
        Me.btVerProp.Text = "Ver Propietario"
        '
        'btEliminarAutom
        '
        Me.btEliminarAutom.Location = New System.Drawing.Point(590, 168)
        Me.btEliminarAutom.Name = "btEliminarAutom"
        Me.btEliminarAutom.Size = New System.Drawing.Size(88, 24)
        Me.btEliminarAutom.TabIndex = 19
        Me.btEliminarAutom.Text = "Eliminar"
        '
        'btEditarAutom
        '
        Me.btEditarAutom.Location = New System.Drawing.Point(590, 136)
        Me.btEditarAutom.Name = "btEditarAutom"
        Me.btEditarAutom.Size = New System.Drawing.Size(88, 24)
        Me.btEditarAutom.TabIndex = 18
        Me.btEditarAutom.Text = "Editar"
        '
        'btAgregarAutom
        '
        Me.btAgregarAutom.Location = New System.Drawing.Point(590, 96)
        Me.btAgregarAutom.Name = "btAgregarAutom"
        Me.btAgregarAutom.Size = New System.Drawing.Size(88, 24)
        Me.btAgregarAutom.TabIndex = 17
        Me.btAgregarAutom.Text = "Agregar"
        '
        'tbBuscarProp
        '
        Me.tbBuscarProp.Location = New System.Drawing.Point(62, 56)
        Me.tbBuscarProp.Name = "tbBuscarProp"
        Me.tbBuscarProp.Size = New System.Drawing.Size(328, 20)
        Me.tbBuscarProp.TabIndex = 16
        Me.tbBuscarProp.Text = ""
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(526, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 16)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Filtros:"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(6, 56)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 16)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Buscar:"
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Panel1.Location = New System.Drawing.Point(-2, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(688, 48)
        Me.Panel1.TabIndex = 25
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Código de Ciudad"
        Me.ColumnHeader5.Width = 126
        '
        'GUIautomoviles
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(684, 490)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.cbFiltrosAutom)
        Me.Controls.Add(Me.btBuscarAutom)
        Me.Controls.Add(Me.lvAutomoviles)
        Me.Controls.Add(Me.btVerProp)
        Me.Controls.Add(Me.btEliminarAutom)
        Me.Controls.Add(Me.btEditarAutom)
        Me.Controls.Add(Me.btAgregarAutom)
        Me.Controls.Add(Me.tbBuscarProp)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "GUIautomoviles"
        Me.Text = "Automoviles"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Sub detalles_gui()
        cbFiltrosAutom.SelectedIndex = 0
    End Sub

    Private Sub GUIPropietarios_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        detalles_gui()
    End Sub
End Class
