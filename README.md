# SalesLoft API Client SDK

## Overview
This repository contains the SalesLoft API Client SDK for C#, which is auto-generated using the **Dawsonsoft ApiForge** tool. This SDK provides a convenient way to interact with the SalesLoft API using C#.

## Features
- Auto-generated client based on the **SalesLoft API**.
- Simplifies integration by providing a set of classes and methods that match the API endpoints.
- Strongly-typed data models for easy handling of API responses.
- Fully supports asynchronous operations.

## Requirements
- **.NET 6.0** or higher



## Usage


Here is a quick example of how to use the SDK to authenticate and fetch some data:
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using DawsonSoft.Salesloft.Api.Core.Api;
using DawsonSoft.Salesloft.Api.Core.Client;
using DawsonSoft.Salesloft.Api.Core.Model;

namespace Example
{
    public class Example
    {
        public static void Main()
        {

            Configuration config = new Configuration();
            config.BasePath = "https://api.salesloft.com/v2";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DefaultApi(config);
            var id = 56;  // int? | 

            try
            {
                // Fetches an account, by ID only.
                AccountGetResponse result = apiInstance.AccountGet(id);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling DefaultApi.AccountGet: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }

        }
    }
}
```


## License
This project is licensed under the **GNU General Public License (GPL)**.

For more details, see the [LICENSE](LICENSE) file.

---

### Contributing
We welcome contributions! Please fork the repository and create a pull request if you have any improvements or bug fixes.

### Support
If you encounter any issues or have questions, feel free to open an issue in the repository.

---

Happy coding! 😊