<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PerDoctorReport.aspx.cs" Inherits="Hospital_Management_System.Reporting.PerDoctorReport" %>


 <%@Register Assembly="Microsoft.ReportViewer.WebForms, Version=11.0.0.0, Culture=neutral, PublicKeyToken=89845dcd8080cc91" Namespace="Microsoft.Reporting.WebForms" TagPrefix="rsweb" %>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:ScriptManager ID="ScriptManager_PerDoctorReport" runat="server"></asp:ScriptManager>
        <rsweb:reportviewer id="ReportViewer_PerDoctorReport"  Height="1000" Width="1300"  runat="server" asyncrendering="false"></rsweb:reportviewer>
    </form>
</body>
</html>
