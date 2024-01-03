using System.ComponentModel;
using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace publisher.Models.DTO;

public class OverbookingRequest
{
    [JsonProperty("tranType", NullValueHandling = NullValueHandling.Ignore)]
    [DefaultValue(null)]
    public string? TranType { get; set; }

    [JsonProperty("channelId", NullValueHandling = NullValueHandling.Ignore)]
    [DefaultValue(null)]
    public string? ChannelId { get; set; }

    [JsonProperty("accountDebit", NullValueHandling = NullValueHandling.Ignore)]
    [DefaultValue(null)]
    public string? AccountDebit { get; set; }

    [JsonProperty("currencyDebit", NullValueHandling = NullValueHandling.Ignore)]
    [DefaultValue(null)]
    public string? CurrencyDebit { get; set; }

    [JsonProperty("accountCredit", NullValueHandling = NullValueHandling.Ignore)]
    [DefaultValue(null)]
    public string? AccountCredit { get; set; }

    [JsonProperty("currencyCredit", NullValueHandling = NullValueHandling.Ignore)]
    [DefaultValue(null)]
    public string? CurrencyCredit { get; set; }

    [JsonProperty("amountTrx", NullValueHandling = NullValueHandling.Ignore)]
    [DefaultValue(null)]
    public double? AmountTrx { get; set; }

    [JsonProperty("amountFee", NullValueHandling = NullValueHandling.Ignore)]
    [DefaultValue(null)]
    public double? AmountFee { get; set; }

    [JsonProperty("accountFee", NullValueHandling = NullValueHandling.Ignore)]
    [DefaultValue(null)]
    public string? AccountFee { get; set; }

    [JsonProperty("remark", NullValueHandling = NullValueHandling.Ignore)]
    [DefaultValue(null)]
    public string? Remark { get; set; }

    [JsonProperty("tellerId", NullValueHandling = NullValueHandling.Ignore)]
    [DefaultValue(null)]
    public string? TellerId { get; set; }

    [JsonProperty("uniqueId", NullValueHandling = NullValueHandling.Ignore)]
    [DefaultValue(null)]
    public string? UniqueId { get; set; }
}