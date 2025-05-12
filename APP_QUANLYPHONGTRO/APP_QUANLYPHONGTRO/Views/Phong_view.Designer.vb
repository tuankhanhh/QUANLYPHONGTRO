<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Phong_view
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
        Panel1 = New Panel()
        Label1 = New Label()
        DataGridView1 = New DataGridView()
        BackgroundWorker1 = New ComponentModel.BackgroundWorker()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        TextBox_TenPhong = New TextBox()
        TextBox_DienTich = New TextBox()
        TextBox_GiaPhong = New TextBox()
        TextBox_TrangThai = New TextBox()
        Button_Luu = New Button()
        Button_Xoa = New Button()
        Button_Nhap = New Button()
        Panel1.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(Label1)
        Panel1.Location = New Point(2, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1483, 121)
        Panel1.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(516, 37)
        Label1.Name = "Label1"
        Label1.Size = New Size(379, 54)
        Label1.TabIndex = 1
        Label1.Text = "Quản Lý Phòng Trọ"
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(642, 151)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 62
        DataGridView1.Size = New Size(815, 611)
        DataGridView1.TabIndex = 1
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(21, 441)
        Label3.Name = "Label3"
        Label3.Size = New Size(163, 38)
        Label3.TabIndex = 3
        Label3.Text = "Trạng Thái:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(21, 355)
        Label4.Name = "Label4"
        Label4.Size = New Size(161, 38)
        Label4.TabIndex = 4
        Label4.Text = "Giá Phòng:"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(21, 268)
        Label5.Name = "Label5"
        Label5.Size = New Size(148, 38)
        Label5.TabIndex = 5
        Label5.Text = "Diện Tích:"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(21, 182)
        Label6.Name = "Label6"
        Label6.Size = New Size(163, 38)
        Label6.TabIndex = 6
        Label6.Text = "Tên Phòng:"
        ' 
        ' TextBox_TenPhong
        ' 
        TextBox_TenPhong.Font = New Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox_TenPhong.Location = New Point(233, 182)
        TextBox_TenPhong.Name = "TextBox_TenPhong"
        TextBox_TenPhong.Size = New Size(368, 37)
        TextBox_TenPhong.TabIndex = 8
        ' 
        ' TextBox_DienTich
        ' 
        TextBox_DienTich.Font = New Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox_DienTich.Location = New Point(233, 267)
        TextBox_DienTich.Name = "TextBox_DienTich"
        TextBox_DienTich.Size = New Size(368, 37)
        TextBox_DienTich.TabIndex = 9
        ' 
        ' TextBox_GiaPhong
        ' 
        TextBox_GiaPhong.Font = New Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox_GiaPhong.Location = New Point(233, 356)
        TextBox_GiaPhong.Name = "TextBox_GiaPhong"
        TextBox_GiaPhong.Size = New Size(368, 37)
        TextBox_GiaPhong.TabIndex = 10
        ' 
        ' TextBox_TrangThai
        ' 
        TextBox_TrangThai.Font = New Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox_TrangThai.Location = New Point(233, 441)
        TextBox_TrangThai.Name = "TextBox_TrangThai"
        TextBox_TrangThai.Size = New Size(368, 37)
        TextBox_TrangThai.TabIndex = 11
        ' 
        ' Button_Luu
        ' 
        Button_Luu.Font = New Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button_Luu.Location = New Point(43, 540)
        Button_Luu.Name = "Button_Luu"
        Button_Luu.Size = New Size(146, 49)
        Button_Luu.TabIndex = 12
        Button_Luu.Text = "Thêm"
        Button_Luu.UseVisualStyleBackColor = True
        ' 
        ' Button_Xoa
        ' 
        Button_Xoa.Font = New Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button_Xoa.Location = New Point(475, 540)
        Button_Xoa.Name = "Button_Xoa"
        Button_Xoa.Size = New Size(146, 49)
        Button_Xoa.TabIndex = 13
        Button_Xoa.Text = "Xóa"
        Button_Xoa.UseVisualStyleBackColor = True
        ' 
        ' Button_Nhap
        ' 
        Button_Nhap.Font = New Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button_Nhap.Location = New Point(247, 540)
        Button_Nhap.Name = "Button_Nhap"
        Button_Nhap.Size = New Size(146, 49)
        Button_Nhap.TabIndex = 14
        Button_Nhap.Text = "Sửa"
        Button_Nhap.UseVisualStyleBackColor = True
        ' 
        ' Phong_view
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1482, 797)
        Controls.Add(Button_Nhap)
        Controls.Add(Button_Xoa)
        Controls.Add(Button_Luu)
        Controls.Add(TextBox_TrangThai)
        Controls.Add(TextBox_GiaPhong)
        Controls.Add(TextBox_DienTich)
        Controls.Add(TextBox_TenPhong)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(DataGridView1)
        Controls.Add(Panel1)
        Name = "Phong_view"
        Text = "Phong_viewvb"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBox_TenPhong As TextBox
    Friend WithEvents TextBox_DienTich As TextBox
    Friend WithEvents TextBox_GiaPhong As TextBox
    Friend WithEvents TextBox_TrangThai As TextBox
    Friend WithEvents Button_Luu As Button
    Friend WithEvents Button_Xoa As Button
    Friend WithEvents Button_Nhap As Button
End Class
