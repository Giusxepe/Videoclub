<%@ Page Title="Registro de clientes" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="About.aspx.cs" Inherits="FormulariosVideoclub.About" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2>
        <table class="nav-justified" style="text-align:center; " >
             <td colspan="2" style="margin: 10px">Registrar nuevo cliente</td>
            <tr>
                <td style="width: 50%; font-size: x-large;">
                    <span style="font-size: x-large">Id cliente</span></td>
                <td style="width: 50%" class="text-left">
                    <asp:TextBox ID="txtIDcliente" runat="server" autocomplete="off" style="margin: 10px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td style="width: 521px; font-size:x-large">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;Nombre</td>
                <td style="width: 50%" class="text-left">
                    <asp:TextBox ID="txtNombreCliente" runat="server"  autocomplete="off" style="margin: 10px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td style="width: 50%; font-size: x-large;">Apellido paterno</td>
                <td style="width: 50%" class="text-left">
                    <asp:TextBox ID="txtApaterno" runat="server" autocomplete="off" style="margin: 10px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td style="width: 50%; font-size: x-large;">Apellido materno</td>
                <td style="width: 50%" class="text-left">
                    <asp:TextBox ID="txtAmaterno" runat="server" autocomplete="off" style="margin: 10px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td style="width: 50%; font-size: x-large;">Dirección</td>
                <td style="width: 50%" class="text-left">
                    <asp:TextBox ID="txtDir" runat="server" autocomplete="off" style="margin: 10px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td style="width: 50%px; font-size: x-large;">Email</td>
                <td style="width: 50%" class="text-left">
                    <asp:TextBox ID="txtEmail" runat="server" autocomplete="off" style="margin: 10px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td style="width: 50%; font-size: x-large;">Telefono</td>
                <td style="width: 50%" class="text-left">
                    <asp:TextBox ID="txtTel" runat="server" autocomplete="off" style="margin: 10px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td style="width: 50%; font-size: x-large;">Fecha registro</td>
                <td style="width: 50%" class="text-left">
                    <asp:TextBox ID="txtFecha" runat="server" autocomplete="off" style="margin: 10px" >2020-01-12</asp:TextBox>
                </td>
               
            </tr>
             <td colspan="2" style="height: 100px">
                 <br />
                 <asp:Button ID="btnAceptar" runat="server" Text="Guardar" OnClick="btnAceptar_Click" style="margin: 10px" />
                 <asp:Button ID="btnActualizar" runat="server" Text="Actualizar" style="margin: 10px" OnClick="btnActualizar_Click" />
                 <asp:Button ID="btnEliminar" runat="server" Text="Eliminar" style="margin: 10px" OnClick="btnEliminar_Click"/>
                 <br />
             </td>
        </table>
        <div class="text-center" style="font-size: xx-large">

            Registro de clientes</div>
        <div>

            <asp:Button ID="btnBuscar" runat="server" Text="Buscar" style="margin: 10px" OnClick="btnBuscar_Click" />
            <asp:TextBox ID="txtNombre" runat="server" autocomplete="off" style="margin: 10px" OnTextChanged="txtNombre_TextChanged" Width="325px">Nombre cliente</asp:TextBox>

            <br />
            
            <asp:GridView ID="GvClientes" runat="server" CellPadding="3" AllowPaging="True" CellSpacing="2" HorizontalAlign="Center" BackColor="#DEBA84" BorderColor="#DEBA84" BorderStyle="None" BorderWidth="1px" OnPageIndexChanging="GvClientes_PageIndexChanging">
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
            
        <%: Title %></h2>
    </asp:Content>
