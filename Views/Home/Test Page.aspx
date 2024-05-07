<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Views/Shared/BlogSite.Master" CodeBehind="Test Page.aspx.vb" Inherits="VB.net_BlogPosts.Test_Page, VB.net_BlogPosts.DatabaseHandler"%>



<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolderBlog" runat="server">

    <% Dim posts As New List(Of Object)() %> 

    <h1>Test Page for all kinds of stuff</h1>

    <div>
    <h1 style = "text-align: center ">Create a new Post</h1>
    
</div>
    <div style = "text-align: center ">
    <label >Title</label>
    <input/>
    <label>Content</label>
    <input />
    <button>Ok</button>
        </div>


    <%For Each  As String In posts%>  
    <div>
        <h1> <%= name%> </h1>
        </div>
        
   <% next %>
    
</asp:Content>
