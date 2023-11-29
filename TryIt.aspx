<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TryIt.aspx.cs" Inherits="CSE445_Project5.TryIt" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>TryIt Page</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Member Page:</h1>
            <h1>Password Management</h1>
            <p>
                <asp:TextBox ID="TextBox1" runat="server" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
                <asp:Button ID="EncryptBtn" runat="server" OnClick="EncryptBtn_Click" Text="Encrypt" />
                <asp:Button ID="DecryptBtn" runat="server" OnClick="DecryptBtn_Click" Text="Decrypt" />
            </p>
            <br />
            <asp:Label ID="lblEncryptedPassword" runat="server" />
            <br />
            <asp:Label ID="lblDecryptedPassword" runat="server" />
            <br />
        </div>
          <div>
            <h1>Web Service&nbsp;&nbsp;&nbsp; </h1>
              <p><a href="http://webstrar31.fulton.asu.edu/page1/Service1.svc" style="box-sizing: border-box; color: var(--bs-link-color); text-decoration: underline; font-family: system-ui, -apple-system, &quot;Segoe UI&quot;, Roboto, &quot;Helvetica Neue&quot;, &quot;Noto Sans&quot;, &quot;Liberation Sans&quot;, Arial, sans-serif, &quot;Apple Color Emoji&quot;, &quot;Segoe UI Emoji&quot;, &quot;Segoe UI Symbol&quot;, &quot;Noto Color Emoji&quot;; font-size: 16px; font-style: normal; font-variant-ligatures: normal; font-variant-caps: normal; font-weight: 400; letter-spacing: normal; orphans: 2; text-align: start; text-indent: 0px; text-transform: none; widows: 2; word-spacing: 0px; -webkit-text-stroke-width: 0px; white-space: normal; background-color: rgb(255, 255, 255);">http://webstrar31.fulton.asu.edu/page8/Service1.svc</a><span style="color: rgb(33, 37, 41); font-family: system-ui, -apple-system, &quot;Segoe UI&quot;, Roboto, &quot;Helvetica Neue&quot;, &quot;Noto Sans&quot;, &quot;Liberation Sans&quot;, Arial, sans-serif, &quot;Apple Color Emoji&quot;, &quot;Segoe UI Emoji&quot;, &quot;Segoe UI Symbol&quot;, &quot;Noto Color Emoji&quot;; font-size: 16px; font-style: normal; font-variant-ligatures: normal; font-variant-caps: normal; font-weight: 400; letter-spacing: normal; orphans: 2; text-align: start; text-indent: 0px; text-transform: none; widows: 2; word-spacing: 0px; -webkit-text-stroke-width: 0px; white-space: normal; background-color: rgb(255, 255, 255); text-decoration-thickness: initial; text-decoration-style: initial; text-decoration-color: initial; display: inline !important; float: none;">&nbsp;</span></p>
              <p><a href="http://localhost:65023/Service1.svc" style="box-sizing: border-box; color: var(--bs-link-color); text-decoration: underline; font-family: system-ui, -apple-system, &quot;Segoe UI&quot;, Roboto, &quot;Helvetica Neue&quot;, &quot;Noto Sans&quot;, &quot;Liberation Sans&quot;, Arial, sans-serif, &quot;Apple Color Emoji&quot;, &quot;Segoe UI Emoji&quot;, &quot;Segoe UI Symbol&quot;, &quot;Noto Color Emoji&quot;; font-size: 16px; font-style: normal; font-variant-ligatures: normal; font-variant-caps: normal; font-weight: 400; letter-spacing: normal; orphans: 2; text-align: start; text-indent: 0px; text-transform: none; widows: 2; word-spacing: 0px; -webkit-text-stroke-width: 0px; white-space: normal; background-color: rgb(255, 255, 255);">http://localhost:65023/Service1.svc</a><span style="color: rgb(33, 37, 41); font-family: system-ui, -apple-system, &quot;Segoe UI&quot;, Roboto, &quot;Helvetica Neue&quot;, &quot;Noto Sans&quot;, &quot;Liberation Sans&quot;, Arial, sans-serif, &quot;Apple Color Emoji&quot;, &quot;Segoe UI Emoji&quot;, &quot;Segoe UI Symbol&quot;, &quot;Noto Color Emoji&quot;; font-size: 16px; font-style: normal; font-variant-ligatures: normal; font-variant-caps: normal; font-weight: 400; letter-spacing: normal; orphans: 2; text-align: start; text-indent: 0px; text-transform: none; widows: 2; word-spacing: 0px; -webkit-text-stroke-width: 0px; white-space: normal; background-color: rgb(255, 255, 255); text-decoration-thickness: initial; text-decoration-style: initial; text-decoration-color: initial; display: inline !important; float: none;">&nbsp;&nbsp;&nbsp;&nbsp; 
                  please run the web service under the wcfservice2 project first</span></p>
              
              <p>
                  WordFilter Service : Analyze a string of words and filter out the function words</p>
              <p>
                  Method Name: WordFilter&nbsp;&nbsp; Input: string&nbsp;&nbsp; output: string</p>
              <p>
                  <asp:Label ID="inputLabel" runat="server" Text="Input"></asp:Label>
&nbsp;&nbsp;
                  <asp:TextBox ID="TextBox2" runat="server" Height="28px" OnTextChanged="TextBox2_TextChanged" Width="283px"></asp:TextBox>
&nbsp;&nbsp;
                  <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Filter" />
              </p>
              <p>
                  <asp:Label ID="outputLabel" runat="server" Text="Output"></asp:Label>
                  <asp:Label ID="resultLabel" runat="server"></asp:Label>
              </p>
              <p>
                  &nbsp;</p>
              <p>
                  Number2Words Service: Convert a number into an easy-to-remember character/digit string</p>
              <p>
                  Method Name: Number2Words&nbsp;&nbsp; Input: string&nbsp;&nbsp; output: string</p>
              <p>
                  &nbsp;</p>
              <p>
                  &nbsp;</p>
              <p>
                  <asp:Label ID="inputLabel1" runat="server" Text="Input"></asp:Label>
                  &nbsp;<asp:TextBox ID="TextBox3" runat="server" OnTextChanged="TextBox3_TextChanged" Width="292px"></asp:TextBox>
                  &nbsp;<asp:Button ID="ConvertButton" runat="server" OnClick="ConvertButton_Click" Text="Convert" />
              </p>
              <p>
                  <asp:Label ID="outputLabel1" runat="server" Text="Output"></asp:Label>
                  <asp:Label ID="resultLabel1" runat="server"></asp:Label>
              </p>
              <p>
                  &nbsp;</p>
              <p>
                  <span>Find random (popular) recipes:</span></p>
              <p>
                  <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Discover!" />
              </p>
              <p>
                  <asp:Label ID="Label1" runat="server" Text="Result"></asp:Label>
              </p>
              <p>
                  &nbsp;</p>
              <p>
                  <span>Get a simple description of a certain wine, e.g. &quot;malbec&quot;, &quot;riesling&quot;, or &quot;merlot&quot;.</span></p>
              <p>
                  <asp:TextBox ID="TextBox4" runat="server" OnTextChanged="TextBox4_TextChanged"></asp:TextBox>
                  <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Show me the result" />
              </p>
              <p>
                  <asp:Label ID="Label2" runat="server" Text="Result"></asp:Label>
              </p>
              <p>
                  &nbsp;</p>
              <p>
                  <span>Parse a recipe search query to find out its intention. e.g.salmon with fusilli and no nuts</span></p>
              <p>
                  <asp:TextBox ID="TextBox5" runat="server" OnTextChanged="TextBox5_TextChanged"></asp:TextBox>
                  <asp:Button ID="Button4" runat="server" OnClick="Button4_Click" Text="Search" />
              </p>
              <p>
                  <asp:Label ID="Label3" runat="server" Text="Result"></asp:Label>
              </p>
              <p>
              </p>
            <br />
        </div>

    </form>
</body>
</html>
