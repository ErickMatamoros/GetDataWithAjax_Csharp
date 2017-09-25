<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="AjaxTable._default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
    <link href="js/bootstrap/dist/css/bootstrap.min.css" rel="stylesheet" />
    <link href="css/style.css" rel="stylesheet" />
</head>
<body>
    <div class="content">
        <div class="col-md-8 col-lg-2">
            <button id="btnGetTable" class="btn btn-primary">Obtener Datos</button>
            <button id="btnBorrar" class="btn btn-danger">Borrar Datos</button>
        </div>
        <div class="col-md-4 col-lg-10">
            <table class="table table-hover">
                <thead>
                    <tr>
                        <th>EmployeeID</th>
                        <th>FirstName</th>
                        <th>LastName</th>
                        <th>Birthday</th>
                        <th>Age</th>
                    </tr>
                </thead>
                <tbody>
                    <tr>
                        <td>EmployeeID</td>
                        <td>FirstName</td>
                        <td>LastName</td>
                        <td>Birthday</td>
                        <td>Age</td>
                    </tr>
                </tbody>
            </table>
        </div>
    </div>


    <script src="js/jquery-3.2.1.min.js"></script>
    <script src="js/bootstrap/dist/css/bootstrap.min.js"></script>
    <script>
        //Erase table data
        $("#btnBorrar").on("click", function (e) {
            $("table tbody").html("<tr><td>EmployeeID</td><td>FirstName</td><td>LastName</td><td>Birthday</td><td>Age</td></tr>");
        });

        //Get data from the database using Ajax
        $("#btnGetTable").on("click", function (e) {
            $.ajax({
                url: "default.aspx/LoadEmployees",
                data: {},
                dataType: "json",
                type: "POST",
                contentType: "application/json; charset=utf-8",
                success: function (data) {
                    var items = data.d;
                    var fragment = "";
                    $.each(items, function (index, val) {
                        var EmployeeID = val.EmployeeID
                        var FirstName = val.FirstName;
                        var LastName = val.LastName;
                        var Birthday = val.BirthDate;
                        var Age = val.Age;
                        fragment += "<tr><td>" + EmployeeID + "</td><td>" + FirstName + "</td><td>" +
                            LastName + "</td><td>" + Birthday + "</td><td>" + Age + "</td></tr>";
                    });
                    $("table tbody").html(fragment);
                },
                error: function (result) {
                    console.log("ERROR " + result.status + ' ' + result.statusText);
                }
            });
        });
    </script>
</body>
</html>
