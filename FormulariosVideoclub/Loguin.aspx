<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Loguin.aspx.cs" Inherits="FormulariosVideoclub.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            text-align: center;
        }
        .auto-style2 {
            font-size: xx-large;
        }
        .auto-style3 {
            text-align: center;
            width: 205px;
            height: 71px;
            position: relative;
            left: 58px;
            top: 12px;
        }
        .auto-style4 {
            position: relative;
            left: 58px;
            top: 15px;
            width: 203px;
            text-align: center;
            height: 72px;
        }
        .auto-style5 {
            position: relative;
            left: 22px;
            top: 48px;
            width: 289px;
            text-align: center;
            margin-bottom: 10px;
        }
        .auto-style6 {
            position: relative;
            left: 469px;
            top: -2px;
            width: 329px;
            height: 212px;
        }
        .auto-style8 {
            text-align: center;
            position: relative;
            left: 0px;
            top: 21px;
        }
        .auto-style9 {
            position: relative;
            left: 543px;
            top: -29px;
            width: 188px;
            margin-top: 102px;
        }
    </style>
    </head>
<body>
    <form id="form1" runat="server">
             <div class="auto-style1">

                 <asp:Label ID="Label3" runat="server" Text="S.I. Gestion de VideoClub" CssClass="auto-style2"></asp:Label>

                 

                 <br />

                 <br />

             </div>
            
          <div style="background-color:aquamarine; " class="auto-style6">
             <div class="auto-style3">
                 <asp:Label ID="Label4" runat="server" Text="Usuario" style="margin: 10px"></asp:Label>
                 <br />
                 <asp:TextBox ID="txtUsuario" runat="server" autocomplete="off" style="margin: 10px"></asp:TextBox>
             </div>
        <div class="auto-style4">
                 <asp:Label ID="Label5" runat="server" Text="Contraseña"  style="margin: 10px; position: relative "></asp:Label>
            <br />
            <asp:TextBox ID="txtContra" runat="server" style="margin: 10px" autocomplete="off" TextMode="Password"></asp:TextBox>
                 <br />
                 <br />
                 <br />
        </div>
        <div class="auto-style8">
            <asp:CheckBox ID="chbxRecordar" runat="server" Text="Recordar usuario" />
            <br />
        </div>
          <div>

          </div>
        
       <div class="auto-style5">
            <asp:Button ID="btnEntrar" runat="server" Text="Iniciar sesion" style="margin: 10px" OnClick="btnEntrar_Click" /> 

       </div>
     </div>

    </form>
</body>
</html>
