<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.btnPlay = New System.Windows.Forms.Button()
        Me.btnStop = New System.Windows.Forms.Button()
        Me.txtN1 = New System.Windows.Forms.TextBox()
        Me.txtN3 = New System.Windows.Forms.TextBox()
        Me.txtN2 = New System.Windows.Forms.TextBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer3 = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnPlay
        '
        Me.btnPlay.Font = New System.Drawing.Font("Stencil", 22.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnPlay.Location = New System.Drawing.Point(556, 147)
        Me.btnPlay.Name = "btnPlay"
        Me.btnPlay.Size = New System.Drawing.Size(205, 72)
        Me.btnPlay.TabIndex = 0
        Me.btnPlay.Text = "Play"
        Me.btnPlay.UseVisualStyleBackColor = True
        '
        'btnStop
        '
        Me.btnStop.Enabled = False
        Me.btnStop.Font = New System.Drawing.Font("Stencil", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnStop.Location = New System.Drawing.Point(556, 247)
        Me.btnStop.Name = "btnStop"
        Me.btnStop.Size = New System.Drawing.Size(205, 72)
        Me.btnStop.TabIndex = 1
        Me.btnStop.Text = "Stop"
        Me.btnStop.UseVisualStyleBackColor = True
        '
        'txtN1
        '
        Me.txtN1.Enabled = False
        Me.txtN1.Font = New System.Drawing.Font("Showcard Gothic", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtN1.Location = New System.Drawing.Point(78, 167)
        Me.txtN1.Multiline = True
        Me.txtN1.Name = "txtN1"
        Me.txtN1.Size = New System.Drawing.Size(125, 144)
        Me.txtN1.TabIndex = 2
        Me.txtN1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtN3
        '
        Me.txtN3.Enabled = False
        Me.txtN3.Font = New System.Drawing.Font("Showcard Gothic", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtN3.Location = New System.Drawing.Point(388, 167)
        Me.txtN3.Multiline = True
        Me.txtN3.Name = "txtN3"
        Me.txtN3.Size = New System.Drawing.Size(125, 144)
        Me.txtN3.TabIndex = 3
        Me.txtN3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtN2
        '
        Me.txtN2.Enabled = False
        Me.txtN2.Font = New System.Drawing.Font("Showcard Gothic", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtN2.Location = New System.Drawing.Point(231, 167)
        Me.txtN2.Multiline = True
        Me.txtN2.Name = "txtN2"
        Me.txtN2.Size = New System.Drawing.Size(125, 144)
        Me.txtN2.TabIndex = 4
        Me.txtN2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Timer1
        '
        '
        'Timer2
        '
        '
        'Timer3
        '
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Stencil", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(288, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(265, 40)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Juego de Azar"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtN2)
        Me.Controls.Add(Me.txtN3)
        Me.Controls.Add(Me.txtN1)
        Me.Controls.Add(Me.btnStop)
        Me.Controls.Add(Me.btnPlay)
        Me.Name = "Form1"
        Me.Text = "Juego de Azar"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnPlay As Button
    Friend WithEvents btnStop As Button
    Friend WithEvents txtN1 As TextBox
    Friend WithEvents txtN3 As TextBox
    Friend WithEvents txtN2 As TextBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Timer2 As Timer
    Friend WithEvents Timer3 As Timer
    Friend WithEvents Label1 As Label
End Class
