<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="PersonalListArgument.aspx.cs" Inherits="PersonalListArgument" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="perimage" runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="perheader" runat="Server">
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="body" runat="Server">
    <%-- <div class="row">
        <i class="fa fa-user-o" aria-hidden="true"></i>
        <label>جستجو</label>
    </div>
    <div class="row">
        <div class="row">
            <div class="col-lg-6 col-md-6 col-sm-12 ">
                <label for="validationDefault01">نام</label>
                <asp:TextBox ID="txt_name" runat="server" CssClass="form-control fcss-fa" MaxLength="32" data-toggle="tooltip" data-placement="top" title="برای جستجو بهتر تمام فیلد ها را پر نمایید" ValidationGroup="inputdata"></asp:TextBox>
            </div><br />
            <div class="col-lg-6 col-md-6 col-sm-12">
                <label for="validationDefault02">نام خانوادگی</label>
                <asp:TextBox ID="txt_lastname" runat="server" CssClass="form-control fcss-fa" data-toggle="tooltip" data-placement="left" title="برای جستجو بهتر تمام فیلد ها را پر نمایید"></asp:TextBox>
            </div><br />
        </div><br />
        
        <div class="row">
            <div class="col-lg-6 col-md-6 col-sm-12 ">
                <label for="validationDefault04">ایمیل</label>
                <div class="input-group">
                    <span class="input-group-addon">
                        <i class="fa fa-envelope-o" aria-hidden="true"></i>
                    </span>
                    <asp:TextBox ID="txt_mail" runat="server" CssClass="form-control fcss-en"></asp:TextBox>
                </div>
            </div>
        </div>

    </div><br /><br />--%>

    <div class="ghj">
        <div class="row pr-3">
            <i class="fa fa-search" aria-hidden="true"></i>
            <label>جستجو</label>
        </div>
        <div class="row">
            <div class="col-lg-3">
                <label for="validationDefault01">نام</label>
                <asp:TextBox ID="txt_name" runat="server" CssClass="form-control fcss-fa" MaxLength="32" data-toggle="tooltip" data-placement="top" title="Tooltip on top" ValidationGroup="inputdata"></asp:TextBox>
            </div>
            <div class="col-lg-3">
                <label for="validationDefault02">نام خانوادگی</label>
                <asp:TextBox ID="txt_lastname" runat="server" CssClass="form-control fcss-fa" data-toggle="tooltip" data-placement="left" title="Tooltip on top"></asp:TextBox>
            </div>
        </div>
         <div class="row">
            <div class="col-lg-3">
                <label for="validationDefault01">ایمیل</label>
                <asp:TextBox ID="TextBox1" runat="server" CssClass="form-control fcss-en" MaxLength="32" data-toggle="tooltip" data-placement="top" title="Tooltip on top" ValidationGroup="inputdata"></asp:TextBox>
            </div>
            <div class="col-lg-3">
                <div class="btnsearch">
                    <asp:button ID="btnSearch" runat="server" Text="جستجو" OnClick="btnSearch_Click" CssClass="btn btn-primary btn-block" />
                </div>
            </div>
        </div>
        <div class="row">
            <asp:Label ID="lblshow" runat="server"></asp:Label>
        </div>
    </div>
    <div class="ghj ">
        <div class="row ">
            <div class="col-6 p-1 m-3 ">
                <div class="form-group row">
                    <label class="col-sm-2 col-form-label"><i class="fa fa-filter" aria-hidden="true"></i> مدرک تحصیلی</label>
                    <div class="col-sm-10">
                        <asp:DropDownList ID="ddlEducation" runat="server" CssClass="custom-select d-block w-100 form-control" AutoPostBack="true">
                            <asp:ListItem Text="انتخاب نمایید" Value=""></asp:ListItem>
                            <asp:ListItem Text="دیپلم" Value="دیپلم"></asp:ListItem>
                            <asp:ListItem Text="فوق دیپلم" Value="فوق دیپلم"></asp:ListItem>
                            <asp:ListItem Text="لیسانس" Value="لیسانس"></asp:ListItem>
                            <asp:ListItem Text="ارشد" Value="ارشد"></asp:ListItem>
                        </asp:DropDownList>
                    </div>
                </div>
            </div>
        </div>
        <div class="row">
            <asp:ListView ID="LVArgument" runat="server">
                <ItemTemplate>

                    <div class="col-lg-3 col-md-4 col-sm-12 ">
                        <div class="ColPerson alert alert-dark p-lg-2  p-sm-6">
                            <asp:Image runat="server" ID="imgArgument" ImageUrl='<%# System.Configuration.ConfigurationManager.AppSettings["PHOTO_UPLOAD_PATH"] +Eval("NCode") +Eval("Extention")%>' CssClass="ArgumentPic w-100" />
                            <br />
                            <br />
                            <div class="alert alert-info">
                                <asp:HyperLink runat="server" ID="lblNameArgument" NavigateUrl='<%#"~/personview.aspx?meli="+ Eval("NCode") %>'><%#Eval("FirstName") %></asp:HyperLink>
                                <asp:HyperLink runat="server" ID="Label1" NavigateUrl='<%#"~/personview.aspx?meli="+ Eval("NCode") %>'><%#Eval("LastName") %></asp:HyperLink>
                            </div>
                        </div>
                    </div>
                </ItemTemplate>
            </asp:ListView>
        </div>
    </div>
</asp:Content>

