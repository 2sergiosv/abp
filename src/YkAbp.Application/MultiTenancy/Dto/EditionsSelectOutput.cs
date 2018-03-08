using System.Collections.Generic;
using YkAbp.Application.Editions.Dto;

namespace YkAbp.Application.MultiTenancy.Dto
{
    public class EditionsSelectOutput
    {
        public EditionsSelectOutput()
        {
            AllFeatures = new List<FlatFeatureSelectDto>();
            EditionsWithFeatures = new List<EditionWithFeaturesDto>();
        }

        public List<FlatFeatureSelectDto> AllFeatures { get; set; }

        public List<EditionWithFeaturesDto> EditionsWithFeatures { get; set; }

        public int? TenantEditionId { get; set; }
    }
}
