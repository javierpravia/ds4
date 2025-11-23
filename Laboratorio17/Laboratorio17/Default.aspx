<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Laboratorio17._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">



        <div class="row">
            <asp:GridView id="MyGridView" DataSourceID="MyDataSource1"
                AllowSorting="True" AllowingPaging="True"
                DataKeyNames="ProductID"
                AutoGenerateEditButton="True"
                Runat="Server" />

            <asp:SqlDataSource ID="MyDataSource1" runat="server"
                ConnectionString ="Data Source=DESKTOP-0Q67IO1\SQLEXPRESS; initial catalog = Northwind;  persist security info=True;
                Integrated Security=SSPI;"
                ProviderName ="System.Data.SqlClient"
                SelectCommand ="SELECT ProductID, ProductName, UnitPrice from Products"
                UpdateCommand ="Update Products Set [ProductName] =@ProductName, [UnitPrice]=@UnitPrice
                Where [ProductId]=@ProductId">
            </asp:SqlDataSource>

        </div>


</asp:Content>
