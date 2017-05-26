﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="CurrencyAggregationApp.Default" %>
<!DOCTYPE html>
<html lang="en">

<head>
    <meta charset="utf-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <title>Service</title>
    <link href="css/bootstrap.min.css" rel="stylesheet">
    <link href="css/style.css" rel="stylesheet">
    <link href="font-awesome/css/font-awesome.min.css" rel="stylesheet" type="text/css">
    <link href="https://fonts.googleapis.com/css?family=Source+Sans+Pro:300,400,700,300italic,400italic,700italic" rel="stylesheet" type="text/css">

</head>

<body>
    <div id="top" class="header">
        <div class="text-vertical-center">
            <h1>Aggregation web-service of exchange rates</h1>
            <h3>Created by Tatiana Zhydeikina</h3>
            <br>
            <form action="http://localhost:63242/CurrencyAggregationWebService.asmx/GetCurrenciesAggregation" method="POST">
                <label for="dateStart">Start date:</label>
                <input class="frmInput" type="date" size="50" name="dateStart"><br>
                <label for="dateEnd">End date:</label>
                <input class="frmInput" type="date" size="50" name="dateEnd"><br>
                <label for="mode">Mode:</label>
                <select name="mode">
                    <option value="0">First variant</option>
                    <option value="1">Second variant</option>
                </select><br>
                <input type="submit" value="Result" class="button">
                <%--<a href="#about" class="btn btn-dark btn-lg">Result</a>--%>
            </form>
        </div>
    </div>
	
    <footer class="call-to-action bg-primary">
        <div class="container">
            <div class="row">
                <div class="col-lg-10 col-lg-offset-1 text-center">
                    <h4><strong>Test task</strong></h4>
                    <ul class="list-unstyled">
                        <li><i class="fa fa-envelope-o fa-fw"></i> <a href="zhidejkina@gmail.com">zhidejkina@gmail.com</a>
                        </li>
                    </ul>
                    <br>
                    <ul class="list-inline" style="color:white;">
                        <li>
                            <a href="https://github.com/CSJedi" style="color:white;"><i class="fa fa-github fa-fw fa-3x"></i></a>
                        </li>
                        <li>
                            <a href="https://www.linkedin.com/in/tatiana-zhydeikina-395ab4b6/" style="color:white;"><i class="fa fa-linkedin fa-fw fa-3x"></i></a>
                        </li>
                        <li>
                    </ul>
                    <hr class="small">
                    <p>Copyright &copy; 2017</p>
                </div>
            </div>
        </div>
        <a id="to-top" href="#top" class="btn btn-dark btn-lg"><i class="fa fa-chevron-up fa-fw fa-1x"></i></a>
    </footer>

</body>

</html>