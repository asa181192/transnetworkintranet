<%@ Page Title="" Language="C#" MasterPageFile="Site1.Master" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="intranet._default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
  
    <div class="container-fluid">
         <form id="Form1" runat="server" >
              <div class="row">
                   <div class="col-md-3"  >
                       </div>
                  <div class="col-md-6"  >
                                     <div class="jumbotron" >
                                      
                                          <div class="form-inline" >
                                          <label style="">Nombre del Servidor</label>
                                       <asp:DropDownList ID="DropDownServer"  Class="form-control" runat="server" Width="170px" Height="30px"> </asp:DropDownList>
                                            
                                          
                                          <asp:Button ID="Button1" Class="btn btn-default" runat="server" Text="Aceptar" OnClick="Button1_Click"/>
                                        
                                          
                                          </div>
                                           
                                    </div>
                 </div>         
                  
                  <div class="col-md-3"  >
                       </div>
                                            
                 </div>
                        

                              
                        <div class="row">
                             <div class="col-md-3"  >
                             </div>
                            <div class="col-md-6">                      
                                 <asp:GridView id="GridviewData" runat="server" Width="488px"  class="table table-striped"></asp:GridView>
                                                       
                            </div>                         
                              <div class="col-md-3"  >
                       </div>
                 </div>
       
        </form>   
    </div>

</asp:Content>
