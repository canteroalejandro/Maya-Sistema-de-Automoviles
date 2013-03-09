Public Class GUIagregar
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
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents tbPatenteAlpha As System.Windows.Forms.TextBox
    Friend WithEvents tbPatenteNum As System.Windows.Forms.TextBox
    Friend WithEvents tbMarca As System.Windows.Forms.TextBox
    Friend WithEvents tbModelo As System.Windows.Forms.TextBox
    Friend WithEvents tbAnio As System.Windows.Forms.TextBox
    Friend WithEvents tbCodCiu As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents btAgregarAutom As System.Windows.Forms.Button
    Friend WithEvents btCancelarAA As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(GUIagregar))
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.tbPatenteAlpha = New System.Windows.Forms.TextBox
        Me.tbPatenteNum = New System.Windows.Forms.TextBox
        Me.tbMarca = New System.Windows.Forms.TextBox
        Me.tbModelo = New System.Windows.Forms.TextBox
        Me.tbAnio = New System.Windows.Forms.TextBox
        Me.tbCodCiu = New System.Windows.Forms.TextBox
        Me.btAgregarAutom = New System.Windows.Forms.Button
        Me.Label6 = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.btCancelarAA = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(8, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(64, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Patente:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(8, 55)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(64, 23)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Marca:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(8, 86)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label3.Size = New System.Drawing.Size(64, 23)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Modelo:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(8, 117)
        Me.Label4.Name = "Label4"
        Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label4.Size = New System.Drawing.Size(64, 23)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Año:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(8, 148)
        Me.Label5.Name = "Label5"
        Me.Label5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label5.Size = New System.Drawing.Size(64, 36)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Codigo de Ciudad:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'tbPatenteAlpha
        '
        Me.tbPatenteAlpha.Location = New System.Drawing.Point(88, 24)
        Me.tbPatenteAlpha.Name = "tbPatenteAlpha"
        Me.tbPatenteAlpha.Size = New System.Drawing.Size(72, 20)
        Me.tbPatenteAlpha.TabIndex = 5
        Me.tbPatenteAlpha.Text = ""
        '
        'tbPatenteNum
        '
        Me.tbPatenteNum.Location = New System.Drawing.Point(176, 24)
        Me.tbPatenteNum.Name = "tbPatenteNum"
        Me.tbPatenteNum.Size = New System.Drawing.Size(72, 20)
        Me.tbPatenteNum.TabIndex = 6
        Me.tbPatenteNum.Text = ""
        '
        'tbMarca
        '
        Me.tbMarca.Location = New System.Drawing.Point(88, 53)
        Me.tbMarca.Name = "tbMarca"
        Me.tbMarca.Size = New System.Drawing.Size(160, 20)
        Me.tbMarca.TabIndex = 7
        Me.tbMarca.Text = ""
        '
        'tbModelo
        '
        Me.tbModelo.Location = New System.Drawing.Point(88, 83)
        Me.tbModelo.Name = "tbModelo"
        Me.tbModelo.Size = New System.Drawing.Size(160, 20)
        Me.tbModelo.TabIndex = 8
        Me.tbModelo.Text = ""
        '
        'tbAnio
        '
        Me.tbAnio.Location = New System.Drawing.Point(88, 115)
        Me.tbAnio.Name = "tbAnio"
        Me.tbAnio.Size = New System.Drawing.Size(160, 20)
        Me.tbAnio.TabIndex = 9
        Me.tbAnio.Text = ""
        '
        'tbCodCiu
        '
        Me.tbCodCiu.Location = New System.Drawing.Point(88, 149)
        Me.tbCodCiu.Name = "tbCodCiu"
        Me.tbCodCiu.Size = New System.Drawing.Size(160, 20)
        Me.tbCodCiu.TabIndex = 10
        Me.tbCodCiu.Text = ""
        '
        'btAgregarAutom
        '
        Me.btAgregarAutom.Location = New System.Drawing.Point(192, 184)
        Me.btAgregarAutom.Name = "btAgregarAutom"
        Me.btAgregarAutom.TabIndex = 11
        Me.btAgregarAutom.Text = "Agregar"
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(160, 24)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(16, 16)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "-"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(8, 184)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(40, 32)
        Me.PictureBox1.TabIndex = 13
        Me.PictureBox1.TabStop = False
        '
        'btCancelarAA
        '
        Me.btCancelarAA.Location = New System.Drawing.Point(104, 184)
        Me.btCancelarAA.Name = "btCancelarAA"
        Me.btCancelarAA.TabIndex = 16
        Me.btCancelarAA.Text = "Cancelar"
        '
        'GUIagregar
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(272, 218)
        Me.Controls.Add(Me.btCancelarAA)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.btAgregarAutom)
        Me.Controls.Add(Me.tbCodCiu)
        Me.Controls.Add(Me.tbAnio)
        Me.Controls.Add(Me.tbModelo)
        Me.Controls.Add(Me.tbMarca)
        Me.Controls.Add(Me.tbPatenteNum)
        Me.Controls.Add(Me.tbPatenteAlpha)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "GUIagregar"
        Me.Text = "Agregar Automovil"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub btCancelarAA_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btCancelarAA.Click
        Me.Close()

    End Sub
End Class
