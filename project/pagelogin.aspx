<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="pagelogin.aspx.cs" Inherits="pagelogin" %>

<asp:content id="Content1" contentplaceholderid="head" runat="Server">
</asp:content>
<asp:content id="Content2" contentplaceholderid="perimage" runat="Server">
</asp:content>
<asp:content id="Content3" contentplaceholderid="perheader" runat="Server">
</asp:content>
<asp:content id="Content4" contentplaceholderid="body" runat="Server">
    <div class="row justify-content-center">
        <div class="col-lg-3 col-md-4 col-sm-9 p-5">
            <label for="exampleInputEmail1">Username</label>
            <div class="input-group">
                <span class="input-group-addon">
                   <i class="fa fa-user-o" aria-hidden="true"></i>
                </span>
                <asp:TextBox ID="username" CssClass="form-control" runat="server"></asp:TextBox>

            </div>
                <label for="exampleInputPassword1">Password</label>
            <div class="input-group">
                <span class="input-group-addon">
                   <i class="fa fa-key" aria-hidden="true"></i>
                </span>
                <asp:TextBox ID="password" CssClass="form-control" runat="server"></asp:TextBox>
            </div><br />
            <asp:Button ID="btnEnter" runat="server" Text="ورود" OnClick="btnEnter_Click" CssClass="my-btn" />
            <asp:Label ID="lbl_show" runat="server"></asp:Label>
        </div>
    </div>


</asp:content>

