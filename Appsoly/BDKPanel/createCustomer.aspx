<%@ Page Title="" Language="C#" MasterPageFile="~/BDKPanel/sindex.Master" AutoEventWireup="true" CodeBehind="createCustomer.aspx.cs" Inherits="Appsoly.BDKPanel.createCustomer" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="col-sm-12 col-xl-12">
        <div class="bg-secondary rounded h-100 p-4">
            <div class="form-floating mb-3">
                <asp:TextBox ID="tb_name" runat="server" CssClass="form-control mb-3" placeholder="Ad Soyad"></asp:TextBox>
                <label for="floatingInput">Ad Soyad</label>
            </div>
            <div class="form-floating mb-3">
                <asp:TextBox ID="tb_company" runat="server" CssClass="form-control mb-3" placeholder="Şirket"></asp:TextBox>
                <label for="floatingInput">Şirket</label>
            </div>
            <div class="form-floating mb-3">
                <asp:TextBox ID="tb_companyPosition" runat="server" CssClass="form-control mb-3" placeholder="Şirket Pozisyonu"></asp:TextBox>
                <label for="floatingInput">Şirket Pozisyonu</label>
            </div>
            <div class="form-floating mb-3">
                <asp:TextBox ID="tb_mail" runat="server" CssClass="form-control mb-3" placeholder="Mail Adresi"></asp:TextBox>
                <label for="floatingInput">Mail Adresi</label>
            </div>
            <div class="form-floating mb-3">
                <asp:TextBox ID="tb_phone" runat="server" CssClass="form-control mb-3" placeholder="Telefon Numarası"></asp:TextBox>
                <label for="floatingInput">Telefon Numarası</label>
            </div>
            <div class="mb-3">
                <label for="formFile" class="form-label">Logo</label>
                <asp:Image ID="img_image" runat="server" Style="width: 100px" />
                <br />
                <asp:FileUpload ID="fu_image" runat="server" CssClass="form-control bg-dark" AllowMultiple="true" />
            </div>
            <div class="form-floating mb-3">
                <asp:TextBox ID="tb_city" runat="server" CssClass="form-control mb-3" placeholder="Şehir"></asp:TextBox>
                <label for="floatingInput">Şehir</label>
            </div>
            <div class="mb-3">
                <asp:LinkButton ID="lbtn_create" runat="server" Text="EKLE" CssClass="btn btn-outline-primary w-100 p-4" OnClick="lbtn_create_Click"></asp:LinkButton>
            </div>
        </div>
    </div>
</asp:Content>
