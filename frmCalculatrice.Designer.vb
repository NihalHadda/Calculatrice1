<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmCalculatrice
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
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        label_Res = New Label()
        Txt_A = New TextBox()
        Txt_B = New TextBox()
        btn_plus = New Button()
        btn_div = New Button()
        btn_equal = New Button()
        btn_mult = New Button()
        btn_moins = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.Salmon
        Label1.Location = New Point(97, 53)
        Label1.Name = "Label1"
        Label1.Size = New Size(30, 31)
        Label1.TabIndex = 0
        Label1.Text = "A"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.Salmon
        Label2.Location = New Point(97, 340)
        Label2.Name = "Label2"
        Label2.Size = New Size(119, 31)
        Label2.TabIndex = 1
        Label2.Text = "RESULTAT"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.Salmon
        Label3.Location = New Point(97, 119)
        Label3.Name = "Label3"
        Label3.Size = New Size(29, 31)
        Label3.TabIndex = 2
        Label3.Text = "B"
        ' 
        ' label_Res
        ' 
        label_Res.AutoSize = True
        label_Res.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        label_Res.ForeColor = Color.Salmon
        label_Res.Location = New Point(253, 340)
        label_Res.Name = "label_Res"
        label_Res.Size = New Size(0, 31)
        label_Res.TabIndex = 3
        ' 
        ' Txt_A
        ' 
        Txt_A.Location = New Point(154, 61)
        Txt_A.Name = "Txt_A"
        Txt_A.Size = New Size(125, 27)
        Txt_A.TabIndex = 4
        ' 
        ' Txt_B
        ' 
        Txt_B.Location = New Point(154, 125)
        Txt_B.Name = "Txt_B"
        Txt_B.Size = New Size(125, 27)
        Txt_B.TabIndex = 5
        ' 
        ' btn_plus
        ' 
        btn_plus.BackColor = Color.Gray
        btn_plus.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btn_plus.Location = New Point(97, 188)
        btn_plus.Name = "btn_plus"
        btn_plus.Size = New Size(52, 47)
        btn_plus.TabIndex = 6
        btn_plus.Text = "+"
        btn_plus.UseVisualStyleBackColor = False
        ' 
        ' btn_div
        ' 
        btn_div.BackColor = Color.Gray
        btn_div.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btn_div.Location = New Point(332, 188)
        btn_div.Name = "btn_div"
        btn_div.Size = New Size(52, 47)
        btn_div.TabIndex = 7
        btn_div.Text = "/"
        btn_div.UseVisualStyleBackColor = False
        ' 
        ' btn_equal
        ' 
        btn_equal.BackColor = Color.Gray
        btn_equal.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btn_equal.Location = New Point(97, 258)
        btn_equal.Name = "btn_equal"
        btn_equal.Size = New Size(52, 47)
        btn_equal.TabIndex = 8
        btn_equal.Text = "="
        btn_equal.UseVisualStyleBackColor = False
        ' 
        ' btn_mult
        ' 
        btn_mult.BackColor = Color.Gray
        btn_mult.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btn_mult.Location = New Point(253, 188)
        btn_mult.Name = "btn_mult"
        btn_mult.Size = New Size(52, 47)
        btn_mult.TabIndex = 9
        btn_mult.Text = "*"
        btn_mult.UseVisualStyleBackColor = False
        ' 
        ' btn_moins
        ' 
        btn_moins.BackColor = Color.Gray
        btn_moins.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btn_moins.Location = New Point(177, 188)
        btn_moins.Name = "btn_moins"
        btn_moins.Size = New Size(52, 47)
        btn_moins.TabIndex = 10
        btn_moins.Text = "-"
        btn_moins.UseVisualStyleBackColor = False
        ' 
        ' frmCalculatrice
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btn_moins)
        Controls.Add(btn_mult)
        Controls.Add(btn_equal)
        Controls.Add(btn_div)
        Controls.Add(btn_plus)
        Controls.Add(Txt_B)
        Controls.Add(Txt_A)
        Controls.Add(label_Res)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "frmCalculatrice"
        Text = "Calculatrice"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents label_Res As Label
    Friend WithEvents Txt_A As TextBox
    Friend WithEvents Txt_B As TextBox
    Friend WithEvents btn_plus As Button
    Friend WithEvents btn_div As Button
    Friend WithEvents btn_equal As Button
    Friend WithEvents btn_mult As Button
    Friend WithEvents btn_moins As Button

End Class
