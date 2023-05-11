<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="afteradminlogin.aspx.cs" Inherits="ONLINEDONATIONSYSTEM.afteradminlogin" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <div class="row">
            <div class="col-md-6 mx-auto">
                <div class="card">
                    <div class="card-body">
                        

                         <div class="row">
                            <div class="col">
                                <center>
                                   <h3> Welcome Admin</h3>
                                </center>
                            </div>
                        </div>
                   
                        
                        <div class="form-group">
                             <asp:Button class=" btn btn-outline-primary btn-block btn-lg" ID="Button2" runat="server" Text="UserList" OnClick="Button2_Click" />


                                 </div>
                     
                         <div class="form-group">
                             <asp:Button class=" btn btn-outline-primary btn-block btn-lg" ID="Button1" runat="server" Text="TransactionHistory" OnClick="Button1_Click" />


                                 </div>


                   

                    </div>
                </div>
                            <asp:LinkButton href ="adminlogin.aspx" ID="LinkButton1" runat="server">Back</asp:LinkButton>

            </div>
        </div>
    </div>
</asp:Content>
