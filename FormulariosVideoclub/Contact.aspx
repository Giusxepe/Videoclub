<%@ Page Title="Contact" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Contact.aspx.cs" Inherits="FormulariosVideoclub.Contact" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2 class="text-center">Registro de empleados</h2>

    <div>

        <table class="nav-justified">
            <tr>
                <td class="text-center" style="width: 598px; font-size: large;">Id empleado</td>
                <td class="text-left">
                    <asp:TextBox ID="txtID" runat="server" style="margin: 10px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="text-center" style="width: 598px; font-size: large;">Nombre</td>
                <td class="text-left">
                    <asp:TextBox ID="txtNombre" runat="server" style="margin: 10px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="text-center" style="width: 598px; font-size: large;">Apellido paterno</td>
                <td class="text-left">
                    <asp:TextBox ID="txtAp" runat="server" style="margin: 10px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="text-center" style="width: 598px; font-size: large;">Apellido materno</td>
                <td class="text-left">
                    <asp:TextBox ID="txtAm" runat="server" style="margin: 10px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="text-center" style="width: 598px; font-size: large;">Edad</td>
                <td class="text-left">
                    <asp:TextBox ID="txtEdad" runat="server" style="margin: 10px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="text-center" style="width: 598px; font-size: large;">Puesto</td>
                <td class="text-left">
                    <asp:TextBox ID="txtPuesto" runat="server" style="margin: 10px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="text-center" style="width: 598px; font-size: large;">Sueldo por dia</td>
                <td class="text-left">
                    <asp:TextBox ID="txtSxD" runat="server" style="margin: 10px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="text-center" style="width: 598px; font-size: large;">Calle</td>
                <td class="text-left">
                    <asp:TextBox ID="txtCalle" runat="server" style="margin: 10px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="text-center" style="width: 598px; font-size: large;">Colonia</td>
                <td class="text-left">
                    <asp:TextBox ID="txtColonia" runat="server" style="margin: 10px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="text-center" style="width: 598px; font-size: large;">Numero de casa</td>
                <td class="text-left">
                    <asp:TextBox ID="txtNcasa" runat="server" style="margin: 10px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="text-center" style="width: 598px; font-size: large;">Fecha registro</td>
                <td class="text-left">
                    <asp:TextBox ID="txtFecha" runat="server" style="margin: 10px"></asp:TextBox>
                </td>
            </tr>
        </table>
        <div class="text-center">
            <asp:Button ID="btnGuardar" runat="server" Text="Guardar" style="margin: 10px" OnClick="btnGuardar_Click" />
            <asp:Button ID="btnEliminar" runat="server" Text="Eliminar" style="margin: 10px" OnClick="btnEliminar_Click" />
            <asp:Button ID="btnActualizar" runat="server" Text="Actualizar" style="margin: 10px" OnClick="btnActualizar_Click" />
        </div>
        <div class="text-center" style="font-size: xx-large">
            
            Registros
            
        </div>
        <div>
            <asp:Button ID="btnBuscar" runat="server" Text="Buscar" style="margin: 10px" OnClick="btnBuscar_Click" />
            <asp:TextBox ID="txtEmp" runat="server" style="margin: 10px"></asp:TextBox>
        </div>
        <div class="text-center">
            <asp:GridView ID="GVempleados" runat="server" BackColor="#DEBA84" BorderColor="#DEBA84" BorderStyle="None" BorderWidth="1px" CellPadding="3" CellSpacing="2" AllowPaging="True" OnPageIndexChanging="GVempleados_PageIndexChanging">
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

