Imports System.IO
Imports System.Data
Imports System.Windows.Forms
Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListBox1.Items.Clear()
        Dim kitaplar As String() = {"Nutuk", "Beyaz Zambaklar Ülkesinde", "1984", "Hayvan Çiftliği"}
        ListBox1.Items.AddRange(kitaplar)
        Me.StartPosition = FormStartPosition.CenterScreen
        Me.ProgressBar1.Visible = False
    End Sub

    Private Sub temizle()
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox5.Clear()
        TextBox6.Clear()
    End Sub

    Private Sub kaydet()
        DataGridView1.Rows.Add()
        DataGridView1.Rows(DataGridView1.Rows.Count - 1).Cells(0).Value = TextBox1.Text
        DataGridView1.Rows(DataGridView1.Rows.Count - 1).Cells(1).Value = TextBox2.Text
        DataGridView1.Rows(DataGridView1.Rows.Count - 1).Cells(2).Value = TextBox3.Text
        DataGridView1.Rows(DataGridView1.Rows.Count - 1).Cells(3).Value = TextBox4.Text
        DataGridView1.Rows(DataGridView1.Rows.Count - 1).Cells(4).Value = TextBox5.Text
        DataGridView1.Rows(DataGridView1.Rows.Count - 1).Cells(5).Value = TextBox6.Text
        temizle()
        DataGridView1.Refresh()
    End Sub
    Private Sub kontrol()
        If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or TextBox4.Text = "" Or TextBox5.Text = "" Or TextBox6.Text = "" Then
            MessageBox.Show("Lütfen tüm alanları doldurun.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            kaydet()
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Me.Text = "Bozkurt Halk Kütüphanesi 2026 " + Date.Now.ToString("yyyy-MM-dd HH:mm:ss")
    End Sub

    Private Sub TextBox2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox2.KeyPress, TextBox1.KeyPress, TextBox4.KeyPress
        e.Handled = Char.IsNumber(e.KeyChar)
    End Sub

    Private Sub TextBox6_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox6.KeyPress, TextBox5.KeyPress
        e.Handled = Char.IsLetter(e.KeyChar)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        kontrol()
    End Sub
End Class
