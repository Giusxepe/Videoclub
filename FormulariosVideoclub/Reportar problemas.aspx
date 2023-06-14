<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Reportar problemas.aspx.cs" Inherits="FormulariosVideoclub.Reportar_problemas" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div>

    </div>
    <div class="text-center" style="font-size: x-large">
        Si has tenido algun problema con el sistema comunicate con nosotros.</div>
    <table class="nav-justified">
        <tr>
            <td class="text-center" style="width: 435px">Email de:</td>
            <td>
                <asp:TextBox ID="txtEmailForm" runat="server" autocomplete="off" style="margin:10px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width: 435px" class="text-center">Contraseña:</td>
            <td>
                <asp:TextBox ID="txtContraseña" runat="server" autocomplete="off" style="margin:10px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width: 435px">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 435px; margin: 10px" class="text-center">
                <asp:Label ID="Label1" runat="server" Text="Email para:" style="margin:10px"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtEmailTo" runat="server" autocomplete="off" style="margin:10px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width: 435px; margin:10px" class="text-right">&nbsp;&nbsp;&nbsp; Mensaje:</td>
            <td><asp:TextBox ID="txtMensaje" runat="server" autocomplete="off" Height="285px" Rows="10" Width="485px" style="margin:10px"></asp:TextBox>
            </td>
        </tr>
        
         <tr>
            <td style="width: 435px" class="text-center"> 
            </td>
            <td><asp:Button ID="btnEnviar" runat="server" Text="Enviar" style="margin:10px" OnClick="btnEnviar_Click" />
             </td>
        </tr>
        </table>
</asp:Content>
