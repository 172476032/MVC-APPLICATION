<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>

<!DOCTYPE html>

<html>
<head runat="server">
    <meta name="viewport" content="width=device-width" />
    <title>Sysadmin</title>
</head>
<body>
    <form action="/" method="post">
        <div>
            姓名：<input type="text" name="name" value=" " />
            密码：<input type="text" name="password" value=" " />
            <input type="submit" name="login" value="登录" />
        </div>
    </form>
    <div>
        <a href="#">学员管理</a>
    </div>

</body>
</html>
