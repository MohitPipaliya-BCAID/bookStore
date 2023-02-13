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
        Me.GridView = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.src = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtSal = New System.Windows.Forms.TextBox()
        Me.txtdept = New System.Windows.Forms.TextBox()
        Me.txtDoj = New System.Windows.Forms.TextBox()
        Me.txtCt = New System.Windows.Forms.TextBox()
        Me.txtENm = New System.Windows.Forms.TextBox()
        Me.txtENo = New System.Windows.Forms.TextBox()
        Me.ins = New System.Windows.Forms.Button()
        Me.updt = New System.Windows.Forms.Button()
        Me.dlt = New System.Windows.Forms.Button()
        Me.disp = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.GridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GridView
        '
        Me.GridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GridView.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GridView.Location = New System.Drawing.Point(0, 279)
        Me.GridView.Name = "GridView"
        Me.GridView.RowTemplate.Height = 25
        Me.GridView.Size = New System.Drawing.Size(800, 171)
        Me.GridView.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.Color.DimGray
        Me.Label1.Location = New System.Drawing.Point(256, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(280, 37)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Employee information"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.src)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtSal)
        Me.GroupBox1.Controls.Add(Me.txtdept)
        Me.GroupBox1.Controls.Add(Me.txtDoj)
        Me.GroupBox1.Controls.Add(Me.txtCt)
        Me.GroupBox1.Controls.Add(Me.txtENm)
        Me.GroupBox1.Controls.Add(Me.txtENo)
        Me.GroupBox1.Location = New System.Drawing.Point(45, 59)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(434, 200)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Enter details"
        '
        'src
        '
        Me.src.Location = New System.Drawing.Point(369, 22)
        Me.src.Name = "src"
        Me.src.Size = New System.Drawing.Size(55, 23)
        Me.src.TabIndex = 7
        Me.src.Text = "Search"
        Me.src.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(25, 170)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(38, 15)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Salary"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(25, 141)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(70, 15)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Department"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(25, 112)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(28, 15)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "DOJ"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(25, 83)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(28, 15)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "City"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(25, 54)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(92, 15)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Employee name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(25, 25)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(104, 15)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Employee number"
        '
        'txtSal
        '
        Me.txtSal.Location = New System.Drawing.Point(167, 167)
        Me.txtSal.Name = "txtSal"
        Me.txtSal.Size = New System.Drawing.Size(196, 23)
        Me.txtSal.TabIndex = 5
        '
        'txtdept
        '
        Me.txtdept.Location = New System.Drawing.Point(167, 138)
        Me.txtdept.Name = "txtdept"
        Me.txtdept.Size = New System.Drawing.Size(196, 23)
        Me.txtdept.TabIndex = 4
        '
        'txtDoj
        '
        Me.txtDoj.Location = New System.Drawing.Point(167, 109)
        Me.txtDoj.Name = "txtDoj"
        Me.txtDoj.Size = New System.Drawing.Size(196, 23)
        Me.txtDoj.TabIndex = 3
        '
        'txtCt
        '
        Me.txtCt.Location = New System.Drawing.Point(167, 80)
        Me.txtCt.Name = "txtCt"
        Me.txtCt.Size = New System.Drawing.Size(196, 23)
        Me.txtCt.TabIndex = 2
        '
        'txtENm
        '
        Me.txtENm.Location = New System.Drawing.Point(167, 51)
        Me.txtENm.Name = "txtENm"
        Me.txtENm.Size = New System.Drawing.Size(196, 23)
        Me.txtENm.TabIndex = 1
        '
        'txtENo
        '
        Me.txtENo.Location = New System.Drawing.Point(167, 22)
        Me.txtENo.Name = "txtENo"
        Me.txtENo.Size = New System.Drawing.Size(196, 23)
        Me.txtENo.TabIndex = 0
        '
        'ins
        '
        Me.ins.Location = New System.Drawing.Point(545, 60)
        Me.ins.Name = "ins"
        Me.ins.Size = New System.Drawing.Size(168, 23)
        Me.ins.TabIndex = 3
        Me.ins.Text = "Insert"
        Me.ins.UseVisualStyleBackColor = True
        '
        'updt
        '
        Me.updt.Location = New System.Drawing.Point(545, 100)
        Me.updt.Name = "updt"
        Me.updt.Size = New System.Drawing.Size(168, 23)
        Me.updt.TabIndex = 4
        Me.updt.Text = "Update"
        Me.updt.UseVisualStyleBackColor = True
        '
        'dlt
        '
        Me.dlt.Location = New System.Drawing.Point(545, 140)
        Me.dlt.Name = "dlt"
        Me.dlt.Size = New System.Drawing.Size(168, 23)
        Me.dlt.TabIndex = 5
        Me.dlt.Text = "Delete"
        Me.dlt.UseVisualStyleBackColor = True
        '
        'disp
        '
        Me.disp.Location = New System.Drawing.Point(545, 180)
        Me.disp.Name = "disp"
        Me.disp.Size = New System.Drawing.Size(168, 23)
        Me.disp.TabIndex = 6
        Me.disp.Text = "Display"
        Me.disp.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(545, 215)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(168, 44)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "Sales department and salary less than 1500"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.disp)
        Me.Controls.Add(Me.dlt)
        Me.Controls.Add(Me.updt)
        Me.Controls.Add(Me.ins)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GridView)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.GridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GridView As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtSal As TextBox
    Friend WithEvents txtdept As TextBox
    Friend WithEvents txtDoj As TextBox
    Friend WithEvents txtCt As TextBox
    Friend WithEvents txtENm As TextBox
    Friend WithEvents txtENo As TextBox
    Friend WithEvents ins As Button
    Friend WithEvents updt As Button
    Friend WithEvents dlt As Button
    Friend WithEvents disp As Button
    Friend WithEvents src As Button
    Friend WithEvents Button1 As Button
End Class
