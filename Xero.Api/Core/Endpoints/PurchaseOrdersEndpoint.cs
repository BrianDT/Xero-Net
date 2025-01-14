﻿using System;
using Xero.Api.Core.Endpoints.Base;
using Xero.Api.Core.Model;
using Xero.Api.Core.Model.Status;
using Xero.Api.Core.Request;
using Xero.Api.Core.Response;
using Xero.Api.Infrastructure.Http;

namespace Xero.Api.Core.Endpoints
{
    public class PurchaseOrdersEndpoint : XeroCreateEndpoint<PurchaseOrdersEndpoint, PurchaseOrder, PurchaseOrdersRequest, PurchaseOrdersResponse>
    {
        public PurchaseOrdersEndpoint(XeroHttpClient client) :
            base(client, "/api.xro/2.0/PurchaseOrders")
        {
        }

        public PurchaseOrdersEndpoint Page(int page)
        {
            AddParameter("page", page);
            return this;
        }

        public PurchaseOrdersEndpoint Status(PurchaseOrderStatus status)
        {
            AddParameter("status", status.ToString().ToUpper());
            return this;
        }

        public PurchaseOrdersEndpoint DateFrom(DateTime dateFrom)
        {
            AddParameter("dateFrom", dateFrom.ToString("yyyy-MM-dd"));
            return this;
        }

        public PurchaseOrdersEndpoint DateTo(DateTime dateTo)
        {
            AddParameter("dateTo", dateTo.ToString("yyyy-MM-dd"));
            return this;
        }
    }
}
