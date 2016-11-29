<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Add.aspx.cs" Inherits="WebInterface.Vehicles.Add" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <div class="page-header">
        <h1>Nuevo Vehículo</h1>
    </div>

    <ul class="nav nav-pills nav-justified">
        <li class="active"><a href="#stepOne" data-toggle="tab">Paso 1. Datos del anuncio</a></li>
        <li><a href="#stepTwo" data-toggle="tab">Paso 2. Datos del vehículo</a></li>
        <li><a href="#stepThree" data-toggle="tab">Paso 3. Datos de contacto</a></li>
    </ul>

    <div class="tab-content">
        <div class="push push-sm"></div>
        <div class="tab-pane fade active in" id="stepOne">
            <div class="row">
                <div class="col-xs-6">
                    <div class="form-group">
                        <label class="control-label">Título *</label>
                        <input class="form-control" id="tbxTitle" type="text" runat="server" required />
                    </div>
                    <div class="form-group">
                        <label class="control-label">Descripción *</label>
                        <textarea class="form-control" id="tbxDescription" runat="server" required></textarea>
                    </div>
                    <div class="form-group">
                        <label class="control-label">Precio *</label>
                        <input class="form-control" id="tbxPrice" type="number" runat="server" required />
                    </div>
                    <div class="form-group">
                        <button class="btn btn-primary" type="button" onclick="goStep('stepTwo')">
                            Continuar <i class="glyphicon glyphicon-chevron-right"></i>
                        </button>
                    </div>
                </div>
            </div>
        </div>
        <div class="tab-pane fade" id="stepTwo">
            <div class="row">
                <div class="col-xs-6">
                    <div class="form-group">
                        <label class="control-label">Tipo de vehículo</label>
                        <select class="form-control" id="tbxType" runat="server">
                            <option value="LIGHT" selected>Vehículo Liviano</option>
                            <option value="CHARGE">Vehiculo de Carga</option>
                            <option value="MOTO">Motocicleta</option>
                        </select>
                    </div>
                    <div class="form-group">
                        <label class="control-label">Marca</label>
                        <input class="form-control" id="tbxBrand" type="text" runat="server" />
                    </div>
                    <div class="form-group">
                        <label class="control-label">Modelo</label>
                        <input class="form-control" id="tbxModel" type="text" runat="server" />
                    </div>
                    <div class="form-group">
                        <label class="control-label">Año</label>
                        <input class="form-control" id="tbxYear" type="number" runat="server" />
                    </div>
                    <div class="form-group">
                        <label class="control-label">Color</label>
                        <input class="form-control" id="tbxColor" type="text" runat="server" />
                    </div>
                    <div class="form-group">
                        <label class="control-label">Estado</label>
                        <select class="form-control" id="tbxStatus" runat="server">
                            <option value="NEW">Nuevo</option>
                            <option value="USED">Usado</option>
                        </select>
                    </div>
                    <div class="form-group">
                        <label class="control-label">Foto</label>
                        <input class="form-control" id="tbxUrl" type="url" runat="server" placeholder="http://" />
                    </div>
                    <div class="form-group">
                        <button class="btn btn-default" type="button" onclick="goStep('stepOne')">
                            <i class="glyphicon glyphicon-chevron-left"></i> Regresar
                        </button>
                        <button class="btn btn-primary" type="button" onclick="goStep('stepThree')">
                            Continuar <i class="glyphicon glyphicon-chevron-right"></i>
                        </button>
                    </div>
                </div>
            </div>
        </div>
        <div class="tab-pane fade" id="stepThree">
            <div class="row">
                <div class="col-xs-6">
                    <div class="form-group">
                        <label class="control-label">Nombre completo *</label>
                        <input class="form-control" id="tbxName" type="text" runat="server" required />
                    </div>
                    <div class="form-group">
                        <label class="control-label">Email</label>
                        <input class="form-control" id="tbxEmail" type="email" runat="server" placeholder="sample@domain.com" />
                    </div>
                    <div class="form-group">
                        <label class="control-label">Teléfono *</label>
                        <input class="form-control" id="tbxTelephone" type="number" runat="server" required />
                    </div>
                    <div class="form-group">
                        <button class="btn btn-default" type="button" onclick="goStep('stepTwo')">
                            <i class="glyphicon glyphicon-chevron-left"></i> Regresar
                        </button>
                        <button class="btn btn-success" type="button" id="btnSave" runat="server" onserverclick="btnSave_Click">Guardar</button>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="Scripts" runat="server">
</asp:Content>
