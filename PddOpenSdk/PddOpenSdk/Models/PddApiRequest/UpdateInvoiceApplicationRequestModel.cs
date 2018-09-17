using Newtonsoft.Json;
namespace PddOpenSdk.Models.PddApiRequest
{
    public partial class UpdateInvoiceApplicationRequestModel : PddRequestModel
    {
        /// <summary>
        /// 申请流水号
        /// </summary>
        [JsonProperty("application_id")]
        public int ApplicationId { get; set; }
        /// <summary>
        /// 订单号
        /// </summary>
        [JsonProperty("order_sn")]
        public object OrderSn { get; set; }
        /// <summary>
        /// 审核结果：0 = 拒绝，2 = 同意
        /// </summary>
        [JsonProperty("status")]
        public int Status { get; set; }
        /// <summary>
        /// 驳回原因，status=0必填
        /// </summary>
        [JsonProperty("reason")]
        public object Reason { get; set; }

    }
}
