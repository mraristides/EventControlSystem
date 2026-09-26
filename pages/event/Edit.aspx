<%@ Page Title="Evento" Language="C#" MasterPageFile="~/Page.master" AutoEventWireup="true" CodeFile="Edit.aspx.cs" Inherits="control_event_Edit" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Content" Runat="Server">
        <div class="row">
            <div class="col-xs-12 col-sm-4">
                <div class="field">
                <asp:Label CssClass="title-field" ID="NomeLabel" runat="server" Text="Nome" ></asp:Label>
                <asp:TextBox ID="nomeText" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="nomeText" ErrorMessage="Digite um nome para o evento">*</asp:RequiredFieldValidator>
                </div>                
                <div class="field block">
                    <asp:Label CssClass="title-field" ID="DataLabel" runat="server" Text="Data" ></asp:Label>
                    <asp:TextBox ID="DataText" Width="170px" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldData" runat="server" ErrorMessage="Escolha uma data" ControlToValidate="DataText">*</asp:RequiredFieldValidator>
                    <ajaxToolkit:CalendarExtender ID="DataText_CalendarExtender" runat="server" BehaviorID="DataText_CalendarExtender" TargetControlID="DataText"   TodaysDateFormat="4 MMMM yyyy" />
                </div>

                <div class="field block" style="margin-top: 10px">
                    <asp:Label CssClass="title-field" ID="HorasLabel" runat="server" Text="Horario" ></asp:Label>
                    <asp:TextBox ID="timeText" runat="server" Width="85px" TextMode="Time"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="timeText" ErrorMessage="Escolha a hora">*</asp:RequiredFieldValidator>
                
                </div>
                <div class="field block">
                    <asp:Label ID="DLabel" runat="server"  Text="Duração minima do Evento" ></asp:Label>
                    <asp:TextBox ID="DuracaoEventText" runat="server" Width="50px" TextMode="Number"></asp:TextBox> Minutos    
                </div>
               
                
                            

            </div>
            <div class="col-xs-12 col-sm-4">
                 <div>                    
                    <asp:Label CssClass="title-field" ID="EventTypeLabel" runat="server" Text="Selecione o Tipo do evento" ></asp:Label>
                </div>
                <div class="field">
                    <asp:RadioButtonList ID="RadioButtonList" runat="server" Height="46px" Width="183px">
                        <asp:ListItem Selected="True" Value="QR Code">QR Code</asp:ListItem>
                        <asp:ListItem>Sem QR Code</asp:ListItem>
                    </asp:RadioButtonList>
                </div>
                <div class="field block">
                    <asp:Label ID="DuracaoLabel" runat="server"  Text="Horas Contabilizadas" ></asp:Label>
                    <asp:TextBox ID="DuracaoText" runat="server" Width="50px" TextMode="Number"></asp:TextBox>    
                </div>
            </div>
            <div class="col-xs-12 col-sm-12">   
                <div class="field" style="margin: 30px 0;">                           
                    <asp:Button CssClass="button" ID="SubmitButton" runat="server" OnClick="SubmitButton_Click" />
                </div>         
                <asp:ValidationSummary ID="ValidationSummary1" runat="server" ShowMessageBox="True" />    
            </div>
        </div>    
</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="BackButton" Runat="Server">
    <asp:Button CssClass="button-voltar" ID="backButton" runat="server" Text="Voltar" CausesValidation="False" OnClick="backButton_Click"  />
</asp:Content>



