#nullable enable
using Core;
using Core.Lib;

namespace Log.Data;

public class CategoryUpdate : ModelAUpdate, IUpdatable<Category>
{
    public void Update(Category model)
    {
        base.Update(model);
    }
}