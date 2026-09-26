<%@ Page Title="Pagina de Eventos" Language="C#" MasterPageFile="~/Page.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="control_event_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Content" Runat="Server">
    <div class="row">        
        <div class="col-xs-12">               
            <div class="title-med">
                <asp:Label CssClass="title-medium" ID="EditNomeLabel" runat="server" Text="Eventos" ></asp:Label> 
            </div>
        </div>
        <div class="col-xs-12 col-sm-6 ">
            <div>                
                <asp:Label CssClass="title-field" ID="QueryLabel" runat="server" Text="Pesquisar Eventos" ></asp:Label>
            </div>
            <div class="field block" style="max-width: 400px">                    
                <asp:TextBox ID="QueryText" runat="server"></asp:TextBox>
            </div>
            <div class="field">                
                <asp:Button CssClass="button" ID="QueryButton" runat="server" Text="Pesquisar" OnClick="QueryButton_Click" />
            </div>   
        </div>
        <div class="col-xs-12 col-sm-6">
            <div>                
                <asp:Label CssClass="title-field" ID="EditLabel" runat="server" Text="Selecione um Evento" ></asp:Label>
            </div>
            <div class="field drop">
                <asp:DropDownList CssClass="DropClass" ID="DownList" runat="server">
                </asp:DropDownList>
            </div>    
            <div>      
                <asp:Button CssClass="button" ID="EditButton" runat="server" OnClick="EditButton_Click" Text="Editar" />
                <asp:Button CssClass="button" ID="ApagarButton" runat="server" OnClick="ApagarButton_Click" Text="Apagar" />
            </div>  
        </div>
        <div class="col-xs-12 col-sm-12 text-center">   
            <hr /> 
            <div class="field" style="max-width:250px">                
                <asp:Button CssClass="button" ID="RegisterButton" runat="server" OnClick="RegisterButton_Click" Text="Cadastrar Novo" />
            </div>        
        </div>

     </div>    

</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="BackButton" Runat="Server">
    <asp:Button CssClass="button-voltar" ID="backButton" runat="server" Text="Voltar" CausesValidation="False" OnClick="backButton_Click"  />
</asp:Content>



