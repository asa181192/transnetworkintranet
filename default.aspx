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
                                       <asp:DropDownList ID="DropDownServer"  Class="form-control" runat="server" Width="170px" Height="30px">
                                           <asp:ListItem Text="Todos" Value="0" />
                                       </asp:DropDownList>
                                            
                                         <asp:TextBox ID="busqueda" Class="form-control" placeholder="Search" runat="server"></asp:TextBox>
                                          <asp:Button ID="Button1" Class="btn btn-default" runat="server" Text="Aceptar" OnClick="Button1_Click"/>
                                        
                                          
                                          </div>
                                           
                                    </div>
                                  
                 </div>         
                  
                  <div class="col-md-3"  >
                       </div>
                                            
                 </div>
                        

                              
                        <div class="row">
                             <div class="col-md-2"  >
                             </div>
                            <div class="col-md-7">                      
                                 <asp:GridView id="GridviewData" runat="server" Width="488px"  class="table table-striped" AutoGenerateColumns="false" OnRowDataBound="GridviewData_DataBound">

                                     <Columns>
                                         <asp:BoundField DataField="Servidor" HeaderText="Servidor" />
                                         <asp:BoundField DataField="Servicio" HeaderText="Servicio" />
                                         <asp:BoundField DataField="Estatus" HeaderText="Estatus" />
                                         <asp:BoundField DataField="Inicio" HeaderText="Inicio" />
                                         <asp:BoundField DataField="Cuenta" HeaderText="Cuenta" />
                                         <asp:BoundField DataField="TipoServidor" HeaderText="TipoServidor" />
                                         <asp:BoundField DataField="ServidorRespaldo" HeaderText="ServidorRespaldo" />
                                     </Columns>

                                 </asp:GridView>
                                                       
                            </div>                         
                              <div class="col-md-3"  >
                       </div>
                 </div>
       
        </form>   
    </div>

</asp:Content>
