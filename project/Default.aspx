<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <script>
        $(document).ready(function () {
            "use strict";
            //var demo = new countUp('lblTedadonline', 0, 1000, 0, 2.5);
            //window.onload = function () {
            //    demo.start();
            //}
            //if (!demo.error) {
            //    demo.start();
            //}
            //else {
            //    console.error(demo.error);
            //}
        });
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="perimage" runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="perheader" runat="Server">
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="body" runat="Server">
    <div class="col-lg-9 col-md-9 col-sm-9">

            <table>
                <tr>
                    <td>
                        <label for="lblTedadonline">افراد آنلاین:</label></td>
                    <td>
                        <asp:Label ID="lblTedadonline" runat="server" ClientIDMode="Static" />
                    </td>

                </tr>
                <tr>
                    <td>
                        <label for="lblVorodtime">زمان ورود:</label>
                    </td>
                    <td>
                        <asp:Label ID="lblVorodtime" runat="server"></asp:Label>
                    </td>

                </tr>
                <tr>
                    <td>
                        <label for="lblPasstime">زمان گذشته:</label>
                    </td>
                    <td>
                        <asp:Label ID="lblPasstime" runat="server"></asp:Label>
                    </td>

                </tr>
                <tr>
                    <td>
                        <label for="txt_nowtime">زمان باقی مانده:</label>
                    </td>
                    <td>
                        <asp:Label ID="lblVaziat" runat="server"></asp:Label><br />
                    </td>

                </tr>
                <tr>
                    <td>
                        <label for="lblNowtime">زمان فعلی:</label>
                    </td>
                    <td>
                        <asp:Label ID="lblNowtime" runat="server"></asp:Label><br />
                    </td>

                </tr>
                <tr>
                    <td>
                        <label for="txt_sabtenamiha">تعداد افراد ثبت نام شده:</label>
                    </td>
                    <td>
                        <asp:Label ID="lblSabtenamiha" runat="server"></asp:Label>
                    </td>
                </tr>
            </table>
        </div>
</asp:Content>

