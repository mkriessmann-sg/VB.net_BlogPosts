Imports VB.net_BlogPosts.DatabaseHandling

Public Class Test_Page
    Inherits System.Web.UI.Page



    Dim blogList As List(Of VB.net_BlogPosts.DatabaseHandling.BlogPost) = New List(Of VB.net_BlogPosts.DatabaseHandling.BlogPost)

    Dim DbHandler As VB.net_BlogPosts.DatabaseHandling.DatabaseHandler = New VB.net_BlogPosts.DatabaseHandling.DatabaseHandler





    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        blogList = DbHandler.GetBlogPosts()
        Dim table As DataTable = New DataTable
        table.Columns.Add("id")
        table.Columns.Add("Title")
        table.Columns.Add("Content")
        For Each b As BlogPost In blogList
            Dim row = table.NewRow()
            row("id") = b.Id
            row("Title") = b.Title
            row("Content") = b.Content
            table.Rows.Add(row)
        Next
        GridView1.DataSource = table
        GridView1.DataBind()


    End Sub


    Protected Sub Add_Post_Button(ByVal sender As Object, ByVal e As EventArgs)
        ' Server-side code to handle button click event
        Dim blogpost As VB.net_BlogPosts.DatabaseHandling.BlogPost = New VB.net_BlogPosts.DatabaseHandling.BlogPost
        blogpost.Title = TitleBox.Text
        blogpost.Content = ContentBox.Text
        blogpost.PostDate = DateTime.Now

        'Dim DbHandler As VB.net_BlogPosts.DatabaseHandling.DatabaseHandler = New VB.net_BlogPosts.DatabaseHandling.DatabaseHandler
        blogpost.Id = DbHandler.GetHighestID() + 1
        DbHandler.AddPost(blogpost)
        Response.Redirect("Test Page.aspx")




    End Sub

    'Protected Sub Delete_Post_Button(ByVal sender As Object, ByVal e As EventArgs)
    '    ' Server-side code to handle button click event
    '    Dim btn As LinkButton = sender
    '    Dim id As Integer = Convert.ToInt32(btn.CommandArgument)
    '    'Dim DbHandler As VB.net_BlogPosts.DatabaseHandling.DatabaseHandler = New VB.net_BlogPosts.DatabaseHandling.DatabaseHandler
    '    DbHandler.DeletePost(id)
    '    Response.Redirect("Test Page.aspx")
    'End Sub

End Class