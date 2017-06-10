<?php 
    session_start(); 
    require("includes/connection.php"); 
    if(isset($_GET['page'])){ 
          
        $pages=array("products", "cart"); 
          
        if(in_array($_GET['page'], $pages)) { 
              
            $_page=$_GET['page']; 
              
        }else{ 
              
            $_page="products"; 
              
        } 
          
    }else{ 
          
        $_page="products"; 
          
    } 
?>


<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Strict//EN" 
"http://www.w3.org/TR/xhtml1/DTD/xhtml1-strict.dtd"> 
  
<html xmlns="http://www.w3.org/1999/xhtml"> 
<head> 
      
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <link rel="shortcut icon" href="assets/images/favicon.png">
    <link rel="apple-touch-icon" href="assets/images/apple-touch-icon.png">
    <link rel="apple-touch-icon" sizes="72x72" href="assets/images/apple-touch-icon-72x72.png">
    <link rel="apple-touch-icon" sizes="114x114" href="assets/images/apple-touch-icon-114x114.png">
    <!-- Web Fonts-->
    <link href="https://fonts.googleapis.com/css?family=Poppins:500,600,700" rel="stylesheet">
    <link href="https://fonts.googleapis.com/css?family=Hind:400,700" rel="stylesheet">
    <link href="https://fonts.googleapis.com/css?family=Lora:400i" rel="stylesheet">
    <!-- Bootstrap core CSS-->
    <link href="Content/bootstrap.min.css" rel="stylesheet">
    <!-- Icon Fonts-->
    <link href="Content/font-awesome.min.css" rel="stylesheet">
    <link href="Content/linea-arrows.css" rel="stylesheet">
    <link href="Content/linea-icons.css" rel="stylesheet">
    <!-- Plugins-->
    <link href="Content/owl.carousel.css" rel="stylesheet">
    <link href="Content/magnific-popup.css" rel="stylesheet">
    <link href="Content/vertical.min.css" rel="stylesheet">
    <link href="Content/pace-theme-minimal.css" rel="stylesheet">
    <link href="Content/animate.css" rel="stylesheet">
    <!-- Template core CSS-->
    <link href="Content/template.css" rel="stylesheet">
 

      
    <title>Shopping cart</title> 
  
</head> 
  
<body> 
      
    <div id="container"> 
  
        <div id="main"> 
        
        <?php require($_page.".php"); ?>
			
              
        </div><!--end main-->
          
        <div id="sidebar"> 
              
        </div><!--end sidebar-->
  
    </div><!--end container-->
  
</body> 
</html>