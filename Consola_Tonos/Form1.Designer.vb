<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Interfaz
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Alerta124Bt = New System.Windows.Forms.Button()
        Me.AlertaBt = New System.Windows.Forms.Button()
        Me.DespachoBt = New System.Windows.Forms.Button()
        Me.IncendioBt = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.PTT = New System.IO.Ports.SerialPort(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.B1 = New System.Windows.Forms.Label()
        Me.B2 = New System.Windows.Forms.Label()
        Me.B3 = New System.Windows.Forms.Label()
        Me.B4 = New System.Windows.Forms.Label()
        Me.R2 = New System.Windows.Forms.Label()
        Me.RX2 = New System.Windows.Forms.Label()
        Me.R4 = New System.Windows.Forms.Label()
        Me.Z1 = New System.Windows.Forms.Label()
        Me.K1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Alerta124Bt
        '
        Me.Alerta124Bt.BackColor = System.Drawing.Color.LightGreen
        Me.Alerta124Bt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Alerta124Bt.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Alerta124Bt.Location = New System.Drawing.Point(17, 20)
        Me.Alerta124Bt.Name = "Alerta124Bt"
        Me.Alerta124Bt.Size = New System.Drawing.Size(170, 61)
        Me.Alerta124Bt.TabIndex = 0
        Me.Alerta124Bt.Text = "Alerta 12.4"
        Me.Alerta124Bt.UseVisualStyleBackColor = False
        '
        'AlertaBt
        '
        Me.AlertaBt.BackColor = System.Drawing.Color.Gold
        Me.AlertaBt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.AlertaBt.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AlertaBt.Location = New System.Drawing.Point(17, 99)
        Me.AlertaBt.Name = "AlertaBt"
        Me.AlertaBt.Size = New System.Drawing.Size(170, 61)
        Me.AlertaBt.TabIndex = 0
        Me.AlertaBt.Text = "Alerta Despacho"
        Me.AlertaBt.UseVisualStyleBackColor = False
        '
        'DespachoBt
        '
        Me.DespachoBt.BackColor = System.Drawing.Color.Turquoise
        Me.DespachoBt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.DespachoBt.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DespachoBt.Location = New System.Drawing.Point(17, 178)
        Me.DespachoBt.Name = "DespachoBt"
        Me.DespachoBt.Size = New System.Drawing.Size(170, 61)
        Me.DespachoBt.TabIndex = 0
        Me.DespachoBt.Text = "Despacho"
        Me.DespachoBt.UseVisualStyleBackColor = False
        '
        'IncendioBt
        '
        Me.IncendioBt.BackColor = System.Drawing.Color.Tomato
        Me.IncendioBt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IncendioBt.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IncendioBt.Location = New System.Drawing.Point(17, 257)
        Me.IncendioBt.Name = "IncendioBt"
        Me.IncendioBt.Size = New System.Drawing.Size(170, 61)
        Me.IncendioBt.TabIndex = 0
        Me.IncendioBt.Text = "Alarma Incendio"
        Me.IncendioBt.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.B4)
        Me.GroupBox1.Controls.Add(Me.R4)
        Me.GroupBox1.Controls.Add(Me.B3)
        Me.GroupBox1.Controls.Add(Me.RX2)
        Me.GroupBox1.Controls.Add(Me.B2)
        Me.GroupBox1.Controls.Add(Me.K1)
        Me.GroupBox1.Controls.Add(Me.Z1)
        Me.GroupBox1.Controls.Add(Me.R2)
        Me.GroupBox1.Controls.Add(Me.B1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(205, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(361, 306)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Unidades en Servicio"
        '
        'B1
        '
        Me.B1.AutoSize = True
        Me.B1.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.B1.ForeColor = System.Drawing.Color.Gainsboro
        Me.B1.Location = New System.Drawing.Point(30, 47)
        Me.B1.Name = "B1"
        Me.B1.Size = New System.Drawing.Size(60, 25)
        Me.B1.TabIndex = 0
        Me.B1.Text = "B - 1"
        '
        'B2
        '
        Me.B2.AutoSize = True
        Me.B2.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.B2.ForeColor = System.Drawing.Color.Gainsboro
        Me.B2.Location = New System.Drawing.Point(113, 47)
        Me.B2.Name = "B2"
        Me.B2.Size = New System.Drawing.Size(60, 25)
        Me.B2.TabIndex = 0
        Me.B2.Text = "B - 2"
        '
        'B3
        '
        Me.B3.AutoSize = True
        Me.B3.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.B3.ForeColor = System.Drawing.Color.Gainsboro
        Me.B3.Location = New System.Drawing.Point(196, 47)
        Me.B3.Name = "B3"
        Me.B3.Size = New System.Drawing.Size(60, 25)
        Me.B3.TabIndex = 0
        Me.B3.Text = "B - 3"
        '
        'B4
        '
        Me.B4.AutoSize = True
        Me.B4.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.B4.ForeColor = System.Drawing.Color.Gainsboro
        Me.B4.Location = New System.Drawing.Point(279, 47)
        Me.B4.Name = "B4"
        Me.B4.Size = New System.Drawing.Size(60, 25)
        Me.B4.TabIndex = 0
        Me.B4.Text = "B - 4"
        '
        'R2
        '
        Me.R2.AutoSize = True
        Me.R2.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.R2.ForeColor = System.Drawing.Color.Gainsboro
        Me.R2.Location = New System.Drawing.Point(30, 114)
        Me.R2.Name = "R2"
        Me.R2.Size = New System.Drawing.Size(61, 25)
        Me.R2.TabIndex = 0
        Me.R2.Text = "R - 2"
        '
        'RX2
        '
        Me.RX2.AutoSize = True
        Me.RX2.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RX2.ForeColor = System.Drawing.Color.Gainsboro
        Me.RX2.Location = New System.Drawing.Point(113, 114)
        Me.RX2.Name = "RX2"
        Me.RX2.Size = New System.Drawing.Size(75, 25)
        Me.RX2.TabIndex = 0
        Me.RX2.Text = "RX - 2"
        '
        'R4
        '
        Me.R4.AutoSize = True
        Me.R4.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.R4.ForeColor = System.Drawing.Color.Gainsboro
        Me.R4.Location = New System.Drawing.Point(196, 114)
        Me.R4.Name = "R4"
        Me.R4.Size = New System.Drawing.Size(61, 25)
        Me.R4.TabIndex = 0
        Me.R4.Text = "R - 4"
        '
        'Z1
        '
        Me.Z1.AutoSize = True
        Me.Z1.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Z1.ForeColor = System.Drawing.Color.Gainsboro
        Me.Z1.Location = New System.Drawing.Point(30, 181)
        Me.Z1.Name = "Z1"
        Me.Z1.Size = New System.Drawing.Size(59, 25)
        Me.Z1.TabIndex = 0
        Me.Z1.Text = "Z - 1"
        '
        'K1
        '
        Me.K1.AutoSize = True
        Me.K1.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.K1.ForeColor = System.Drawing.Color.Gainsboro
        Me.K1.Location = New System.Drawing.Point(28, 246)
        Me.K1.Name = "K1"
        Me.K1.Size = New System.Drawing.Size(61, 25)
        Me.K1.TabIndex = 0
        Me.K1.Text = "K - 1"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(274, 242)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(35, 41)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Interfaz
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.GhostWhite
        Me.ClientSize = New System.Drawing.Size(584, 334)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.IncendioBt)
        Me.Controls.Add(Me.DespachoBt)
        Me.Controls.Add(Me.AlertaBt)
        Me.Controls.Add(Me.Alerta124Bt)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Interfaz"
        Me.ShowInTaskbar = False
        Me.Text = "Consola de Tonos"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Alerta124Bt As Button
    Friend WithEvents AlertaBt As Button
    Friend WithEvents DespachoBt As Button
    Friend WithEvents IncendioBt As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents PTT As IO.Ports.SerialPort
    Friend WithEvents Timer1 As Timer
    Friend WithEvents B4 As Label
    Friend WithEvents R4 As Label
    Friend WithEvents B3 As Label
    Friend WithEvents RX2 As Label
    Friend WithEvents B2 As Label
    Friend WithEvents K1 As Label
    Friend WithEvents Z1 As Label
    Friend WithEvents R2 As Label
    Friend WithEvents B1 As Label
    Friend WithEvents Button1 As Button
End Class
