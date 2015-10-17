<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Matriks
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
        Me.LABEL_MATRIK1 = New System.Windows.Forms.Label()
        Me.TEKSBOX_MATRIK1 = New System.Windows.Forms.TextBox()
        Me.LABEL_OPERASI = New System.Windows.Forms.Label()
        Me.COMBO_OPERASI = New System.Windows.Forms.ComboBox()
        Me.LABEL_MATRIK2 = New System.Windows.Forms.Label()
        Me.TEKSBOX_MATRIK2 = New System.Windows.Forms.TextBox()
        Me.Txb_hasil = New System.Windows.Forms.TextBox()
        Me.LABEL_HASIL = New System.Windows.Forms.Label()
        Me.BUTTON_PROSES = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'LABEL_MATRIK1
        '
        Me.LABEL_MATRIK1.AutoSize = True
        Me.LABEL_MATRIK1.Location = New System.Drawing.Point(13, 23)
        Me.LABEL_MATRIK1.Name = "LABEL_MATRIK1"
        Me.LABEL_MATRIK1.Size = New System.Drawing.Size(54, 13)
        Me.LABEL_MATRIK1.TabIndex = 0
        Me.LABEL_MATRIK1.Text = "MATRIK1"
        '
        'TEKSBOX_MATRIK1
        '
        Me.TEKSBOX_MATRIK1.Location = New System.Drawing.Point(61, 20)
        Me.TEKSBOX_MATRIK1.Multiline = True
        Me.TEKSBOX_MATRIK1.Name = "TEKSBOX_MATRIK1"
        Me.TEKSBOX_MATRIK1.Size = New System.Drawing.Size(368, 76)
        Me.TEKSBOX_MATRIK1.TabIndex = 1
        '
        'LABEL_OPERASI
        '
        Me.LABEL_OPERASI.AutoSize = True
        Me.LABEL_OPERASI.Location = New System.Drawing.Point(12, 121)
        Me.LABEL_OPERASI.Name = "LABEL_OPERASI"
        Me.LABEL_OPERASI.Size = New System.Drawing.Size(54, 13)
        Me.LABEL_OPERASI.TabIndex = 2
        Me.LABEL_OPERASI.Text = "OPERASI"
        '
        'COMBO_OPERASI
        '
        Me.COMBO_OPERASI.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.COMBO_OPERASI.FormattingEnabled = True
        Me.COMBO_OPERASI.Items.AddRange(New Object() {"Tambah", "Kurang"})
        Me.COMBO_OPERASI.Location = New System.Drawing.Point(61, 118)
        Me.COMBO_OPERASI.Name = "COMBO_OPERASI"
        Me.COMBO_OPERASI.Size = New System.Drawing.Size(368, 21)
        Me.COMBO_OPERASI.TabIndex = 3
        '
        'LABEL_MATRIK2
        '
        Me.LABEL_MATRIK2.AutoSize = True
        Me.LABEL_MATRIK2.Location = New System.Drawing.Point(12, 168)
        Me.LABEL_MATRIK2.Name = "LABEL_MATRIK2"
        Me.LABEL_MATRIK2.Size = New System.Drawing.Size(54, 13)
        Me.LABEL_MATRIK2.TabIndex = 4
        Me.LABEL_MATRIK2.Text = "MATRIK2"
        '
        'TEKSBOX_MATRIK2
        '
        Me.TEKSBOX_MATRIK2.Location = New System.Drawing.Point(61, 165)
        Me.TEKSBOX_MATRIK2.Multiline = True
        Me.TEKSBOX_MATRIK2.Name = "TEKSBOX_MATRIK2"
        Me.TEKSBOX_MATRIK2.Size = New System.Drawing.Size(368, 76)
        Me.TEKSBOX_MATRIK2.TabIndex = 5
        '
        'Txb_hasil
        '
        Me.Txb_hasil.Location = New System.Drawing.Point(61, 260)
        Me.Txb_hasil.Multiline = True
        Me.Txb_hasil.Name = "Txb_hasil"
        Me.Txb_hasil.Size = New System.Drawing.Size(368, 76)
        Me.Txb_hasil.TabIndex = 6
        '
        'LABEL_HASIL
        '
        Me.LABEL_HASIL.AutoSize = True
        Me.LABEL_HASIL.Location = New System.Drawing.Point(12, 263)
        Me.LABEL_HASIL.Name = "LABEL_HASIL"
        Me.LABEL_HASIL.Size = New System.Drawing.Size(38, 13)
        Me.LABEL_HASIL.TabIndex = 7
        Me.LABEL_HASIL.Text = "HASIL"
        '
        'BUTTON_PROSES
        '
        Me.BUTTON_PROSES.Location = New System.Drawing.Point(307, 351)
        Me.BUTTON_PROSES.Name = "BUTTON_PROSES"
        Me.BUTTON_PROSES.Size = New System.Drawing.Size(122, 23)
        Me.BUTTON_PROSES.TabIndex = 8
        Me.BUTTON_PROSES.Text = "PROSES"
        Me.BUTTON_PROSES.UseVisualStyleBackColor = True
        '
        'Matriks
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(441, 402)
        Me.Controls.Add(Me.BUTTON_PROSES)
        Me.Controls.Add(Me.LABEL_HASIL)
        Me.Controls.Add(Me.Txb_hasil)
        Me.Controls.Add(Me.TEKSBOX_MATRIK2)
        Me.Controls.Add(Me.LABEL_MATRIK2)
        Me.Controls.Add(Me.COMBO_OPERASI)
        Me.Controls.Add(Me.LABEL_OPERASI)
        Me.Controls.Add(Me.TEKSBOX_MATRIK1)
        Me.Controls.Add(Me.LABEL_MATRIK1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Matriks"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Matriks Kalkulator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LABEL_MATRIK1 As System.Windows.Forms.Label
    Friend WithEvents TEKSBOX_MATRIK1 As System.Windows.Forms.TextBox
    Friend WithEvents LABEL_OPERASI As System.Windows.Forms.Label
    Friend WithEvents COMBO_OPERASI As System.Windows.Forms.ComboBox
    Friend WithEvents LABEL_MATRIK2 As System.Windows.Forms.Label
    Friend WithEvents TEKSBOX_MATRIK2 As System.Windows.Forms.TextBox
    Friend WithEvents Txb_hasil As System.Windows.Forms.TextBox
    Friend WithEvents LABEL_HASIL As System.Windows.Forms.Label
    Friend WithEvents BUTTON_PROSES As System.Windows.Forms.Button
End Class
