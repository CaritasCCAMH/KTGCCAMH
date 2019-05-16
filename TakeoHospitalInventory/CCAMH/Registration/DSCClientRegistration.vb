

Partial Public Class DSCClientRegistration
    Partial Class TblOccupationDataTable

        Private Sub TblOccupationDataTable_ColumnChanging(ByVal sender As System.Object, ByVal e As System.Data.DataColumnChangeEventArgs) Handles Me.ColumnChanging
            If (e.Column.ColumnName = Me.OccupationColumn.ColumnName) Then
                'Add user code here
            End If

        End Sub

    End Class

End Class

Namespace DSCClientRegistrationTableAdapters
    
    Partial Public Class CCAMH_CLIENTS111TableAdapter
    End Class
End Namespace
