<%@ Page Title="" Language="C#" MasterPageFile="~/BDKPanel/sindex.Master" AutoEventWireup="true" CodeBehind="monthlyPayments.aspx.cs" Inherits="Appsoly.BDKPanel.monthlyPayments" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container mt-3">
        <div class="row">
            <div class="col-12">
                <div class="bg-secondary rounded h-100 p-4">
                    <h6 class="mb-4">Alacaklı Tablosu</h6>
                    <div class="table-responsive">
                        <asp:ListView ID="lv_monthlyPayment" runat="server" DataKeyNames="ID" OnItemCommand="lv_monthlyPayment_ItemCommand">
                            <LayoutTemplate>
                                <table class="table" cellpadding="0" cellspacing="0">
                                    <thead>
                                        <tr>
                                            <th scope="col">#</th>
                                            <th scope="col">Borç</th>
                                            <th scope="col">Aylık Ödeme</th>
                                            <th scope="col">Ödenecek Tarih</th>
                                            <th scope="col">Ödendi mi?</th>
                                            <th scope="col">Seçenekler</th>
                                        </tr>
                                    </thead>
                                    <tbody>
                                        <asp:PlaceHolder ID="ItemPlaceHolder" runat="server"></asp:PlaceHolder>
                                    </tbody>
                                </table>
                            </LayoutTemplate>
                            <ItemTemplate>
                                <tr>
                                    <th scope="row"><%# Eval("ID") %></th>
                                    <td><%# Eval("Payee") %></td>
                                    <td><%# Eval("MonthlyPayment") %></td>
                                    <td><%# Eval("InstallmentDate", "{0:dd.MM.yyyy}") %></td>
                                    <td><%# Eval("StatusStr") %></td>
                                    <td>
                                        <asp:LinkButton ID="lbtn_statusToggle" runat="server" CssClass="toggle-status"
                                            CommandArgument='<%# Eval("ID") %>' CommandName="toggleStatus"><i class="fa fa-toggle-on"></i></asp:LinkButton>
                                    </td>
                                </tr>
                            </ItemTemplate>
                        </asp:ListView>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
