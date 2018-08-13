<%@ Page Language="C#" AutoEventWireup="true" CodeFile="index.aspx.cs" Inherits="index" %>


<!doctype html>
<html xmlns="http://www.w3.org/1999/xhtml">

<head runat="server">
	<meta charset="utf-8">
    <meta name="viewport" content="width=device-width, maximum-scale=1"/>
	<title>Homepage</title>
    <link rel="icon" href="favicon.jpg" type="image/png"/>
    <link href="css/bootstrap.css" rel="stylesheet" type="text/css"/>
    <link href="css/style.css" rel="stylesheet" type="text/css"/>
    <link href="css/linecons.css" rel="stylesheet" type="text/css"/>
    <link href="css/font-awesome.css" rel="stylesheet" type="text/css"/>
    <link href="css/responsive.css" rel="stylesheet" type="text/css"/>
    <link href="css/animate.css" rel="stylesheet" type="text/css"/>

    <link href='https://fonts.googleapis.com/css?family=Lato:400,900,700,700italic,400italic,300italic,300,100italic,100,900italic' rel='stylesheet' type='text/css'/>
    <link href='https://fonts.googleapis.com/css?family=Dosis:400,500,700,800,600,300,200' rel='stylesheet' type='text/css'/>

	<!-- =======================================================
    Theme Name: Butterfly
    Theme URL: https://bootstrapmade.com/butterfly-free-bootstrap-theme/
    Author: BootstrapMade
    Author URL: https://bootstrapmade.com
	======================================================= -->

	<script type="text/javascript" src="js/jquery.1.8.3.min.js"></script>
	<script type="text/javascript" src="js/bootstrap.js"></script>
	<script type="text/javascript" src="js/jquery-scrolltofixed.js"></script>
	<script type="text/javascript" src="js/jquery.easing.1.3.js"></script>
	<script type="text/javascript" src="js/jquery.isotope.js"></script>
	<script type="text/javascript" src="js/wow.js"></script>
	<script type="text/javascript" src="js/classie.js"></script>

	<script type="text/javascript">
	    $(document).ready(function (e) {
	        $('.res-nav_click').click(function () {
	            $('ul.toggle').slideToggle(600);
	        });

	        $(document).ready(function () {
	            $(window).bind('scroll', function () {
	                if ($(window).scrollTop() > 0) {
	                    $('#header_outer').addClass('fixed');
	                } else {
	                    $('#header_outer').removeClass('fixed');
	                }
	            });

	        });


	    });

	    function resizeText() {
	        var preferredWidth = 767;
	        var displayWidth = window.innerWidth;
	        var percentage = displayWidth / preferredWidth;
	        var fontsizetitle = 25;
	        var newFontSizeTitle = Math.floor(fontsizetitle * percentage);
	        $(".divclass").css("font-size", newFontSizeTitle);
	    }
	</script>
    <style type="text/css">
        .auto-style1 {
            width: 589px;
            height: 452px;
        }
    </style>
</head>

<body style="background-image:none">

	<!--Header_section-->
	<header id="header_outer">
		<div class="container">
			<div class="header_section">
				<div class="logo"><a href="javascript:void(0)"><img src="img/logo.jpg" width="49" height="45" alt=""></a></div>
				<nav class="nav" id="nav">
					<ul class="toggle">
						<li><h1><a href="#top_content">Home</a></h1></li>
						<li><a href="#service">Serviços</a></li>
						<li><a href="#work_outer">PDV</a></li>
						<li><a href="#contact">Contato</a></li>
                        <li><a href="#contact">Login</a></li>
					</ul>
					<ul class="">
						<li><a href="#top_content">Home</a></li>
						<li><a href="#service">Serviços</a></li>
						<li><a href="#work_outer">PDV</a></li>
						<li><a href="#contact">Contato</a></li>
                        <li><a href="login.aspx">Login</a></li>
					</ul>
				</nav>
				<a class="res-nav_click animated wobble wow" href="javascript:void(0)"><i class="fa-bars"></i></a> </div>
		</div>
	</header>
	<!--Header_section-->

	<!--Top_content-->
	<section id="top_content" class="top_cont_outer">
		<div class="top_cont_inner">
			<div class="container">
				<div class="top_content">
					<div class="row">
						<div class="col-lg-5 col-sm-7">
							<div class="top_left_cont flipInY wow animated">
								
								<h2>Supermercado</h2>
								<p>O supermercado está localizado na Aldeia de Barueri, contém muitos produtos e uma boa administração. O supermercado, no ano de 2017 adquiriu um sistema para gerenciamento evitando qualquer problema, afim de proporcionar uma maior qualidade nos serviços para seus clientes. O supermercado possui uma variedade de produtos das melhores marcas com os melhores preços. &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </p>
                                <br/>
                                <br/>
                                <br/>
                                <br/>
                                <br/>
								<h2>Dicas do Supermercado - Receitas</h2>
                                <h1>BOLO DE CHOCOLATE</h1>
                                <h3>Ingredientes</h3>
                                <p>- 4 ovos</p>
                                <p>- 4 colheres (sopa) de chocolate em pó</p>
                                <p>- 2 colheres (sopa) de manteiga</p>
                                <p>- 3 xícaras (chá) de farinha de trigo</p>
                                <p>- 2 xícaras (chá) de açucar</p>
                                <p>- 2 colheres (sopa) de fermento</p>
                                <p>- 1 xícaras (chá) de leite</p>
                                <h3>Modo de preparo</h3>
                                 <p>1- Em um liquidificador adicione os ovos, o chocolate em pó, a manteiga, a farinha de trigo, o açucar e o leite, depois bata por 5 minutos.</p>
                                 <p>2- Adicione o fermento e misture com uma espátula delicadamente</p>
                                 <p>3- Em uma forma untada, despeje a massa e asse em forno médio 180°C, preaquecido por cerca de 40 minutos</p>
                                <a href="#service" class="learn_more2">Ver Mais</a> </div>
						</div>
						<div class="col-lg-7 col-sm-5"> 
                            <img alt="" class="auto-style1" src="img/images.jpg" /><br />
                            <br />
                            <br />
                            <br />
                            <br />
                            <br />
                            <br />
                            <br />
                            <img alt="" class="auto-style1" src="img/bolochoco.jpg" /></div>
					</div>
				</div>
			</div>
		</div>
	</section>
	<!--Top_content-->

	<!--Service-->
	<section id="service">
		<div class="container">
			<h2>Serviços</h2>
			<div class="service_area">
				<div class="row">
					<div class="col-lg-4">
						<div class="service_block">
							<div class="service_icon delay-03s animated wow  zoomIn"> <span><i class="fa-flash"></i></span> </div>
							<h3 class="animated fadeInUp wow">Eficiencia Máxima</h3>
							<p class="animated fadeInDown wow">Desenvolvendo projetos com o maior nivel de organização e eficiencia possivel, utilizando as últimas ferramentas de desenvolvimento do mercado. O novo sistema oferece qualidade tanto no gerenciamento de pessoas, como o gerencimento de produtos visando uma melhor qualidade para os clientes. </p>
						</div>
					</div>
					<div class="col-lg-4">
						<div class="service_block">
							<div class="service_icon icon2  delay-03s animated wow zoomIn"> <span><i class="fa-comments"></i></span> </div>
							<h3 class="animated fadeInUp wow">Suporte Amigavel</h3>
							<p class="animated fadeInDown wow">Caso haja problemas temos o suporte 24hrs por dia, 7 dias da semana para ajuda-lo. A equipe do supermercado está pronta para resolver qualquer problema.</p>
						</div>
					</div>
					<div class="col-lg-4">
						<div class="service_block">
							<div class="service_icon icon3  delay-03s animated wow zoomIn"> <span><i class="fa-shield"></i></span> </div>
							<h3 class="animated fadeInUp wow">Segurança Máxima</h3>
							<p class="animated fadeInDown wow">Niveis de acesso bem definidos. A equipe responsável pelo supermercado possui um nível de acesso no web site para administrar as principais rotinas do supermercado mesmo a distância.</p>
						</div>
					</div>
				</div>
			</div>
		</div>
	</section>
	<!--Service-->

	<section id="work_outer">
		<!--main-section-start-->
		<div class="top_cont_latest">
			<div class="container">
				<div class="work_section">
					<div class="row">
						<div class="col-lg-6 col-sm-6 wow fadeInLeft delay-05s">
							<div class="service-list">
								<div class="service-list-col1"> <i class="icon-comment"></i> </div>
								<div class="service-list-col2">
									<h3>Suporte 24/7</h3>
								</div>
							</div>

							<div class="service-list">
								<div class="service-list-col1"> <i class="icon-database"></i> </div>
								<div class="service-list-col2">
									<h3>Banco de dados Oracle</h3>
									
								</div>
							</div>
							<div class="service-list">
								<div class="service-list-col1"> <i class="icon-cog"></i> </div>
								<div class="service-list-col2">
									<h3>Opções de alterações</h3>
									
								</div>
							</div>
							<div class="work_bottom"> <span>Pronto para ajudar?</span> <a href="#contact" class="contact_btn">Contate</a> </div>
						</div>
						
					</div>
				</div>
			</div>
		</div>
	</section>
	<!--main-section-end-->

	
	<!--
<section class="main-section paddind" id="Portfolio">
	<div class="container">
    	<h2>Portfolio</h2>
    	<h6>Fresh portfolio of designs that will keep you wanting more.</h6>
	</div>


</section>

-->

	
	
	<!--c-logo-part-end-->
	<section class="main-section team" id="team" style="background-color:black">
		
	
			<footer class="footer_section" id="contact">
		<div class="container">
			<section class="main-section contact" id="contact">
				<div class="contact_section">
					<h2>Contato</h2>
					<div class="row">
						<div class="col-lg-4">
							<div class="contact_block">
								<div class="contact_block_icon rollIn animated wow"><span><i class="fa-home"></i></span></div>
								<span> Endereço ...<br/>
              </span> </div>
						</div>
						<div class="col-lg-4">
							<div class="contact_block">
								<div class="contact_block_icon icon2 rollIn animated wow"><span><i class="fa-phone"></i></span></div>
								<span> (11)93232-3232 </span> </div>
						</div>
						<div class="col-lg-4">
							<div class="contact_block">
								<div class="contact_block_icon icon3 rollIn animated wow"><span><i class="fa-pencil"></i></span></div>
								<span> <a href="mailto:email@email.com"> email@email.com</a> </span> </div>
						</div>
					</div>
				</div>
				<div class="row" style="background-color:black">
					<div class="col-lg-6 wow fadeInLeft">
						<div class="contact-info-box address clearfix">
							<h3>Nos mande algo</h3>
							<p>Caso encontre algum erro nos avise</p>
							
						</div>
						<ul class="social-link">
							<li class="twitter animated bounceIn wow delay-02s"><a href="javascript:void(0)"><i class="fa-twitter"></i></a></li>
							<li class="facebook animated bounceIn wow delay-03s"><a href="javascript:void(0)"><i class="fa-facebook"></i></a></li>
							<li class="pinterest animated bounceIn wow delay-04s"><a href="javascript:void(0)"><i class="fa-pinterest"></i></a></li>
							<li class="gplus animated bounceIn wow delay-05s"><a href="javascript:void(0)"><i class="fa-google-plus"></i></a></li>
							<li class="dribbble animated bounceIn wow delay-06s"><a href="javascript:void(0)"><i class="fa-dribbble"></i></a></li>
						</ul>
					</div>
					<div class="col-lg-6 wow fadeInUp delay-06s">
						<div class="form">
							<div id="sendmessage"></div>
							<div id="errormessage"></div>
							<form action="" method="post" role="form" class="contactForm">
								<div class="form-group">
									<input type="text" name="name" class="form-control input-text" id="name" placeholder="Seu nome" data-rule="minlen:4" data-msg="Tem que haver pelomenos 4 caractéres" />
									<div class="validation"></div>
								</div>
								<div class="form-group">
									<input type="email" class="form-control input-text" name="email" id="email" placeholder="Seu Email" data-rule="email" data-msg="Por favor entre um email valido" />
									<div class="validation"></div>
								</div>
								<div class="form-group">
									<input type="text" class="form-control input-text" name="subject" id="subject" placeholder="Assunto" data-rule="minlen:4" data-msg="Tem que haver pelomenos 8 caractéres" />
									<div class="validation"></div>
								</div>
								<div class="form-group">
									<textarea class="form-control" name="message" rows="5" data-rule="required" data-msg="Escreva algo" placeholder="Mensagem"></textarea>
									<div class="validation"></div>
								</div>

								<button type="submit" class="btn input-btn" runat="server">Enviar</button>
							</form>
						</div>
					</div>
				</div>
			</section>
		</div>
		<div class="container">
			<div class="footer_bottom">
				<span>© PDV WEB</span>
				<div class="credits">
			
					
				</div>
			</div>
		</div>
	</footer>
   </section>
	<script type="text/javascript">
	    $(document).ready(function (e) {
	        $('#header_outer').scrollToFixed();
	        $('.res-nav_click').click(function () {
	            $('.main-nav').slideToggle();
	            return false

	        });

	    });
	</script>
	<script>
	    wow = new WOW({
	        animateClass: 'animated',
	        offset: 100
	    });
	    wow.init();
	    document.getElementById('').onclick = function () {
	        var section = document.createElement('section');
	        section.className = 'wow fadeInDown';
	        section.className = 'wow shake';
	        section.className = 'wow zoomIn';
	        section.className = 'wow lightSpeedIn';
	        this.parentNode.insertBefore(section, this);
	    };
	</script>
	<script type="text/javascript">
	    $(window).load(function () {

	        $('a').bind('click', function (event) {
	            var $anchor = $(this);

	            $('html, body').stop().animate({
	                scrollTop: $($anchor.attr('href')).offset().top - 91
	            }, 1500, 'easeInOutExpo');
	            /*
				if you don't want to use the easing effects:
				$('html, body').stop().animate({
					scrollTop: $($anchor.attr('href')).offset().top
				}, 1000);
				*/
	            event.preventDefault();
	        });
	    })
	</script>

	<script type="text/javascript">
	    jQuery(document).ready(function ($) {
	        // Portfolio Isotope
	        var container = $('#portfolio-wrap');


	        container.isotope({
	            animationEngine: 'best-available',
	            animationOptions: {
	                duration: 200,
	                queue: false
	            },
	            layoutMode: 'fitRows'
	        });

	        $('#filters a').click(function () {
	            $('#filters a').removeClass('active');
	            $(this).addClass('active');
	            var selector = $(this).attr('data-filter');
	            container.isotope({
	                filter: selector
	            });
	            setProjects();
	            return false;
	        });


	        function splitColumns() {
	            var winWidth = $(window).width(),
					columnNumb = 1;


	            if (winWidth > 1024) {
	                columnNumb = 4;
	            } else if (winWidth > 900) {
	                columnNumb = 2;
	            } else if (winWidth > 479) {
	                columnNumb = 2;
	            } else if (winWidth < 479) {
	                columnNumb = 1;
	            }

	            return columnNumb;
	        }

	        function setColumns() {
	            var winWidth = $(window).width(),
					columnNumb = splitColumns(),
					postWidth = Math.floor(winWidth / columnNumb);

	            container.find('.portfolio-item').each(function () {
	                $(this).css({
	                    width: postWidth + 'px'
	                });
	            });
	        }

	        function setProjects() {
	            setColumns();
	            container.isotope('reLayout');
	        }

	        container.imagesLoaded(function () {
	            setColumns();
	        });


	        $(window).bind('resize', function () {
	            setProjects();
	        });

	    });
	    $(window).load(function () {
	        jQuery('#all').click();
	        return false;
	    });
	</script>
	<script src="contactform/contactform.js"></script>

</body>
</html>
