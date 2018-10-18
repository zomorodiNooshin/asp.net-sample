<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="search.aspx.cs" Inherits="search" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="perimage" runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="perheader" runat="Server">
    جستجو
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="body" runat="Server">
    <div class="certainbox">
        <div class="row m-4">
            <div class="col-3">
                <label for="entercode" class="sr-only">کد ملی</label>
                <asp:TextBox ID="entercode" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <div class="col-9">
                <asp:Button ID="searchcode" runat="server" CssClass="btn btn-primary" Text="جستجو" OnClick="searchcode_Click" />
            </div>
        </div>
    </div>
</asp:Content>

