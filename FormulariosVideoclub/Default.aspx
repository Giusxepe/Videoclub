<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="FormulariosVideoclub._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div>
    </div>

    <div class="jumbotron">
        <div>
    </div>
        <p class="lead" style="font-size: xx-large; text-align: center;">Transacciones diarias</p>
        <div class="text-right">
            <asp:Button ID="bntCerrarSesion" runat="server" Text="Cerrar sesion" BackColor="White" BorderStyle="None" Height="28px" OnClick="bntCerrarSesion_Click" Width="170px" />
        </div>
        <asp:Label ID="lblBienvenido" runat="server" Text="Bienvenido:" style="font-size: x-large"></asp:Label>
    </div>
    

    <div class="row">
        <div class="col-md-4">
            <h2 class="text-center">Realizar transaccion</h2>
        </div>
        <div>

            <table align="center" class="nav-justified">
                <tr>
                    <td class="text-center" style="width: 373px; font-size: large;">Id transaccion</td>
                    <td class="text-left" style="width: 483px">
                        <asp:TextBox ID="txtIdTran" runat="server" style="margin: 10px; font-size: large;" Width="119px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="text-center" style="width: 373px; font-size: large;">Id producto&nbsp;</td>
                    <td class="text-left" style="width: 483px">
                        <asp:TextBox ID="txtIdProd" runat="server" style="margin: 10px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="text-center" style="width: 373px; font-size: large;">Id empleado</td>
                    <td class="text-left" style="width: 483px">
                        <asp:TextBox ID="txtIdEmpl" runat="server" style="margin: 10px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="text-center" style="width: 373px; font-size: large;">Id cliente</td>
                    <td class="text-left" style="width: 483px">
                        <asp:TextBox ID="txtIdCliente" runat="server" style="margin: 10px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="text-center" style="width: 373px; font-size: large;">Tipo de transaccion</td>
                    <td class="text-left" style="width: 483px">
                        <asp:TextBox ID="txtTipoTran" runat="server" style="margin: 10px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="text-center" style="width: 373px; font-size: large;">Cantidad</td>
                    <td class="text-left" style="width: 483px">
                        <asp:TextBox ID="txtCant" runat="server" style="margin: 10px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="text-center" style="width: 373px; font-size: large;">Fecha </td>
                    <td class="text-left" style="width: 483px">
                        <asp:TextBox ID="txtFecha" runat="server" style="margin: 10px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="text-center" style="width: 373px; font-size: large;">Monto por dia </td>
                    <td class="text-left" style="width: 483px">
                        <asp:TextBox ID="txtMxDia" runat="server" style="margin: 10px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="text-center" style="width: 373px; font-size: large;">Dias renta</td>
                    <td class="text-left" style="width: 483px">
                        <asp:TextBox ID="txtDiasRen" runat="server" style="margin: 10px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="text-center" style="width: 373px; font-size: large;">Fecha de entrega</td>
                    <td class="text-left" style="width: 483px">
                        <asp:TextBox ID="txtFechaEntrega" runat="server" style="margin: 10px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="text-center" style="width: 373px; font-size: large;">Total</td>
                    <td class="text-left" style="width: 483px">
                        <asp:TextBox ID="txtTotal" runat="server" style="margin: 10px"></asp:TextBox>
                    </td>
                </tr>
            </table>
            <div class="text-center">
                <asp:Button ID="btnGuardar" runat="server" Text="Guardar" style="margin: 30px" OnClick="btnGuardar_Click" />
                <asp:Button ID="btnAct" runat="server" Text="Actualizar" style="margin: 30px" Height="26px" OnClick="btnAct_Click" />
                <asp:Button ID="btnEliminar" runat="server" Text="Borrar"  style="margin: 30px" OnClick="btnEliminar_Click"/>
            </div>

            <div class="jumbotron" style="text-align: center">
                <div style="font-size: x-large">
                    Ultima transaccion realizada
                </div>
                <div>
                <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
                </div>
    </div>

        </div>
        <div class="col-md-4">
            <h2 class="text-center">Registros transacciones</h2>
            <p>
                <asp:Button ID="btnBuscar" runat="server" Text="Buscar" style="margin: 20px" OnClick="btnBuscar_Click" />
                <asp:TextBox ID="txtTransac" runat="server" style="margin: 20px"></asp:TextBox>
            </p>

        </div>
        <div class="text-center">
            <asp:GridView ID="GVtran" runat="server" BackColor="#DEBA84" BorderColor="#DEBA84" BorderStyle="None" BorderWidth="1px" CellPadding="3" CellSpacing="2" AllowPaging="True" OnPageIndexChanging="GVtran_PageIndexChanging">
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
        <div class="col-md-4">
        </div>
    </div>

</asp:Content>
