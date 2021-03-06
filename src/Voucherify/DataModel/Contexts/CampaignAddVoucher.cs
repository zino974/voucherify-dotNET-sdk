﻿#if VOUCHERIFYSERVER
using Newtonsoft.Json;
using Voucherify.Core.DataModel;

namespace Voucherify.DataModel.Contexts
{
    [JsonObject]
    public class CampaignAddVoucher
    {
        [JsonProperty(PropertyName = "additional_info")]
        public string AdditionalInfo { get; set; }

        [JsonProperty(PropertyName = "code")]
        public string Code { get; set; }

        [JsonProperty(PropertyName = "redemption")]
        public VoucherRedemption VoucherRedemption { get; set; }

        [JsonProperty(PropertyName = "metadata")]
        public Metadata Metadata { get; set; }

        public CampaignAddVoucher()
        {
           this. Metadata = new Metadata();
        }
    }
}
#endif