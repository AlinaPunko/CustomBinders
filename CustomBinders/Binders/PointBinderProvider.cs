using CustomBinders.Models;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace CustomBinders.Binders
{
    public class PointBinderProvider : IModelBinderProvider
    {
        private readonly IModelBinder binder = new PointBinder();

        public IModelBinder GetBinder(ModelBinderProviderContext context)
        {
            return context.Metadata.ModelType == typeof(Point) ? binder : null;
        }
    }
}
