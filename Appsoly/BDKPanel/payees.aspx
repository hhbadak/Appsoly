<%@ Page Title="" Language="C#" MasterPageFile="~/BDKPanel/sindex.Master" AutoEventWireup="true" CodeBehind="payees.aspx.cs" Inherits="Appsoly.BDKPanel.payees" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container mt-3 mb-3">
        <div class="row">
            <div class="col-12">
                <a type="button" class="btn btn-outline-primary m-2" href="../BDKPanel/createPayee.aspx"><i class="fa fa-money-bill-alt me-2"></i>Alacaklı Ekle</a>
            </div>
        </div>
    </div>
    <div class="container mt-3">
        <div class="row">
            <div class="col-12">
                <div class="bg-secondary rounded h-100 p-4">
                    <h6 class="mb-4">Alacaklı Tablosu</h6>
                    <div class="table-responsive">
                        <asp:ListView ID="lv_payees" runat="server" DataKeyNames="ID" OnItemCommand="lv_payees_ItemCommand">
                            <LayoutTemplate>
                                <table class="table" cellpadding="0" cellspacing="0">
                                    <thead>
                                        <tr>
                                            <th scope="col">#</th>
                                            <th scope="col">Alacaklı</th>
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
                                    <td><%# Eval("Name") %></td>
                                    <td>
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
