<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmRegister1
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
        Me.components = New System.ComponentModel.Container()
        Me.txtFirstName = New System.Windows.Forms.TextBox()
        Me.txtbLastName = New System.Windows.Forms.TextBox()
        Me.txtUser = New System.Windows.Forms.TextBox()
        Me.lblRegister = New System.Windows.Forms.Label()
        Me.lblFirstName = New System.Windows.Forms.Label()
        Me.lblLastName = New System.Windows.Forms.Label()
        Me.lblUserName = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.txtPass = New System.Windows.Forms.TextBox()
        Me.lblConfirmPass = New System.Windows.Forms.Label()
        Me.txtConfirmPass = New System.Windows.Forms.TextBox()
        Me.lblBirthday = New System.Windows.Forms.Label()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.dtpBirthday = New System.Windows.Forms.DateTimePicker()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.lblGender = New System.Windows.Forms.Label()
        Me.ToolTipNext = New System.Windows.Forms.ToolTip(Me.components)
        Me.btnClose = New System.Windows.Forms.Button()
        Me.cmbGender = New System.Windows.Forms.ComboBox()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtFirstName
        '
        Me.txtFirstName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.txtFirstName.Location = New System.Drawing.Point(173, 154)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(200, 26)
        Me.txtFirstName.TabIndex = 1
        '
        'txtbLastName
        '
        Me.txtbLastName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.txtbLastName.Location = New System.Drawing.Point(173, 189)
        Me.txtbLastName.Name = "txtbLastName"
        Me.txtbLastName.Size = New System.Drawing.Size(200, 26)
        Me.txtbLastName.TabIndex = 2
        '
        'txtUser
        '
        Me.txtUser.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.txtUser.Location = New System.Drawing.Point(551, 189)
        Me.txtUser.Name = "txtUser"
        Me.txtUser.Size = New System.Drawing.Size(203, 26)
        Me.txtUser.TabIndex = 3
        '
        'lblRegister
        '
        Me.lblRegister.AutoSize = True
        Me.lblRegister.Font = New System.Drawing.Font("Cambria", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRegister.ForeColor = System.Drawing.Color.Black
        Me.lblRegister.Location = New System.Drawing.Point(343, 91)
        Me.lblRegister.Name = "lblRegister"
        Me.lblRegister.Size = New System.Drawing.Size(105, 28)
        Me.lblRegister.TabIndex = 4
        Me.lblRegister.Text = "Register"
        '
        'lblFirstName
        '
        Me.lblFirstName.AutoSize = True
        Me.lblFirstName.Font = New System.Drawing.Font("Cambria", 10.0!)
        Me.lblFirstName.ForeColor = System.Drawing.Color.Black
        Me.lblFirstName.Location = New System.Drawing.Point(54, 157)
        Me.lblFirstName.Name = "lblFirstName"
        Me.lblFirstName.Size = New System.Drawing.Size(89, 16)
        Me.lblFirstName.TabIndex = 5
        Me.lblFirstName.Text = "FIRST NAME:"
        '
        'lblLastName
        '
        Me.lblLastName.AutoSize = True
        Me.lblLastName.Font = New System.Drawing.Font("Cambria", 10.0!)
        Me.lblLastName.ForeColor = System.Drawing.Color.Black
        Me.lblLastName.Location = New System.Drawing.Point(54, 196)
        Me.lblLastName.Name = "lblLastName"
        Me.lblLastName.Size = New System.Drawing.Size(84, 16)
        Me.lblLastName.TabIndex = 6
        Me.lblLastName.Text = "LAST NAME:"
        '
        'lblUserName
        '
        Me.lblUserName.AutoSize = True
        Me.lblUserName.Font = New System.Drawing.Font("Cambria", 10.0!)
        Me.lblUserName.ForeColor = System.Drawing.Color.Black
        Me.lblUserName.Location = New System.Drawing.Point(402, 196)
        Me.lblUserName.Name = "lblUserName"
        Me.lblUserName.Size = New System.Drawing.Size(82, 16)
        Me.lblUserName.TabIndex = 7
        Me.lblUserName.Text = "USERNAME:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Cambria", 10.0!)
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(402, 157)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(113, 16)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "EMAIL ADDRESS:"
        '
        'txtEmail
        '
        Me.txtEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.txtEmail.Location = New System.Drawing.Point(551, 157)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(203, 26)
        Me.txtEmail.TabIndex = 8
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.Font = New System.Drawing.Font("Cambria", 10.0!)
        Me.lblPassword.ForeColor = System.Drawing.Color.Black
        Me.lblPassword.Location = New System.Drawing.Point(403, 234)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(81, 16)
        Me.lblPassword.TabIndex = 13
        Me.lblPassword.Text = "PASSWORD:"
        '
        'txtPass
        '
        Me.txtPass.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.txtPass.Location = New System.Drawing.Point(551, 227)
        Me.txtPass.Name = "txtPass"
        Me.txtPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPass.Size = New System.Drawing.Size(203, 26)
        Me.txtPass.TabIndex = 12
        '
        'lblConfirmPass
        '
        Me.lblConfirmPass.AutoSize = True
        Me.lblConfirmPass.Font = New System.Drawing.Font("Cambria", 10.0!)
        Me.lblConfirmPass.ForeColor = System.Drawing.Color.Black
        Me.lblConfirmPass.Location = New System.Drawing.Point(401, 275)
        Me.lblConfirmPass.Name = "lblConfirmPass"
        Me.lblConfirmPass.Size = New System.Drawing.Size(144, 16)
        Me.lblConfirmPass.TabIndex = 11
        Me.lblConfirmPass.Text = "CONFIRM PASSWORD:"
        '
        'txtConfirmPass
        '
        Me.txtConfirmPass.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.txtConfirmPass.Location = New System.Drawing.Point(551, 268)
        Me.txtConfirmPass.Name = "txtConfirmPass"
        Me.txtConfirmPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtConfirmPass.Size = New System.Drawing.Size(203, 26)
        Me.txtConfirmPass.TabIndex = 10
        '
        'lblBirthday
        '
        Me.lblBirthday.AutoSize = True
        Me.lblBirthday.Font = New System.Drawing.Font("Cambria", 10.0!)
        Me.lblBirthday.ForeColor = System.Drawing.Color.Black
        Me.lblBirthday.Location = New System.Drawing.Point(54, 268)
        Me.lblBirthday.Name = "lblBirthday"
        Me.lblBirthday.Size = New System.Drawing.Size(76, 16)
        Me.lblBirthday.TabIndex = 15
        Me.lblBirthday.Text = "BIRTHDAY:"
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.btnClear.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.ForeColor = System.Drawing.Color.Black
        Me.btnClear.Location = New System.Drawing.Point(551, 341)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(97, 29)
        Me.btnClear.TabIndex = 16
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(209, Byte), Integer))
        Me.Panel1.Controls.Add(Me.btnClose)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(798, 73)
        Me.Panel1.TabIndex = 18
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(209, Byte), Integer))
        Me.Panel2.Location = New System.Drawing.Point(0, 391)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(798, 58)
        Me.Panel2.TabIndex = 19
        '
        'dtpBirthday
        '
        Me.dtpBirthday.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.dtpBirthday.Font = New System.Drawing.Font("Cambria", 10.0!)
        Me.dtpBirthday.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpBirthday.Location = New System.Drawing.Point(173, 268)
        Me.dtpBirthday.Name = "dtpBirthday"
        Me.dtpBirthday.Size = New System.Drawing.Size(200, 23)
        Me.dtpBirthday.TabIndex = 20
        '
        'btnNext
        '
        Me.btnNext.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.btnNext.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNext.ForeColor = System.Drawing.Color.Black
        Me.btnNext.Location = New System.Drawing.Point(657, 341)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(97, 29)
        Me.btnNext.TabIndex = 21
        Me.btnNext.Text = "Next"
        Me.ToolTipNext.SetToolTip(Me.btnNext, "Proceed to Salary Information")
        Me.btnNext.UseVisualStyleBackColor = False
        '
        'lblGender
        '
        Me.lblGender.AutoSize = True
        Me.lblGender.Font = New System.Drawing.Font("Cambria", 10.0!)
        Me.lblGender.ForeColor = System.Drawing.Color.Black
        Me.lblGender.Location = New System.Drawing.Point(54, 234)
        Me.lblGender.Name = "lblGender"
        Me.lblGender.Size = New System.Drawing.Size(64, 16)
        Me.lblGender.TabIndex = 22
        Me.lblGender.Text = "GENDER:"
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnClose.Font = New System.Drawing.Font("Cambria", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ForeColor = System.Drawing.Color.Black
        Me.btnClose.Location = New System.Drawing.Point(715, 23)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(39, 25)
        Me.btnClose.TabIndex = 23
        Me.btnClose.Text = "X"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'cmbGender
        '
        Me.cmbGender.FormattingEnabled = True
        Me.cmbGender.Items.AddRange(New Object() {"Male", "Female", "Non-Binary", "Prefer not to Say"})
        Me.cmbGender.Location = New System.Drawing.Point(173, 232)
        Me.cmbGender.Name = "cmbGender"
        Me.cmbGender.Size = New System.Drawing.Size(200, 21)
        Me.cmbGender.TabIndex = 23
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.cmbGender)
        Me.Controls.Add(Me.lblGender)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.dtpBirthday)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.lblBirthday)
        Me.Controls.Add(Me.lblPassword)
        Me.Controls.Add(Me.txtPass)
        Me.Controls.Add(Me.lblConfirmPass)
        Me.Controls.Add(Me.txtConfirmPass)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.lblUserName)
        Me.Controls.Add(Me.lblLastName)
        Me.Controls.Add(Me.lblFirstName)
        Me.Controls.Add(Me.lblRegister)
        Me.Controls.Add(Me.txtUser)
        Me.Controls.Add(Me.txtbLastName)
        Me.Controls.Add(Me.txtFirstName)
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtFirstName As TextBox
    Friend WithEvents txtbLastName As TextBox
    Friend WithEvents txtUser As TextBox
    Friend WithEvents lblRegister As Label
    Friend WithEvents lblFirstName As Label
    Friend WithEvents lblLastName As Label
    Friend WithEvents lblUserName As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents lblPassword As Label
    Friend WithEvents txtPass As TextBox
    Friend WithEvents lblConfirmPass As Label
    Friend WithEvents txtConfirmPass As TextBox
    Friend WithEvents lblBirthday As Label
    Friend WithEvents btnClear As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents dtpBirthday As DateTimePicker
    Friend WithEvents btnNext As Button
    Friend WithEvents lblGender As Label
    Friend WithEvents ToolTipNext As ToolTip
    Friend WithEvents btnClose As Button
    Friend WithEvents cmbGender As ComboBox
End Class
