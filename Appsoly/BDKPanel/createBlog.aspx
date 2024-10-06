<%@ Page Title="" Language="C#" MasterPageFile="~/BDKPanel/sindex.Master" AutoEventWireup="true" CodeBehind="createBlog.aspx.cs" Inherits="Appsoly.BDKPanel.createBlog" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="col-sm-12 col-xl-12">
        <div class="bg-secondary rounded h-100 p-4">
            <div class="form-floating mb-3">
                <asp:TextBox ID="tb_title" runat="server" CssClass="form-control mb-3" placeholder="Başlık"></asp:TextBox>
                <label for="floatingInput">Başlık</label>
            </div>
            <div class="form-floating mb-3">
                <asp:TextBox ID="tb_brief" runat="server" CssClass="form-control"
                    TextMode="MultiLine" Style="height: 150px;" Placeholder="Özet"></asp:TextBox>
                <label for="floatingTextarea">Özet</label>
            </div>
            <div class="mb-3">
                <label for="formFile" class="form-label">ImgThumb</label>
                <asp:Image ID="img_imgThumb" runat="server" Style="width: 100px" /><br />
                <asp:FileUpload ID="fu_imgThumb" runat="server" CssClass="form-control bg-dark" AllowMultiple="true" />
            </div>
            <div class="mb-3">
                <label for="formFile" class="form-label">1. Görsel</label>
                <asp:Image ID="img_image1" runat="server" Style="width: 100px" /><br />
                <asp:FileUpload ID="fu_image1" runat="server" CssClass="form-control bg-dark" AllowMultiple="true" />
            </div>
            <div class="form-floating mb-3">
                <asp:TextBox ID="tb_content1" runat="server" CssClass="form-control"
                    TextMode="MultiLine" Style="height: 150px;" Placeholder="1. İçerik"></asp:TextBox>
                <label for="floatingTextarea">1. İçerik</label>
            </div>
            <div class="form-floating mb-3">
                <asp:TextBox ID="tb_content2" runat="server" CssClass="form-control"
                    TextMode="MultiLine" Style="height: 150px;" Placeholder="2. İçerik"></asp:TextBox>
                <label for="floatingTextarea">2. İçerik</label>
            </div>
            <div class="mb-3">
                <label for="formFile" class="form-label">2. Görsel</label>
                <asp:Image ID="img_image2" runat="server" Style="width: 100px" /><br />
                <asp:FileUpload ID="fu_image2" runat="server" CssClass="form-control bg-dark" AllowMultiple="true" />
            </div>
            <div class="form-floating mb-3">
                <asp:TextBox ID="tb_importantInformation" runat="server" CssClass="form-control"
                    TextMode="MultiLine" Style="height: 150px;" Placeholder="Önemli Bilgi"></asp:TextBox>
                <label for="floatingTextarea">Önemli Bilgi</label>
            </div>
            <div class="form-floating mb-3">
                <asp:TextBox ID="tb_content2Continued" runat="server" CssClass="form-control"
                    TextMode="MultiLine" Style="height: 150px;" Placeholder="2. İçerik Devamı"></asp:TextBox>
                <label for="floatingTextarea">2. İçerik Devamı</label>
            </div>
            <div class="form-floating mb-3">
                <asp:TextBox ID="tb_weld" runat="server" CssClass="form-control mb-3" placeholder="Kaynak"></asp:TextBox>
                <label for="floatingInput">Kaynak</label>
            </div>
            <div class="form-floating mb-3">
                <asp:DropDownList ID="ddl_service" runat="server" Enabled="true" CssClass="form-select mb-3" AppendDataBoundItems="true">
                    <asp:ListItem Text="Servisler" Value="0"></asp:ListItem>
                </asp:DropDownList>
            </div>
            <div class="form-floating mb-3">
                <asp:DropDownList ID="ddl_team" runat="server" Enabled="true" CssClass="form-select mb-3" AppendDataBoundItems="true">
                    <asp:ListItem Text="Ekip" Value="0"></asp:ListItem>
                </asp:DropDownList>
            </div>
            <div class="mb-3">
                <asp:LinkButton ID="lbtn_create" runat="server" Text="EKLE" CssClass="btn btn-outline-primary w-100 p-4" OnClick="lbtn_create_Click"></asp:LinkButton>
            </div>
        </div>
    </div>
</asp:Content>
