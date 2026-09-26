<%@ Page Title="Participante" Language="C#" MasterPageFile="~/Page.master" AutoEventWireup="true" CodeFile="Edit.aspx.cs" Inherits="control_users_Edit" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Content" Runat="Server">
        <div class="row">
            <div class="col-sm-12">                    
                <div class="title-med">
                    <asp:Label CssClass="title-medium" ID="EditNomeLabel" runat="server" Text="" ></asp:Label>                    
                </div>        

                <!-- HORAS -->
                <div class="header-infos hora"><i class="fa fa-clock-o" aria-hidden="true"></i><span>Total de Horas: <asp:Label ID="HorasLabel" runat="server" Text="0" Font-Bold="True"></asp:Label> </span>
                </div>
                
            </div>
            <div class="col-xs-12 col-sm-7">

                <!-- NOME -- -->
                <div class="field block">
                <asp:Label CssClass="title-field" ID="NomeLabel" runat="server" Text="Nome" >
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="nomeText" ErrorMessage="Digite um Nome" ForeColor="#CC3300">*</asp:RequiredFieldValidator></asp:Label>                   
                <asp:TextBox ID="nomeText" runat="server" Width="100%"></asp:TextBox>
                 </div>

                <!-- RG -->
                <div class="field">
                <asp:Label CssClass="title-field" ID="RGLabel" runat="server" Text="RG" >
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="rgText" ErrorMessage="Digite o RG" ForeColor="#CC3300">*</asp:RequiredFieldValidator></asp:Label>
                <asp:TextBox ID="rgText" runat="server"></asp:TextBox>
                <ajaxToolkit:MaskedEditExtender ID="rgText_MaskedEditExtender" runat="server" BehaviorID="rgText_MaskedEditExtender" Century="2000" CultureAMPMPlaceholder="" CultureCurrencySymbolPlaceholder="" CultureDateFormat="" CultureDatePlaceholder="" CultureDecimalPlaceholder="" CultureThousandsPlaceholder="" CultureTimePlaceholder="" TargetControlID="rgText" Mask="LL-99,999,999" />
                
                </div>
                

                <!-- TELEFONE -->
                <div class="field">
                <asp:Label CssClass="title-field" ID="TelefoneLabel" runat="server" Text="Telefone" ></asp:Label>
                <asp:TextBox ID="telefoneText" runat="server"></asp:TextBox>
                <ajaxToolkit:MaskedEditExtender ID="telefoneText_MaskedEditExtender" runat="server" BehaviorID="telefoneText_MaskedEditExtender" Century="2000" CultureAMPMPlaceholder="" CultureCurrencySymbolPlaceholder="" CultureDateFormat="" CultureDatePlaceholder="" CultureDecimalPlaceholder="" CultureThousandsPlaceholder="" CultureTimePlaceholder="" TargetControlID="telefoneText" Mask="(99) 9999-9999" />                
                </div>


                <!-- CELULAR -->
                <div class="field">
                <asp:Label CssClass="title-field" ID="CelularLabel" runat="server" Text="Celular"></asp:Label>
                <asp:TextBox ID="celularText" runat="server"></asp:TextBox>
                <ajaxToolkit:MaskedEditExtender ID="celularText_MaskedEditExtender" runat="server" BehaviorID="celularText_MaskedEditExtender" Century="2000" CultureAMPMPlaceholder="" CultureCurrencySymbolPlaceholder="" CultureDateFormat="" CultureDatePlaceholder="" CultureDecimalPlaceholder="" CultureThousandsPlaceholder="" CultureTimePlaceholder="" TargetControlID="celularText" Mask="(99) 99999-9999" />                
                </div>

                
        
                <!-- EMAIL -->
                <div class="field">
                <asp:Label CssClass="title-field" ID="EmailLabel" runat="server" Text="Email">
                <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="emailText" ErrorMessage="Digite um Email Correto" ForeColor="#CC3300" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*">*</asp:RegularExpressionValidator></asp:Label>
                <asp:TextBox ID="emailText" runat="server"></asp:TextBox>
                
                </div>    

                <!-- MEMBRO -->
                <div class="field down">
                <asp:Label CssClass="title-field" ID="MembroLabel" runat="server" Text="Membro"></asp:Label>
                <asp:DropDownList CssClass="DropClass" ID="DownListMembro" runat="server">
                <asp:ListItem Value="1">SIM</asp:ListItem>
                <asp:ListItem Value="0">NÃO</asp:ListItem>
                </asp:DropDownList>                                   
                </div>

                
                
                <!-- PAGAMENTO -->
                <div class="field down">
                    <asp:Label CssClass="title-field" ID="PagamentoLabel" runat="server" Text="Pagamento"></asp:Label>
                    <asp:DropDownList CssClass="DropClass" ID="DownListPagamento" runat="server">
                        <asp:ListItem Value="1">PAGO</asp:ListItem>
                        <asp:ListItem Value="0">PENDENTE</asp:ListItem>
                    </asp:DropDownList>
                </div>        

                
                <div>
                <!-- CURSO -->
                <div class="field">
                <asp:Label CssClass="title-field" ID="CursoLabel" runat="server" Text="Curso"></asp:Label>
                <asp:TextBox ID="cursoText" runat="server" ></asp:TextBox>                
                </div>        
                
                <!-- PERIODO -->
                <div class="field">
                <asp:Label CssClass="title-field" ID="PeriodoLabel" runat="server" Text="Periodo"></asp:Label>
                <asp:TextBox ID="periodoText" runat="server" Width="50px" TextMode="Number"></asp:TextBox>                
                </div></div>
                
                      
                <!-- ENSINO -->
                <div class="field block">
                <asp:Label CssClass="title-field" ID="EnsinoLabel" runat="server" Text="Instituição de Ensino"></asp:Label>
                <asp:TextBox ID="ensinoText" runat="server" Width="100%"></asp:TextBox>
                </div>              

                               

         </div>
        <div class="col-xs-12 col-sm-5">  
            <!-- EVENTOS -->
            <div class="field block">
                <asp:Label CssClass="title-field" ID="EventosLabel" runat="server" Text="Eventos"></asp:Label>
                <asp:DropDownList CssClass="DropClass" ID="EventDownList" width="230px" runat="server">
                </asp:DropDownList>
                <asp:Button  ID="addEventButton" runat="server" OnClick="addEventButton_Click" Text="+" CausesValidation="False" ViewStateMode="Enabled" Width="30px" Height="30px"/>               
                
            </div>
            <div class="field block">
                <asp:ListBox ID="eventsUserList" runat="server" Height="120px" Width="230px"></asp:ListBox>
            </div>            
                
            <div class="field block">
                <asp:Button CssClass="button" ID="AbrirCrachar" runat="server" Text="Abrir Crachar" OnClick="AbrirCrachar_Click"/>                
            </div>
            <div class="field block">
                <asp:Button CssClass="button" ID="AbrirCertificado" runat="server" Text="Abrir Certificado" OnClick="AbrirCertificado_Click"/>                
            </div>

            <!-- SUMARIO -->
            <asp:ValidationSummary ID="ValidationSummary1" runat="server" ShowMessageBox="True" />

        </div> 
        <div class="col-sm-12 text-center" style="margin-top:30px;">      
            <asp:Button CssClass="button" ID="submitButton" runat="server" OnClick="submitButton_Click"  />
        </div>

    </div>   
</asp:Content>


<asp:Content ID="Content3" ContentPlaceHolderID="BackButton" Runat="Server">
    <asp:Button CssClass="button-voltar" ID="backButton" runat="server" Text="Voltar" CausesValidation="False" OnClick="backButton_Click"  />
</asp:Content>

