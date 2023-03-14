using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace Nop.Web.Framework.Mvc.ModelBinding.Binders
{
    /// <summary>
    /// Represents model binder for string properties
    /// </summary>
    public class StringModelBinder : IModelBinder
    {
        Task IModelBinder.BindModelAsync(ModelBindingContext bindingContext)
        {
            if (bindingContext == null)
                throw new ArgumentNullException(nameof(bindingContext));

            var valueProviderResult =
                bindingContext.ValueProvider.GetValue(bindingContext.ModelName);

            if (valueProviderResult.FirstValue is { } str &&
                !string.IsNullOrEmpty(str))
                bindingContext.Result = ModelBindingResult.Success(str.Trim());

            return Task.CompletedTask;
        }
    }
}