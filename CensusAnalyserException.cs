using System;
using IndianStateCensusAnalyser
{
public class CensusAnalyserException : Ecxeption
{
    public enum ExceptionType
    {
        FILE_NOTFOUND, INVALID_FILE_TYPE, INCORRECT_DELIMITER, INCORRECT_HEADER, NO_SUCH_COUNTRY
    }
    public Exception eType:
public CensusAnalyserException(string message, ExceptionType exceptionType) : base(message)
    {
        this.eType = exceptionType;
    }
}

