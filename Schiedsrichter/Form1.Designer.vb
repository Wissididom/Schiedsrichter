<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
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

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.PictureBox_red = New System.Windows.Forms.PictureBox()
        Me.PictureBox_yellow = New System.Windows.Forms.PictureBox()
        Me.Button_save_red = New System.Windows.Forms.Button()
        Me.Button_save_yellow = New System.Windows.Forms.Button()
        Me.SFD = New System.Windows.Forms.SaveFileDialog()
        Me.btn_hide = New System.Windows.Forms.Button()
        CType(Me.PictureBox_red, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox_yellow, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox_red
        '
        Me.PictureBox_red.BackColor = System.Drawing.Color.Red
        Me.PictureBox_red.Location = New System.Drawing.Point(13, 13)
        Me.PictureBox_red.Name = "PictureBox_red"
        Me.PictureBox_red.Size = New System.Drawing.Size(327, 472)
        Me.PictureBox_red.TabIndex = 0
        Me.PictureBox_red.TabStop = False
        '
        'PictureBox_yellow
        '
        Me.PictureBox_yellow.BackColor = System.Drawing.Color.Yellow
        Me.PictureBox_yellow.Location = New System.Drawing.Point(346, 13)
        Me.PictureBox_yellow.Name = "PictureBox_yellow"
        Me.PictureBox_yellow.Size = New System.Drawing.Size(327, 472)
        Me.PictureBox_yellow.TabIndex = 1
        Me.PictureBox_yellow.TabStop = False
        '
        'Button_save_red
        '
        Me.Button_save_red.Location = New System.Drawing.Point(12, 491)
        Me.Button_save_red.Name = "Button_save_red"
        Me.Button_save_red.Size = New System.Drawing.Size(75, 23)
        Me.Button_save_red.TabIndex = 2
        Me.Button_save_red.Text = "speichern"
        Me.Button_save_red.UseVisualStyleBackColor = True
        '
        'Button_save_yellow
        '
        Me.Button_save_yellow.Location = New System.Drawing.Point(597, 491)
        Me.Button_save_yellow.Name = "Button_save_yellow"
        Me.Button_save_yellow.Size = New System.Drawing.Size(75, 23)
        Me.Button_save_yellow.TabIndex = 3
        Me.Button_save_yellow.Text = "speichern"
        Me.Button_save_yellow.UseVisualStyleBackColor = True
        '
        'SFD
        '
        Me.SFD.FileName = "nichts gewählt"
        Me.SFD.Filter = resources.GetString("SFD.Filter")
        '
        'btn_hide
        '
        Me.btn_hide.Location = New System.Drawing.Point(305, 491)
        Me.btn_hide.Name = "btn_hide"
        Me.btn_hide.Size = New System.Drawing.Size(75, 23)
        Me.btn_hide.TabIndex = 4
        Me.btn_hide.Text = "ausblenden"
        Me.btn_hide.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(684, 525)
        Me.Controls.Add(Me.btn_hide)
        Me.Controls.Add(Me.Button_save_yellow)
        Me.Controls.Add(Me.Button_save_red)
        Me.Controls.Add(Me.PictureBox_yellow)
        Me.Controls.Add(Me.PictureBox_red)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Auswahl"
        CType(Me.PictureBox_red, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox_yellow, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PictureBox_red As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox_yellow As System.Windows.Forms.PictureBox
    Friend WithEvents Button_save_red As System.Windows.Forms.Button
    Friend WithEvents Button_save_yellow As System.Windows.Forms.Button
    Friend WithEvents SFD As System.Windows.Forms.SaveFileDialog
    Friend WithEvents btn_hide As System.Windows.Forms.Button

End Class
