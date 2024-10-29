<%@ Page Title="" Language="C#" MasterPageFile="~/BDKPanel/sindex.Master" AutoEventWireup="true" CodeBehind="createDebts.aspx.cs" Inherits="Appsoly.BDKPanel.createDebts" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="col-sm-12 col-lg-12 col-xl-11 m-3 ">
        <div class="bg-secondary rounded h-100 p-4">
            <h6 class="mb-4">Floating Label</h6>
            <div class="form-floating mb-3">
                <asp:DropDownList ID="ddl_payee" runat="server" Enabled="true" CssClass="form-select mb-3" AppendDataBoundItems="true">
                    <asp:ListItem Text="Alacaklı" Value="0"></asp:ListItem>
                </asp:DropDownList>
            </div>
            <div class="form-floating mb-3">
                <asp:TextBox ID="tb_totalDebt" runat="server" CssClass="form-control" placeholder="Toplam Borç"></asp:TextBox>
                <label for="floatingInput">Toplam Borç</label>
            </div>
            <div class="form-floating mb-3">
                <asp:TextBox ID="tb_monthlyPayment" runat="server" CssClass="form-control" placeholder="Aylık Taksit Tutarı"></asp:TextBox>
                <label for="floatingInput">Aylık Taksit Tutarı</label>
            </div>
            <div class="mb-3">
                <asp:LinkButton ID="lbtn_create" runat="server" Text="EKLE" CssClass="btn btn-outline-primary w-100 p-4" OnClick="lbtn_create_Click"></asp:LinkButton>
            </div>
        </div>
    </div>
</asp:Content>
