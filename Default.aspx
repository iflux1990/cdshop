<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
    <head runat="server">
        <link href="Style.css" rel="stylesheet" />
        <title>CD Shop</title>
    </head>
    <body>
        <form id="form1" runat="server">
            <div id="backgroundDiv">
                <div id="tablerowDiv">
            <asp:Panel CssClass="panelStyle" runat="server">
                <div>   
                    <h1 style="text-align: center">CD Shop</h1>
                </div>
                <hr />
                <div id="albumTable">
                    <asp:Panel ID="pnlInventory" CssClass="panelStyleForeground" runat="server">
                        <p style="font-size: 10px; text-align: center;"><i>Press "Ctrl + F" to use the browser search function.</i></p>
                        <asp:PlaceHolder ID="PlaceHolder1" runat="server"></asp:PlaceHolder><br
                        <asp:Label ID="lblAlbumCount" runat="server">Total Count:</asp:Label>
                    </asp:Panel>
                </div>
                <div id="shoppingcart" style="vertical-align: top">
                    <asp:Panel  ID="pnlCart"  CssClass="panelStyleForeground" runat="server">
                        <h2 style="text-align: center">Shopping Cart</h2>
                        <asp:Panel runat="server" CssClass="cartListPanel">
                            <asp:PlaceHolder ID="phShoppingCart" runat="server"></asp:PlaceHolder>
                        </asp:Panel>
                        <br />
                        <p style="text-align: center">
                            <asp:Button ID="btnCheckOut" runat="server" CssClass="button" Text="Check Out" Width="120px" />
                        </p>
                        <p style="text-align: center">
                            <asp:Button ID="btnEmptyCart" runat="server" CssClass="button" OnClick="btnEmptyCart_Click" Text="Empty Cart" Width="120px" />
                            <br/>
                        </p>
                    </asp:Panel>
                </div>
                <br />
                <asp:PlaceHolder ID="phError" runat="server"></asp:PlaceHolder>
                <asp:PlaceHolder ID="PlaceHolder2" runat="server"></asp:PlaceHolder>
                <hr/>
                    <p style="font-size: 12px;"><i>Lavet af <strong>Daniel Foght Jensen</strong> &amp; <strong>Ida Kristensen</strong></i> <small>the page is currently optimized for 2560x1440 resolution</small></p>

            </asp:Panel>
                    </div>
                </div>
        </form>
    </body>
</html>