<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Views/Shared/BlogSite.Master" CodeBehind="Test Page.aspx.vb" Inherits="VB.net_BlogPosts.Test_Page"%>



<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolderBlog" runat="server">

    <%@ Import Namespace="DatabaseHandling"%> 


    <% 
        Dim blogList As List(Of VB.net_BlogPosts.DatabaseHandling.BlogPost) = New List(Of VB.net_BlogPosts.DatabaseHandling.BlogPost)

        Dim DbHandler As VB.net_BlogPosts.DatabaseHandling.DatabaseHandler = New VB.net_BlogPosts.DatabaseHandling.DatabaseHandler

        blogList = DbHandler.GetBlogPosts()

        %>

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

        End Sub

        Protected Sub Delete_Post_Button(ByVal sender As Object, ByVal e As CommandEventArgs)
            ' Server-side code to handle button click event
            Dim btn As Button = sender
            Dim id As Integer = Convert.ToInt32(e.CommandArgument)
            Dim DbHandler As VB.net_BlogPosts.DatabaseHandling.DatabaseHandler = New VB.net_BlogPosts.DatabaseHandling.DatabaseHandler
            DbHandler.DeletePost(id)

        End Sub


</script>



    <% Dim posts As New List(Of Object)() %> 

    <h1>Test Page for all kinds of stuff</h1>

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

 <% For Each blog As VB.net_BlogPosts.DatabaseHandling.BlogPost In blogList %>
    <div>
        <h1 style="text-align: center "><%= blog.Title %></h1>
    </div>
    <div>
        <p style="text-align: center ">
            <%= blog.Content %>
        </p>
    </div>
    <asp:Button runat="server" Text="Delete" CommandArgument=' <%= blog.Id %>' OnCommand="Delete_Post_Button" />
    <div><hr class="solid"></div>
<% Next %>
  

    

</asp:Content>

