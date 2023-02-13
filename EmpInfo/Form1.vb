Imports System.Data.OleDb
Public Class Form1
    Sub view()
        Dim conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\HPX\OneDrive\Desktop\VB_Journal\EmpInfo\EmpInfoDB.accdb")
        conn.Open()
        Dim adp As New OleDbDataAdapter("select * from info", conn)
        Dim ds As New DataSet()
        adp.Fill(ds, "info")
        GridView.DataSource = ds.Tables("info")
        conn.Close()
        txtCt.Clear()
        txtdept.Clear()
        txtDoj.Clear()
        txtENm.Clear()
        txtENo.Clear()
        txtSal.Clear()
    End Sub

    Private Sub disp_Click(sender As Object, e As EventArgs) Handles disp.Click
        view()
    End Sub

    Private Sub ins_Click(sender As Object, e As EventArgs) Handles ins.Click
        If txtENo.Text = "" Or txtENm.Text = "" Or txtCt.Text = "" Or txtDoj.Text = "" Or txtdept.Text = "" Or txtSal.Text = "" Then
            MsgBox("Please enter all mandatory fields")
        ElseIf Not IsNumeric(txtENo.Text) Or Not IsNumeric(txtSal.Text) Then
            MsgBox("Please enter numeric value in employee number and salary field")
        ElseIf Not IsDate(txtDoj.Text) Then
            MsgBox("Please enter date in valid format (dd/mm/yyyy)")
        Else
            Dim conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\HPX\OneDrive\Desktop\VB_Journal\EmpInfo\EmpInfoDB.accdb")
            conn.Open()
            Dim cmd As New OleDbCommand
            cmd.Connection = conn
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "insert into info values(" & txtENo.Text & ",'" & txtENm.Text & "','" & txtCt.Text & "','" & txtDoj.Text & "','" & txtdept.Text & "'," & txtSal.Text & ")"
            cmd.ExecuteNonQuery()
            MsgBox("Record inserted successfully!")
            conn.Close()
            view()
        End If
    End Sub

    Private Sub updt_Click(sender As Object, e As EventArgs) Handles updt.Click
        If txtENo.Text = "" Or txtENm.Text = "" Or txtCt.Text = "" Or txtDoj.Text = "" Or txtdept.Text = "" Or txtSal.Text = "" Then
            MsgBox("Please enter all mandatory fields")
        ElseIf Not IsNumeric(txtENo.Text) Or Not IsNumeric(txtSal.Text) Then
            MsgBox("Please enter numeric value in employee number and salary field")
        ElseIf Not IsDate(txtDoj.Text) Then
            MsgBox("Please enter date in valid format (dd/mm/yyyy)")
        Else
            Dim conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\HPX\OneDrive\Desktop\VB_Journal\EmpInfo\EmpInfoDB.accdb")
            conn.Open()
            Dim cmd As New OleDbCommand
            cmd.Connection = conn
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "update info set empName = '" & txtENm.Text & "' ,city='" & txtCt.Text & "' ,DOJ='" & txtDoj.Text & "' ,department='" & txtdept.Text & "' ,salary=" & txtSal.Text & " where empNo= " & txtENo.Text & " "
            cmd.ExecuteNonQuery()
            MsgBox("Record updated successfully!")
            conn.Close()
            view()
        End If
    End Sub

    Private Sub dlt_Click(sender As Object, e As EventArgs) Handles dlt.Click
        Dim conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\HPX\OneDrive\Desktop\VB_Journal\EmpInfo\EmpInfoDB.accdb")
        conn.Open()
        Dim cmd As New OleDbCommand
        cmd.Connection = conn
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "delete from info where empNo= " & txtENo.Text & " "
        cmd.ExecuteNonQuery()
        MsgBox("Record deleted successfully!")
        conn.Close()
        view()
    End Sub

    Private Sub src_Click(sender As Object, e As EventArgs) Handles src.Click
        Dim conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\HPX\OneDrive\Desktop\VB_Journal\EmpInfo\EmpInfoDB.accdb")
        conn.Open()
        Dim adp As New OleDbDataAdapter("select * from info where empNo =" & txtENo.Text & " ", conn)
        Dim ds As New DataSet()
        adp.Fill(ds, "info")
        GridView.DataSource = ds.Tables("info")
        conn.Close()
        txtCt.Clear()
        txtdept.Clear()
        txtDoj.Clear()
        txtENm.Clear()
        txtENo.Clear()
        txtSal.Clear()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\HPX\OneDrive\Desktop\VB_Journal\EmpInfo\EmpInfoDB.accdb")
        conn.Open()
        Dim adp As New OleDbDataAdapter("select * from info where department ='sales' and salary < 1500 ", conn)
        Dim ds As New DataSet()
        adp.Fill(ds, "info")
        GridView.DataSource = ds.Tables("info")
        conn.Close()
    End Sub
End Class
