<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="personview.aspx.cs" Inherits="personview" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="perimage" runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="perheader" runat="Server">
    نمایش اطلاعات فردی
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="body" runat="Server">
    <div class="certainbox">

        <asp:Image ID="imageperson" runat="server" CssClass="card-img-top picsmall" />
        <asp:Panel ID="matn" runat="server" CssClass="m-4">
            <h5>نام:</h5>
            <asp:Label ID="txt_name2" runat="server"></asp:Label>
            <h5>نام خانوادگی:</h5>
            <asp:Label ID="txt_lastname2" runat="server"></asp:Label>
            <h5>کدملی:</h5>
            <asp:Label ID="txt_codemeli2" runat="server"></asp:Label>
            <h5>نام پدر:</h5>
            <asp:Label ID="txt_father" runat="server"></asp:Label>
            <h5>ایمیل:</h5>
            <asp:Label ID="tex_mail2" runat="server"></asp:Label>
            <h5>رشته تحصیلی:</h5>
            <asp:Label ID="txt_reshte2" runat="server"></asp:Label>
            <h5>مدرک تحصیلی:</h5>
            <asp:Label ID="txt_madrak2" runat="server"></asp:Label>
        </asp:Panel>
    </div>
</asp:Content>

