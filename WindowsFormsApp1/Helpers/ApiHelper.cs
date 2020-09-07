using System.Net.Http;

namespace WindowsFormsApp1.Helpers
{
    public class ApiHelper
    {
        public static HttpClient ApiClient { get; set; }

        public static void InitializeClient()
        {
            ApiClient = new HttpClient();
            ApiClient.DefaultRequestHeaders.Accept.Clear();
            ApiClient.DefaultRequestHeaders.Add("Accept", "application/json");
            ApiClient.DefaultRequestHeaders.Add("Authorization", "Bearer eyJ0eXAiOiJKV1QiLCJhbGciOiJSUzI1NiJ9.eyJhdWQiOiIxIiwianRpIjoiZjMzNTkwZmJmYjZhNmNkNWVlNTkzZWViYWJiMDY5MmVmNTE4NjZlZmJhYTlmMGJjNzYzMGI3YTQzNWMxMmVlYzRmZTU0YjQyNTM3YmY0MzkiLCJpYXQiOjE1NzgxMDg3OTAsIm5iZiI6MTU3ODEwODc5MCwiZXhwIjoxNjA5NzMxMTkwLCJzdWIiOiIxIiwic2NvcGVzIjpbXX0.B1o4xFavLqvNAkp0Cvp0HW4rrJLkxuuEQenY7mMlZ45K9fr_Y3HbLr_JANmTj90j0xLcoUWt2mCzQiYnMI5r0-eH9kfmLZijHaJKUkmUq8vSLRf5b929sNW0fOCxFLgxAk1VAx4EEwjO8TNOX64UO6ZKqhnhkRZxu5R5xv3zDnduRurAd7-ynQwcbxUK0QEARroxMMUlTXZNsUPKEDsMO2uxURsPOCnXWAMNNZaIvMKB7bHZqhz-xD4-cFa6HLsaFChYNbI8Lg5YbnMuH6DOVPwgPWtjmj_3wO8Ie07N4-_CnfE_-sc4xrQzR8p0hx5nuHZ9t_UDpNjfgWhcBLph2Jq1WcGWLc6_ReoPZqTntNAtbIgFu5urCNNMeguicc_EehnUR_gZRzNZDwLjZWGdYIee3dXJguxNn88imEZQL_x9pjUP9RFBXGTELzBOqof1V-5848Er7D_abCCYN_ivAN0cU-xKbmBDkuZxjr2B3oApDXg1KsGGecNGq3I0nEBqaxoqyl8IMbegBTfxJmc7HelAOteqftTOCuf9QJk_V_vhpbo_sM6V15HujhhvMRtRha8dRNN9cw8IGVX6n327E5_ZtFeD4IE6S4Ki4UOSTQiANnN7iwnKSX2xMXaQj4w3gxTVgNEy7Nk9_80el41KIGYBLrzT3j8fst5hrMDx2tU");
        }
    }
}
