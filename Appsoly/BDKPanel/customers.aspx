<%@ Page Title="" Language="C#" MasterPageFile="~/BDKPanel/sindex.Master" AutoEventWireup="true" CodeBehind="customers.aspx.cs" Inherits="Appsoly.BDKPanel.customers" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container-fluid pt-4 px-4">
        <div class="row g-4">
            <div class="col-lg-12 col-sm-12 col-xl-6" style="width: 100%">
                <div class="m-n2">
                    <a href="../BDKPanel/createCustomer.aspx" class="btn btn-outline-primary w-100 m-2" type="button">Müşteri EKLE</a>
                </div>
            </div>
            <div class="col-12">
                <div class="bg-secondary rounded h-100 p-4">
                    <h6 class="mb-4">BLOGLAR</h6>
                    <div class="table-responsive">
                        <asp:ListView ID="lv_listCustomers" runat="server" DataKeyNames="ID" OnItemCommand="lv_listCustomers_ItemCommand">
                            <LayoutTemplate>
                                <table class="table" cellpadding="0" cellspacing="0">
                                    <thead>
                                        <tr>
                                            <th scope="col">#</th>
                                            <th scope="col">Adı</th>
                                            <th scope="col">Şirket</th>
                                            <th scope="col">Şirket Pozisyonu</th>
                                            <th scope="col">Mail</th>
                                            <th scope="col">Telefon</th>
                                            <th scope="col">Resim</th>
                                            <th scope="col">Şehir</th>
                                            <th scope="col">Kayıt Tarihi</th>
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
                                    <td><%# Eval("Name") %></td>
                                    <td><%# Eval("Company") %></td>
                                    <td><%# Eval("CompanyPosition") %></td>
                                    <td><%# Eval("Mail") %></td>
                                    <td>
                                        <img src="../assets/images/customer/<%# Eval("Image") %>" width="30" />
                                    </td>
                                    <td><%# Eval("City") %></td>
                                    <td><%# ((DateTime)Eval("CreateDate")).ToString("dd.MM.yyyy") %></td>
                                    <td><%# Eval("StatusStr") %></td>

                                    <td>
                                        <a href='../AdminBilge/updateProduct.aspx?mid=<%# Eval("ID") %>' class="duzenle"><i class="fa fa-user-edit me-2"></i></a>
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
