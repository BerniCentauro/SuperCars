<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebInterface.Home.Default" %>

<%@ Import Namespace="WebInterface.SuperCarsService" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <div class="page-header">
        <h1>Vehículos en Venta</h1>
    </div>

    <asp:ListView ID="lstVehicles" runat="server">
        <LayoutTemplate>
            <div class="row vehicles-list">
                <asp:PlaceHolder ID="itemPlaceHolder" runat="server" />
            </div>
        </LayoutTemplate>
        <ItemTemplate>
            <div class="col-xs-3" >
                <div class="thumbnail">
                    <img src="<%#((Vehicle)Container.DataItem).Url%>">
                    <div class="caption">
                        <h3><%#((Vehicle)Container.DataItem).Title%></h3>
                        <p><%#((Vehicle)Container.DataItem).Description%></p>
                    </div>
                </div>
            </div>
        </ItemTemplate>
    </asp:ListView>
</asp:Content>
