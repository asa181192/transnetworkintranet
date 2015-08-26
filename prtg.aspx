<%@ Page Title="" Language="C#" MasterPageFile="./Site1.Master" AutoEventWireup="true" CodeBehind="prtg.aspx.cs" Inherits="intranet.routing.prtg" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   
    <div class="container">
    <div class="row">
      
        <div class="col-md-9" >

                     <iframe src="http://monitor.transnetwork.com:8181/group.htm?id=0&tabid=1"
                        style="height: 700px; width: 1000px; margin-top: 3px;" id="Iframe1" name="Iframe1" > </iframe>
                       </div>



        <div class="col-md-3"  >
                       </div>


    </div>

    </div>
   
</asp:Content>
