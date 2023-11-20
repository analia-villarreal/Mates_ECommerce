<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="DetalleArticulo.aspx.cs" Inherits="Mates_ECommerce.DetalleArticulo" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

        <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>

    <div class="container">
            <div class="table" style="max-width: 540px; height: 540px">
                <table>
                    <tr>
                        <td>
                            <asp:Image ID="img" runat="server" style="width:500px; height:500px;" />
                        </td>
                        <td style="text-align:center; font-size:20px">
                            <div>
                                <asp:Label ID="lblNombre" runat="server" Text="NOMBRE" style="font:25px bold; background-color:black; color:white"></asp:Label>
                            </div>
                            <div>
                                <asp:Label ID="lblDescripcion" runat="server" Text="DESCRIPCIÓN"></asp:Label>
                            </div>
                            <div>
                                <asp:Label ID="lblPrecio" runat="server" Text="PRECIO"></asp:Label>
                            </div>
                                <asp:Button ID="btnRestar" runat="server" Text="-" OnClick="btnRestar_Click"/>
                                <asp:TextBox ID="txtCantidad" runat="server" value="1" style="width:40px" CssClass="text-center" ></asp:TextBox>
                                <asp:Button ID="btnSumar" runat="server" Text="+" OnClick="btnSumar_Click"/>
                            <div>
                                <br />
                                <asp:Button ID="btnCarrito" runat="server" CssClass="btn btn-danger" Text="AGREGAR AL CARRITO" OnClick="btnCarrito_Click"/>
                            </div>
                            <div>
                                <br />
                                <!-- Enlace para abrir el modal -->
                                <div style="border:double; font-size:15px">
                                    <p>Información sobre envíos:</p>
                                    <asp:ImageButton ID="imgEnvio" runat="server" ImageUrl="~/Content/Img/caja.png"  data-target="#miModal" data-toggle="modal" OnClick="imgEnvio_Click"  />
                                </div>
                            </div>
                        </td>
                    </tr>
                </table>
            </div>
    </div>

 
    <script>
        function ModalStock(decision) {
            if (decision == "Abrir") {
                $('#miModal').removeClass('d-none');
                $('#miModal').addClass('d-block');
            }
            if (decision == "Cerrar") {
                $('#miModal').removeClass('d-block');
                $('#miModal').addClass('d-none');
            }
        }
    </script>
  
</asp:Content>
