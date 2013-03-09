Public Class GUIPropietarios
    Inherits System.Windows.Forms.Form
    Public PM As New PropietariosManager
    Public guiAddProp As New GUI_agregar_propietario(PM)
    Public guiEditProp As New GUI_editar_propietario(PM)

#Region " Código generado por el Diseñador de Windows Forms "

    Public Sub New(ByVal PropManag As PropietariosManager, ByVal GuiAtom As GUIautomoviles)
        MyBase.New()

        'El Diseñador de Windows Forms requiere esta llamada.
        InitializeComponent()

        'Agregar cualquier inicialización después de la llamada a InitializeComponent()
        PM = PropManag

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
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btAgregarProp As System.Windows.Forms.Button
    Friend WithEvents btEditarProp As System.Windows.Forms.Button
    Friend WithEvents btEliminarProp As System.Windows.Forms.Button
    Friend WithEvents btVerAutom As System.Windows.Forms.Button
    Friend WithEvents lvPrpietarios As System.Windows.Forms.ListView
    Friend WithEvents btBuscar As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents tbBuscarProp As System.Windows.Forms.TextBox
    Friend WithEvents cbFiltrosProp As System.Windows.Forms.ComboBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(GUIPropietarios))
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.tbBuscarProp = New System.Windows.Forms.TextBox
        Me.btAgregarProp = New System.Windows.Forms.Button
        Me.btEditarProp = New System.Windows.Forms.Button
        Me.btEliminarProp = New System.Windows.Forms.Button
        Me.btVerAutom = New System.Windows.Forms.Button
        Me.lvPrpietarios = New System.Windows.Forms.ListView
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader4 = New System.Windows.Forms.ColumnHeader
        Me.btBuscar = New System.Windows.Forms.Button
        Me.cbFiltrosProp = New System.Windows.Forms.ComboBox
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(8, 56)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Buscar:"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(528, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Filtros:"
        '
        'tbBuscarProp
        '
        Me.tbBuscarProp.Location = New System.Drawing.Point(64, 56)
        Me.tbBuscarProp.Name = "tbBuscarProp"
        Me.tbBuscarProp.Size = New System.Drawing.Size(328, 20)
        Me.tbBuscarProp.TabIndex = 2
        Me.tbBuscarProp.Text = ""
        '
        'btAgregarProp
        '
        Me.btAgregarProp.Location = New System.Drawing.Point(592, 96)
        Me.btAgregarProp.Name = "btAgregarProp"
        Me.btAgregarProp.Size = New System.Drawing.Size(88, 24)
        Me.btAgregarProp.TabIndex = 5
        Me.btAgregarProp.Text = "Agregar"
        '
        'btEditarProp
        '
        Me.btEditarProp.Location = New System.Drawing.Point(592, 136)
        Me.btEditarProp.Name = "btEditarProp"
        Me.btEditarProp.Size = New System.Drawing.Size(88, 24)
        Me.btEditarProp.TabIndex = 6
        Me.btEditarProp.Text = "Editar"
        '
        'btEliminarProp
        '
        Me.btEliminarProp.Location = New System.Drawing.Point(592, 168)
        Me.btEliminarProp.Name = "btEliminarProp"
        Me.btEliminarProp.Size = New System.Drawing.Size(88, 24)
        Me.btEliminarProp.TabIndex = 7
        Me.btEliminarProp.Text = "Eliminar"
        '
        'btVerAutom
        '
        Me.btVerAutom.Location = New System.Drawing.Point(592, 240)
        Me.btVerAutom.Name = "btVerAutom"
        Me.btVerAutom.Size = New System.Drawing.Size(88, 32)
        Me.btVerAutom.TabIndex = 8
        Me.btVerAutom.Text = "Ver Automoviles"
        '
        'lvPrpietarios
        '
        Me.lvPrpietarios.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4})
        Me.lvPrpietarios.FullRowSelect = True
        Me.lvPrpietarios.GridLines = True
        Me.lvPrpietarios.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.lvPrpietarios.Location = New System.Drawing.Point(8, 88)
        Me.lvPrpietarios.MultiSelect = False
        Me.lvPrpietarios.Name = "lvPrpietarios"
        Me.lvPrpietarios.Size = New System.Drawing.Size(576, 384)
        Me.lvPrpietarios.TabIndex = 9
        Me.lvPrpietarios.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "DNI"
        Me.ColumnHeader1.Width = 122
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Apellido"
        Me.ColumnHeader2.Width = 159
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Nombre"
        Me.ColumnHeader3.Width = 157
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Fecha de Nacimiento"
        Me.ColumnHeader4.Width = 132
        '
        'btBuscar
        '
        Me.btBuscar.Location = New System.Drawing.Point(408, 52)
        Me.btBuscar.Name = "btBuscar"
        Me.btBuscar.Size = New System.Drawing.Size(88, 24)
        Me.btBuscar.TabIndex = 10
        Me.btBuscar.Text = "Buscar"
        '
        'cbFiltrosProp
        '
        Me.cbFiltrosProp.Items.AddRange(New Object() {"DNI", "nombre"})
        Me.cbFiltrosProp.Location = New System.Drawing.Point(568, 56)
        Me.cbFiltrosProp.Name = "cbFiltrosProp"
        Me.cbFiltrosProp.Size = New System.Drawing.Size(104, 21)
        Me.cbFiltrosProp.TabIndex = 11
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(16, 8)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(96, 32)
        Me.PictureBox1.TabIndex = 12
        Me.PictureBox1.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(688, 48)
        Me.Panel1.TabIndex = 13
        '
        'GUIPropietarios
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(684, 490)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.cbFiltrosProp)
        Me.Controls.Add(Me.btBuscar)
        Me.Controls.Add(Me.lvPrpietarios)
        Me.Controls.Add(Me.btVerAutom)
        Me.Controls.Add(Me.btEliminarProp)
        Me.Controls.Add(Me.btEditarProp)
        Me.Controls.Add(Me.btAgregarProp)
        Me.Controls.Add(Me.tbBuscarProp)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "GUIPropietarios"
        Me.Text = "Propietarios"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Sub detalles_gui()
        cbFiltrosProp.SelectedIndex = 0
    End Sub

    Private Sub GUIPropietarios_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        detalles_gui()
    End Sub

    Private Sub btAgregarProp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btAgregarProp.Click
        guiAddProp.show()
    End Sub
End Class
