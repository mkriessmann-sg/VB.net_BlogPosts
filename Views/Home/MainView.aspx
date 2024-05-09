<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Views/Shared/BlogSite.Master" CodeBehind="MainView.aspx.vb" Inherits="VB.net_BlogPosts.MainView" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolderBlog" runat="server">

       
    <h1 style = "text-align: center " >Main View</h1>

<asp:GridView ID="GridView1" runat="server" EnableModelValidation="True" Width="999px" style="margin-top: 0px" AutoGenerateColumns ="false">
    <Columns>   
        <asp:BoundField DataField ="title" HeaderText ="Title" />
        <asp:BoundField DataField ="content" HeaderText ="Content" />
        <asp:TemplateField>
            <ItemTemplate>
                <asp:LinkButton ID ="lnkDelete" Text ="Delete" runat ="server" CommandArgument ='<%#Eval("id")%>' OnClick="Delete_Post_Button"></asp:LinkButton>
            </ItemTemplate>

            <ItemTemplate>
                <asp:LinkButton ID ="lnkEdit" Text ="Edit" runat ="server" CommandArgument ='<%#Eval("id")%>' OnClick="Edit_Post_Button"></asp:LinkButton>
                <asp:LinkButton ID ="lnkDelete" Text ="Delete" runat ="server" CommandArgument ='<%#Eval("id")%>' OnClick="Delete_Post_Button"></asp:LinkButton>
</ItemTemplate>

        </asp:TemplateField>


    </Columns>

</asp:GridView>
  



<asp:ObjectDataSource ID="ObjectDataSource1" runat="server"></asp:ObjectDataSource>

<asp:SqlDataSource ID="SqlDataSource1" runat="server"></asp:SqlDataSource>
  

</asp:Content>
