using System.ComponentModel;
using Newtonsoft.Json;

namespace consumerQlola.Models.DTO;

public class OverbookingRequest
{
    [JsonProperty("tranType", NullValueHandling = NullValueHandling.Ignore)]
    [System.ComponentModel.DefaultValue(null)]
    public string? TranType { get; set; }

    [JsonProperty("channelId", NullValueHandling = NullValueHandling.Ignore)]
    [System.ComponentModel.DefaultValue(null)]
    public string? ChannelId { get; set; }

    [JsonProperty("accountDebit", NullValueHandling = NullValueHandling.Ignore)]
    [System.ComponentModel.DefaultValue(null)]
    public string? AccountDebit { get; set; }

    [JsonProperty("currencyDebit", NullValueHandling = NullValueHandling.Ignore)]
    [System.ComponentModel.DefaultValue(null)]
    public string? CurrencyDebit { get; set; }

    [JsonProperty("accountCredit", NullValueHandling = NullValueHandling.Ignore)]
    [System.ComponentModel.DefaultValue(null)]
    public string? AccountCredit { get; set; }

    [JsonProperty("currencyCredit", NullValueHandling = NullValueHandling.Ignore)]
    [System.ComponentModel.DefaultValue(null)]
    public string? CurrencyCredit { get; set; }

    [JsonProperty("amountTrx", NullValueHandling = NullValueHandling.Ignore)]
    [System.ComponentModel.DefaultValue(null)]
    public double? AmountTrx { get; set; }

    [JsonProperty("amountFee", NullValueHandling = NullValueHandling.Ignore)]
    [System.ComponentModel.DefaultValue(null)]
    public double? AmountFee { get; set; }

    [JsonProperty("accountFee", NullValueHandling = NullValueHandling.Ignore)]
    [System.ComponentModel.DefaultValue(null)]
    public string? AccountFee { get; set; }

    [JsonProperty("remark", NullValueHandling = NullValueHandling.Ignore)]
    [System.ComponentModel.DefaultValue(null)]
    public string? Remark { get; set; }

    [JsonProperty("tellerId", NullValueHandling = NullValueHandling.Ignore)]
    [System.ComponentModel.DefaultValue(null)]
    public string? TellerId { get; set; }

    [JsonProperty("uniqueId", NullValueHandling = NullValueHandling.Ignore)]
    [System.ComponentModel.DefaultValue(null)]
    public string? UniqueId { get; set; }
}