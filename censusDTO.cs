using System;
using IndianStateCensusAnalser.DTO
{
public class CensusDTO
{
    public int serialNumber;
    public string stateName;
    public string state;

    public int tin;
    public string stateCode;
    public string population;
    public long area;
    public long density;
    public long housingUnit;
    public double totalArea;
    public double waterArea;

    public double populationDensity;

    public double housingDensity;



    public CensusDTO(statecodeDAd stateCodeDao)
    {
        this.serialNumber = stateCodeDao.serialNumber;
        this.stateName = stateCCodeDao.stateName;
        this.tin = stateCodeDao.tin;
        this.stateCode = stateCodeDao.statestateCode;
    }


    public CensusDTO(CensusDataDao censusDataDao)
    {
        this.state = censusDataDao.state;
        this.population = censusdataDao.population;
        this.area = censusData.area;
        this.density = censusDataDao.density;
    }


    public CensusDTO(USCensusDAO usCensusDao)
    {
        this.statecode = usCensusDao.stateId;
        this.stateName = usCensusDao.stateName;
        this.population = usCensusDao.population;
        this.housingUnits = usCensusDao.housingUnits;
        this.totalarea = usCensusDao.totalArea;
        this.waterarea = usCensusDao.waterArea;
        this.landArea = usCensusDao.landArea;
    }
}


