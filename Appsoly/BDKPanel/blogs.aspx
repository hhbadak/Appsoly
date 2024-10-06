<%@ Page Title="" Language="C#" MasterPageFile="~/BDKPanel/sindex.Master" AutoEventWireup="true" CodeBehind="blogs.aspx.cs" Inherits="Appsoly.BDKPanel.blogs" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container-fluid pt-4 px-4">
        <div class="row g-4">
            <div class="col-lg-12 col-sm-12 col-xl-6" style="width: 100%">
                <div class="m-n2">
                    <a href="../BDKPanel/createBlog.aspx" class="btn btn-outline-primary w-100 m-2" type="button">Blog EKLE</a>
                </div>
            </div>
            <div class="col-12">
                <div class="bg-secondary rounded h-100 p-4">
                    <h6 class="mb-4">BLOGLAR</h6>
                    <div class="table-responsive">
                        <asp:ListView ID="lv_listblog" runat="server" DataKeyNames="ID" OnItemCommand="lv_listblog_ItemCommand">
                            <LayoutTemplate>
                                <table class="table" cellpadding="0" cellspacing="0">
                                    <thead>
                                        <tr>
                                            <th scope="col">#</th>
                                            <th scope="col">Başlk</th>
                                            <th scope="col">Özet</th>
                                            <th scope="col">ImgThumb</th>
                                            <th scope="col">Resim 1</th>
                                            <th scope="col">İçerik 1</th>
                                            <th scope="col">İçerik 2</th>
                                            <th scope="col">Resim 2</th>
                                            <th scope="col">Önemli Bilgi</th>
                                            <th scope="col">İçerik 2 Devamı</th>
                                            <th scope="col">Kaynak</th>
                                            <th scope="col">Servis</th>
                                            <th scope="col">Tarih</th>
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
                                    <td><%# Eval("Title") %></td>
                                    <td><%# Eval("Brief") %></td>
                                    <td>
                                        <img src="../assets/images/blog/imgThumb/<%# Eval("ImgThumb") %>" width="30" /></td>
                                    <td>
                                        <img src="../assets/images/blog/images/<%# Eval("Image1") %>" width="30" /></td>
                                    <td><%# Eval("Contents1") %></td>
                                    <td><%# Eval("Contents2") %></td>
                                    <td>
                                        <img src="../assets/images/blog/images/<%# Eval("Image2") %>" width="30" /></td>
                                    <td><%# Eval("ImportantInformation") %></td>
                                    <td><%# Eval("Content2Continued") %></td>
                                    <td><%# Eval("Weld") %></td>
                                    <td><%# Eval("Service") %></td>
                                    <td><%# ((DateTime)Eval("Date")).ToString("dd.MM.yyyy") %></td>

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
