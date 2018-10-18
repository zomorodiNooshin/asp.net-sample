<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="PersonalList2.aspx.cs" Inherits="PersonalList2"
    Title="" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="perimage" runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="perheader" runat="Server">
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="body" runat="Server">
    <asp:ListView ID="LV1" runat="server">
        <ItemTemplate>
            <table class="myitem">

                <tr>
                    <td>نام</td>
                    <td>

                        <asp:Label runat="server" ID="lblName1"><%#Eval("FirstName") %></asp:Label>

                    </td>
                </tr>
                <tr>
                    <td>نام خانوادگی</td>
                    <td>
                        <asp:Label runat="server" ID="lblLastname2"><%#Eval("LastName") %></asp:Label>

                    </td>
                </tr>
                <tr>
                    <td>کدملی</td>
                    <td>
                        <asp:Label runat="server" ID="lblNcode3"><%#Eval("NCode") %></asp:Label>
                    </td>
                </tr>
            </table>

        </ItemTemplate>

    </asp:ListView>
    <br />
    <br />
    <asp:ListView ID="LV2" runat="server">
        <LayoutTemplate>
            <%--            برای آنکه عنوان ستون ها تکرار نشود از لی آت تمپلیت استفاده می کنیم و یک جدول قرار می دهیم که چون قرار تغییر کند پس بهش ران ات می دهیم و آی دی وتی آر دوم چون --%>
            <%--قرار نام و ... را جای گذاری کند یک آی دی آیتم پلیس هولدر استفاده می کنیم که میفهمد که قرار است جایگذاری کند.--%>
            <table runat="server" id="tblProducts">
                <tr>
                    <td>نام</td>
                    <td>نام خانوادگی</td>
                    <td>کدملی</td>
                </tr>
                <tr runat="server" id="itemPlaceholder">
                </tr>
            </table>
        </LayoutTemplate>
        <ItemTemplate>
            <tr>
                <td>
                    <asp:Label runat="server" ID="lblName"><%#Eval("FirstName") %></asp:Label>
                </td>
                <td>
                    <asp:Label runat="server" ID="lblLastname"><%#Eval("LastName") %></asp:Label>
                </td>
                <td>
                    <asp:Label runat="server" ID="lblNcode"><%#Eval("NCode") %></asp:Label>
                </td>
            </tr>
        </ItemTemplate>
    </asp:ListView>
    <br />
    <asp:DetailsView ID="DV1" runat="server" AutoGenerateInsertButton="True" AutoGenerateRows="False" 
        BackColor="#DEBA84" BorderColor="#DEBA84" BorderStyle="None" BorderWidth="1px" CellPadding="3" CellSpacing="2">
        <EditRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="White" />
        <Fields>
            <asp:BoundField DataField="FirstName" HeaderText="نام" />
            <asp:BoundField DataField="LastName" HeaderText="نام خانوادگی" />
            <asp:BoundField DataField="FatherName" HeaderText="نام پدر" />
            <asp:BoundField DataField="NCode" HeaderText="کد ملی" />
            <asp:BoundField DataField="Tell" HeaderText="شماره تماس" />
            <asp:BoundField DataField="Email" HeaderText="ایمیل" />
            <asp:BoundField DataField="Major" HeaderText="رشته تحصیلی" />
            <asp:BoundField DataField="Education" HeaderText="تحصیلات" />
            <asp:BoundField DataField="Birthday" HeaderText="تاریخ تولد" />
            <asp:BoundField DataField="Gender" HeaderText="جنسیت" />
        </Fields>
        <FooterStyle BackColor="#F7DFB5" ForeColor="#8C4510" />
        <FooterTemplate>
            فوتر
        </FooterTemplate>
        <HeaderStyle BackColor="#A55129" Font-Bold="True" ForeColor="White" />
        <PagerStyle ForeColor="#8C4510" HorizontalAlign="Center" />
        <RowStyle BackColor="#FFF7E7" ForeColor="#8C4510" />
    </asp:DetailsView>
</asp:Content>

