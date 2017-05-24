# IO.Swagger - ASP.NET Core 1.0 Server

 # Introduction   Welcome to the reference for my API!   <a href=\"http://en.wikipedia.org/wiki/REST_API\" target=\"_blank\">REST</a> is a web-service protocol that lends itself to rapid development by using everyday HTTP and JSON technology.   My REST API provides a broad set of operations and resources that:  * Enable x.  * Support y.  * Process z.   ## Endpoints   My API is provided via the following endpoints.   | Tenant                 | Base URL for REST Endpoints    |  |- -- -- -- -- -- -- -- -- -- -- -- -|- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -|  | Production             | https://api.mydomain.com/v1    |  | API Sandbox            | https://sandbox.mydomain.com/v1|     The production endpoint provides access to your live user data. The API Sandbox tenant is a good place to test your code without affecting real-world data. To use it, you must be provisioned with an API Sandbox tenant.   ## Access to the API   If you have a tenant, you already have access to the API.   If you don't have a tenant, go to <a href=\"https://www.mydomain.com/resource/sandbox\" target=\"_blank\">https://www.mydomain.com/resource/sandbox</a> and sign up for a one. # Operations:  ## Basic Info  These are the basic operations for my API...   etc 

## Run

Linux/OS X:

```
sh build.sh
```

Windows:

```
build.bat
```

## Run in Docker

```
cd src/IO.Swagger
docker build -t IO.Swagger .
docker run -p 5000:5000 IO.Swagger
```
