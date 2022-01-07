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
        Me.lblName = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.txtMessage = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.txtAddVal1 = New System.Windows.Forms.TextBox()
        Me.btnAddValues = New System.Windows.Forms.Button()
        Me.txtAddVal2 = New System.Windows.Forms.TextBox()
        Me.lblAddEqual = New System.Windows.Forms.Label()
        Me.txtSumAnswer = New System.Windows.Forms.TextBox()
        Me.txtDivisionAnswer = New System.Windows.Forms.TextBox()
        Me.lblDivideEqual = New System.Windows.Forms.Label()
        Me.txtDivideVal2 = New System.Windows.Forms.TextBox()
        Me.btnDivideVals = New System.Windows.Forms.Button()
        Me.txtDivideVal1 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(12, 9)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(35, 13)
        Me.lblName.TabIndex = 0
        Me.lblName.Text = "Name"
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(53, 2)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(208, 20)
        Me.txtName.TabIndex = 1
        '
        'btnOK
        '
        Me.btnOK.Location = New System.Drawing.Point(15, 40)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(75, 23)
        Me.btnOK.TabIndex = 2
        Me.btnOK.Text = "&OK"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'txtMessage
        '
        Me.txtMessage.Location = New System.Drawing.Point(107, 40)
        Me.txtMessage.Name = "txtMessage"
        Me.txtMessage.Size = New System.Drawing.Size(75, 23)
        Me.txtMessage.TabIndex = 3
        Me.txtMessage.Text = "&Message"
        Me.txtMessage.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(197, 40)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 4
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'txtAddVal1
        '
        Me.txtAddVal1.Location = New System.Drawing.Point(15, 84)
        Me.txtAddVal1.Name = "txtAddVal1"
        Me.txtAddVal1.Size = New System.Drawing.Size(55, 20)
        Me.txtAddVal1.TabIndex = 5
        '
        'btnAddValues
        '
        Me.btnAddValues.Location = New System.Drawing.Point(77, 84)
        Me.btnAddValues.Name = "btnAddValues"
        Me.btnAddValues.Size = New System.Drawing.Size(20, 20)
        Me.btnAddValues.TabIndex = 6
        Me.btnAddValues.Text = "+"
        Me.btnAddValues.UseVisualStyleBackColor = True
        '
        'txtAddVal2
        '
        Me.txtAddVal2.Location = New System.Drawing.Point(104, 84)
        Me.txtAddVal2.Name = "txtAddVal2"
        Me.txtAddVal2.Size = New System.Drawing.Size(55, 20)
        Me.txtAddVal2.TabIndex = 7
        '
        'lblAddEqual
        '
        Me.lblAddEqual.AutoSize = True
        Me.lblAddEqual.Location = New System.Drawing.Point(165, 87)
        Me.lblAddEqual.Name = "lblAddEqual"
        Me.lblAddEqual.Size = New System.Drawing.Size(13, 13)
        Me.lblAddEqual.TabIndex = 8
        Me.lblAddEqual.Text = "="
        '
        'txtSumAnswer
        '
        Me.txtSumAnswer.Location = New System.Drawing.Point(184, 84)
        Me.txtSumAnswer.Name = "txtSumAnswer"
        Me.txtSumAnswer.Size = New System.Drawing.Size(55, 20)
        Me.txtSumAnswer.TabIndex = 9
        '
        'txtDivisionAnswer
        '
        Me.txtDivisionAnswer.Location = New System.Drawing.Point(184, 126)
        Me.txtDivisionAnswer.Name = "txtDivisionAnswer"
        Me.txtDivisionAnswer.Size = New System.Drawing.Size(55, 20)
        Me.txtDivisionAnswer.TabIndex = 14
        '
        'lblDivideEqual
        '
        Me.lblDivideEqual.AutoSize = True
        Me.lblDivideEqual.Location = New System.Drawing.Point(165, 129)
        Me.lblDivideEqual.Name = "lblDivideEqual"
        Me.lblDivideEqual.Size = New System.Drawing.Size(13, 13)
        Me.lblDivideEqual.TabIndex = 13
        Me.lblDivideEqual.Text = "="
        '
        'txtDivideVal2
        '
        Me.txtDivideVal2.Location = New System.Drawing.Point(104, 126)
        Me.txtDivideVal2.Name = "txtDivideVal2"
        Me.txtDivideVal2.Size = New System.Drawing.Size(55, 20)
        Me.txtDivideVal2.TabIndex = 12
        '
        'btnDivideVals
        '
        Me.btnDivideVals.Location = New System.Drawing.Point(77, 126)
        Me.btnDivideVals.Name = "btnDivideVals"
        Me.btnDivideVals.Size = New System.Drawing.Size(20, 20)
        Me.btnDivideVals.TabIndex = 11
        Me.btnDivideVals.Text = "/"
        Me.btnDivideVals.UseVisualStyleBackColor = True
        '
        'txtDivideVal1
        '
        Me.txtDivideVal1.Location = New System.Drawing.Point(15, 126)
        Me.txtDivideVal1.Name = "txtDivideVal1"
        Me.txtDivideVal1.Size = New System.Drawing.Size(55, 20)
        Me.txtDivideVal1.TabIndex = 10
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 333)
        Me.Controls.Add(Me.txtDivisionAnswer)
        Me.Controls.Add(Me.lblDivideEqual)
        Me.Controls.Add(Me.txtDivideVal2)
        Me.Controls.Add(Me.btnDivideVals)
        Me.Controls.Add(Me.txtDivideVal1)
        Me.Controls.Add(Me.txtSumAnswer)
        Me.Controls.Add(Me.lblAddEqual)
        Me.Controls.Add(Me.txtAddVal2)
        Me.Controls.Add(Me.btnAddValues)
        Me.Controls.Add(Me.txtAddVal1)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.txtMessage)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.lblName)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblName As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents btnOK As Button
    Friend WithEvents txtMessage As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents txtAddVal1 As TextBox
    Friend WithEvents btnAddValues As Button
    Friend WithEvents txtAddVal2 As TextBox
    Friend WithEvents lblAddEqual As Label
    Friend WithEvents txtSumAnswer As TextBox
    Friend WithEvents txtDivisionAnswer As TextBox
    Friend WithEvents lblDivideEqual As Label
    Friend WithEvents txtDivideVal2 As TextBox
    Friend WithEvents btnDivideVals As Button
    Friend WithEvents txtDivideVal1 As TextBox
End Class
