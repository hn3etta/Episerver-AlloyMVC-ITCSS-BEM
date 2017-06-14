using AlloyMVC_ITCSS_BEM.Models.ViewModels;

namespace AlloyMVC_ITCSS_BEM.Business
{
    /// <summary>
    /// Defines a method which may be invoked by PageContextActionFilter allowing controllers
    /// to modify common layout properties of the view model.
    /// </summary>
    interface IModifyLayout
    {
        void ModifyLayout(LayoutModel layoutModel);
    }
}
