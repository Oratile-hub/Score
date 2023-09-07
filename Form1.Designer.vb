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
        btnResults = New Button()
        txtScore = New TextBox()
        Label1 = New Label()
        SuspendLayout()
        ' 
        ' btnResults
        ' 
        btnResults.BackColor = Color.Coral
        btnResults.Location = New Point(452, 289)
        btnResults.Name = "btnResults"
        btnResults.Size = New Size(150, 87)
        btnResults.TabIndex = 0
        btnResults.Text = "Results"
        btnResults.UseVisualStyleBackColor = False
        ' 
        ' txtScore
        ' 
        txtScore.Location = New Point(452, 197)
        txtScore.Name = "txtScore"
        txtScore.Size = New Size(150, 31)
        txtScore.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(277, 197)
        Label1.Name = "Label1"
        Label1.Size = New Size(105, 25)
        Label1.TabIndex = 2
        Label1.Text = "Enter Marks"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Label1)
        Controls.Add(txtScore)
        Controls.Add(btnResults)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnResults As Button
    Friend WithEvents txtScore As TextBox
    Friend WithEvents Label1 As Label
End Class
