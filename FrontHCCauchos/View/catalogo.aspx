<%@ Page Title="" async="true" Language="C#" MasterPageFile="~/View/Principal.master" AutoEventWireup="true" CodeFile="~/Controller/catalogo.aspx.cs" Inherits="View_catalogo" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <link href="../../archivos_index/barra_carrito/font.css" rel="stylesheet" />
    <link href="../../archivos_index/barra_carrito/estilos_Carrito.css" rel="stylesheet" />
    <style type="text/css">
        #productos{
            border-color:black;
        }
        #productos:hover{
            background:#0b94fa;
            color:white;
            border-color:black;
          
        }
        #productos h4:hover{
            color:black;
            font-size:30px;
        }
        #Image1:hover{
            width:60%;

        }
                
        </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="social-bar1">
        <a href="Carrito.aspx" class="icon icon-cart">
           &nbsp;<asp:Label ID="LB_cantidad" runat="server" Text=""></asp:Label> 
        </a>
    </div>
    <br />
    <br />
    <div style=" width:50%;" class="center-block text-center">
        <asp:Panel runat="server" ID="PanelMensaje1" Visible="false" CssClass="alert alert-warning shadow" role="alert">
	    <strong>
	    <asp:Label ID="LblMensaje1" runat="server" />
	    </strong>
	    <asp:LinkButton Text="<span aria-hidden='true'>&times;</span>" runat="server" CssClass="close" ID="B_cerrar_mensaje1"  />
        </asp:Panel>
    </div>


    <div class="row ">      
    <asp:Repeater ID="Repeater1" runat="server"  >
        <ItemTemplate>            
            <div class="col-md-2 col-sm-6 col-xs-8 mb-3" >
                 <div class="card shadow text-block" style=" width:120%; height:500px;" id="productos">  
                         <asp:Image ID="Image1" runat="server" ImageUrl='<%# Eval("Imagen") %>' width="100%" Height="30%" class="card-img-top"  />                 
                            <div class="card-body ">
                                <h4 class="card-title text-center" id="titulo">
                                    <strong><asp:Label ID="TituloLabel" runat="server" Text='<%# Eval("Titulo") %>' /></strong>
                                </h4>
                                <strong>Referencia:</strong>
                                <asp:Label ID="ReferenciaLabel" runat="server" Text='<%# Eval("Referencia") %>' class="card-text" />                            
                                <br />
                                <strong>Precio:</strong> 
                                <asp:Label ID="PrecioLabel" runat="server" Text='<%# Eval("Precio") %>' class="card-text" />
                                <br />
                                <strong>Stock:</strong> 
                                <asp:Label ID="Ca_actualLabel" runat="server" Text='<%# Eval("Ca_actual") %>' class="card-text"/>
                                <br />
                                <strong>Marca:</strong> 
                                <asp:Label ID="NombremarcaLabel" runat="server" Text='<%# Eval("Nombre_marca") %>' class="card-text"/>
                                <br />
                                <strong>Categoria:</strong>
                                <asp:Label ID="Nombre_categoriaLabel" runat="server" Text='<%# Eval("Nombre_categoria") %>' class="card-text"/>  
                                <br />
                                <strong>Cantidad:</strong>
                                <asp:TextBox ID="TB_cantidad" runat="server" TextMode="number" Class="card-text" Width="25%" CssClass="text-black" MaxLength="4"></asp:TextBox>                         
                                <asp:RequiredFieldValidator ID="RFV_cantidad" runat="server" ErrorMessage="*" ControlToValidate="TB_cantidad" EnableClientScript="True" ValidationGroup='<%# Eval("Id") %>'></asp:RequiredFieldValidator>&nbsp;&nbsp;
                                <asp:RangeValidator ID="RV_cantidad" runat="server" ErrorMessage="valor invalido" ControlToValidate="TB_cantidad" MaximumValue="1000" MinimumValue="1" Type="Integer" ValidationGroup='<%# Eval("Id") %>'></asp:RangeValidator>
                                <asp:ImageButton class="btn-group center-block" ID="BTNI_carritoAdd" runat="server" ImageUrl="~/ima/carro.png" ImageAlign="AbsBottom" CommandArgument='<%# Eval("Id") %>' ValidationGroup='<%# Eval("Id") %>' />
                                
                            </div>
               </div>    
          </div>                            
        </ItemTemplate>
    </asp:Repeater>
    </div>
    <br />
</asp:Content>

