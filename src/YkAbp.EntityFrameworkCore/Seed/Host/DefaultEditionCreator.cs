using System.Linq;
using Abp.Application.Features;
using Microsoft.EntityFrameworkCore;
using YkAbp.Core.Editions;
#if FEATURE_SIGNALR
using YkAbp.Core.Features;
#endif

namespace YkAbp.EntityFrameworkCore.Seed.Host
{
    public class DefaultEditionCreator
    {
        private readonly YkAbpDbContext _context;

        public DefaultEditionCreator(YkAbpDbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            CreateEditions();
        }

        private void CreateEditions()
        {
            var defaultEdition = _context.Editions.IgnoreQueryFilters().FirstOrDefault(e => e.Name == EditionManager.DefaultEditionName);
            if (defaultEdition == null)
            {
                defaultEdition = new SubscribableEdition { Name = EditionManager.DefaultEditionName, DisplayName = EditionManager.DefaultEditionName };
                _context.Editions.Add(defaultEdition);
                _context.SaveChanges();

                // TODO: Add desired features to the standard edition, if wanted... 
            }

#if FEATURE_SIGNALR
            if (defaultEdition.Id > 0)
            {
                CreateFeatureIfNotExists(defaultEdition.Id, AppFeatures.ChatFeature, true);
                CreateFeatureIfNotExists(defaultEdition.Id, AppFeatures.TenantToTenantChatFeature, true);
                CreateFeatureIfNotExists(defaultEdition.Id, AppFeatures.TenantToHostChatFeature, true);
            }
#endif
        }

        private void CreateFeatureIfNotExists(int editionId, string featureName, bool isEnabled)
        {
            var defaultEditionChatFeature = _context.EditionFeatureSettings.IgnoreQueryFilters()
                                                        .FirstOrDefault(ef => ef.EditionId == editionId && ef.Name == featureName);

            if (defaultEditionChatFeature == null)
            {
                _context.EditionFeatureSettings.Add(new EditionFeatureSetting
                {
                    Name = featureName,
                    Value = isEnabled.ToString(),
                    EditionId = editionId
                });
            }
        }
    }
}