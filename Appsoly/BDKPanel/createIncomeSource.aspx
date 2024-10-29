<%@ Page Title="" Language="C#" MasterPageFile="~/BDKPanel/sindex.Master" AutoEventWireup="true" CodeBehind="createIncomeSource.aspx.cs" Inherits="Appsoly.BDKPanel.createIncomeSource" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="col-sm-12 col-lg-12 col-xl-11 m-3 ">
        <div class="bg-secondary rounded h-100 p-4">
            <h6 class="mb-4">Floating Label</h6>
            <div class="form-floating mb-3">
                <asp:TextBox ID="tb_name" runat="server" CssClass="form-control" placeholder="Gelir Kaynağı"></asp:TextBox>
                <label for="floatingPassword">Gelir Kaynağı</label>
            </div>
            <div class="mb-3">
            </div>
            <asp:LinkButton ID="lbtn_create" runat="server" Text="EKLE" CssClass="btn btn-outline-primary w-100 p-2" OnClick="lbtn_create_Click"></asp:LinkButton>
        </div>
    </div>
</asp:Content>
