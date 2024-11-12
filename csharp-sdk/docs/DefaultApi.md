# DawsonSoft.Salesloft.Api.Core.Api.DefaultApi

All URIs are relative to *https://api.salesloft.com/v2*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**AccountGet**](DefaultApi.md#accountget) | **GET** /accounts/{id} | Fetches an account, by ID only. |
| [**AccountsList**](DefaultApi.md#accountslist) | **GET** /accounts | Fetches multiple account records. The records can be filtered, paged, and sorted according to the respective parameters. |
| [**ActivityHistoriesList**](DefaultApi.md#activityhistorieslist) | **GET** /activity_histories |  |
| [**CadenceExport**](DefaultApi.md#cadenceexport) | **GET** /cadence_exports/{id} | Exports a cadence as JSON. |
| [**CadenceGet**](DefaultApi.md#cadenceget) | **GET** /cadences/{id} | Fetch a cadence |
| [**CadencesList**](DefaultApi.md#cadenceslist) | **GET** /cadences | Fetches multiple cadence records. The records can be filtered, paged, and sorted according to the respective parameters. |
| [**GroupsList**](DefaultApi.md#groupslist) | **GET** /groups | Fetches multiple group records.  |
| [**NotesList**](DefaultApi.md#noteslist) | **GET** /notes | Fetches multiple note records. |
| [**PeopleUpdate**](DefaultApi.md#peopleupdate) | **PUT** /people/{id} | Update a person |
| [**PersonCreate**](DefaultApi.md#personcreate) | **POST** /people | Creates a person. Either email_address or phone/last_name must be provided as a unique lookup on the team. |
| [**PersonGet**](DefaultApi.md#personget) | **GET** /people/{id} | Fetches a person, by ID only. |
| [**PersonList**](DefaultApi.md#personlist) | **GET** /people | Fetches multiple person records. The records can be filtered, paged, and sorted according to the respective parameters. |
| [**TagsList**](DefaultApi.md#tagslist) | **GET** /tags | Fetches a list of the tags used for a team. |
| [**TeamTemplatesGet**](DefaultApi.md#teamtemplatesget) | **GET** /team_templates/{id} | Fetches a team template, by ID only. |
| [**TeamTemplatesList**](DefaultApi.md#teamtemplateslist) | **GET** /team_templates | etches multiple team template records. |
| [**UserMe**](DefaultApi.md#userme) | **GET** /me | Fetch current user |
| [**UsersList**](DefaultApi.md#userslist) | **GET** /users | Non Admin: Lists only your user, or all on team depending on group visibility policy Team Admin: Lists users associated with your team |

<a id="accountget"></a>
# **AccountGet**
> AccountGetResponse AccountGet (int? id)

Fetches an account, by ID only.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using DawsonSoft.Salesloft.Api.Core.Api;
using DawsonSoft.Salesloft.Api.Core.Client;
using DawsonSoft.Salesloft.Api.Core.Model;

namespace Example
{
    public class AccountGetExample
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
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.AccountGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AccountGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Fetches an account, by ID only.
    ApiResponse<AccountGetResponse> response = apiInstance.AccountGetWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.AccountGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int?** |  |  |

### Return type

[**AccountGetResponse**](AccountGetResponse.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Fill something |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="accountslist"></a>
# **AccountsList**
> AccountsListResponse AccountsList (int? ids = null, string? updatedAt = null, string? createdAt = null, string? sortBy = null, string? sortDirection = null, string? perPage = null, string? page = null, string? includePagingCounts = null, string? limitPagingCounts = null)

Fetches multiple account records. The records can be filtered, paged, and sorted according to the respective parameters.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using DawsonSoft.Salesloft.Api.Core.Api;
using DawsonSoft.Salesloft.Api.Core.Client;
using DawsonSoft.Salesloft.Api.Core.Model;

namespace Example
{
    public class AccountsListExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.salesloft.com/v2";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DefaultApi(config);
            var ids = 56;  // int? |  (optional) 
            var updatedAt = "updatedAt_example";  // string? | Returns all matching records that are greater than the provided iso8601 timestamp. The comparison is done using microsecond precision. (optional) 
            var createdAt = "createdAt_example";  // string? | Returns all matching records that are greater than the provided iso8601 timestamp. The comparison is done using microsecond precision. (optional) 
            var sortBy = "sortBy_example";  // string? | Key to sort on (optional) 
            var sortDirection = "sortDirection_example";  // string? | Direction to sort in, must be one of: ASC, DESC. Defaults to DESC (optional) 
            var perPage = "perPage_example";  // string? | How many records to show per page in the range [1, 100]. Defaults to 25 (optional) 
            var page = "page_example";  // string? | The current page to fetch results from. Defaults to 1 (optional) 
            var includePagingCounts = "includePagingCounts_example";  // string? | Whether to include total_pages and total_count in the metadata. Defaults to false (optional) 
            var limitPagingCounts = "limitPagingCounts_example";  // string? | Specifies whether the max limit of 10k records should be applied to pagination counts. Affects the total_count and total_pages data (optional) 

            try
            {
                // Fetches multiple account records. The records can be filtered, paged, and sorted according to the respective parameters.
                AccountsListResponse result = apiInstance.AccountsList(ids, updatedAt, createdAt, sortBy, sortDirection, perPage, page, includePagingCounts, limitPagingCounts);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.AccountsList: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AccountsListWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Fetches multiple account records. The records can be filtered, paged, and sorted according to the respective parameters.
    ApiResponse<AccountsListResponse> response = apiInstance.AccountsListWithHttpInfo(ids, updatedAt, createdAt, sortBy, sortDirection, perPage, page, includePagingCounts, limitPagingCounts);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.AccountsListWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **ids** | **int?** |  | [optional]  |
| **updatedAt** | **string?** | Returns all matching records that are greater than the provided iso8601 timestamp. The comparison is done using microsecond precision. | [optional]  |
| **createdAt** | **string?** | Returns all matching records that are greater than the provided iso8601 timestamp. The comparison is done using microsecond precision. | [optional]  |
| **sortBy** | **string?** | Key to sort on | [optional]  |
| **sortDirection** | **string?** | Direction to sort in, must be one of: ASC, DESC. Defaults to DESC | [optional]  |
| **perPage** | **string?** | How many records to show per page in the range [1, 100]. Defaults to 25 | [optional]  |
| **page** | **string?** | The current page to fetch results from. Defaults to 1 | [optional]  |
| **includePagingCounts** | **string?** | Whether to include total_pages and total_count in the metadata. Defaults to false | [optional]  |
| **limitPagingCounts** | **string?** | Specifies whether the max limit of 10k records should be applied to pagination counts. Affects the total_count and total_pages data | [optional]  |

### Return type

[**AccountsListResponse**](AccountsListResponse.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Fill something |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="activityhistorieslist"></a>
# **ActivityHistoriesList**
> ActivityHistoriesListResponse ActivityHistoriesList (int? ids = null, string? updatedAt = null, string? occurredAt = null, string? sortBy = null, string? sortDirection = null, string? perPage = null, string? page = null, string? includePagingCounts = null, string? limitPagingCounts = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using DawsonSoft.Salesloft.Api.Core.Api;
using DawsonSoft.Salesloft.Api.Core.Client;
using DawsonSoft.Salesloft.Api.Core.Model;

namespace Example
{
    public class ActivityHistoriesListExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.salesloft.com/v2";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DefaultApi(config);
            var ids = 56;  // int? |  (optional) 
            var updatedAt = "updatedAt_example";  // string? | Returns all matching records that are greater than the provided iso8601 timestamp. The comparison is done using microsecond precision. (optional) 
            var occurredAt = "occurredAt_example";  // string? | Returns all matching records that are greater than the provided iso8601 timestamp. The comparison is done using microsecond precision. (optional) 
            var sortBy = "sortBy_example";  // string? | Key to sort on (optional) 
            var sortDirection = "sortDirection_example";  // string? | Direction to sort in, must be one of: ASC, DESC. Defaults to DESC (optional) 
            var perPage = "perPage_example";  // string? | How many records to show per page in the range [1, 100]. Defaults to 25 (optional) 
            var page = "page_example";  // string? | The current page to fetch results from. Defaults to 1 (optional) 
            var includePagingCounts = "includePagingCounts_example";  // string? | Whether to include total_pages and total_count in the metadata. Defaults to false (optional) 
            var limitPagingCounts = "limitPagingCounts_example";  // string? | Specifies whether the max limit of 10k records should be applied to pagination counts. Affects the total_count and total_pages data (optional) 

            try
            {
                ActivityHistoriesListResponse result = apiInstance.ActivityHistoriesList(ids, updatedAt, occurredAt, sortBy, sortDirection, perPage, page, includePagingCounts, limitPagingCounts);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.ActivityHistoriesList: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ActivityHistoriesListWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ActivityHistoriesListResponse> response = apiInstance.ActivityHistoriesListWithHttpInfo(ids, updatedAt, occurredAt, sortBy, sortDirection, perPage, page, includePagingCounts, limitPagingCounts);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.ActivityHistoriesListWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **ids** | **int?** |  | [optional]  |
| **updatedAt** | **string?** | Returns all matching records that are greater than the provided iso8601 timestamp. The comparison is done using microsecond precision. | [optional]  |
| **occurredAt** | **string?** | Returns all matching records that are greater than the provided iso8601 timestamp. The comparison is done using microsecond precision. | [optional]  |
| **sortBy** | **string?** | Key to sort on | [optional]  |
| **sortDirection** | **string?** | Direction to sort in, must be one of: ASC, DESC. Defaults to DESC | [optional]  |
| **perPage** | **string?** | How many records to show per page in the range [1, 100]. Defaults to 25 | [optional]  |
| **page** | **string?** | The current page to fetch results from. Defaults to 1 | [optional]  |
| **includePagingCounts** | **string?** | Whether to include total_pages and total_count in the metadata. Defaults to false | [optional]  |
| **limitPagingCounts** | **string?** | Specifies whether the max limit of 10k records should be applied to pagination counts. Affects the total_count and total_pages data | [optional]  |

### Return type

[**ActivityHistoriesListResponse**](ActivityHistoriesListResponse.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Fill something |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="cadenceexport"></a>
# **CadenceExport**
> CadenceExportResponse CadenceExport (int? id)

Exports a cadence as JSON.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using DawsonSoft.Salesloft.Api.Core.Api;
using DawsonSoft.Salesloft.Api.Core.Client;
using DawsonSoft.Salesloft.Api.Core.Model;

namespace Example
{
    public class CadenceExportExample
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
                // Exports a cadence as JSON.
                CadenceExportResponse result = apiInstance.CadenceExport(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.CadenceExport: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CadenceExportWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Exports a cadence as JSON.
    ApiResponse<CadenceExportResponse> response = apiInstance.CadenceExportWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.CadenceExportWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int?** |  |  |

### Return type

[**CadenceExportResponse**](CadenceExportResponse.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Fill something |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="cadenceget"></a>
# **CadenceGet**
> CadenceGetResponse CadenceGet (int? id)

Fetch a cadence

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using DawsonSoft.Salesloft.Api.Core.Api;
using DawsonSoft.Salesloft.Api.Core.Client;
using DawsonSoft.Salesloft.Api.Core.Model;

namespace Example
{
    public class CadenceGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.salesloft.com/v2";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DefaultApi(config);
            var id = 56;  // int? | Cadence ID

            try
            {
                // Fetch a cadence
                CadenceGetResponse result = apiInstance.CadenceGet(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.CadenceGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CadenceGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Fetch a cadence
    ApiResponse<CadenceGetResponse> response = apiInstance.CadenceGetWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.CadenceGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int?** | Cadence ID |  |

### Return type

[**CadenceGetResponse**](CadenceGetResponse.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Fill something |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="cadenceslist"></a>
# **CadencesList**
> CadencesListResponse CadencesList (int? ids = null, string? updatedAt = null, string? createdAt = null, string? sortBy = null, string? sortDirection = null, string? perPage = null, string? page = null, string? includePagingCounts = null, string? limitPagingCounts = null)

Fetches multiple cadence records. The records can be filtered, paged, and sorted according to the respective parameters.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using DawsonSoft.Salesloft.Api.Core.Api;
using DawsonSoft.Salesloft.Api.Core.Client;
using DawsonSoft.Salesloft.Api.Core.Model;

namespace Example
{
    public class CadencesListExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.salesloft.com/v2";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DefaultApi(config);
            var ids = 56;  // int? |  (optional) 
            var updatedAt = "updatedAt_example";  // string? | Returns all matching records that are greater than the provided iso8601 timestamp. The comparison is done using microsecond precision. (optional) 
            var createdAt = "createdAt_example";  // string? | Returns all matching records that are greater than the provided iso8601 timestamp. The comparison is done using microsecond precision. (optional) 
            var sortBy = "sortBy_example";  // string? | Key to sort on (optional) 
            var sortDirection = "sortDirection_example";  // string? | Direction to sort in, must be one of: ASC, DESC. Defaults to DESC (optional) 
            var perPage = "perPage_example";  // string? | How many records to show per page in the range [1, 100]. Defaults to 25 (optional) 
            var page = "page_example";  // string? | The current page to fetch results from. Defaults to 1 (optional) 
            var includePagingCounts = "includePagingCounts_example";  // string? | Whether to include total_pages and total_count in the metadata. Defaults to false (optional) 
            var limitPagingCounts = "limitPagingCounts_example";  // string? | Specifies whether the max limit of 10k records should be applied to pagination counts. Affects the total_count and total_pages data (optional) 

            try
            {
                // Fetches multiple cadence records. The records can be filtered, paged, and sorted according to the respective parameters.
                CadencesListResponse result = apiInstance.CadencesList(ids, updatedAt, createdAt, sortBy, sortDirection, perPage, page, includePagingCounts, limitPagingCounts);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.CadencesList: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CadencesListWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Fetches multiple cadence records. The records can be filtered, paged, and sorted according to the respective parameters.
    ApiResponse<CadencesListResponse> response = apiInstance.CadencesListWithHttpInfo(ids, updatedAt, createdAt, sortBy, sortDirection, perPage, page, includePagingCounts, limitPagingCounts);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.CadencesListWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **ids** | **int?** |  | [optional]  |
| **updatedAt** | **string?** | Returns all matching records that are greater than the provided iso8601 timestamp. The comparison is done using microsecond precision. | [optional]  |
| **createdAt** | **string?** | Returns all matching records that are greater than the provided iso8601 timestamp. The comparison is done using microsecond precision. | [optional]  |
| **sortBy** | **string?** | Key to sort on | [optional]  |
| **sortDirection** | **string?** | Direction to sort in, must be one of: ASC, DESC. Defaults to DESC | [optional]  |
| **perPage** | **string?** | How many records to show per page in the range [1, 100]. Defaults to 25 | [optional]  |
| **page** | **string?** | The current page to fetch results from. Defaults to 1 | [optional]  |
| **includePagingCounts** | **string?** | Whether to include total_pages and total_count in the metadata. Defaults to false | [optional]  |
| **limitPagingCounts** | **string?** | Specifies whether the max limit of 10k records should be applied to pagination counts. Affects the total_count and total_pages data | [optional]  |

### Return type

[**CadencesListResponse**](CadencesListResponse.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Fill something |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="groupslist"></a>
# **GroupsList**
> GroupsListResponse GroupsList (int? ids = null, string? updatedAt = null, string? createdAt = null, string? sortBy = null, string? sortDirection = null, string? perPage = null, string? page = null, string? includePagingCounts = null, string? limitPagingCounts = null)

Fetches multiple group records. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using DawsonSoft.Salesloft.Api.Core.Api;
using DawsonSoft.Salesloft.Api.Core.Client;
using DawsonSoft.Salesloft.Api.Core.Model;

namespace Example
{
    public class GroupsListExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.salesloft.com/v2";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DefaultApi(config);
            var ids = 56;  // int? |  (optional) 
            var updatedAt = "updatedAt_example";  // string? | Returns all matching records that are greater than the provided iso8601 timestamp. The comparison is done using microsecond precision. (optional) 
            var createdAt = "createdAt_example";  // string? | Returns all matching records that are greater than the provided iso8601 timestamp. The comparison is done using microsecond precision. (optional) 
            var sortBy = "sortBy_example";  // string? | Key to sort on (optional) 
            var sortDirection = "sortDirection_example";  // string? | Direction to sort in, must be one of: ASC, DESC. Defaults to DESC (optional) 
            var perPage = "perPage_example";  // string? | How many records to show per page in the range [1, 100]. Defaults to 25 (optional) 
            var page = "page_example";  // string? | The current page to fetch results from. Defaults to 1 (optional) 
            var includePagingCounts = "includePagingCounts_example";  // string? | Whether to include total_pages and total_count in the metadata. Defaults to false (optional) 
            var limitPagingCounts = "limitPagingCounts_example";  // string? | Specifies whether the max limit of 10k records should be applied to pagination counts. Affects the total_count and total_pages data (optional) 

            try
            {
                // Fetches multiple group records. 
                GroupsListResponse result = apiInstance.GroupsList(ids, updatedAt, createdAt, sortBy, sortDirection, perPage, page, includePagingCounts, limitPagingCounts);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.GroupsList: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GroupsListWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Fetches multiple group records. 
    ApiResponse<GroupsListResponse> response = apiInstance.GroupsListWithHttpInfo(ids, updatedAt, createdAt, sortBy, sortDirection, perPage, page, includePagingCounts, limitPagingCounts);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.GroupsListWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **ids** | **int?** |  | [optional]  |
| **updatedAt** | **string?** | Returns all matching records that are greater than the provided iso8601 timestamp. The comparison is done using microsecond precision. | [optional]  |
| **createdAt** | **string?** | Returns all matching records that are greater than the provided iso8601 timestamp. The comparison is done using microsecond precision. | [optional]  |
| **sortBy** | **string?** | Key to sort on | [optional]  |
| **sortDirection** | **string?** | Direction to sort in, must be one of: ASC, DESC. Defaults to DESC | [optional]  |
| **perPage** | **string?** | How many records to show per page in the range [1, 100]. Defaults to 25 | [optional]  |
| **page** | **string?** | The current page to fetch results from. Defaults to 1 | [optional]  |
| **includePagingCounts** | **string?** | Whether to include total_pages and total_count in the metadata. Defaults to false | [optional]  |
| **limitPagingCounts** | **string?** | Specifies whether the max limit of 10k records should be applied to pagination counts. Affects the total_count and total_pages data | [optional]  |

### Return type

[**GroupsListResponse**](GroupsListResponse.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Fill something |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="noteslist"></a>
# **NotesList**
> NotesListResponse NotesList (int? ids = null, string? updatedAt = null, string? createdAt = null, string? sortBy = null, string? sortDirection = null, string? perPage = null, string? page = null, string? includePagingCounts = null, string? limitPagingCounts = null)

Fetches multiple note records.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using DawsonSoft.Salesloft.Api.Core.Api;
using DawsonSoft.Salesloft.Api.Core.Client;
using DawsonSoft.Salesloft.Api.Core.Model;

namespace Example
{
    public class NotesListExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.salesloft.com/v2";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DefaultApi(config);
            var ids = 56;  // int? |  (optional) 
            var updatedAt = "updatedAt_example";  // string? | Returns all matching records that are greater than the provided iso8601 timestamp. The comparison is done using microsecond precision. (optional) 
            var createdAt = "createdAt_example";  // string? | Returns all matching records that are greater than the provided iso8601 timestamp. The comparison is done using microsecond precision. (optional) 
            var sortBy = "sortBy_example";  // string? | Key to sort on (optional) 
            var sortDirection = "sortDirection_example";  // string? | Direction to sort in, must be one of: ASC, DESC. Defaults to DESC (optional) 
            var perPage = "perPage_example";  // string? | How many records to show per page in the range [1, 100]. Defaults to 25 (optional) 
            var page = "page_example";  // string? | The current page to fetch results from. Defaults to 1 (optional) 
            var includePagingCounts = "includePagingCounts_example";  // string? | Whether to include total_pages and total_count in the metadata. Defaults to false (optional) 
            var limitPagingCounts = "limitPagingCounts_example";  // string? | Specifies whether the max limit of 10k records should be applied to pagination counts. Affects the total_count and total_pages data (optional) 

            try
            {
                // Fetches multiple note records.
                NotesListResponse result = apiInstance.NotesList(ids, updatedAt, createdAt, sortBy, sortDirection, perPage, page, includePagingCounts, limitPagingCounts);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.NotesList: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the NotesListWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Fetches multiple note records.
    ApiResponse<NotesListResponse> response = apiInstance.NotesListWithHttpInfo(ids, updatedAt, createdAt, sortBy, sortDirection, perPage, page, includePagingCounts, limitPagingCounts);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.NotesListWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **ids** | **int?** |  | [optional]  |
| **updatedAt** | **string?** | Returns all matching records that are greater than the provided iso8601 timestamp. The comparison is done using microsecond precision. | [optional]  |
| **createdAt** | **string?** | Returns all matching records that are greater than the provided iso8601 timestamp. The comparison is done using microsecond precision. | [optional]  |
| **sortBy** | **string?** | Key to sort on | [optional]  |
| **sortDirection** | **string?** | Direction to sort in, must be one of: ASC, DESC. Defaults to DESC | [optional]  |
| **perPage** | **string?** | How many records to show per page in the range [1, 100]. Defaults to 25 | [optional]  |
| **page** | **string?** | The current page to fetch results from. Defaults to 1 | [optional]  |
| **includePagingCounts** | **string?** | Whether to include total_pages and total_count in the metadata. Defaults to false | [optional]  |
| **limitPagingCounts** | **string?** | Specifies whether the max limit of 10k records should be applied to pagination counts. Affects the total_count and total_pages data | [optional]  |

### Return type

[**NotesListResponse**](NotesListResponse.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Fill something |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="peopleupdate"></a>
# **PeopleUpdate**
> PeoplePutResponse PeopleUpdate (int? id, PersonCreateRequest personCreateRequest)

Update a person

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using DawsonSoft.Salesloft.Api.Core.Api;
using DawsonSoft.Salesloft.Api.Core.Client;
using DawsonSoft.Salesloft.Api.Core.Model;

namespace Example
{
    public class PeopleUpdateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.salesloft.com/v2";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DefaultApi(config);
            var id = 56;  // int? | 
            var personCreateRequest = new PersonCreateRequest(); // PersonCreateRequest | 

            try
            {
                // Update a person
                PeoplePutResponse result = apiInstance.PeopleUpdate(id, personCreateRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.PeopleUpdate: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PeopleUpdateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update a person
    ApiResponse<PeoplePutResponse> response = apiInstance.PeopleUpdateWithHttpInfo(id, personCreateRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.PeopleUpdateWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int?** |  |  |
| **personCreateRequest** | [**PersonCreateRequest**](PersonCreateRequest.md) |  |  |

### Return type

[**PeoplePutResponse**](PeoplePutResponse.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Fill something |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="personcreate"></a>
# **PersonCreate**
> PeoplePostResponse PersonCreate (PersonCreateRequest personCreateRequest)

Creates a person. Either email_address or phone/last_name must be provided as a unique lookup on the team.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using DawsonSoft.Salesloft.Api.Core.Api;
using DawsonSoft.Salesloft.Api.Core.Client;
using DawsonSoft.Salesloft.Api.Core.Model;

namespace Example
{
    public class PersonCreateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.salesloft.com/v2";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DefaultApi(config);
            var personCreateRequest = new PersonCreateRequest(); // PersonCreateRequest | 

            try
            {
                // Creates a person. Either email_address or phone/last_name must be provided as a unique lookup on the team.
                PeoplePostResponse result = apiInstance.PersonCreate(personCreateRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.PersonCreate: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PersonCreateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Creates a person. Either email_address or phone/last_name must be provided as a unique lookup on the team.
    ApiResponse<PeoplePostResponse> response = apiInstance.PersonCreateWithHttpInfo(personCreateRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.PersonCreateWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **personCreateRequest** | [**PersonCreateRequest**](PersonCreateRequest.md) |  |  |

### Return type

[**PeoplePostResponse**](PeoplePostResponse.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Fill something |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="personget"></a>
# **PersonGet**
> PeopleGetResponse PersonGet (int? id)

Fetches a person, by ID only.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using DawsonSoft.Salesloft.Api.Core.Api;
using DawsonSoft.Salesloft.Api.Core.Client;
using DawsonSoft.Salesloft.Api.Core.Model;

namespace Example
{
    public class PersonGetExample
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
                // Fetches a person, by ID only.
                PeopleGetResponse result = apiInstance.PersonGet(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.PersonGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PersonGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Fetches a person, by ID only.
    ApiResponse<PeopleGetResponse> response = apiInstance.PersonGetWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.PersonGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int?** |  |  |

### Return type

[**PeopleGetResponse**](PeopleGetResponse.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Fill something |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="personlist"></a>
# **PersonList**
> PeopleListResponse PersonList (int? ids = null, string? updatedAt = null, string? createdAt = null, string? sortBy = null, string? sortDirection = null, string? perPage = null, string? page = null, string? includePagingCounts = null, string? limitPagingCounts = null)

Fetches multiple person records. The records can be filtered, paged, and sorted according to the respective parameters.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using DawsonSoft.Salesloft.Api.Core.Api;
using DawsonSoft.Salesloft.Api.Core.Client;
using DawsonSoft.Salesloft.Api.Core.Model;

namespace Example
{
    public class PersonListExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.salesloft.com/v2";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DefaultApi(config);
            var ids = 56;  // int? |  (optional) 
            var updatedAt = "updatedAt_example";  // string? | Returns all matching records that are greater than the provided iso8601 timestamp. The comparison is done using microsecond precision. (optional) 
            var createdAt = "createdAt_example";  // string? | Returns all matching records that are greater than the provided iso8601 timestamp. The comparison is done using microsecond precision. (optional) 
            var sortBy = "sortBy_example";  // string? | Key to sort on (optional) 
            var sortDirection = "sortDirection_example";  // string? | Direction to sort in, must be one of: ASC, DESC. Defaults to DESC (optional) 
            var perPage = "perPage_example";  // string? | How many records to show per page in the range [1, 100]. Defaults to 25 (optional) 
            var page = "page_example";  // string? | The current page to fetch results from. Defaults to 1 (optional) 
            var includePagingCounts = "includePagingCounts_example";  // string? | Whether to include total_pages and total_count in the metadata. Defaults to false (optional) 
            var limitPagingCounts = "limitPagingCounts_example";  // string? | Specifies whether the max limit of 10k records should be applied to pagination counts. Affects the total_count and total_pages data (optional) 

            try
            {
                // Fetches multiple person records. The records can be filtered, paged, and sorted according to the respective parameters.
                PeopleListResponse result = apiInstance.PersonList(ids, updatedAt, createdAt, sortBy, sortDirection, perPage, page, includePagingCounts, limitPagingCounts);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.PersonList: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PersonListWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Fetches multiple person records. The records can be filtered, paged, and sorted according to the respective parameters.
    ApiResponse<PeopleListResponse> response = apiInstance.PersonListWithHttpInfo(ids, updatedAt, createdAt, sortBy, sortDirection, perPage, page, includePagingCounts, limitPagingCounts);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.PersonListWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **ids** | **int?** |  | [optional]  |
| **updatedAt** | **string?** | Returns all matching records that are greater than the provided iso8601 timestamp. The comparison is done using microsecond precision. | [optional]  |
| **createdAt** | **string?** | Returns all matching records that are greater than the provided iso8601 timestamp. The comparison is done using microsecond precision. | [optional]  |
| **sortBy** | **string?** | Key to sort on | [optional]  |
| **sortDirection** | **string?** | Direction to sort in, must be one of: ASC, DESC. Defaults to DESC | [optional]  |
| **perPage** | **string?** | How many records to show per page in the range [1, 100]. Defaults to 25 | [optional]  |
| **page** | **string?** | The current page to fetch results from. Defaults to 1 | [optional]  |
| **includePagingCounts** | **string?** | Whether to include total_pages and total_count in the metadata. Defaults to false | [optional]  |
| **limitPagingCounts** | **string?** | Specifies whether the max limit of 10k records should be applied to pagination counts. Affects the total_count and total_pages data | [optional]  |

### Return type

[**PeopleListResponse**](PeopleListResponse.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Fill something |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="tagslist"></a>
# **TagsList**
> TagsListResponse TagsList (int? ids = null, string? updatedAt = null, string? createdAt = null, string? sortBy = null, string? sortDirection = null, string? perPage = null, string? page = null, string? includePagingCounts = null, string? limitPagingCounts = null)

Fetches a list of the tags used for a team.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using DawsonSoft.Salesloft.Api.Core.Api;
using DawsonSoft.Salesloft.Api.Core.Client;
using DawsonSoft.Salesloft.Api.Core.Model;

namespace Example
{
    public class TagsListExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.salesloft.com/v2";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DefaultApi(config);
            var ids = 56;  // int? |  (optional) 
            var updatedAt = "updatedAt_example";  // string? | Returns all matching records that are greater than the provided iso8601 timestamp. The comparison is done using microsecond precision. (optional) 
            var createdAt = "createdAt_example";  // string? | Returns all matching records that are greater than the provided iso8601 timestamp. The comparison is done using microsecond precision. (optional) 
            var sortBy = "sortBy_example";  // string? | Key to sort on (optional) 
            var sortDirection = "sortDirection_example";  // string? | Direction to sort in, must be one of: ASC, DESC. Defaults to DESC (optional) 
            var perPage = "perPage_example";  // string? | How many records to show per page in the range [1, 100]. Defaults to 25 (optional) 
            var page = "page_example";  // string? | The current page to fetch results from. Defaults to 1 (optional) 
            var includePagingCounts = "includePagingCounts_example";  // string? | Whether to include total_pages and total_count in the metadata. Defaults to false (optional) 
            var limitPagingCounts = "limitPagingCounts_example";  // string? | Specifies whether the max limit of 10k records should be applied to pagination counts. Affects the total_count and total_pages data (optional) 

            try
            {
                // Fetches a list of the tags used for a team.
                TagsListResponse result = apiInstance.TagsList(ids, updatedAt, createdAt, sortBy, sortDirection, perPage, page, includePagingCounts, limitPagingCounts);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.TagsList: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the TagsListWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Fetches a list of the tags used for a team.
    ApiResponse<TagsListResponse> response = apiInstance.TagsListWithHttpInfo(ids, updatedAt, createdAt, sortBy, sortDirection, perPage, page, includePagingCounts, limitPagingCounts);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.TagsListWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **ids** | **int?** |  | [optional]  |
| **updatedAt** | **string?** | Returns all matching records that are greater than the provided iso8601 timestamp. The comparison is done using microsecond precision. | [optional]  |
| **createdAt** | **string?** | Returns all matching records that are greater than the provided iso8601 timestamp. The comparison is done using microsecond precision. | [optional]  |
| **sortBy** | **string?** | Key to sort on | [optional]  |
| **sortDirection** | **string?** | Direction to sort in, must be one of: ASC, DESC. Defaults to DESC | [optional]  |
| **perPage** | **string?** | How many records to show per page in the range [1, 100]. Defaults to 25 | [optional]  |
| **page** | **string?** | The current page to fetch results from. Defaults to 1 | [optional]  |
| **includePagingCounts** | **string?** | Whether to include total_pages and total_count in the metadata. Defaults to false | [optional]  |
| **limitPagingCounts** | **string?** | Specifies whether the max limit of 10k records should be applied to pagination counts. Affects the total_count and total_pages data | [optional]  |

### Return type

[**TagsListResponse**](TagsListResponse.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Fill something |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="teamtemplatesget"></a>
# **TeamTemplatesGet**
> TeamTemplatesGetResponse TeamTemplatesGet (int? id)

Fetches a team template, by ID only.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using DawsonSoft.Salesloft.Api.Core.Api;
using DawsonSoft.Salesloft.Api.Core.Client;
using DawsonSoft.Salesloft.Api.Core.Model;

namespace Example
{
    public class TeamTemplatesGetExample
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
                // Fetches a team template, by ID only.
                TeamTemplatesGetResponse result = apiInstance.TeamTemplatesGet(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.TeamTemplatesGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the TeamTemplatesGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Fetches a team template, by ID only.
    ApiResponse<TeamTemplatesGetResponse> response = apiInstance.TeamTemplatesGetWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.TeamTemplatesGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **int?** |  |  |

### Return type

[**TeamTemplatesGetResponse**](TeamTemplatesGetResponse.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Fill something |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="teamtemplateslist"></a>
# **TeamTemplatesList**
> TeamTemplatesListResponse TeamTemplatesList (int? ids = null, string? updatedAt = null, string? createdAt = null, string? sortBy = null, string? sortDirection = null, string? perPage = null, string? page = null, string? includePagingCounts = null, string? limitPagingCounts = null)

etches multiple team template records.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using DawsonSoft.Salesloft.Api.Core.Api;
using DawsonSoft.Salesloft.Api.Core.Client;
using DawsonSoft.Salesloft.Api.Core.Model;

namespace Example
{
    public class TeamTemplatesListExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.salesloft.com/v2";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DefaultApi(config);
            var ids = 56;  // int? |  (optional) 
            var updatedAt = "updatedAt_example";  // string? | Returns all matching records that are greater than the provided iso8601 timestamp. The comparison is done using microsecond precision. (optional) 
            var createdAt = "createdAt_example";  // string? | Returns all matching records that are greater than the provided iso8601 timestamp. The comparison is done using microsecond precision. (optional) 
            var sortBy = "sortBy_example";  // string? | Key to sort on (optional) 
            var sortDirection = "sortDirection_example";  // string? | Direction to sort in, must be one of: ASC, DESC. Defaults to DESC (optional) 
            var perPage = "perPage_example";  // string? | How many records to show per page in the range [1, 100]. Defaults to 25 (optional) 
            var page = "page_example";  // string? | The current page to fetch results from. Defaults to 1 (optional) 
            var includePagingCounts = "includePagingCounts_example";  // string? | Whether to include total_pages and total_count in the metadata. Defaults to false (optional) 
            var limitPagingCounts = "limitPagingCounts_example";  // string? | Specifies whether the max limit of 10k records should be applied to pagination counts. Affects the total_count and total_pages data (optional) 

            try
            {
                // etches multiple team template records.
                TeamTemplatesListResponse result = apiInstance.TeamTemplatesList(ids, updatedAt, createdAt, sortBy, sortDirection, perPage, page, includePagingCounts, limitPagingCounts);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.TeamTemplatesList: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the TeamTemplatesListWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // etches multiple team template records.
    ApiResponse<TeamTemplatesListResponse> response = apiInstance.TeamTemplatesListWithHttpInfo(ids, updatedAt, createdAt, sortBy, sortDirection, perPage, page, includePagingCounts, limitPagingCounts);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.TeamTemplatesListWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **ids** | **int?** |  | [optional]  |
| **updatedAt** | **string?** | Returns all matching records that are greater than the provided iso8601 timestamp. The comparison is done using microsecond precision. | [optional]  |
| **createdAt** | **string?** | Returns all matching records that are greater than the provided iso8601 timestamp. The comparison is done using microsecond precision. | [optional]  |
| **sortBy** | **string?** | Key to sort on | [optional]  |
| **sortDirection** | **string?** | Direction to sort in, must be one of: ASC, DESC. Defaults to DESC | [optional]  |
| **perPage** | **string?** | How many records to show per page in the range [1, 100]. Defaults to 25 | [optional]  |
| **page** | **string?** | The current page to fetch results from. Defaults to 1 | [optional]  |
| **includePagingCounts** | **string?** | Whether to include total_pages and total_count in the metadata. Defaults to false | [optional]  |
| **limitPagingCounts** | **string?** | Specifies whether the max limit of 10k records should be applied to pagination counts. Affects the total_count and total_pages data | [optional]  |

### Return type

[**TeamTemplatesListResponse**](TeamTemplatesListResponse.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Fill something |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="userme"></a>
# **UserMe**
> UserMeResponse UserMe ()

Fetch current user

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using DawsonSoft.Salesloft.Api.Core.Api;
using DawsonSoft.Salesloft.Api.Core.Client;
using DawsonSoft.Salesloft.Api.Core.Model;

namespace Example
{
    public class UserMeExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.salesloft.com/v2";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DefaultApi(config);

            try
            {
                // Fetch current user
                UserMeResponse result = apiInstance.UserMe();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.UserMe: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UserMeWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Fetch current user
    ApiResponse<UserMeResponse> response = apiInstance.UserMeWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.UserMeWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**UserMeResponse**](UserMeResponse.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Fill something |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="userslist"></a>
# **UsersList**
> UsersListResponse UsersList (int? ids = null, string? updatedAt = null, string? createdAt = null, string? sortBy = null, string? sortDirection = null, string? perPage = null, string? page = null, string? includePagingCounts = null, string? limitPagingCounts = null)

Non Admin: Lists only your user, or all on team depending on group visibility policy Team Admin: Lists users associated with your team

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using DawsonSoft.Salesloft.Api.Core.Api;
using DawsonSoft.Salesloft.Api.Core.Client;
using DawsonSoft.Salesloft.Api.Core.Model;

namespace Example
{
    public class UsersListExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.salesloft.com/v2";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DefaultApi(config);
            var ids = 56;  // int? |  (optional) 
            var updatedAt = "updatedAt_example";  // string? | Returns all matching records that are greater than the provided iso8601 timestamp. The comparison is done using microsecond precision. (optional) 
            var createdAt = "createdAt_example";  // string? | Returns all matching records that are greater than the provided iso8601 timestamp. The comparison is done using microsecond precision. (optional) 
            var sortBy = "sortBy_example";  // string? | Key to sort on (optional) 
            var sortDirection = "sortDirection_example";  // string? | Direction to sort in, must be one of: ASC, DESC. Defaults to DESC (optional) 
            var perPage = "perPage_example";  // string? | How many records to show per page in the range [1, 100]. Defaults to 25 (optional) 
            var page = "page_example";  // string? | The current page to fetch results from. Defaults to 1 (optional) 
            var includePagingCounts = "includePagingCounts_example";  // string? | Whether to include total_pages and total_count in the metadata. Defaults to false (optional) 
            var limitPagingCounts = "limitPagingCounts_example";  // string? | Specifies whether the max limit of 10k records should be applied to pagination counts. Affects the total_count and total_pages data (optional) 

            try
            {
                // Non Admin: Lists only your user, or all on team depending on group visibility policy Team Admin: Lists users associated with your team
                UsersListResponse result = apiInstance.UsersList(ids, updatedAt, createdAt, sortBy, sortDirection, perPage, page, includePagingCounts, limitPagingCounts);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.UsersList: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UsersListWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Non Admin: Lists only your user, or all on team depending on group visibility policy Team Admin: Lists users associated with your team
    ApiResponse<UsersListResponse> response = apiInstance.UsersListWithHttpInfo(ids, updatedAt, createdAt, sortBy, sortDirection, perPage, page, includePagingCounts, limitPagingCounts);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.UsersListWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **ids** | **int?** |  | [optional]  |
| **updatedAt** | **string?** | Returns all matching records that are greater than the provided iso8601 timestamp. The comparison is done using microsecond precision. | [optional]  |
| **createdAt** | **string?** | Returns all matching records that are greater than the provided iso8601 timestamp. The comparison is done using microsecond precision. | [optional]  |
| **sortBy** | **string?** | Key to sort on | [optional]  |
| **sortDirection** | **string?** | Direction to sort in, must be one of: ASC, DESC. Defaults to DESC | [optional]  |
| **perPage** | **string?** | How many records to show per page in the range [1, 100]. Defaults to 25 | [optional]  |
| **page** | **string?** | The current page to fetch results from. Defaults to 1 | [optional]  |
| **includePagingCounts** | **string?** | Whether to include total_pages and total_count in the metadata. Defaults to false | [optional]  |
| **limitPagingCounts** | **string?** | Specifies whether the max limit of 10k records should be applied to pagination counts. Affects the total_count and total_pages data | [optional]  |

### Return type

[**UsersListResponse**](UsersListResponse.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Fill something |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

