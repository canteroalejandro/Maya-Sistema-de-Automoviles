Public Class GUIPrincipal
    Inherits System.Windows.Forms.Form
    Public PM As New PropietariosManager        ''Referencia
    Dim GUIAutom As New AutomovilesManager
    Dim GUIProp As New GUIPropietarios(PM)



#Region " Código generado por el Diseñador de Windows Forms "

    Public Sub New(ByVal PropMang As PropietariosManager)
        MyBase.New()

        'El Diseñador de Windows Forms requiere esta llamada.
        InitializeComponent()

        'Agregar cualquier inicialización después de la llamada a InitializeComponent()
        PM = PropMang
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
    Friend WithEvents btPropietarios As System.Windows.Forms.Button
    Friend WithEvents btAutomoviles As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label
        Me.btPropietarios = New System.Windows.Forms.Button
        Me.btAutomoviles = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(104, 73)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(328, 40)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Bienvenido a Maya el software que te soluciona la vida :)"
        '
        'btPropietarios
        '
        Me.btPropietarios.Location = New System.Drawing.Point(96, 161)
        Me.btPropietarios.Name = "btPropietarios"
        Me.btPropietarios.Size = New System.Drawing.Size(104, 56)
        Me.btPropietarios.TabIndex = 1
        Me.btPropietarios.Text = "Propietarios"
        '
        'btAutomoviles
        '
        Me.btAutomoviles.Location = New System.Drawing.Point(280, 161)
        Me.btAutomoviles.Name = "btAutomoviles"
        Me.btAutomoviles.Size = New System.Drawing.Size(112, 56)
        Me.btAutomoviles.TabIndex = 2
        Me.btAutomoviles.Text = "Automoviles"
        '
        'GUI
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(528, 290)
        Me.Controls.Add(Me.btAutomoviles)
        Me.Controls.Add(Me.btPropietarios)
        Me.Controls.Add(Me.Label1)
        Me.Name = "GUI"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub btPropietarios_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btPropietarios.Click
        GUIProp.Show()
    End Sub
End Class
