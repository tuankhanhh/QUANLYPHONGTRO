<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HopDongView
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
        Button_Nhap = New Button()
        Button_Xoa = New Button()
        Button_Luu = New Button()
        TextBox_MaNguoiThue = New TextBox()
        Label6 = New Label()
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        DataGridView1 = New DataGridView()
        Panel1 = New Panel()
        Label1 = New Label()
        ComboBox1 = New ComboBox()
        TextBox_TienCoc = New TextBox()
        Label2 = New Label()
        DateTimePicker1 = New DateTimePicker()
        DateTimePicker2 = New DateTimePicker()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Button_Nhap
        ' 
        Button_Nhap.Font = New Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button_Nhap.Location = New Point(247, 602)
        Button_Nhap.Name = "Button_Nhap"
        Button_Nhap.Size = New Size(146, 49)
        Button_Nhap.TabIndex = 27
        Button_Nhap.Text = "Sửa"
        Button_Nhap.UseVisualStyleBackColor = True
        ' 
        ' Button_Xoa
        ' 
        Button_Xoa.Font = New Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button_Xoa.Location = New Point(475, 602)
        Button_Xoa.Name = "Button_Xoa"
        Button_Xoa.Size = New Size(146, 49)
        Button_Xoa.TabIndex = 26
        Button_Xoa.Text = "Xóa"
        Button_Xoa.UseVisualStyleBackColor = True
        ' 
        ' Button_Luu
        ' 
        Button_Luu.Font = New Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button_Luu.Location = New Point(43, 602)
        Button_Luu.Name = "Button_Luu"
        Button_Luu.Size = New Size(146, 49)
        Button_Luu.TabIndex = 25
        Button_Luu.Text = "Thêm"
        Button_Luu.UseVisualStyleBackColor = True
        ' 
        ' TextBox_MaNguoiThue
        ' 
        TextBox_MaNguoiThue.Font = New Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox_MaNguoiThue.Location = New Point(253, 246)
        TextBox_MaNguoiThue.Name = "TextBox_MaNguoiThue"
        TextBox_MaNguoiThue.Size = New Size(368, 37)
        TextBox_MaNguoiThue.TabIndex = 22
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(21, 156)
        Label6.Name = "Label6"
        Label6.Size = New Size(168, 38)
        Label6.TabIndex = 20
        Label6.Text = "Mã Phòng: "
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(21, 242)
        Label5.Name = "Label5"
        Label5.Size = New Size(240, 38)
        Label5.TabIndex = 19
        Label5.Text = "Mã Người Thuê: "
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(21, 329)
        Label4.Name = "Label4"
        Label4.Size = New Size(215, 38)
        Label4.TabIndex = 18
        Label4.Text = "Ngày Bắt Đầu: "
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(21, 415)
        Label3.Name = "Label3"
        Label3.Size = New Size(225, 38)
        Label3.TabIndex = 17
        Label3.Text = "Ngày Kết Thúc: "
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(660, 137)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 62
        DataGridView1.Size = New Size(815, 579)
        DataGridView1.TabIndex = 16
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(Label1)
        Panel1.Location = New Point(1, 1)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1483, 121)
        Panel1.TabIndex = 15
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(516, 37)
        Label1.Name = "Label1"
        Label1.Size = New Size(381, 54)
        Label1.TabIndex = 1
        Label1.Text = "Quản Lý Hợp Đồng"
        ' 
        ' ComboBox1
        ' 
        ComboBox1.Font = New Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ComboBox1.FormattingEnabled = True
        ComboBox1.Location = New Point(253, 160)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(368, 38)
        ComboBox1.TabIndex = 28
        ' 
        ' TextBox_TienCoc
        ' 
        TextBox_TienCoc.Font = New Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox_TienCoc.Location = New Point(253, 507)
        TextBox_TienCoc.Name = "TextBox_TienCoc"
        TextBox_TienCoc.Size = New Size(368, 37)
        TextBox_TienCoc.TabIndex = 30
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(21, 507)
        Label2.Name = "Label2"
        Label2.Size = New Size(144, 38)
        Label2.TabIndex = 29
        Label2.Text = "Tiền Cọc: "
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.Location = New Point(253, 336)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(368, 31)
        DateTimePicker1.TabIndex = 31
        ' 
        ' DateTimePicker2
        ' 
        DateTimePicker2.Location = New Point(253, 422)
        DateTimePicker2.Name = "DateTimePicker2"
        DateTimePicker2.Size = New Size(368, 31)
        DateTimePicker2.TabIndex = 32
        ' 
        ' HopDongView
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1487, 743)
        Controls.Add(DateTimePicker2)
        Controls.Add(DateTimePicker1)
        Controls.Add(TextBox_TienCoc)
        Controls.Add(Label2)
        Controls.Add(ComboBox1)
        Controls.Add(Button_Nhap)
        Controls.Add(Button_Xoa)
        Controls.Add(Button_Luu)
        Controls.Add(TextBox_MaNguoiThue)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(DataGridView1)
        Controls.Add(Panel1)
        Name = "HopDongView"
        Text = "HopDongView"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button_Nhap As Button
    Friend WithEvents Button_Xoa As Button
    Friend WithEvents Button_Luu As Button
    Friend WithEvents TextBox_MaNguoiThue As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents TextBox_TienCoc As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents DateTimePicker2 As DateTimePicker
End Class
