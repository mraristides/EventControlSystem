<%@ Page Title="Inicio" Language="C#" MasterPageFile="~/Page.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" ClientIDMode="Inherit" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="Content" Runat="Server">
    <div class="row">
        <div class="col-xs-12 col-sm-6">
            <div class="border-total  text-center">
                <div>
                    <asp:Label CssClass="title-medium" ID="LabelAcessar" runat="server" Text="Acessar Temporada"></asp:Label>
                </div>
                <div class="field drop" style="margin-top: 20px;">
                    <asp:DropDownList CssClass="DropClass" ID="DropDownSeason" runat="server" >
                    </asp:DropDownList>                       
                 </div>    
                <div class="field block">
                </div>
                <div class="block text-center" style="margin-top:10px">                    
                    <asp:Button CssClass="button" ID="editButton" runat="server" Text="Entrar" CausesValidation="False" OnClick="editButton_Click" />
                </div>   
            </div>
            
            
        </div>
        <div class="col-xs-12 col-sm-6">
            <div class="border-total text-left">
                <div>
                    <asp:Label CssClass="title-medium" ID="LabelCreateSeason" runat="server" Text="Criar Nova Temporada"></asp:Label>
                </div>
                <div class="field block" style="margin-top: 20px">
                    <asp:Label CssClass="title-field" ID="NewTemporadaLabel" runat="server" Text="Nome" ></asp:Label>
                    <asp:TextBox ID="nameSeasonText" runat="server" ></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="nameSeasonText" ErrorMessage="* Digite um nome para Temporada" ForeColor="#CC3300"></asp:RequiredFieldValidator>            
                
                </div>
            <div class="field block">
                <asp:Label CssClass="title-field" ID="LabelData" runat="server" Text="Data emitida no certificado" ></asp:Label>
                <asp:TextBox ID="DataText" Text="No dia xx de xxxxx de xxxx" runat="server" ></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="dataText" ErrorMessage="* Insira uma Data" ForeColor="#CC3300"></asp:RequiredFieldValidator>            
                
            </div>

                <div class="field block">
                    <asp:Label CssClass="title-field" ID="LabelModeloCertificado" runat="server" Text="Modelo do Certificado" ></asp:Label>
                    
                    <asp:DropDownList CssClass="DropClass" ID="DropCertificadosModelo" runat="server" >
                        <asp:ListItem>CreaJR</asp:ListItem>
                        <asp:ListItem>Semea</asp:ListItem>
                    </asp:DropDownList>                       
                </div>

                <div class="field">
                    <asp:Button CssClass="button" ID="seasonButton" runat="server" Text="Nova Temporada"  OnClick="seasonButton_Click" />
                </div>

                <asp:ValidationSummary ID="ValidationSummary" runat="server" ShowMessageBox="True" ShowSummary="False" />
            </div>
        </div>
    </div>
</asp:Content>

