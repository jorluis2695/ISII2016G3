﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="postulacion.aspx.cs" Inherits="Vista.postulacion" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <meta name="description" content="">
    <meta name="author" content="">

    <title>Examen de Postulación</title>

    <!-- PACE LOAD BAR PLUGIN - This creates the subtle load bar effect at the top of the page. -->
    <link href="css/plugins/pace/pace.css" rel="stylesheet">
    <script src="js/plugins/pace/pace.js"></script>

    <!-- GLOBAL STYLES - Include these on every page. -->
    <link href="css/plugins/bootstrap/css/bootstrap.min.css" rel="stylesheet">
    <link href='http://fonts.googleapis.com/css?family=Ubuntu:300,400,500,700,300italic,400italic,500italic,700italic' rel="stylesheet" type="text/css">
    <link href='http://fonts.googleapis.com/css?family=Open+Sans:300italic,400italic,600italic,700italic,800italic,400,300,600,700,800' rel="stylesheet" type="text/css">
    <link href="icons/font-awesome/css/font-awesome.min.css" rel="stylesheet">

    <!-- PAGE LEVEL PLUGIN STYLES -->
    <link href="css/plugins/bootstrap-timepicker/bootstrap-timepicker.min.css" rel="stylesheet">
    <link href="http://code.jquery.com/ui/1.10.3/themes/smoothness/jquery-ui.css" type="text/css" rel="stylesheet">
    <link href="css/plugins/bootstrap-tokenfield/tokenfield-typeahead.css" rel="stylesheet">
    <link href="css/plugins/bootstrap-tokenfield/bootstrap-tokenfield.css" rel="stylesheet">
    <link href="css/plugins/bootstrap-datepicker/datepicker3.css" rel="stylesheet">

    <!-- THEME STYLES - Include these on every page. -->
    <link href="css/style.css" rel="stylesheet">
    <link href="css/plugins.css" rel="stylesheet">

    <!-- THEME DEMO STYLES - Use these styles for reference if needed. Otherwise they can be deleted. -->
    <link href="css/demo.css" rel="stylesheet">

    <script src="http://code.jquery.com/ui/1.10.3/jquery-ui.js"></script>
    <script src="js/plugins/bootstrap/bootstrap.min.js"></script>
    <script src="js/plugins/slimscroll/jquery.slimscroll.min.js"></script>
    <script src="js/plugins/popupoverlay/jquery.popupoverlay.js"></script>
    <script src="js/plugins/popupoverlay/defaults.js"></script>
    <script src="js/plugins/popupoverlay/logout.js"></script>
    <!-- HISRC Retina Images -->
    <script src="js/plugins/hisrc/hisrc.js"></script>

    <!-- PAGE LEVEL PLUGIN SCRIPTS -->
    <script src="js/plugins/bootstrap-tokenfield/bootstrap-tokenfield.min.js"></script>
    <script src="js/plugins/bootstrap-tokenfield/scrollspy.js"></script>
    <script src="js/plugins/bootstrap-tokenfield/affix.js"></script>
    <script src="js/plugins/bootstrap-tokenfield/typeahead.min.js"></script>
    <script src="js/plugins/bootstrap-maxlength/bootstrap-maxlength.js"></script>
    <script src="js/plugins/bootstrap-timepicker/bootstrap-timepicker.min.js"></script>
    <script src="js/plugins/bootstrap-datepicker/bootstrap-datepicker.js"></script>

    <!-- THEME SCRIPTS -->
    <script src="js/flex.js"></script>
    <script src="js/demo/advanced-form-demo.js"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="wrapper">

        <!-- begin TOP NAVIGATION -->
        <nav class="navbar-top" role="navigation">

            <!-- begin BRAND HEADING -->
            <div class="navbar-header">
                <button type="button" class="navbar-toggle pull-right" data-toggle="collapse" data-target=".sidebar-collapse">
                    <i class="fa fa-bars"></i> Menu
                </button>
                <div class="navbar-brand">
                    <a href="index.html">
                        <img src="img/logo.png" class="img-responsive" alt="">
                    </a>
                </div>
            </div>
            <!-- end BRAND HEADING -->

            <div class="nav-top">

                <!-- begin LEFT SIDE WIDGETS -->
                <ul class="nav navbar-left">
                    <li class="tooltip-sidebar-toggle">
                        <a href="#" id="sidebar-toggle" data-toggle="tooltip" data-placement="right" title="Sidebar Toggle">
                            <i class="fa fa-bars"></i>
                        </a>
                    </li>
                    <!-- You may add more widgets here using <li> -->
                </ul>
                <!-- end LEFT SIDE WIDGETS -->

                <!-- begin MESSAGES/ALERTS/TASKS/USER ACTIONS DROPDOWNS -->
                <ul class="nav navbar-right">

                    <!-- begin MESSAGES DROPDOWN -->
                    
                        <!-- /.dropdown-menu -->
                    </li>
                    <!-- /.dropdown -->
                    <!-- end MESSAGES DROPDOWN -->

                    <!-- begin ALERTS DROPDOWN -->
                    <li class="dropdown">
                        <a href="#" class="dropdown-toggle" data-toggle="dropdown">
                            <i class="fa fa-user"></i>  <i class="fa fa-caret-down"></i>
                        </a>
                        <ul class="dropdown-menu dropdown-user">
                            <li>
                                <a href="profile.html">
                                    <i class="fa fa-user"></i> My Profile
                                </a>
                            </li>
                            <li>
                                <a href="mailbox.html">
                                    <i class="fa fa-envelope"></i> My Messages
                                    <span class="badge green pull-right">4</span>
                                </a>
                            </li>
                            <li>
                                <a href="#">
                                    <i class="fa fa-bell"></i> My Alerts
                                    <span class="badge orange pull-right">9</span>
                                </a>
                            </li>
                            <li>
                                <a href="#">
                                    <i class="fa fa-tasks"></i> My Tasks
                                    <span class="badge blue pull-right">10</span>
                                </a>
                            </li>
                            <li>
                                <a href="calendar.html">
                                    <i class="fa fa-calendar"></i> My Calendar
                                </a>
                            </li>
                            <li class="divider"></li>
                            <li>
                                <a href="#">
                                    <i class="fa fa-gear"></i> Settings
                                </a>
                            </li>
                            <li>
                                <a class="logout_open" href="#logout">
                                    <i class="fa fa-sign-out"></i> Logout
                                    <strong>Estudiante</strong>
                                </a>
                            </li>
                        </ul>
                        <!-- /.dropdown-menu -->
                    </li>
                        <!-- /.dropdown-menu -->
                    </li>
                    <!-- /.dropdown -->
                    <!-- end ALERTS DROPDOWN -->

                    <!-- begin TASKS DROPDOWN -->
                    

                            <!-- Tasks Dropdown Footer -->
                            

                        </ul>
                        <!-- /.dropdown-menu -->
                    </li>
                    <!-- /.dropdown -->
                    <!-- end TASKS DROPDOWN -->

                    <!-- begin USER ACTIONS DROPDOWN -->
                    
                    <!-- /.dropdown -->
                    <!-- end USER ACTIONS DROPDOWN -->

                </ul>
                <!-- /.nav -->
                <!-- end MESSAGES/ALERTS/TASKS/USER ACTIONS DROPDOWNS -->

            </div>
            <!-- /.nav-top -->
        </nav>
        <!-- /.navbar-top -->
        <!-- end TOP NAVIGATION -->

        <!-- begin SIDE NAVIGATION -->
        <nav class="navbar-side" role="navigation">
            <div class="navbar-collapse sidebar-collapse collapse">
                <ul id="side" class="nav navbar-nav side-nav">
                    <!-- begin SIDE NAV USER PANEL -->
                    <li class="side-user hidden-xs">
                        <img class="img-circle" src="img/profile-pic.jpg" alt="">
                        <p class="welcome">
                            <i class="fa fa-key"></i> Logged in as
                        </p>
                        <p class="name tooltip-sidebar-logout">
                            
                            <span class="last-name">Estudiante</span> <a style="color: inherit" class="logout_open" href="#logout" data-toggle="tooltip" data-placement="top" title="Logout"><i class="fa fa-sign-out"></i></a>
                        </p>
                        <div class="clearfix"></div>
                    </li>
                    <!-- end SIDE NAV USER PANEL -->
                    <!-- begin SIDE NAV SEARCH -->
                    <li class="nav-search">
                        <form role="form">
                            <input type="search" class="form-control" placeholder="Search...">
                            <button class="btn">
                                <i class="fa fa-search"></i>
                            </button>
                        </form>
                    </li>
                    <!-- end SIDE NAV SEARCH -->
                    <!-- begin DASHBOARD LINK -->
                    
                    <!-- end DASHBOARD LINK -->
                    <!-- begin CHARTS DROPDOWN -->
                  
                    <!-- end CHARTS DROPDOWN -->
                    <!-- begin FORMS DROPDOWN -->
                    <li class="panel">
                        <a href="javascript:;" data-parent="#side" data-toggle="collapse" class="accordion-toggle" data-target="#forms">
                            <i class="fa fa-edit"></i> Pruebas <i class="fa fa-caret-down"></i>
                        </a>
                        <ul class="collapse nav in" id="forms">
                           
							<li>
                                <a href="aptitudes.aspx">
                                    <i class="fa fa-angle-double-right"></i> Prueba de Aptitudes
                                </a>
                            </li>
							<li>
                                <a href="postulacion.aspx">
                                    <i class="fa fa-angle-double-right"></i> Prueba de Postulacion
                                </a>
                            </li>
							<li>
                                <a href="calif_est.html">
                                    <i class="fa fa-angle-double-right"></i> Calificaciones
                                </a>
                            </li>
                        </ul>
                    </li>
                    <!-- end FORMS DROPDOWN -->
                    <!-- begin CALENDAR LINK -->
                   
                    <!-- end CALENDAR LINK -->
                    <!-- begin TABLES DROPDOWN -->
                   
                    <!-- end UI ELEMENTS DROPDOWN -->
                    <!-- begin MESSAGE CENTER DROPDOWN -->
                    
                    </li>
                    <!-- end PAGES DROPDOWN -->
                </ul>
                <!-- /.side-nav -->
            </div>
            <!-- /.navbar-collapse -->
        </nav>
        <!-- /.navbar-side -->
        <!-- end SIDE NAVIGATION -->

        <!-- begin MAIN PAGE CONTENT -->
        <div id="page-wrapper">

            <div class="page-content">

                <!-- begin PAGE TITLE ROW -->
                <div class="row">
                    <div class="col-lg-12">
                        <div class="page-title">
                            <h1>Examen de Postulación
                                <small>Sobre 100 puntos</small>
                            </h1>
                        </div>
                    </div>
                    <!-- /.col-lg-12 -->
                </div>
                <!-- /.row -->
                <!-- end PAGE TITLE ROW -->

                <!-- begin ADVANCED FORM COMPONENTS MAIN ROW -->
                <div class="row">

                    <div class="col-lg-6">

                        <div class="row">

                            <div class="col-lg-12" id="TestEspacio" runat="server">
							
							
							
                            </div>
							
                            <!-- /.col-lg-12 (nested) -->

                        </div>
                        <!-- /.row (nested) -->

                    </div>
                    <!-- /.col-lg-6 -->

                    <div class="col-lg-6">

                        <div class="row">

                                <!-- Form Controls -->
                            <div class="col-lg-12">
                                
                                <!-- /.portlet -->
                            </div>
							
                            <!-- /.col-lg-12 (nested) -->
                        </div>
                        <!-- /.row (nested) -->

                    </div>
                    <!-- /.col-lg-6 -->

                </div>
                <!-- /.row -->
                <!-- end ADVANCED FORM COMPONENTS MAIN ROW -->

            </div>
            <!-- /.page-content -->

        </div>
        <!-- /#page-wrapper -->
        <!-- end MAIN PAGE CONTENT -->

    </div>
    <div id="logout">
        <div class="logout-message">
            <img class="img-circle img-logout" src="img/profile-pic.jpg" alt="">
            <h3>
                <i class="fa fa-sign-out text-green"></i> Ready to go?
            </h3>
            <p>Select "Logout" below if you are ready<br> to end your current session.</p>
            <ul class="list-inline">
                <li>
                    <a href="login.html" class="btn btn-green">
                        <strong>Logout</strong>
                    </a>
                </li>
                <li>
                    <button class="logout_close btn btn-green">Cancel</button>
                </li>
            </ul>
        </div>
    </div>
</asp:Content>