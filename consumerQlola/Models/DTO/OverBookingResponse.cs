using Newtonsoft.Json;

namespace consumerQlola.Models.DTO;

public class OverBookingResponse
{
    [JsonProperty("statusCode", NullValueHandling = NullValueHandling.Ignore)]
    [DefaultValue(null)]
    public int? StatusCode { get; set; }

    [JsonProperty("statusDesc", NullValueHandling = NullValueHandling.Ignore)]
    [DefaultValue(null)]
    public string? StatusDesc { get; set; }

    [JsonProperty("accountDebit", NullValueHandling = NullValueHandling.Ignore)]
    [DefaultValue(null)]
    public string? AccountDebit { get; set; }

    [JsonProperty("nameDebit", NullValueHandling = NullValueHandling.Ignore)]
    [DefaultValue(null)]
    public string? NameDebit { get; set; }

    [JsonProperty("statusDebit", NullValueHandling = NullValueHandling.Ignore)]
    [DefaultValue(null)]
    public string? StatusDebit { get; set; }

    [JsonProperty("accountCredit", NullValueHandling = NullValueHandling.Ignore)]
    [DefaultValue(null)]
    public string? AccountCredit { get; set; }

    [JsonProperty("nameCredit", NullValueHandling = NullValueHandling.Ignore)]
    [DefaultValue(null)]
    public string? NameCredit { get; set; }

    [JsonProperty("statusCredit", NullValueHandling = NullValueHandling.Ignore)]
    [DefaultValue(null)]
    public string? StatusCredit { get; set; }

    [JsonProperty("amountTrx", NullValueHandling = NullValueHandling.Ignore)]
    [DefaultValue(null)]
    public string? AmountTrx { get; set; }

    [JsonProperty("remark", NullValueHandling = NullValueHandling.Ignore)]
    [DefaultValue(null)]
    public string? Remark { get; set; }

    [JsonProperty("dateTrx", NullValueHandling = NullValueHandling.Ignore)]
    [DefaultValue(null)]
    public string? DateTrx { get; set; }

    [JsonProperty("journalSeq", NullValueHandling = NullValueHandling.Ignore)]
    public string JournalSeq { get; set; }

    [JsonProperty("trrefn", NullValueHandling = NullValueHandling.Ignore)]
    public string Trrefn { get; set; }

    [JsonProperty("currencyDebit", NullValueHandling = NullValueHandling.Ignore)]
    [DefaultValue(null)]
    public string? CurrencyDebit { get; set; }

    [JsonProperty("currencyCredit", NullValueHandling = NullValueHandling.Ignore)]
    [DefaultValue(null)]
    public string? CurrencyCredit { get; set; }

    [JsonProperty("tellerId", NullValueHandling = NullValueHandling.Ignore)]
    [DefaultValue(null)]
    public string? TellerId { get; set; }

    [JsonProperty("amountDebited", NullValueHandling = NullValueHandling.Ignore)]
    [DefaultValue(null)]
    public string? AmountDebited { get; set; }

    [JsonProperty("amountCredited", NullValueHandling = NullValueHandling.Ignore)]
    [DefaultValue(null)]
    public string? AmountCredited { get; set; }

    [JsonProperty("tranType", NullValueHandling = NullValueHandling.Ignore)]
    [DefaultValue(null)]
    public string? TranType { get; set; }

    [JsonProperty("channelId", NullValueHandling = NullValueHandling.Ignore)]
    [DefaultValue(null)]
    public string? ChannelId { get; set; }

    [JsonProperty("amountFee", NullValueHandling = NullValueHandling.Ignore)]
    [DefaultValue(null)]
    public string? AmountFee { get; set; }

    [JsonProperty("recordStatus", NullValueHandling = NullValueHandling.Ignore)]
    [DefaultValue(null)]
    public string? RecordStatus { get; set; }

    [JsonProperty("uniqueId", NullValueHandling = NullValueHandling.Ignore)]
    [DefaultValue(null)]
    public string? UniqueId { get; set; }
}