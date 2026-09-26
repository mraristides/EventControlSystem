<%@ Page Title="Check" Language="C#" MasterPageFile="~/Page.master" AutoEventWireup="true" CodeFile="Check.aspx.cs" Inherits="Check" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Content" Runat="Server">
     <div class="container">
       <div class="row">
           <div class="col-xs-12 col-sm-12 text-center">                  
               <div class="field block">
               <asp:Label ID="Nome" runat="server" Font-Size="X-Large">Nome </asp:Label>                   
               <asp:Label ID="LabelNome" runat="server" Font-Size="Large"></asp:Label>
               </div>
               <div class="field block">
               <asp:Label ID="Evento" runat="server" Font-Size="X-Large">Evento </asp:Label>                   
               <asp:Label ID="LabelEvento" runat="server" Font-Size="Large"></asp:Label>
               </div>
               <asp:Label ID="LabelCheckin" runat="server" Font-Size="XX-Large"></asp:Label>
           </div>               
            <div class="col-xs-12 col-sm-12">            
                <div class="field block text-center">  
                    <asp:Button CssClass="button" ID="EntradaButton" runat="server" Text="Entrada" Visible="False" CausesValidation="False" OnClick="EntradaButton_Click"  />                  
                </div>  
                <div class="field block text-center">  
                    <asp:Button CssClass="button" ID="SaidaButton" runat="server" Text="Saida" Visible="False" CausesValidation="False" OnClick="SaidaButton_Click" />                  
                </div>    
            </div>            
       </div>    
     </div>
</asp:Content>


