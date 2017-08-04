Public Class MasterPage
    Inherits System.Web.UI.MasterPage

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub btnPage1_Click() Handles btnPage1.Click
        Response.Redirect("Page1.aspx")
    End Sub
    Protected Sub btnPage2_Click() Handles btnPage2.Click
        Response.Redirect("Page2.aspx")
    End Sub

End Class