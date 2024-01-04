using Newtonsoft.Json;

namespace consumerQlola.Models.DTO;

public class OverbookingResult
{
    [JsonProperty("abcsOvbInternal", NullValueHandling = NullValueHandling.Ignore)]
    public OverBookingResponse? AbcsOvbInternal { get; set; }
   // public OvbInqTrrefnResponse? abcsOvbInqTrrefn { get; set; }
   // public OverBookingResponse? abcsReversal { get; set; }
}