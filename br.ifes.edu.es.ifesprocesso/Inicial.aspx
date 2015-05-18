<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Inicial.aspx.cs" Inherits="br.ifes.edu.es.ifesprocesso.Inicial" %>

!DOCTYPE html>
<html lang="en">
	<head>
		<meta http-equiv="content-type" content="text/html; charset=UTF-8">
		<meta charset="utf-8">
		<title>Starter Template (3.0)</title>
		<meta name="generator" content="Bootply" />
		<meta name="viewport" content="width=device-width, initial-scale=1, maximum-scale=1">
		<link href="css/bootstrap.min.css" rel="stylesheet">
		<!--[if lt IE 9]>
			<script src="//html5shim.googlecode.com/svn/trunk/html5.js"></script>
		<![endif]-->
		<link href="css/styles.css" rel="stylesheet">
	</head>
	<body>
<div class="navbar navbar-inverse navbar-fixed-top">
  <div class="container">
    <div class="navbar-header">
      <button type="button" class="navbar-toggle" data-toggle="collapse" data-target=".navbar-collapse">
        <span class="icon-bar"></span>
        <span class="icon-bar"></span>
        <span class="icon-bar"></span>
      </button>
      <a class="navbar-brand" href="#">Inicio</a>
    </div>
    <div class="collapse navbar-collapse">
      <ul class="nav navbar-nav">
        <li><a href="Cadastrar_Setor.aspx">Cadastar Setor</a></li>
        <li><a href="Cadastrar_Processo.aspx">Cadastrar Processo</a></li>
        
              </ul>
    </div><!--/.nav-collapse -->
  </div>
</div>
       
  <br />
               
  <br />
               
  <br />       
  <br />       
  <br />       
  <br />       
  <br />
        <div class="container" runat="server" >
  
  <div class="text-center" runat="server" >
      <!--tabs-->
      <div class="container" runat="server" >
        <ul class="nav nav-tabs" id="myTab" runat="server" >
          <li class="active"><a href="#profile" data-toggle="tab">Meus Processos</a></li>
          <li><a href="#messages" data-toggle="tab">Messages</a></li>
          <li><a href="#settings" data-toggle="tab">Settings</a></li>
        </ul>
           <form id="form1" runat="server">
        <div class="tab-content" runat="server" >
          <div class="tab-pane active" id="profile" runat="server" >
    
              <ContentTemplate>
             
                    <asp:GridView ID="gv_MeusProcessos" runat="server" CssClass="table table-hover table-striped"
                        CellPadding="2"  AutoGenerateColumns="False" Width="100%"                         OnRowDataBound="gv_MeusProcessos_RowDataBound">
                        <Columns>
                                 <asp:TemplateField HeaderText="Requerente do Processo">
                                <ItemTemplate>
                                    <asp:Label ID="lblrequerente" runat="server"></asp:Label></ItemTemplate>
                            </asp:TemplateField>

                             <asp:TemplateField HeaderText="Descrição do Processo">
                                <ItemTemplate>
                                    <asp:Label ID="lbldescricao" runat="server"></asp:Label></ItemTemplate>
                            </asp:TemplateField>

                               <asp:TemplateField HeaderText="Protocolo">
                                <ItemTemplate>
                                    <asp:Label ID="lblprotocolo" runat="server"></asp:Label></ItemTemplate>
                            </asp:TemplateField>

                              <asp:TemplateField HeaderText="Ultimo Setor">
                                <ItemTemplate>
                                    <asp:Label ID="lblSetor" runat="server"></asp:Label></ItemTemplate>
                            </asp:TemplateField>
                                                      
                        </Columns>
                    </asp:GridView>
                </ContentTemplate>
            </div>
          <div class="tab-pane" id="messages">
        
              <ContentTemplate>
             
                    <asp:GridView ID="gv_processospendentes" runat="server" CssClass="table table-hover table-striped"
                        CellPadding="2"  AutoGenerateColumns="False" Width="100%"                         OnRowDataBound="gv_processospendentes_RowDataBound">
                        <Columns>
                                 <asp:TemplateField HeaderText="Requerente do Processo">
                                <ItemTemplate>
                                    <asp:Label ID="lblrequerente" runat="server"></asp:Label></ItemTemplate>
                            </asp:TemplateField>

                             <asp:TemplateField HeaderText="Descrição do Processo">
                                <ItemTemplate>
                                    <asp:Label ID="lbldescricao" runat="server"></asp:Label></ItemTemplate>
                            </asp:TemplateField>

                               <asp:TemplateField HeaderText="Protocolo">
                                <ItemTemplate>
                                    <asp:Label ID="lblprotocolo" runat="server"></asp:Label></ItemTemplate>
                            </asp:TemplateField>

                              <asp:TemplateField HeaderText="Ultimo Setor">
                                <ItemTemplate>
                                    <asp:Label ID="lblSetor" runat="server"></asp:Label></ItemTemplate>
                            </asp:TemplateField>
                                                      
                        </Columns>
                    </asp:GridView>
                </ContentTemplate>
          
          </div>
          <div class="tab-pane" id="settings">
                       <ContentTemplate>
             
                    <asp:GridView ID="GridView1" runat="server" CssClass="table table-hover table-striped"
                        CellPadding="2"  AutoGenerateColumns="False" Width="100%"                         OnRowDataBound="gv_processospendentes_RowDataBound">
                        <Columns>
                                 <asp:TemplateField HeaderText="Requerente do Processo">
                                <ItemTemplate>
                                    <asp:Label ID="lblrequerente" runat="server"></asp:Label></ItemTemplate>
                            </asp:TemplateField>

                             <asp:TemplateField HeaderText="Descrição do Processo">
                                <ItemTemplate>
                                    <asp:Label ID="lbldescricao" runat="server"></asp:Label></ItemTemplate>
                            </asp:TemplateField>

                               <asp:TemplateField HeaderText="Protocolo">
                                <ItemTemplate>
                                    <asp:Label ID="lblprotocolo" runat="server"></asp:Label></ItemTemplate>
                            </asp:TemplateField>

                              <asp:TemplateField HeaderText="Ultimo Setor">
                                <ItemTemplate>
                                    <asp:Label ID="lblSetor" runat="server"></asp:Label></ItemTemplate>
                            </asp:TemplateField>
                                                      
                        </Columns>
                    </asp:GridView>
                </ContentTemplate>
          </div>
          
        </div>
             </form>
      </div>
      
      <!--/tabs-->
  </div>
  
</div>
        
        
        
        
                    
    
     











	</body>
    		<script src="//ajax.googleapis.com/ajax/libs/jquery/2.0.2/jquery.min.js"></script>
    <script src="Scripts/bootstrap.min.js"></script>
<link href="Content/styles.css" rel="stylesheet" />
<link href="Content/Site.css" rel="stylesheet" />
<link href="Content/bootstrap.min.css" rel="stylesheet" />
</html>