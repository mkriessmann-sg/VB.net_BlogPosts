<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Views/Shared/BlogSite.Master" CodeBehind="MainView.aspx.vb" Inherits="VB.net_BlogPosts.MainView" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolderBlog" runat="server">


        <% 
        Dim blogList As List(Of VB.net_BlogPosts.DatabaseHandling.BlogPost) = New List(Of VB.net_BlogPosts.DatabaseHandling.BlogPost)

        Dim DbHandler As VB.net_BlogPosts.DatabaseHandling.DatabaseHandler = New VB.net_BlogPosts.DatabaseHandling.DatabaseHandler

        blogList = DbHandler.GetBlogPosts()

        %>

    <script runat="server">

        Protected Sub Delete_Post_Button(ByVal sender As Object, ByVal e As CommandEventArgs)
            ' Server-side code to handle button click event
            Dim btn As Button = sender
            Dim id As Integer = Convert.ToInt32(e.CommandArgument)
            Dim DbHandler As VB.net_BlogPosts.DatabaseHandling.DatabaseHandler = New VB.net_BlogPosts.DatabaseHandling.DatabaseHandler
            DbHandler.DeletePost(id)

        End Sub


</script>
       
    <h1 style = "text-align: center " >Main View</h1>


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
