using Newtonsoft.Json;
namespace PddOpenSdk.Models.Response.Ad
{
    public partial class StatusAdApiUnitUpdateDataOperateResponseModel : PddResponseModel
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("response")]
        public ResponseResponseModel Response { get; set; }
        public partial class ResponseResponseModel : PddResponseModel
        {
            /// <summary>
            /// 
            /// </summary>
            [JsonProperty("errorCode")]
            public int? ErrorCode { get; set; }
            /// <summary>
            /// 
            /// </summary>
            [JsonProperty("errorMsg")]
            public string ErrorMsg { get; set; }
            /// <summary>
            /// 是否更新成功
            /// </summary>
            [JsonProperty("result")]
            public bool? Result { get; set; }
            /// <summary>
            /// 
            /// </summary>
            [JsonProperty("success")]
            public bool? Success { get; set; }

        }

    }

}
