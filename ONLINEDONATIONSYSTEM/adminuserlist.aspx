<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="adminuserlist.aspx.cs" Inherits="ONLINEDONATIONSYSTEM.adminuserlist" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    </asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

     <center>
    <h1> User List</h1>
       </center>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString='<%$ ConnectionStrings:donationConnectionString %>' SelectCommand="SELECT * FROM [systemuser]"></asp:SqlDataSource>
   
     <asp:GridView ID="GridView1" runat="server" Width="928px" DataSourceID="SqlDataSource1" HorizontalAlign="Center" BackColor="Black" BorderColor="Black" BorderStyle="Solid" Font-Bold="True" ForeColor="White" ShowFooter="True">
     </asp:GridView>
   
     <center>
         <div>
                            <asp:LinkButton href ="afteradminlogin.aspx" ID="LinkButton1" runat="server">Back</asp:LinkButton>

    </div>
    </center>
</asp:Content>
