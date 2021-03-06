using Newtonsoft.Json;

namespace CloudBankTester
{
    public class ReceiptDetail
    {
        //Fields
        [JsonProperty("nn.sn")]
        public string nnsn { get; set; }

        [JsonProperty("status")]
        public string status { get; set; }

        [JsonProperty("pown")]
        public string pown { get; set; }

        [JsonProperty("note")]
        public string note { get; set; }


        //Constructors
        public ReceiptDetail()
        {

        }//end of constructor

        public ReceiptDetail(string nnsn, string status, string pown, string note)
        {
            this.nnsn = nnsn;
            this.status = status;
            this.pown = pown;
            this.note = note;

        }//end of constructor

    }//End Class
}//End Namespace
