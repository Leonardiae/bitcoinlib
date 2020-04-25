// Copyright (c) 2014 - 2016 Leonard
// See the accompanying file LICENSE for the Software License Aggrement

namespace BitcoinLib.Responses.Bridges
{
    //  Note: This serves as a common interface for the cases that a strongly-typed response is required while it is not yet clear whether the transaction in question is in-wallet or not 
    //  A practical example is the bridging of GetTransaction(), DecodeRawTransaction() and GetRawTransaction()
    public interface ITransactionResponseMempool
    {
        string wtxid { get; set; }
    }
}
