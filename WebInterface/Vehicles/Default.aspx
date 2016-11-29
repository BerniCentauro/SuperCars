<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebInterface.Default" %>
<%@ Import NameSpace="WebInterface.SuperCarsService" %> 
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <div class="page-header">
        <h1>Vehículos</h1>
    </div>

    <a class="btn btn-primary" href="/Vehicles/Add.aspx">
        <i class="glyphicon glyphicon-plus"></i> Nuevo
    </a>

    <div class="push push-xs"></div>

    <asp:GridView ID="grdVehicles" CssClass="table table-bordered table-striped table-hover" runat="server" AutoGenerateSelectButton="true" OnSelectedIndexChanging="grdVehicles_SelectedIndexChanging" OnRowEditing="grdVehicles_RowEditing" OnRowDeleting="grdVehicles_RowDeleting"></asp:GridView>
    
    <asp:ListView ID="lstPages" runat="server">
        <LayoutTemplate>
            <ul class="pagination">
                <asp:PlaceHolder ID="itemPlaceHolder" runat="server" />
            </ul>
        </LayoutTemplate>
        <ItemTemplate>
            <li>
                <a href="?page=<%#Container.DataItem%>">
                    <%#Container.DataItem%>
                </a>
            </li>
        </ItemTemplate>
    </asp:ListView>

</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="Scripts" runat="server">
</asp:Content>
