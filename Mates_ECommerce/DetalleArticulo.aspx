﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="DetalleArticulo.aspx.cs" Inherits="Mates_ECommerce.DetalleArticulo" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

      
     <div class="container">
        <div class="row">
            <div class="col-6">
                <img src="<%: Session["Url_Imagen"].ToString() %>" style="border-radius: 20px; width: 500px">
            </div>

            <div class="col-6">
                <h2 runat="server" id="NombreDetalle" style="color: white" />
                <p runat="server" id="DescripcionDetalle" style="color: grey" />
                <hr style="color: white" />
                <div style="display: flex; flex-direction: row; margin-top: 20px;">
                    <h3>$ </h3>
                    <h3 runat="server" id="PrecioDetalle" style="color: black" />
                </div>
                <asp:UpdatePanel runat="server">
                    <ContentTemplate>
                        <div style="display: flex; flex-direction: row; margin-top: 20px;">
                            <p style="color: grey">Seleccione Cantidad</p>
                            <asp:TextBox id="txtCantidad" AutoPostBack="true"  runat="server" type="number" min="0" Style="margin-left: 20px"  CssClass="btn btn- dropdown-toogle" max="20" value="0"></asp:TextBox>
                        </div>

                        <div style="display: flex; flex-direction: row; margin-top: 50px;">
                            <img src="https://img.icons8.com/ios-glyphs/30/ffffff/shopping-cart--v1.png" style="margin-right: 20px;" />
                            <asp:Button Text="AÑADIR AL CARRITO" ID="btnAddCarrito" OnClick="btnAddCarrito_Click" Style="width: 500px;" runat="server" CssClass="btn btn-danger" />
                            
                        </div>
                    </ContentTemplate>
                </asp:UpdatePanel>

            </div>

            <div class="modal fade" id="AddCarrito" tabindex="-1" role="dialog" aria-labelledby="AddCarrito2" style="color: black;" aria-hidden="true">
                <div class="modal-dialog" role="document">
                    <div class="modal-content">
                        <div class="modal-header">
                            <h5 class="modal-title" id="AddCarrito2">Agregado al carrito!  </h5>
                            <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                                <span aria-hidden="true">&times;</span>
                            </button>
                        </div>
                        <%-- <div class="modal-body">
                 <p>Agregado al carrito! </p>
            </div>--%>
                    </div>
                </div>
            </div>

        </div>
    </div>

    <script type="text/javascript">
        function openModalAgregado() {
            $('#AddCarrito').modal('show');

        }
    </script>

  
</asp:Content>
