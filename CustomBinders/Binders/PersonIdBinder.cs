using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace CustomBinders.Binders
{
    public class PersonIdBinder : IModelBinder
    {
        public Task BindModelAsync(ModelBindingContext bindingContext)
        {
            if (bindingContext == null)
            {
                throw new ArgumentNullException(nameof(bindingContext));
            }

            string encodedId = bindingContext.ValueProvider.GetValue("id").FirstValue;
            string decodedId = Base64Decode(encodedId);
            bindingContext.Result = ModelBindingResult.Success(new Guid(decodedId));
            return  Task.CompletedTask;
        }

        public static string Base64Decode(string base64EncodedData)
        {
            byte[] base64EncodedBytes = Convert.FromBase64String(base64EncodedData);
            return System.Text.Encoding.UTF8.GetString(base64EncodedBytes);
        }
    }
}
