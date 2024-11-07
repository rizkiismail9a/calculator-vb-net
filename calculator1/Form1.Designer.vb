<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Calculator1
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
        firstNumLabel = New Label()
        secondNumLabel = New Label()
        firstInput = New TextBox()
        secondInput = New TextBox()
        addBtn = New Button()
        substractBtn = New Button()
        multipleBtn = New Button()
        divisionBtn = New Button()
        moduloBtn = New Button()
        Label1 = New Label()
        result = New TextBox()
        exitBtn = New Button()
        clearBtn = New Button()
        moreThanBtn = New Button()
        lessThanBtn = New Button()
        SuspendLayout()
        ' 
        ' firstNumLabel
        ' 
        firstNumLabel.AutoSize = True
        firstNumLabel.Location = New Point(82, 39)
        firstNumLabel.Name = "firstNumLabel"
        firstNumLabel.Size = New Size(289, 32)
        firstNumLabel.TabIndex = 0
        firstNumLabel.Text = "Masukkan Angka Pertama"
        ' 
        ' secondNumLabel
        ' 
        secondNumLabel.AutoSize = True
        secondNumLabel.Location = New Point(82, 110)
        secondNumLabel.Name = "secondNumLabel"
        secondNumLabel.Size = New Size(270, 32)
        secondNumLabel.TabIndex = 1
        secondNumLabel.Text = "Masukkan Angka Kedua"
        ' 
        ' firstInput
        ' 
        firstInput.Location = New Point(396, 36)
        firstInput.Name = "firstInput"
        firstInput.Size = New Size(302, 39)
        firstInput.TabIndex = 2
        ' 
        ' secondInput
        ' 
        secondInput.Location = New Point(396, 103)
        secondInput.Name = "secondInput"
        secondInput.Size = New Size(302, 39)
        secondInput.TabIndex = 3
        ' 
        ' addBtn
        ' 
        addBtn.Font = New Font("Segoe UI", 16F)
        addBtn.Location = New Point(82, 238)
        addBtn.Name = "addBtn"
        addBtn.Size = New Size(104, 73)
        addBtn.TabIndex = 4
        addBtn.Text = "+"
        addBtn.UseVisualStyleBackColor = True
        ' 
        ' substractBtn
        ' 
        substractBtn.Font = New Font("Segoe UI", 16F)
        substractBtn.Location = New Point(228, 238)
        substractBtn.Name = "substractBtn"
        substractBtn.Size = New Size(104, 73)
        substractBtn.TabIndex = 5
        substractBtn.Text = "-"
        substractBtn.UseVisualStyleBackColor = True
        ' 
        ' multipleBtn
        ' 
        multipleBtn.Font = New Font("Segoe UI", 16F)
        multipleBtn.Location = New Point(364, 238)
        multipleBtn.Name = "multipleBtn"
        multipleBtn.Size = New Size(104, 73)
        multipleBtn.TabIndex = 6
        multipleBtn.Text = "x"
        multipleBtn.UseVisualStyleBackColor = True
        ' 
        ' divisionBtn
        ' 
        divisionBtn.Font = New Font("Segoe UI", 16F)
        divisionBtn.Location = New Point(492, 238)
        divisionBtn.Name = "divisionBtn"
        divisionBtn.Size = New Size(104, 73)
        divisionBtn.TabIndex = 7
        divisionBtn.Text = "/"
        divisionBtn.UseVisualStyleBackColor = True
        ' 
        ' moduloBtn
        ' 
        moduloBtn.Font = New Font("Segoe UI", 16F)
        moduloBtn.Location = New Point(623, 238)
        moduloBtn.Name = "moduloBtn"
        moduloBtn.Size = New Size(104, 73)
        moduloBtn.TabIndex = 8
        moduloBtn.Text = "%"
        moduloBtn.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(82, 175)
        Label1.Name = "Label1"
        Label1.Size = New Size(65, 32)
        Label1.TabIndex = 9
        Label1.Text = "Hasil"
        ' 
        ' result
        ' 
        result.Location = New Point(396, 172)
        result.Name = "result"
        result.ReadOnly = True
        result.Size = New Size(302, 39)
        result.TabIndex = 10
        ' 
        ' exitBtn
        ' 
        exitBtn.Font = New Font("Segoe UI", 16F)
        exitBtn.Location = New Point(492, 331)
        exitBtn.Name = "exitBtn"
        exitBtn.RightToLeft = RightToLeft.No
        exitBtn.Size = New Size(235, 73)
        exitBtn.TabIndex = 14
        exitBtn.Text = "Exit"
        exitBtn.UseVisualStyleBackColor = True
        ' 
        ' clearBtn
        ' 
        clearBtn.Font = New Font("Segoe UI", 16F)
        clearBtn.Location = New Point(364, 331)
        clearBtn.Name = "clearBtn"
        clearBtn.Size = New Size(104, 73)
        clearBtn.TabIndex = 13
        clearBtn.Text = "C"
        clearBtn.UseVisualStyleBackColor = True
        ' 
        ' moreThanBtn
        ' 
        moreThanBtn.Font = New Font("Segoe UI", 16F)
        moreThanBtn.Location = New Point(228, 331)
        moreThanBtn.Name = "moreThanBtn"
        moreThanBtn.Size = New Size(104, 73)
        moreThanBtn.TabIndex = 12
        moreThanBtn.Text = ">"
        moreThanBtn.UseVisualStyleBackColor = True
        ' 
        ' lessThanBtn
        ' 
        lessThanBtn.Font = New Font("Segoe UI", 16F)
        lessThanBtn.Location = New Point(82, 331)
        lessThanBtn.Name = "lessThanBtn"
        lessThanBtn.Size = New Size(104, 73)
        lessThanBtn.TabIndex = 11
        lessThanBtn.Text = "<"
        lessThanBtn.UseVisualStyleBackColor = True
        ' 
        ' Calculator1
        ' 
        AutoScaleDimensions = New SizeF(13F, 32F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(exitBtn)
        Controls.Add(clearBtn)
        Controls.Add(moreThanBtn)
        Controls.Add(lessThanBtn)
        Controls.Add(result)
        Controls.Add(Label1)
        Controls.Add(moduloBtn)
        Controls.Add(divisionBtn)
        Controls.Add(multipleBtn)
        Controls.Add(substractBtn)
        Controls.Add(addBtn)
        Controls.Add(secondInput)
        Controls.Add(firstInput)
        Controls.Add(secondNumLabel)
        Controls.Add(firstNumLabel)
        FormBorderStyle = FormBorderStyle.None
        Name = "Calculator1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Kalkulator Sederahana"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents firstNumLabel As Label
    Friend WithEvents secondNumLabel As Label
    Friend WithEvents firstInput As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents secondInput As TextBox
    Friend WithEvents addBtn As Button
    Friend WithEvents substractBtn As Button
    Friend WithEvents multipleBtn As Button
    Friend WithEvents divisionBtn As Button
    Friend WithEvents moduloBtn As Button
    Friend WithEvents result As TextBox
    Friend WithEvents exitBtn As Button
    Friend WithEvents clearBtn As Button
    Friend WithEvents moreThanBtn As Button
    Friend WithEvents lessThanBtn As Button

End Class
