Class SiteMaster
    Inherits System.Web.UI.Page


    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        ' Add any initialization logic here
    End Sub

    Protected Sub BlogPostsLink_Click(sender As Object, e As EventArgs)
        ' Handle navigation to Blog Posts page
        Response.Redirect("BlogPosts.aspx")
    End Sub

    Protected Sub CreateBlogPostLink_Click(sender As Object, e As EventArgs)
        ' Handle navigation to Create Blog Post page
        Response.Redirect("CreateBlogPost.aspx")
    End Sub

End Class

