// Assuming 'token' is a string containing the access token
HttpContext.Response.Cookies.Append("access_token", token, new CookieOptions { HttpOnly = true });
