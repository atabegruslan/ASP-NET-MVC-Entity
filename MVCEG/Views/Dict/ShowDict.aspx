<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<MVCEG.Models.Dict>" %>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <h2>Contents of Dict</h2>
    <%=Model.Key %>
    <%=Model.Value %>

</asp:Content>
