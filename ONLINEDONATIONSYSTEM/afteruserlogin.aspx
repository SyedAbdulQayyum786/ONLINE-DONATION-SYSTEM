<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="afteruserlogin.aspx.cs" Inherits="ONLINEDONATIONSYSTEM.afteruserlogin" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            margin-top: 28;
        }
    </style>
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
                                   <h3> Welcome Donor</h3>
                                </center>
                            </div>
                        </div>
                         <div class="row">
                            <div class="col">
                                <label> ID </label>
                                 <div class="form-group">
                                     <asp:TextBox CssClass="form-control" ID="TextBox1" runat="server" placeholder=""></asp:TextBox>
                                 </div>
                            </div>
                        </div>

                         <div class="row">
                            <div class="col">
                                <label> Name </label>
                                 <div class="form-group">
                                     <asp:TextBox CssClass="form-control" ID="TextBox2" runat="server" placeholder=""></asp:TextBox>
                                 </div>
                            </div>
                        </div>
                         <div class="row">
                            <div class="col">
                                <label> Remaining Amount </label>
                                 <div class="form-group">
                                     <asp:TextBox CssClass="form-control" ID="TextBox3" runat="server" placeholder=""></asp:TextBox>
                                 </div>
                            </div>
                        </div>

                         <div class="form-group">
                             <asp:Button class=" btn btn-outline-primary btn-block btn-lg"  ID="Button1" runat="server" Text="Donate" OnClick="Button1_Click" />


                                 </div>

                          <div class="form-group">

                             <asp:Button class=" btn btn-danger btn-block btn-lg"  ID="Button2" runat="server" Text="TransactionHistory" OnClick="Button2_Click" />


                                 </div>

                   

                    </div>
                </div>
                            <asp:LinkButton href ="login.aspx" ID="LinkButton1" runat="server">Back</asp:LinkButton>

            </div>
        </div>
    </div>

</asp:Content>
