Imports System.Data.SqlClient

Public Class frm_Venue
    Private Sub frm_Venue_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadVenues()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        SaveVenue()
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        UpdateVenue()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        DeleteVenue()
    End Sub

    Private Sub dgw_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgw.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = dgw.Rows(e.RowIndex)
            txtvenuename.Text = row.Cells("Column4").Value.ToString()
            txtvenuecapacity.Text = row.Cells("Column3").Value.ToString()
            btnUpdate.Enabled = True
            btnDelete.Enabled = True
            btnSave.Enabled = False
        End If
    End Sub

    Private Sub LoadVenues()
        Dim sql As String = "SELECT id, venue_name, capacity FROM Venues"
        Dim parameters As New List(Of SqlParameter)()
        Dim dt As DataTable = Crud(sql, parameters)
        dgw.Rows.Clear()
        Dim sn As Integer = 1
        For Each row As DataRow In dt.Rows
            dgw.Rows.Add(sn, row("id"), row("capacity"), row("venue_name"))
            sn += 1
        Next
        ResetForm()
    End Sub

    Private Sub SaveVenue()
        Dim name As String = txtvenuename.Text
        Dim capacity As String = txtvenuecapacity.Text
        Dim sql As String = "INSERT INTO Venues (venue_name, capacity) VALUES (@name, @capacity)"
        Dim parameters As New List(Of SqlParameter) From {
            New SqlParameter("@name", SqlDbType.NVarChar) With {.Value = name},
            New SqlParameter("@capacity", SqlDbType.NVarChar) With {.Value = capacity}
        }
        Crud(sql, parameters)
        LoadVenues()
    End Sub

    Private Sub UpdateVenue()
        Dim id As Integer = Convert.ToInt32(dgw.SelectedRows(0).Cells("Column2").Value)
        Dim name As String = txtvenuename.Text
        Dim capacity As String = txtvenuecapacity.Text
        Dim sql As String = "UPDATE Venues SET venue_name = @name, capacity = @capacity WHERE id = @id"
        Dim parameters As New List(Of SqlParameter) From {
            New SqlParameter("@name", SqlDbType.NVarChar) With {.Value = name},
            New SqlParameter("@capacity", SqlDbType.NVarChar) With {.Value = capacity},
            New SqlParameter("@id", SqlDbType.Int) With {.Value = id}
        }
        Crud(sql, parameters)
        LoadVenues()
    End Sub

    Private Sub DeleteVenue()
        Dim id As Integer = Convert.ToInt32(dgw.SelectedRows(0).Cells("Column2").Value)
        Dim sql As String = "DELETE FROM Venues WHERE id = @id"
        Dim parameters As New List(Of SqlParameter) From {
            New SqlParameter("@id", SqlDbType.Int) With {.Value = id}
        }
        Crud(sql, parameters)
        LoadVenues()
    End Sub

    Private Sub ResetForm()
        txtvenuename.Clear()
        txtvenuecapacity.Clear()
        btnSave.Enabled = True
        btnUpdate.Enabled = False
        btnDelete.Enabled = False
    End Sub


End Class
