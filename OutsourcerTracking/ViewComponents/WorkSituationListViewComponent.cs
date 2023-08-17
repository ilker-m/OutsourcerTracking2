using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;
using OutsourcerTracking.Labels.Business.Abstract;
using OutsourcerTracking.Models.ViewComponentModels;

namespace OutsourcerTracking.ViewComponents
{
    public class WorkSituationListViewComponent : ViewComponent
    {
        private readonly ISituationService _situationService;
        public WorkSituationListViewComponent(ISituationService situationService)
        {
            _situationService = situationService;
        }
        public ViewViewComponentResult Invoke()
        {
            var model = new WorkSituationListViewComponentModel
            {
                Situations = _situationService.GetAll()
            };
            return View(model);
        }
    }
}
