Public Class GUImodificar
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
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tbNewCodCiu As System.Windows.Forms.TextBox
    Friend WithEvents tbNewAnio As System.Windows.Forms.TextBox
    Friend WithEvents tbNewModelo As System.Windows.Forms.TextBox
    Friend WithEvents tbNewMarca As System.Windows.Forms.TextBox
    Friend WithEvents tbNewPatenteNum As System.Windows.Forms.TextBox
    Friend WithEvents tbNewPatenteAlpha As System.Windows.Forms.TextBox
    Friend WithEvents btGuardarAutom As System.Windows.Forms.Button
    Friend WithEvents btCancelarEA As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(GUImodificar))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.btGuardarAutom = New System.Windows.Forms.Button
        Me.tbNewCodCiu = New System.Windows.Forms.TextBox
        Me.tbNewAnio = New System.Windows.Forms.TextBox
        Me.tbNewModelo = New System.Windows.Forms.TextBox
        Me.tbNewMarca = New System.Windows.Forms.TextBox
        Me.tbNewPatenteNum = New System.Windows.Forms.TextBox
        Me.tbNewPatenteAlpha = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.btCancelarEA = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(8, 184)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(40, 32)
        Me.PictureBox1.TabIndex = 27
        Me.PictureBox1.TabStop = False
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(160, 24)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(16, 16)
        Me.Label6.TabIndex = 26
        Me.Label6.Text = "-"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btGuardarAutom
        '
        Me.btGuardarAutom.Location = New System.Drawing.Point(192, 184)
        Me.btGuardarAutom.Name = "btGuardarAutom"
        Me.btGuardarAutom.TabIndex = 25
        Me.btGuardarAutom.Text = "Agregar"
        '
        'tbNewCodCiu
        '
        Me.tbNewCodCiu.Location = New System.Drawing.Point(88, 150)
        Me.tbNewCodCiu.Name = "tbNewCodCiu"
        Me.tbNewCodCiu.Size = New System.Drawing.Size(160, 20)
        Me.tbNewCodCiu.TabIndex = 24
        Me.tbNewCodCiu.Text = ""
        '
        'tbNewAnio
        '
        Me.tbNewAnio.Location = New System.Drawing.Point(88, 119)
        Me.tbNewAnio.Name = "tbNewAnio"
        Me.tbNewAnio.Size = New System.Drawing.Size(160, 20)
        Me.tbNewAnio.TabIndex = 23
        Me.tbNewAnio.Text = ""
        '
        'tbNewModelo
        '
        Me.tbNewModelo.Location = New System.Drawing.Point(88, 88)
        Me.tbNewModelo.Name = "tbNewModelo"
        Me.tbNewModelo.Size = New System.Drawing.Size(160, 20)
        Me.tbNewModelo.TabIndex = 22
        Me.tbNewModelo.Text = ""
        '
        'tbNewMarca
        '
        Me.tbNewMarca.Location = New System.Drawing.Point(88, 56)
        Me.tbNewMarca.Name = "tbNewMarca"
        Me.tbNewMarca.Size = New System.Drawing.Size(160, 20)
        Me.tbNewMarca.TabIndex = 21
        Me.tbNewMarca.Text = ""
        '
        'tbNewPatenteNum
        '
        Me.tbNewPatenteNum.Location = New System.Drawing.Point(176, 24)
        Me.tbNewPatenteNum.Name = "tbNewPatenteNum"
        Me.tbNewPatenteNum.Size = New System.Drawing.Size(72, 20)
        Me.tbNewPatenteNum.TabIndex = 20
        Me.tbNewPatenteNum.Text = ""
        '
        'tbNewPatenteAlpha
        '
        Me.tbNewPatenteAlpha.Location = New System.Drawing.Point(88, 24)
        Me.tbNewPatenteAlpha.Name = "tbNewPatenteAlpha"
        Me.tbNewPatenteAlpha.Size = New System.Drawing.Size(72, 20)
        Me.tbNewPatenteAlpha.TabIndex = 19
        Me.tbNewPatenteAlpha.Text = ""
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(8, 150)
        Me.Label5.Name = "Label5"
        Me.Label5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label5.Size = New System.Drawing.Size(64, 36)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "Codigo de Ciudad:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(8, 119)
        Me.Label4.Name = "Label4"
        Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label4.Size = New System.Drawing.Size(64, 23)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "Año:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(8, 88)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label3.Size = New System.Drawing.Size(64, 23)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Modelo:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(8, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(64, 23)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Marca:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(8, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(64, 23)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Patente:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'btCancelarEA
        '
        Me.btCancelarEA.Location = New System.Drawing.Point(104, 184)
        Me.btCancelarEA.Name = "btCancelarEA"
        Me.btCancelarEA.TabIndex = 28
        Me.btCancelarEA.Text = "Cancelar"
        '
        'GUImodificar
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(272, 218)
        Me.Controls.Add(Me.btCancelarEA)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.btGuardarAutom)
        Me.Controls.Add(Me.tbNewCodCiu)
        Me.Controls.Add(Me.tbNewAnio)
        Me.Controls.Add(Me.tbNewModelo)
        Me.Controls.Add(Me.tbNewMarca)
        Me.Controls.Add(Me.tbNewPatenteNum)
        Me.Controls.Add(Me.tbNewPatenteAlpha)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "GUImodificar"
        Me.Text = "Editar Automovil"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub btCancelarEA_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btCancelarEA.Click
        Me.Close()
    End Sub
End Class
