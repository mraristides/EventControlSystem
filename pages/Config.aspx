<%@ Page Title="Config" Language="C#" MasterPageFile="~/Page.master" AutoEventWireup="true" CodeFile="Config.aspx.cs" Inherits="Config" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="BackButton" Runat="Server">

</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="Content" Runat="Server">
    <div class="row">
        <div class="col-xs-12 col-sm-6">
            <div class="border-total">                
                <div class="block text-center">  
                    <asp:Button CssClass="button" ID="InsertButton" runat="server" Text="Insert" CausesValidation="False" OnClick="InsertButton_Click"  />                  
                </div>                          
            </div>
        </div>
    </div>
</asp:Content>

