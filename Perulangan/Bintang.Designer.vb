<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Bintang
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
        Me.COMBO_POLA = New System.Windows.Forms.ComboBox()
        Me.TEKSBOX_HASIL = New System.Windows.Forms.TextBox()
        Me.BUTTON_PROSES = New System.Windows.Forms.Button()
        Me.TEKSBOX_BARIS = New System.Windows.Forms.TextBox()
        Me.LABEL_BARIS = New System.Windows.Forms.Label()
        Me.LABEL_POLA = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'COMBO_POLA
        '
        Me.COMBO_POLA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.COMBO_POLA.FormattingEnabled = True
        Me.COMBO_POLA.Items.AddRange(New Object() {"Pyramid", "Hollow Pyramid", "Inverted Pyramid", "Hollow Inverted Pyramid"})
        Me.COMBO_POLA.Location = New System.Drawing.Point(63, 11)
        Me.COMBO_POLA.Name = "COMBO_POLA"
        Me.COMBO_POLA.Size = New System.Drawing.Size(386, 21)
        Me.COMBO_POLA.TabIndex = 7
        '
        'TEKSBOX_HASIL
        '
        Me.TEKSBOX_HASIL.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TEKSBOX_HASIL.Location = New System.Drawing.Point(26, 108)
        Me.TEKSBOX_HASIL.Multiline = True
        Me.TEKSBOX_HASIL.Name = "TEKSBOX_HASIL"
        Me.TEKSBOX_HASIL.Size = New System.Drawing.Size(423, 305)
        Me.TEKSBOX_HASIL.TabIndex = 11
        '
        'BUTTON_PROSES
        '
        Me.BUTTON_PROSES.Location = New System.Drawing.Point(335, 60)
        Me.BUTTON_PROSES.Name = "BUTTON_PROSES"
        Me.BUTTON_PROSES.Size = New System.Drawing.Size(114, 23)
        Me.BUTTON_PROSES.TabIndex = 10
        Me.BUTTON_PROSES.Text = "Proses"
        Me.BUTTON_PROSES.UseVisualStyleBackColor = True
        '
        'TEKSBOX_BARIS
        '
        Me.TEKSBOX_BARIS.Location = New System.Drawing.Point(63, 62)
        Me.TEKSBOX_BARIS.Name = "TEKSBOX_BARIS"
        Me.TEKSBOX_BARIS.Size = New System.Drawing.Size(266, 20)
        Me.TEKSBOX_BARIS.TabIndex = 9
        '
        'LABEL_BARIS
        '
        Me.LABEL_BARIS.AutoSize = True
        Me.LABEL_BARIS.Location = New System.Drawing.Point(23, 65)
        Me.LABEL_BARIS.Name = "LABEL_BARIS"
        Me.LABEL_BARIS.Size = New System.Drawing.Size(39, 13)
        Me.LABEL_BARIS.TabIndex = 8
        Me.LABEL_BARIS.Text = "BARIS"
        '
        'LABEL_POLA
        '
        Me.LABEL_POLA.AutoSize = True
        Me.LABEL_POLA.Location = New System.Drawing.Point(23, 19)
        Me.LABEL_POLA.Name = "LABEL_POLA"
        Me.LABEL_POLA.Size = New System.Drawing.Size(35, 13)
        Me.LABEL_POLA.TabIndex = 6
        Me.LABEL_POLA.Text = "POLA"
        '
        'Bintang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(473, 425)
        Me.Controls.Add(Me.COMBO_POLA)
        Me.Controls.Add(Me.TEKSBOX_HASIL)
        Me.Controls.Add(Me.BUTTON_PROSES)
        Me.Controls.Add(Me.TEKSBOX_BARIS)
        Me.Controls.Add(Me.LABEL_BARIS)
        Me.Controls.Add(Me.LABEL_POLA)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Bintang"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Problem Bintang"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents COMBO_POLA As System.Windows.Forms.ComboBox
    Friend WithEvents TEKSBOX_HASIL As System.Windows.Forms.TextBox
    Friend WithEvents BUTTON_PROSES As System.Windows.Forms.Button
    Friend WithEvents TEKSBOX_BARIS As System.Windows.Forms.TextBox
    Friend WithEvents LABEL_BARIS As System.Windows.Forms.Label
    Friend WithEvents LABEL_POLA As System.Windows.Forms.Label
End Class
