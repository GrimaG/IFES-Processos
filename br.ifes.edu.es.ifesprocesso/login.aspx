<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="br.ifes.edu.es.ifesprocesso.login" %>

<html lang="pt-br">

<head>
    <meta charset="utf-8">
    <title>IFes</title>
    <meta name="description" content="description">
    <meta name="author" content="DevOOPS">
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <link href="plugins/bootstrap/bootstrap.css" rel="stylesheet">
    <link href="plugins/jquery-ui/jquery-ui.min.css" rel="stylesheet">
    <link href="http://netdna.bootstrapcdn.com/font-awesome/4.0.3/css/font-awesome.css" rel="stylesheet">
    <link href='http://fonts.googleapis.com/css?family=Righteous' rel='stylesheet' type='text/css'>
    <link href="plugins/fancybox/jquery.fancybox.css" rel="stylesheet">
    <link href="plugins/fullcalendar/fullcalendar.css" rel="stylesheet">
    <link href="plugins/xcharts/xcharts.min.css" rel="stylesheet">
    <link href="plugins/select2/select2.css" rel="stylesheet">
    <link href="css/style.css" rel="stylesheet">
    <!-- HTML5 shim and Respond.js IE8 support of HTML5 elements and media queries -->
    <!--[if lt IE 9]>
				<script src="http://getbootstrap.com/docs-assets/js/html5shiv.js"></script>
				<script src="http://getbootstrap.com/docs-assets/js/respond.min.js"></script>
		<![endif]-->
</head>

<body>
 
   
    <div class="col-xs-12 col-sm-12">
		<div class="box ui-draggable ui-droppable">
			<div class="box-header">
							<div class="no-move"></div>
			</div>
			<div class="box-content" style="display: block;">
				<h4 class="page-header">Acesso</h4>
				<form id="Form1" class="form-horizontal" role="form" runat="server">
					<div class="form-group">
						<label class="col-sm-2 control-label">Nome</label>
						<div class="col-sm-4">
							<input  id="txtnome" runat="server" type="text" class="form-control" placeholder="First name" data-toggle="tooltip" data-placement="bottom" title="" data-original-title="Tooltip for name">
						</div>
										</div>
					<div class="form-group has-success has-feedback">
						<label class="col-sm-2 control-label">Senha</label>
						<div class="col-sm-4">
							<input id="txtsenha" runat="server" type="text" class="form-control" placeholder="Senha" data-original-title="" title="">
                                    <asp:Button ID="btn_Cadastrar" runat="server" Text="Logar" Style="float: right"
                            OnClick="btnsenha_Click"  class="btn btn-primary">
                        </asp:Button>
						</div>
                        				
               
					
					</div>
				
				<div class="col-sm-9 col-sm-offset-3">
			
						</div>
				</form>
			</div>
		</div>
	</div>
    
</body>
<script src="Scripts/bootstrap.min.js"></script>
<link href="Content/styles.css" rel="stylesheet" />
<link href="Content/Site.css" rel="stylesheet" />
<link href="Content/bootstrap.min.css" rel="stylesheet" />
</html>
