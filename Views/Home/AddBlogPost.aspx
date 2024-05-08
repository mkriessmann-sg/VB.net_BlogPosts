<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Views/Shared/BlogSite.Master" CodeBehind="AddBlogPost.aspx.vb" Inherits="VB.net_BlogPosts.AddBlogPost" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolderBlog" runat="server">
       
    <script runat="server">
        Protected Sub Add_Post_Button(ByVal sender As Object, ByVal e As EventArgs)
            ' Server-side code to handle button click event
            Dim blogpost As VB.net_BlogPosts.DatabaseHandling.BlogPost = New VB.net_BlogPosts.DatabaseHandling.BlogPost
            blogpost.Title = TitleBox.Text
            blogpost.Content = ContentBox.Text
            blogpost.PostDate = DateTime.Now

            Dim DbHandler As VB.net_BlogPosts.DatabaseHandling.DatabaseHandler = New VB.net_BlogPosts.DatabaseHandling.DatabaseHandler
            blogpost.Id = DbHandler.GetHighestID() + 1
            DbHandler.AddPost(blogpost)
            Response.Redirect("MainView.aspx")

        End Sub

     </script>




     <div>
    <h1 style = "text-align: center ">Create a new Post</h1>
    
</div>
    <div style = "text-align: center ">
    <label >Title</label>
    
    <asp:TextBox ID="TitleBox" runat="server" placeholder ="Title" />
    <label>Content</label>
    
    <asp:TextBox ID="ContentBox" runat="server" placeholder ="Content" />

    <asp:Button ID="btnSubmit" runat="server" Text="Submit" OnClick="Add_Post_Button" />
    
        </div>

</asp:Content>
