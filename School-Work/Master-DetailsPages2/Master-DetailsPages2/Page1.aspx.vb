Public Class WebForm1
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub btnSelect_Click() Handles btnSelect.Click
        lblAnswer.Text = "You chose " &
        ddlFruitList.SelectedItem.ToString
    End Sub

End Class