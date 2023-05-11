<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="adminlogin.aspx.cs" Inherits="ONLINEDONATIONSYSTEM.adminlogin" %>
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
                                    <img width="150" src="images/login.jpg" />
                                </center>
                            </div>
                        </div>

                         <div class="row">
                            <div class="col">
                                <center>
                                   <h3> Admin Login</h3>
                                </center>
                            </div>
                        </div>
                         <div class="row">
                            <div class="col">
                                <label> ID </label>
                                 <div class="form-group">
                                     <asp:TextBox CssClass="form-control" ID="TextBox1" runat="server" placeholder="UserID"></asp:TextBox>
                                 </div>
                            </div>
                        </div>

                         <div class="row">
                            <div class="col">
                                <label>Password</label>
                                 <div class="form-group">
                                     <asp:TextBox CssClass="form-control" ID="TextBox2" runat="server" placeholder="Password" TextMode="Password"></asp:TextBox>
                                 </div>
                            </div>
                        </div>

                         <div class="form-group">
                             <asp:Button class=" btn btn-outline-primary btn-block btn-lg" ID="Button1" runat="server" Text="Login" OnClick="Button1_Click" />


                                 </div>

                   

                    </div>
                </div>
                            <asp:LinkButton href ="homepage.aspx" ID="LinkButton1" runat="server">Back</asp:LinkButton>

            </div>
        </div>
    </div>
</asp:Content>
