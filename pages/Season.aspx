<%@ Page Title="Season" Language="C#" MasterPageFile="~/Page.master" AutoEventWireup="true" CodeFile="Season.aspx.cs" Inherits="_Season" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Content" Runat="Server">
        
       <div class="row">       
           <div class="col-sm-6 text-center">      
                <div style="margin:20px 0;">
                    <span>Selecione a opção que deseja ter acesso:</span>
                </div>     

                <div style="margin: 2px 0;">
                    <asp:Button CssClass="button" ID="EventButton" runat="server" Text="Eventos" OnClick="EventButton_Click" />  
                </div>   
                <div style="margin: 2px 0;">
                    <asp:Button CssClass="button" ID="UsersButton" runat="server" OnClick="UsersButton_Click" TabIndex="1" Text="Participantes" />
                </div>                     
                <div style="margin: 2px 0;">
                    <asp:Button CssClass="button" ID="GerarCrachar"  runat="server" Text="Gerar Crachás" OnClick="GerarCrachar_Click" /> 
                </div>
                <div style="margin: 2px 0;">
                    <asp:Button CssClass="button" ID="GerarButton"  runat="server" Text="Gerar Certificado" OnClick="GerarButton_Click" /> 
                </div>    
                <div style="margin-top: 30px">
                <asp:LinkButton ID="DeleteButton" CssClass="display-none" runat="server"  OnClick="DeleteButton_Click">Apagar Temporada</asp:LinkButton>      
                </div> 
            </div>   
            <div class="col-sm-4">                
                <div class="field drop" style="margin-top: 20px;">
                    <div>
                    <asp:Label CssClass="title-medium" ID="LabelCreateSeason" runat="server" Text="Temporada"></asp:Label>
                    </div>
                    <asp:Label CssClass="title-field" ID="LabelCertificado" runat="server" Text="Certificado" ></asp:Label>                    
                    <asp:DropDownList CssClass="DropClass" ID="DropCertificado" runat="server" >
                        <asp:ListItem>CreaJR</asp:ListItem>
                        <asp:ListItem>Semea</asp:ListItem>
                    </asp:DropDownList>                       
                </div>  
                <div class="field block">
                    <asp:Label CssClass="title-field" ID="LabelData" runat="server" Text="Data emitida no certificado" ></asp:Label>
                    <asp:TextBox ID="DataText" runat="server" ></asp:TextBox>                    
                </div>
                <div class="field block">
                     <asp:Button CssClass="button" ID="ButtonUpdateSeason"  runat="server" Text="Atualizar" OnClick="ButtonUpdateSeason_Click" />
            
                </div>
            </div>
        </div>
        
    <asp:GridView ID="Gv" runat="server"></asp:GridView>
        
</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="BackButton" Runat="Server">
    <asp:Button CssClass="button-voltar" ID="backButton" runat="server" Text="Voltar" CausesValidation="False" OnClick="backButton_Click"  />
</asp:Content>
