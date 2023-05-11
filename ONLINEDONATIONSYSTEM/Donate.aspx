<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Donate.aspx.cs" Inherits="ONLINEDONATIONSYSTEM.Donate" %>
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
                                   <h3> EVERY PENNY COUNTS</h3>
                                </center>
                            </div>
                        </div>
                         <div class="row">
                            <div class="col">
                                <label> Enter Recipient Id </label>
                                 <div class="form-group">
                                     <asp:TextBox CssClass="form-control" ID="TextBox1" runat="server" placeholder="00000"></asp:TextBox>
                                 </div>

        
                            </div>
                        </div>

                          <div class="row">
                            <div class="col">
                                <label> How much do you want to pay? </label>
                                 <div class="form-group">
                                     <asp:TextBox CssClass="form-control" ID="TextBox2" runat="server" placeholder="0-100000000000000"></asp:TextBox>
                                 </div>

        
                            </div>
                        </div>

                         <div class="form-group">
                             <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
                             <asp:Button class=" btn btn-primary btn-block btn-lg" ID="Button1" runat="server" Text="Donate" OnClick="Button1_Click" />


                                 </div>

                      

                    </div>
                </div>
                            <asp:LinkButton href ="afteruserlogin.aspx" ID="LinkButton1" runat="server">Back</asp:LinkButton>

            </div>
        </div>
    </div>


</asp:Content>
