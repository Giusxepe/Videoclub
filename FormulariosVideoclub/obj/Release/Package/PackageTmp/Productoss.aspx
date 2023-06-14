<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Productoss.aspx.cs" Inherits="FormulariosVideoclub.Productoss" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div>
    <div style="height: 393px">


        <div class="text-center">
            <asp:Label ID="Label1" runat="server" Text="Registro de productos" style="font-size: xx-large; margin: 10px"></asp:Label>
        </div>
        <div>
            
            <table class="nav-justified">
                <tr>
                    <td class="text-center" style="width: 588px; font-size: large;">Id producto</td>
                   
                    <td class="text-left">
                        <asp:TextBox ID="txtIdProd" runat="server" style="margin: 10px"></asp:TextBox>
                    </td>
                </tr>
                 <tr>
                    <td class="text-center" style="width: 588px; font-size: large;">Id proovedor</td>
                    <td class="text-left">
                        <asp:TextBox ID="txtIdProv" runat="server" style="margin: 10px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="text-center" style="width: 588px; font-size: large;">Tipo</td>
                    <td class="text-left">
                        <asp:TextBox ID="txtTipo" runat="server" style="margin: 10px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="text-center" style="width: 588px; font-size: large;">Nombre</td>
                    <td class="text-left">
                        <asp:TextBox ID="txtNombre" runat="server" style="margin: 10px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="text-center" style="width: 588px; font-size: large;">Año</td>
                    <td class="text-left">
                        <asp:TextBox ID="txtAño" runat="server" style="margin: 10px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="text-center" style="width: 588px; font-size: large;">Genero</td>
                    <td class="text-left">
                        <asp:TextBox ID="txtGenero" runat="server" style="margin: 10px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="text-center" style="width: 588px; font-size: large;">Tipo de publico</td>
                    <td class="text-left">
                        <asp:TextBox ID="txtPublico" runat="server" style="margin: 10px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="text-center" style="width: 588px; font-size: large;">Cantidad</td>
                    <td class="text-left">
                        <asp:TextBox ID="txtCantidad" runat="server" style="margin: 10px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="text-center" style="width: 588px; font-size: large;">Fecha de registro</td>
                    <td class="text-left">
                        <asp:TextBox ID="txtFecha" runat="server" style="margin: 10px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="text-center" style="width: 588px; font-size: large;">&nbsp;</td>
                    <td class="text-left">
                        &nbsp;</td>
                </tr>
            </table>
            
        </div>
       
    </div>
        <div class="text-center">
                <br />
                <br />
                <br />
                <asp:Button ID="btnGuardar" runat="server" Text="Guardar" style="margin: 20px" OnClick="btnGuardar_Click" />
                <asp:Button ID="btnActualizar" runat="server" Text="Actualizar" style="margin: 20px" OnClick="btnActualizar_Click" />
                <asp:Button ID="btnEliminar" runat="server" Text="Eliminar" style="margin: 20px" OnClick="btnEliminar_Click"/>
        </div>
        <div>
            <asp:Button ID="btnBuscar" runat="server" Text="Buscar" style="margin: 10px" OnClick="btnBuscar_Click" />
            <asp:TextBox ID="txtProd" runat="server" style="margin: 10px" Width="242px"></asp:TextBox>
        </div>
        <div class="text-center">
            <asp:GridView ID="GVprod" runat="server" AllowPaging="True" BackColor="#DEBA84" BorderColor="#DEBA84" BorderStyle="None" BorderWidth="1px" CellPadding="3" CellSpacing="2" OnPageIndexChanging="GVprod_PageIndexChanging">
                <FooterStyle BackColor="#F7DFB5" ForeColor="#8C4510" />
                <HeaderStyle BackColor="#A55129" Font-Bold="True" ForeColor="White" />
                <PagerStyle ForeColor="#8C4510" HorizontalAlign="Center" />
                <RowStyle BackColor="#FFF7E7" ForeColor="#8C4510" />
                <SelectedRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="White" />
                <SortedAscendingCellStyle BackColor="#FFF1D4" />
                <SortedAscendingHeaderStyle BackColor="#B95C30" />
                <SortedDescendingCellStyle BackColor="#F1E5CE" />
                <SortedDescendingHeaderStyle BackColor="#93451F" />
            </asp:GridView>
        </div>
    </div>
    </asp:Content>
