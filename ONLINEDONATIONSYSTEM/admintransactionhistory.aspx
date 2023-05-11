<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="admintransactionhistory.aspx.cs" Inherits="ONLINEDONATIONSYSTEM.admintransactionhistory" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <center>
  <h1>
      Transaction History
  </h1>
        <style type="text/css">
            #Gridview1
            {
                border-collapse:collapse;
                border:1px solid #0026ffff;


            }
             /* #Gridview1 th
              {
                  background-color:#0026ffff;
                  color:#dddddddd;
                  padding:5px 7px;
              }
              #Gridview1 tr:nth-child(2n+1)
              {
                  background-color:black;
                  color:white;
                  padding:3px;

              }*/

        </style>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString='<%$ ConnectionStrings:donationConnectionString2 %>' SelectCommand="SELECT * FROM [history]"></asp:SqlDataSource>
        <asp:GridView ID="GridView1" runat="server" DataSourceID="SqlDataSource1" OnRowDataBound="GridView1_RowDataBound" BackColor="Black" BorderColor="White" BorderStyle="Solid" Font-Bold="True" Font-Size="Medium" ForeColor="White" ShowFooter="True" Width="660px"></asp:GridView>

    </center>
    <center>
         <div>
                            <asp:LinkButton href ="afteradminlogin.aspx" ID="LinkButton1" runat="server">Back</asp:LinkButton>

    </div>
    </center>
   
</asp:Content>
