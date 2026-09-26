<%@ Page Title="Pagina de Usuarios" Language="C#" MasterPageFile="~/Page.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="control_users_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Content" Runat="Server">
        <div class="row">
            <div class="col-sm-12">                    
                <div class="title-med">
                    <asp:Label CssClass="title-medium" ID="EditNomeLabel" runat="server" Text="Participantes" ></asp:Label>                    
                </div>
            </div>
            <div class="col-xs-12 col-sm-6">   
             <div class="field">
                <asp:Label CssClass="title-field" ID="QueryLabel" runat="server" Text="Pesquisar" ></asp:Label>
                <asp:TextBox ID="queryText" runat="server" ></asp:TextBox>      
                <asp:Button CssClass="button" ID="queryButton" runat="server" Text="Pesquisar" OnClick="queryButton_Click" />
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="queryText" ErrorMessage="* Digite um nome para pesquisar" ForeColor="#CC3300"></asp:RequiredFieldValidator>
                          
             
                </div>
            </div>

            <div class="col-xs-12 col-sm-6">          
                <div class="field drop">
                    <asp:Label CssClass="title-field" ID="SelectLabel" runat="server" Text="Selecione um participante" ></asp:Label>
                    <asp:DropDownList CssClass="DropClass" ID="DownList" runat="server">
                    </asp:DropDownList>
                </div>
                <div>
                    <div class="field">                    
                        <asp:Button CssClass="button" ID="editButton" runat="server" Text="Editar" OnClick="editButton_Click" CausesValidation="False" />
                    </div>
                    <div class="field">                    
                        <asp:Button CssClass="button" ID="deleteButton" runat="server" Text="Apagar" OnClick="deleteButton_Click" CausesValidation="False" />
                    </div>
                </div>
                <div class="field block">
                <asp:Button CssClass="button" ID="registerButton" runat="server" Text="Adicionar Novo Participante" OnClick="registerButton_Click" CausesValidation="False" />
                </div>
            </div>           


            <div class="col-xs-12" style="margin-top: 30px">   
                <div class="field">
                 <asp:Label CssClass="title-field" ID="PendenteLabel" runat="server" Text="Pagamentos Pendentes" ></asp:Label>
                <asp:ListBox ID="pendenteList" runat="server" Height="150px" Width="100%"></asp:ListBox>
                <asp:Button CssClass="button" ID="pagoButton" runat="server" Text="Pago" OnClick="pagoButton_Click" CausesValidation="False" />
                </div>           
            
            </div>
        </div>
</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="BackButton" Runat="Server">
    <asp:Button CssClass="button-voltar" ID="backButton" runat="server" Text="Voltar" CausesValidation="False" OnClick="backButton_Click"  />
</asp:Content>


