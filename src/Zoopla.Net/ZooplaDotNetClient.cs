﻿using System;
using System.Threading.Tasks;
using Zoopla.Net.Models;
using Zoopla.Net.Models.AreaValueGraphs;
using Zoopla.Net.Models.AverageAreaSoldPrices;
using Zoopla.Net.Models.AverageSoldPrices;
using Zoopla.Net.Models.Listings;
using Zoopla.Net.Models.PropertyRichList;
using Zoopla.Net.Models.Session;
using Zoopla.Net.Models.ZedIndex;
using Zoopla.Net.Models.ZedIndices;
using Zoopla.Net.Options;
using Zoopla.Net.Options.AreaValueGraphs;
using Zoopla.Net.Options.ArrangeViewing;
using Zoopla.Net.Options.AverageSoldPrices;
using Zoopla.Net.Options.ZedIndices;

namespace Zoopla.Net
{
    public class ZooplaDotNetClient
    {
        private string _accessToken = String.Empty;
        private ZooplaHttpClient _httpClient;

        public ZooplaDotNetClient(string token)
        {
            _accessToken = token;
            _httpClient = new ZooplaHttpClient();
        }

        public Task<PropertyListingsResponse> GetPropertyListings(StandardLocationParameters locationParams, ListingBaseOptions options)
        {
            string url = Endpoints.PROPERTY_LISTINGS + "?api_key=" + _accessToken;

            url += locationParams.GetUrlParams();
            url += options.GetUrlParams();

            return _httpClient.GetObject<PropertyListingsResponse>(url);
        }

        public Task<AverageSoldPriceResponse> GetAverageSoldPrices(StandardLocationParameters locationParams, AverageSoldPricesOptions options)
        {
            string url = Endpoints.AVERAGE_SOLD_PRICES + "?api_key=" + _accessToken;

            url += locationParams.GetUrlParams();
            url += options.GetUrlParams();

            return _httpClient.GetObject<AverageSoldPriceResponse>(url);
        }

        public Task<PropertyRichListResponse> GetPropertyRichList(StandardLocationParameters locationParams)
        {
            string url = Endpoints.PROPERTY_RICH_LIST + "?api_key=" + _accessToken;

            url += locationParams.GetUrlParams();

            return _httpClient.GetObject<PropertyRichListResponse>(url);
        }

        public Task<AverageAreaSoldPriceResponse> GetAverageAreaSoldPrice(StandardLocationParameters locationParams)
        {
            string url = Endpoints.AVERAGE_AREA_SOLD_PRICE + "?api_key=" + _accessToken;

            url += locationParams.GetUrlParams();

            return _httpClient.GetObject<AverageAreaSoldPriceResponse>(url);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="options">OutputType on options can only be TOWN, OUTCODE, COUNTY, or COUNTRY</param>
        /// <returns></returns>
        public Task<ZedIndexResponse> GetZedIndex(StandardLocationParameters locationParams)
        {
            string url = Endpoints.ZED_INDEX + "?api_key=" + _accessToken;

            url += locationParams.GetUrlParams();

            return _httpClient.GetObject<ZedIndexResponse>(url);
        }

        public Task<ZedIndicesResponse> GetZedIndices(StandardLocationParameters locationParams, ZedIndicesOptions options)
        {
            string url = Endpoints.ZED_INDICES + "?api_key=" + _accessToken;

            url += locationParams.GetUrlParams();
            url += options.GetUrlParams();

            return _httpClient.GetObject<ZedIndicesResponse>(url);
        }

        public Task<AreaValueGraphResponse> GetAreaValueGraphs(StandardLocationParameters locationParams, AreaValueGraphOptions options)
        {
            string url = Endpoints.AREA_VALUE_GRAPHS + "?api_key=" + _accessToken;

            url += locationParams.GetUrlParams();
            url += options.GetUrlParams();

            return _httpClient.GetObject<AreaValueGraphResponse>(url);
        }

        public Task<SessionResponse> GetSessionId()
        {
            string url = Endpoints.SESSION_ID + "?api_key=" + _accessToken;

            return _httpClient.GetObject<SessionResponse>(url);
        }

        //public Task<string> GetRefineEstimate()
        //{
        //    string url = Endpoints.REFINE_ESTIMATE + "?api_key=" + _accessToken;

        //    throw new NotImplementedException();
        //}

        public Task<ArrangeViewing> ArrangeViewing(ArrangeViewingOptions options)
        {
            string url = Endpoints.ARRANGE_VIEWING + "?api_key=" + _accessToken;

            url += options.GetUrlString();

            return _httpClient.GetObject<ArrangeViewing>(url);
        }

        //public Task<LocalInfoGraphs> GetLocalInfoGraphs(StandardAreaOptions options)
        //{
        //    string url = Endpoints.LOCAL_INFO_GRAPHS + "?api_key=" + _accessToken;

        //    url += options.GetUrlString();

        //    return _httpClient.GetObject<LocalInfoGraphs>(url);
        //}

        //public Task<string> GetGeoAutocomplete()
        //{
        //    string url = Endpoints.GEO_AUTOCOMPLETE + "?api_key=" + _accessToken;

        //    throw new NotImplementedException();
        //}
    }
}
