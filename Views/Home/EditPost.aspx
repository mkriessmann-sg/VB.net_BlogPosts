<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Views/Shared/BlogSite.Master" CodeBehind="EditPost.aspx.vb" Inherits="VB.net_BlogPosts.EditPost" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolderBlog" runat="server">

   


        <script runat="server">

            Protected Sub Edit_Post_Button(ByVal sender As Object, ByVal e As EventArgs)
                ' Server-side code to handle button click event
                Dim blogpost As VB.net_BlogPosts.DatabaseHandling.BlogPost = New VB.net_BlogPosts.DatabaseHandling.BlogPost
                blogpost.Title = TitleBox.Text
                blogpost.Content = ContentBox.Text

                Dim DbHandler As VB.net_BlogPosts.DatabaseHandling.DatabaseHandler = New VB.net_BlogPosts.DatabaseHandling.DatabaseHandler
                blogpost.Id = Convert.ToInt32(HiddenPostId.Value)
                DbHandler.AddPost(blogpost)
                Response.Redirect("MainView.aspx")

            End Sub

            Protected Overrides Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
                If Not IsPostBack Then
                    Dim blogpostToUpdate As VB.net_BlogPosts.DatabaseHandling.BlogPost
                    Dim DbHandler As VB.net_BlogPosts.DatabaseHandling.DatabaseHandler = New VB.net_BlogPosts.DatabaseHandling.DatabaseHandler
                    blogpostToUpdate = DbHandler.GetPostByID(0)

                    ' Set the values of hidden fields
                    HiddenPostId.Value = blogpostToUpdate.Id.ToString()
                    ' Set the textboxes with retrieved values
                    TitleBox.Text = blogpostToUpdate.Title
                    ContentBox.Text = blogpostToUpdate.Content
                End If
            End Sub

     </script>
    <asp:HiddenField ID="HiddenPostId" runat="server"/>



     <div>
    <h1 style = "text-align: center ">Create a new Post</h1>
    
</div>
    <div style = "text-align: center ">
    <label >Title</label>
    
    <asp:TextBox ID="TitleBox" runat="server" placeholder ="Title" />
    <label>Content</label>
    
    <asp:TextBox ID="ContentBox" runat="server" placeholder ="Content" />

    <asp:Button ID="btnSubmit" runat="server" Text="Submit" OnClick="Edit_Post_Button" />
    
        </div>

</asp:Content>
