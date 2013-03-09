Public Class GUI_editar_propietario
    Inherits System.Windows.Forms.Form
    Dim PM As PropietariosManager

#Region " Código generado por el Diseñador de Windows Forms "

    Public Sub New(ByVal PMarg As PropietariosManager)
        MyBase.New()

        'El Diseñador de Windows Forms requiere esta llamada.
        InitializeComponent()

        'Agregar cualquier inicialización después de la llamada a InitializeComponent()
        Me.PM = PMarg
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
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btGuardarProp As System.Windows.Forms.Button
    Friend WithEvents tbNewFechadeNac As System.Windows.Forms.TextBox
    Friend WithEvents tbNewDNI As System.Windows.Forms.TextBox
    Friend WithEvents tbNewApellido As System.Windows.Forms.TextBox
    Friend WithEvents tbNewNombre As System.Windows.Forms.TextBox
    Friend WithEvents btCancelarEP As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(GUI_editar_propietario))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.btGuardarProp = New System.Windows.Forms.Button
        Me.tbNewFechadeNac = New System.Windows.Forms.TextBox
        Me.tbNewDNI = New System.Windows.Forms.TextBox
        Me.tbNewApellido = New System.Windows.Forms.TextBox
        Me.tbNewNombre = New System.Windows.Forms.TextBox
        Me.btCancelarEP = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(8, 168)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(40, 32)
        Me.PictureBox1.TabIndex = 24
        Me.PictureBox1.TabStop = False
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(16, 120)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 32)
        Me.Label4.TabIndex = 23
        Me.Label4.Text = "Fecha de Nacimiento:"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(32, 88)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 16)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "Nombre:"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(32, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 16)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "Apellido:"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(48, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(32, 16)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "DNI:"
        '
        'btGuardarProp
        '
        Me.btGuardarProp.Location = New System.Drawing.Point(192, 168)
        Me.btGuardarProp.Name = "btGuardarProp"
        Me.btGuardarProp.TabIndex = 19
        Me.btGuardarProp.Text = "Guardar"
        '
        'tbNewFechadeNac
        '
        Me.tbNewFechadeNac.Location = New System.Drawing.Point(96, 120)
        Me.tbNewFechadeNac.Name = "tbNewFechadeNac"
        Me.tbNewFechadeNac.Size = New System.Drawing.Size(152, 20)
        Me.tbNewFechadeNac.TabIndex = 18
        Me.tbNewFechadeNac.Text = ""
        '
        'tbNewDNI
        '
        Me.tbNewDNI.Location = New System.Drawing.Point(96, 20)
        Me.tbNewDNI.Name = "tbNewDNI"
        Me.tbNewDNI.Size = New System.Drawing.Size(152, 20)
        Me.tbNewDNI.TabIndex = 17
        Me.tbNewDNI.Text = ""
        '
        'tbNewApellido
        '
        Me.tbNewApellido.Location = New System.Drawing.Point(96, 52)
        Me.tbNewApellido.Name = "tbNewApellido"
        Me.tbNewApellido.Size = New System.Drawing.Size(152, 20)
        Me.tbNewApellido.TabIndex = 16
        Me.tbNewApellido.Text = ""
        '
        'tbNewNombre
        '
        Me.tbNewNombre.Location = New System.Drawing.Point(96, 84)
        Me.tbNewNombre.Name = "tbNewNombre"
        Me.tbNewNombre.Size = New System.Drawing.Size(152, 20)
        Me.tbNewNombre.TabIndex = 15
        Me.tbNewNombre.Text = ""
        '
        'btCancelarEP
        '
        Me.btCancelarEP.Location = New System.Drawing.Point(112, 168)
        Me.btCancelarEP.Name = "btCancelarEP"
        Me.btCancelarEP.TabIndex = 25
        Me.btCancelarEP.Text = "Cancelar"
        '
        'GUI_editar_propietario
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(272, 202)
        Me.Controls.Add(Me.btCancelarEP)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btGuardarProp)
        Me.Controls.Add(Me.tbNewFechadeNac)
        Me.Controls.Add(Me.tbNewDNI)
        Me.Controls.Add(Me.tbNewApellido)
        Me.Controls.Add(Me.tbNewNombre)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "GUI_editar_propietario"
        Me.Text = "Editar Propietario"
        Me.ResumeLayout(False)

    End Sub

#End Region


    Private Sub btCancelarEP_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btCancelarEP.Click
        Me.Close()
    End Sub
End Class
