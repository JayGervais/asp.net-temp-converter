<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Main.aspx.cs" Inherits="JayGervais_LAB1_2.Main" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Temperature Converter</title>
    <link href="Content/bootstrap.css" rel="stylesheet" />
    <link href="Styles.css" rel="stylesheet" />
</head>
<body>
  <div class="page-header jumbotron">
    
  </div>
    <div class="container">
        <form id="form1" runat="server">
        <div>

       <div class="form-group">
        <div class="row">
  		    <div class ="col-11">
               <div class="container">
               <div class="form-container">     
                   <h1 class="headertxt pb-3">Temperature Converter</h1>
                   <div class="row">
                    <div class ="col-lg-6">
                    <asp:Label ID="lblFrom" runat="server" Text="From"></asp:Label>
                    <asp:DropDownList class="form-control" ID="ddlTempSystemsFrom" runat="server" AppendDataBoundItems="True" AutoPostBack="True">
                        </asp:DropDownList>
                    </div>
                    <div class ="col-lg-6">
                    <asp:Label ID="lblTo" runat="server" Text="To"></asp:Label>
                    <asp:DropDownList class="form-control" ID="ddlTempSystemsTo" runat="server" AppendDataBoundItems="True">
                        </asp:DropDownList>
                    </div>
                </div>
                <div class="pt-3">
                    <asp:Label ID="lblInputTemp" runat="server" Text="Input Temperature"></asp:Label>&nbsp;
                    <asp:RequiredFieldValidator ID="RequiredFieldValidatorTemp" runat="server" ControlToValidate="txtTempInput" Display="Dynamic" ErrorMessage="Input temperature is required" ForeColor="#990000"></asp:RequiredFieldValidator>
                    <asp:RangeValidator ID="RangeValidatorInputTemp" runat="server" ControlToValidate="txtTempInput" Display="Dynamic" ErrorMessage="Add a number between -1000 to 1000" ForeColor="#9900CC" MaximumValue="1000" MinimumValue="-1000" Type="Integer"></asp:RangeValidator>
                    <asp:TextBox class="form-control" ID="txtTempInput" runat="server" MaxLength="50"></asp:TextBox>
                </div>
                <div class="pt-3" aria-readonly="True">
                    <asp:Label ID="lblConversion" runat="server" Text="Result"></asp:Label>
                    <asp:TextBox class="form-control" ID="txtCalcResult" runat="server" MaxLength="50" ReadOnly="True"></asp:TextBox>
                </div>
                <div class="pt-4">
                    <asp:Button ID="btnConvert" CssClass="btn btn-primary" runat="server" Text="Convert" OnClick="btnConvert_Click1" />&nbsp;<asp:Button ID="btnClear" CssClass="btn btn-primary" runat="server" Text="Clear" OnClick="btnClear_Click" CausesValidation="False" />
                </div>
                 </div>
               </div>
            
          </div>
        </div>
      </div>


        </div>
    </form>
    </div>
    
</body>
</html>
