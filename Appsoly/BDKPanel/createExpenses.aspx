<%@ Page Title="" Language="C#" MasterPageFile="~/BDKPanel/sindex.Master" AutoEventWireup="true" CodeBehind="createExpenses.aspx.cs" Inherits="Appsoly.BDKPanel.createExpenses" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <div class="col-sm-12 col-lg-12 col-xl-11 m-3 ">
        <div class="bg-secondary rounded h-100 p-4">
            <h6 class="mb-4">Floating Label</h6>
            <div class="form-floating mb-3">
                <asp:DropDownList ID="ddl_expensesSource" runat="server" Enabled="true" CssClass="form-select mb-3" AppendDataBoundItems="true">
                    <asp:ListItem Text="Gider Kaynağı" Value="0"></asp:ListItem>
                </asp:DropDownList>
            </div>
            <div class="form-floating mb-3">
                <asp:TextBox ID="tb_incomeFee" runat="server" CssClass="form-control" placeholder="Giden Ücret"></asp:TextBox>
                <label for="floatingInput">Giden Ücret</label>
            </div>
            <div class="form-floating mb-3">
                <asp:TextBox ID="tb_description" runat="server" CssClass="form-control" placeholder="Açıklama"></asp:TextBox>
                <label for="floatingInput">Açıklama</label>
            </div>
            <div class="mb-3">
                <asp:LinkButton ID="lbtn_create" runat="server" Text="EKLE" CssClass="btn btn-outline-primary w-100 p-4" OnClick="lbtn_create_Click"></asp:LinkButton>
            </div>
        </div>
    </div>
</asp:Content>
