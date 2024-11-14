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
        A = New Label()
        Label2 = New Label()
        txt_A = New TextBox()
        txt_B = New TextBox()
        btn_plus = New Button()
        btn_Div = New Button()
        btn_mult = New Button()
        btn_minus = New Button()
        btn_reset = New Button()
        btn_equal = New Button()
        lbl_res = New Label()
        Label3 = New Label()
        SuspendLayout()
        ' 
        ' A
        ' 
        A.AutoSize = True
        A.BackColor = Color.FromArgb(CByte(255), CByte(192), CByte(192))
        A.BorderStyle = BorderStyle.Fixed3D
        A.Font = New Font("Cooper Black", 13.8F)
        A.Location = New Point(87, 61)
        A.Name = "A"
        A.Size = New Size(33, 28)
        A.TabIndex = 0
        A.Text = "A"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.FromArgb(CByte(255), CByte(192), CByte(192))
        Label2.BorderStyle = BorderStyle.Fixed3D
        Label2.Font = New Font("Cooper Black", 13.8F)
        Label2.Location = New Point(87, 107)
        Label2.Name = "Label2"
        Label2.Size = New Size(30, 28)
        Label2.TabIndex = 1
        Label2.Text = "B"
        ' 
        ' txt_A
        ' 
        txt_A.Location = New Point(218, 54)
        txt_A.Name = "txt_A"
        txt_A.Size = New Size(125, 27)
        txt_A.TabIndex = 2
        ' 
        ' txt_B
        ' 
        txt_B.Location = New Point(218, 107)
        txt_B.Name = "txt_B"
        txt_B.Size = New Size(125, 27)
        txt_B.TabIndex = 3
        ' 
        ' btn_plus
        ' 
        btn_plus.BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(128))
        btn_plus.Font = New Font("Showcard Gothic", 9F)
        btn_plus.Location = New Point(194, 166)
        btn_plus.Name = "btn_plus"
        btn_plus.Size = New Size(60, 59)
        btn_plus.TabIndex = 5
        btn_plus.Text = "+"
        btn_plus.UseVisualStyleBackColor = False
        ' 
        ' btn_Div
        ' 
        btn_Div.BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(128))
        btn_Div.Font = New Font("Showcard Gothic", 9F)
        btn_Div.Location = New Point(466, 166)
        btn_Div.Name = "btn_Div"
        btn_Div.Size = New Size(61, 59)
        btn_Div.TabIndex = 6
        btn_Div.Text = "/"
        btn_Div.UseVisualStyleBackColor = False
        ' 
        ' btn_mult
        ' 
        btn_mult.BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(128))
        btn_mult.Font = New Font("Showcard Gothic", 9F)
        btn_mult.Location = New Point(373, 166)
        btn_mult.Name = "btn_mult"
        btn_mult.Size = New Size(64, 59)
        btn_mult.TabIndex = 7
        btn_mult.Text = "*"
        btn_mult.UseVisualStyleBackColor = False
        ' 
        ' btn_minus
        ' 
        btn_minus.BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(128))
        btn_minus.Font = New Font("Showcard Gothic", 9F)
        btn_minus.Location = New Point(282, 166)
        btn_minus.Name = "btn_minus"
        btn_minus.Size = New Size(61, 59)
        btn_minus.TabIndex = 8
        btn_minus.Text = "-"
        btn_minus.UseVisualStyleBackColor = False
        ' 
        ' btn_reset
        ' 
        btn_reset.BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(128))
        btn_reset.Font = New Font("Cooper Black", 13.8F)
        btn_reset.Location = New Point(282, 231)
        btn_reset.Name = "btn_reset"
        btn_reset.Size = New Size(245, 53)
        btn_reset.TabIndex = 9
        btn_reset.Text = "Reset"
        btn_reset.UseVisualStyleBackColor = False
        ' 
        ' btn_equal
        ' 
        btn_equal.BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(128))
        btn_equal.Font = New Font("Showcard Gothic", 9F)
        btn_equal.Location = New Point(194, 231)
        btn_equal.Name = "btn_equal"
        btn_equal.Size = New Size(60, 53)
        btn_equal.TabIndex = 10
        btn_equal.Text = "="
        btn_equal.UseVisualStyleBackColor = False
        ' 
        ' lbl_res
        ' 
        lbl_res.AutoSize = True
        lbl_res.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lbl_res.Location = New Point(343, 311)
        lbl_res.Name = "lbl_res"
        lbl_res.Size = New Size(0, 28)
        lbl_res.TabIndex = 11
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.FromArgb(CByte(255), CByte(192), CByte(192))
        Label3.BorderStyle = BorderStyle.Fixed3D
        Label3.Font = New Font("Cooper Black", 13.8F)
        Label3.Location = New Point(194, 311)
        Label3.Name = "Label3"
        Label3.Size = New Size(114, 28)
        Label3.TabIndex = 12
        Label3.Text = "Resultat"
        ' 
        ' frmCalculatrice
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Label3)
        Controls.Add(lbl_res)
        Controls.Add(btn_equal)
        Controls.Add(btn_reset)
        Controls.Add(btn_minus)
        Controls.Add(btn_mult)
        Controls.Add(btn_Div)
        Controls.Add(btn_plus)
        Controls.Add(txt_B)
        Controls.Add(txt_A)
        Controls.Add(Label2)
        Controls.Add(A)
        Name = "frmCalculatrice"
        Text = "calculatrice"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents A As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_A As TextBox
    Friend WithEvents txt_B As TextBox
    Friend WithEvents btn_plus As Button
    Friend WithEvents btn_Div As Button
    Friend WithEvents btn_mult As Button
    Friend WithEvents btn_minus As Button
    Friend WithEvents btn_reset As Button
    Friend WithEvents btn_equal As Button
    Friend WithEvents lbl_res As Label
    Friend WithEvents Label3 As Label

End Class
