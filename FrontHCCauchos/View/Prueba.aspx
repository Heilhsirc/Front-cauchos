<%@ Page Language="C#" Async="true" AutoEventWireup="true" CodeFile="Prueba.aspx.cs" Inherits="View_Prueba" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Repeater ID="Repeater1" runat="server">
                <ItemTemplate>
                    <div class="row">
                        <div class="col1"></div>
                        <div class="col3">
                            <h1><b>Titulo:</b><%# Eval("Titulo") %></h1>
                        </div>
                        <div class="col3">
                            <h1><b>Referencia:</b><%# Eval("Referencia") %></h1>
                        </div>
                        <div class="col3">
                            <h1><b>Precio:</b><%# Eval("Precio") %></h1>
                        </div>
                        <div class="col3">
                            <h1><b>Ca_actual:</b><%# Eval("Ca_actual") %></h1>
                        </div>
                        <div class="col3">
                            <h1><b>Nombre_marca:</b><%# Eval("Nombre_marca") %></h1>
                        </div>
                        <div class="col3">
                            <h1><b>Nombre_categoria:</b><%# Eval("Nombre_categoria") %></h1>
                        </div>
                    </div>
                </ItemTemplate>
            </asp:Repeater>
            <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" SelectMethod="ObtenerCatalogo" TypeName="utilitarios.Class1"></asp:ObjectDataSource>
            <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" />
        </div>
    </form>
</body>
</html>
