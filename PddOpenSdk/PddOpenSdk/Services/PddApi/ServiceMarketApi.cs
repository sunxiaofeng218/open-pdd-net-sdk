
using System.Threading.Tasks;
using PddOpenSdk.Models.Request.ServiceMarket;
using PddOpenSdk.Models.Response.ServiceMarket;
namespace PddOpenSdk.Services.PddApi
{
    public class ServiceMarketApi : PddCommonApi
    {
        public ServiceMarketApi() { }
        public ServiceMarketApi(string clientId, string clientSecret, string accessToken) : base(clientId, clientSecret, accessToken) { }
        /// <summary>
        /// 服务市场订单履约查询
        /// </summary>
        public async Task<SearchServicemarketContractResponseModel> SearchServicemarketContractAsync(SearchServicemarketContractRequestModel searchServicemarketContract)
        {
            var result = await PostAsync<SearchServicemarketContractRequestModel, SearchServicemarketContractResponseModel>("pdd.servicemarket.contract.search", searchServicemarketContract);
            return result;
        }
        /// <summary>
        /// 月结算账单导出
        /// </summary>
        public async Task<GetServicemarketSettlementbillResponseModel> GetServicemarketSettlementbillAsync(GetServicemarketSettlementbillRequestModel getServicemarketSettlementbill)
        {
            var result = await PostAsync<GetServicemarketSettlementbillRequestModel, GetServicemarketSettlementbillResponseModel>("pdd.servicemarket.settlementbill.get", getServicemarketSettlementbill);
            return result;
        }
        /// <summary>
        /// 交易明细单导出
        /// </summary>
        public async Task<GetServicemarketTradelistResponseModel> GetServicemarketTradelistAsync(GetServicemarketTradelistRequestModel getServicemarketTradelist)
        {
            var result = await PostAsync<GetServicemarketTradelistRequestModel, GetServicemarketTradelistResponseModel>("pdd.servicemarket.tradelist.get", getServicemarketTradelist);
            return result;
        }
        /// <summary>
        /// 线上服务市场订单查询接口
        /// </summary>
        public async Task<SearchVasOrderResponseModel> SearchVasOrderAsync(SearchVasOrderRequestModel searchVasOrder)
        {
            var result = await PostAsync<SearchVasOrderRequestModel, SearchVasOrderResponseModel>("pdd.vas.order.search", searchVasOrder);
            return result;
        }

    }
}
