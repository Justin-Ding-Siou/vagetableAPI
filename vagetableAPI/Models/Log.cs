
//------------------------------------------------------------------------------
// <auto-generated>
//     這個程式碼是由範本產生。
//
//     對這個檔案進行手動變更可能導致您的應用程式產生未預期的行為。
//     如果重新產生程式碼，將會覆寫對這個檔案的手動變更。
// </auto-generated>
//------------------------------------------------------------------------------


namespace vagetableAPI.Models
{

using System;
    using System.Collections.Generic;
    
public partial class Log
{

    public string account { get; set; }

    public string food_name { get; set; }

    public int fridge_id { get; set; }

    public System.DateTime buy_time { get; set; }

    public int price { get; set; }

    public string type { get; set; }



    public virtual Food Food { get; set; }

    public virtual Member Member { get; set; }

}

}