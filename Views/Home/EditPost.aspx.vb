Imports VB.net_BlogPosts.DatabaseHandling

Public Class EditPost
    Inherits System.Web.UI.Page






    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then
            Dim DbHandler As VB.net_BlogPosts.DatabaseHandling.DatabaseHandler = New VB.net_BlogPosts.DatabaseHandling.DatabaseHandler
            Dim updateID As Integer = CType(Session.Item("IDtoEdit"), Integer)
            Dim blogpostToUpdate As VB.net_BlogPosts.DatabaseHandling.BlogPost
            blogpostToUpdate = DbHandler.GetPostByID(updateID)
            TitleBox.Text = blogpostToUpdate.Title
            ContentBox.Text = blogpostToUpdate.Content


        End If
    End Sub

    Protected Sub Edit_Post_Button(ByVal sender As Object, ByVal e As EventArgs)
        ' Server-side code to handle button click event
        Dim DbHandler As VB.net_BlogPosts.DatabaseHandling.DatabaseHandler = New VB.net_BlogPosts.DatabaseHandling.DatabaseHandler
        Dim updateID As Integer = CType(Session.Item("IDtoEdit"), Integer)

        Dim blogpostToUpdate As BlogPost = DbHandler.GetPostByID(updateID)
        blogpostToUpdate.Title = TitleBox.Text
        blogpostToUpdate.Content = ContentBox.Text
        DbHandler.UpdatePost(blogpostToUpdate)
        Response.Redirect("MainView.aspx")

    End Sub


End Class