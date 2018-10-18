<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="PersonalList.aspx.cs" Inherits="PersonalList" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="perimage" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="perheader" runat="server">
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="body" runat="server">
    <asp:GridView ID="gvPerson" runat="server" AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" GridLines="None">
        <FooterStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
        <HeaderStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#666666" ForeColor="White" HorizontalAlign="Center" />
        <RowStyle BackColor="#E3EAEB" />
        <EditRowStyle BackColor="#7C6F57" />
        <AlternatingRowStyle BackColor="White" />
        <Columns>
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
        </Columns>
        <EmptyDataTemplate>
            اطلاعاتی برای نمایش موجود نیست
        </EmptyDataTemplate>
        <SelectedRowStyle BackColor="#C5BBAF" Font-Bold="True" ForeColor="#333333" />
        <SortedAscendingCellStyle BackColor="#F8FAFA" />
        <SortedAscendingHeaderStyle BackColor="#246B61" />
        <SortedDescendingCellStyle BackColor="#D4DFE1" />
        <SortedDescendingHeaderStyle BackColor="#15524A" />
    </asp:GridView>
    <asp:FormView runat="server" ID="FV1" AllowPaging="true">
        <ItemTemplate>
            <asp:Image ID="imageperson" runat="server" CssClass="card-img-top picsmall" />
            <asp:Panel ID="matn" runat="server" CssClass="m-4">
                <h5>نام:</h5>
                <asp:Label ID="txt_name2" runat="server" Text='<%# Eval("FirstName") %>' />
                <h5>نام خانوادگی:</h5>
                <asp:Label ID="txt_lastname2" runat="server" Text='<%# Eval("LastName") %>'></asp:Label>
                <h5>کدملی:</h5>
                <asp:Label ID="txt_codemeli2" runat="server" Text='<%# Eval("NCode") %>'></asp:Label>
                <h5>نام پدر:</h5>
                <asp:Label ID="txt_father" runat="server" Text='<%# Eval("FatherName") %>'></asp:Label>
                <h5>ایمیل:</h5>
                <asp:Label ID="tex_mail2" runat="server" Text='<%# Eval("Email") %>'></asp:Label>
                <h5>رشته تحصیلی:</h5>
                <asp:Label ID="txt_reshte2" runat="server" Text='<%# Eval("Major") %>'></asp:Label>
                <h5>مدرک تحصیلی:</h5>
                <asp:Label ID="txt_madrak2" runat="server" Text='<%# Eval("Education") %>'></asp:Label>
            </asp:Panel>
        </ItemTemplate>
        <EmptyDataTemplate>
            اطلاعاتی برای نمایش موجود نیست
        </EmptyDataTemplate>

    </asp:FormView>
    <asp:Repeater ID="Rp1" runat="server">
        <ItemTemplate>
            <asp:Panel ID="PanPersonality" runat="server" CssClass="panperson">
                <h5>نام:</h5>
                <asp:Label ID="txt_name2" runat="server" Text='<%# Eval("FirstName") %>' />
                <h5>نام خانوادگی:</h5>
                <asp:Label ID="txt_lastname2" runat="server" Text='<%# Eval("LastName") %>'></asp:Label>
                <h5>کدملی:</h5>
                <asp:Label ID="txt_codemeli2" runat="server" Text='<%# Eval("NCode") %>'></asp:Label>
            </asp:Panel>
        </ItemTemplate>
    </asp:Repeater>
    
</asp:Content>

