<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="usertransactionhistory.aspx.cs" Inherits="ONLINEDONATIONSYSTEM.usertransactionhistory" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
      <center>
  <h1>
      Transaction History
  </h1>
          <asp:GridView ID="GridView1" runat="server" BackColor="Black" BorderColor="White" BorderStyle="Solid" Font-Bold="True" ForeColor="White" Width="605px"></asp:GridView>
       
    </center>

    <div>
        <center>
                                        <asp:LinkButton href ="afteruserlogin.aspx" ID="LinkButton1" runat="server" ForeColor="Black">Back</asp:LinkButton>

        </center>
    </div>
</asp:Content>
