
@{
    Layout = null;
}

<!DOCTYPE html>

<html>
<head>
    <meta name="viewport" content="width=device-width" />
    <title>Index</title>
</head>
<body>
    <div> 
        <h1>Hy!!!!.It is the first Example</h1>
    </div>
    <div>
        <h1>Current Time is : @DateTime.Now.ToString("T")</h1>
        <script>alert('Welcome to Razor ASP.NET MVC !')</script>
        @("<script>alert('this is alert box')</script>")
    </div>
    <div>
       @{ var name = "Razor ASP.NET MVC";
            <h4>Welcome to the @name</h4>
           }
    </div>
    <div>
        @{ var f = 3;
            var Cost = 20;
            var value = 25;
            var data = "shaikfirdos1998@gmail.com";
            var f1 = true;
            var favCartoon = new List<string>() { "Dora", "Shinchan", "Doraemon" };
            }
       
        @for (var i = 1; i < 5; i++)
        {
            @(f * i);
        }
    </div>
    <div>
     
        @if (Cost > 100)
        {
            <p>The cost is greater than 100</p>
        }
        else
        {
            <p>The cost is less than 100</p>
        }
    </div>
    <div>
        @switch (value)
        {
            case 1:
                <p>You Entered 1</p><br />
                break;
            case 25:
                <p>You Entered 25</p><br />
                break;
            default:
                <p>You entered something than 1 and 25.</p><br />
                break;
        }
    </div>
    <div>
       <label>My Email Address is - @data</label> <br />
    </div>
    <div>
        @(f1 == true ? "You Like Choco" : "You Hate Choco")

    </div>
    <div>
        @foreach(var i in favCartoon)
        {
           <p>List of the Favourite Cartoons are : @i</p><br />
        }
    </div>
</body>
</html>

EXAMPLE-2


@{
    Layout = null;
}

<!DOCTYPE html>

<html>
<head>
    <meta name="viewport" content="width=device-width" />
    <title>Index</title>
</head>
<body>
    <div> 
        <h1>This is Example 2</h1>
    </div>
    <div>
        <h1>This is an example for Single line expression</h1><br />
        <h1>Addition of two numbers @(80+90)</h1><br />

    </div>
    <div>
        @{ 
            var a = "Data";
            var b = "Base";
            var c = a + b;
            var DotNetTechnology = new List<string>() { "C-SHARP", "OOPS", "HTML", "CSS", "BOOTSTRAP", "ANGULAR", "ASP.NET MVC" };
            var val = 1;
            var value = "DotNetCourses";
        }
    </div>
    <div>
        @foreach(var h1 in DotNetTechnology)
        {
        <p>List of Courses for DotNetTechnology : <b>@h1</b> </p><br />
        }
    </div>
    <div>
        @if(val==1)
        {
            <p>
                Given Number is one
            </p>
        }
    </div>
    <div>
        @switch (value)
        {
            case "C-Sharp":
                <p>You Selected C-Sharp</p><br />
                break;
            case "HTML":
                <p>You Selected Angular</p><br />
                break;
            default:
                <p>The Course is not available</p><br />
                break;
        }
    </div>
</body>
</html>

EXAMPLE-3


@{
    Layout = null;
}

<!DOCTYPE html>

<html>
<head>
    <meta name="viewport" content="width=device-width" />
    <title>Index</title>
</head>
<body>
    <div> 
        @{ 
            var i = "SHAIK FIRDOS";
            var Greetings = new List<string>() { "HI", "HELLO", "HEY" };
            var h = "panipuri";
            var j = 45;
            }
    </div>
    <div>
        @i
    </div>
    <div>
        @foreach(var J in Greetings)
        {
        <p>@J</p><br />
        }
    </div>
    <div>
        @if(h== "panipuri")
        {
            <p>You Order is Panipuri</p>
        }
        else
        {
            <p>You Order is Noodles</p>
        }
    </div>
    <div>
        @for (int i1 = 0; i1 <= 5; i1++)

        {
           <label>i = @i1</label><br />
        }
    </div>
    <div>
        @if(j%2!=0)
        {
            <p>Given number is odd</p>
        }
    </div>
</body>
</html>

