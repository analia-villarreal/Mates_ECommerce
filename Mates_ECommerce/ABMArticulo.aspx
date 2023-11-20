<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ABMArticulo.aspx.cs" Inherits="Mates_ECommerce.ABMArticulo" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">


        <h3>LISTADO</h3>
    
    <div class="row">

        <div class="col">

            <asp:GridView runat="server" ID="dgvArticulos"  OnPageIndexChanging="dgvArticulos_PageIndexChanging" OnSelectedIndexChanged="dgvArticulos_SelectedIndexChanged" DataKeyNames="ID" CssClass="table" AutoGenerateColumns="false" AllowPaging="true" PageSize="15">
                <Columns>
                    <asp:BoundField HeaderText="ID" DataField="ID" />
                    <asp:BoundField HeaderText="Nombre" DataField="NombreArt" />
                    <asp:BoundField HeaderText="Descripcion" DataField="Descripcion" />  
                    <asp:BoundField HeaderText="Precio" DataField="Precio" /> 
                    <asp:CommandField ShowSelectButton="true" SelectText="Seleccionar" HeaderText="Acción" />
                </Columns>

            </asp:GridView>
            <a href="ArticulosForm.aspx">Agregar</a>

        </div>

    </div>






</asp:Content>
