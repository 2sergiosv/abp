using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using YkAbp.Application.MultiTenancy.HostDashboard.Dto;

namespace YkAbp.Application.MultiTenancy.HostDashboard
{
    public interface IIncomeStatisticsService
    {
        Task<List<IncomeStastistic>> GetIncomeStatisticsData(DateTime startDate, DateTime endDate,
            ChartDateInterval dateInterval);
    }
}