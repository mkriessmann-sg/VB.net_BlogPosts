<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Views/Shared/BlogSite.Master" CodeBehind="Test Page.aspx.vb" Inherits="VB.net_BlogPosts.Test_Page"%>



<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolderBlog" runat="server">

    <%@ Import Namespace="DatabaseHandling"%> 


    <% Dim blogList As List(Of VB.net_BlogPosts.DatabaseHandling.BlogPost) = New List(Of VB.net_BlogPosts.DatabaseHandling.BlogPost)


        'Dim blog1 = New VB.net_BlogPosts.DatabaseHandling.BlogPost()
        'blog1.Id = 1
        'blog1.Title = "Title1"
        'blog1.Content = "Content 1"

        'Dim blog2 = New VB.net_BlogPosts.DatabaseHandling.BlogPost()
        'blog2.Id = 2
        'blog2.Title = "Title2"
        'blog2.Content = "Content 2"
        'blogList.Add(blog2)
        'blogList.Add(blog1)


        Dim DbHandler As VB.net_BlogPosts.DatabaseHandling.DatabaseHandler = New VB.net_BlogPosts.DatabaseHandling.DatabaseHandler

        blogList = DbHandler.GetBlogPosts()
        DbHandler.TestConnection()


        %>


    <% Dim posts As New List(Of Object)() %> 

    <h1>Test Page for all kinds of stuff</h1>

    <div>
    <h1 style = "text-align: center ">Create a new Post</h1>
    
</div>
    <div style = "text-align: center ">
    <label >Title</label>
    <input placeholder ="Title" />
    <label>Content</label>
    <input placeholder ="Content"   />
    <button id="OkButton" onclick ="Add_Post" >Ok</button>
        </div>


    <%For Each blog As VB.net_BlogPosts.DatabaseHandling.BlogPost In blogList%>  
    <div>
        <h1 style = "text-align: center "> <%= blog.Title%> </h1>
        </div>
    <div> 
        <p style = "text-align: center " > 
            <%= blog.Content%>
        </p>
    </div>
    <div> <hr class="solid"> </div>
    <a>Edit</a>
    <a>delete</a>
   <%       Next %>
  



</asp:Content>
