
<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Mates_ECommerce._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    
                 
             <div id="carouselExampleSlidesOnly" class="carousel slide" data-bs-ride="carousel">
              <div class="carousel-inner">
                <div class="carousel-item active">
                  <img src="https://d22fxaf9t8d39k.cloudfront.net/42005d331cfc60cc567cdc59364fdd570b034a4a8447c52ddfd958010b07063019762.jpg" class="d-block w-100" alt="...">
                </div>
                <div class="carousel-item">
                  <img src="https://d22fxaf9t8d39k.cloudfront.net/4d3e590ae3f342ee6a0a0e9840a202c1ef2b7f38b2af5d622919c8ad67493afd19762.jpg" class="d-block w-100" alt="...">
                </div>
                <div class="carousel-item">
                  <img src="https://d22fxaf9t8d39k.cloudfront.net/bfcff9cd28146d464c90deb2d92e96b6a4c1287656094cbb4ffc94d1a4c95c1d19762.jpg" class="d-block w-100" alt="...">
                </div>
              </div>
            </div>
        
      <div class="row">
        <div class="row row-cols-1 row-cols-md-4 g-4">
            <div style="display: flex; justify-content: center; margin-top: 20px; margin-bottom: 20px;">
        <h1>PRODUCTOS DESTACADOS</h1>
            </div>
       </div>
          </div>
    <div class="row">
        
            <div class="row row-cols-1 row-cols-md-4 g-4">

            <% foreach (Dominio.Models.Articulo item in listaArticulos )
                { %>
                <div class="col">
                    <div class="card h-100" style="width:400px; height:400px;border: solid 3px black">
                        <div align="center">
                            <img src="<% = item.UrlImagen %>"" class="card-img-top" alt="..." style="width:350px; height:350px">
                        </div>
                        <div class="card-body">
                            <h5 class="card-title"><% = item.NombreArt %></h5>
                            <p class="card-text"><%= item.Descripcion %></p>
                            <h6 class="card-text"> $<% = item.Precio %></h6>   
                            <asp:Label ID="Label1" runat="server" Text="Stock" Visible ="false"></asp:Label>
                        </div>
                        <footer align="center">
                            <a href="DetalleArticulo.aspx?id=<%:item.ID%>" class ="btn btn-danger" align="right">COMPRAR</a>
                        </footer>
                    </div>
                </div>
            <% } %>
            </div>
       
    </div>

</asp:Content>
