<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="CurrencyAggregationApp.Default" %>
<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="utf-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <title>Service</title>
    <link href="styles/css/bootstrap.min.css" rel="stylesheet">
    <link href="styles/css/style.css" rel="stylesheet">
    <link href="styles/font-awesome-4.7.0/css/font-awesome.min.css" rel="stylesheet" />
    <link href="https://fonts.googleapis.com/css?family=Source+Sans+Pro:300,400,700,300italic,400italic,700italic" rel="stylesheet" type="text/css">
</head>
<body>
    <header id="top" class="header">
        <div class="text-vertical-center">
            <h1>Aggregation web-service of exchange rates</h1>
            <h3>Created by Tatiana Zhydeikina</h3>
            <br>
            <form action="http://localhost:63242/CurrencyAggregationWebService.asmx/GetCurrenciesAggregation" method="POST">
                <label for="dateStart">Start date:</label>
                <input class="form-control" type="date" name="dateStart" value="2016-01-01"><br>
                <label for="dateEnd">End date:</label>
                <input class="form-control" type="date" name="dateEnd" value="2017-01-03"><br>
                <label for="mode">Mode:</label>
                <select class="form-control" name="mode">
                    <option value="0">First variant</option>
                    <option value="1">Second variant</option>
                </select><br>
                <input type="submit" value="Result" style="margin: 0% 40%; width: 200px !important;" class="btn btn-dark btn-lg">
            </form>
        </div>
    </header>
    <footer class="call-to-action bg-primary">
        <div class="container">
            <div class="row">
                <div class="col-lg-10 col-lg-offset-1 text-center">
                    <h4><strong>Test task</strong></h4>
                    <ul class="list-unstyled">
                        <li><i class="fa fa-envelope-o fa-fw"></i> <p id="email">zhidejkina@gmail.com</p>
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
