// Copyright (c) 2014 - 2016 George Kimionis
// See the accompanying file LICENSE for the Software License Aggrement

using System.Collections.Generic;
using BitcoinLib.Responses.Bridges;
using BitcoinLib.Responses.SharedComponents;

namespace BitcoinLib.Responses
{
    public class GetMempoolEntryResponse : ITransactionResponseMempool
    { 
        public decimal Modifiedfee { get; set; }
        public decimal Fee { get; set; }
        public long vsize { get; set; }
        public string WTxId { get; set; }
    }
}
