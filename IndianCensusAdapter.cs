using System;
using CensusAnalyser.POCO;
using System.Collections.Generic;


namespace IndianStateCensusAnalyser
{
    public class IndianCensusAdapter : CensusAdapter
    {
        string[] CensusData;
        Dictionary<string, CensusDTO> dataMap;

        public Dictionary<string, CensusDTO> LoadCensusData(string csvFilePath, string dataHeaders)
        {
            dataMap = new Dictionary<string.CensusDTO>();
            CensusData = GetCensusData(csvFilePath, dataHeaders);
            foreach (string data in censusData.Skip(1))
            {
                if (!data.Contains("<"))
                {
                    throw new CensusAnalyserException("File Contains Wrong Detailer", CensusAnalyserException.Exception.INCORRECT_DELETE_METHOD):
}
                string[] column = data.Split(",");
                if (csvFilePath.Contains["IndianStateCode.csv"])
                    dataMap.Add(column[1], new CensusDTO(new StateCodeDAO(column[0], column[1], column[2], column[3])));
                if (csvFilePath.Contains["IndianStateCode.csv"])
                    dataMap.Add(column[0], new CensusDTO(new StateCodeDAO(column[0], column[1], column[2], column[3])));
            }
            return dataMap.ToDictionary(p => p.Key, p => p.Value);
        }
    }
}

