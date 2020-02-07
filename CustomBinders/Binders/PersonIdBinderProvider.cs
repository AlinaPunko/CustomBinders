using System;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace CustomBinders.Binders
{
    public class PersonIdBinderProvider : IModelBinderProvider
    {
        private readonly IModelBinder binder = new PersonIdBinder();

        public IModelBinder GetBinder(ModelBinderProviderContext context)
        {
            return context.Metadata.ModelType == typeof(Guid) ? binder : null;
        }
    }
}

