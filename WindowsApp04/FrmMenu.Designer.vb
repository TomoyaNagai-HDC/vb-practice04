<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMenu
    Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
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

    'Windows フォーム デザイナーで必要です。
    Private components As System.ComponentModel.IContainer

    'メモ: 以下のプロシージャは Windows フォーム デザイナーで必要です。
    'Windows フォーム デザイナーを使用して変更できます。  
    'コード エディターを使って変更しないでください。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnProcA = New System.Windows.Forms.Button()
        Me.btnProcB = New System.Windows.Forms.Button()
        Me.btnProcC = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnProcA
        '
        Me.btnProcA.Location = New System.Drawing.Point(100, 87)
        Me.btnProcA.Name = "btnProcA"
        Me.btnProcA.Size = New System.Drawing.Size(244, 58)
        Me.btnProcA.TabIndex = 0
        Me.btnProcA.Text = "ProcA"
        Me.btnProcA.UseVisualStyleBackColor = True
        '
        'btnProcB
        '
        Me.btnProcB.Location = New System.Drawing.Point(97, 196)
        Me.btnProcB.Name = "btnProcB"
        Me.btnProcB.Size = New System.Drawing.Size(244, 58)
        Me.btnProcB.TabIndex = 1
        Me.btnProcB.Text = "ProcB"
        Me.btnProcB.UseVisualStyleBackColor = True
        '
        'btnProcC
        '
        Me.btnProcC.Location = New System.Drawing.Point(97, 316)
        Me.btnProcC.Name = "btnProcC"
        Me.btnProcC.Size = New System.Drawing.Size(244, 58)
        Me.btnProcC.TabIndex = 2
        Me.btnProcC.Text = "ProcC"
        Me.btnProcC.UseVisualStyleBackColor = True
        '
        'FrmMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(439, 450)
        Me.Controls.Add(Me.btnProcC)
        Me.Controls.Add(Me.btnProcB)
        Me.Controls.Add(Me.btnProcA)
        Me.Name = "FrmMenu"
        Me.Text = "メニュー画面"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnProcA As Button
    Friend WithEvents btnProcB As Button
    Friend WithEvents btnProcC As Button
End Class
