using Microsoft.AspNetCore.Mvc.ApplicationModels;
using Microsoft.AspNetCore.Mvc.Routing;
using System.Linq;

namespace OrgChart.API.Extensions
{
    public class ApiGlobalRoutePrefix : IApplicationModelConvention
    {

        #region [Fields]

        /// <summary>
        /// The AttributeRouteModel.
        /// </summary>
        private readonly AttributeRouteModel _centralPrefix;

        #endregion

        #region [Constructors]

        /// <summary>
        ///  Initializes a new instance of the <see cref="ApiGlobalRoutePrefix" /> class.
        /// </summary>
        /// <param name="routeTemplateProvider">The IRouteTemplateProvider.</param>
        public ApiGlobalRoutePrefix(IRouteTemplateProvider routeTemplateProvider)
        {
            _centralPrefix = new AttributeRouteModel(routeTemplateProvider);
        }

        #endregion

        #region [Methods]

        /// <summary>
        /// Register Prefix Routes to All Controller.
        /// </summary>
        /// <param name="application">The ApplicationModel.</param>
        public void Apply(ApplicationModel application)
        {
            foreach (var controller in application.Controllers)
            {
                var matchedSelectors = controller.Selectors.Where(x => x.AttributeRouteModel != null).ToList();
                if (matchedSelectors.Any())
                {
                    foreach (var selectorModel in matchedSelectors)
                    {
                        selectorModel.AttributeRouteModel = AttributeRouteModel.CombineAttributeRouteModel(_centralPrefix,
                            selectorModel.AttributeRouteModel);
                    }
                }

                var unmatchedSelectors = controller.Selectors.Where(x => x.AttributeRouteModel == null).ToList();
                if (unmatchedSelectors.Any())
                {
                    foreach (var selectorModel in unmatchedSelectors)
                    {
                        selectorModel.AttributeRouteModel = _centralPrefix;
                    }
                }
            }
        }

        #endregion

    }
}
