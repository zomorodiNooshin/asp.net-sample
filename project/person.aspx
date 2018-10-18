<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="person.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <script>
        $(document).ready(function () {
            $("#txt_address").autosize();
            $("#txt_tell").mask("(+99)999999999", { placeholder: "_" });
            new WOW().init();
            $('[data-toggle="tooltip"]').tooltip();



        });
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="perimage" runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="perheader" runat="Server">
    اطلاعات فردی
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="body" runat="Server">
    <div class="container bg-white p-3">
        <div class="row">
            <div class="col-lg-7 col-sm-12  wow zoomIn" data-wow-delay="500ms" data-wow-duration="3s">
                <div class="row">
                    <div class="col-lg-6 col-md-6 col-sm-12 ">
                        <label for="validationDefault01">نام</label>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="*" ControlToValidate="txt_name" CssClass="text-danger" ValidationGroup="inputdata"></asp:RequiredFieldValidator>
                        <asp:TextBox ID="txt_name" runat="server" CssClass="form-control fcss-fa" MaxLength="32" data-toggle="tooltip" data-placement="top" title="Tooltip on top" ValidationGroup="inputdata"></asp:TextBox>
                    </div>
                    <div class="col-lg-6 col-md-6 col-sm-12">
                        <label for="validationDefault02">نام خانوادگی</label>
                        <asp:TextBox ID="txt_lastname" runat="server" CssClass="form-control fcss-fa" data-toggle="tooltip" data-placement="left" title="Tooltip on top"></asp:TextBox>
                    </div>
                </div>
                <div class="row">
                    <div class="col-md-6">
                        <label for="validationDefault03">کدملی/کد فراگیر اتباع خارجی</label>
                        <asp:TextBox ID="txt_codemeli" runat="server" CssClass="form-control fcss-no"></asp:TextBox>
                    </div>
                    <div class="col-md-3">
                        <label for="validationDefault04">نام پدر</label>
                        <asp:TextBox ID="txt_father" runat="server" CssClass="form-control fcss-fa"></asp:TextBox>
                    </div>
                    <div class="col-md-3">
                        <label for="rblGender">جنسیت</label><br />
                        <asp:RadioButtonList ID="rblGender" runat="server" RepeatDirection="Horizontal">
                            <asp:ListItem Text=" مرد" Value="male" Selected="True"></asp:ListItem>
                            <asp:ListItem Text=" زن" Value="female"></asp:ListItem>
                        </asp:RadioButtonList>
                    </div>
                </div>
                <div class="row">
                    <div class="col-md-6">
                        <label for="validationDefault04">شماره همراه</label>
                        <asp:TextBox ID="txt_tell" runat="server" CssClass="form-control fcss-no"></asp:TextBox>
                    </div>
                    <div class="col-md-6">
                        <label for="validationDefault04">ایمیل</label>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="*" CssClass="text-danger" ControlToValidate="txt_mail" ValidationGroup="inputdata"></asp:RequiredFieldValidator>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ErrorMessage="ایمیل صحیح را وارد کنید" ControlToValidate="txt_mail" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" ValidationGroup="inputdata"></asp:RegularExpressionValidator>
                        <div class="input-group">
                            <span class="input-group-addon">
                                <i class="fa fa-envelope-o" aria-hidden="true"></i>
                            </span>
                            <asp:TextBox ID="txt_mail" runat="server" CssClass="form-control fcss-en"></asp:TextBox>
                        </div>
                    </div>
                </div>
                <div class="row">
                    <div class="col-md-12">
                        <label for="validationDefault03">آدرس</label>
                        <asp:TextBox ID="txt_address" runat="server" TextMode="MultiLine" CssClass="form-control css-fa csautosize" data-maxlength='64'></asp:TextBox>
                        <span class="maxlength-remain"></span>
                    </div>

                </div>
                <label for="validationDefault03">تاریخ تولد</label>
                <div class="row">
                    <div class="col-lg-4 col-md-4 col-sm-12">
                        <asp:DropDownList ID="day" runat="server" CssClass="form-control">
                            <asp:ListItem Text="1" Value="1"></asp:ListItem>
                            <asp:ListItem Text="2" Value="2"></asp:ListItem>
                            <asp:ListItem Text="3" Value="3"></asp:ListItem>
                            <asp:ListItem Text="4" Value="4"></asp:ListItem>
                            <asp:ListItem Text="5" Value="5"></asp:ListItem>
                            <asp:ListItem Text="6" Value="6"></asp:ListItem>
                            <asp:ListItem Text="7" Value="7"></asp:ListItem>
                            <asp:ListItem Text="8" Value="8"></asp:ListItem>
                            <asp:ListItem Text="9" Value="9"></asp:ListItem>
                            <asp:ListItem Text="10" Value="10"></asp:ListItem>
                            <asp:ListItem Text="11" Value="11"></asp:ListItem>
                            <asp:ListItem Text="12" Value="12"></asp:ListItem>
                            <asp:ListItem Text="13" Value="13"></asp:ListItem>
                            <asp:ListItem Text="14" Value="14"></asp:ListItem>
                            <asp:ListItem Text="15" Value="15"></asp:ListItem>
                            <asp:ListItem Text="16" Value="16"></asp:ListItem>
                            <asp:ListItem Text="17" Value="17"></asp:ListItem>
                            <asp:ListItem Text="18" Value="18"></asp:ListItem>
                            <asp:ListItem Text="19" Value="19"></asp:ListItem>
                            <asp:ListItem Text="20" Value="20"></asp:ListItem>
                            <asp:ListItem Text="21" Value="21"></asp:ListItem>
                            <asp:ListItem Text="22" Value="22"></asp:ListItem>
                            <asp:ListItem Text="23" Value="23"></asp:ListItem>
                            <asp:ListItem Text="24" Value="24"></asp:ListItem>
                            <asp:ListItem Text="25" Value="25"></asp:ListItem>
                            <asp:ListItem Text="26" Value="26"></asp:ListItem>
                            <asp:ListItem Text="27" Value="27"></asp:ListItem>
                            <asp:ListItem Text="28" Value="28"></asp:ListItem>
                            <asp:ListItem Text="29" Value="29"></asp:ListItem>
                            <asp:ListItem Text="30" Value="30"></asp:ListItem>
                            <asp:ListItem Text="31" Value="31"></asp:ListItem>

                        </asp:DropDownList>
                    </div>
                    <div class="col-lg-4 col-md-4 col-sm-12">
                        <asp:DropDownList ID="month" runat="server" CssClass="form-control">
                            <asp:ListItem Text="فروردین" Value="فروردین"></asp:ListItem>
                            <asp:ListItem Text="اردیبهشت" Value="اردیبهشت"></asp:ListItem>
                            <asp:ListItem Text="خرداد" Value="خرداد"></asp:ListItem>
                            <asp:ListItem Text="تیر" Value="تیر"></asp:ListItem>
                            <asp:ListItem Text="مرداد" Value="مرداد"></asp:ListItem>
                            <asp:ListItem Text="شهریور" Value="شهریور"></asp:ListItem>
                            <asp:ListItem Text="مهر" Value="مهر"></asp:ListItem>
                            <asp:ListItem Text="آبان" Value="آبان"></asp:ListItem>
                            <asp:ListItem Text="آذر" Value="آذر"></asp:ListItem>
                            <asp:ListItem Text="دی" Value="دی"></asp:ListItem>
                            <asp:ListItem Text="بهمن" Value="بهمن"></asp:ListItem>
                            <asp:ListItem Text="اسفند" Value="اسفند"></asp:ListItem>
                        </asp:DropDownList>
                    </div>
                    <div class="col-lg-4 col-md-4 col-sm-12">
                        <asp:DropDownList ID="year" runat="server" CssClass="form-control">
                            <asp:ListItem Text="1380" Value="1380"></asp:ListItem>
                            <asp:ListItem Text="1379" Value="1379"></asp:ListItem>
                            <asp:ListItem Text="1378" Value="1378"></asp:ListItem>
                            <asp:ListItem Text="1377" Value="1377"></asp:ListItem>
                            <asp:ListItem Text="1376" Value="1376"></asp:ListItem>
                            <asp:ListItem Text="1375" Value="1375"></asp:ListItem>
                            <asp:ListItem Text="1374" Value="1374"></asp:ListItem>
                            <asp:ListItem Text="1373" Value="1373"></asp:ListItem>
                            <asp:ListItem Text="1372" Value="1372"></asp:ListItem>
                            <asp:ListItem Text="1371" Value="1371"></asp:ListItem>
                            <asp:ListItem Text="1370" Value="1370"></asp:ListItem>
                            <asp:ListItem Text="1369" Value="1369"></asp:ListItem>
                            <asp:ListItem Text="1368" Value="1368"></asp:ListItem>
                            <asp:ListItem Text="1367" Value="1367"></asp:ListItem>
                            <asp:ListItem Text="1366" Value="1366"></asp:ListItem>
                        </asp:DropDownList>
                    </div>
                </div>
                <br />
                <div class="row">
                    <div class="col-lg-6 col-md-6 col-sm-12">
                        <asp:DropDownList ID="reshte" runat="server" CssClass="custom-select hi d-block  w-100">
                            <asp:ListItem Text="علوم پایه و مهندسی" Value="علوم پایه و مهندسی"></asp:ListItem>
                            <asp:ListItem Text="علوم انسانی" Value="علوم انسانی"></asp:ListItem>
                            <asp:ListItem Text="حقوق" Value="حقوق"></asp:ListItem>
                        </asp:DropDownList><br />
                    </div>
                    <div class="col-lg-6 col-md-6 col-sm-12">
                        <asp:DropDownList ID="madrak" runat="server" CssClass="custom-select d-block w-100">
                            <asp:ListItem Text="دیپلم" Value="دیپلم"></asp:ListItem>
                            <asp:ListItem Text="فوق دیپلم" Value="فوق دیپلم"></asp:ListItem>
                            <asp:ListItem Text="لیسانس" Value="لیسانس"></asp:ListItem>
                            <asp:ListItem Text="ارشد" Value="ارشد"></asp:ListItem>
                        </asp:DropDownList>
                    </div>
                </div>

            </div>
            <div class="col-lg-5 col-sm-12 wow zoomIn" data-wow-delay="500ms" data-wow-duration="3s">
                <div class="form-group">
                    <h4>عکس:</h4>
                    <br />
                    <asp:FileUpload ID="fuPhoto" CssClass="form-control form-control-m" runat="server" />
                    <asp:Label ID="lblMessage" runat="server" />
                    <asp:Label ID="lblshow" runat="server" />

                </div>
            </div>
        </div>


        <div class="row m-2">
            <asp:Button ID="btn_save" runat="server" CssClass="btn btn-outline-primary" Text="به روز رسانی" OnClick="btn_save_Click" ValidationGroup="inputdata"/>
            <asp:Button ID="btn_cansel" runat="server" CssClass="btn btn-outline-secondary" Text="انصراف" />
        </div>
        <div class="row justify-content-right">
            <div class="col-lg-3">
                زمان ورود:
    <asp:Label ID="lbl_entertime" runat="server"></asp:Label><br />
                زمان گذشته:
    <asp:Label ID="Label1" runat="server"></asp:Label><br />
                زمان فعلی:
    <asp:Label ID="Label2" runat="server"></asp:Label>
            </div>
        </div>

    </div>
    <br />
    <br />



</asp:Content>

