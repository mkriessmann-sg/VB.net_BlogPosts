<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Views/Shared/BlogSite.Master" CodeBehind="Test Page.aspx.vb" Inherits="VB.net_BlogPosts.Test_Page"%>



<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolderBlog" runat="server">

    <%@ Import Namespace="DatabaseHandling"%>

    <h1>Test Page for all kinds of stuff</h1>

    <div>
    <h1 style = "text-align: center ">Create a new Post</h1>
    
</div>
    <div style = "text-align: center ">
    <label >Title</label>
    
    <asp:TextBox ID="TitleBox" runat="server" placeholder ="Title" />
    <label>Content</label>
    
    <asp:TextBox ID="ContentBox" runat="server" placeholder ="Content" />

    <asp:Button ID="btnSubmit1" runat="server" Text="Submit" OnClick="Add_Post_Button" />
    
        </div>
  

   
    <asp:GridView ID="GridView1" runat="server" EnableModelValidation="True" Width="999px" style="margin-top: 0px" AutoGenerateColumns ="false">
        <Columns>   
            <asp:BoundField DataField ="title" HeaderText ="Title" />
            <asp:BoundField DataField ="content" HeaderText ="Content" />
            <asp:TemplateField>
                <ItemTemplate>
                    
                </ItemTemplate>

            </asp:TemplateField>


        </Columns>

    </asp:GridView>
  

    

    <asp:ObjectDataSource ID="ObjectDataSource1" runat="server"></asp:ObjectDataSource>

    <asp:SqlDataSource ID="SqlDataSource1" runat="server"></asp:SqlDataSource>
  

    

</asp:Content>

