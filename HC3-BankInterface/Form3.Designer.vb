<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PIN4 = New System.Windows.Forms.TextBox()
        Me.PIN3 = New System.Windows.Forms.TextBox()
        Me.PIN2 = New System.Windows.Forms.TextBox()
        Me.PIN1 = New System.Windows.Forms.TextBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
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
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Bank of McMaster"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 22.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(405, 389)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(414, 43)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "ENTER your PIN below"
        '
        'PIN4
        '
        Me.PIN4.Font = New System.Drawing.Font("Arial", 36.0!, System.Drawing.FontStyle.Bold)
        Me.PIN4.Location = New System.Drawing.Point(669, 473)
        Me.PIN4.MaxLength = 1
        Me.PIN4.Name = "PIN4"
        Me.PIN4.Size = New System.Drawing.Size(54, 76)
        Me.PIN4.TabIndex = 34
        Me.PIN4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.PIN4.UseSystemPasswordChar = True
        '
        'PIN3
        '
        Me.PIN3.Font = New System.Drawing.Font("Arial", 36.0!, System.Drawing.FontStyle.Bold)
        Me.PIN3.Location = New System.Drawing.Point(609, 473)
        Me.PIN3.MaxLength = 1
        Me.PIN3.Name = "PIN3"
        Me.PIN3.Size = New System.Drawing.Size(54, 76)
        Me.PIN3.TabIndex = 33
        Me.PIN3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.PIN3.UseSystemPasswordChar = True
        '
        'PIN2
        '
        Me.PIN2.Font = New System.Drawing.Font("Arial", 36.0!, System.Drawing.FontStyle.Bold)
        Me.PIN2.Location = New System.Drawing.Point(549, 473)
        Me.PIN2.MaxLength = 1
        Me.PIN2.Name = "PIN2"
        Me.PIN2.Size = New System.Drawing.Size(54, 76)
        Me.PIN2.TabIndex = 32
        Me.PIN2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.PIN2.UseSystemPasswordChar = True
        '
        'PIN1
        '
        Me.PIN1.Font = New System.Drawing.Font("Arial", 36.0!, System.Drawing.FontStyle.Bold)
        Me.PIN1.Location = New System.Drawing.Point(489, 473)
        Me.PIN1.MaxLength = 1
        Me.PIN1.Name = "PIN1"
        Me.PIN1.Size = New System.Drawing.Size(54, 76)
        Me.PIN1.TabIndex = 31
        Me.PIN1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.PIN1.UseSystemPasswordChar = True
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(120.0!, 120.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(1182, 853)
        Me.Controls.Add(Me.PIN4)
        Me.Controls.Add(Me.PIN3)
        Me.Controls.Add(Me.PIN2)
        Me.Controls.Add(Me.PIN1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "Form3"
        Me.RightToLeftLayout = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Bank of McMaster ATM"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents PIN4 As TextBox
    Friend WithEvents PIN3 As TextBox
    Friend WithEvents PIN2 As TextBox
    Friend WithEvents PIN1 As TextBox
End Class
