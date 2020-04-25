// Copyright (c) 2014 - 2016 George Kimionis
// See the accompanying file LICENSE for the Software License Aggrement

using System.Collections.Generic;
using BitcoinLib.Responses.Bridges;
using BitcoinLib.Responses.SharedComponents;

namespace BitcoinLib.Responses
{
    public class GetMempoolEntryResponse : ITransactionResponseMempool
    { 
        public Fees fees { get; set; }
        public long vsize { get; set; }
        public long weight { get; set; }
        public decimal fee { get; set; }
        public decimal modifiedfee { get; set; }
        public int height { get; set; }
        public int descendantcount { get; set; }
        public long descendantsize { get; set; }
        public long descendantfees { get; set; }
        public int ascendantcount { get; set; }
        public long ascendantsize { get; set; }
        public long ascendantfees { get; set; }        
        public string wtxid { get; set; }
        public string[] depends { get; set; }
        public string[] spentby { get; set; }
    }
    
    public class Fees
    {
        public decimal base { get; set; }
        public decimal modified { get; set; }
        public decimal ancestor { get; set; }
        public decimal descendant { get; set; }
    }
}
