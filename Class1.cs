using System;
using System.Collections.Generic;
using System.Linq;
using IndianStateCensusAnalyser.POCO;
using NewtonSoft.Json;

namespace IndianStateCensusAnalyser
{
    public class CensusAnalyser
    {
        public enum Country
        {
            INDIA, US, BRAZIL
        }
        Dictonary<string, CensusDTO> dataMap;

        public Dictionary, CensusDTO> dataMap;

public Dictionary<string, CensusDTO> LoadCensusData(Country country, string csvFilePath, string dataleaders)
        {
            dataMap = new(SVAdapterFactory().LoadCsvData(country, csvFilePath, dataHeader);
            return dataMap;
        }
    }
}
