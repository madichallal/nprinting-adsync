/* 
 * Qlik NPrinting API
 *
 * You can extend your reporting system by using the Qlik NPrinting API. This API provides endpoints to perform operations on apps, On-Demand requests and results, reports, filters, and so on.  For all requests, the data returned is filtered based on user permissions. That is, if a user is not authorized to access a certain object, that object is not returned in the reponse.  API Stability: Experimental.  Deprecation period: None. Can change at any point and should be used only to evaluate upcoming functionality.     
 *
 * OpenAPI spec version: 0.2.0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Collections.Generic;
using System.Linq;
using Qlik.NPrinting.Rest.Client.Client;
using Qlik.NPrinting.Rest.Client.Model;
using RestSharp;

namespace Qlik.NPrinting.Rest.Client.Api
{
    
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IReportsApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Gets the list of reports.
        /// </summary>
        /// <remarks>
        /// Returns the list of reports that the calling user is authorized to view.  The response includes the title and other details about each report. The list can be filtered by a particular app, and is sorted in the order specified by the &#x60;sort&#x60; parameter. 
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="appId">The ID of the app to filter on. (optional)</param>
        /// <param name="sort">A comma separated list of fields to be used for sorting the reports. Allowed field values are \&quot;title\&quot; and \&quot;created\&quot;. Fields can be prefixed by \&quot;+\&quot; and \&quot;-\&quot; to indicate, respectively, ascending and descending order.  Usage example: /reports?sort&#x3D;+title,-created  (optional)</param>
        /// <param name="offset">The number of entries to skip. Default is 0. (optional, default to 0)</param>
        /// <param name="limit">The maximum number of entries to return. Default is 50. (optional, default to 50)</param>
        /// <returns>ReportListResponse</returns>
        ReportListResponse ReportsGet (string appId = null, string sort = null, int? offset = null, int? limit = null);

        /// <summary>
        /// Gets the list of reports.
        /// </summary>
        /// <remarks>
        /// Returns the list of reports that the calling user is authorized to view.  The response includes the title and other details about each report. The list can be filtered by a particular app, and is sorted in the order specified by the &#x60;sort&#x60; parameter. 
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="appId">The ID of the app to filter on. (optional)</param>
        /// <param name="sort">A comma separated list of fields to be used for sorting the reports. Allowed field values are \&quot;title\&quot; and \&quot;created\&quot;. Fields can be prefixed by \&quot;+\&quot; and \&quot;-\&quot; to indicate, respectively, ascending and descending order.  Usage example: /reports?sort&#x3D;+title,-created  (optional)</param>
        /// <param name="offset">The number of entries to skip. Default is 0. (optional, default to 0)</param>
        /// <param name="limit">The maximum number of entries to return. Default is 50. (optional, default to 50)</param>
        /// <returns>ApiResponse of ReportListResponse</returns>
        ApiResponse<ReportListResponse> ReportsGetWithHttpInfo (string appId = null, string sort = null, int? offset = null, int? limit = null);
        /// <summary>
        /// Gets details about a specific report.
        /// </summary>
        /// <remarks>
        /// Returns the details about the specified report specified by the &#x60;reportId&#x60; parameter. 
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="reportId">The report ID.</param>
        /// <returns>ReportResponse</returns>
        ReportResponse ReportsReportIdGet (string reportId);

        /// <summary>
        /// Gets details about a specific report.
        /// </summary>
        /// <remarks>
        /// Returns the details about the specified report specified by the &#x60;reportId&#x60; parameter. 
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="reportId">The report ID.</param>
        /// <returns>ApiResponse of ReportResponse</returns>
        ApiResponse<ReportResponse> ReportsReportIdGetWithHttpInfo (string reportId);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Gets the list of reports.
        /// </summary>
        /// <remarks>
        /// Returns the list of reports that the calling user is authorized to view.  The response includes the title and other details about each report. The list can be filtered by a particular app, and is sorted in the order specified by the &#x60;sort&#x60; parameter. 
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="appId">The ID of the app to filter on. (optional)</param>
        /// <param name="sort">A comma separated list of fields to be used for sorting the reports. Allowed field values are \&quot;title\&quot; and \&quot;created\&quot;. Fields can be prefixed by \&quot;+\&quot; and \&quot;-\&quot; to indicate, respectively, ascending and descending order.  Usage example: /reports?sort&#x3D;+title,-created  (optional)</param>
        /// <param name="offset">The number of entries to skip. Default is 0. (optional, default to 0)</param>
        /// <param name="limit">The maximum number of entries to return. Default is 50. (optional, default to 50)</param>
        /// <returns>Task of ReportListResponse</returns>
        System.Threading.Tasks.Task<ReportListResponse> ReportsGetAsync (string appId = null, string sort = null, int? offset = null, int? limit = null);

        /// <summary>
        /// Gets the list of reports.
        /// </summary>
        /// <remarks>
        /// Returns the list of reports that the calling user is authorized to view.  The response includes the title and other details about each report. The list can be filtered by a particular app, and is sorted in the order specified by the &#x60;sort&#x60; parameter. 
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="appId">The ID of the app to filter on. (optional)</param>
        /// <param name="sort">A comma separated list of fields to be used for sorting the reports. Allowed field values are \&quot;title\&quot; and \&quot;created\&quot;. Fields can be prefixed by \&quot;+\&quot; and \&quot;-\&quot; to indicate, respectively, ascending and descending order.  Usage example: /reports?sort&#x3D;+title,-created  (optional)</param>
        /// <param name="offset">The number of entries to skip. Default is 0. (optional, default to 0)</param>
        /// <param name="limit">The maximum number of entries to return. Default is 50. (optional, default to 50)</param>
        /// <returns>Task of ApiResponse (ReportListResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<ReportListResponse>> ReportsGetAsyncWithHttpInfo (string appId = null, string sort = null, int? offset = null, int? limit = null);
        /// <summary>
        /// Gets details about a specific report.
        /// </summary>
        /// <remarks>
        /// Returns the details about the specified report specified by the &#x60;reportId&#x60; parameter. 
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="reportId">The report ID.</param>
        /// <returns>Task of ReportResponse</returns>
        System.Threading.Tasks.Task<ReportResponse> ReportsReportIdGetAsync (string reportId);

        /// <summary>
        /// Gets details about a specific report.
        /// </summary>
        /// <remarks>
        /// Returns the details about the specified report specified by the &#x60;reportId&#x60; parameter. 
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="reportId">The report ID.</param>
        /// <returns>Task of ApiResponse (ReportResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<ReportResponse>> ReportsReportIdGetAsyncWithHttpInfo (string reportId);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class ReportsApi : IReportsApi
    {
        private ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="ReportsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ReportsApi(ApiClient apiClient)
        {
            ApiClient = apiClient;

            ExceptionFactory = ApiClient.DefaultExceptionFactory;
        }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public string GetBasePath()
        {
            return this.ApiClient.RestClient.BaseUrl.ToString();
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public ApiClient ApiClient { get; set; }

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public ExceptionFactory ExceptionFactory
        {
            get
            {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                {
                    throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
                }
                return _exceptionFactory;
            }
            set { _exceptionFactory = value; }
        }

        /// <summary>
        /// Gets the list of reports. Returns the list of reports that the calling user is authorized to view.  The response includes the title and other details about each report. The list can be filtered by a particular app, and is sorted in the order specified by the &#x60;sort&#x60; parameter. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="appId">The ID of the app to filter on. (optional)</param>
        /// <param name="sort">A comma separated list of fields to be used for sorting the reports. Allowed field values are \&quot;title\&quot; and \&quot;created\&quot;. Fields can be prefixed by \&quot;+\&quot; and \&quot;-\&quot; to indicate, respectively, ascending and descending order.  Usage example: /reports?sort&#x3D;+title,-created  (optional)</param>
        /// <param name="offset">The number of entries to skip. Default is 0. (optional, default to 0)</param>
        /// <param name="limit">The maximum number of entries to return. Default is 50. (optional, default to 50)</param>
        /// <returns>ReportListResponse</returns>
        public ReportListResponse ReportsGet (string appId = null, string sort = null, int? offset = null, int? limit = null)
        {
             ApiResponse<ReportListResponse> localVarResponse = ReportsGetWithHttpInfo(appId, sort, offset, limit);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Gets the list of reports. Returns the list of reports that the calling user is authorized to view.  The response includes the title and other details about each report. The list can be filtered by a particular app, and is sorted in the order specified by the &#x60;sort&#x60; parameter. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="appId">The ID of the app to filter on. (optional)</param>
        /// <param name="sort">A comma separated list of fields to be used for sorting the reports. Allowed field values are \&quot;title\&quot; and \&quot;created\&quot;. Fields can be prefixed by \&quot;+\&quot; and \&quot;-\&quot; to indicate, respectively, ascending and descending order.  Usage example: /reports?sort&#x3D;+title,-created  (optional)</param>
        /// <param name="offset">The number of entries to skip. Default is 0. (optional, default to 0)</param>
        /// <param name="limit">The maximum number of entries to return. Default is 50. (optional, default to 50)</param>
        /// <returns>ApiResponse of ReportListResponse</returns>
        public ApiResponse< ReportListResponse > ReportsGetWithHttpInfo (string appId = null, string sort = null, int? offset = null, int? limit = null)
        {

            var localVarPath = ApiClient.ApiPathPrefix + "/reports";
            var localVarPathParams = new Dictionary<string, string>();
            var localVarQueryParams = new Dictionary<string, string>();
            var localVarHeaderParams = new Dictionary<string, string>(this.ApiClient.DefaultHeader);
            var localVarFormParams = new Dictionary<string, string>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            string[] localVarHttpContentTypes = new string[] {
            };
            string localVarHttpContentType =  this.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            string[] localVarHttpHeaderAccepts = new string[] {
                "application/json"
            };
            string localVarHttpHeaderAccept =  this.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (appId != null) localVarQueryParams.Add("appId",  this.ApiClient.ParameterToString(appId)); // query parameter
            if (sort != null) localVarQueryParams.Add("sort",  this.ApiClient.ParameterToString(sort)); // query parameter
            if (offset != null) localVarQueryParams.Add("offset",  this.ApiClient.ParameterToString(offset)); // query parameter
            if (limit != null) localVarQueryParams.Add("limit",  this.ApiClient.ParameterToString(limit)); // query parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse)  this.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("ReportsGet", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ReportListResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ReportListResponse)  this.ApiClient.Deserialize(localVarResponse, typeof(ReportListResponse)));
            
        }

        /// <summary>
        /// Gets the list of reports. Returns the list of reports that the calling user is authorized to view.  The response includes the title and other details about each report. The list can be filtered by a particular app, and is sorted in the order specified by the &#x60;sort&#x60; parameter. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="appId">The ID of the app to filter on. (optional)</param>
        /// <param name="sort">A comma separated list of fields to be used for sorting the reports. Allowed field values are \&quot;title\&quot; and \&quot;created\&quot;. Fields can be prefixed by \&quot;+\&quot; and \&quot;-\&quot; to indicate, respectively, ascending and descending order.  Usage example: /reports?sort&#x3D;+title,-created  (optional)</param>
        /// <param name="offset">The number of entries to skip. Default is 0. (optional, default to 0)</param>
        /// <param name="limit">The maximum number of entries to return. Default is 50. (optional, default to 50)</param>
        /// <returns>Task of ReportListResponse</returns>
        public async System.Threading.Tasks.Task<ReportListResponse> ReportsGetAsync (string appId = null, string sort = null, int? offset = null, int? limit = null)
        {
             ApiResponse<ReportListResponse> localVarResponse = await ReportsGetAsyncWithHttpInfo(appId, sort, offset, limit);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Gets the list of reports. Returns the list of reports that the calling user is authorized to view.  The response includes the title and other details about each report. The list can be filtered by a particular app, and is sorted in the order specified by the &#x60;sort&#x60; parameter. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="appId">The ID of the app to filter on. (optional)</param>
        /// <param name="sort">A comma separated list of fields to be used for sorting the reports. Allowed field values are \&quot;title\&quot; and \&quot;created\&quot;. Fields can be prefixed by \&quot;+\&quot; and \&quot;-\&quot; to indicate, respectively, ascending and descending order.  Usage example: /reports?sort&#x3D;+title,-created  (optional)</param>
        /// <param name="offset">The number of entries to skip. Default is 0. (optional, default to 0)</param>
        /// <param name="limit">The maximum number of entries to return. Default is 50. (optional, default to 50)</param>
        /// <returns>Task of ApiResponse (ReportListResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ReportListResponse>> ReportsGetAsyncWithHttpInfo (string appId = null, string sort = null, int? offset = null, int? limit = null)
        {

            var localVarPath = ApiClient.ApiPathPrefix + "/reports";
            var localVarPathParams = new Dictionary<string, string>();
            var localVarQueryParams = new Dictionary<string, string>();
            var localVarHeaderParams = new Dictionary<string, string>( this.ApiClient.DefaultHeader);
            var localVarFormParams = new Dictionary<string, string>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            string[] localVarHttpContentTypes = new string[] {
            };
            string localVarHttpContentType =  this.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            string[] localVarHttpHeaderAccepts = new string[] {
                "application/json"
            };
            string localVarHttpHeaderAccept =  this.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (appId != null) localVarQueryParams.Add("appId",  this.ApiClient.ParameterToString(appId)); // query parameter
            if (sort != null) localVarQueryParams.Add("sort",  this.ApiClient.ParameterToString(sort)); // query parameter
            if (offset != null) localVarQueryParams.Add("offset",  this.ApiClient.ParameterToString(offset)); // query parameter
            if (limit != null) localVarQueryParams.Add("limit",  this.ApiClient.ParameterToString(limit)); // query parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await  this.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("ReportsGet", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ReportListResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ReportListResponse)  this.ApiClient.Deserialize(localVarResponse, typeof(ReportListResponse)));
            
        }

        /// <summary>
        /// Gets details about a specific report. Returns the details about the specified report specified by the &#x60;reportId&#x60; parameter. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="reportId">The report ID.</param>
        /// <returns>ReportResponse</returns>
        public ReportResponse ReportsReportIdGet (string reportId)
        {
             ApiResponse<ReportResponse> localVarResponse = ReportsReportIdGetWithHttpInfo(reportId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Gets details about a specific report. Returns the details about the specified report specified by the &#x60;reportId&#x60; parameter. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="reportId">The report ID.</param>
        /// <returns>ApiResponse of ReportResponse</returns>
        public ApiResponse< ReportResponse > ReportsReportIdGetWithHttpInfo (string reportId)
        {
            // verify the required parameter 'reportId' is set
            if (reportId == null)
                throw new ApiException(400, "Missing required parameter 'reportId' when calling ReportsApi->ReportsReportIdGet");

            var localVarPath = ApiClient.ApiPathPrefix + "/reports/{reportId}";
            var localVarPathParams = new Dictionary<string, string>();
            var localVarQueryParams = new Dictionary<string, string>();
            var localVarHeaderParams = new Dictionary<string, string>( this.ApiClient.DefaultHeader);
            var localVarFormParams = new Dictionary<string, string>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            string[] localVarHttpContentTypes = new string[] {
            };
            string localVarHttpContentType =  this.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            string[] localVarHttpHeaderAccepts = new string[] {
                "application/json"
            };
            string localVarHttpHeaderAccept =  this.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (reportId != null) localVarPathParams.Add("reportId",  this.ApiClient.ParameterToString(reportId)); // path parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse)  this.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("ReportsReportIdGet", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ReportResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ReportResponse)  this.ApiClient.Deserialize(localVarResponse, typeof(ReportResponse)));
            
        }

        /// <summary>
        /// Gets details about a specific report. Returns the details about the specified report specified by the &#x60;reportId&#x60; parameter. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="reportId">The report ID.</param>
        /// <returns>Task of ReportResponse</returns>
        public async System.Threading.Tasks.Task<ReportResponse> ReportsReportIdGetAsync (string reportId)
        {
             ApiResponse<ReportResponse> localVarResponse = await ReportsReportIdGetAsyncWithHttpInfo(reportId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Gets details about a specific report. Returns the details about the specified report specified by the &#x60;reportId&#x60; parameter. 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="reportId">The report ID.</param>
        /// <returns>Task of ApiResponse (ReportResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ReportResponse>> ReportsReportIdGetAsyncWithHttpInfo (string reportId)
        {
            // verify the required parameter 'reportId' is set
            if (reportId == null)
                throw new ApiException(400, "Missing required parameter 'reportId' when calling ReportsApi->ReportsReportIdGet");

            var localVarPath = ApiClient.ApiPathPrefix + "/reports/{reportId}";
            var localVarPathParams = new Dictionary<string, string>();
            var localVarQueryParams = new Dictionary<string, string>();
            var localVarHeaderParams = new Dictionary<string, string>( this.ApiClient.DefaultHeader);
            var localVarFormParams = new Dictionary<string, string>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            string[] localVarHttpContentTypes = new string[] {
            };
            string localVarHttpContentType =  this.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            string[] localVarHttpHeaderAccepts = new string[] {
                "application/json"
            };
            string localVarHttpHeaderAccept =  this.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (reportId != null) localVarPathParams.Add("reportId",  this.ApiClient.ParameterToString(reportId)); // path parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await  this.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("ReportsReportIdGet", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ReportResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ReportResponse)  this.ApiClient.Deserialize(localVarResponse, typeof(ReportResponse)));
            
        }

    }
}