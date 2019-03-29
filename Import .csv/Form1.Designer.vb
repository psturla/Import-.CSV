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
        Me.grdCsv = New System.Windows.Forms.DataGridView()
        Me.btnOpenFile = New System.Windows.Forms.Button()
        Me.txtFile = New System.Windows.Forms.TextBox()
        CType(Me.grdCsv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grdCsv
        '
        Me.grdCsv.AllowUserToAddRows = False
        Me.grdCsv.AllowUserToDeleteRows = False
        Me.grdCsv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdCsv.Location = New System.Drawing.Point(13, 54)
        Me.grdCsv.Name = "grdCsv"
        Me.grdCsv.ReadOnly = True
        Me.grdCsv.Size = New System.Drawing.Size(595, 395)
        Me.grdCsv.TabIndex = 0
        '
        'btnOpenFile
        '
        Me.btnOpenFile.Location = New System.Drawing.Point(13, 12)
        Me.btnOpenFile.Name = "btnOpenFile"
        Me.btnOpenFile.Size = New System.Drawing.Size(126, 36)
        Me.btnOpenFile.TabIndex = 1
        Me.btnOpenFile.Text = "Open .CSV"
        Me.btnOpenFile.UseVisualStyleBackColor = True
        '
        'txtFile
        '
        Me.txtFile.Location = New System.Drawing.Point(145, 12)
        Me.txtFile.Multiline = True
        Me.txtFile.Name = "txtFile"
        Me.txtFile.Size = New System.Drawing.Size(200, 36)
        Me.txtFile.TabIndex = 2
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(644, 486)
        Me.Controls.Add(Me.txtFile)
        Me.Controls.Add(Me.btnOpenFile)
        Me.Controls.Add(Me.grdCsv)
        Me.Name = "Form1"
        Me.Text = "Open .CSV"
        CType(Me.grdCsv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents grdCsv As DataGridView
    Friend WithEvents btnOpenFile As Button
    Friend WithEvents txtFile As TextBox
End Class
