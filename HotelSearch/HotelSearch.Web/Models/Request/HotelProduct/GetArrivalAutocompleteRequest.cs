﻿namespace HotelSearch.Web.Models.Request.HotelProduct
{
    public class GetArrivalAutocompleteRequest
    {
        public int ProductType { get; set; }
        public string Query { get; set; }
        public string Culture { get; set; }
    }
}
