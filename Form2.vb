Public Class Form2
    Dim student(3, 3) As String ' 2차원 배열 Student
    Dim i As Integer = 0 ' 자동으로 할당되는 번호를 저장할 변수 i 

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        i += 1 ' 입력을 클릭하면 변수 i 값을 증가시켜 번호를 자동으로 할당
        If i <= 3 Then
            TextBox1.Text = i
            TextBox2.Text = ""
            TextBox3.Text = ""
            TextBox3.Focus()
        Else ' 3명이 넘어가면 입력을 중단
            TextBox1.Text = i
            MessageBox.Show("입력이 불가능합니다.", "입력")
            TextBox1.Text = ""
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If i <= 3 Then ' 저장을 클릭하면 입력한 번호, 이름, 점수를 저장 
            student(TextBox1.Text, 1) = TextBox1.Text  '번호
            student(TextBox1.Text, 2) = TextBox2.Text  '이름
            student(TextBox1.Text, 3) = TextBox3.Text  '정수 
            TextBox1.Text = ""
            TextBox2.Text = ""
            TextBox3.Text = ""
        Else
            MessageBox.Show("저장이 불가능합니다.", "저장")
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If TextBox4.Text Like "[1-3]" Then
            TextBox1.Text = student(TextBox4.Text, 1)
            TextBox2.Text = student(TextBox4.Text, 2)
            TextBox3.Text = student(TextBox4.Text, 3)
        Else
            MessageBox.Show("찾는 데이터가 없습니다.", "검색")
            TextBox4.Focus()
        End If
    End Sub


End Class