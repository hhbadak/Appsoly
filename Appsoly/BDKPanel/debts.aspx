<%@ Page Title="" Language="C#" MasterPageFile="~/BDKPanel/sindex.Master" AutoEventWireup="true" CodeBehind="debts.aspx.cs" Inherits="Appsoly.BDKPanel.debts" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container mt-3 mb-3">
        <div class="row">
            <div class="col-12">
                <a type="button" class="btn btn-outline-primary m-2" href="../BDKPanel/createDebts.aspx"><i class="fa fa-money-bill-alt me-2"></i>Borç Ekle</a>
            </div>
            <div class="col-12">
                <a type="button" class="btn btn-outline-primary m-2" href="../BDKPanel/createDebtDetail.aspx"><i class="fa fa-money-bill-alt me-2"></i>Taksitli Borç Ekle</a>
            </div>
        </div>
    </div>
    <div class="container mt-3">
        <div class="row">
            <div class="col-12">
                <div class="bg-secondary rounded h-100 p-4">
                    <h6 class="mb-4">Alacaklı Tablosu</h6>
                    <div class="table-responsive">
                        <asp:ListView ID="lv_debts" runat="server" DataKeyNames="ID" OnItemCommand="lv_debts_ItemCommand">
                            <LayoutTemplate>
                                <table class="table" cellpadding="0" cellspacing="0">
                                    <thead>
                                        <tr>
                                            <th scope="col">#</th>
                                            <th scope="col">Alacaklı</th>
                                            <th scope="col">Toplam Borç</th>
                                            <th scope="col">Aylık Ödeme</th>
                                            <th scope="col">Durum</th>
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
                                    <td><%# Eval("TotalDebt") %></td>
                                    <td><%# Eval("MonthlyPayment") %></td>
                                    <td><%# Eval("Statu") %></td>
                                    <td>
                                         <a href='../BDKPanel/debtDetail.aspx?detailID=<%# Eval("ID") %>' class="duzenle"><i class="fa fa-list"></i></a>
                                        
                                        <asp:LinkButton ID="lbtn_sil" runat="server" CssClass="sil" CommandArgument='<%# Eval("ID") %>' CommandName="delete"><i class="fa fa-trash"></i></asp:LinkButton>
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
