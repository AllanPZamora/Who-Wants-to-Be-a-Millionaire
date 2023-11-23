<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Game
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
        Me.btnAnswer1 = New System.Windows.Forms.Button()
        Me.btnAnswer3 = New System.Windows.Forms.Button()
        Me.btnAnswer2 = New System.Windows.Forms.Button()
        Me.btnAnswer4 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.Label()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.Btn5050 = New System.Windows.Forms.Button()
        Me.BtnIns = New System.Windows.Forms.Button()
        Me.BtnSkip = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnAnswer1
        '
        Me.btnAnswer1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAnswer1.Location = New System.Drawing.Point(117, 323)
        Me.btnAnswer1.Name = "btnAnswer1"
        Me.btnAnswer1.Size = New System.Drawing.Size(270, 58)
        Me.btnAnswer1.TabIndex = 1
        Me.btnAnswer1.UseVisualStyleBackColor = True
        '
        'btnAnswer3
        '
        Me.btnAnswer3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAnswer3.Location = New System.Drawing.Point(117, 402)
        Me.btnAnswer3.Name = "btnAnswer3"
        Me.btnAnswer3.Size = New System.Drawing.Size(270, 58)
        Me.btnAnswer3.TabIndex = 2
        Me.btnAnswer3.UseVisualStyleBackColor = True
        '
        'btnAnswer2
        '
        Me.btnAnswer2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAnswer2.Location = New System.Drawing.Point(444, 323)
        Me.btnAnswer2.Name = "btnAnswer2"
        Me.btnAnswer2.Size = New System.Drawing.Size(270, 58)
        Me.btnAnswer2.TabIndex = 3
        Me.btnAnswer2.UseVisualStyleBackColor = True
        '
        'btnAnswer4
        '
        Me.btnAnswer4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAnswer4.Location = New System.Drawing.Point(444, 402)
        Me.btnAnswer4.Name = "btnAnswer4"
        Me.btnAnswer4.Size = New System.Drawing.Size(270, 58)
        Me.btnAnswer4.TabIndex = 4
        Me.btnAnswer4.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(117, 210)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(597, 94)
        Me.TextBox1.TabIndex = 5
        Me.TextBox1.Text = "Label1"
        Me.TextBox1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Items.AddRange(New Object() {"100", "99", "97", "96", "95", "94", "93", "92", "91", "90", "89", "88", "87", "86", "85", "84", "83", "82", "81", "80", "79", "78", "77", "76", "75"})
        Me.ListBox1.Location = New System.Drawing.Point(807, 165)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(120, 329)
        Me.ListBox1.TabIndex = 6
        '
        'Btn5050
        '
        Me.Btn5050.Location = New System.Drawing.Point(199, 517)
        Me.Btn5050.Name = "Btn5050"
        Me.Btn5050.Size = New System.Drawing.Size(103, 38)
        Me.Btn5050.TabIndex = 7
        Me.Btn5050.Text = "5050"
        Me.Btn5050.UseVisualStyleBackColor = True
        '
        'BtnIns
        '
        Me.BtnIns.Location = New System.Drawing.Point(327, 517)
        Me.BtnIns.Name = "BtnIns"
        Me.BtnIns.Size = New System.Drawing.Size(103, 38)
        Me.BtnIns.TabIndex = 8
        Me.BtnIns.Text = "Ask"
        Me.BtnIns.UseVisualStyleBackColor = True
        '
        'BtnSkip
        '
        Me.BtnSkip.Location = New System.Drawing.Point(458, 517)
        Me.BtnSkip.Name = "BtnSkip"
        Me.BtnSkip.Size = New System.Drawing.Size(103, 38)
        Me.BtnSkip.TabIndex = 9
        Me.BtnSkip.Text = "Skip"
        Me.BtnSkip.UseVisualStyleBackColor = True
        '
        'Game
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1071, 600)
        Me.Controls.Add(Me.BtnSkip)
        Me.Controls.Add(Me.BtnIns)
        Me.Controls.Add(Me.Btn5050)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.btnAnswer4)
        Me.Controls.Add(Me.btnAnswer2)
        Me.Controls.Add(Me.btnAnswer3)
        Me.Controls.Add(Me.btnAnswer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Game"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnAnswer1 As Button
    Friend WithEvents btnAnswer3 As Button
    Friend WithEvents btnAnswer2 As Button
    Friend WithEvents btnAnswer4 As Button
    Friend WithEvents TextBox1 As Label
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents Btn5050 As Button
    Friend WithEvents BtnIns As Button
    Friend WithEvents BtnSkip As Button
End Class
