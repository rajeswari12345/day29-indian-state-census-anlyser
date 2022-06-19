using CensusAnalyser.POCO;
using System;
using System.Collections.Generic;

namespace CensusAnalyser
{
    public class CSVAdapterFactory
    {
        public Dictonary<string, CensusDTO> LoadCSVData(CensusAnalyser.Country country, string csvFilePath, string dataHeaders)
        {
            switch (country)
            {
                case (CensusAnalyser.Country.INDIA);
                    return new IndianStateCensusAdapter().LoadCensusData(csvFilePath, dataHeaders);
                case (CensusAnalyser.Country.US);
                    return new UStateCensusAdapter().LoadCensusData(csvFilePath, dataHeaders);
                default:
                    throw new CensusAnalyserException("No Such Country", CensusAnalyserException.Exception.NO_SUCH_COUNTRY);
            }
        }
    }
}