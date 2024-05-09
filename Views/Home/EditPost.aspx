<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Views/Shared/BlogSite.Master" CodeBehind="EditPost.aspx.vb" Inherits="VB.net_BlogPosts.EditPost" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolderBlog" runat="server">

   
     <div>
    <h1 style = "text-align: center ">Edit Post</h1>
    
</div>
    <div style = "text-align: center ">
    <label >Title</label>
    
    <asp:TextBox ID="TitleBox" runat="server" placeholder ="Title" />
    <label>Content</label>
    
    <asp:TextBox ID="ContentBox" runat="server" placeholder ="Content" />

    <asp:Button ID="btnSubmit" runat="server" Text="Submit" OnClick="Edit_Post_Button" />
    
        </div>

</asp:Content>
