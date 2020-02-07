using System;
using System.Threading.Tasks;
using CustomBinders.Models;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace CustomBinders.Binders
{
    public class PointBinder : IModelBinder
    {
        public Task BindModelAsync(ModelBindingContext bindingContext)
        {
            if (bindingContext == null)
            {
                throw new ArgumentNullException(nameof(bindingContext));
            }

            var coordinatesArray = bindingContext.ValueProvider.GetValue("coord").FirstValue.Split(",");

            if (!int.TryParse(coordinatesArray[0], out var xCoordinate) ||
                !int.TryParse(coordinatesArray[1], out var yCoordinate) ||
                !int.TryParse(coordinatesArray[2], out var zCoordinate))
            {
                return null;
            }

            bindingContext.Result = ModelBindingResult.Success(new Point(xCoordinate, yCoordinate, zCoordinate));
            return Task.CompletedTask;
        }
    }
}
