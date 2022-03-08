﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ViewTransactionHistory.aspx.cs" Inherits="ProjectFinal.View.ViewTransactionHistory" %>

<%@ Register Assembly="CrystalDecisions.Web, Version=13.0.4000.0, Culture=neutral, PublicKeyToken=692fbea5521e1304" Namespace="CrystalDecisions.Web" TagPrefix="CR" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>View Transaction History</h1>
            <a href="HomePage.aspx">Back to HomePage</a>
            <br /> <br />
            <cr:crystalreportviewer ID="TransactionHistory" runat="server" autodatabind="true"></cr:crystalreportviewer>
        </div>
    </form>
</body>
</html>
