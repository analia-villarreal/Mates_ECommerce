<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AltaArticulo.aspx.cs" Inherits="Mates_ECommerce.AltaArticulo" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    
    <div class="form-group">
        <div class="row">
            <div class="col-6">
                <div class="mb-3 row">
                    <label for="textNombre" class="col-sm-2 col-form-label">Nombre</label>
                    <div class="col-sm-10">
                        <asp:TextBox runat="server" ID="textNombre" CssClass="form-control" />
                    </div>
                </div>
                <div class="mb-3 row">
                    <label for="textDescripcion" class="col-sm-2 col-form-label">Descripcion</label>
                    <div class="col-sm-10">
                        <asp:TextBox runat="server" ID="textDescripcion" CssClass="form-control" />
                    </div>
                </div>
                 <div class="mb-3 row">
                    <label for="ddlCategoria" class="col-sm-2 col-form-label">Categoria</label>
                    <div class="col-sm-10">
                        <asp:DropDownList ID="ddlCategoria" runat="server" CssClass="form-select"></asp:DropDownList>
                    </div>
                </div>
                <div class="mb-3 row">
                    <label for="ddlSubCategoria" class="col-sm-2 col-form-label">SubCategoria</label>
                    <div class="col-sm-10">
                        <asp:DropDownList ID="ddlSubCategoria" runat="server" CssClass="form-select"></asp:DropDownList>
                    </div>
                </div>     
                <div class="mb-3 row">
                    <label for="textURLImagen" class="col-sm-2 col-form-label">URL Imagen</label>
                    <div class="col-sm-10">
                        <asp:TextBox runat="server" ID="textURLImagen" CssClass="form-control" />
                    </div>
                </div>
                </div>
                <div class="mb-3 row">
                    <label for="textPrecio" class="col-sm-2 col-form-label">Precio</label>
                    <div class="col-sm-10">
                        <asp:TextBox runat="server" ID="txtPrecio" CssClass="form-control" />
                    </div>
                </div>
                <div class="mb-3 row">
                    <div class="col-sm-10 form-check-input">
                        <asp:CheckBox Text="" ID="chkActivo" runat="server" />
                        <asp:Label Text="Activo" CssClass="form-check-label" runat="server" />
                    </div>
                </div>
              <div class="mb-3 row">
                            <%if (Request.QueryString["ID"] != null)
                    {%>
                    <div class="col-sm-10">
                        <asp:Button CssClass="btn btn-primary" ID="btnModificar" OnClick="btnModificar_Click" runat ="server" Text="Modificar" />
                    </div>
                    <div class="col-sm-10">
                        <asp:Button CssClass="btn btn-primary" ID="btnEliminar" OnClick="btnEliminar_Click" runat="server" Text="Eliminar" />
                    </div>
                
                <%}
                    else
                    {%>
                <div class="col-sm-10">
                    <asp:Button CssClass="btn btn-primary" ID="btnAceptar"  OnClick="btnAceptar_Click" runat="server" Text="Aceptar" />
                </div>
            
                <%}%>
            </div>
                <a href="">Cancelar</a>
            </div>
         </div>

    


</asp:Content>
