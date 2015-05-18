<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Cadastrar_Processo.aspx.cs" Inherits="br.ifes.edu.es.ifesprocesso.Cadastrar_Processo"%>

<!DOCTYPE html>
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
                <a class="navbar-brand" href="Inicial.aspx">Inicio</a>
            </div>
            <div class="collapse navbar-collapse">
                <ul class="nav navbar-nav">
                    <li><a href="Cadastrar_Setor.aspx">Cadastar Setor</a></li>
                    <li><a href="Cadastrar_Processo.aspx">Cadastrar Processo</a></li>

                </ul>
            </div>
            <!--/.nav-collapse -->
        </div>
    </div>

    <br />

    <br />
    <br />


    <div class="col-xs-12 col-sm-12">
        <div class="box ui-draggable ui-droppable">
            <div class="box-header">
                <div class="no-move"></div>
            </div>
            <div class="box-content" style="display: block;">
                <h4 class="page-header">Preencha os Dados do Setor</h4>
                <form id="Form1" class="form-horizontal" role="form" runat="server">
                    <div class="form-group">
                        <label class="col-sm-2 control-label">Nome do Requerente</label>
                        <div class="col-sm-4">
                            <input id="txtnome" runat="server" type="text" class="form-control" placeholder="First name" data-toggle="tooltip" data-placement="bottom" title="" data-original-title="Tooltip for name">
                        </div>
                    </div>
                                         <div class="form-group">
                        <label class="col-sm-2 control-label">Protocolo</label>
                        <div class="col-sm-4">
                            <input id="Text1" runat="server" type="text" class="form-control" placeholder="First name" data-toggle="tooltip" data-placement="bottom" title="" data-original-title="Tooltip for name">
                        </div>
                    </div>

                                                 <div class="form-group">
                        <label class="col-sm-2 control-label">Tipo</label>
                        <div class="col-sm-4">
                            <input id="Text2" runat="server" type="text" class="form-control" placeholder="First name" data-toggle="tooltip" data-placement="bottom" title="" data-original-title="Tooltip for name">
                        </div>
                    </div>


                    <div class="form-group has-success has-feedback">
                        <label class="col-sm-2 control-label">Descrição</label>
                        <div class="col-sm-4">
                            <input id="txtresponsavel" runat="server" type="text" class="form-control" placeholder="Senha" data-original-title="" title="" />
                            <asp:Button ID="btn_Cadastrar" runat="server" Text="Salvar" Style="float: right" Width="90px"
                                OnClick="btnsenha_Click" class="btn btn-primary"></asp:Button>
                        </div>
                    </div>
                                      <div class="col-sm-9 col-sm-offset-3">
                    </div>
                </form>
            </div>
        </div>
    </div>















</body>
<script src="//ajax.googleapis.com/ajax/libs/jquery/2.0.2/jquery.min.js"></script>
<script src="Scripts/bootstrap.min.js"></script>
<link href="Content/styles.css" rel="stylesheet" />
<link href="Content/Site.css" rel="stylesheet" />
<link href="Content/bootstrap.min.css" rel="stylesheet" />
</html>
