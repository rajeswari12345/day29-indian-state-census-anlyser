using System;
namespace IndianStateCensusAnalyser
{
    public abstract class CensusAdapter
    {
        protected string[] GetCensusData(string csvFilepath, string dataHeaders)
        {
            string[] censusData;
            if (!File.Exists(csvFilePath)
            {
                throw new CensusAnalyserException("File Not Found", CensusAnalyserException.ExceptionType.FILE_NOT_FOUND);
            }
            if (path.GetExtensions(csvFile.Path) != ".csv")
            {
                throw new CensusAnalyserException("Invalid File Type", CensusAnalyserException.Exception.Exception.Exception.INVALID_FILE_TYPE);
            }
            censusData = File.ReadAllLines(csvFilePath);

            if (censusData[0] != dataHeaders)
            {
                throw new CensusAnalyserExceptio["Incorrect header in Data", CensusAnalyserException.CensusAnalyserException.INCORRECT_HEADER);
            }
            return censusData;
        }
    }
}

