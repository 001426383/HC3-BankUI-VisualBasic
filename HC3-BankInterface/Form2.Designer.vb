<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.InsertCardButton = New System.Windows.Forms.Button()
        Me.AccountNum1 = New System.Windows.Forms.TextBox()
        Me.AccountNum2 = New System.Windows.Forms.TextBox()
        Me.AccountNum3 = New System.Windows.Forms.TextBox()
        Me.AccountNum4 = New System.Windows.Forms.TextBox()
        Me.AccountNum8 = New System.Windows.Forms.TextBox()
        Me.AccountNum7 = New System.Windows.Forms.TextBox()
        Me.AccountNum6 = New System.Windows.Forms.TextBox()
        Me.AccountNum5 = New System.Windows.Forms.TextBox()
        Me.AccountNum12 = New System.Windows.Forms.TextBox()
        Me.AccountNum11 = New System.Windows.Forms.TextBox()
        Me.AccountNum10 = New System.Windows.Forms.TextBox()
        Me.AccountNum9 = New System.Windows.Forms.TextBox()
        Me.AccountNum16 = New System.Windows.Forms.TextBox()
        Me.AccountNum15 = New System.Windows.Forms.TextBox()
        Me.AccountNum14 = New System.Windows.Forms.TextBox()
        Me.AccountNum13 = New System.Windows.Forms.TextBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("ITC Garamond Std Book", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1182, 175)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Bank of McMaster"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Image = Global.HC3_BankInterface.My.Resources.Resources.Bank_of_McMaster
        Me.PictureBox1.Location = New System.Drawing.Point(132, 19)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(81, 137)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 22.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(213, 356)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(786, 43)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "INSERT your registered McMaster Debit Card"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 22.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(256, 399)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(669, 43)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "or ENTER your account number below"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 22.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(536, 303)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(133, 43)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "Please"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 24.0!, System.Drawing.FontStyle.Bold)
        Me.Label5.Location = New System.Drawing.Point(325, 547)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(33, 46)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "-"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 24.0!, System.Drawing.FontStyle.Bold)
        Me.Label6.Location = New System.Drawing.Point(580, 547)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(33, 46)
        Me.Label6.TabIndex = 21
        Me.Label6.Text = "-"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial", 24.0!, System.Drawing.FontStyle.Bold)
        Me.Label7.Location = New System.Drawing.Point(836, 547)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(33, 46)
        Me.Label7.TabIndex = 26
        Me.Label7.Text = "-"
        '
        'InsertCardButton
        '
        Me.InsertCardButton.Font = New System.Drawing.Font("Arial", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InsertCardButton.Location = New System.Drawing.Point(982, 188)
        Me.InsertCardButton.Name = "InsertCardButton"
        Me.InsertCardButton.Size = New System.Drawing.Size(188, 66)
        Me.InsertCardButton.TabIndex = 17
        Me.InsertCardButton.TabStop = False
        Me.InsertCardButton.Text = "INSERT CARD"
        Me.InsertCardButton.UseVisualStyleBackColor = True
        '
        'AccountNum1
        '
        Me.AccountNum1.Font = New System.Drawing.Font("Arial", 24.0!, System.Drawing.FontStyle.Bold)
        Me.AccountNum1.Location = New System.Drawing.Point(125, 547)
        Me.AccountNum1.MaxLength = 1
        Me.AccountNum1.Name = "AccountNum1"
        Me.AccountNum1.Size = New System.Drawing.Size(40, 53)
        Me.AccountNum1.TabIndex = 27
        Me.AccountNum1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'AccountNum2
        '
        Me.AccountNum2.Font = New System.Drawing.Font("Arial", 24.0!, System.Drawing.FontStyle.Bold)
        Me.AccountNum2.Location = New System.Drawing.Point(171, 547)
        Me.AccountNum2.MaxLength = 1
        Me.AccountNum2.Name = "AccountNum2"
        Me.AccountNum2.Size = New System.Drawing.Size(40, 53)
        Me.AccountNum2.TabIndex = 28
        Me.AccountNum2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'AccountNum3
        '
        Me.AccountNum3.Font = New System.Drawing.Font("Arial", 24.0!, System.Drawing.FontStyle.Bold)
        Me.AccountNum3.Location = New System.Drawing.Point(217, 547)
        Me.AccountNum3.MaxLength = 1
        Me.AccountNum3.Name = "AccountNum3"
        Me.AccountNum3.Size = New System.Drawing.Size(40, 53)
        Me.AccountNum3.TabIndex = 29
        Me.AccountNum3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'AccountNum4
        '
        Me.AccountNum4.Font = New System.Drawing.Font("Arial", 24.0!, System.Drawing.FontStyle.Bold)
        Me.AccountNum4.Location = New System.Drawing.Point(263, 547)
        Me.AccountNum4.MaxLength = 1
        Me.AccountNum4.Name = "AccountNum4"
        Me.AccountNum4.Size = New System.Drawing.Size(40, 53)
        Me.AccountNum4.TabIndex = 30
        Me.AccountNum4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'AccountNum8
        '
        Me.AccountNum8.Font = New System.Drawing.Font("Arial", 24.0!, System.Drawing.FontStyle.Bold)
        Me.AccountNum8.Location = New System.Drawing.Point(517, 547)
        Me.AccountNum8.MaxLength = 1
        Me.AccountNum8.Name = "AccountNum8"
        Me.AccountNum8.Size = New System.Drawing.Size(40, 53)
        Me.AccountNum8.TabIndex = 34
        Me.AccountNum8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'AccountNum7
        '
        Me.AccountNum7.Font = New System.Drawing.Font("Arial", 24.0!, System.Drawing.FontStyle.Bold)
        Me.AccountNum7.Location = New System.Drawing.Point(471, 547)
        Me.AccountNum7.MaxLength = 1
        Me.AccountNum7.Name = "AccountNum7"
        Me.AccountNum7.Size = New System.Drawing.Size(40, 53)
        Me.AccountNum7.TabIndex = 33
        Me.AccountNum7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'AccountNum6
        '
        Me.AccountNum6.Font = New System.Drawing.Font("Arial", 24.0!, System.Drawing.FontStyle.Bold)
        Me.AccountNum6.Location = New System.Drawing.Point(425, 547)
        Me.AccountNum6.MaxLength = 1
        Me.AccountNum6.Name = "AccountNum6"
        Me.AccountNum6.Size = New System.Drawing.Size(40, 53)
        Me.AccountNum6.TabIndex = 32
        Me.AccountNum6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'AccountNum5
        '
        Me.AccountNum5.Font = New System.Drawing.Font("Arial", 24.0!, System.Drawing.FontStyle.Bold)
        Me.AccountNum5.Location = New System.Drawing.Point(379, 547)
        Me.AccountNum5.MaxLength = 1
        Me.AccountNum5.Name = "AccountNum5"
        Me.AccountNum5.Size = New System.Drawing.Size(40, 53)
        Me.AccountNum5.TabIndex = 31
        Me.AccountNum5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'AccountNum12
        '
        Me.AccountNum12.Font = New System.Drawing.Font("Arial", 24.0!, System.Drawing.FontStyle.Bold)
        Me.AccountNum12.Location = New System.Drawing.Point(773, 547)
        Me.AccountNum12.MaxLength = 1
        Me.AccountNum12.Name = "AccountNum12"
        Me.AccountNum12.Size = New System.Drawing.Size(40, 53)
        Me.AccountNum12.TabIndex = 38
        Me.AccountNum12.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'AccountNum11
        '
        Me.AccountNum11.Font = New System.Drawing.Font("Arial", 24.0!, System.Drawing.FontStyle.Bold)
        Me.AccountNum11.Location = New System.Drawing.Point(727, 547)
        Me.AccountNum11.MaxLength = 1
        Me.AccountNum11.Name = "AccountNum11"
        Me.AccountNum11.Size = New System.Drawing.Size(40, 53)
        Me.AccountNum11.TabIndex = 37
        Me.AccountNum11.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'AccountNum10
        '
        Me.AccountNum10.Font = New System.Drawing.Font("Arial", 24.0!, System.Drawing.FontStyle.Bold)
        Me.AccountNum10.Location = New System.Drawing.Point(681, 547)
        Me.AccountNum10.MaxLength = 1
        Me.AccountNum10.Name = "AccountNum10"
        Me.AccountNum10.Size = New System.Drawing.Size(40, 53)
        Me.AccountNum10.TabIndex = 36
        Me.AccountNum10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'AccountNum9
        '
        Me.AccountNum9.Font = New System.Drawing.Font("Arial", 24.0!, System.Drawing.FontStyle.Bold)
        Me.AccountNum9.Location = New System.Drawing.Point(635, 547)
        Me.AccountNum9.MaxLength = 1
        Me.AccountNum9.Name = "AccountNum9"
        Me.AccountNum9.Size = New System.Drawing.Size(40, 53)
        Me.AccountNum9.TabIndex = 35
        Me.AccountNum9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'AccountNum16
        '
        Me.AccountNum16.Font = New System.Drawing.Font("Arial", 24.0!, System.Drawing.FontStyle.Bold)
        Me.AccountNum16.Location = New System.Drawing.Point(1029, 547)
        Me.AccountNum16.MaxLength = 1
        Me.AccountNum16.Name = "AccountNum16"
        Me.AccountNum16.Size = New System.Drawing.Size(40, 53)
        Me.AccountNum16.TabIndex = 42
        Me.AccountNum16.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'AccountNum15
        '
        Me.AccountNum15.Font = New System.Drawing.Font("Arial", 24.0!, System.Drawing.FontStyle.Bold)
        Me.AccountNum15.Location = New System.Drawing.Point(983, 547)
        Me.AccountNum15.MaxLength = 1
        Me.AccountNum15.Name = "AccountNum15"
        Me.AccountNum15.Size = New System.Drawing.Size(40, 53)
        Me.AccountNum15.TabIndex = 41
        Me.AccountNum15.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'AccountNum14
        '
        Me.AccountNum14.Font = New System.Drawing.Font("Arial", 24.0!, System.Drawing.FontStyle.Bold)
        Me.AccountNum14.Location = New System.Drawing.Point(937, 547)
        Me.AccountNum14.MaxLength = 1
        Me.AccountNum14.Name = "AccountNum14"
        Me.AccountNum14.Size = New System.Drawing.Size(40, 53)
        Me.AccountNum14.TabIndex = 40
        Me.AccountNum14.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'AccountNum13
        '
        Me.AccountNum13.Font = New System.Drawing.Font("Arial", 24.0!, System.Drawing.FontStyle.Bold)
        Me.AccountNum13.Location = New System.Drawing.Point(891, 547)
        Me.AccountNum13.MaxLength = 1
        Me.AccountNum13.Name = "AccountNum13"
        Me.AccountNum13.Size = New System.Drawing.Size(40, 53)
        Me.AccountNum13.TabIndex = 39
        Me.AccountNum13.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(120.0!, 120.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(1182, 853)
        Me.Controls.Add(Me.AccountNum16)
        Me.Controls.Add(Me.AccountNum15)
        Me.Controls.Add(Me.AccountNum14)
        Me.Controls.Add(Me.AccountNum13)
        Me.Controls.Add(Me.AccountNum12)
        Me.Controls.Add(Me.AccountNum11)
        Me.Controls.Add(Me.AccountNum10)
        Me.Controls.Add(Me.AccountNum9)
        Me.Controls.Add(Me.AccountNum8)
        Me.Controls.Add(Me.AccountNum7)
        Me.Controls.Add(Me.AccountNum6)
        Me.Controls.Add(Me.AccountNum5)
        Me.Controls.Add(Me.AccountNum4)
        Me.Controls.Add(Me.AccountNum3)
        Me.Controls.Add(Me.AccountNum2)
        Me.Controls.Add(Me.AccountNum1)
        Me.Controls.Add(Me.InsertCardButton)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "Form2"
        Me.RightToLeftLayout = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Bank of McMaster ATM"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents InsertCardButton As Button
    Friend WithEvents AccountNum1 As TextBox
    Friend WithEvents AccountNum2 As TextBox
    Friend WithEvents AccountNum3 As TextBox
    Friend WithEvents AccountNum4 As TextBox
    Friend WithEvents AccountNum8 As TextBox
    Friend WithEvents AccountNum7 As TextBox
    Friend WithEvents AccountNum6 As TextBox
    Friend WithEvents AccountNum5 As TextBox
    Friend WithEvents AccountNum12 As TextBox
    Friend WithEvents AccountNum11 As TextBox
    Friend WithEvents AccountNum10 As TextBox
    Friend WithEvents AccountNum9 As TextBox
    Friend WithEvents AccountNum16 As TextBox
    Friend WithEvents AccountNum15 As TextBox
    Friend WithEvents AccountNum14 As TextBox
    Friend WithEvents AccountNum13 As TextBox
End Class
