<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Main
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        Me.Play = New System.Windows.Forms.Button()
        Me.Options = New System.Windows.Forms.Button()
        Me.About = New System.Windows.Forms.Button()
        Me.Quit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Play
        '
        Me.Play.Font = New System.Drawing.Font("Bahnschrift", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Play.Location = New System.Drawing.Point(310, 246)
        Me.Play.Name = "Play"
        Me.Play.Size = New System.Drawing.Size(124, 53)
        Me.Play.TabIndex = 0
        Me.Play.Text = "Play"
        Me.Play.UseVisualStyleBackColor = True
        '
        'Options
        '
        Me.Options.Font = New System.Drawing.Font("Bahnschrift", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Options.Location = New System.Drawing.Point(151, 346)
        Me.Options.Name = "Options"
        Me.Options.Size = New System.Drawing.Size(124, 53)
        Me.Options.TabIndex = 1
        Me.Options.Text = "Options"
        Me.Options.UseVisualStyleBackColor = True
        '
        'About
        '
        Me.About.Font = New System.Drawing.Font("Bahnschrift", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.About.Location = New System.Drawing.Point(310, 346)
        Me.About.Name = "About"
        Me.About.Size = New System.Drawing.Size(124, 53)
        Me.About.TabIndex = 2
        Me.About.Text = "About"
        Me.About.UseVisualStyleBackColor = True
        '
        'Quit
        '
        Me.Quit.Font = New System.Drawing.Font("Bahnschrift", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Quit.Location = New System.Drawing.Point(471, 346)
        Me.Quit.Name = "Quit"
        Me.Quit.Size = New System.Drawing.Size(124, 53)
        Me.Quit.TabIndex = 3
        Me.Quit.Text = "Quit"
        Me.Quit.UseVisualStyleBackColor = True
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(741, 434)
        Me.Controls.Add(Me.Quit)
        Me.Controls.Add(Me.About)
        Me.Controls.Add(Me.Options)
        Me.Controls.Add(Me.Play)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.Name = "Main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Play As Button
    Friend WithEvents Options As Button
    Friend WithEvents About As Button
    Friend WithEvents Quit As Button
End Class
