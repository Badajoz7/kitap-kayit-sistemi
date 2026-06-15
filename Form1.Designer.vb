<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        components = New ComponentModel.Container()
        TabControl1 = New TabControl()
        TabPage1 = New TabPage()
        Label8 = New Label()
        Label7 = New Label()
        Label6 = New Label()
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        Button1 = New Button()
        TextBox6 = New TextBox()
        TextBox5 = New TextBox()
        TextBox4 = New TextBox()
        TextBox3 = New TextBox()
        TextBox2 = New TextBox()
        TextBox1 = New TextBox()
        TabPage2 = New TabPage()
        ListBox1 = New ListBox()
        Timer1 = New Timer(components)
        ProgressBar1 = New ProgressBar()
        TabControl1.SuspendLayout()
        TabPage1.SuspendLayout()
        TabPage2.SuspendLayout()
        SuspendLayout()
        ' 
        ' TabControl1
        ' 
        TabControl1.Controls.Add(TabPage1)
        TabControl1.Controls.Add(TabPage2)
        TabControl1.Dock = DockStyle.Fill
        TabControl1.Location = New Point(0, 0)
        TabControl1.Name = "TabControl1"
        TabControl1.SelectedIndex = 0
        TabControl1.Size = New Size(1116, 577)
        TabControl1.TabIndex = 0
        ' 
        ' TabPage1
        ' 
        TabPage1.Controls.Add(ProgressBar1)
        TabPage1.Controls.Add(Label8)
        TabPage1.Controls.Add(Label7)
        TabPage1.Controls.Add(Label6)
        TabPage1.Controls.Add(Label5)
        TabPage1.Controls.Add(Label4)
        TabPage1.Controls.Add(Label3)
        TabPage1.Controls.Add(Label2)
        TabPage1.Controls.Add(Label1)
        TabPage1.Controls.Add(Button1)
        TabPage1.Controls.Add(TextBox6)
        TabPage1.Controls.Add(TextBox5)
        TabPage1.Controls.Add(TextBox4)
        TabPage1.Controls.Add(TextBox3)
        TabPage1.Controls.Add(TextBox2)
        TabPage1.Controls.Add(TextBox1)
        TabPage1.Location = New Point(4, 24)
        TabPage1.Name = "TabPage1"
        TabPage1.Padding = New Padding(3)
        TabPage1.Size = New Size(1108, 549)
        TabPage1.TabIndex = 0
        TabPage1.Text = "Kitap Kayıt Sorgulama"
        TabPage1.UseVisualStyleBackColor = True
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold Or FontStyle.Italic)
        Label8.Location = New Point(349, 108)
        Label8.Name = "Label8"
        Label8.Size = New Size(411, 30)
        Label8.TabIndex = 15
        Label8.Text = "Bozkurt Halk Kütüphanesi Kitap Sistemi"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold Or FontStyle.Italic)
        Label7.Location = New Point(367, 76)
        Label7.Name = "Label7"
        Label7.Size = New Size(324, 30)
        Label7.TabIndex = 14
        Label7.Text = "T.C. Kültür ve Turizm Bakanlığı"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(572, 319)
        Label6.Name = "Label6"
        Label6.Size = New Size(55, 15)
        Label6.TabIndex = 13
        Label6.Text = "Kitap NO"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(572, 290)
        Label5.Name = "Label5"
        Label5.Size = New Size(67, 15)
        Label5.TabIndex = 12
        Label5.Text = "Sayfa Sayısı"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(572, 262)
        Label4.Name = "Label4"
        Label4.Size = New Size(89, 15)
        Label4.TabIndex = 11
        Label4.Text = "Kitap Kategorisi"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(305, 233)
        Label3.Name = "Label3"
        Label3.Size = New Size(50, 15)
        Label3.TabIndex = 10
        Label3.Text = "Yayınevi"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(305, 204)
        Label2.Name = "Label2"
        Label2.Size = New Size(34, 15)
        Label2.TabIndex = 9
        Label2.Text = "Yazar"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(305, 175)
        Label1.Name = "Label1"
        Label1.Size = New Size(55, 15)
        Label1.TabIndex = 8
        Label1.Text = "Kitap Adı"
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.LightGray
        Button1.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(162))
        Button1.Location = New Point(305, 340)
        Button1.Name = "Button1"
        Button1.Size = New Size(455, 56)
        Button1.TabIndex = 7
        Button1.Text = "Kitabı Kaydet"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' TextBox6
        ' 
        TextBox6.Location = New Point(667, 311)
        TextBox6.MaxLength = 20
        TextBox6.Name = "TextBox6"
        TextBox6.Size = New Size(93, 23)
        TextBox6.TabIndex = 5
        ' 
        ' TextBox5
        ' 
        TextBox5.Location = New Point(667, 282)
        TextBox5.MaxLength = 20
        TextBox5.Name = "TextBox5"
        TextBox5.Size = New Size(93, 23)
        TextBox5.TabIndex = 4
        ' 
        ' TextBox4
        ' 
        TextBox4.Location = New Point(667, 254)
        TextBox4.MaxLength = 20
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(93, 23)
        TextBox4.TabIndex = 3
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(370, 225)
        TextBox3.MaxLength = 50
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(390, 23)
        TextBox3.TabIndex = 2
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(370, 196)
        TextBox2.MaxLength = 50
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(390, 23)
        TextBox2.TabIndex = 1
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(370, 167)
        TextBox1.MaxLength = 50
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(390, 23)
        TextBox1.TabIndex = 0
        ' 
        ' TabPage2
        ' 
        TabPage2.Controls.Add(ListBox1)
        TabPage2.Location = New Point(4, 24)
        TabPage2.Name = "TabPage2"
        TabPage2.Padding = New Padding(3)
        TabPage2.Size = New Size(1108, 549)
        TabPage2.TabIndex = 1
        TabPage2.Text = "Kitap Listesi"
        TabPage2.UseVisualStyleBackColor = True
        ' 
        ' ListBox1
        ' 
        ListBox1.Dock = DockStyle.Fill
        ListBox1.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(162))
        ListBox1.FormattingEnabled = True
        ListBox1.Location = New Point(3, 3)
        ListBox1.Name = "ListBox1"
        ListBox1.Size = New Size(1102, 543)
        ListBox1.TabIndex = 0
        ' 
        ' Timer1
        ' 
        Timer1.Enabled = True
        Timer1.Interval = 1000
        ' 
        ' ProgressBar1
        ' 
        ProgressBar1.Location = New Point(305, 402)
        ProgressBar1.Name = "ProgressBar1"
        ProgressBar1.Size = New Size(455, 27)
        ProgressBar1.TabIndex = 17
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1116, 577)
        Controls.Add(TabControl1)
        Name = "Form1"
        Text = "Form1"
        TabControl1.ResumeLayout(False)
        TabPage1.ResumeLayout(False)
        TabPage1.PerformLayout()
        TabPage2.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents ProgressBar1 As ProgressBar

End Class
