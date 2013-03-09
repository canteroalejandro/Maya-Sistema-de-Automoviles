Public Class GUI_agregar_propietario
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
    Friend WithEvents tbNombre As System.Windows.Forms.TextBox
    Friend WithEvents tbApellido As System.Windows.Forms.TextBox
    Friend WithEvents tbDNI As System.Windows.Forms.TextBox
    Friend WithEvents tbFechadeNac As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btAgregarProp As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents btCancelarAP As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(GUI_agregar_propietario))
        Me.tbNombre = New System.Windows.Forms.TextBox
        Me.tbApellido = New System.Windows.Forms.TextBox
        Me.tbDNI = New System.Windows.Forms.TextBox
        Me.tbFechadeNac = New System.Windows.Forms.TextBox
        Me.btAgregarProp = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.btCancelarAP = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'tbNombre
        '
        Me.tbNombre.Location = New System.Drawing.Point(96, 84)
        Me.tbNombre.Name = "tbNombre"
        Me.tbNombre.Size = New System.Drawing.Size(152, 20)
        Me.tbNombre.TabIndex = 0
        Me.tbNombre.Text = ""
        '
        'tbApellido
        '
        Me.tbApellido.Location = New System.Drawing.Point(96, 52)
        Me.tbApellido.Name = "tbApellido"
        Me.tbApellido.Size = New System.Drawing.Size(152, 20)
        Me.tbApellido.TabIndex = 1
        Me.tbApellido.Text = ""
        '
        'tbDNI
        '
        Me.tbDNI.Location = New System.Drawing.Point(96, 20)
        Me.tbDNI.Name = "tbDNI"
        Me.tbDNI.Size = New System.Drawing.Size(152, 20)
        Me.tbDNI.TabIndex = 2
        Me.tbDNI.Text = ""
        '
        'tbFechadeNac
        '
        Me.tbFechadeNac.Location = New System.Drawing.Point(96, 120)
        Me.tbFechadeNac.Name = "tbFechadeNac"
        Me.tbFechadeNac.Size = New System.Drawing.Size(152, 20)
        Me.tbFechadeNac.TabIndex = 3
        Me.tbFechadeNac.Text = ""
        '
        'btAgregarProp
        '
        Me.btAgregarProp.Location = New System.Drawing.Point(192, 168)
        Me.btAgregarProp.Name = "btAgregarProp"
        Me.btAgregarProp.TabIndex = 4
        Me.btAgregarProp.Text = "Agregar"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(48, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(32, 16)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "DNI:"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(32, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 16)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Apellido:"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(32, 88)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 16)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Nombre:"
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(16, 120)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 32)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Fecha de Nacimiento:"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(8, 168)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(40, 32)
        Me.PictureBox1.TabIndex = 14
        Me.PictureBox1.TabStop = False
        '
        'btCancelarAP
        '
        Me.btCancelarAP.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btCancelarAP.Location = New System.Drawing.Point(112, 168)
        Me.btCancelarAP.Name = "btCancelarAP"
        Me.btCancelarAP.TabIndex = 15
        Me.btCancelarAP.Text = "Cancelar"
        '
        'GUI_agregar_propietario
        '
        Me.AcceptButton = Me.btAgregarProp
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.CancelButton = Me.btCancelarAP
        Me.ClientSize = New System.Drawing.Size(272, 202)
        Me.Controls.Add(Me.btCancelarAP)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btAgregarProp)
        Me.Controls.Add(Me.tbFechadeNac)
        Me.Controls.Add(Me.tbDNI)
        Me.Controls.Add(Me.tbApellido)
        Me.Controls.Add(Me.tbNombre)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "GUI_agregar_propietario"
        Me.Text = "Agregar Propietario"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub btCancelarAP_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btCancelarAP.Click
        Me.Close()
    End Sub
End Class
