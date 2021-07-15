<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.lampuHijau = New System.Windows.Forms.PictureBox()
        Me.lampuKuning = New System.Windows.Forms.PictureBox()
        Me.lampuMerah = New System.Windows.Forms.PictureBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.bttnKeluar = New System.Windows.Forms.Button()
        CType(Me.lampuHijau, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lampuKuning, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lampuMerah, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lampuHijau
        '
        Me.lampuHijau.BackColor = System.Drawing.Color.Transparent
        Me.lampuHijau.BackgroundImage = CType(resources.GetObject("lampuHijau.BackgroundImage"), System.Drawing.Image)
        Me.lampuHijau.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.lampuHijau.Location = New System.Drawing.Point(180, 422)
        Me.lampuHijau.Name = "lampuHijau"
        Me.lampuHijau.Size = New System.Drawing.Size(146, 202)
        Me.lampuHijau.TabIndex = 0
        Me.lampuHijau.TabStop = False
        '
        'lampuKuning
        '
        Me.lampuKuning.BackColor = System.Drawing.Color.Transparent
        Me.lampuKuning.BackgroundImage = CType(resources.GetObject("lampuKuning.BackgroundImage"), System.Drawing.Image)
        Me.lampuKuning.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.lampuKuning.Location = New System.Drawing.Point(180, 246)
        Me.lampuKuning.Name = "lampuKuning"
        Me.lampuKuning.Size = New System.Drawing.Size(146, 206)
        Me.lampuKuning.TabIndex = 1
        Me.lampuKuning.TabStop = False
        '
        'lampuMerah
        '
        Me.lampuMerah.BackColor = System.Drawing.Color.Transparent
        Me.lampuMerah.BackgroundImage = CType(resources.GetObject("lampuMerah.BackgroundImage"), System.Drawing.Image)
        Me.lampuMerah.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.lampuMerah.Location = New System.Drawing.Point(181, 76)
        Me.lampuMerah.Name = "lampuMerah"
        Me.lampuMerah.Size = New System.Drawing.Size(146, 200)
        Me.lampuMerah.TabIndex = 2
        Me.lampuMerah.TabStop = False
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'bttnKeluar
        '
        Me.bttnKeluar.BackColor = System.Drawing.SystemColors.ControlLight
        Me.bttnKeluar.Location = New System.Drawing.Point(370, 651)
        Me.bttnKeluar.Name = "bttnKeluar"
        Me.bttnKeluar.Size = New System.Drawing.Size(118, 35)
        Me.bttnKeluar.TabIndex = 3
        Me.bttnKeluar.Text = "Keluar"
        Me.bttnKeluar.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(500, 698)
        Me.Controls.Add(Me.bttnKeluar)
        Me.Controls.Add(Me.lampuMerah)
        Me.Controls.Add(Me.lampuKuning)
        Me.Controls.Add(Me.lampuHijau)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.lampuHijau, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lampuKuning, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lampuMerah, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lampuHijau As PictureBox
    Friend WithEvents lampuKuning As PictureBox
    Friend WithEvents lampuMerah As PictureBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents bttnKeluar As Button
End Class
